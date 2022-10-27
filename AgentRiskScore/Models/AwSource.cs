using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwSource
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string Name { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
