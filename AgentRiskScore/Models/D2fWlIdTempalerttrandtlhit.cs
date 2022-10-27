using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class D2fWlIdTempalerttrandtlhit
    {
        public short CompCode { get; set; }
        public string TempAlertId { get; set; }
        public long AlertId { get; set; }
        public int AlertSeqno { get; set; }
        public string HitDtlGrpId { get; set; }
        public string HitDtlErId { get; set; }
        public string HitDtlEqId { get; set; }
        public double HitDtlErThreshold { get; set; }
        public short HitDtlErRank { get; set; }
        public short HitDtlEqRuleType { get; set; }
        public string HitDtlEqName { get; set; }
        public double? HitDtlEqWeight { get; set; }
        public short HitDtlEqNoOfDays { get; set; }
        public short CreditDebit { get; set; }
        public int TranDate { get; set; }
        public string TranCode { get; set; }
        public string LocalCurrency { get; set; }
        public double FxRate { get; set; }
        public int TransCount { get; set; }
        public double LocalAmount { get; set; }
        public double ForeignAmount { get; set; }
        public int HistTransCount { get; set; }
        public double HistLocalAmount { get; set; }
        public double HistForeignAmount { get; set; }
        public short HitStatus { get; set; }
        public string AccountNo { get; set; }
        public short FilterTranhistStatus { get; set; }
        public string TranhistSqlStmt { get; set; }
        public int BatchDate { get; set; }
        public string BatchNo { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
        public double CrAmount { get; set; }
        public double DrAmount { get; set; }
    }
}
