using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class TemplateFile
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
        /// File ID
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Template File Name
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Template File Path
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
