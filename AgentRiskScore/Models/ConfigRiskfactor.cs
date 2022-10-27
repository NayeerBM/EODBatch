using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigRiskfactor
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public string AssessmentId { get; set; }
        public int RiskfactorId { get; set; }
        public string RiskfactorTitle { get; set; }
        public string RiskfactorDesc { get; set; }
        public int? RiskLvl1 { get; set; }
        public int? RiskLvl2 { get; set; }
        public int? RiskLvl3 { get; set; }
        public int? RiskLvl4 { get; set; }
        public int? RiskLvl5 { get; set; }
        public int? RiskLvl6 { get; set; }
        public int? MinScore { get; set; }
        public int? MaxScore { get; set; }
        public int? ParamCode { get; set; }
        public int? Status { get; set; }
        /// <summary>
        /// Date of this user being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created record for this ID
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update record for this ID
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
