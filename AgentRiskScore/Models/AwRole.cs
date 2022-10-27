using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwRole
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string RoleType { get; set; }
        public int SinceDay { get; set; }
        public int SinceMonth { get; set; }
        public int SinceYear { get; set; }
        public int ToDay { get; set; }
        public int ToMonth { get; set; }
        public int ToYear { get; set; }
        public string OccCategory { get; set; }
        public string OccTitle { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public string OccId { get; set; }
    }
}
