using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigWfHdr
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
        /// Module ID
        /// </summary>
        public int WfModule { get; set; }
        /// <summary>
        /// Template ID for workflow
        /// </summary>
        public int WfId { get; set; }
        /// <summary>
        /// Template name of the workflow
        /// </summary>
        public string WfName { get; set; }
        /// <summary>
        /// Max level of Alert Esculation
        /// </summary>
        public int? WfLevelMax { get; set; }
        /// <summary>
        /// To indicate the template is active inactive (0D1E)
        /// </summary>
        public int? WfStatus { get; set; }
        /// <summary>
        /// Workflow filtering status (0-inactive/1-active)
        /// </summary>
        public int? WfFilterStatus { get; set; }
        /// <summary>
        /// Date template created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who create the template
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date template get updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update the template
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
