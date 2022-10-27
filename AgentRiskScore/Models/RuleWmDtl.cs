using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RuleWmDtl
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public string RuleId { get; set; }
        public int RuleConId { get; set; }
        /// <summary>
        /// Condition Name
        /// </summary>
        public string RuleConDesc { get; set; }
        public string RuleSrcTable { get; set; }
        public string RuleSrcField { get; set; }
        public string RuleDestTable { get; set; }
        public string RuleDestField { get; set; }
        /// <summary>
        /// 1-active\n0-inactive
        /// </summary>
        public int? RuleStatus { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
