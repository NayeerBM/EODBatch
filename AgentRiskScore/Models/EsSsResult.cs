using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class EsSsResult
    {
        public long AutoSeqNo { get; set; }
        public string AccountNo { get; set; }
        public string CifNo { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string ClientCountry { get; set; }
        public string ClientGender { get; set; }
        public string ClientDob { get; set; }
        public string CategoryFilter { get; set; }
        public string SanctionFilter { get; set; }
        public string EntityId { get; set; }
        public string SysId { get; set; }
        public string InfoSource { get; set; }
        public string EntityType { get; set; }
        public string NameType { get; set; }
        public string SingleStringName2 { get; set; }
        public string SingleStringName3 { get; set; }
        public string OriginalScriptName { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Dob { get; set; }
        public string Country { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Namesource { get; set; }
        public string Sanction { get; set; }
        public string Match { get; set; }
        public double ConfidenceScore { get; set; }
    }
}
