using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfAlertAssigned
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int? CodeOrg { get; set; }
        /// <summary>
        /// ID of redflag
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// ID of case being made
        /// </summary>
        public long CaseId { get; set; }
        /// <summary>
        /// Module ID of the redflag
        /// </summary>
        public int? ModuleId { get; set; }
        public int RfStatus { get; set; }
        public int RfDate { get; set; }
        public DateTime AuditDateUpdated { get; set; }
        public DateTime AuditDateCreated { get; set; }
    }
}
