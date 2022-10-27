using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Remarks performed on watchlist module
    /// </summary>
    public partial class RfOddAct
    {
        public int CodeSeq { get; set; }
        /// <summary>
        /// Company Code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int? CodeOrg { get; set; }
        /// <summary>
        /// RedFlag ID for watchlist module
        /// </summary>
        public long? RfId { get; set; }
        /// <summary>
        /// Case ID for watchlist Module
        /// </summary>
        public int? CaseId { get; set; }
        /// <summary>
        /// Remarks fill in by users
        /// </summary>
        public string AuditRemarks { get; set; }
        public string AuditAction { get; set; }
        /// <summary>
        /// Status changed upon activity performed
        /// </summary>
        public int? AuditStatus { get; set; }
        /// <summary>
        /// Status changed upon activity performed
        /// </summary>
        public int? AuditSubStatus { get; set; }
        /// <summary>
        /// Date time activity being executed
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User ID of staff performed activity
        /// </summary>
        public string AuditCreatedUser { get; set; }
    }
}
