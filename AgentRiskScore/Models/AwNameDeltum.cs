using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwNameDeltum
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string NameType { get; set; }
        public string TitleHonorific { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string MaidenName { get; set; }
        public string Suffix { get; set; }
        public string EntityName { get; set; }
        public string SingleStringName { get; set; }
        public string SingleStringName2 { get; set; }
        public string SingleStringName3 { get; set; }
        public string OriginalScriptName { get; set; }
        public short FalsePositive { get; set; }
        public int FalsePositiveExpiryDt { get; set; }
        public short ApprovalStatus { get; set; }
        public string HighRiskCountry { get; set; }
        public short HighRiskCountryScore { get; set; }
        public string Category { get; set; }
        public string Dob { get; set; }
        public string Country { get; set; }
        public string IdRefNo { get; set; }
        public string Action { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public string Sanction { get; set; }
        public string Categorynum { get; set; }
        public string Countries { get; set; }
        public string IdFilter { get; set; }
    }
}
