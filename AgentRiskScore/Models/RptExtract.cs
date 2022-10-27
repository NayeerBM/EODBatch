using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptExtract
    {
        /// <summary>
        /// Company COde
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        public int ExtractionId { get; set; }
        public string ReportType { get; set; }
        /// <summary>
        /// 1 - Case ID (from and to) // 2 - Txn Date (from and to)
        /// </summary>
        public int? RangeType { get; set; }
        public string RangeFrom { get; set; }
        public string RangeTo { get; set; }
        public string OutputType { get; set; }
        public string ExtractedRec { get; set; }
        public string ExtractedBy { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int? ExtractStatus { get; set; }
        public string ExtractedFile { get; set; }
        public int? ReportStatus { get; set; }
        /// <summary>
        /// Transaction Report Country (7004001 CodePrime)
        /// </summary>
        public int? ReportCountry { get; set; }
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
