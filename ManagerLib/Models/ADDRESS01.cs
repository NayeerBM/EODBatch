using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ADDRESS01
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string CIF_ID { get; set; }
        [Key, Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SEQ_NO { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ADDRESS_TYPE { get; set; }
        public string ADDRESS_FORMAT { get; set; }
        public string ADDRESS_FOREIGN { get; set; }
        public Int16 ADDRESS_STATUS { get; set; }
        public string ADR_REF { get; set; }
        public string ADR_DETAILS { get; set; }
        public string ADRField01 { get; set; }
        public string ADRField02 { get; set; }
        public string ADRField03 { get; set; }
        public string ADRField04 { get; set; }
        public string ADRField05 { get; set; }
        public string ADRField06 { get; set; }
        public string ADRField07 { get; set; }
        public string ADRField08 { get; set; }
        public string ADRField09 { get; set; }
        public string ADRField10 { get; set; }
        public string ADRField11 { get; set; }
        public string ADRField12 { get; set; }
        public string ADRField13 { get; set; }
        public string ADRField14 { get; set; }
        public string ADRField15 { get; set; }
        public string ADRField16 { get; set; }
        public string ADRField17 { get; set; }
        public string ADRField18 { get; set; }
        public string ADRField19 { get; set; }
        public string ADRField20 { get; set; }
        public string ADRField40 { get; set; }
        public string ADRField41 { get; set; }
        public double ADRField131 { get; set; }
        public double ADRField132 { get; set; }
        public double ADRField133 { get; set; }
        public double ADRField134 { get; set; }
        public double ADRField135 { get; set; }
        public int ADRField151 { get; set; }
        public int ADRField152 { get; set; }
        public int ADRField153 { get; set; }
        public int ADRField154 { get; set; }
        public int ADRField155 { get; set; }
        public int ADRField156 { get; set; }
        public int ADRField157 { get; set; }
        public int ADRField158 { get; set; }
        public int ADRField159 { get; set; }
        public int ADRField160 { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ADDRESS01")]
    public class _ADDRESS01
    {

        public _ADDRESS01() { }

        public _ADDRESS01(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CIF_ID = "";
            SEQ_NO = 0;
            ACCOUNT_NO = "";
            ADDRESS_TYPE = "";
            ADDRESS_FORMAT = "";
            ADDRESS_FOREIGN = "";
            ADDRESS_STATUS = 0;
            ADR_REF = "";
            ADR_DETAILS = "";
            ADRField01 = "";
            ADRField02 = "";
            ADRField03 = "";
            ADRField04 = "";
            ADRField05 = "";
            ADRField06 = "";
            ADRField07 = "";
            ADRField08 = "";
            ADRField09 = "";
            ADRField10 = "";
            ADRField11 = "";
            ADRField12 = "";
            ADRField13 = "";
            ADRField14 = "";
            ADRField15 = "";
            ADRField16 = "";
            ADRField17 = "";
            ADRField18 = "";
            ADRField19 = "";
            ADRField20 = "";
            ADRField40 = "";
            ADRField41 = "";
            ADRField131 = 0;
            ADRField132 = 0;
            ADRField133 = 0;
            ADRField134 = 0;
            ADRField135 = 0;
            ADRField151 = 0;
            ADRField152 = 0;
            ADRField153 = 0;
            ADRField154 = 0;
            ADRField155 = 0;
            ADRField156 = 0;
            ADRField157 = 0;
            ADRField158 = 0;
            ADRField159 = 0;
            ADRField160 = 0;
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
        public string CIF_ID { get; set; }
        [Key, Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SEQ_NO { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ADDRESS_TYPE { get; set; }
        public string ADDRESS_FORMAT { get; set; }
        public string ADDRESS_FOREIGN { get; set; }
        public Int16 ADDRESS_STATUS { get; set; }
        public string ADR_REF { get; set; }
        public string ADR_DETAILS { get; set; }
        public string ADRField01 { get; set; }
        public string ADRField02 { get; set; }
        public string ADRField03 { get; set; }
        public string ADRField04 { get; set; }
        public string ADRField05 { get; set; }
        public string ADRField06 { get; set; }
        public string ADRField07 { get; set; }
        public string ADRField08 { get; set; }
        public string ADRField09 { get; set; }
        public string ADRField10 { get; set; }
        public string ADRField11 { get; set; }
        public string ADRField12 { get; set; }
        public string ADRField13 { get; set; }
        public string ADRField14 { get; set; }
        public string ADRField15 { get; set; }
        public string ADRField16 { get; set; }
        public string ADRField17 { get; set; }
        public string ADRField18 { get; set; }
        public string ADRField19 { get; set; }
        public string ADRField20 { get; set; }
        public string ADRField40 { get; set; }
        public string ADRField41 { get; set; }
        public double ADRField131 { get; set; }
        public double ADRField132 { get; set; }
        public double ADRField133 { get; set; }
        public double ADRField134 { get; set; }
        public double ADRField135 { get; set; }
        public int ADRField151 { get; set; }
        public int ADRField152 { get; set; }
        public int ADRField153 { get; set; }
        public int ADRField154 { get; set; }
        public int ADRField155 { get; set; }
        public int ADRField156 { get; set; }
        public int ADRField157 { get; set; }
        public int ADRField158 { get; set; }
        public int ADRField159 { get; set; }
        public int ADRField160 { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}