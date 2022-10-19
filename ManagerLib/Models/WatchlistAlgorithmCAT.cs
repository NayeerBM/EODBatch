using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WLAlgorithmCat
    {
        public string strFilterPEP { get; set; }
        public string strFilterSIPSIE { get; set; }
        public string strFilterSubCategory { get; set; }
        public string strFilterSanction { get; set; }
        public string iFilterCategory_CAT1 { get; set; }
        public string iFilterCategory_CAT2 { get; set; }
    }

    public class WatchlistAlgorithmCAT
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 CATEGROY_TYPE { get; set; }
        public string CAT_DESC { get; set; }
        public string CAT1 { get; set; }
        public string CAT2 { get; set; }
        public string CAT3 { get; set; }
        public string CAT4 { get; set; }
        public string CAT5 { get; set; }
        public Int16 EXCLUDED_CAT1 { get; set; }
        public Int16 EXCLUDED_CAT2 { get; set; }
        public Int16 EXCLUDED_CAT3 { get; set; }
        public Int16 EXCLUDED_CAT4 { get; set; }
        public Int16 EXCLUDED_CAT5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("WatchlistAlgorithmCAT")]
    public class _WatchlistAlgorithmCAT
    {

        public _WatchlistAlgorithmCAT() { }

        public _WatchlistAlgorithmCAT(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CATEGROY_TYPE = 0;
            CAT_DESC = "";
            CAT1 = "";
            CAT2 = "";
            CAT3 = "";
            CAT4 = "";
            CAT5 = "";
            EXCLUDED_CAT1 = 0;
            EXCLUDED_CAT2 = 0;
            EXCLUDED_CAT3 = 0;
            EXCLUDED_CAT4 = 0;
            EXCLUDED_CAT5 = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 CATEGROY_TYPE { get; set; }
        public string CAT_DESC { get; set; }
        public string CAT1 { get; set; }
        public string CAT2 { get; set; }
        public string CAT3 { get; set; }
        public string CAT4 { get; set; }
        public string CAT5 { get; set; }
        public Int16 EXCLUDED_CAT1 { get; set; }
        public Int16 EXCLUDED_CAT2 { get; set; }
        public Int16 EXCLUDED_CAT3 { get; set; }
        public Int16 EXCLUDED_CAT4 { get; set; }
        public Int16 EXCLUDED_CAT5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
}