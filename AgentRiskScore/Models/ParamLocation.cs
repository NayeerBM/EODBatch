using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Location of staff being assigned to
    /// </summary>
    public partial class ParamLocation
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
        /// Location Code
        /// </summary>
        public string LocCode { get; set; }
        /// <summary>
        /// Abbreviation of Location
        /// </summary>
        public string LocShort { get; set; }
        /// <summary>
        /// Name of the location
        /// </summary>
        public string LocName { get; set; }
        /// <summary>
        /// Location Description
        /// </summary>
        public string LocDesc { get; set; }
        /// <summary>
        /// emailgroup / staff for selected location
        /// </summary>
        public string MailGroup { get; set; }
        /// <summary>
        /// Date of this location being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created this record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date this record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated this record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
