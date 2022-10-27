using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class WlBatchlog
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Running No for Job
        /// </summary>
        public int JobId { get; set; }
        /// <summary>
        /// 1-Watchlist\n2-Screening
        /// </summary>
        public short UploadType { get; set; }
        /// <summary>
        /// Source type of uploaded file (only apply for internal upload)
        /// </summary>
        public string UploadSource { get; set; }
        /// <summary>
        /// Uploaded filename
        /// </summary>
        public string UploadFileName { get; set; }
        /// <summary>
        /// Uploaded file size
        /// </summary>
        public int UploadFileSize { get; set; }
        /// <summary>
        /// Generated filename
        /// </summary>
        public string ResultFileName { get; set; }
        /// <summary>
        /// Generated file size
        /// </summary>
        public int ResultFileSize { get; set; }
        /// <summary>
        /// Total record successfully processed
        /// </summary>
        public int TotalProcessed { get; set; }
        /// <summary>
        /// Total record available in file
        /// </summary>
        public int TotalRecord { get; set; }
        /// <summary>
        /// Total record hit
        /// </summary>
        public int TotalHit { get; set; }
        /// <summary>
        /// 0-Pending\n1-In Progress\n2-Completed
        /// </summary>
        public short Status { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// Date record created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// user who created the record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date record updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// user who updated the record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        /// <summary>
        /// 0-archive\n1-active
        /// </summary>
        public int? Active { get; set; }
        public string FileEncode { get; set; }
        public string ResultFileEncode { get; set; }
    }
}
