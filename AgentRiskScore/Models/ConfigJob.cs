using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigJob
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public string JobId { get; set; }
        public int JobSeq { get; set; }
        public string JobName { get; set; }
        public int JobGroup { get; set; }
        public int? JobStatus { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
