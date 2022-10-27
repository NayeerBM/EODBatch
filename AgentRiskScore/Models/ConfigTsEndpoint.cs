using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigTsEndpoint
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        public string SourceId { get; set; }
        public string SourceName { get; set; }
        public string ApiEndpoint { get; set; }
        public string AuthEndpoint { get; set; }
        public string Token { get; set; }
        public int? Status { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
    }
}
