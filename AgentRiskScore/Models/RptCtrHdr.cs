using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptCtrHdr
    {
        /// <summary>
        /// Company COde
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Customer no master
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// Customer  no CIF
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// Sequence header for each reported CTR under 1 customer
        /// </summary>
        public int CtrHdrSeq { get; set; }
        public int CaseId { get; set; }
        /// <summary>
        /// CTR ID taken from param_mapping_hdr
        /// </summary>
        public string ReportId { get; set; }
        public string ReportIdentifier { get; set; }
        /// <summary>
        /// Participant Type
        /// </summary>
        public int? PartType { get; set; }
        /// <summary>
        /// Transaction Date
        /// </summary>
        public int? TranDate { get; set; }
        /// <summary>
        /// Transaction Currency
        /// </summary>
        public string TranCur { get; set; }
        public double? TranAmount { get; set; }
        /// <summary>
        /// CTR Date Extracted
        /// </summary>
        public DateTime? ExtractDate { get; set; }
        /// <summary>
        /// CTR Date Exported
        /// </summary>
        public DateTime? ExportDate { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// User level who performed CTR creation/edition
        /// </summary>
        public string AuditUserLevel { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date record updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// USer ID who perform updation process
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
