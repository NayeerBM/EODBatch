using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamStrHdr
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
        public int StrId { get; set; }
        /// <summary>
        /// Name for template created
        /// </summary>
        public string StrName { get; set; }
        /// <summary>
        /// To load coutry available for STR in config_codes_dtl
        /// </summary>
        public int? StrCountry { get; set; }
        /// <summary>
        /// 1-CTR\n2-STR
        /// </summary>
        public int StrType { get; set; }
        /// <summary>
        /// 0-inactive\n1-active
        /// </summary>
        public int StrStatus { get; set; }
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
