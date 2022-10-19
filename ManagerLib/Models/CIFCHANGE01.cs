using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WatchlistResult
    {
        public string FIRST_NAME { get; set; }
        public string CIF_NO { get; set; }
        public string BR_CODE_CIF { get; set; }
        public string ACCOUNT_NO_X { get; set; }
        public string CIF_NO_X { get; set; }
        public string FdCIFAcctValue1 { get; set; }
        public string FdCIFAcctValue2 { get; set; }
        public string FdCIFAcctValue3 { get; set; }
        public string FdCIFAcctValue4 { get; set; }
        public string FdCIFAcctValue5 { get; set; }
        public string FdCIFAcctValue6 { get; set; }
        public string FdCIFAcctValue7 { get; set; }
        public string FdCIFAcctValue8 { get; set; }
        public string FdCIFAcctValue9 { get; set; }
        public string FdCIFAcctValue10 { get; set; }
        public string FdCIFAcctValue11 { get; set; }
        public string FdCIFAcctValue12 { get; set; }
        public string FdCIFAcctValue13 { get; set; }
        public string FdCIFAcctValue14 { get; set; }
        public string FdCIFAcctValue15 { get; set; }
        public string FdCIFAcctValue16 { get; set; }

    }

    public class CIFCHANGE01
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string CIF_NO { get; set; }
        public string BR_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string CIF_STATUS { get; set; }
        public string ID_TYPE { get; set; }
        public string ID_NUMBER { get; set; }
        public string ID_ISSUE_PLACE { get; set; }
        public int ID_ISSUE_DT { get; set; }
        public int ID_EXPIRY_DT { get; set; }
        public int ID_NEXT_VERIFY_DT { get; set; }
        public Int16 ID_STATUS { get; set; }
        public string ADDRESS_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string POSTAGE_CODE { get; set; }
        public string PHONE_NO { get; set; }
        public string OFFICE_PHONE_NO { get; set; }
        public string HAND_PHONE { get; set; }
        public string FAX_NO { get; set; }
        public string EMAIL_ADDR { get; set; }
        public Int16 ADDR_STATUS { get; set; }
        public int DATE_VALUE1 { get; set; }
        public int DATE_VALUE2 { get; set; }
        public int DATE_VALUE3 { get; set; }
        public int DATE_VALUE4 { get; set; }
        public int DATE_VALUE5 { get; set; }
        public int DATE_VALUE6 { get; set; }
        public int DATE_VALUE7 { get; set; }
        public int DATE_VALUE8 { get; set; }
        public int DATE_VALUE9 { get; set; }
        public int DATE_VALUE10 { get; set; }
        public string DATA_VALUE1 { get; set; }
        public string DATA_VALUE2 { get; set; }
        public string DATA_VALUE3 { get; set; }
        public string DATA_VALUE4 { get; set; }
        public string DATA_VALUE5 { get; set; }
        public string DATA_VALUE6 { get; set; }
        public string DATA_VALUE7 { get; set; }
        public string DATA_VALUE8 { get; set; }
        public string DATA_VALUE9 { get; set; }
        public string DATA_VALUE10 { get; set; }
        public string DATA_VALUE11 { get; set; }
        public string DATA_VALUE12 { get; set; }
        public string DATA_VALUE13 { get; set; }
        public string DATA_VALUE14 { get; set; }
        public string DATA_VALUE15 { get; set; }
        public string DATA_VALUE16 { get; set; }
        public string DATA_VALUE17 { get; set; }
        public string DATA_VALUE18 { get; set; }
        public string DATA_VALUE19 { get; set; }
        public string DATA_VALUE20 { get; set; }
        public string DATA_VALUE21 { get; set; }
        public string DATA_VALUE22 { get; set; }
        public string DATA_VALUE23 { get; set; }
        public string DATA_VALUE24 { get; set; }
        public string DATA_VALUE25 { get; set; }
        public string DATA_VALUE26 { get; set; }
        public string DATA_VALUE27 { get; set; }
        public string DATA_VALUE28 { get; set; }
        public string DATA_VALUE29 { get; set; }
        public string DATA_VALUE30 { get; set; }
        public string DATA_VALUE31 { get; set; }
        public string DATA_VALUE32 { get; set; }
        public string DATA_VALUE33 { get; set; }
        public string DATA_VALUE34 { get; set; }
        public string DATA_VALUE35 { get; set; }
        public string DATA_VALUE36 { get; set; }
        public string DATA_VALUE37 { get; set; }
        public string DATA_VALUE38 { get; set; }
        public string DATA_VALUE39 { get; set; }
        public string DATA_VALUE40 { get; set; }
        public string DATA_VALUE41 { get; set; }
        public string DATA_VALUE42 { get; set; }
        public string DATA_VALUE43 { get; set; }
        public string DATA_VALUE44 { get; set; }
        public int DATA_VALUE45 { get; set; }
        public int DATA_VALUE46 { get; set; }
        public int DATA_VALUE47 { get; set; }
        public int DATA_VALUE48 { get; set; }
        public int DATA_VALUE49 { get; set; }
        public int DATA_VALUE50 { get; set; }
        public int DATA_VALUE51 { get; set; }
        public int DATA_VALUE52 { get; set; }
        public int DATA_VALUE53 { get; set; }
        public int DATA_VALUE54 { get; set; }
        public int DATA_VALUE55 { get; set; }
        public int CIF_FALSE_POSITIVE_DT { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND { get; set; }
        public int CIF_FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string GIVEN_NAME { get; set; }
        #endregion

    }
    [Table("CIFCHANGE01")]
    public class _CIFCHANGE01
    {

        public _CIFCHANGE01() { }

        public _CIFCHANGE01(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CIF_NO = "";
            BR_CODE = "";
            FIRST_NAME = "";
            MIDDLE_NAME = "";
            LAST_NAME = "";
            CIF_STATUS = "";
            ID_TYPE = "";
            ID_NUMBER = "";
            ID_ISSUE_PLACE = "";
            ID_ISSUE_DT = 0;
            ID_EXPIRY_DT = 0;
            ID_NEXT_VERIFY_DT = 0;
            ID_STATUS = 0;
            ADDRESS_TYPE = "";
            ADDRESS = "";
            CITY = "";
            STATE = "";
            COUNTRY = "";
            POSTAGE_CODE = "";
            PHONE_NO = "";
            OFFICE_PHONE_NO = "";
            HAND_PHONE = "";
            FAX_NO = "";
            EMAIL_ADDR = "";
            ADDR_STATUS = 0;
            DATE_VALUE1 = 0;
            DATE_VALUE2 = 0;
            DATE_VALUE3 = 0;
            DATE_VALUE4 = 0;
            DATE_VALUE5 = 0;
            DATE_VALUE6 = 0;
            DATE_VALUE7 = 0;
            DATE_VALUE8 = 0;
            DATE_VALUE9 = 0;
            DATE_VALUE10 = 0;
            DATA_VALUE1 = "";
            DATA_VALUE2 = "";
            DATA_VALUE3 = "";
            DATA_VALUE4 = "";
            DATA_VALUE5 = "";
            DATA_VALUE6 = "";
            DATA_VALUE7 = "";
            DATA_VALUE8 = "";
            DATA_VALUE9 = "";
            DATA_VALUE10 = "";
            DATA_VALUE11 = "";
            DATA_VALUE12 = "";
            DATA_VALUE13 = "";
            DATA_VALUE14 = "";
            DATA_VALUE15 = "";
            DATA_VALUE16 = "";
            DATA_VALUE17 = "";
            DATA_VALUE18 = "";
            DATA_VALUE19 = "";
            DATA_VALUE20 = "";
            DATA_VALUE21 = "";
            DATA_VALUE22 = "";
            DATA_VALUE23 = "";
            DATA_VALUE24 = "";
            DATA_VALUE25 = "";
            DATA_VALUE26 = "";
            DATA_VALUE27 = "";
            DATA_VALUE28 = "";
            DATA_VALUE29 = "";
            DATA_VALUE30 = "";
            DATA_VALUE31 = "";
            DATA_VALUE32 = "";
            DATA_VALUE33 = "";
            DATA_VALUE34 = "";
            DATA_VALUE35 = "";
            DATA_VALUE36 = "";
            DATA_VALUE37 = "";
            DATA_VALUE38 = "";
            DATA_VALUE39 = "";
            DATA_VALUE40 = "";
            DATA_VALUE41 = "";
            DATA_VALUE42 = "";
            DATA_VALUE43 = "";
            DATA_VALUE44 = "";
            DATA_VALUE45 = 0;
            DATA_VALUE46 = 0;
            DATA_VALUE47 = 0;
            DATA_VALUE48 = 0;
            DATA_VALUE49 = 0;
            DATA_VALUE50 = 0;
            DATA_VALUE51 = 0;
            DATA_VALUE52 = 0;
            DATA_VALUE53 = 0;
            DATA_VALUE54 = 0;
            DATA_VALUE55 = 0;
            CIF_FALSE_POSITIVE_DT = 0;
            CIF_FALSE_POSITIVE_IND = 0;
            CIF_FALSE_POSITIVE_DT_WL = 0;
            CIF_FALSE_POSITIVE_IND_WL = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
            GIVEN_NAME = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string CIF_NO { get; set; }
        public string BR_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string CIF_STATUS { get; set; }
        public string ID_TYPE { get; set; }
        public string ID_NUMBER { get; set; }
        public string ID_ISSUE_PLACE { get; set; }
        public int ID_ISSUE_DT { get; set; }
        public int ID_EXPIRY_DT { get; set; }
        public int ID_NEXT_VERIFY_DT { get; set; }
        public Int16 ID_STATUS { get; set; }
        public string ADDRESS_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string POSTAGE_CODE { get; set; }
        public string PHONE_NO { get; set; }
        public string OFFICE_PHONE_NO { get; set; }
        public string HAND_PHONE { get; set; }
        public string FAX_NO { get; set; }
        public string EMAIL_ADDR { get; set; }
        public Int16 ADDR_STATUS { get; set; }
        public int DATE_VALUE1 { get; set; }
        public int DATE_VALUE2 { get; set; }
        public int DATE_VALUE3 { get; set; }
        public int DATE_VALUE4 { get; set; }
        public int DATE_VALUE5 { get; set; }
        public int DATE_VALUE6 { get; set; }
        public int DATE_VALUE7 { get; set; }
        public int DATE_VALUE8 { get; set; }
        public int DATE_VALUE9 { get; set; }
        public int DATE_VALUE10 { get; set; }
        public string DATA_VALUE1 { get; set; }
        public string DATA_VALUE2 { get; set; }
        public string DATA_VALUE3 { get; set; }
        public string DATA_VALUE4 { get; set; }
        public string DATA_VALUE5 { get; set; }
        public string DATA_VALUE6 { get; set; }
        public string DATA_VALUE7 { get; set; }
        public string DATA_VALUE8 { get; set; }
        public string DATA_VALUE9 { get; set; }
        public string DATA_VALUE10 { get; set; }
        public string DATA_VALUE11 { get; set; }
        public string DATA_VALUE12 { get; set; }
        public string DATA_VALUE13 { get; set; }
        public string DATA_VALUE14 { get; set; }
        public string DATA_VALUE15 { get; set; }
        public string DATA_VALUE16 { get; set; }
        public string DATA_VALUE17 { get; set; }
        public string DATA_VALUE18 { get; set; }
        public string DATA_VALUE19 { get; set; }
        public string DATA_VALUE20 { get; set; }
        public string DATA_VALUE21 { get; set; }
        public string DATA_VALUE22 { get; set; }
        public string DATA_VALUE23 { get; set; }
        public string DATA_VALUE24 { get; set; }
        public string DATA_VALUE25 { get; set; }
        public string DATA_VALUE26 { get; set; }
        public string DATA_VALUE27 { get; set; }
        public string DATA_VALUE28 { get; set; }
        public string DATA_VALUE29 { get; set; }
        public string DATA_VALUE30 { get; set; }
        public string DATA_VALUE31 { get; set; }
        public string DATA_VALUE32 { get; set; }
        public string DATA_VALUE33 { get; set; }
        public string DATA_VALUE34 { get; set; }
        public string DATA_VALUE35 { get; set; }
        public string DATA_VALUE36 { get; set; }
        public string DATA_VALUE37 { get; set; }
        public string DATA_VALUE38 { get; set; }
        public string DATA_VALUE39 { get; set; }
        public string DATA_VALUE40 { get; set; }
        public string DATA_VALUE41 { get; set; }
        public string DATA_VALUE42 { get; set; }
        public string DATA_VALUE43 { get; set; }
        public string DATA_VALUE44 { get; set; }
        public int DATA_VALUE45 { get; set; }
        public int DATA_VALUE46 { get; set; }
        public int DATA_VALUE47 { get; set; }
        public int DATA_VALUE48 { get; set; }
        public int DATA_VALUE49 { get; set; }
        public int DATA_VALUE50 { get; set; }
        public int DATA_VALUE51 { get; set; }
        public int DATA_VALUE52 { get; set; }
        public int DATA_VALUE53 { get; set; }
        public int DATA_VALUE54 { get; set; }
        public int DATA_VALUE55 { get; set; }
        public int CIF_FALSE_POSITIVE_DT { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND { get; set; }
        public int CIF_FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string GIVEN_NAME { get; set; }
        #endregion

    }

}