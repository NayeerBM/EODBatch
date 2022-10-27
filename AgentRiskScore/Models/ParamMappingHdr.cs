using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Record created date
    /// </summary>
    public partial class ParamMappingHdr
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        /// <summary>
        /// 1-CLIENT\n2-ACCOUNT\n3-TRANSACTION
        /// </summary>
        public int MapType { get; set; }
        /// <summary>
        /// Store the product no for respective mapping\n1-CASA\n2-Loan\n3-Treasury\n4-Others
        /// </summary>
        public int MapProduct { get; set; }
        /// <summary>
        /// Mapping Name
        /// </summary>
        public string MapName { get; set; }
        /// <summary>
        /// Store the table name of selected map
        /// </summary>
        public string MapTable { get; set; }
        public string MapDefaultQuery { get; set; }
        public string MapLatestQuery { get; set; }
        /// <summary>
        /// 0-inactive\n1-active
        /// </summary>
        public int ConfigStatus { get; set; }
        /// <summary>
        /// Date record created
        /// </summary>
        public DateTime AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created the record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the record updated
        /// </summary>
        public DateTime AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update the record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
