using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class TxnHist
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Module ID of Red Flag
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Case ID
        /// </summary>
        public long CaseId { get; set; }
        /// <summary>
        /// Red Flag ID
        /// </summary>
        public long RfId { get; set; }
        public long SeqHistAuto { get; set; }
        /// <summary>
        /// SEQ_AUTO from TXN_DAILY
        /// </summary>
        public long SeqAuto { get; set; }
        /// <summary>
        /// Transaction number
        /// </summary>
        public string TranNo { get; set; }
        /// <summary>
        /// Account number
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// Transaction location
        /// </summary>
        public string TranLoc { get; set; }
        /// <summary>
        /// CIF number
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// Transaction reference number
        /// </summary>
        public string TranRef { get; set; }
        /// <summary>
        /// Transaction type
        /// </summary>
        public string TranType { get; set; }
        /// <summary>
        /// Credit amount
        /// </summary>
        public double AmtCr { get; set; }
        /// <summary>
        /// Debit amount
        /// </summary>
        public double AmtDr { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        public string AmtCur { get; set; }
        /// <summary>
        /// FX rate
        /// </summary>
        public double AmtRate { get; set; }
        /// <summary>
        /// Remaining acc balance
        /// </summary>
        public double AmtBal { get; set; }
        /// <summary>
        /// Original amount
        /// </summary>
        public double AmtOther { get; set; }
        /// <summary>
        /// Product type
        /// </summary>
        public int ProdType { get; set; }
        /// <summary>
        /// Sub product type
        /// </summary>
        public int SprodType { get; set; }
        /// <summary>
        /// Fund type
        /// </summary>
        public string FundType { get; set; }
        /// <summary>
        /// Fund description
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// Auxiliary txn code
        /// </summary>
        public string TranCode1 { get; set; }
        /// <summary>
        /// Txn code
        /// </summary>
        public string TranCode2 { get; set; }
        /// <summary>
        /// Transaction channel
        /// </summary>
        public string TranChan { get; set; }
        /// <summary>
        /// Transaction status
        /// </summary>
        public int TranStatus { get; set; }
        /// <summary>
        /// Transaction purpose
        /// </summary>
        public string TranPurpose { get; set; }
        /// <summary>
        /// Transaction date
        /// </summary>
        public int TranDate { get; set; }
        /// <summary>
        /// Posting date
        /// </summary>
        public int TranPdate { get; set; }
        public int TranVdate { get; set; }
        /// <summary>
        /// Sender name
        /// </summary>
        public string SendName { get; set; }
        /// <summary>
        /// Sender country
        /// </summary>
        public string SendCty { get; set; }
        /// <summary>
        /// Sender bank name
        /// </summary>
        public string SendBname { get; set; }
        /// <summary>
        /// Sender bank country
        /// </summary>
        public string SendBcty { get; set; }
        /// <summary>
        /// Sender bank swift code
        /// </summary>
        public string SendSwift { get; set; }
        /// <summary>
        /// Sender bank BIC
        /// </summary>
        public string SendBic { get; set; }
        /// <summary>
        /// Sender relationship
        /// </summary>
        public string SendRelay { get; set; }
        /// <summary>
        /// Beneficiary name
        /// </summary>
        public string BeneName { get; set; }
        /// <summary>
        /// Beneficiary country
        /// </summary>
        public string BeneCty { get; set; }
        /// <summary>
        /// Beneficiary bank name
        /// </summary>
        public string BeneBname { get; set; }
        /// <summary>
        /// Beneficiary bank country
        /// </summary>
        public string BeneBcty { get; set; }
        /// <summary>
        /// Beneficiary bank swift code
        /// </summary>
        public string BeneSwift { get; set; }
        /// <summary>
        /// Beneficiary bank BIC
        /// </summary>
        public string BeneBic { get; set; }
        /// <summary>
        /// Beneficiary relationship
        /// </summary>
        public string BeneRelay { get; set; }
        public double UnitPrice { get; set; }
        public double UnitVal { get; set; }
        public double UnitRate { get; set; }
        public string PctName { get; set; }
        public string PctNat { get; set; }
        public string PctAdd1 { get; set; }
        public string PctPcode { get; set; }
        public string PctAdd2 { get; set; }
        public string PctCity { get; set; }
        public string PctAdd3 { get; set; }
        public string PctState { get; set; }
        public string PctAdd4 { get; set; }
        public string PctCty { get; set; }
        public string PctRelay { get; set; }
        public string DataValue01 { get; set; }
        public string DataValue02 { get; set; }
        public string DataValue03 { get; set; }
        public string DataValue04 { get; set; }
        public string DataValue05 { get; set; }
        public string DataValue06 { get; set; }
        public string DataValue07 { get; set; }
        public string DataValue08 { get; set; }
        public string DataValue09 { get; set; }
        public string DataValue10 { get; set; }
        public string DataValue11 { get; set; }
        public string DataValue12 { get; set; }
        public string DataValue13 { get; set; }
        public string DataValue14 { get; set; }
        public string DataValue15 { get; set; }
        public string DataValue16 { get; set; }
        public string DataValue17 { get; set; }
        public string DataValue18 { get; set; }
        public string DataValue19 { get; set; }
        public string DataValue20 { get; set; }
        public string DataValue21 { get; set; }
        public string DataValue22 { get; set; }
        public string DataValue23 { get; set; }
        public string DataValue24 { get; set; }
        public string DataValue25 { get; set; }
        public string DataValue26 { get; set; }
        public string DataValue27 { get; set; }
        public string DataValue28 { get; set; }
        public string DataValue29 { get; set; }
        public string DataValue30 { get; set; }
        public string DataValue31 { get; set; }
        public string DataValue32 { get; set; }
        public string DataValue33 { get; set; }
        public string DataValue34 { get; set; }
        public string DataValue35 { get; set; }
        public string DataValue36 { get; set; }
        public string DataValue37 { get; set; }
        public string DataValue38 { get; set; }
        public string DataValue39 { get; set; }
        public string DataValue40 { get; set; }
        public string DataValue41 { get; set; }
        public string DataValue42 { get; set; }
        public string DataValue43 { get; set; }
        public string DataValue44 { get; set; }
        public string DataValue45 { get; set; }
        public string DataValue46 { get; set; }
        public string DataValue47 { get; set; }
        public string DataValue48 { get; set; }
        public string DataValue49 { get; set; }
        public string DataValue50 { get; set; }
        public string DataValue51 { get; set; }
        public string DataValue52 { get; set; }
        public string DataValue53 { get; set; }
        public string DataValue54 { get; set; }
        public string DataValue55 { get; set; }
        public int BatchDate { get; set; }
        public string BatchNo { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
    }
}
