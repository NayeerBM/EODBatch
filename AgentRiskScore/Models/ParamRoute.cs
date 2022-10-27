using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Grouping of location codes to be assign as redflag routing
    /// </summary>
    public partial class ParamRoute
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// A group of location to be taken as a place (cor_branch_group)
        /// </summary>
        public string RouteCode { get; set; }
        /// <summary>
        /// Name of the grouping location
        /// </summary>
        public string RouteName { get; set; }
        /// <summary>
        /// Description of the grouping location
        /// </summary>
        public string RouteDesc { get; set; }
        /// <summary>
        /// List of location codes to be added into group
        /// </summary>
        public string RouteList { get; set; }
        /// <summary>
        /// Status of the routing (0D1E)
        /// </summary>
        public short ConfigStatus { get; set; }
        /// <summary>
        /// Date of record being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User ID who created the record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the record being updated
        /// </summary>
        public DateTime? AuditUpdateDate { get; set; }
        /// <summary>
        /// User ID who update the record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
