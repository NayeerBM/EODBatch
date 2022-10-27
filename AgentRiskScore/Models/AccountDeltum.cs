using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AccountDeltum
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public int NoMaster { get; set; }
        public string NoCif { get; set; }
        public string NoAccount { get; set; }
    }
}
