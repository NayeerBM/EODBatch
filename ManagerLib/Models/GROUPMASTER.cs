using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class GROUPMASTER
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string GRP_ID { get; set; }
        public string GRP_NAME { get; set; }
        public string GRP_DESCRIPTION { get; set; }
        public Int16 GRP_TYPE { get; set; }
        public Int16 GRP_AML_IND { get; set; }
        public Int16 GRP_MKT_IND { get; set; }
        public Int16 GRP_RANK { get; set; }
        public Int16 GRP_CHECK_RA_IND { get; set; }
        public double GRP_MIN_RA_SCORE { get; set; }
        public Int16 GRP_CHECK_DL_IND { get; set; }
        public double GRP_MIN_DL_SCORE { get; set; }
        public Int16 GRP_CHECK_PROF_IND { get; set; }
        public double GRP_MIN_PROF_SCORE { get; set; }
        public Int16 GRP_CHECK_Q_IND { get; set; }
        public double GRP_MIN_Q_SCORE { get; set; }
        public string GRP_REMARK { get; set; }
        public Int16 GRP_DEFAULT_GROUP { get; set; }
        public Int16 GRP_FILTER_STATUS { get; set; }
        public string GRP_FILTER_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_TRAN_STATUS { get; set; }
        public string GRP_TRAN_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_ACCT_STATUS { get; set; }
        public string GRP_ACCT_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_CIF_STATUS { get; set; }
        public string GRP_CIF_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_HIST_STATUS { get; set; }
        public string GRP_HIST_SQL_STMT { get; set; }
        public string GRP_GROUP_SORT_KEY { get; set; }
        public int GRP_ACTION_GUIDE_NO { get; set; }
        public Int16 GRP_SHOW_RULETYPE { get; set; }
        public Int16 GRP_USEDPRIKEY_CIFACCT { get; set; }
        public string GRP_USEDPRIKEY_SPECIAL { get; set; }
        public string GRP_AML_TRANCODE { get; set; }
        public Int16 GRP_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public Int16 GRP_ENT_RISK { get; set; }
        public Int16 GRP_REPEAT_ALERT_IN_DAY { get; set; }
        public Int16 GRP_AFTER_NO_OF_TIME { get; set; }
        #endregion

    }
    [Table("GROUPMASTER")]
    public class _GROUPMASTER
    {

        public _GROUPMASTER() { }

        public _GROUPMASTER(bool setDefaultValue)
        {
            COMP_CODE = 0;
            GRP_ID = "";
            GRP_NAME = "";
            GRP_DESCRIPTION = "";
            GRP_TYPE = 0;
            GRP_AML_IND = 0;
            GRP_MKT_IND = 0;
            GRP_RANK = 0;
            GRP_CHECK_RA_IND = 0;
            GRP_MIN_RA_SCORE = 0;
            GRP_CHECK_DL_IND = 0;
            GRP_MIN_DL_SCORE = 0;
            GRP_CHECK_PROF_IND = 0;
            GRP_MIN_PROF_SCORE = 0;
            GRP_CHECK_Q_IND = 0;
            GRP_MIN_Q_SCORE = 0;
            GRP_REMARK = "";
            GRP_DEFAULT_GROUP = 0;
            GRP_FILTER_STATUS = 0;
            GRP_FILTER_SQL_STMT = "";
            GRP_FILTER_TRAN_STATUS = 0;
            GRP_TRAN_SQL_STMT = "";
            GRP_FILTER_ACCT_STATUS = 0;
            GRP_ACCT_SQL_STMT = "";
            GRP_FILTER_CIF_STATUS = 0;
            GRP_CIF_SQL_STMT = "";
            GRP_FILTER_HIST_STATUS = 0;
            GRP_HIST_SQL_STMT = "";
            GRP_GROUP_SORT_KEY = "";
            GRP_ACTION_GUIDE_NO = 0;
            GRP_SHOW_RULETYPE = 0;
            GRP_USEDPRIKEY_CIFACCT = 0;
            GRP_USEDPRIKEY_SPECIAL = "";
            GRP_AML_TRANCODE = "";
            GRP_STATUS = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
            GRP_ENT_RISK = 0;
            GRP_REPEAT_ALERT_IN_DAY = 0;
            GRP_AFTER_NO_OF_TIME = 0;
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string GRP_ID { get; set; }
        public string GRP_NAME { get; set; }
        public string GRP_DESCRIPTION { get; set; }
        public Int16 GRP_TYPE { get; set; }
        public Int16 GRP_AML_IND { get; set; }
        public Int16 GRP_MKT_IND { get; set; }
        public Int16 GRP_RANK { get; set; }
        public Int16 GRP_CHECK_RA_IND { get; set; }
        public double GRP_MIN_RA_SCORE { get; set; }
        public Int16 GRP_CHECK_DL_IND { get; set; }
        public double GRP_MIN_DL_SCORE { get; set; }
        public Int16 GRP_CHECK_PROF_IND { get; set; }
        public double GRP_MIN_PROF_SCORE { get; set; }
        public Int16 GRP_CHECK_Q_IND { get; set; }
        public double GRP_MIN_Q_SCORE { get; set; }
        public string GRP_REMARK { get; set; }
        public Int16 GRP_DEFAULT_GROUP { get; set; }
        public Int16 GRP_FILTER_STATUS { get; set; }
        public string GRP_FILTER_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_TRAN_STATUS { get; set; }
        public string GRP_TRAN_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_ACCT_STATUS { get; set; }
        public string GRP_ACCT_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_CIF_STATUS { get; set; }
        public string GRP_CIF_SQL_STMT { get; set; }
        public Int16 GRP_FILTER_HIST_STATUS { get; set; }
        public string GRP_HIST_SQL_STMT { get; set; }
        public string GRP_GROUP_SORT_KEY { get; set; }
        public int GRP_ACTION_GUIDE_NO { get; set; }
        public Int16 GRP_SHOW_RULETYPE { get; set; }
        public Int16 GRP_USEDPRIKEY_CIFACCT { get; set; }
        public string GRP_USEDPRIKEY_SPECIAL { get; set; }
        public string GRP_AML_TRANCODE { get; set; }
        public Int16 GRP_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public Int16 GRP_ENT_RISK { get; set; }
        public Int16 GRP_REPEAT_ALERT_IN_DAY { get; set; }
        public Int16 GRP_AFTER_NO_OF_TIME { get; set; }
        #endregion

    }

}