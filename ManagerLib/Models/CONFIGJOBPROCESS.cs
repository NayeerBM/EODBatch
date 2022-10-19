using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class CONFIGJOBPROCESS
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_CODE { get; set; }
        public Int16 JOB_PROCESSOR_TYPE { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_TASK_ID { get; set; }
        public string JOB_TRAN_TABLE { get; set; }
        public string JOB_ACCT_TABLE { get; set; }
        public string JOB_CIF_TABLE { get; set; }
        public string JOB_HIST_TABLE { get; set; }
        public string JOB_HIT_TRAN_TABLE { get; set; }
        public string JOB_ADDR_TABLE { get; set; }
        public string JOB_SQL_STMT { get; set; }
        public string JOB_REMARK { get; set; }
        public string JOB_PRODUCT_CODE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("CONFIGJOBPROCESS")]
    public class _CONFIGJOBPROCESS
    {

        public _CONFIGJOBPROCESS() { }

        public _CONFIGJOBPROCESS(bool setDefaultValue)
        {
            COMP_CODE = 0;
            JOB_CODE = "";
            JOB_PROCESSOR_TYPE = 0;
            JOB_NAME = "";
            JOB_TASK_ID = "";
            JOB_TRAN_TABLE = "";
            JOB_ACCT_TABLE = "";
            JOB_CIF_TABLE = "";
            JOB_HIST_TABLE = "";
            JOB_HIT_TRAN_TABLE = "";
            JOB_ADDR_TABLE = "";
            JOB_SQL_STMT = "";
            JOB_REMARK = "";
            JOB_PRODUCT_CODE = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string JOB_CODE { get; set; }
        public Int16 JOB_PROCESSOR_TYPE { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_TASK_ID { get; set; }
        public string JOB_TRAN_TABLE { get; set; }
        public string JOB_ACCT_TABLE { get; set; }
        public string JOB_CIF_TABLE { get; set; }
        public string JOB_HIST_TABLE { get; set; }
        public string JOB_HIT_TRAN_TABLE { get; set; }
        public string JOB_ADDR_TABLE { get; set; }
        public string JOB_SQL_STMT { get; set; }
        public string JOB_REMARK { get; set; }
        public string JOB_PRODUCT_CODE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}