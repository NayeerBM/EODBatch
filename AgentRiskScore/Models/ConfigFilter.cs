using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Table declared to specified filter for each template and level ID
    /// </summary>
    public partial class ConfigFilter
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int? CodeOrg { get; set; }
        /// <summary>
        /// Workflow module affected
        /// </summary>
        public int? WfModule { get; set; }
        /// <summary>
        /// Workflow ID for selected template
        /// </summary>
        public int? WfId { get; set; }
        /// <summary>
        /// Workflow level for selected row
        /// </summary>
        public int? WfLevel { get; set; }
        /// <summary>
        /// Field Name for selection filtering
        /// </summary>
        public string FilterFdName { get; set; }
        /// <summary>
        /// Data to be stored for specified filtering
        /// </summary>
        public string FilterData { get; set; }
        /// <summary>
        /// Table name for specified filtering (Customer/
        /// </summary>
        public string FilterTable { get; set; }
        /// <summary>
        /// 1 - Rule\n2 - Workflow
        /// </summary>
        public int? FilterType { get; set; }
        /// <summary>
        /// rule for filtering purpose
        /// </summary>
        public string RuleId { get; set; }
        public string FilterForm { get; set; }
        public string FilterDataStart { get; set; }
        /// <summary>
        /// End mark of the data
        /// </summary>
        public string FilterDataEnd { get; set; }
        /// <summary>
        /// First date data being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// First user created data
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date data get updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who perform latest action
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
