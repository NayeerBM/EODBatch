using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Attachment on Transaction Monitoring module
    /// </summary>
    public partial class RfTsAttach
    {
        public int CodeSeq { get; set; }
        /// <summary>
        /// Company Code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int? CodeOrg { get; set; }
        /// <summary>
        /// RedFlag ID for Transaction Monitoring module
        /// </summary>
        public long? RfId { get; set; }
        /// <summary>
        /// Case ID for Transaction Monitoring Module
        /// </summary>
        public int? CaseId { get; set; }
        /// <summary>
        /// Attachment File Name
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Attachment File Path
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// Date time attachment being executed
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User ID of staff performed activity
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Encoded data of each files
        /// </summary>
        public string FileEncode { get; set; }
    }
}
