using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Customerstatus
    {
        /// <summary>
        /// CIF Number
        /// </summary>
        public string NoCif { get; set; }
        public string Indicator { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
