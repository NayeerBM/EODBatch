using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwEducation
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public int SinceDay { get; set; }
        public int SinceMonth { get; set; }
        public int SinceYear { get; set; }
        public int ToDay { get; set; }
        public int ToMonth { get; set; }
        public int ToYear { get; set; }
        public string InstituteName { get; set; }
        public string Qualification { get; set; }
        public string MajorSubject { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public string UserId { get; set; }
        public DateTime? StampDttm { get; set; }
        public string ModeMn { get; set; }
    }
}
