using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RiskCalcFilter
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        public string AssessmentId { get; set; }
        public short RiskCalcId { get; set; }
        public int FilterId { get; set; }
        public short FilterDisplayOrder { get; set; }
        /// <summary>
        /// Table name for specified filtering (Customer/
        /// </summary>
        public string FilterTable { get; set; }
        /// <summary>
        /// Field Name for selection filtering
        /// </summary>
        public string FilterField { get; set; }
        public string FilterFormula { get; set; }
        /// <summary>
        /// Data to be stored for specified filtering
        /// </summary>
        public string FilterInputData { get; set; }
        public string FilterDatatype { get; set; }
        public string FilterOperator { get; set; }
        public string FilterQuery { get; set; }
        public short RiskTableParentId { get; set; }
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
