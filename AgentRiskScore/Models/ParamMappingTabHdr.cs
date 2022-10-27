using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamMappingTabHdr
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public int TabNo { get; set; }
        public int MapType { get; set; }
        public string TabDisplayName { get; set; }
        public int? Status { get; set; }
        /// <summary>
        /// Date of this user being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created record for this ID
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update record for this ID
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
