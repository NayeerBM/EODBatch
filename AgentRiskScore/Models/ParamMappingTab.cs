using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamMappingTab
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public int TabNo { get; set; }
        public int MapType { get; set; }
        public string TabDisplayName { get; set; }
        public int? TabStatus { get; set; }
        /// <summary>
        /// Date of this user being created
        /// </summary>
        public DateTime? TabCreatedDate { get; set; }
        /// <summary>
        /// User who created record for this ID
        /// </summary>
        public string TabCreatedUser { get; set; }
        /// <summary>
        /// Date of this record being updated
        /// </summary>
        public DateTime? TabUpdatedDate { get; set; }
        /// <summary>
        /// User who update record for this ID
        /// </summary>
        public string TabUpdatedUser { get; set; }
        public int ColumnNo { get; set; }
        public string ColumnDisplayName { get; set; }
        public int? ColumnTable { get; set; }
        public int? ColumnField { get; set; }
        public int? ColumnParameter { get; set; }
        public int? ColumnStatus { get; set; }
        public DateTime? ColumnCreatedDate { get; set; }
        public string ColumnCreatedUser { get; set; }
        public DateTime? ColumnUpdatedDate { get; set; }
        public string ColumnUpdatedUser { get; set; }
    }
}
