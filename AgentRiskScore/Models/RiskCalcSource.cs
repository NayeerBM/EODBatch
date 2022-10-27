using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RiskCalcSource
    {
        public short CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public string AssessmentId { get; set; }
        public short RiskfactorId { get; set; }
        public short RiskCalcId { get; set; }
        public short AutoSeqNo { get; set; }
        public string RiskDesc { get; set; }
        public int? ParamCode { get; set; }
        public string SourceTable { get; set; }
        public string SourceField { get; set; }
        public string DestinationTable { get; set; }
        public string DestinationField { get; set; }
        public int Status { get; set; }
        /// <summary>
        /// Date the record being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User created the record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// user who modify the record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
