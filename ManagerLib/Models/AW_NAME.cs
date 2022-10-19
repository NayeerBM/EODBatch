using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class AW_NAME
    {

        #region Extra Properties

        public string CATEGORY1 { get; set; }
        public string CATEGORY2 { get; set; }
        public string NAMESOURCE { get; set; }
        public Int16 NO { get; set; }
        public string ID_VALUE { get; set; }
        public string ENTITY_TYPE { get; set; }
        public string GENDER { get; set; }
        public string MATCH { get; set; }
        public string NAME_HIT { get; set; }
        public string ID_HIT { get; set; }
        public Int16 RANK { get; set; }
        public bool IS_ID_HIT { get; set; }
        public bool IS_SANCTION_HIT { get; set; }
        public bool IS_PEP_HIT { get; set; }
        public Int16 PERCENTAGE { get; set; }


        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public string ENTITY_ID { get; set; }
        [Key, Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SYS_ID { get; set; }
        public string INFO_SOURCE { get; set; }
        public string NAME_TYPE { get; set; }
        public string TITLE_HONORIFIC { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string SURNAME { get; set; }
        public string MAIDEN_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string ENTITY_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string SINGLE_STRING_NAME2 { get; set; }
        public string SINGLE_STRING_NAME3 { get; set; }
        public string ORIGINAL_SCRIPT_NAME { get; set; }
        public Int16 FALSE_POSITIVE { get; set; }
        public int FALSE_POSITIVE_EXPIRY_DT { get; set; }
        public Int16 APPROVAL_STATUS { get; set; }
        public string HIGH_RISK_COUNTRY { get; set; }
        public Int16 HIGH_RISK_COUNTRY_SCORE { get; set; }
        public string CATEGORY { get; set; }
        public string DOB { get; set; }
        public string COUNTRY { get; set; }
        public string ID_REF_NO { get; set; }
        public string ACTION { get; set; }
        public string BATCH_NO { get; set; }
        public int BATCH_DATE { get; set; }
        public string SANCTION { get; set; }
        public string CATEGORYNUM { get; set; }
        #endregion

    }
    [Table("AW_NAME")]
    public class _AW_NAME
    {

        public _AW_NAME() { }

        public _AW_NAME(bool setDefaultValue)
        {
            ENTITY_ID = "";
            SYS_ID = 0;
            INFO_SOURCE = "";
            NAME_TYPE = "";
            TITLE_HONORIFIC = "";
            FIRST_NAME = "";
            MIDDLE_NAME = "";
            SURNAME = "";
            MAIDEN_NAME = "";
            SUFFIX = "";
            ENTITY_NAME = "";
            SINGLE_STRING_NAME = "";
            SINGLE_STRING_NAME2 = "";
            SINGLE_STRING_NAME3 = "";
            ORIGINAL_SCRIPT_NAME = "";
            FALSE_POSITIVE = 0;
            FALSE_POSITIVE_EXPIRY_DT = 0;
            APPROVAL_STATUS = 0;
            HIGH_RISK_COUNTRY = "";
            HIGH_RISK_COUNTRY_SCORE = 0;
            CATEGORY = "";
            DOB = "";
            COUNTRY = "";
            ID_REF_NO = "";
            ACTION = "";
            BATCH_NO = "";
            BATCH_DATE = 0;
            SANCTION = "";
            CATEGORYNUM = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public string ENTITY_ID { get; set; }
        [Key, Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SYS_ID { get; set; }
        public string INFO_SOURCE { get; set; }
        public string NAME_TYPE { get; set; }
        public string TITLE_HONORIFIC { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string SURNAME { get; set; }
        public string MAIDEN_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string ENTITY_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string SINGLE_STRING_NAME2 { get; set; }
        public string SINGLE_STRING_NAME3 { get; set; }
        public string ORIGINAL_SCRIPT_NAME { get; set; }
        public Int16 FALSE_POSITIVE { get; set; }
        public int FALSE_POSITIVE_EXPIRY_DT { get; set; }
        public Int16 APPROVAL_STATUS { get; set; }
        public string HIGH_RISK_COUNTRY { get; set; }
        public Int16 HIGH_RISK_COUNTRY_SCORE { get; set; }
        public string CATEGORY { get; set; }
        public string DOB { get; set; }
        public string COUNTRY { get; set; }
        public string ID_REF_NO { get; set; }
        public string ACTION { get; set; }
        public string BATCH_NO { get; set; }
        public int BATCH_DATE { get; set; }
        public string SANCTION { get; set; }
        public string CATEGORYNUM { get; set; }
        #endregion

    }

}