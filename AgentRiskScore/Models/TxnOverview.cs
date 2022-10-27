using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class TxnOverview
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
        /// CIF number
        /// </summary>
        public string NoCif { get; set; }
        public short Year { get; set; }
        public short Month { get; set; }
        public short Week { get; set; }
        public double AmtCr { get; set; }
        public double AmtDr { get; set; }
        public long TxnCountCr { get; set; }
        public long TxnCountDr { get; set; }
        public int BatchDate { get; set; }
        public string BatchNo { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
    }
}
