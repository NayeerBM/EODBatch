using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwVessel
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string VesselCallSign { get; set; }
        public string VesselType { get; set; }
        public string VesselTonnage { get; set; }
        public string VesselGrt { get; set; }
        public string VesselOwner { get; set; }
        public string VesselFlag { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
