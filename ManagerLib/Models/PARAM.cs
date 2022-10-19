using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class PARAM
    {

        #region Extra Properties

        public int intBatchNo { get; set; }
        public string strBatchNo { get; set; }

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        public string EQ_PREFIX { get; set; }
        public int LAST_EQ_NO { get; set; }
        public Int16 EQ_NO_LEN { get; set; }
        public string RULE_PREFIX { get; set; }
        public int LAST_RULE_NO { get; set; }
        public Int16 RULE_NO_LEN { get; set; }
        public string GROUP_PREFIX { get; set; }
        public int LAST_GROUP_NO { get; set; }
        public Int16 GROUP_NO_LEN { get; set; }
        public int LAST_RISKLEVEL_NO { get; set; }
        public int LAST_FILTER_NO { get; set; }
        public int LAST_IMPORT_BATCH_NO { get; set; }
        public int LAST_PROCESS_DATE { get; set; }
        public int CURRENT_PROCESS_DATE { get; set; }
        public int AGENT_PROCESS_NO { get; set; }
        public Int64 LAST_ALERT_NO { get; set; }
        public Int64 LAST_WATCHLIST_NO { get; set; }
        public Int16 RISKASS_APPROVAL_REQ { get; set; }
        public Int16 DL_APPROVAL_REQ { get; set; }
        public Int16 CP_APPROVAL_REQ { get; set; }
        public Int16 PQ_APPROVAL_REQ { get; set; }
        public Int16 ALERT_HIT_CHECK_THRESHOLD { get; set; }
        public Int16 ALERT_ASSIGN_BR_IND { get; set; }
        public Int16 ALERT_ASSIGN_BR_SP_IND { get; set; }
        public string ALERT_ASSIGN_BR_SP_CODE { get; set; }
        public Int16 ALERT_ASSIGN_BR_SP_CASE_STATUS { get; set; }
        public Int16 ALERT_DETECTION_METHOD { get; set; }
        public Int16 ALERT_STR_UPT_MONITOR_IND { get; set; }
        public Int16 ALERT_MONITORING_PERIOD { get; set; }
        public double ALERT_VIEW_DISMISS_PERCENT { get; set; }
        public Int16 ALERT_VIEW_DISSMISS_REJECT_ST { get; set; }
        public Int16 ALERT_STR_CASE_STATUS { get; set; }
        public Int16 ALERT_BR_VIEW_CASE_STATUS { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST1 { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST2 { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST3 { get; set; }
        public string SERVERREPORT_URL { get; set; }
        public string SERVERREPORT_PATH { get; set; }
        public Int16 SAME_FX_BASE_CURR_FD { get; set; }
        public Int16 SHOW_FX_AMT_COLUMN { get; set; }
        public int LAST_RS_NO { get; set; }
        public int LAST_MSG_NO { get; set; }
        public Int16 SEND_MAIL1 { get; set; }
        public Int16 SEND_MAIL2 { get; set; }
        public Int16 ALERT_STR_SUBMIT_AUTO_UPT_CLOSE_ST { get; set; }
        public string ALERT_STR_FIELD_ID_IN_CIF { get; set; }
        public string ALERT_STR_FIELD_ID_IN_ACCT { get; set; }
        public Int16 WATCHLIST_REDIRECT_CASE_ST { get; set; }
        public Int16 ALERT_AMLC_NO_OF_APPROVAL_REQ { get; set; }
        public Int16 ALERT_AMLC_VIEW_CASE_STATUS1 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS1 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS2 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS3 { get; set; }
        public Int16 BATCH_RUN_METHOD1 { get; set; }
        public int BATCH_RUN_AUTO_TIME1 { get; set; }
        public int BATCH_RUN_AUTO_EOD1 { get; set; }
        public string BATCH_RUN_PATH1 { get; set; }
        public Int16 BATCH_RUN_METHOD2 { get; set; }
        public int BATCH_RUN_AUTO_TIME2 { get; set; }
        public int BATCH_RUN_AUTO_EOD2 { get; set; }
        public string BATCH_RUN_PATH2 { get; set; }
        public Int16 BATCH_RUN_METHOD3 { get; set; }
        public int BATCH_RUN_AUTO_TIME3 { get; set; }
        public int BATCH_RUN_AUTO_EOD3 { get; set; }
        public string BATCH_RUN_PATH3 { get; set; }
        public Int16 BATCH_RUN_METHOD4 { get; set; }
        public int BATCH_RUN_AUTO_TIME4 { get; set; }
        public int BATCH_RUN_AUTO_EOD4 { get; set; }
        public string BATCH_RUN_PATH4 { get; set; }
        public Int16 BATCH_RUN_METHOD5 { get; set; }
        public int BATCH_RUN_AUTO_TIME5 { get; set; }
        public int BATCH_RUN_AUTO_EOD5 { get; set; }
        public string BATCH_RUN_PATH5 { get; set; }
        public Int16 BATCH_RUN_METHOD6 { get; set; }
        public int BATCH_RUN_AUTO_TIME6 { get; set; }
        public int BATCH_RUN_AUTO_EOD6 { get; set; }
        public string BATCH_RUN_PATH6 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE1 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE2 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE3 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE4 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("PARAM")]
    public class _PARAM
    {

        public _PARAM() { }

        public _PARAM(bool setDefaultValue)
        {
            COMP_CODE = 0;
            EQ_PREFIX = "";
            LAST_EQ_NO = 0;
            EQ_NO_LEN = 0;
            RULE_PREFIX = "";
            LAST_RULE_NO = 0;
            RULE_NO_LEN = 0;
            GROUP_PREFIX = "";
            LAST_GROUP_NO = 0;
            GROUP_NO_LEN = 0;
            LAST_RISKLEVEL_NO = 0;
            LAST_FILTER_NO = 0;
            LAST_IMPORT_BATCH_NO = 0;
            LAST_PROCESS_DATE = 0;
            CURRENT_PROCESS_DATE = 0;
            AGENT_PROCESS_NO = 0;
            LAST_ALERT_NO = 0;
            LAST_WATCHLIST_NO = 0;
            RISKASS_APPROVAL_REQ = 0;
            DL_APPROVAL_REQ = 0;
            CP_APPROVAL_REQ = 0;
            PQ_APPROVAL_REQ = 0;
            ALERT_HIT_CHECK_THRESHOLD = 0;
            ALERT_ASSIGN_BR_IND = 0;
            ALERT_ASSIGN_BR_SP_IND = 0;
            ALERT_ASSIGN_BR_SP_CODE = "";
            ALERT_ASSIGN_BR_SP_CASE_STATUS = 0;
            ALERT_DETECTION_METHOD = 0;
            ALERT_STR_UPT_MONITOR_IND = 0;
            ALERT_MONITORING_PERIOD = 0;
            ALERT_VIEW_DISMISS_PERCENT = 0;
            ALERT_VIEW_DISSMISS_REJECT_ST = 0;
            ALERT_STR_CASE_STATUS = 0;
            ALERT_BR_VIEW_CASE_STATUS = 0;
            ALERT_DISSMISS_APPLY_TO_CASE_ST1 = 0;
            ALERT_DISSMISS_APPLY_TO_CASE_ST2 = 0;
            ALERT_DISSMISS_APPLY_TO_CASE_ST3 = 0;
            SERVERREPORT_URL = "";
            SERVERREPORT_PATH = "";
            SAME_FX_BASE_CURR_FD = 0;
            SHOW_FX_AMT_COLUMN = 0;
            LAST_RS_NO = 0;
            LAST_MSG_NO = 0;
            SEND_MAIL1 = 0;
            SEND_MAIL2 = 0;
            ALERT_STR_SUBMIT_AUTO_UPT_CLOSE_ST = 0;
            ALERT_STR_FIELD_ID_IN_CIF = "";
            ALERT_STR_FIELD_ID_IN_ACCT = "";
            WATCHLIST_REDIRECT_CASE_ST = 0;
            ALERT_AMLC_NO_OF_APPROVAL_REQ = 0;
            ALERT_AMLC_VIEW_CASE_STATUS1 = 0;
            ALERT_AMLC_DISMISS_CASE_STATUS1 = 0;
            ALERT_AMLC_DISMISS_CASE_STATUS2 = 0;
            ALERT_AMLC_DISMISS_CASE_STATUS3 = 0;
            BATCH_RUN_METHOD1 = 0;
            BATCH_RUN_AUTO_TIME1 = 0;
            BATCH_RUN_AUTO_EOD1 = 0;
            BATCH_RUN_PATH1 = "";
            BATCH_RUN_METHOD2 = 0;
            BATCH_RUN_AUTO_TIME2 = 0;
            BATCH_RUN_AUTO_EOD2 = 0;
            BATCH_RUN_PATH2 = "";
            BATCH_RUN_METHOD3 = 0;
            BATCH_RUN_AUTO_TIME3 = 0;
            BATCH_RUN_AUTO_EOD3 = 0;
            BATCH_RUN_PATH3 = "";
            BATCH_RUN_METHOD4 = 0;
            BATCH_RUN_AUTO_TIME4 = 0;
            BATCH_RUN_AUTO_EOD4 = 0;
            BATCH_RUN_PATH4 = "";
            BATCH_RUN_METHOD5 = 0;
            BATCH_RUN_AUTO_TIME5 = 0;
            BATCH_RUN_AUTO_EOD5 = 0;
            BATCH_RUN_PATH5 = "";
            BATCH_RUN_METHOD6 = 0;
            BATCH_RUN_AUTO_TIME6 = 0;
            BATCH_RUN_AUTO_EOD6 = 0;
            BATCH_RUN_PATH6 = "";
            LAST_WATCHLIST_UPT_DATE1 = 0;
            LAST_WATCHLIST_UPT_DATE2 = 0;
            LAST_WATCHLIST_UPT_DATE3 = 0;
            LAST_WATCHLIST_UPT_DATE4 = 0;
            LAST_WATCHLIST_UPT_DATE5 = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        public string EQ_PREFIX { get; set; }
        public int LAST_EQ_NO { get; set; }
        public Int16 EQ_NO_LEN { get; set; }
        public string RULE_PREFIX { get; set; }
        public int LAST_RULE_NO { get; set; }
        public Int16 RULE_NO_LEN { get; set; }
        public string GROUP_PREFIX { get; set; }
        public int LAST_GROUP_NO { get; set; }
        public Int16 GROUP_NO_LEN { get; set; }
        public int LAST_RISKLEVEL_NO { get; set; }
        public int LAST_FILTER_NO { get; set; }
        public int LAST_IMPORT_BATCH_NO { get; set; }
        public int LAST_PROCESS_DATE { get; set; }
        public int CURRENT_PROCESS_DATE { get; set; }
        public int AGENT_PROCESS_NO { get; set; }
        public Int64 LAST_ALERT_NO { get; set; }
        public Int64 LAST_WATCHLIST_NO { get; set; }
        public Int16 RISKASS_APPROVAL_REQ { get; set; }
        public Int16 DL_APPROVAL_REQ { get; set; }
        public Int16 CP_APPROVAL_REQ { get; set; }
        public Int16 PQ_APPROVAL_REQ { get; set; }
        public Int16 ALERT_HIT_CHECK_THRESHOLD { get; set; }
        public Int16 ALERT_ASSIGN_BR_IND { get; set; }
        public Int16 ALERT_ASSIGN_BR_SP_IND { get; set; }
        public string ALERT_ASSIGN_BR_SP_CODE { get; set; }
        public Int16 ALERT_ASSIGN_BR_SP_CASE_STATUS { get; set; }
        public Int16 ALERT_DETECTION_METHOD { get; set; }
        public Int16 ALERT_STR_UPT_MONITOR_IND { get; set; }
        public Int16 ALERT_MONITORING_PERIOD { get; set; }
        public double ALERT_VIEW_DISMISS_PERCENT { get; set; }
        public Int16 ALERT_VIEW_DISSMISS_REJECT_ST { get; set; }
        public Int16 ALERT_STR_CASE_STATUS { get; set; }
        public Int16 ALERT_BR_VIEW_CASE_STATUS { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST1 { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST2 { get; set; }
        public Int16 ALERT_DISSMISS_APPLY_TO_CASE_ST3 { get; set; }
        public string SERVERREPORT_URL { get; set; }
        public string SERVERREPORT_PATH { get; set; }
        public Int16 SAME_FX_BASE_CURR_FD { get; set; }
        public Int16 SHOW_FX_AMT_COLUMN { get; set; }
        public int LAST_RS_NO { get; set; }
        public int LAST_MSG_NO { get; set; }
        public Int16 SEND_MAIL1 { get; set; }
        public Int16 SEND_MAIL2 { get; set; }
        public Int16 ALERT_STR_SUBMIT_AUTO_UPT_CLOSE_ST { get; set; }
        public string ALERT_STR_FIELD_ID_IN_CIF { get; set; }
        public string ALERT_STR_FIELD_ID_IN_ACCT { get; set; }
        public Int16 WATCHLIST_REDIRECT_CASE_ST { get; set; }
        public Int16 ALERT_AMLC_NO_OF_APPROVAL_REQ { get; set; }
        public Int16 ALERT_AMLC_VIEW_CASE_STATUS1 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS1 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS2 { get; set; }
        public Int16 ALERT_AMLC_DISMISS_CASE_STATUS3 { get; set; }
        public Int16 BATCH_RUN_METHOD1 { get; set; }
        public int BATCH_RUN_AUTO_TIME1 { get; set; }
        public int BATCH_RUN_AUTO_EOD1 { get; set; }
        public string BATCH_RUN_PATH1 { get; set; }
        public Int16 BATCH_RUN_METHOD2 { get; set; }
        public int BATCH_RUN_AUTO_TIME2 { get; set; }
        public int BATCH_RUN_AUTO_EOD2 { get; set; }
        public string BATCH_RUN_PATH2 { get; set; }
        public Int16 BATCH_RUN_METHOD3 { get; set; }
        public int BATCH_RUN_AUTO_TIME3 { get; set; }
        public int BATCH_RUN_AUTO_EOD3 { get; set; }
        public string BATCH_RUN_PATH3 { get; set; }
        public Int16 BATCH_RUN_METHOD4 { get; set; }
        public int BATCH_RUN_AUTO_TIME4 { get; set; }
        public int BATCH_RUN_AUTO_EOD4 { get; set; }
        public string BATCH_RUN_PATH4 { get; set; }
        public Int16 BATCH_RUN_METHOD5 { get; set; }
        public int BATCH_RUN_AUTO_TIME5 { get; set; }
        public int BATCH_RUN_AUTO_EOD5 { get; set; }
        public string BATCH_RUN_PATH5 { get; set; }
        public Int16 BATCH_RUN_METHOD6 { get; set; }
        public int BATCH_RUN_AUTO_TIME6 { get; set; }
        public int BATCH_RUN_AUTO_EOD6 { get; set; }
        public string BATCH_RUN_PATH6 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE1 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE2 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE3 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE4 { get; set; }
        public int LAST_WATCHLIST_UPT_DATE5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}
