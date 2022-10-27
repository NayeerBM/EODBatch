using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class CustomerWhitelist
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public string NoMaster { get; set; }
        public string NoCif { get; set; }
        public string NoAcc { get; set; }
        public string FirstName { get; set; }
        public int CifFalsePositiveDt { get; set; }
        public short CifFalsePositiveInd { get; set; }
        public int CifFalsePositiveDtWl { get; set; }
        public short CifFalsePositiveIndWl { get; set; }
        public string CifTableName { get; set; }
        public string Remarks { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
