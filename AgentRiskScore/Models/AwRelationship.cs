using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwRelationship
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string AssociateEntity { get; set; }
        public string RelationshipType { get; set; }
        public string ExRelationship { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
