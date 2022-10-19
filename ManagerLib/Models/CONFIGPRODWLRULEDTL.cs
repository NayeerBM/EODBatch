using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    #region Extra Class
    public class BuildSql_Details
    {
        public Int16 TABLE_FD_ID { get; set; }
        public string strWatchlistFieldValue { get; set; }
        public string strWatchlistFieldUsed { get; set; }
        public string strWatchlistFieldValueDistict { get; set; }
        public string strSQLStmtSkipRec { get; set; }
        public Int16 EQ_LIST_PERCENT { get; set; }
        
    }

    #endregion


    public class CONFIGPRODWLRULEDTL
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_TEMPLATE_ID { get; set; }
        [Key, Column(Order = 3)]
        public Int16 TABLE_FD_ID { get; set; }
        public Int16 TABLE_PARENT_ID { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public Int16 FIELD_USED_IND { get; set; }
        public string TABLE_FD_NAME { get; set; }
        public string TABLE_FD_DISP_DESC { get; set; }
        public string TABLE_FD_DISP_DESC_OTHER { get; set; }
        public string TABLE_FD_TARGET_NAME { get; set; }
        public string TABLE_FD_TARGET_DISP_DESC { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("CONFIGPRODWLRULEDTL")]
    public class _CONFIGPRODWLRULEDTL
    {

        public _CONFIGPRODWLRULEDTL() { }

        public _CONFIGPRODWLRULEDTL(bool setDefaultValue)
        {
            COMP_CODE = 0;
            WL_TEMPLATE_ID = 0;
            TABLE_FD_ID = 0;
            TABLE_PARENT_ID = 0;
            PRODUCT_TYPE = 0;
            FIELD_USED_IND = 0;
            TABLE_FD_NAME = "";
            TABLE_FD_DISP_DESC = "";
            TABLE_FD_DISP_DESC_OTHER = "";
            TABLE_FD_TARGET_NAME = "";
            TABLE_FD_TARGET_DISP_DESC = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_TEMPLATE_ID { get; set; }
        [Key, Column(Order = 3)]
        public Int16 TABLE_FD_ID { get; set; }
        public Int16 TABLE_PARENT_ID { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public Int16 FIELD_USED_IND { get; set; }
        public string TABLE_FD_NAME { get; set; }
        public string TABLE_FD_DISP_DESC { get; set; }
        public string TABLE_FD_DISP_DESC_OTHER { get; set; }
        public string TABLE_FD_TARGET_NAME { get; set; }
        public string TABLE_FD_TARGET_DISP_DESC { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}