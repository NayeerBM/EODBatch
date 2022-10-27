using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfOmcountryresult
    {
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        public int SeqNo { get; set; }
        public string InputData { get; set; }
        public string Result { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
    }
}
