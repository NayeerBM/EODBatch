using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    #region Extra Class
    public class BuildSql_Header
    {
        public Int16 TABLE_PARENT_ID { get; set; }
        public string WATCHLIST_SOURCE { get; set; }
        public string strWatchlistType { get; set; }
        public string strCountrySQLStmt1 { get; set; }
        public string strCountrySQLStmt2 { get; set; }
        public string strGenderSQLStmt1 { get; set; }
        public string strGenderSQLStmt2 { get; set; }
        public string strSQLCommonFdsUsedStmt { get; set; }
        public string strSQLCommonSortOrderStmt { get; set; }
        public string strTable_Name_Used { get; set; }
        public string strTable_Name { get; set; }
    }
    #endregion

    public class CONFIGPRODWLRULEHDR
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_TEMPLATE_ID { get; set; }
        public Int16 TABLE_PARENT_ID { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public string TABLE_NAME_INUSED { get; set; }
        public string WATCHLIST_SOURCE { get; set; }
        public string TABLE_DESCR { get; set; }
        public string TABLE_BRIEF_DESCR { get; set; }
        public string TABLE_REMARKS { get; set; }
        public Int16 TABLE_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public Int16 SCAN_PARTIAL { get; set; }
        #endregion

    }
    [Table("CONFIGPRODWLRULEHDR")]
    public class _CONFIGPRODWLRULEHDR
    {

        public _CONFIGPRODWLRULEHDR() { }

        public _CONFIGPRODWLRULEHDR(bool setDefaultValue)
        {
            COMP_CODE = 0;
            WL_TEMPLATE_ID = 0;
            TABLE_PARENT_ID = 0;
            PRODUCT_TYPE = 0;
            TABLE_NAME_INUSED = "";
            WATCHLIST_SOURCE = "";
            TABLE_DESCR = "";
            TABLE_BRIEF_DESCR = "";
            TABLE_REMARKS = "";
            TABLE_STATUS = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
            SCAN_PARTIAL = 0;
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int16 WL_TEMPLATE_ID { get; set; }
        public Int16 TABLE_PARENT_ID { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public string TABLE_NAME_INUSED { get; set; }
        public string WATCHLIST_SOURCE { get; set; }
        public string TABLE_DESCR { get; set; }
        public string TABLE_BRIEF_DESCR { get; set; }
        public string TABLE_REMARKS { get; set; }
        public Int16 TABLE_STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public Int16 SCAN_PARTIAL { get; set; }
        #endregion

    }

}