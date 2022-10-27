using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwMasterDelete
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
        public string BriefName { get; set; }
        public short ExistingStatus { get; set; }
        public short ApprovalStatus { get; set; }
        public string RjRemarks { get; set; }
        public string ApprovedBy { get; set; }
        public int ApprovedDt { get; set; }
        public int ApprovedTm { get; set; }
        public string Action { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
