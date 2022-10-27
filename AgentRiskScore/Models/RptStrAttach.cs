using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptStrAttach
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
        /// Sequence to tag STR between DTL and HDR
        /// </summary>
        public int StrHdrSeq { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public string FileBase64 { get; set; }
        public string FileEncode { get; set; }
        /// <summary>
        /// Date time attachment being executed
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User ID of staff performed activity
        /// </summary>
        public string AuditCreatedUser { get; set; }
    }
}
