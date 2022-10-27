using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class VwEsSsResultsCifacc
    {
        public string AccountNo { get; set; }
        public string CifNo { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string ClientCountry { get; set; }
        public string ClientGender { get; set; }
        public string ClientDob { get; set; }
        public string CategoryFilter { get; set; }
        public string SanctionFilter { get; set; }
        public string Id1No { get; set; }
    }
}
