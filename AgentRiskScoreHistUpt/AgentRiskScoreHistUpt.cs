using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentRiskScoreHistUpt.Shared;
using ManagerLib.Common;
using ManagerLib.Database;
using ManagerLib.Manager;
using ManagerLib.Models;
using ManagerLib.Query;
using System.Runtime.Serialization;

namespace AgentRiskScoreHistUpt
{
    //[Serializable]
    //internal class CustomException : Exception
    //{
    //    public CustomException()
    //    {
    //    }

    //    public CustomException(string message) : base(message)
    //    {
    //    }

    //    public CustomException(string message, Exception innerException) : base(message, innerException)
    //    {
    //    }

    //    protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
    //    {
    //    }
    //}

    public class AgentRiskScoreHistUpt
    {
        public static void Main(string[] args)
        {
            var dtStartJob = DateTime.Now;
            Int16 intArgCount = 1;
            try
            {
                using (var context = new CommonContext())
                {
                    using (var trx = context.Database.BeginTransaction())
                    {
                        var strJobId = "";
                        var strStepId = "";

                        ////1) Test Database Connection
                        if (!context.Database.Exists())
                            throw new Exception("Database connection failed");

                        ////2) Check input arguments
                        if (args.Length == 0)
                            throw new CustomException("Missing argusment(s): [JOB_ID] [STEP_ID]");
                        else
                            foreach (string arg in args)
                                {
                                if (intArgCount == 1)
                                    strJobId = arg;
                                else if (intArgCount == 2)
                                    strStepId = arg;
                                    
                                intArgCount += 1;
                                }

                        //test
                        var ConfigJob = new ConfigJobManager(context, GlobalVariables.AppSetting_CodeComp, GlobalVariables.AppSetting_CodeComp, GlobalVariables.AppSetting_UserId, strJobId, strStepId);
                        ConfigJob.InitProcess();

                        ////3) Init Batch Job
                        var BatchJob = new BatchJobManager(context, GlobalVariables.AppSetting_CodeComp, GlobalVariables.AppSetting_CodeComp, GlobalVariables.AppSetting_UserId, strJobId, strStepId);
                        BatchJob.InitProcess();
                        BatchJob.CheckProcessorType(20);

                        ////4) Process
                        var lsRiskModel = context.cor_code.Where(l => l.cor_CodeNo == GlobalVariables.AppSetting_Risk_Setting && l.cor_ValueF2 == GlobalVariables.AppSetting_Risk_Column_Table).FirstOrDefault();

                        if (lsRiskModel == null)    ////Check if risk model exists
                        {
                            BatchJobHelper.LogBatchError(context, GlobalVariables.AppSetting_CodeComp, strJobId, "Risk Model Setting"
                                                        , GlobalVariables.AppSetting_UserId, BatchJobError.Err_No_Risk_Model, GlobalVariables.AppSetting_Risk_Setting.ToString(), GlobalVariables.AppSetting_Risk_Column_Table.ToString());
                            context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                            , new SqlParameter("CompCode", GlobalVariables.AppSetting_CodeComp)
                                                                                            , new SqlParameter("JOB_ID", strJobId));
                            throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_No_Risk_Model, GlobalVariables.AppSetting_Risk_Setting.ToString(), GlobalVariables.AppSetting_Risk_Column_Table.ToString()));
                        }
                        else
                        {
                            var lsRiskFactors = context.cor_code.Where(l => l.cor_CodeNo == GlobalVariables.AppSetting_Risk_Column_Table).FirstOrDefault();

                            if (lsRiskFactors == null)    ////Check if risk factor(s) exists
                            {
                                BatchJobHelper.LogBatchError(context, GlobalVariables.AppSetting_CodeComp, strJobId, "Risk Factor(s) Setting"
                                                            , GlobalVariables.AppSetting_UserId, BatchJobError.Err_No_Risk_Model, GlobalVariables.AppSetting_Risk_Column_Table.ToString());
                                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                                , new SqlParameter("CompCode", GlobalVariables.AppSetting_CodeComp)
                                                                                                , new SqlParameter("JOB_ID", strJobId));
                                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_No_Risk_Model, GlobalVariables.AppSetting_Risk_Column_Table.ToString()));
                            }
                            else
                            {
                                var strParticipant_Filter = "";
                                if (!string.IsNullOrEmpty(GlobalVariables.AppSetting_Participant_Filter))
                                    strParticipant_Filter = System.Environment.NewLine + "and " + GlobalVariables.AppSetting_Participant_Filter;

                                ////Build Insert Statement
                                var strInsertStatement = BuildInsertStatement(context, GlobalVariables.AppSetting_SourceTable, GlobalVariables.AppSetting_TargetedTable
                                                                                , lsRiskModel.cor_CodeKey, BatchJob.strNewBatchNo, BatchJob.lsParam.CURRENT_PROCESS_DATE.ToString(), strParticipant_Filter);


                                ////Delete Risk Hist (prevent redundant record)
                                var strDeleteSql = AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.DeleteRiskHistByDate);
                                strDeleteSql = StringHelper.FormatString(strDeleteSql, new KeyValuePair<string, string>("strTargetedTable", GlobalVariables.AppSetting_TargetedTable));
                                context.Database.ExecuteSqlCommand(strDeleteSql, new SqlParameter("COMP_CODE", GlobalVariables.AppSetting_CodeComp)
                                                                                , new SqlParameter("RS_DATE", BatchJob.lsParam.CURRENT_PROCESS_DATE));

                                ////Insert Risk Hist
                                context.Database.ExecuteSqlCommand(strInsertStatement);

                                ////Update Previous Score
                                if (GlobalVariables.AppSetting_UpdatePreviousScoreInd == 1)
                                {
                                    var strUpdateStatement = AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.UpdatePreviousScore);
                                    strUpdateStatement = StringHelper.FormatString(strUpdateStatement
                                                                                    , new KeyValuePair<string, string>("strSourceTable", GlobalVariables.AppSetting_SourceTable)
                                                                                    , new KeyValuePair<string, string>("CurrentRiskScoreField", GlobalVariables.AppSetting_CurrentRiskScoreField)
                                                                                    , new KeyValuePair<string, string>("PreviousRiskScoreField", GlobalVariables.AppSetting_PreviousRiskScoreField)
                                                                                    , new KeyValuePair<string, string>("COMP_CODE", GlobalVariables.AppSetting_CodeComp.ToString())
                                                                                    , new KeyValuePair<string, string>("strParticipant_Filter", strParticipant_Filter));

                                    context.Database.ExecuteSqlCommand(strUpdateStatement);
                                }
                            }

                        }

                        ////5) End Batch Job
                        BatchJob.EndProcess(context, GlobalVariables.AppSetting_CodeComp, strJobId, dtStartJob, BatchJob.lsParam.CURRENT_PROCESS_DATE, BatchJob.strNewBatchNo, GlobalVariables.AppSetting_UserId);

                        trx.Commit();
                    }
                }
            }
            catch (CustomException ex)
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Exception: " + ex.Message);
            }
        }

        private static string BuildInsertStatement(CommonContext context, string strSourceTable, string strTargetTable, string strRiskModelKey, string strNewBatchNo, string strCurrentProcessDate, string strParticipant_Filter)
        {
            var strInsertStatement = "";
            var strSelectColumns = "";
            var strInsertColumns = "";
            var strInsertValues = "";
            var strCols_ACCOUNT_ONLY = "";

            ////Account
            if (GlobalVariables.AppSetting_RiskChangePartAt.ToLower() == "a")
            {
                strSelectColumns = "hdr.COMP_CODE, hdr.CIF_ID as CIF_NO, hdr.ACCOUNT_NO, hdr.PRODUCT_TYPE, hdr." + GlobalVariables.AppSetting_CurrentRiskScoreField + ", hdr." + GlobalVariables.AppSetting_PreviousRiskScoreField;
                strInsertColumns = "COMP_CODE, CIF_ID, RS_DATE, ACCOUNT_NO, PRODUCT_TYPE";
                strInsertValues = GlobalVariables.AppSetting_CodeComp.ToString() + " as COMP_CODE, ISNULL(RTrim(CIF_NO), '') as CIF_ID, " + strCurrentProcessDate + " as RS_DATE, ISNULL(RTrim(ACCOUNT_NO), '') as ACCOUNT_NO, ISNULL(RTrim(PRODUCT_TYPE), '') as PRODUCT_TYPE";

                strCols_ACCOUNT_ONLY = ", ACCOUNT_NO, PRODUCT_TYPE";
            }
            ////CIF
            else
            {
                strSelectColumns = "hdr.COMP_CODE, hdr.CIF_NO, hdr." + GlobalVariables.AppSetting_CurrentRiskScoreField + ", hdr." + GlobalVariables.AppSetting_PreviousRiskScoreField;
                strInsertColumns = "COMP_CODE, CIF_ID, RS_DATE, BATCH_NO, RISK_MODEL";
                strInsertValues = GlobalVariables.AppSetting_CodeComp.ToString() + " as COMP_CODE, ISNULL(RTrim(CIF_NO), '''') as CIF_ID, " + strCurrentProcessDate + " as RS_DATE, '" + strNewBatchNo + "' as BATCH_NO, " + strRiskModelKey + " as RISK_MODEL";
            }

            #region Statement Part 1

            ////Risk Factor Type 1 - Map by key (cor_CodeKey)
            var lsRiskFactors = context.cor_code.Where(l => l.cor_CodeNo == GlobalVariables.AppSetting_Risk_Column_Table && l.cor_ValueF2 == 1);
            var strSqlRiskFactorType1 = AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.BuildSql_RiskFactorType1);
            var lsSqlStatement = new List<string>();
            var cols_RSFDVALUE = new List<string>();
            var cols_RSFDSCORE = new List<string>();
            var cols_MAX_RSFDVALUE = new List<string>();
            var cols_SUM_RSFDSCORE = new List<string>();
            var cnt = 1;

            foreach (var rm in lsRiskFactors)
            {
                lsSqlStatement.Add(StringHelper.FormatString(strSqlRiskFactorType1, new KeyValuePair<string, string>("COMP_CODE", GlobalVariables.AppSetting_CodeComp.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_CodeNo", rm.cor_CodeNo.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_CodeKey", rm.cor_CodeKey)
                                                                                    , new KeyValuePair<string, string>("cor_Desc", rm.cor_Desc)
                                                                                    , new KeyValuePair<string, string>("cor_ValueF2", rm.cor_ValueF2.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_ValueI1", rm.cor_ValueI1.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_ValueT1", rm.cor_ValueT1)
                                                                                    , new KeyValuePair<string, string>("strSelectColumns", strSelectColumns)
                                                                                    , new KeyValuePair<string, string>("strParticipant_Filter", strParticipant_Filter)
                                                                                    , new KeyValuePair<string, string>("strSourceTable", GlobalVariables.AppSetting_SourceTable)));

                cols_RSFDVALUE.Add("RSFDVALUE" + cnt.ToString());
                cols_RSFDSCORE.Add("RSFDSCORE" + cnt.ToString());
                cols_MAX_RSFDVALUE.Add(string.Format("MAX([RSFDVALUE{0}]) as [RSFDVALUE{1}]", cnt.ToString(), cnt.ToString()));
                cols_SUM_RSFDSCORE.Add(string.Format("SUM([RSFDSCORE{0}]) as [RSFDSCORE{1}]", cnt.ToString(), cnt.ToString()));
                cnt++;
            }

            ////Risk Factor Type 2 - Map by numeric range
            lsRiskFactors = context.cor_code.Where(l => l.cor_CodeNo == GlobalVariables.AppSetting_Risk_Column_Table && l.cor_ValueF2 == 2);
            var strSqlRiskFactorType2 = AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.BuildSql_RiskFactorType2);

            foreach (var rm in lsRiskFactors)
            {
                lsSqlStatement.Add(StringHelper.FormatString(strSqlRiskFactorType2, new KeyValuePair<string, string>("COMP_CODE", GlobalVariables.AppSetting_CodeComp.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_CodeNo", rm.cor_CodeNo.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_CodeKey", rm.cor_CodeKey)
                                                                                    , new KeyValuePair<string, string>("cor_Desc", rm.cor_Desc)
                                                                                    , new KeyValuePair<string, string>("cor_ValueF2", rm.cor_ValueF2.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_ValueI1", rm.cor_ValueI1.ToString())
                                                                                    , new KeyValuePair<string, string>("cor_ValueT1", rm.cor_ValueT1)
                                                                                    , new KeyValuePair<string, string>("strSelectColumns", strSelectColumns)
                                                                                    , new KeyValuePair<string, string>("strParticipant_Filter", strParticipant_Filter)
                                                                                    , new KeyValuePair<string, string>("strSourceTable", GlobalVariables.AppSetting_SourceTable)));

                cols_RSFDVALUE.Add("RSFDVALUE" + cnt.ToString());
                cols_RSFDSCORE.Add("RSFDSCORE" + cnt.ToString());
                cols_MAX_RSFDVALUE.Add(string.Format("MAX([RSFDVALUE{0}]) as [RSFDVALUE{1}]", cnt.ToString(), cnt.ToString()));
                cols_SUM_RSFDSCORE.Add(string.Format("SUM([RSFDSCORE{0}]) as [RSFDSCORE{1}]", cnt.ToString(), cnt.ToString()));
                cnt++;
            }

            ////Risk Factor Type 3 - Map 2 keys (cor_CodeKey)
            var lsRiskFactor_Type3 = context.Database.SqlQuery<cor_code_RiskType3>(AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.GetRiskFactor_Type3), new SqlParameter("RiskModelCode", GlobalVariables.AppSetting_Risk_Column_Table)).ToList();
            var strSqlRiskFactorType3 = AgentRiskScoreHistUptQuery.GetStatement(AgentRiskScoreHistUptQuery.SqlCase.BuildSql_RiskFactorType3);

            foreach (var rm in lsRiskFactor_Type3)
            {
                var strCondition1 = "";
                var strCondition2 = "";

                if (rm.h1_cor_ValueF2 == 1)
                    strCondition1 = StringHelper.FormatString("dtl.cor_CodeKey=CAST(hdr.{h1_cor_ValueT1} AS NVARCHAR(100))"
                                                                , new KeyValuePair<string, string>("h1_cor_ValueT1", rm.h1_cor_ValueT1.ToString()));
                else if (rm.h1_cor_ValueF2 == 2)
                    strCondition1 = StringHelper.FormatString("hdr.{h1_cor_ValueT1} between dtl.cor_ValueD1 and dtl.cor_ValueD2"
                                                                , new KeyValuePair<string, string>("h1_cor_ValueT1", rm.h1_cor_ValueT1.ToString()));

                if (rm.h2_cor_ValueF2 == 1)
                    strCondition2 = StringHelper.FormatString("dtl2.cor_CodeKey=CAST(hdr.{h2_cor_ValueT1} AS NVARCHAR(100))"
                                                                , new KeyValuePair<string, string>("h2_cor_ValueT1", rm.h2_cor_ValueT1.ToString()));
                else if (rm.h2_cor_ValueF2 == 2)
                    strCondition2 = StringHelper.FormatString("hdr.{h2_cor_ValueT1} between dtl2.cor_ValueD1 and dtl2.cor_ValueD2"
                                                                , new KeyValuePair<string, string>("h2_cor_ValueT1", rm.h2_cor_ValueT1.ToString()));

                lsSqlStatement.Add(StringHelper.FormatString(strSqlRiskFactorType3, new KeyValuePair<string, string>("COMP_CODE", GlobalVariables.AppSetting_CodeComp.ToString())
                                                                                    , new KeyValuePair<string, string>("rm_cor_CodeNo", rm.rm_cor_CodeNo.ToString())
                                                                                    , new KeyValuePair<string, string>("rm_cor_CodeKey", rm.rm_cor_CodeKey)
                                                                                    , new KeyValuePair<string, string>("rm_cor_Desc", rm.rm_cor_Desc)
                                                                                    , new KeyValuePair<string, string>("rm_cor_ValueF2", rm.rm_cor_ValueF2.ToString())
                                                                                    , new KeyValuePair<string, string>("rm_cor_ValueI1", rm.rm_cor_ValueI1.ToString())
                                                                                    , new KeyValuePair<string, string>("h1_cor_ValueI1", rm.h1_cor_ValueI1.ToString())
                                                                                    , new KeyValuePair<string, string>("h1_cor_ValueT1", rm.h1_cor_ValueT1.ToString())
                                                                                    , new KeyValuePair<string, string>("h2_cor_ValueI1", rm.h2_cor_ValueI1.ToString())
                                                                                    , new KeyValuePair<string, string>("h2_cor_ValueT1", rm.h2_cor_ValueT1.ToString())
                                                                                    , new KeyValuePair<string, string>("strCondition1", strCondition1)
                                                                                    , new KeyValuePair<string, string>("strCondition2", strCondition2)
                                                                                    , new KeyValuePair<string, string>("strSelectColumns", strSelectColumns)
                                                                                    , new KeyValuePair<string, string>("strParticipant_Filter", strParticipant_Filter)
                                                                                    , new KeyValuePair<string, string>("strSourceTable", GlobalVariables.AppSetting_SourceTable)));

                cols_RSFDVALUE.Add("RSFDVALUE" + cnt.ToString());
                cols_RSFDSCORE.Add("RSFDSCORE" + cnt.ToString());
                cols_MAX_RSFDVALUE.Add(string.Format("MAX([RSFDVALUE{0}]) as [RSFDVALUE{1}]", cnt.ToString(), cnt.ToString()));
                cols_SUM_RSFDSCORE.Add(string.Format("SUM([RSFDSCORE{0}]) as [RSFDSCORE{1}]", cnt.ToString(), cnt.ToString()));
                cnt++;
            }

            strInsertStatement = string.Join(string.Format(System.Environment.NewLine + "UNION ALL" + System.Environment.NewLine), lsSqlStatement);


            #endregion

            #region Statement Part 2
            strInsertStatement = "select 'RSFDVALUE'+CAST(ROW_NUMBER() OVER (PARTITION BY t1.COMP_CODE, t1.CIF_NO ORDER BY RiskModelKey) AS VARCHAR(10)) as cols_RSFDVALUE" + System.Environment.NewLine +
                                ", 'RSFDSCORE'+CAST(ROW_NUMBER() OVER (PARTITION BY t1.COMP_CODE, t1.CIF_NO ORDER BY RiskModelKey) AS VARCHAR(10)) as cols_RSFDSCORE, t1.*" + System.Environment.NewLine +
                                "from (" + System.Environment.NewLine + strInsertStatement + System.Environment.NewLine + ") as t1";

            #endregion

            #region Statement Part 3
            var strCols_RSFDVALUE = string.Join(",", cols_RSFDVALUE);
            var strCols_RSFDSCORE = string.Join(",", cols_RSFDSCORE);
            var strCols_MAX_RSFDVALUE = string.Join(",", cols_MAX_RSFDVALUE);
            var strCols_SUM_RSFDSCORE = string.Join(",", cols_SUM_RSFDSCORE);
            var strExtra_Columns = "RISK_LEVEL,RISK_LEVEL_VALUE,FINAL_SCORE,LAST_RISK_LEVEL,LAST_RISK_LEVEL_VALUE,RSFDSCORE";
            var strExtra_Values = "ISNULL(curr.cor_Desc, '') as RISK_LEVEL, ISNULL(curr.cor_CodeKey, '') as RISK_LEVEL_VALUE, ISNULL(curr.cor_ValueI2, 0) as FINAL_SCORE" +
                                    ", ISNULL(prev.cor_Desc, '') as LAST_RISK_LEVEL, ISNULL(prev.cor_CodeKey, '') as LAST_RISK_LEVEL_VALUE, ISNULL(prev.cor_ValueI2, 0) as RSFDSCORE";


            var strInsertSample = "insert into {strTargetTable}" + System.Environment.NewLine +
                                    "({strInsertColumns}, {strCols_RSFDVALUE}, {strCols_RSFDSCORE},{strExtra_Columns})" + System.Environment.NewLine +

                                    ////t3
                                    "select {strInsertValues}" + System.Environment.NewLine +
                                    ", {strCols_MAX_RSFDVALUE}" + System.Environment.NewLine +
                                    ", {strCols_SUM_RSFDSCORE}" + System.Environment.NewLine +
                                    ", {strExtra_Columns}" + System.Environment.NewLine +
                                    "from (" + System.Environment.NewLine +
                                    ////t2
                                    "select COMP_CODE, CIF_NO, cols_RSFDVALUE, RFDesc_1, cols_RSFDSCORE, RFScore " + System.Environment.NewLine +
                                    ", {strExtra_Values}{strCols_ACCOUNT_ONLY}" + System.Environment.NewLine +
                                    "from (" + System.Environment.NewLine +
                                    "{strInsertStatement}" + System.Environment.NewLine +
                                    ") as t2" + System.Environment.NewLine +
                                    "left join cor_code as curr on curr.cor_CodeNo={RiskScoreCode} and curr.cor_CodeKey={CurrentRiskScoreField}" + System.Environment.NewLine +
                                    "left join cor_code as prev on prev.cor_CodeNo={RiskScoreCode} and prev.cor_CodeKey={PreviousRiskScoreField}" + System.Environment.NewLine +
                                    ////t2 - end
                                    ") as t3" + System.Environment.NewLine +
                                    "PIVOT(MAX(RFDesc_1) FOR cols_RSFDVALUE IN ({strCols_RSFDVALUE})) as pv1" + System.Environment.NewLine +
                                    "PIVOT(SUM(RFScore) FOR cols_RSFDSCORE IN ({strCols_RSFDSCORE})) as pv2" + System.Environment.NewLine +
                                    "GROUP BY COMP_CODE,CIF_NO,{strExtra_Columns}{strCols_ACCOUNT_ONLY}";

            strInsertStatement = StringHelper.FormatString(strInsertSample, new KeyValuePair<string, string>("strTargetTable", strTargetTable)
                                                                                , new KeyValuePair<string, string>("strInsertColumns", strInsertColumns)
                                                                                , new KeyValuePair<string, string>("strInsertValues", strInsertValues)
                                                                                , new KeyValuePair<string, string>("strExtra_Columns", strExtra_Columns)
                                                                                , new KeyValuePair<string, string>("strExtra_Values", strExtra_Values)
                                                                                , new KeyValuePair<string, string>("strCols_ACCOUNT_ONLY", strCols_ACCOUNT_ONLY)

                                                                                , new KeyValuePair<string, string>("RiskScoreCode", GlobalVariables.AppSetting_RiskScoreCode.ToString())
                                                                                , new KeyValuePair<string, string>("CurrentRiskScoreField", GlobalVariables.AppSetting_CurrentRiskScoreField)
                                                                                , new KeyValuePair<string, string>("PreviousRiskScoreField", GlobalVariables.AppSetting_PreviousRiskScoreField)

                                                                                , new KeyValuePair<string, string>("strCols_RSFDVALUE", strCols_RSFDVALUE)
                                                                                , new KeyValuePair<string, string>("strCols_RSFDSCORE", strCols_RSFDSCORE)
                                                                                , new KeyValuePair<string, string>("strCols_MAX_RSFDVALUE", strCols_MAX_RSFDVALUE)
                                                                                , new KeyValuePair<string, string>("strCols_SUM_RSFDSCORE", strCols_SUM_RSFDSCORE)
                                                                                , new KeyValuePair<string, string>("strInsertStatement", strInsertStatement));

            #endregion

            return strInsertStatement;
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string text) : base(text)
        {
        }
    }
}
