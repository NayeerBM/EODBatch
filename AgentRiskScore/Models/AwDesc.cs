using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwDesc
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string Description { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public int DescId1 { get; set; }
        public int DescId2 { get; set; }
        public int DescId3 { get; set; }
    }
}
