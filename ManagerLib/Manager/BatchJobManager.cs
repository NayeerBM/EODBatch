using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerLib.Common;
using ManagerLib.Database;
using ManagerLib.Query;
using ManagerLib.Models;

namespace ManagerLib.Manager
{
    public class BatchJobManager
    {
        private CommonContext context;
        private Int16 intCodeComp = 0;
        private Int16 intCodeOrg = 0;
        private string strUserId = "";
        private string strJobId = "";
        private string strStepId = "";

        public _PARAM lsParam;
        public _CONFIGJOBPROCESS lsJobProcess;
        public _JOBCONTROL lsJobControl;

        public int intNewBatchNo = 0;
        public string strNewBatchNo = "";

        public BatchJobManager(CommonContext context, Int16 CodeComp, Int16 CodeOrg, string UserId, string JobId, string StepId)
        {
            this.context = context;
            intCodeComp = CodeComp;
            intCodeOrg = CodeOrg;
            strUserId = UserId;
            strJobId = JobId;
            strStepId = StepId;
        }

        public void InitProcess()
        {

            #region Prepare Settings

            ////1) Retrieve Job Control Details
            lsJobControl = context.JOBCONTROL.Where(l => l.COMP_CODE == intCodeComp && l.JOB_ID == strJobId).FirstOrDefault();

            if (lsJobControl != null)
            {
                if (lsJobControl.STATUS == 1)   ////Inactive Job
                {
                    BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Job Control Table", strUserId, BatchJobError.Err_Inactive_Job);
                    context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                , new SqlParameter("CompCode", intCodeComp)
                                                                                , new SqlParameter("JOB_ID", strJobId));
                    throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Inactive_Job));
                }
            }
            else
            {
                BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Job Control Table"
                                            , strUserId, BatchJobError.Err_Unknown_Job);
                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                , new SqlParameter("CompCode", intCodeComp)
                                                                                , new SqlParameter("JOB_ID", strJobId));
                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Unknown_Job));
            }

            ////2) Retrieve Config Job Process Details
            lsJobProcess = context.CONFIGJOBPROCESS.Where(l => l.COMP_CODE == intCodeComp && l.JOB_CODE == strJobId).FirstOrDefault();

            if (lsJobProcess == null)
            {
                BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Config Job Process Table"
                                            , strUserId, BatchJobError.Err_Unregistered_Job);
                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                , new SqlParameter("CompCode", intCodeComp)
                                                                                , new SqlParameter("JOB_ID", strJobId));
                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Unregistered_Job));
            }

            ////3) Retrieve Param
            lsParam = context.PARAM.Where(l => l.COMP_CODE == intCodeComp).FirstOrDefault();

            if (lsParam != null)
            {
                intNewBatchNo = lsParam.LAST_IMPORT_BATCH_NO + 1;
                strNewBatchNo = lsParam.CURRENT_PROCESS_DATE.ToString() + "-" + intNewBatchNo.ToString();
                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateNewBatchNo)
                                                                                , new SqlParameter("NewBatchNo", intNewBatchNo)
                                                                                , new SqlParameter("CompCode", intCodeComp));
            }
            else
            {
                BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Parameter Table"
                                            , strUserId, BatchJobError.Err_No_Param);
                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_No_Param));
            }

            #endregion

        }

        public void CheckProcessorType(int intAgentType)
        {
            if (lsJobProcess != null)
            {
                if (lsJobProcess.JOB_PROCESSOR_TYPE != intAgentType)
                {
                    BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Config Job Process Table"
                                                , strUserId, BatchJobError.Err_Invalid_Agent_Type, lsJobProcess.JOB_PROCESSOR_TYPE.ToString());
                    context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                    , new SqlParameter("CompCode", intCodeComp)
                                                                                    , new SqlParameter("JOB_ID", strJobId));
                    throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Invalid_Agent_Type, lsJobProcess.JOB_PROCESSOR_TYPE.ToString(), intAgentType.ToString()));
                }
            }
        }

        public void EndProcess(CommonContext context, Int16 intCompCode, string strJobId, DateTime dtJobStart, int intBatchDate, string strBatchNo, string strUserId)
        {
            var dt = DateTime.Now;
            ////var strUserId = "SERVER";

            ////1) Job Control - Completed
            context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Complete)
                                                                            , new SqlParameter("RUN_DTTM_END", dt.ToString("dd MMM yyyy HH:mm:ss"))
                                                                            , new SqlParameter("LAST_RUN_DTTM", dt.ToString("dd MMM yyyy HH:mm:ss"))
                                                                            , new SqlParameter("LAST_DATE_RUN", int.Parse(dt.ToString("yyyyMMdd")))
                                                                            , new SqlParameter("LAST_TIME_RUN", int.Parse(dt.ToString("HHmmss")))
                                                                            , new SqlParameter("STAMP_DTTM", dt)
                                                                            , new SqlParameter("USER_ID", strUserId)
                                                                            , new SqlParameter("JOB_ID", strJobId));

            ////2) Insert Job Tran
            context.JOBTRAN.Add(new _JOBTRAN(true)
            {
                COMP_CODE = intCompCode,
                JOB_ID = strJobId,
                RUN_DATE = int.Parse(dt.ToString("yyyyMMdd")),
                RUN_TIME = int.Parse(dt.ToString("HHmmss")),
                TOTAL_RECORDS = 0,
                PROCESS_RECORDS = 0,
                PROCESS_PERCENT = 100,
                PROCESS_STATUS = "Completed",
                RUN_DTTM_START = dtJobStart.ToString("dd MMM yyyy HH:mm:ss"),
                RUN_DTTM_END = dt.ToString("dd MMM yyyy HH:mm:ss"),
                BATCH_DATE = intBatchDate,
                BATCH_NO = strBatchNo,
                REMARKS = "Ok",
                STAMP_DTTM = dt,
                USER_ID = strUserId,
                MODE_MN = "A"
            });

            context.SaveChanges();


            lsParam = null;
            lsJobProcess = null;
            lsJobControl = null;
        }

    }

    public class ConfigJobManager
    {
        private CommonContext context;
        private Int16 intCodeComp = 0;
        private Int16 intCodeOrg = 0;
        private string strUserId = "";
        private string strJobId = "";
        private string strStepId = "";

        public _PARAM lsParam;
        public _CONFIGJOBPROCESS lsJobProcess;
        public _CONFIG_JOB lsConfigJob;

        public int intNewBatchNo = 0;
        public string strNewBatchNo = "";

        public ConfigJobManager(CommonContext context, Int16 CodeComp, Int16 CodeOrg, string UserId, string JobId, string StepId)
        {
            this.context = context;
            intCodeComp = CodeComp;
            intCodeOrg = CodeOrg;
            strUserId = UserId;
            strJobId = JobId;
            strStepId = StepId;
        }

        public void InitProcess()
        {
            var dt = DateTime.Now;

            #region Prepare Settings

            ////1) Retrieve Job Control Details
            //lsConfigJob = context.CONFIG_JOB.Where(cj => cj.CODE_COMP == intCodeComp && cj.CODE_ORG == intCodeOrg && cj.JOB_ID == strJobId).FirstOrDefault();
            var result = (from a in context.CONFIG_JOB
                          join b in context.CONFIG_JOB_STEP on a.JOB_ID equals b.JOB_ID
                          where a.JOB_ID == strJobId && b.STEP_ID == strStepId
                          select new
                          {
                              a.JOB_STATUS,
                              b.STEP_STATUS
                          }).FirstOrDefault();

            if (result is null)
            {
                BatchLogHelper.LogBatchError(context, intCodeComp, intCodeOrg, strJobId, strStepId, "Config Job Table"
                                            , strUserId, BatchLog.Err_Unregistered_Job);
                context.Database.ExecuteSqlCommand(ConfigJobStepQuery.GetStatement(ConfigJobStepQuery.SqlCase.UpdateConfigJobStep_Error)
                                                                                , new SqlParameter("CodeComp", intCodeComp)
                                                                                , new SqlParameter("CodeOrg", intCodeOrg)
                                                                                , new SqlParameter("JobId", strJobId)
                                                                                , new SqlParameter("StepId", strStepId)
                                                                                , new SqlParameter("auditUpdDt", dt)
                                                                                , new SqlParameter("auditUptUser", "None"));
                throw new Exception("CONFIG JOB table. Invalid/Unknown Job ID. The argument should be the same as Job ID & Step ID configured in the system.");
            }
            else if (result.JOB_STATUS == 0)
            {
                BatchLogHelper.LogBatchError(context, intCodeComp, intCodeOrg, strJobId, strStepId, "Config Job Table"
                                            , strUserId, BatchLog.Err_Inactive_Job);
                context.Database.ExecuteSqlCommand(ConfigJobStepQuery.GetStatement(ConfigJobStepQuery.SqlCase.UpdateConfigJobStep_Error)
                                                                                , new SqlParameter("CodeComp", intCodeComp)
                                                                                , new SqlParameter("CodeOrg", intCodeOrg)
                                                                                , new SqlParameter("JobId", strJobId)
                                                                                , new SqlParameter("StepId", strStepId)
                                                                                , new SqlParameter("auditUpdDt", dt)
                                                                                , new SqlParameter("auditUptUser", "None"));

                throw new Exception("Inactive Job Status.");
            }
            else if (result.STEP_STATUS == 0)
            {
                BatchLogHelper.LogBatchError(context, intCodeComp, intCodeOrg, strJobId, strStepId, "Config Job Table"
                                            , strUserId, BatchLog.Err_Inactive_Step);
                context.Database.ExecuteSqlCommand(ConfigJobStepQuery.GetStatement(ConfigJobStepQuery.SqlCase.UpdateConfigJobStep_Error)
                                                                                , new SqlParameter("CodeComp", intCodeComp)
                                                                                , new SqlParameter("CodeOrg", intCodeOrg)
                                                                                , new SqlParameter("JobId", strJobId)
                                                                                , new SqlParameter("StepId", strStepId)
                                                                                , new SqlParameter("auditUpdDt", dt)
                                                                                , new SqlParameter("auditUptUser", "None"));
                throw new Exception("Inactive Step Status.");
            }

            ////2) Retrieve Config Job Process Details
            lsJobProcess = context.CONFIGJOBPROCESS.Where(l => l.COMP_CODE == intCodeComp && l.JOB_CODE == strJobId).FirstOrDefault();

            if (lsJobProcess == null)
            {
                BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Config Job Process Table"
                                            , strUserId, BatchJobError.Err_Unregistered_Job);
                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
                                                                                , new SqlParameter("CompCode", intCodeComp)
                                                                                , new SqlParameter("JOB_ID", strJobId));
                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Unregistered_Job));
            }

            ////3) Retrieve Param
            lsParam = context.PARAM.Where(l => l.COMP_CODE == intCodeComp).FirstOrDefault();

            if (lsParam != null)
            {
                intNewBatchNo = lsParam.LAST_IMPORT_BATCH_NO + 1;
                strNewBatchNo = lsParam.CURRENT_PROCESS_DATE.ToString() + "-" + intNewBatchNo.ToString();
                context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateNewBatchNo)
                                                                                , new SqlParameter("NewBatchNo", intNewBatchNo)
                                                                                , new SqlParameter("CompCode", intCodeComp));
            }
            else
            {
                BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Parameter Table"
                                            , strUserId, BatchJobError.Err_No_Param);
                throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_No_Param));
            }

            #endregion

        }

        //public void CheckProcessorType(int intAgentType)
        //{
        //    if (lsJobProcess != null)
        //    {
        //        if (lsJobProcess.JOB_PROCESSOR_TYPE != intAgentType)
        //        {
        //            BatchJobHelper.LogBatchError(context, intCodeComp, strJobId, "Config Job Process Table"
        //                                        , strUserId, BatchJobError.Err_Invalid_Agent_Type, lsJobProcess.JOB_PROCESSOR_TYPE.ToString());
        //            context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Error)
        //                                                                            , new SqlParameter("CompCode", intCodeComp)
        //                                                                            , new SqlParameter("JOB_ID", strJobId));
        //            throw new Exception("Error: " + BatchJobHelper.GetErrorMessage(BatchJobError.Err_Invalid_Agent_Type, lsJobProcess.JOB_PROCESSOR_TYPE.ToString(), intAgentType.ToString()));
        //        }
        //    }
        //}

        public void EndProcess(CommonContext context, Int16 intCompCode, string strJobId, DateTime dtJobStart, int intBatchDate, string strBatchNo, string strUserId)
        {
            var dt = DateTime.Now;
            ////var strUserId = "SERVER";

            ////1) Job Control - Completed
            context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateJobControl_Complete)
                                                                            , new SqlParameter("RUN_DTTM_END", dt.ToString("dd MMM yyyy HH:mm:ss"))
                                                                            , new SqlParameter("LAST_RUN_DTTM", dt.ToString("dd MMM yyyy HH:mm:ss"))
                                                                            , new SqlParameter("LAST_DATE_RUN", int.Parse(dt.ToString("yyyyMMdd")))
                                                                            , new SqlParameter("LAST_TIME_RUN", int.Parse(dt.ToString("HHmmss")))
                                                                            , new SqlParameter("STAMP_DTTM", dt)
                                                                            , new SqlParameter("USER_ID", strUserId)
                                                                            , new SqlParameter("JOB_ID", strJobId));

            ////2) Insert Job Tran
            context.JOBTRAN.Add(new _JOBTRAN(true)
            {
                COMP_CODE = intCompCode,
                JOB_ID = strJobId,
                RUN_DATE = int.Parse(dt.ToString("yyyyMMdd")),
                RUN_TIME = int.Parse(dt.ToString("HHmmss")),
                TOTAL_RECORDS = 0,
                PROCESS_RECORDS = 0,
                PROCESS_PERCENT = 100,
                PROCESS_STATUS = "Completed",
                RUN_DTTM_START = dtJobStart.ToString("dd MMM yyyy HH:mm:ss"),
                RUN_DTTM_END = dt.ToString("dd MMM yyyy HH:mm:ss"),
                BATCH_DATE = intBatchDate,
                BATCH_NO = strBatchNo,
                REMARKS = "Ok",
                STAMP_DTTM = dt,
                USER_ID = strUserId,
                MODE_MN = "A"
            });

            context.SaveChanges();


            lsParam = null;
            lsJobProcess = null;
            lsConfigJob = null;
        }

    }
}
