﻿using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Table declared to specified filter for each template and level ID
    /// </summary>
    public partial class RuleWmFilter
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
        /// Rule ID
        /// </summary>
        public string RuleId { get; set; }
        public int FilterId { get; set; }
        public short FilterDisplayOrder { get; set; }
        public string FilterObracket { get; set; }
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
        public string FilterCbracket { get; set; }
        public string FilterDatatype { get; set; }
        public string FilterOperator { get; set; }
        public string FilterQuery { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
    }
}
