using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class TransactionDeltum
    {
        public int TranId { get; set; }
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public int NoMaster { get; set; }
        public string NoCif { get; set; }
        public string NoAccount { get; set; }
    }
}
