using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Wcfwlhittran
    {
        public short CompCode { get; set; }
        public int ScanNo { get; set; }
        public int SrcSeqNo { get; set; }
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public int AutoSeqNo { get; set; }
        public string YourRef { get; set; }
        public short HitIdOrName { get; set; }
        public string InfoSource { get; set; }
        public string NameType { get; set; }
        public string SingleStringName { get; set; }
        public string IdValue { get; set; }
        public string Country { get; set; }
        public string Dobs { get; set; }
        public string Category { get; set; }
        public string Namesource { get; set; }
        public short MatchPercent { get; set; }
        public short InvestigateStatus { get; set; }
        public short TypeOfExposition { get; set; }
        public string Remarks { get; set; }
        public int LastUptDate { get; set; }
        public int LastUptTime { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
        public string AccountNo { get; set; }
        public string CifId { get; set; }
        public short FalsePositiveInd { get; set; }
        public DateTime BatchDate { get; set; }
        public double WeightagePercent { get; set; }
        public string WeightageCompute { get; set; }
        public string Gender { get; set; }
        public string Match { get; set; }
        public string Subcategory { get; set; }
        public string Sanction { get; set; }
        public string EntityType { get; set; }
        public string Categorynum { get; set; }
        public string OriginalScriptName { get; set; }
    }
}
