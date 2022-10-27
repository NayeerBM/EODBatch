using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Header for config codes dtl
    /// </summary>
    public partial class ConfigCodesHdr
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
        /// Grouping Code
        /// </summary>
        public int CodePrime { get; set; }
        /// <summary>
        /// Description of the grouping category
        /// </summary>
        public string InfoCategory { get; set; }
        /// <summary>
        /// Title of the DATA_VALUEI1
        /// </summary>
        public string I1Title { get; set; }
        /// <summary>
        /// Description of the DATA_VALUEI1
        /// </summary>
        public string I1Desc { get; set; }
        /// <summary>
        /// Visibility of DATA_VALUEI1 (0D1E)
        /// </summary>
        public short I1Visible { get; set; }
        /// <summary>
        /// Title of the DATA_VALUEI2
        /// </summary>
        public string I2Title { get; set; }
        /// <summary>
        /// Description of the DATA_VALUEI2
        /// </summary>
        public string I2Desc { get; set; }
        /// <summary>
        /// VIsibility of the DATA_VALUEI2 (0D1E)
        /// </summary>
        public short I2Visible { get; set; }
        /// <summary>
        /// Title of the DATA_VALUEF1
        /// </summary>
        public string F1Title { get; set; }
        /// <summary>
        /// Description of the DATA_VALUEF1
        /// </summary>
        public string F1Desc { get; set; }
        /// <summary>
        /// Visibility of the DATA_VALUEF1
        /// </summary>
        public short F1Visible { get; set; }
        public string F2Title { get; set; }
        public string F2Desc { get; set; }
        public short F2Visible { get; set; }
        public string T1Title { get; set; }
        public string T1Desc { get; set; }
        public short T1Visible { get; set; }
        public string T2Title { get; set; }
        public string T2Desc { get; set; }
        public short T2Visible { get; set; }
        public string D1Title { get; set; }
        public string D1Desc { get; set; }
        public short D1Visible { get; set; }
        public string D2Title { get; set; }
        public string D2Desc { get; set; }
        public short D2Visible { get; set; }
        /// <summary>
        /// Record created date
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User ID who created this record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date record being updated
        /// </summary>
        public DateTime? AuditUpdateDate { get; set; }
        /// <summary>
        /// User ID who updated the record
        /// </summary>
        public string AuditUpdateUser { get; set; }
        public short? ConfigStatus { get; set; }
    }
}
