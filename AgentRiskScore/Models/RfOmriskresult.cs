using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfOmriskresult
    {
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        public string AssessmentId { get; set; }
        public string ComparisonData { get; set; }
        public string FilteringCriteria { get; set; }
        public string InputData { get; set; }
        public string Match { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
    }
}
