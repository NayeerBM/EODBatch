using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class JOBTRAN
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_DATE { get; set; }
        [Key, Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TRAN_SEQ { get; set; }
        public int RUN_TIME { get; set; }
        public Int64 TOTAL_RECORDS { get; set; }
        public Int64 PROCESS_RECORDS { get; set; }
        public string PROCESS_STATUS { get; set; }
        public double PROCESS_PERCENT { get; set; }
        public string RUN_DTTM_START { get; set; }
        public string RUN_DTTM_END { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public string REMARKS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("JOBTRAN")]
    public class _JOBTRAN
    {

        public _JOBTRAN() { }

        public _JOBTRAN(bool setDefaultValue)
        {
            COMP_CODE = 0;
            JOB_ID = "";
            RUN_DATE = 0;
            TRAN_SEQ = 0;
            RUN_TIME = 0;
            TOTAL_RECORDS = 0;
            PROCESS_RECORDS = 0;
            PROCESS_STATUS = "";
            PROCESS_PERCENT = 0;
            RUN_DTTM_START = "";
            RUN_DTTM_END = "";
            BATCH_DATE = 0;
            BATCH_NO = "";
            REMARKS = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_DATE { get; set; }
        [Key, Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TRAN_SEQ { get; set; }
        public int RUN_TIME { get; set; }
        public Int64 TOTAL_RECORDS { get; set; }
        public Int64 PROCESS_RECORDS { get; set; }
        public string PROCESS_STATUS { get; set; }
        public double PROCESS_PERCENT { get; set; }
        public string RUN_DTTM_START { get; set; }
        public string RUN_DTTM_END { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public string REMARKS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
