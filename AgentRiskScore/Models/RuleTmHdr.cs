using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RuleTmHdr
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// System generated ID base on running no
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// Description of the rule
        /// </summary>
        public string RuleDesc { get; set; }
        /// <summary>
        /// Watchlist Type (DJ, WC, Std)
        /// </summary>
        public string RuleType { get; set; }
        /// <summary>
        /// 1-delta wl to full customer\n2-full wl to delta customer\n3-delta wl to delta customer\n4-full wl to full customer
        /// </summary>
        public int? ScenarioType { get; set; }
        /// <summary>
        /// Scenario Description
        /// </summary>
        public string ScenarioDesc { get; set; }
        public string ReportType { get; set; }
        /// <summary>
        /// 1-active\n0-inactive
        /// </summary>
        public int? RuleStatus { get; set; }
        public int? TmWeakresult { get; set; }
        /// <summary>
        /// Combined Query. Split Query can be found inside RULE_TM_FILTER table
        /// </summary>
        public string GrpFiltering { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public int? EodBatchStatus { get; set; }
        public int? RuleTxn { get; set; }
        public int? RuleTxnHistory { get; set; }
        public int? RuleCif { get; set; }
        public int? RuleAccount { get; set; }
        public int? RuleCurrency { get; set; }
        /// <summary>
        /// Indicator to exclude STR client
        /// </summary>
        public short RuleStrFilter { get; set; }
        /// <summary>
        /// Exclude STR client for certain of duration
        /// </summary>
        public int RuleStrFilterDuration { get; set; }
        public string GrpSqlStmt { get; set; }
    }
}
