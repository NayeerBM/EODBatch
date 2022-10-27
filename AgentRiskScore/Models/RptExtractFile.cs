using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptExtractFile
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public int ExtractionId { get; set; }
        public int SeqNo { get; set; }
        public string ExtractedFile { get; set; }
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
