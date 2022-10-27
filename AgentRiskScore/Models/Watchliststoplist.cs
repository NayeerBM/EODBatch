using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchliststoplist
    {
        public short CompCode { get; set; }
        public string AbbrValue { get; set; }
        public string AbbrReplacement { get; set; }
        public string OrgDescription { get; set; }
        public short Status { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
