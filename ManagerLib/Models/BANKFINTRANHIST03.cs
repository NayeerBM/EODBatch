using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class BANKFINTRANHIST03
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 SEQ_NO { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int16 COMP_CODE { get; set; }
        public string REC_TYPE { get; set; }
        public string UNLOAD_IND { get; set; }
        public string REC_IDENTITY_NO { get; set; }
        public string INWARD_OUTWARD_CODE { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public string BR_CODE { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public string REFERANCE_NO { get; set; }
        public string REFERANCE_DT { get; set; }
        public string TRAN_LOCATION { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public double FIELD21 { get; set; }
        public double FIELD22 { get; set; }
        public double FIELD23 { get; set; }
        public double FIELD24 { get; set; }
        public double FIELD25 { get; set; }
        public double FIELD26 { get; set; }
        public double FIELD27 { get; set; }
        public double FIELD28 { get; set; }
        public double FIELD29 { get; set; }
        public double FIELD30 { get; set; }
        public int FIELD31 { get; set; }
        public int FIELD32 { get; set; }
        public int FIELD33 { get; set; }
        public int FIELD34 { get; set; }
        public int FIELD35 { get; set; }
        public int FIELD36 { get; set; }
        public int FIELD37 { get; set; }
        public int FIELD38 { get; set; }
        public int FIELD39 { get; set; }
        public int FIELD40 { get; set; }
        public string FIELD50 { get; set; }
        public string FIELD51 { get; set; }
        public string FIELD52 { get; set; }
        public string FIELD53 { get; set; }
        public string FIELD54 { get; set; }
        public string FIELD55 { get; set; }
        public Int16 CR_IND { get; set; }
        public double CR_AMOUNT { get; set; }
        public Int16 DR_IND { get; set; }
        public double DR_AMOUNT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("BANKFINTRANHIST03")]
    public class _BANKFINTRANHIST03
    {

        public _BANKFINTRANHIST03() { }

        public _BANKFINTRANHIST03(bool setDefaultValue)
        {
            SEQ_NO = 0;
            TRAN_ID = 0;
            COMP_CODE = 0;
            REC_TYPE = "";
            UNLOAD_IND = "";
            REC_IDENTITY_NO = "";
            INWARD_OUTWARD_CODE = "";
            CREDIT_DEBIT = 0;
            TRAN_DATE = 0;
            POSTING_DATE = 0;
            VALUE_DATE = 0;
            TRAN_CODE = "";
            ACCOUNT_NO = "";
            CIF_ID = "";
            BR_CODE = "";
            LOCAL_AMOUNT = 0;
            LOCAL_CURRENCY = "";
            FOREIGN_AMOUNT = 0;
            FX_RATE = 0;
            TRAN_REVERSAL_IND = 0;
            REFERANCE_NO = "";
            REFERANCE_DT = "";
            TRAN_LOCATION = "";
            Field1 = "";
            Field2 = "";
            Field3 = "";
            Field4 = "";
            Field5 = "";
            Field6 = "";
            Field7 = "";
            Field8 = "";
            Field9 = "";
            Field10 = "";
            Field11 = "";
            Field12 = "";
            Field13 = "";
            Field14 = "";
            Field15 = "";
            FIELD21 = 0;
            FIELD22 = 0;
            FIELD23 = 0;
            FIELD24 = 0;
            FIELD25 = 0;
            FIELD26 = 0;
            FIELD27 = 0;
            FIELD28 = 0;
            FIELD29 = 0;
            FIELD30 = 0;
            FIELD31 = 0;
            FIELD32 = 0;
            FIELD33 = 0;
            FIELD34 = 0;
            FIELD35 = 0;
            FIELD36 = 0;
            FIELD37 = 0;
            FIELD38 = 0;
            FIELD39 = 0;
            FIELD40 = 0;
            FIELD50 = "";
            FIELD51 = "";
            FIELD52 = "";
            FIELD53 = "";
            FIELD54 = "";
            FIELD55 = "";
            CR_IND = 0;
            CR_AMOUNT = 0;
            DR_IND = 0;
            DR_AMOUNT = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 SEQ_NO { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int16 COMP_CODE { get; set; }
        public string REC_TYPE { get; set; }
        public string UNLOAD_IND { get; set; }
        public string REC_IDENTITY_NO { get; set; }
        public string INWARD_OUTWARD_CODE { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CIF_ID { get; set; }
        public string BR_CODE { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public string REFERANCE_NO { get; set; }
        public string REFERANCE_DT { get; set; }
        public string TRAN_LOCATION { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public double FIELD21 { get; set; }
        public double FIELD22 { get; set; }
        public double FIELD23 { get; set; }
        public double FIELD24 { get; set; }
        public double FIELD25 { get; set; }
        public double FIELD26 { get; set; }
        public double FIELD27 { get; set; }
        public double FIELD28 { get; set; }
        public double FIELD29 { get; set; }
        public double FIELD30 { get; set; }
        public int FIELD31 { get; set; }
        public int FIELD32 { get; set; }
        public int FIELD33 { get; set; }
        public int FIELD34 { get; set; }
        public int FIELD35 { get; set; }
        public int FIELD36 { get; set; }
        public int FIELD37 { get; set; }
        public int FIELD38 { get; set; }
        public int FIELD39 { get; set; }
        public int FIELD40 { get; set; }
        public string FIELD50 { get; set; }
        public string FIELD51 { get; set; }
        public string FIELD52 { get; set; }
        public string FIELD53 { get; set; }
        public string FIELD54 { get; set; }
        public string FIELD55 { get; set; }
        public Int16 CR_IND { get; set; }
        public double CR_AMOUNT { get; set; }
        public Int16 DR_IND { get; set; }
        public double DR_AMOUNT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}