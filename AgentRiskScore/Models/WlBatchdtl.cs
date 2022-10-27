using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class WlBatchdtl
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
        /// ID created for each individual\n- To insert incrementally from csv to db
        /// </summary>
        public string InputId { get; set; }
        /// <summary>
        /// Screened name
        /// </summary>
        public string InfoName { get; set; }
        /// <summary>
        /// Screened ID
        /// </summary>
        public string InfoId { get; set; }
        /// <summary>
        /// Screened nationality
        /// </summary>
        public string InfoNationality { get; set; }
        /// <summary>
        /// Screened gender
        /// </summary>
        public string InfoGender { get; set; }
        /// <summary>
        /// Screened DOB
        /// </summary>
        public string InfoDob { get; set; }
        /// <summary>
        /// Screened native name
        /// </summary>
        public string InfoNative { get; set; }
        /// <summary>
        /// Screened entity type
        /// </summary>
        public string InfoEntType { get; set; }
        /// <summary>
        /// Screened info source
        /// </summary>
        public string InfoSource { get; set; }
        /// <summary>
        /// Screened
        /// </summary>
        public string InfoCategory { get; set; }
        /// <summary>
        /// 0-disable\n1-enable
        /// </summary>
        public int InfoPassport { get; set; }
        /// <summary>
        /// Security No
        /// </summary>
        public string InfoSec { get; set; }
        /// <summary>
        /// Expiry Date
        /// </summary>
        public string InfoDateExp { get; set; }
        /// <summary>
        /// Expiry date security no
        /// </summary>
        public string InfoSecExp { get; set; }
        /// <summary>
        /// Country risk verification\n0-disable\n1-enable
        /// </summary>
        public int InfoCountry { get; set; }
        /// <summary>
        /// TBD
        /// </summary>
        public int InfoPurpose { get; set; }
        /// <summary>
        /// 0-No Hit\n1-Hit
        /// </summary>
        public int? ResultHit { get; set; }
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
    }
}
