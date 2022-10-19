using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class GROUPINGLINK_INFO
    {

        public Int16 COMP_CODE { get; set; }
        public string ER_DETECTION_METHOD { get; set; }
        public Int16 GRP_FILTER_STATUS { get; set; }
        public string GRP_ID { get; set; }
        public Int16 GRP_RANK { get; set; }
        public int GRP_ACTION_GUIDE_NO { get; set; }
        public string ER_ID { get; set; }
        public string ER_NAME { get; set; }
        public Int16 ER_RANK { get; set; }
        public double ER_THRESHOLD { get; set; }
        public double ER_COMPUTED_THRESHOLD { get; set; }
        public string EQ_ID { get; set; }
        public string EQ_NAME { get; set; }
        public Int16 EQ_RULE_TYPE { get; set; }
        public double EQ_WEIGHT { get; set; }
        public string EQ_AND_OR_STRING { get; set; }
        public Int16 EQ_APPLY_SOUNDEX { get; set; }
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

        public string GRP_FILTER_SQL_STMT { get; set; }
        public string GRP_ACCT_SQL_STMT { get; set; }
        public string GRP_HIST_SQL_STMT { get; set; }
    }
    public class GROUPINGLINK
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string GROUPING_ID { get; set; }
        [Key, Column(Order = 3)]
        public string GROUPING_TYPE { get; set; }
        [Key, Column(Order = 4)]
        public string GROUPING_LINK_ID { get; set; }
        public Int16 GROUPING_PROCESS_ID { get; set; }
        public Int16 GROUPING_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("GROUPINGLINK")]
    public class _GROUPINGLINK
    {

        public _GROUPINGLINK() { }

        public _GROUPINGLINK(bool setDefaultValue)
        {
            COMP_CODE = 0;
            GROUPING_ID = "";
            GROUPING_TYPE = "";
            GROUPING_LINK_ID = "";
            GROUPING_PROCESS_ID = 0;
            GROUPING_STATUS = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string GROUPING_ID { get; set; }
        [Key, Column(Order = 3)]
        public string GROUPING_TYPE { get; set; }
        [Key, Column(Order = 4)]
        public string GROUPING_LINK_ID { get; set; }
        public Int16 GROUPING_PROCESS_ID { get; set; }
        public Int16 GROUPING_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
