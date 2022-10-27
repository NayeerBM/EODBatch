using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwFalsePositive
    {
        public string EntityId { get; set; }
        public string InfoSource { get; set; }
        public short FalsePositive { get; set; }
        public int FalsePositiveExpiryDt { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
