using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwMaster
    {
        public string EntityId { get; set; }
        public string InfoSource { get; set; }
        public string EntityType { get; set; }
        public string Gender { get; set; }
        public string ActiveStatus { get; set; }
        public string Deceased { get; set; }
        public string BirthPlace { get; set; }
        public string ProfileNotes { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string HighRiskCountry { get; set; }
        public short HighRiskCountryScore { get; set; }
        public short CompCode { get; set; }
        public short FalsePositive { get; set; }
        public int FalsePositiveExpiryDt { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public string Action { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public short SubsidiaryCode { get; set; }
        public string SubsidiaryDesc { get; set; }
        public string IndustryCode { get; set; }
        public string IndustryDesc { get; set; }
        public string DateOfNational { get; set; }
        public string DateOfPrivate { get; set; }
        public string DateOfCessation { get; set; }
    }
}
