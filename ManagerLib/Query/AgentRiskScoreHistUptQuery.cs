using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Query
{
    public class AgentRiskScoreHistUptQuery
    {
        public enum SqlCase
        {
                GetRiskFactor_Type3
                , BuildSql_RiskFactorType1
                , BuildSql_RiskFactorType2
                , BuildSql_RiskFactorType3
                , UpdatePreviousScore
                , DeleteRiskHistByDate
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";
            switch (sqlCase)
            {

                //case SqlCase.BuildRiskScoreSql:
                //    sqlStatement = "select hdr.COMP_CODE, hdr.CIF_NO," + Environment.NewLine + System.Environment.NewLine +

                //        "";
                //    break;

                case SqlCase.GetRiskFactor_Type3:
                    sqlStatement = "select rm.cor_CodeNo as rm_cor_CodeNo, rm.cor_CodeKey as rm_cor_CodeKey, rm.cor_Desc as rm_cor_Desc, rm.cor_ValueF2 as rm_cor_ValueF2, rm.cor_ValueI1 as rm_cor_ValueI1" + System.Environment.NewLine +
                                    ", h1.cor_ValueI1 as h1_cor_ValueI1, h1.cor_ValueT1 as h1_cor_ValueT1, h1.cor_ValueF2 as h1_cor_ValueF2" + System.Environment.NewLine +
                                    ", h2.cor_ValueI1 as h2_cor_ValueI1, h2.cor_ValueT1 as h2_cor_ValueT1, h2.cor_ValueF2 as h2_cor_ValueF2" + System.Environment.NewLine +
                                    "from cor_code as rm" + Environment.NewLine + System.Environment.NewLine +
                                    "inner join cor_code as h1 on h1.cor_codeno=@RiskModelCode and h1.cor_CodeKey=rm.cor_ValueT1" + System.Environment.NewLine +
                                    "inner join cor_code as h2 on h2.cor_codeno=@RiskModelCode and h2.cor_CodeKey=rm.cor_ValueT2" + System.Environment.NewLine +
                                    "where rm.cor_codeno=@RiskModelCode" + System.Environment.NewLine +
                                    "and rm.cor_ValueF2=3";
                    break;

                case SqlCase.BuildSql_RiskFactorType1:
                    sqlStatement = "select {strSelectColumns}, '{cor_CodeNo}' as RiskModelCode, '{cor_CodeKey}' as RiskModelKey, '{cor_Desc}' as RiskModelDesc, '{cor_ValueF2}' as RiskFactorType " + System.Environment.NewLine +
                                    ", '{cor_ValueI1}' as RiskFactorRefCode, '{cor_ValueT1}' as RiskFactorRefField" + System.Environment.NewLine +
                                    ", NULL as RiskFactorRefCode_1, NULL as RiskFactorRefField_1, NULL as RiskFactorRefCode_2, NULL as RiskFactorRefField_2" + System.Environment.NewLine +
                                    ", ISNULL(dtl.cor_ValueI1, 0) as RFScore, ISNULL(dtl.cor_ValueI2, 0) as RFLevel, ISNULL(dtl.cor_CodeNo, 0) as RFCode_1" + System.Environment.NewLine +
                                    ", ISNULL(dtl.cor_Desc, '') as RFDesc_1, ISNULL(dtl.cor_CodeKey, '') as RFCodeKey_1, ISNULL(dtl.cor_ValueD1, 0) as RFRangeValueFrom_1, ISNULL(dtl.cor_ValueD2, 0) as RFRangeValueTo_1" + System.Environment.NewLine +
                                    ", NULL as RFCode_2, NULL as RFDesc_2, NULL as RFCodeKey_2, NULL as RFRangeValueFrom_2, NULL as RFRangeValueTo_2" + System.Environment.NewLine +
                                    "from {strSourceTable} as hdr" + System.Environment.NewLine +
                                    "left join cor_code as dtl on dtl.cor_CodeNo={cor_ValueI1} and dtl.cor_CodeKey=CAST(hdr.{cor_ValueT1} AS NVARCHAR(100))" + System.Environment.NewLine +
                                    "where hdr.COMP_CODE={COMP_CODE}{strParticipant_Filter}";
                    break;

                case SqlCase.BuildSql_RiskFactorType2:
                    sqlStatement = "select {strSelectColumns}, '{cor_CodeNo}' as RiskModelCode, '{cor_CodeKey}' as RiskModelKey, '{cor_Desc}' as RiskModelDesc, '{cor_ValueF2}' as RiskFactorType " + System.Environment.NewLine +
                                    ", '{cor_ValueI1}' as RiskFactorRefCode, '{cor_ValueT1}' as RiskFactorRefField" + System.Environment.NewLine +
                                    ", NULL as RiskFactorRefCode_1, NULL as RiskFactorRefField_1, NULL as RiskFactorRefCode_2, NULL as RiskFactorRefField_2" + System.Environment.NewLine +
                                    ", ISNULL(dtl.cor_ValueI1, 0) as RFScore, ISNULL(dtl.cor_ValueI2, 0) as RFLevel, ISNULL(dtl.cor_CodeNo, 0) as RFCode_1" + System.Environment.NewLine +
                                    ", ISNULL(dtl.cor_Desc, '') as RFDesc_1, ISNULL(dtl.cor_CodeKey, '') as RFCodeKey_1, ISNULL(dtl.cor_ValueD1, 0) as RFRangeValueFrom_1, ISNULL(dtl.cor_ValueD2, 0) as RFRangeValueTo_1" + System.Environment.NewLine +
                                    ", NULL as RFCode_2, NULL as RFDesc_2, NULL as RFCodeKey_2, NULL as RFRangeValueFrom_2, NULL as RFRangeValueTo_2" + System.Environment.NewLine +
                                    "from {strSourceTable} as hdr" + System.Environment.NewLine +
                                    "left join cor_code as dtl on dtl.cor_CodeNo={cor_ValueI1} and hdr.{cor_ValueT1} between dtl.cor_ValueD1 and dtl.cor_ValueD2" + System.Environment.NewLine +
                                    "where hdr.COMP_CODE={COMP_CODE}{strParticipant_Filter}";
                    break;

                case SqlCase.BuildSql_RiskFactorType3:
                    sqlStatement = "select {strSelectColumns}, '{rm_cor_CodeNo}' as RiskModelCode, '{rm_cor_CodeKey}' as RiskModelKey, '{rm_cor_Desc}' as RiskModelDesc, '{rm_cor_ValueF2}' as RiskFactorType " + System.Environment.NewLine +
                                    ", '{rm_cor_ValueI1}' as RiskFactorRefCode, '' as RiskFactorRefField" + System.Environment.NewLine +
                                    ", '{h1_cor_ValueI1}' as RiskFactorRefCode_1, '{h1_cor_ValueT1}' as RiskFactorRefField_1, '{h2_cor_ValueI1}' as RiskFactorRefCode_2, '{h2_cor_ValueT1}' as RiskFactorRefField_2" + System.Environment.NewLine +
                                    ", ISNULL(result.cor_ValueI1, 0) as RFScore, ISNULL(result.cor_ValueI2, 0) as RFLevel, ISNULL(dtl.cor_CodeNo, 0) as RFCode_1" + System.Environment.NewLine +
                                    ", ISNULL(dtl.cor_Desc, '') as RFDesc_1, ISNULL(dtl.cor_CodeKey, '') as RFCodeKey_1, ISNULL(dtl.cor_ValueD1, '') as RFRangeValueFrom_1, ISNULL(dtl.cor_ValueD2, '') as RFRangeValueTo_1" + System.Environment.NewLine +
                                    ", ISNULL(dtl2.cor_CodeNo, 0) as RFCode_2, ISNULL(dtl2.cor_Desc, '') as RFDesc_2, ISNULL(dtl2.cor_CodeKey, '') as RFCodeKey_2, ISNULL(dtl2.cor_ValueD1, 0) as RFRangeValueFrom_2, ISNULL(dtl2.cor_ValueD2, 0) as RFRangeValueTo_2" + System.Environment.NewLine +
                                    "from {strSourceTable} as hdr" + System.Environment.NewLine +
                                    "left join cor_code as dtl on dtl.cor_CodeNo={h1_cor_ValueI1} and {strCondition1}" + System.Environment.NewLine +
                                    "left join cor_code as dtl2 on dtl2.cor_CodeNo={h2_cor_ValueI1} and {strCondition2}" + System.Environment.NewLine +
                                    "left join cor_code as result on result.cor_CodeNo={rm_cor_ValueI1} and result.cor_ValueT1=dtl.cor_CodeKey and result.cor_ValueT2=dtl2.cor_CodeKey" + System.Environment.NewLine +
                                    "where hdr.COMP_CODE={COMP_CODE}{strParticipant_Filter}";
                    break;

                case SqlCase.UpdatePreviousScore:
                    sqlStatement = "update {strSourceTable} " + System.Environment.NewLine + 
                                    "set {CurrentRiskScoreField}={PreviousRiskScoreField}" + System.Environment.NewLine +
                                    "where COMP_CODE={COMP_CODE}" + System.Environment.NewLine +
                                    "and {CurrentRiskScoreField}!={PreviousRiskScoreField}{strParticipant_Filter}";

                    break;

                case SqlCase.DeleteRiskHistByDate:
                    sqlStatement = "delete from {strTargetedTable} " + System.Environment.NewLine +
                                    "where COMP_CODE=@COMP_CODE" + System.Environment.NewLine +
                                    "and RS_DATE=@RS_DATE";

                    break;
                    
                default:
                    sqlStatement = "";
                    break;
            }

#if DEBUG
            System.Diagnostics.Debug.WriteLine("GetStatement " + sqlCase.ToString() + System.Environment.NewLine + sqlStatement);
#endif

            return sqlStatement;
        }
    }
}
