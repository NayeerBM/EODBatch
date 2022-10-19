using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ALERTWLTRANWLISTDTL
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public string ENTITY_ID { get; set; }
        [Key, Column(Order = 4)]
        public int SYS_ID { get; set; }
        [Key, Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AUTO_SEQ_NO { get; set; }
        public Int16 HIT_ID_OR_NAME { get; set; }
        public string INFO_SOURCE { get; set; }
        public string NAME_TYPE { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string ID_VALUE { get; set; }
        public string COUNTRY { get; set; }
        public string DOBS { get; set; }
        public string CATEGORY { get; set; }
        public string NAMESOURCE { get; set; }
        public Int16 MATCH_PERCENT { get; set; }
        public Int16 INVESTIGATE_STATUS { get; set; }
        public Int16 TYPE_OF_EXPOSITION { get; set; }
        public string REMARKS { get; set; }
        public int LAST_UPT_DATE { get; set; }
        public int LAST_UPT_TIME { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public int BATCH_DATE { get; set; }
        public double WEIGHTAGE_PERCENT { get; set; }
        public string WEIGHTAGE_COMPUTE { get; set; }
        public string GENDER { get; set; }
        #endregion

    }
    [Table("ALERTWLTRANWLISTDTL")]
    public class _ALERTWLTRANWLISTDTL
    {

        public _ALERTWLTRANWLISTDTL() { }

        public _ALERTWLTRANWLISTDTL(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ALERT_ID = 0;
            ENTITY_ID = "";
            SYS_ID = 0;
            AUTO_SEQ_NO = 0;
            HIT_ID_OR_NAME = 0;
            INFO_SOURCE = "";
            NAME_TYPE = "";
            SINGLE_STRING_NAME = "";
            ID_VALUE = "";
            COUNTRY = "";
            DOBS = "";
            CATEGORY = "";
            NAMESOURCE = "";
            MATCH_PERCENT = 0;
            INVESTIGATE_STATUS = 0;
            TYPE_OF_EXPOSITION = 0;
            REMARKS = "";
            LAST_UPT_DATE = 0;
            LAST_UPT_TIME = 0;
            USER_ID = "";
            MODE_MN = "";
            ACCOUNT_NO = "";
            CIF_ID = "";
            FALSE_POSITIVE_IND = 0;
            BATCH_DATE = 0;
            WEIGHTAGE_PERCENT = 0;
            WEIGHTAGE_COMPUTE = "";
            GENDER = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public string ENTITY_ID { get; set; }
        [Key, Column(Order = 4)]
        public int SYS_ID { get; set; }
        [Key, Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AUTO_SEQ_NO { get; set; }
        public Int16 HIT_ID_OR_NAME { get; set; }
        public string INFO_SOURCE { get; set; }
        public string NAME_TYPE { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string ID_VALUE { get; set; }
        public string COUNTRY { get; set; }
        public string DOBS { get; set; }
        public string CATEGORY { get; set; }
        public string NAMESOURCE { get; set; }
        public Int16 MATCH_PERCENT { get; set; }
        public Int16 INVESTIGATE_STATUS { get; set; }
        public Int16 TYPE_OF_EXPOSITION { get; set; }
        public string REMARKS { get; set; }
        public int LAST_UPT_DATE { get; set; }
        public int LAST_UPT_TIME { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public int BATCH_DATE { get; set; }
        public double WEIGHTAGE_PERCENT { get; set; }
        public string WEIGHTAGE_COMPUTE { get; set; }
        public string GENDER { get; set; }
        #endregion

    }

}