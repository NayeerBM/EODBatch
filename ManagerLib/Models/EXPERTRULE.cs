using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class EXPERTRULE
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ER_ID { get; set; }
        public string ER_NAME { get; set; }
        public string ER_DESCRIPTION { get; set; }
        public string ER_TRAN_TYPE { get; set; }
        public string ER_PATTERN_TYPE { get; set; }
        public Int16 ER_RANK { get; set; }
        public double ER_THRESHOLD { get; set; }
        public double ER_COMPUTED_THRESHOLD { get; set; }
        public string ER_DETECTION_METHOD { get; set; }
        public string ER_PERIOD { get; set; }
        public Int16 ER_FILTER_ACCT_STATUS { get; set; }
        public Int16 ER_FILTER_TRANHIST_STATUS { get; set; }
        public string ER_TRANHIST_SQL_STMT { get; set; }
        public string ER_REMARK { get; set; }
        public Int16 ER_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string ER_COMPUTE_METHOD1 { get; set; }
        #endregion

    }
    [Table("EXPERTRULE")]
    public class _EXPERTRULE
    {

        public _EXPERTRULE() { }

        public _EXPERTRULE(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ER_ID = "";
            ER_NAME = "";
            ER_DESCRIPTION = "";
            ER_TRAN_TYPE = "";
            ER_PATTERN_TYPE = "";
            ER_RANK = 0;
            ER_THRESHOLD = 0;
            ER_COMPUTED_THRESHOLD = 0;
            ER_DETECTION_METHOD = "";
            ER_PERIOD = "";
            ER_FILTER_ACCT_STATUS = 0;
            ER_FILTER_TRANHIST_STATUS = 0;
            ER_TRANHIST_SQL_STMT = "";
            ER_REMARK = "";
            ER_STATUS = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
            ER_COMPUTE_METHOD1 = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ER_ID { get; set; }
        public string ER_NAME { get; set; }
        public string ER_DESCRIPTION { get; set; }
        public string ER_TRAN_TYPE { get; set; }
        public string ER_PATTERN_TYPE { get; set; }
        public Int16 ER_RANK { get; set; }
        public double ER_THRESHOLD { get; set; }
        public double ER_COMPUTED_THRESHOLD { get; set; }
        public string ER_DETECTION_METHOD { get; set; }
        public string ER_PERIOD { get; set; }
        public Int16 ER_FILTER_ACCT_STATUS { get; set; }
        public Int16 ER_FILTER_TRANHIST_STATUS { get; set; }
        public string ER_TRANHIST_SQL_STMT { get; set; }
        public string ER_REMARK { get; set; }
        public Int16 ER_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string ER_COMPUTE_METHOD1 { get; set; }
        #endregion

    }

}