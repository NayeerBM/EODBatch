using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Query
{
    public class BatchJobQuery
    {
        public enum SqlCase
        {
            UpdateNewBatchNo
            , UpdateJobControl_Error
            , UpdateJobControl_Complete
            , UpdateJobControl_Kill
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";
            switch (sqlCase)
            {

                case SqlCase.UpdateNewBatchNo:
                    sqlStatement = "update PARAM" + Environment.NewLine +
                                    "set LAST_IMPORT_BATCH_NO=@NewBatchNo" + Environment.NewLine +
                                    "where COMP_CODE=@CompCode";
                    break;

                case SqlCase.UpdateJobControl_Error:
                    sqlStatement = "update JOBCONTROL" + Environment.NewLine +
                                    "set PROCESS_RETURN_CODE1=9, PROCESS_STATUS='Error', PROCESS_PERCENT=0" + Environment.NewLine +
                                    "where COMP_CODE=@CompCode" + Environment.NewLine +
                                    "and JOB_ID=@JobId";
                    break;

                case SqlCase.UpdateJobControl_Complete:
                    sqlStatement = "update JOBCONTROL" + System.Environment.NewLine +
                                    "set RUN_DTTM_END=@RUN_DTTM_END, PROCESS_STATUS='Completed', PROCESS_RETURN_CODE1=0" + System.Environment.NewLine +
                                    ", PROCESS_PERCENT=100, LAST_RUN_DTTM=@LAST_RUN_DTTM, LAST_DATE_RUN=@LAST_DATE_RUN, LAST_TIME_RUN=@LAST_TIME_RUN" + System.Environment.NewLine +
                                    ", ERR_MSG='', STAMP_DTTM=@STAMP_DTTM, USER_ID=@USER_ID, MODE_MN='M'" + System.Environment.NewLine +
                                    "where COMP_CODE=1 And JOB_ID=@JOB_ID";
                    break;

                case SqlCase.UpdateJobControl_Kill:
                    sqlStatement = "update JOBCONTROL" + System.Environment.NewLine +
                                    "set RUN_DTTM_END=@RUN_DTTM_END, PROCESS_STATUS='Killed', PROCESS_RETURN_CODE1=2" + System.Environment.NewLine +
                                    ", PROCESS_PERCENT=100, LAST_RUN_DTTM=@LAST_RUN_DTTM, LAST_DATE_RUN=@LAST_DATE_RUN, LAST_TIME_RUN=@LAST_TIME_RUN" + System.Environment.NewLine +
                                    ", ERR_MSG='', STAMP_DTTM=@STAMP_DTTM, USER_ID=@USER_ID, MODE_MN='M'" + System.Environment.NewLine +
                                    "where COMP_CODE=1 And JOB_ID=@JOB_ID";
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

    public class ConfigJobStepQuery
    {
        public enum SqlCase
        {
            //UpdateNewBatchNo, 
            UpdateConfigJobStep_InProgress
            , UpdateConfigJobStep_Error
            , UpdateConfigJobStep_Complete
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";
            switch (sqlCase)
            {

                //case SqlCase.UpdateNewBatchNo:
                //    sqlStatement = "update PARAM" + Environment.NewLine +
                //                    "set LAST_IMPORT_BATCH_NO=@NewBatchNo" + Environment.NewLine +
                //                    "where COMP_CODE=@CompCode";
                //    break;

                case SqlCase.UpdateConfigJobStep_InProgress:
                    sqlStatement = "update CONFIG_JOB_STEP" + Environment.NewLine +
                                    "set PROCESS_STATUS=1, PROCESS_PERCENT=1, AUDIT_UPDATED_DATE=@auditUpdDt, AUDIT_UPDATED_USER=@auditUptUser" + Environment.NewLine +
                                    "where CODE_COMP=@CodeComp and CODE_ORG=@CodeOrg" + Environment.NewLine +
                                    "and JOB_ID=@JobId and STEP_ID=@StepId";
                    break;

                case SqlCase.UpdateConfigJobStep_Error:
                    sqlStatement = "update CONFIG_JOB_STEP" + Environment.NewLine +
                                    "set PROCESS_STATUS=9, PROCESS_PERCENT=0, AUDIT_UPDATED_DATE=@auditUpdDt, AUDIT_UPDATED_USER=@auditUptUser" + Environment.NewLine +
                                    "where CODE_COMP=@CodeComp and CODE_ORG=@CodeOrg" + Environment.NewLine +
                                    "and JOB_ID=@JobId and STEP_ID=@StepId";
                    break;

                case SqlCase.UpdateConfigJobStep_Complete:
                    sqlStatement = "update CONFIG_JOB_STEP" + Environment.NewLine +
                                    "set PROCESS_STATUS=0, PROCESS_PERCENT=100, AUDIT_UPDATED_DATE=@auditUpdDt, AUDIT_UPDATED_USER=@auditUptUser" + Environment.NewLine +
                                    "where CODE_COMP=@CodeComp and CODE_ORG=@CodeOrg" + Environment.NewLine +
                                    "and JOB_ID=@JobId and STEP_ID=@StepId";
                    break;

                //case SqlCase.UpdateJobControl_Kill:
                //    sqlStatement = "update JOBCONTROL" + System.Environment.NewLine +
                //                    "set RUN_DTTM_END=@RUN_DTTM_END, PROCESS_STATUS='Killed', PROCESS_RETURN_CODE1=2" + System.Environment.NewLine +
                //                    ", PROCESS_PERCENT=100, LAST_RUN_DTTM=@LAST_RUN_DTTM, LAST_DATE_RUN=@LAST_DATE_RUN, LAST_TIME_RUN=@LAST_TIME_RUN" + System.Environment.NewLine +
                //                    ", ERR_MSG='', STAMP_DTTM=@STAMP_DTTM, USER_ID=@USER_ID, MODE_MN='M'" + System.Environment.NewLine +
                //                    "where COMP_CODE=1 And JOB_ID=@JOB_ID";
                //    break;

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
