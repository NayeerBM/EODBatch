using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class ALERTWLTRAN
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        public string REC_TYPE { get; set; }
        public string REC_IDENTITY_NO { get; set; }
        public int HIT_DATE { get; set; }
        public string HIT_GRP_ID { get; set; }
        public string HIT_ER_ID { get; set; }
        public string HIT_ER_NAME { get; set; }
        public double HIT_ER_THRESHOLD { get; set; }
        public string HIT_EQ_ID { get; set; }
        public double HIT_EQ_WEIGHT { get; set; }
        public Int16 HIT_EQ_NO_OF_DAYS { get; set; }
        public string HIT_EQ_ID_MULTIPLE { get; set; }
        public string HIT_RL_RISK_LEVEL { get; set; }
        public string HIT_ASSESSMENT_IND { get; set; }
        public Int16 HIT_RANKING { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string CIF_ID { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string BR_CODE { get; set; }
        public string ALERT_BR { get; set; }
        public string TRAN_LOCATION { get; set; }
        public int TRANS_COUNT { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public string REFERANCE_NO { get; set; }
        public string REFERANCE_DT { get; set; }
        public string PRODUCT_CODE { get; set; }
        public int PRIMARY_ALERT_REC { get; set; }
        public Int16 STATUS { get; set; }
        public Int16 LAST_STATUS { get; set; }
        public int STATUS_UPT_DT { get; set; }
        public int USER_UPT_COUNT { get; set; }
        public int ACTION_GUIDE_NO { get; set; }
        public int ALERT_HIT_STATUS { get; set; }
        public Int16 DISMISS_IND { get; set; }
        public int DISMISS_DATE { get; set; }
        public int DISMISS_TIME { get; set; }
        public int DISMISS_VIEW_DATE { get; set; }
        public int DISMISS_VIEW_TIME { get; set; }
        public string DISMISS_VIEW_BY { get; set; }
        public int ESTABLISH_DATE { get; set; }
        public int ESTABLISH_TIME { get; set; }
        public int LAST_UPT_DATE { get; set; }
        public int LAST_UPT_TIME { get; set; }
        public Int16 HQ_TRAN_IND { get; set; }
        public Int16 STAFF_IND { get; set; }
        public string AML_FRAUD_IND { get; set; }
        public Int64 PARENT_ALERT_ID { get; set; }
        public Int16 GROUP_ALERT_IND { get; set; }
        public double CR_AMOUNT { get; set; }
        public double DR_AMOUNT { get; set; }
        public Int16 AMLC_DISMISS_IND { get; set; }
        public string AMLC_APPROVAL_LIST { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string RUSER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("ALERTWLTRAN")]
    public class _ALERTWLTRAN
    {

        public _ALERTWLTRAN() { }

        public _ALERTWLTRAN(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ALERT_ID = 0;
            REC_TYPE = "";
            REC_IDENTITY_NO = "";
            HIT_DATE = 0;
            HIT_GRP_ID = "";
            HIT_ER_ID = "";
            HIT_ER_NAME = "";
            HIT_ER_THRESHOLD = 0;
            HIT_EQ_ID = "";
            HIT_EQ_WEIGHT = 0;
            HIT_EQ_NO_OF_DAYS = 0;
            HIT_EQ_ID_MULTIPLE = "";
            HIT_RL_RISK_LEVEL = "";
            HIT_ASSESSMENT_IND = "";
            HIT_RANKING = 0;
            ACCOUNT_NO = "";
            ACCOUNT_NAME = "";
            CIF_ID = "";
            CREDIT_DEBIT = 0;
            TRAN_DATE = 0;
            POSTING_DATE = 0;
            VALUE_DATE = 0;
            TRAN_CODE = "";
            BR_CODE = "";
            ALERT_BR = "";
            TRAN_LOCATION = "";
            TRANS_COUNT = 0;
            LOCAL_AMOUNT = 0;
            LOCAL_CURRENCY = "";
            FOREIGN_AMOUNT = 0;
            FX_RATE = 0;
            TRAN_REVERSAL_IND = 0;
            REFERANCE_NO = "";
            REFERANCE_DT = "";
            PRODUCT_CODE = "";
            PRIMARY_ALERT_REC = 0;
            STATUS = 0;
            LAST_STATUS = 0;
            STATUS_UPT_DT = 0;
            USER_UPT_COUNT = 0;
            ACTION_GUIDE_NO = 0;
            ALERT_HIT_STATUS = 0;
            DISMISS_IND = 0;
            DISMISS_DATE = 0;
            DISMISS_TIME = 0;
            DISMISS_VIEW_DATE = 0;
            DISMISS_VIEW_TIME = 0;
            DISMISS_VIEW_BY = "";
            ESTABLISH_DATE = 0;
            ESTABLISH_TIME = 0;
            LAST_UPT_DATE = 0;
            LAST_UPT_TIME = 0;
            HQ_TRAN_IND = 0;
            STAFF_IND = 0;
            AML_FRAUD_IND = "";
            PARENT_ALERT_ID = 0;
            GROUP_ALERT_IND = 0;
            CR_AMOUNT = 0;
            DR_AMOUNT = 0;
            AMLC_DISMISS_IND = 0;
            AMLC_APPROVAL_LIST = "";
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            RUSER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public Int64 ALERT_ID { get; set; }
        public string REC_TYPE { get; set; }
        public string REC_IDENTITY_NO { get; set; }
        public int HIT_DATE { get; set; }
        public string HIT_GRP_ID { get; set; }
        public string HIT_ER_ID { get; set; }
        public string HIT_ER_NAME { get; set; }
        public double HIT_ER_THRESHOLD { get; set; }
        public string HIT_EQ_ID { get; set; }
        public double HIT_EQ_WEIGHT { get; set; }
        public Int16 HIT_EQ_NO_OF_DAYS { get; set; }
        public string HIT_EQ_ID_MULTIPLE { get; set; }
        public string HIT_RL_RISK_LEVEL { get; set; }
        public string HIT_ASSESSMENT_IND { get; set; }
        public Int16 HIT_RANKING { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string CIF_ID { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string BR_CODE { get; set; }
        public string ALERT_BR { get; set; }
        public string TRAN_LOCATION { get; set; }
        public int TRANS_COUNT { get; set; }
        public double LOCAL_AMOUNT { get; set; }
        public string LOCAL_CURRENCY { get; set; }
        public double FOREIGN_AMOUNT { get; set; }
        public double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public string REFERANCE_NO { get; set; }
        public string REFERANCE_DT { get; set; }
        public string PRODUCT_CODE { get; set; }
        public int PRIMARY_ALERT_REC { get; set; }
        public Int16 STATUS { get; set; }
        public Int16 LAST_STATUS { get; set; }
        public int STATUS_UPT_DT { get; set; }
        public int USER_UPT_COUNT { get; set; }
        public int ACTION_GUIDE_NO { get; set; }
        public int ALERT_HIT_STATUS { get; set; }
        public Int16 DISMISS_IND { get; set; }
        public int DISMISS_DATE { get; set; }
        public int DISMISS_TIME { get; set; }
        public int DISMISS_VIEW_DATE { get; set; }
        public int DISMISS_VIEW_TIME { get; set; }
        public string DISMISS_VIEW_BY { get; set; }
        public int ESTABLISH_DATE { get; set; }
        public int ESTABLISH_TIME { get; set; }
        public int LAST_UPT_DATE { get; set; }
        public int LAST_UPT_TIME { get; set; }
        public Int16 HQ_TRAN_IND { get; set; }
        public Int16 STAFF_IND { get; set; }
        public string AML_FRAUD_IND { get; set; }
        public Int64 PARENT_ALERT_ID { get; set; }
        public Int16 GROUP_ALERT_IND { get; set; }
        public double CR_AMOUNT { get; set; }
        public double DR_AMOUNT { get; set; }
        public Int16 AMLC_DISMISS_IND { get; set; }
        public string AMLC_APPROVAL_LIST { get; set; }
        public int BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string RUSER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}