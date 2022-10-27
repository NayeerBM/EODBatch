using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptStrHdr
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
        /// Sequence header for each reported STR under 1 customer
        /// </summary>
        public int StrHdrSeq { get; set; }
        public int CaseId { get; set; }
        /// <summary>
        /// STR ID taken from param_mapping_hdr
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// 1(Draft) 2(Final)
        /// </summary>
        public int? StrStatus { get; set; }
        /// <summary>
        /// Participant Type 1 for individual 2 for organization
        /// </summary>
        public int? PartType { get; set; }
        /// <summary>
        /// Transaction Date
        /// </summary>
        public int TranDate { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// User level who performed STR creation/edition
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
