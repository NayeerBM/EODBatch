using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Jobbatchlog
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public int RunDate { get; set; }
        public string JobId { get; set; }
        public string StepId { get; set; }
        public int UniqueKey { get; set; }
        public int? RunTime { get; set; }
        public string RefNo1 { get; set; }
        public string RefNo2 { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
