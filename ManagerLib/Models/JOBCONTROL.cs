using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class JOBCONTROL
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_ID { get; set; }
        public Int16 JOB_SEQ { get; set; }
        public string JOB_NAME { get; set; }
        public Int16 JOB_GROUP { get; set; }
        public Int16 PROCESSOR_TYPE { get; set; }
        public string EXECUTE_PROGRAM_ID { get; set; }
        public string PASSING_ARGUMENT { get; set; }
        public string EXECUTE_PATH { get; set; }
        public string DEPENDANT_ID { get; set; }
        public int PROCESS_RETURN_CODE { get; set; }
        public int PROCESS_RETURN_CODE1 { get; set; }
        public Int16 STATUS { get; set; }
        public string PROCESS_PERIOD { get; set; }
        public Int16 REPEAT_CYCLE { get; set; }
        public string FREQUENCY { get; set; }
        public Int16 PROCESS_INSTRUCT { get; set; }
        public int PERIOD_FROM { get; set; }
        public int PERIOD_TO { get; set; }
        public int LAST_DATE_RUN { get; set; }
        public int LAST_TIME_RUN { get; set; }
        public string LAST_RUN_DTTM { get; set; }
        public string PROCESS_STATUS { get; set; }
        public double PROCESS_PERCENT { get; set; }
        public string RUN_DTTM_START { get; set; }
        public string RUN_DTTM_END { get; set; }
        public string ERR_MSG { get; set; }
        public string ALERT_MSG { get; set; }
        public Int16 ALERT_IND { get; set; }
        public int TOTAL_REC_UPDATED { get; set; }
        public int TOTAL_REC_READ { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("JOBCONTROL")]
    public class _JOBCONTROL
    {

        public _JOBCONTROL() { }

        public _JOBCONTROL(bool setDefaultValue)
        {
            COMP_CODE = 0;
            JOB_ID = "";
            JOB_SEQ = 0;
            JOB_NAME = "";
            JOB_GROUP = 0;
            PROCESSOR_TYPE = 0;
            EXECUTE_PROGRAM_ID = "";
            PASSING_ARGUMENT = "";
            EXECUTE_PATH = "";
            DEPENDANT_ID = "";
            PROCESS_RETURN_CODE = 0;
            PROCESS_RETURN_CODE1 = 0;
            STATUS = 0;
            PROCESS_PERIOD = "";
            REPEAT_CYCLE = 0;
            FREQUENCY = "";
            PROCESS_INSTRUCT = 0;
            PERIOD_FROM = 0;
            PERIOD_TO = 0;
            LAST_DATE_RUN = 0;
            LAST_TIME_RUN = 0;
            LAST_RUN_DTTM = "";
            PROCESS_STATUS = "";
            PROCESS_PERCENT = 0;
            RUN_DTTM_START = "";
            RUN_DTTM_END = "";
            ERR_MSG = "";
            ALERT_MSG = "";
            ALERT_IND = 0;
            TOTAL_REC_UPDATED = 0;
            TOTAL_REC_READ = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_ID { get; set; }
        public Int16 JOB_SEQ { get; set; }
        public string JOB_NAME { get; set; }
        public Int16 JOB_GROUP { get; set; }
        public Int16 PROCESSOR_TYPE { get; set; }
        public string EXECUTE_PROGRAM_ID { get; set; }
        public string PASSING_ARGUMENT { get; set; }
        public string EXECUTE_PATH { get; set; }
        public string DEPENDANT_ID { get; set; }
        public int PROCESS_RETURN_CODE { get; set; }
        public int PROCESS_RETURN_CODE1 { get; set; }
        public Int16 STATUS { get; set; }
        public string PROCESS_PERIOD { get; set; }
        public Int16 REPEAT_CYCLE { get; set; }
        public string FREQUENCY { get; set; }
        public Int16 PROCESS_INSTRUCT { get; set; }
        public int PERIOD_FROM { get; set; }
        public int PERIOD_TO { get; set; }
        public int LAST_DATE_RUN { get; set; }
        public int LAST_TIME_RUN { get; set; }
        public string LAST_RUN_DTTM { get; set; }
        public string PROCESS_STATUS { get; set; }
        public double PROCESS_PERCENT { get; set; }
        public string RUN_DTTM_START { get; set; }
        public string RUN_DTTM_END { get; set; }
        public string ERR_MSG { get; set; }
        public string ALERT_MSG { get; set; }
        public Int16 ALERT_IND { get; set; }
        public int TOTAL_REC_UPDATED { get; set; }
        public int TOTAL_REC_READ { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}