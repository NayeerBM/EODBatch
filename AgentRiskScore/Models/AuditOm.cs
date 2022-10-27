using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AuditOm
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
        /// Date time activity being executed
        /// </summary>
        public DateTime? AuditStampdt { get; set; }
        /// <summary>
        /// User ID of staff performed activity
        /// </summary>
        public string AuditUserId { get; set; }
        /// <summary>
        /// Module being accessed by user
        /// </summary>
        public int? AuditModule { get; set; }
        /// <summary>
        /// Page accessed by user
        /// </summary>
        public int? AuditPage { get; set; }
        /// <summary>
        /// Activity performed by user (click button, submit form, open, close, delete)
        /// </summary>
        public int? AuditActivity { get; set; }
        public string AuditActivityDesc { get; set; }
    }
}
