using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class EQUATION
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string EQ_ID { get; set; }
        public string EQ_NAME { get; set; }
        public string EQ_CURRENCY { get; set; }
        public Int16 EQ_RULE_TYPE { get; set; }
        public double EQ_WEIGHT { get; set; }
        public double EQ_MIN_TRAN_AMOUNT { get; set; }
        public double EQ_MAX_TRAN_AMOUNT { get; set; }
        public int EQ_MIN_TRAN_COUNT { get; set; }
        public int EQ_MAX_TRAN_COUNT { get; set; }
        public int EQ_TRAN_VELOCITY { get; set; }
        public double EQ_TRAN_VALUE { get; set; }
        public Int16 EQ_NO_OF_DAYS { get; set; }
        public string EQ_MONITOR_TYPE { get; set; }
        public string EQ_OCCURRED_EVENT { get; set; }
        public string EQ_TABLE_FD_ID { get; set; }
        public string EQ_TBL_REL_OPERATOR { get; set; }
        public string EQ_TBL_TRAN_VALUE { get; set; }
        public double EQ_TBL_PER_VALUE { get; set; }
        public string EQ_PERCENT_IND { get; set; }
        public string EQ_TABLE_FD_ID_TO { get; set; }
        public int EQ_TBL_TRAN_VELOCITY { get; set; }
        public Int16 EQ_LIST_PERCENT1 { get; set; }
        public Int16 EQ_LIST_PERCENT2 { get; set; }
        public Int16 EQ_LIST_PERCENT3 { get; set; }
        public Int16 EQ_LIST_PERCENT4 { get; set; }
        public Int16 EQ_LIST_PERCENT5 { get; set; }
        public Int16 EQ_LIST_PERCENT6 { get; set; }
        public Int16 EQ_LIST_PERCENT7 { get; set; }
        public Int16 EQ_LIST_PERCENT8 { get; set; }
        public Int16 EQ_LIST_PERCENT9 { get; set; }
        public Int16 EQ_LIST_PERCENT10 { get; set; }
        public Int16 EQ_LIST_PERCENT11 { get; set; }
        public Int16 EQ_LIST_PERCENT12 { get; set; }
        public Int16 EQ_LIST_PERCENT13 { get; set; }
        public Int16 EQ_LIST_PERCENT14 { get; set; }
        public Int16 EQ_LIST_PERCENT15 { get; set; }
        public Int16 EQ_LIST_PERCENT16 { get; set; }
        public string EQ_AND_OR_STRING { get; set; }
        public Int16 EQ_APPLY_FULL_MATCH { get; set; }
        public Int16 EQ_APPLY_SOUNDEX { get; set; }
        public string EQ_REMARK { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("EQUATION")]
    public class _EQUATION
    {

        public _EQUATION() { }

        public _EQUATION(bool setDefaultValue)
        {
            COMP_CODE = 0;
            EQ_ID = "";
            EQ_NAME = "";
            EQ_CURRENCY = "";
            EQ_RULE_TYPE = 0;
            EQ_WEIGHT = 0;
            EQ_MIN_TRAN_AMOUNT = 0;
            EQ_MAX_TRAN_AMOUNT = 0;
            EQ_MIN_TRAN_COUNT = 0;
            EQ_MAX_TRAN_COUNT = 0;
            EQ_TRAN_VELOCITY = 0;
            EQ_TRAN_VALUE = 0;
            EQ_NO_OF_DAYS = 0;
            EQ_MONITOR_TYPE = "";
            EQ_OCCURRED_EVENT = "";
            EQ_TABLE_FD_ID = "";
            EQ_TBL_REL_OPERATOR = "";
            EQ_TBL_TRAN_VALUE = "";
            EQ_TBL_PER_VALUE = 0;
            EQ_PERCENT_IND = "";
            EQ_TABLE_FD_ID_TO = "";
            EQ_TBL_TRAN_VELOCITY = 0;
            EQ_LIST_PERCENT1 = 0;
            EQ_LIST_PERCENT2 = 0;
            EQ_LIST_PERCENT3 = 0;
            EQ_LIST_PERCENT4 = 0;
            EQ_LIST_PERCENT5 = 0;
            EQ_LIST_PERCENT6 = 0;
            EQ_LIST_PERCENT7 = 0;
            EQ_LIST_PERCENT8 = 0;
            EQ_LIST_PERCENT9 = 0;
            EQ_LIST_PERCENT10 = 0;
            EQ_LIST_PERCENT11 = 0;
            EQ_LIST_PERCENT12 = 0;
            EQ_LIST_PERCENT13 = 0;
            EQ_LIST_PERCENT14 = 0;
            EQ_LIST_PERCENT15 = 0;
            EQ_LIST_PERCENT16 = 0;
            EQ_AND_OR_STRING = "";
            EQ_APPLY_FULL_MATCH = 0;
            EQ_APPLY_SOUNDEX = 0;
            EQ_REMARK = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string EQ_ID { get; set; }
        public string EQ_NAME { get; set; }
        public string EQ_CURRENCY { get; set; }
        public Int16 EQ_RULE_TYPE { get; set; }
        public double EQ_WEIGHT { get; set; }
        public double EQ_MIN_TRAN_AMOUNT { get; set; }
        public double EQ_MAX_TRAN_AMOUNT { get; set; }
        public int EQ_MIN_TRAN_COUNT { get; set; }
        public int EQ_MAX_TRAN_COUNT { get; set; }
        public int EQ_TRAN_VELOCITY { get; set; }
        public double EQ_TRAN_VALUE { get; set; }
        public Int16 EQ_NO_OF_DAYS { get; set; }
        public string EQ_MONITOR_TYPE { get; set; }
        public string EQ_OCCURRED_EVENT { get; set; }
        public string EQ_TABLE_FD_ID { get; set; }
        public string EQ_TBL_REL_OPERATOR { get; set; }
        public string EQ_TBL_TRAN_VALUE { get; set; }
        public double EQ_TBL_PER_VALUE { get; set; }
        public string EQ_PERCENT_IND { get; set; }
        public string EQ_TABLE_FD_ID_TO { get; set; }
        public int EQ_TBL_TRAN_VELOCITY { get; set; }
        public Int16 EQ_LIST_PERCENT1 { get; set; }
        public Int16 EQ_LIST_PERCENT2 { get; set; }
        public Int16 EQ_LIST_PERCENT3 { get; set; }
        public Int16 EQ_LIST_PERCENT4 { get; set; }
        public Int16 EQ_LIST_PERCENT5 { get; set; }
        public Int16 EQ_LIST_PERCENT6 { get; set; }
        public Int16 EQ_LIST_PERCENT7 { get; set; }
        public Int16 EQ_LIST_PERCENT8 { get; set; }
        public Int16 EQ_LIST_PERCENT9 { get; set; }
        public Int16 EQ_LIST_PERCENT10 { get; set; }
        public Int16 EQ_LIST_PERCENT11 { get; set; }
        public Int16 EQ_LIST_PERCENT12 { get; set; }
        public Int16 EQ_LIST_PERCENT13 { get; set; }
        public Int16 EQ_LIST_PERCENT14 { get; set; }
        public Int16 EQ_LIST_PERCENT15 { get; set; }
        public Int16 EQ_LIST_PERCENT16 { get; set; }
        public string EQ_AND_OR_STRING { get; set; }
        public Int16 EQ_APPLY_FULL_MATCH { get; set; }
        public Int16 EQ_APPLY_SOUNDEX { get; set; }
        public string EQ_REMARK { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}