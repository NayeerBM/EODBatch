using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwClassification
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string RegulationDesc { get; set; }
        public int SectionNo { get; set; }
        public int SubSectionNo { get; set; }
        public int SubsubSectionNo { get; set; }
        public string RegulationMain { get; set; }
        public string RegulationSub { get; set; }
        public string RegulationSubsub { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
