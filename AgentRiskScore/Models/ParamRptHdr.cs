using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamRptHdr
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
        /// Template ID for created template
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// Name for template created
        /// </summary>
        public string ReportName { get; set; }
        /// <summary>
        /// To load coutry available for STR in config_codes_dtl
        /// </summary>
        public int? ReportCountry { get; set; }
        /// <summary>
        /// 1-CTR\n2-STR
        /// </summary>
        public string ReportType { get; set; }
        /// <summary>
        /// 0-inactive\n1-active
        /// </summary>
        public int ReportStatus { get; set; }
        /// <summary>
        /// date created
        /// </summary>
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date updated
        /// </summary>
        public DateTime AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
