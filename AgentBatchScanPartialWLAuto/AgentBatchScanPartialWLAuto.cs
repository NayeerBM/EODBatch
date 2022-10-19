using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentRiskScoreHistUpt.Shared;
using ManagerLib.Database;
using ManagerLib.Manager;
using ManagerLib.Query;

namespace AgentBatchScanPartialWLAuto
{
    public class AgentBatchScanPartialWLAuto
    {
        public static void Main(string[] args)
        {
            var strAlertTranTableName = "";
            var strAlertTranDtlTableName = "";
            var strAlertTranWlistTableName = "";
            var strAlertTranWlistDtlTableName = "";

            var strTable_Name_Acct = "";
            var strTable_Name_CIF = "";
            var strTable_Name_TranHist = "";
            var strTable_Name_Address = "";
            var strTable_Name_HitTran = "";
            var strTask_ID = "";
            var strProductCode = "";
            var strFileIdUsed = "";

            var dtStartJob = DateTime.Now;


            using (var context = new CommonContext())
            {
                using (var trx = context.Database.BeginTransaction())
                {
                    var strJobId = "";

                    ////1) Test Database Connection
                    if (!context.Database.Exists())
                        throw new Exception("Database connection failed");

                    ////2) Check input arguments
                    if (args.Length == 0)
                        throw new Exception("Missing argusment(s): [JOB_ID]");
                    else
                        strJobId = args[0];

                    ////3) Init Batch Job
                    var BatchJob = new BatchJobManager(context, GlobalVariables.AppSetting_CompCode, GlobalVariables.AppSetting_UserId, strJobId);
                    BatchJob.InitProcess();


                    ////4) Process
                    if ((AlertTranTableGroup)GlobalVariables.AppSetting_AlertTranTableGroup == AlertTranTableGroup.CSV)
                        BatchJob.CheckProcessorType(20);
                    else
                    {
                        BatchJob.CheckProcessorType(69);

                        strTable_Name_Acct = BatchJob.lsJobProcess.JOB_ACCT_TABLE == "" || BatchJob.lsJobProcess.JOB_ACCT_TABLE.ToLower() == "none" ? "NA" : BatchJob.lsJobProcess.JOB_ACCT_TABLE;
                        strTable_Name_CIF = BatchJob.lsJobProcess.JOB_CIF_TABLE == "" || BatchJob.lsJobProcess.JOB_CIF_TABLE.ToLower() == "none" ? "NA" : BatchJob.lsJobProcess.JOB_CIF_TABLE;
                        strTable_Name_TranHist = BatchJob.lsJobProcess.JOB_HIST_TABLE == "" || BatchJob.lsJobProcess.JOB_HIST_TABLE.ToLower() == "none" ? "NA" : BatchJob.lsJobProcess.JOB_HIST_TABLE;
                        strTable_Name_Address = BatchJob.lsJobProcess.JOB_ADDR_TABLE == "" || BatchJob.lsJobProcess.JOB_ADDR_TABLE.ToLower() == "none" ? "NA" : BatchJob.lsJobProcess.JOB_ADDR_TABLE;
                        strTable_Name_HitTran = BatchJob.lsJobProcess.JOB_HIT_TRAN_TABLE == "" || BatchJob.lsJobProcess.JOB_HIT_TRAN_TABLE.ToLower() == "none" ? "NA" : BatchJob.lsJobProcess.JOB_HIT_TRAN_TABLE;
                        
                        strTask_ID = BatchJob.lsJobProcess.JOB_TASK_ID;
                        strProductCode = BatchJob.lsJobProcess.JOB_PRODUCT_CODE;
                        strFileIdUsed = string.Format("NA;{0};{1};NA;{2};NA;NA;", strTable_Name_Acct, strTable_Name_TranHist, strTable_Name_HitTran);

                        context.Database.ExecuteSqlCommand(AgentBatchScanPartialWLAutoQuery.GetStatement(AgentBatchScanPartialWLAutoQuery.SqlCase.Truncate_ATEMPALERTTRANWLISTDTL));
                        
                    }

                    switch ((AlertTranTableGroup)GlobalVariables.AppSetting_AlertTranTableGroup)
                    {
                        case AlertTranTableGroup.ALERT_POOL:

                            strAlertTranTableName = "ALERTTRAN";
                            strAlertTranDtlTableName = "ALERTTRANDTLHIT";
                            strAlertTranWlistTableName = "ALERTTRANWLIST";
                            strAlertTranWlistDtlTableName = "ALERTTRANWLISTDTL";

                            break;
                        case AlertTranTableGroup.WATCHLIST_ALERT_POOL:

                            strAlertTranTableName = "ALERTWLTRAN";
                            strAlertTranDtlTableName = "ALERTWLTRANDTLHIT";
                            strAlertTranWlistTableName = "ALERTWLTRANWLIST";
                            strAlertTranWlistDtlTableName = "ALERTWLTRANWLISTDTL";

                            break;

                        case AlertTranTableGroup.CSV:

                            strAlertTranWlistDtlTableName = "SCANDATA_RTN2";

                            break;
                    }

                    if ((ScanFullPartial)GlobalVariables.AppSetting_ScanFullPartial == ScanFullPartial.SCAN_FULL)
                    {

                    }
                    else
                    { 
                        
                    }




                    ////5) End Batch Job
                    BatchJob.EndProcess(context, GlobalVariables.AppSetting_CompCode, strJobId, dtStartJob, BatchJob.lsParam.CURRENT_PROCESS_DATE, BatchJob.strNewBatchNo, GlobalVariables.AppSetting_UserId);

                    trx.Commit();
                }
            }

        }
    }
}
