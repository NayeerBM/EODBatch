using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Riskrulematrixdtl
    {
        public short CompCode { get; set; }
        public short RiskNo { get; set; }
        public short RiskType { get; set; }
        public short RiskLevel { get; set; }
        public int SeqNo { get; set; }
        public int RiskFactor1 { get; set; }
        public int RiskFactor2 { get; set; }
        public int RiskFactor3 { get; set; }
        public int RiskFactor4 { get; set; }
        public int RiskFactor5 { get; set; }
        public int RiskFactor6 { get; set; }
        public int RiskFactor7 { get; set; }
        public int RiskFactor8 { get; set; }
        public int RiskFactor9 { get; set; }
        public int? ColTotalValue { get; set; }
        public short ColRiskLevel1 { get; set; }
        public short ColRiskLevel2 { get; set; }
        public short ColRiskLevel3 { get; set; }
        public short ColRiskLevel4 { get; set; }
        public short ColRiskLevel5 { get; set; }
        public short ColRiskLevel6 { get; set; }
        public short ColRiskLevel7 { get; set; }
        public short ColRiskLevel8 { get; set; }
        public short ColRiskLevel9 { get; set; }
        public string ColDesc1 { get; set; }
        public string ColDesc2 { get; set; }
        public string ColDesc3 { get; set; }
        public string ColDesc4 { get; set; }
        public string ColDesc5 { get; set; }
        public string ColDesc6 { get; set; }
        public string ColDesc7 { get; set; }
        public string ColDesc8 { get; set; }
        public string ColDesc9 { get; set; }
        public string SortFields { get; set; }
        public short ComputeLevel { get; set; }
        public short ComputeMethod { get; set; }
        public int ComputeSeq { get; set; }
    }
}
