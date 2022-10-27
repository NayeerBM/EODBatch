using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfCase
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int? CodeOrg { get; set; }
        public int CaseId { get; set; }
        /// <summary>
        /// Master Number of client
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// CIF No of customer
        /// </summary>
        public string NoCif { get; set; }
        public int CaseStatus { get; set; }
        public int? CaseSubStatus { get; set; }
        public int? ModuleId { get; set; }
        public int CaseLevel { get; set; }
        public int? ReviewCase { get; set; }
        /// <summary>
        /// User attending alert
        /// </summary>
        public string AuditUser { get; set; }
        /// <summary>
        /// Level of Role User
        /// </summary>
        public int? AuditUserLevel { get; set; }
        public DateTime AuditDateUpdated { get; set; }
        public DateTime AuditDateCreated { get; set; }
    }
}
