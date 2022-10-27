using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigPwrestrict
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
        /// Password Restriction ID
        /// </summary>
        public int RestrictId { get; set; }
        public string PasswordRestrict { get; set; }
        public int ConfigStatus { get; set; }
        /// <summary>
        /// Date of the parameter being registered
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created the paramater
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the parameter being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated the parameter
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
