using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerLib.Database;
using ManagerLib.Models;

namespace ManagerLib.Common
{
    public enum BatchJobError
    {
        Completed = 0,
        Kill = -1,
        Defined_Job_Error = 111,
        Err_Inactive_Job = 106,
        Err_Unknown_Job = 107,
        Err_Unregistered_Job = 108,
        Err_Invalid_Agent_Type = 109,
        Err_No_Param = 110,
        Err_No_Risk_Model = 120,
        Err_No_Risk_Factors = 121,
        Unknown_Error = -999999
    }

    public static class BatchJobHelper
    {
        public static bool LogBatchError(CommonContext context, Int16 intCompCode, string strJobId, string strRef1, string strUserId, BatchJobError batchJobError, params string[] errorMessageParam)
        {
            var dtNow = DateTime.Now;
            context.JOBBATCHERRORLOG.Add(new _JOBBATCHERRORLOG(true)
            {
                COMP_CODE = intCompCode,
                RUN_DATE = int.Parse(dtNow.ToString("yyyyMMdd")),
                RUN_TIME = int.Parse(dtNow.ToString("HHmmss")),
                JOB_ID = strJobId,
                REF_NO1 = strRef1,
                REF_NO2 = GetErrorMessage(batchJobError, errorMessageParam),
                ERROR_MSG = ((int)batchJobError).ToString(),
                STAMP_DTTM = dtNow,
                USER_ID = strUserId,
                MODE_MN = "A",
            });
            context.SaveChanges();

            return true;
        }

        public static string GetErrorMessage(BatchJobError batchJobError, params string[] errorMessageParam)
        {
            var msg = "";
            switch (batchJobError)
            {
                case BatchJobError.Err_Unknown_Job:
                    msg = "Unknown Job Name";
                    break;

                case BatchJobError.Err_Inactive_Job:
                    msg = "Inactive Job";
                    break;

                case BatchJobError.Err_Unregistered_Job:
                    msg = "Unregistered Job";
                    break;
                    
                case BatchJobError.Err_Invalid_Agent_Type:
                    msg = string.Format("Invalid Agent Type - {0} (Should Be {1})", errorMessageParam);
                    break;

                case BatchJobError.Err_No_Param:
                    msg = string.Format("Parameter record not found");
                    break;

                case BatchJobError.Err_No_Risk_Model:
                    msg = string.Format("Risk Model Not Found - Risk_Setting: {0}, Risk_Column_Table: {1}", errorMessageParam);
                    break;

                case BatchJobError.Err_No_Risk_Factors:
                    msg = string.Format("Risk Factor(s) Not Found - Risk_Column_Table: {0}", errorMessageParam);
                    break;
                    
                default:

                    break;
            }

            return msg;
        }
    }


    public enum BatchLog
    {
        Completed = 0,
        Kill = -1,
        Defined_Job_Error = 111,
        Err_Inactive_Job = 101,
        Err_Inactive_Step = 101,
        Err_Unknown_Job = 107,
        Err_Unregistered_Job = 108,
        Err_Invalid_Agent_Type = 109,
        Err_No_Param = 110,
        Err_No_Risk_Model = 120,
        Err_No_Risk_Factors = 121,
        Unknown_Error = -999999
    }

    public static class BatchLogHelper
    {
        public static bool LogBatchError(CommonContext context, Int16 intCodeComp, Int16 intCodeOrg, string strJobId, string strStepId, string strRef1, string strUserId, BatchLog batchLog, params string[] errorMessageParam)
        {
            var dtNow = DateTime.Now;
            context.JOBBATCHLOG.Add(new _JOBBATCHLOG(true)
            {
                CODE_COMP = intCodeComp,
                CODE_ORG = intCodeOrg,
                RUN_DATE = int.Parse(dtNow.ToString("yyyyMMdd")),
                RUN_TIME = int.Parse(dtNow.ToString("HHmmss")),
                JOB_ID = strJobId,
                STEP_ID = strStepId,
                REF_NO1 = strRef1,
                REF_NO2 = GetErrorMessage(batchLog, errorMessageParam),
                ERROR_MSG = ((int)batchLog).ToString(),
                AUDIT_CREATED_DATE = dtNow,
                AUDIT_CREATED_USER = "SYSTEM",
                AUDIT_UPDATED_DATE = dtNow,
                AUDIT_UPDATED_USER = "SYSTEM"
            });
            context.SaveChanges();

            return true;
        }

        public static string GetErrorMessage(BatchLog batchLog, params string[] errorMessageParam)
        {
            var msg = "";
            switch (batchLog)
            {
                case BatchLog.Err_Unknown_Job:
                    msg = "Unknown Job Name";
                    break;

                case BatchLog.Err_Inactive_Job:
                    msg = "Inactive Job";
                    break;

                case BatchLog.Err_Unregistered_Job:
                    msg = "Unregistered Job";
                    break;

                case BatchLog.Err_Invalid_Agent_Type:
                    msg = string.Format("Invalid Agent Type - {0} (Should Be {1})", errorMessageParam);
                    break;

                case BatchLog.Err_No_Param:
                    msg = string.Format("Parameter record not found");
                    break;

                case BatchLog.Err_No_Risk_Model:
                    msg = string.Format("Risk Model Not Found - Risk_Setting: {0}, Risk_Column_Table: {1}", errorMessageParam);
                    break;

                case BatchLog.Err_No_Risk_Factors:
                    msg = string.Format("Risk Factor(s) Not Found - Risk_Column_Table: {0}", errorMessageParam);
                    break;

                default:

                    break;
            }

            return msg;
        }
    }
}
