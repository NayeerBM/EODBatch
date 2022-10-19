using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ALERTTRANWLIST
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public int SEQ_NO { get; set; }
        public string SEARCH_TYPE { get; set; }
        public string TABLE_NAME_USED { get; set; }
        public string KEY_FIELD1 { get; set; }
        public string KEY_FIELD2 { get; set; }
        public string SQL_WATCHLIST_FD_USED { get; set; }
        public string SQL_SEARCH_STMT { get; set; }
        public int NO_OF_ROWS_HIT { get; set; }
        public int NAME_HIT { get; set; }
        public int ID_HIT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public string CIF_ID { get; set; }
        public string DETECTION_METHOD { get; set; }
        public int WATCH_LIST_SCORE1 { get; set; }
        public int WATCH_LIST_SCORE2 { get; set; }
        public int WATCH_LIST_SCORE3 { get; set; }
        public int WATCH_LIST_SCORE4 { get; set; }
        public int WATCH_LIST_SCORE5 { get; set; }
        public int WATCH_LIST_SCORE6 { get; set; }
        public int WATCH_LIST_SCORE7 { get; set; }
        public int WATCH_LIST_SCORE8 { get; set; }
        public int WATCH_LIST_SCORE9 { get; set; }
        public int WATCH_LIST_SCORE10 { get; set; }
        public int WATCH_LIST_SCORE11 { get; set; }
        public int WATCH_LIST_SCORE12 { get; set; }
        public int WATCH_LIST_SCORE13 { get; set; }
        public int WATCH_LIST_SCORE14 { get; set; }
        public int WATCH_LIST_SCORE15 { get; set; }
        public int WATCH_LIST_SCORE16 { get; set; }
        public string EQ_AND_OR_STRING { get; set; }
        public Int16 EQ_APPLY_FULL_MATCH { get; set; }
        public Int16 EQ_APPLY_SOUNDEX { get; set; }
        public string WATCH_LIST_HIT { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ALERTTRANWLIST")]
    public class _ALERTTRANWLIST
    {

        public _ALERTTRANWLIST() { }

        public _ALERTTRANWLIST(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ALERT_ID = 0;
            SEQ_NO = 0;
            SEARCH_TYPE = "";
            TABLE_NAME_USED = "";
            KEY_FIELD1 = "";
            KEY_FIELD2 = "";
            SQL_WATCHLIST_FD_USED = "";
            SQL_SEARCH_STMT = "";
            NO_OF_ROWS_HIT = 0;
            NAME_HIT = 0;
            ID_HIT = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            CIF_ID = "";
            DETECTION_METHOD = "";
            WATCH_LIST_SCORE1 = 0;
            WATCH_LIST_SCORE2 = 0;
            WATCH_LIST_SCORE3 = 0;
            WATCH_LIST_SCORE4 = 0;
            WATCH_LIST_SCORE5 = 0;
            WATCH_LIST_SCORE6 = 0;
            WATCH_LIST_SCORE7 = 0;
            WATCH_LIST_SCORE8 = 0;
            WATCH_LIST_SCORE9 = 0;
            WATCH_LIST_SCORE10 = 0;
            WATCH_LIST_SCORE11 = 0;
            WATCH_LIST_SCORE12 = 0;
            WATCH_LIST_SCORE13 = 0;
            WATCH_LIST_SCORE14 = 0;
            WATCH_LIST_SCORE15 = 0;
            WATCH_LIST_SCORE16 = 0;
            EQ_AND_OR_STRING = "";
            EQ_APPLY_FULL_MATCH = 0;
            EQ_APPLY_SOUNDEX = 0;
            WATCH_LIST_HIT = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public int SEQ_NO { get; set; }
        public string SEARCH_TYPE { get; set; }
        public string TABLE_NAME_USED { get; set; }
        public string KEY_FIELD1 { get; set; }
        public string KEY_FIELD2 { get; set; }
        public string SQL_WATCHLIST_FD_USED { get; set; }
        public string SQL_SEARCH_STMT { get; set; }
        public int NO_OF_ROWS_HIT { get; set; }
        public int NAME_HIT { get; set; }
        public int ID_HIT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public string CIF_ID { get; set; }
        public string DETECTION_METHOD { get; set; }
        public int WATCH_LIST_SCORE1 { get; set; }
        public int WATCH_LIST_SCORE2 { get; set; }
        public int WATCH_LIST_SCORE3 { get; set; }
        public int WATCH_LIST_SCORE4 { get; set; }
        public int WATCH_LIST_SCORE5 { get; set; }
        public int WATCH_LIST_SCORE6 { get; set; }
        public int WATCH_LIST_SCORE7 { get; set; }
        public int WATCH_LIST_SCORE8 { get; set; }
        public int WATCH_LIST_SCORE9 { get; set; }
        public int WATCH_LIST_SCORE10 { get; set; }
        public int WATCH_LIST_SCORE11 { get; set; }
        public int WATCH_LIST_SCORE12 { get; set; }
        public int WATCH_LIST_SCORE13 { get; set; }
        public int WATCH_LIST_SCORE14 { get; set; }
        public int WATCH_LIST_SCORE15 { get; set; }
        public int WATCH_LIST_SCORE16 { get; set; }
        public string EQ_AND_OR_STRING { get; set; }
        public Int16 EQ_APPLY_FULL_MATCH { get; set; }
        public Int16 EQ_APPLY_SOUNDEX { get; set; }
        public string WATCH_LIST_HIT { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}