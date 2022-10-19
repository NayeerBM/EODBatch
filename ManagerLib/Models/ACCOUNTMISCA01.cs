using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ACCOUNTMISCA01
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string MISC_KEY1 { get; set; }
        [Key, Column(Order = 3)]
        public string MISC_KEY2 { get; set; }
        [Key, Column(Order = 4)]
        public int SEQ_NO { get; set; }
        public string MISC_FIELD01 { get; set; }
        public string MISC_FIELD02 { get; set; }
        public string MISC_FIELD03 { get; set; }
        public string MISC_FIELD04 { get; set; }
        public string MISC_FIELD05 { get; set; }
        public string MISC_FIELD06 { get; set; }
        public string MISC_FIELD07 { get; set; }
        public string MISC_FIELD08 { get; set; }
        public string MISC_FIELD09 { get; set; }
        public string MISC_FIELD10 { get; set; }
        public string MISC_FIELD11 { get; set; }
        public string MISC_FIELD12 { get; set; }
        public string MISC_FIELD13 { get; set; }
        public string MISC_FIELD14 { get; set; }
        public string MISC_FIELD15 { get; set; }
        public string MISC_FIELD16 { get; set; }
        public string MISC_FIELD17 { get; set; }
        public string MISC_FIELD18 { get; set; }
        public string MISC_FIELD19 { get; set; }
        public string MISC_FIELD20 { get; set; }
        public string MISC_FIELD21 { get; set; }
        public string MISC_FIELD22 { get; set; }
        public string MISC_FIELD23 { get; set; }
        public string MISC_FIELD24 { get; set; }
        public string MISC_FIELD25 { get; set; }
        public string MISC_FIELD26 { get; set; }
        public string MISC_FIELD27 { get; set; }
        public string MISC_FIELD28 { get; set; }
        public string MISC_FIELD29 { get; set; }
        public string MISC_FIELD30 { get; set; }
        public double MISC_FIELD131 { get; set; }
        public double MISC_FIELD132 { get; set; }
        public double MISC_FIELD133 { get; set; }
        public double MISC_FIELD134 { get; set; }
        public double MISC_FIELD135 { get; set; }
        public double MISC_FIELD136 { get; set; }
        public int MISC_FIELD151 { get; set; }
        public int MISC_FIELD152 { get; set; }
        public int MISC_FIELD153 { get; set; }
        public int MISC_FIELD154 { get; set; }
        public int MISC_FIELD155 { get; set; }
        public int MISC_FIELD156 { get; set; }
        public int MISC_FIELD157 { get; set; }
        public int MISC_FIELD158 { get; set; }
        public int MISC_FIELD159 { get; set; }
        public int MISC_FIELD160 { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ACCOUNTMISCA01")]
    public class _ACCOUNTMISCA01
    {

        public _ACCOUNTMISCA01() { }

        public _ACCOUNTMISCA01(bool setDefaultValue)
        {
            COMP_CODE = 0;
            MISC_KEY1 = "";
            MISC_KEY2 = "";
            SEQ_NO = 0;
            MISC_FIELD01 = "";
            MISC_FIELD02 = "";
            MISC_FIELD03 = "";
            MISC_FIELD04 = "";
            MISC_FIELD05 = "";
            MISC_FIELD06 = "";
            MISC_FIELD07 = "";
            MISC_FIELD08 = "";
            MISC_FIELD09 = "";
            MISC_FIELD10 = "";
            MISC_FIELD11 = "";
            MISC_FIELD12 = "";
            MISC_FIELD13 = "";
            MISC_FIELD14 = "";
            MISC_FIELD15 = "";
            MISC_FIELD16 = "";
            MISC_FIELD17 = "";
            MISC_FIELD18 = "";
            MISC_FIELD19 = "";
            MISC_FIELD20 = "";
            MISC_FIELD21 = "";
            MISC_FIELD22 = "";
            MISC_FIELD23 = "";
            MISC_FIELD24 = "";
            MISC_FIELD25 = "";
            MISC_FIELD26 = "";
            MISC_FIELD27 = "";
            MISC_FIELD28 = "";
            MISC_FIELD29 = "";
            MISC_FIELD30 = "";
            MISC_FIELD131 = 0;
            MISC_FIELD132 = 0;
            MISC_FIELD133 = 0;
            MISC_FIELD134 = 0;
            MISC_FIELD135 = 0;
            MISC_FIELD136 = 0;
            MISC_FIELD151 = 0;
            MISC_FIELD152 = 0;
            MISC_FIELD153 = 0;
            MISC_FIELD154 = 0;
            MISC_FIELD155 = 0;
            MISC_FIELD156 = 0;
            MISC_FIELD157 = 0;
            MISC_FIELD158 = 0;
            MISC_FIELD159 = 0;
            MISC_FIELD160 = 0;
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
        public string MISC_KEY1 { get; set; }
        [Key, Column(Order = 3)]
        public string MISC_KEY2 { get; set; }
        [Key, Column(Order = 4)]
        public int SEQ_NO { get; set; }
        public string MISC_FIELD01 { get; set; }
        public string MISC_FIELD02 { get; set; }
        public string MISC_FIELD03 { get; set; }
        public string MISC_FIELD04 { get; set; }
        public string MISC_FIELD05 { get; set; }
        public string MISC_FIELD06 { get; set; }
        public string MISC_FIELD07 { get; set; }
        public string MISC_FIELD08 { get; set; }
        public string MISC_FIELD09 { get; set; }
        public string MISC_FIELD10 { get; set; }
        public string MISC_FIELD11 { get; set; }
        public string MISC_FIELD12 { get; set; }
        public string MISC_FIELD13 { get; set; }
        public string MISC_FIELD14 { get; set; }
        public string MISC_FIELD15 { get; set; }
        public string MISC_FIELD16 { get; set; }
        public string MISC_FIELD17 { get; set; }
        public string MISC_FIELD18 { get; set; }
        public string MISC_FIELD19 { get; set; }
        public string MISC_FIELD20 { get; set; }
        public string MISC_FIELD21 { get; set; }
        public string MISC_FIELD22 { get; set; }
        public string MISC_FIELD23 { get; set; }
        public string MISC_FIELD24 { get; set; }
        public string MISC_FIELD25 { get; set; }
        public string MISC_FIELD26 { get; set; }
        public string MISC_FIELD27 { get; set; }
        public string MISC_FIELD28 { get; set; }
        public string MISC_FIELD29 { get; set; }
        public string MISC_FIELD30 { get; set; }
        public double MISC_FIELD131 { get; set; }
        public double MISC_FIELD132 { get; set; }
        public double MISC_FIELD133 { get; set; }
        public double MISC_FIELD134 { get; set; }
        public double MISC_FIELD135 { get; set; }
        public double MISC_FIELD136 { get; set; }
        public int MISC_FIELD151 { get; set; }
        public int MISC_FIELD152 { get; set; }
        public int MISC_FIELD153 { get; set; }
        public int MISC_FIELD154 { get; set; }
        public int MISC_FIELD155 { get; set; }
        public int MISC_FIELD156 { get; set; }
        public int MISC_FIELD157 { get; set; }
        public int MISC_FIELD158 { get; set; }
        public int MISC_FIELD159 { get; set; }
        public int MISC_FIELD160 { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
