using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigJobStep
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public string JobId { get; set; }
        public string StepId { get; set; }
        public string StepName { get; set; }
        public int StepOrder { get; set; }
        public string ProgArgument { get; set; }
        public string ProgName { get; set; }
        public int? ProcessStatus { get; set; }
        public int? StepStatus { get; set; }
        public int ProcessPercent { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
