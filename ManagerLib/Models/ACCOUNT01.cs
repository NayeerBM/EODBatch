using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ACCOUNT01
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string ACCOUNT_TYPE { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public string BR_CODE { get; set; }
        public int DATE_OF_ACCT_OPENED { get; set; }
        public string ACCOUNT_STATUS { get; set; }
        public int DATE_OF_ACCT_CLOSED { get; set; }
        public string TYPE_OF_OWNERSHIP { get; set; }
        public double BALANCE_VALUE1 { get; set; }
        public double BALANCE_VALUE2 { get; set; }
        public int FALSE_POSITIVE_DT { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public string RISK_LEVEL { get; set; }
        public string FieldA17 { get; set; }
        public string FieldA18 { get; set; }
        public string FieldA19 { get; set; }
        public string FieldA20 { get; set; }
        public string AField01 { get; set; }
        public string AField02 { get; set; }
        public string AField03 { get; set; }
        public string AField04 { get; set; }
        public string AField05 { get; set; }
        public string AField06 { get; set; }
        public string AField07 { get; set; }
        public string AField08 { get; set; }
        public string AField09 { get; set; }
        public string AField10 { get; set; }
        public string AField11 { get; set; }
        public string AField12 { get; set; }
        public string AField13 { get; set; }
        public string AField14 { get; set; }
        public string AField15 { get; set; }
        public string AField16 { get; set; }
        public string AField17 { get; set; }
        public string AField18 { get; set; }
        public string AField19 { get; set; }
        public string AField20 { get; set; }
        public string AField21 { get; set; }
        public string AField22 { get; set; }
        public string AField23 { get; set; }
        public string AField24 { get; set; }
        public string AField25 { get; set; }
        public string AField26 { get; set; }
        public string AField27 { get; set; }
        public string AField28 { get; set; }
        public string AField29 { get; set; }
        public string AField30 { get; set; }
        public double AField131 { get; set; }
        public double AField132 { get; set; }
        public double AField133 { get; set; }
        public double AField134 { get; set; }
        public double AField135 { get; set; }
        public double AField136 { get; set; }
        public double AField137 { get; set; }
        public double AField138 { get; set; }
        public double AField139 { get; set; }
        public double AField140 { get; set; }
        public double AField141 { get; set; }
        public double AField142 { get; set; }
        public double AField143 { get; set; }
        public double AField144 { get; set; }
        public double AField145 { get; set; }
        public double AField146 { get; set; }
        public double AField147 { get; set; }
        public double AField148 { get; set; }
        public double AField149 { get; set; }
        public double AField150 { get; set; }
        public int AField151 { get; set; }
        public int AField152 { get; set; }
        public int AField153 { get; set; }
        public int AField154 { get; set; }
        public int AField155 { get; set; }
        public int AField156 { get; set; }
        public int AField157 { get; set; }
        public int AField158 { get; set; }
        public int AField159 { get; set; }
        public int AField160 { get; set; }
        public int AField161 { get; set; }
        public int AField162 { get; set; }
        public int AField163 { get; set; }
        public int AField164 { get; set; }
        public int AField165 { get; set; }
        public int FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ACCOUNT01")]
    public class _ACCOUNT01
    {

        public _ACCOUNT01() { }

        public _ACCOUNT01(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ACCOUNT_NO = "";
            CIF_ID = "";
            ACCOUNT_NAME = "";
            ACCOUNT_TYPE = "";
            PRODUCT_TYPE = 0;
            BR_CODE = "";
            DATE_OF_ACCT_OPENED = 0;
            ACCOUNT_STATUS = "";
            DATE_OF_ACCT_CLOSED = 0;
            TYPE_OF_OWNERSHIP = "";
            BALANCE_VALUE1 = 0;
            BALANCE_VALUE2 = 0;
            FALSE_POSITIVE_DT = 0;
            FALSE_POSITIVE_IND = 0;
            RISK_LEVEL = "";
            FieldA17 = "";
            FieldA18 = "";
            FieldA19 = "";
            FieldA20 = "";
            AField01 = "";
            AField02 = "";
            AField03 = "";
            AField04 = "";
            AField05 = "";
            AField06 = "";
            AField07 = "";
            AField08 = "";
            AField09 = "";
            AField10 = "";
            AField11 = "";
            AField12 = "";
            AField13 = "";
            AField14 = "";
            AField15 = "";
            AField16 = "";
            AField17 = "";
            AField18 = "";
            AField19 = "";
            AField20 = "";
            AField21 = "";
            AField22 = "";
            AField23 = "";
            AField24 = "";
            AField25 = "";
            AField26 = "";
            AField27 = "";
            AField28 = "";
            AField29 = "";
            AField30 = "";
            AField131 = 0;
            AField132 = 0;
            AField133 = 0;
            AField134 = 0;
            AField135 = 0;
            AField136 = 0;
            AField137 = 0;
            AField138 = 0;
            AField139 = 0;
            AField140 = 0;
            AField141 = 0;
            AField142 = 0;
            AField143 = 0;
            AField144 = 0;
            AField145 = 0;
            AField146 = 0;
            AField147 = 0;
            AField148 = 0;
            AField149 = 0;
            AField150 = 0;
            AField151 = 0;
            AField152 = 0;
            AField153 = 0;
            AField154 = 0;
            AField155 = 0;
            AField156 = 0;
            AField157 = 0;
            AField158 = 0;
            AField159 = 0;
            AField160 = 0;
            AField161 = 0;
            AField162 = 0;
            AField163 = 0;
            AField164 = 0;
            AField165 = 0;
            FALSE_POSITIVE_DT_WL = 0;
            FALSE_POSITIVE_IND_WL = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string ACCOUNT_TYPE { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public string BR_CODE { get; set; }
        public int DATE_OF_ACCT_OPENED { get; set; }
        public string ACCOUNT_STATUS { get; set; }
        public int DATE_OF_ACCT_CLOSED { get; set; }
        public string TYPE_OF_OWNERSHIP { get; set; }
        public double BALANCE_VALUE1 { get; set; }
        public double BALANCE_VALUE2 { get; set; }
        public int FALSE_POSITIVE_DT { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public string RISK_LEVEL { get; set; }
        public string FieldA17 { get; set; }
        public string FieldA18 { get; set; }
        public string FieldA19 { get; set; }
        public string FieldA20 { get; set; }
        public string AField01 { get; set; }
        public string AField02 { get; set; }
        public string AField03 { get; set; }
        public string AField04 { get; set; }
        public string AField05 { get; set; }
        public string AField06 { get; set; }
        public string AField07 { get; set; }
        public string AField08 { get; set; }
        public string AField09 { get; set; }
        public string AField10 { get; set; }
        public string AField11 { get; set; }
        public string AField12 { get; set; }
        public string AField13 { get; set; }
        public string AField14 { get; set; }
        public string AField15 { get; set; }
        public string AField16 { get; set; }
        public string AField17 { get; set; }
        public string AField18 { get; set; }
        public string AField19 { get; set; }
        public string AField20 { get; set; }
        public string AField21 { get; set; }
        public string AField22 { get; set; }
        public string AField23 { get; set; }
        public string AField24 { get; set; }
        public string AField25 { get; set; }
        public string AField26 { get; set; }
        public string AField27 { get; set; }
        public string AField28 { get; set; }
        public string AField29 { get; set; }
        public string AField30 { get; set; }
        public double AField131 { get; set; }
        public double AField132 { get; set; }
        public double AField133 { get; set; }
        public double AField134 { get; set; }
        public double AField135 { get; set; }
        public double AField136 { get; set; }
        public double AField137 { get; set; }
        public double AField138 { get; set; }
        public double AField139 { get; set; }
        public double AField140 { get; set; }
        public double AField141 { get; set; }
        public double AField142 { get; set; }
        public double AField143 { get; set; }
        public double AField144 { get; set; }
        public double AField145 { get; set; }
        public double AField146 { get; set; }
        public double AField147 { get; set; }
        public double AField148 { get; set; }
        public double AField149 { get; set; }
        public double AField150 { get; set; }
        public int AField151 { get; set; }
        public int AField152 { get; set; }
        public int AField153 { get; set; }
        public int AField154 { get; set; }
        public int AField155 { get; set; }
        public int AField156 { get; set; }
        public int AField157 { get; set; }
        public int AField158 { get; set; }
        public int AField159 { get; set; }
        public int AField160 { get; set; }
        public int AField161 { get; set; }
        public int AField162 { get; set; }
        public int AField163 { get; set; }
        public int AField164 { get; set; }
        public int AField165 { get; set; }
        public int FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
