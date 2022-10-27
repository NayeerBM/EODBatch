using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RiskTemp
    {
        public string NoCif { get; set; }
        public string NoMaster { get; set; }
        public int SumRiskCalcType1 { get; set; }
        public int SumRiskCalcType2 { get; set; }
        public int SumRiskCalcType3 { get; set; }
        public int FinalScore { get; set; }
    }
}
