using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class D2fWlIdTempalerttran
    {
        public short CompCode { get; set; }
        public string TempAlertId { get; set; }
        public long AlertId { get; set; }
        public int AutoSeqNo { get; set; }
        public string RecType { get; set; }
        public string RecIdentityNo { get; set; }
        public int HitDate { get; set; }
        public string HitGrpId { get; set; }
        public string HitErId { get; set; }
        public string HitErName { get; set; }
        public double HitErThreshold { get; set; }
        public string HitEqId { get; set; }
        public double? HitEqWeight { get; set; }
        public short HitEqNoOfDays { get; set; }
        public string HitEqIdMultiple { get; set; }
        public string HitRlRiskLevel { get; set; }
        public string HitAssessmentInd { get; set; }
        public short HitRanking { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string CifId { get; set; }
        public short CreditDebit { get; set; }
        public int TranDate { get; set; }
        public int PostingDate { get; set; }
        public int ValueDate { get; set; }
        public string TranCode { get; set; }
        public string BrCode { get; set; }
        public string AlertBr { get; set; }
        public string TranLocation { get; set; }
        public int TransCount { get; set; }
        public double LocalAmount { get; set; }
        public string LocalCurrency { get; set; }
        public double ForeignAmount { get; set; }
        public double FxRate { get; set; }
        public short TranReversalInd { get; set; }
        public string ReferanceNo { get; set; }
        public string ReferanceDt { get; set; }
        public string ProductCode { get; set; }
        public int PrimaryAlertRec { get; set; }
        public short Status { get; set; }
        public short LastStatus { get; set; }
        public int StatusUptDt { get; set; }
        public int UserUptCount { get; set; }
        public int ActionGuideNo { get; set; }
        public int AlertHitStatus { get; set; }
        public short DismissInd { get; set; }
        public int DismissDate { get; set; }
        public int DismissTime { get; set; }
        public int DismissViewDate { get; set; }
        public int DismissViewTime { get; set; }
        public string DismissViewBy { get; set; }
        public int EstablishDate { get; set; }
        public int EstablishTime { get; set; }
        public int LastUptDate { get; set; }
        public int LastUptTime { get; set; }
        public short HqTranInd { get; set; }
        public short StaffInd { get; set; }
        public string AmlFraudInd { get; set; }
        public long ParentAlertId { get; set; }
        public short GroupAlertInd { get; set; }
        public int BatchDate { get; set; }
        public string BatchNo { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string RuserId { get; set; }
        public string ModeMn { get; set; }
    }
}
