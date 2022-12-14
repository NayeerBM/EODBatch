using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WatchlistAlgorightmDetails
    {
        public Int16 WL_ALGO { get; set; }
        public Int16 ENABLED { get; set; }
        public string WL_TYPE { get; set; }
        public string WL_KEY { get; set; }
        public string WL_VALUE { get; set; }
        public Int16 SHOW_NO_OF_TOP_REC { get; set; }
    }


    public class WatchlistAlgorithmDtl
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_ALGO { get; set; }
        [Key, Column(Order = 3)]
        public string WL_TYPE { get; set; }
        [Key, Column(Order = 4)]
        public string WL_KEY { get; set; }
        public string WL_DTL_DESC { get; set; }
        public Int16 SET_HIT_PERCENTS { get; set; }
        public Int16 APPLY_EDIT_DISTANT { get; set; }
        public Int16 SHOW_NO_OF_TOP_REC { get; set; }
        public int NUMERIC_VALUE { get; set; }
        public string TEXT_VALUE { get; set; }
        public int BOOLEAN_VALUE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("WatchlistAlgorithmDtl")]
    public class _WatchlistAlgorithmDtl
    {

        public _WatchlistAlgorithmDtl() { }

        public _WatchlistAlgorithmDtl(bool setDefaultValue)
        {
            COMP_CODE = 0;
            WL_ALGO = 0;
            WL_TYPE = "";
            WL_KEY = "";
            WL_DTL_DESC = "";
            SET_HIT_PERCENTS = 0;
            APPLY_EDIT_DISTANT = 0;
            SHOW_NO_OF_TOP_REC = 0;
            NUMERIC_VALUE = 0;
            TEXT_VALUE = "";
            BOOLEAN_VALUE = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_ALGO { get; set; }
        [Key, Column(Order = 3)]
        public string WL_TYPE { get; set; }
        [Key, Column(Order = 4)]
        public string WL_KEY { get; set; }
        public string WL_DTL_DESC { get; set; }
        public Int16 SET_HIT_PERCENTS { get; set; }
        public Int16 APPLY_EDIT_DISTANT { get; set; }
        public Int16 SHOW_NO_OF_TOP_REC { get; set; }
        public int NUMERIC_VALUE { get; set; }
        public string TEXT_VALUE { get; set; }
        public int BOOLEAN_VALUE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
