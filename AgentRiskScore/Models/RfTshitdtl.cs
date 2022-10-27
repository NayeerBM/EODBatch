using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfTshitdtl
    {
        /// <summary>
        /// company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// system running number (index purpose)
        /// </summary>
        public long SysSeq { get; set; }
        /// <summary>
        /// Hit indicator for 1-Sanction country/currency, 2-BIC code, 3-Txn purpose, 4-Amount
        /// </summary>
        public short? TypeHit { get; set; }
        public string Input { get; set; }
        public string HitValue { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
