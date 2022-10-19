using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ALERTWLTRANDTLHIT
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public int ALERT_SEQNO { get; set; }
        public string HIT_DTL_GRP_ID { get; set; }
        public string HIT_DTL_ER_ID { get; set; }
        public string HIT_DTL_EQ_ID { get; set; }
        public double HIT_DTL_ER_THRESHOLD { get; set; }
        public Int16 HIT_DTL_ER_RANK { get; set; }
        public Int16 HIT_DTL_EQ_RULE_TYPE { get; set; }
        public string HIT_DTL_EQ_NAME { get; set; }
        public double HIT_DTL_EQ_WEIGHT { get; set; }
        public Int16 HIT_DTL_EQ_NO_OF_DAYS { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FX_RATE { get; set; }
        public int TRANS_COUNT { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public int HIST_TRANS_COUNT { get; set; }
        public double HIST_LOCAL_AMOUNT { get; set; }
        public double HIST_FOREIGN_AMOUNT { get; set; }
        public Int16 HIT_STATUS { get; set; }
        public string ACCOUNT_NO { get; set; }
        public Int16 FILTER_TRANHIST_STATUS { get; set; }
        public string TRANHIST_SQL_STMT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ALERTWLTRANDTLHIT")]
    public class _ALERTWLTRANDTLHIT
    {

        public _ALERTWLTRANDTLHIT() { }

        public _ALERTWLTRANDTLHIT(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ALERT_ID = 0;
            ALERT_SEQNO = 0;
            HIT_DTL_GRP_ID = "";
            HIT_DTL_ER_ID = "";
            HIT_DTL_EQ_ID = "";
            HIT_DTL_ER_THRESHOLD = 0;
            HIT_DTL_ER_RANK = 0;
            HIT_DTL_EQ_RULE_TYPE = 0;
            HIT_DTL_EQ_NAME = "";
            HIT_DTL_EQ_WEIGHT = 0;
            HIT_DTL_EQ_NO_OF_DAYS = 0;
            CREDIT_DEBIT = 0;
            TRAN_DATE = 0;
            TRAN_CODE = "";
            LOCAL_CURRENCY = "";
            FX_RATE = 0;
            TRANS_COUNT = 0;
            LOCAL_AMOUNT = 0;
            FOREIGN_AMOUNT = 0;
            HIST_TRANS_COUNT = 0;
            HIST_LOCAL_AMOUNT = 0;
            HIST_FOREIGN_AMOUNT = 0;
            HIT_STATUS = 0;
            ACCOUNT_NO = "";
            FILTER_TRANHIST_STATUS = 0;
            TRANHIST_SQL_STMT = "";
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
        public Int64 ALERT_ID { get; set; }
        [Key, Column(Order = 3)]
        public int ALERT_SEQNO { get; set; }
        public string HIT_DTL_GRP_ID { get; set; }
        public string HIT_DTL_ER_ID { get; set; }
        public string HIT_DTL_EQ_ID { get; set; }
        public double HIT_DTL_ER_THRESHOLD { get; set; }
        public Int16 HIT_DTL_ER_RANK { get; set; }
        public Int16 HIT_DTL_EQ_RULE_TYPE { get; set; }
        public string HIT_DTL_EQ_NAME { get; set; }
        public double HIT_DTL_EQ_WEIGHT { get; set; }
        public Int16 HIT_DTL_EQ_NO_OF_DAYS { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FX_RATE { get; set; }
        public int TRANS_COUNT { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public int HIST_TRANS_COUNT { get; set; }
        public double HIST_LOCAL_AMOUNT { get; set; }
        public double HIST_FOREIGN_AMOUNT { get; set; }
        public Int16 HIT_STATUS { get; set; }
        public string ACCOUNT_NO { get; set; }
        public Int16 FILTER_TRANHIST_STATUS { get; set; }
        public string TRANHIST_SQL_STMT { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
