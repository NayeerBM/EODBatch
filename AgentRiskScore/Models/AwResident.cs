using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwResident
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public int Type { get; set; }
        public string CountryType { get; set; }
        public string CountryCode { get; set; }
        public string CountryDesc { get; set; }
        public short MainEntry { get; set; }
        public string SubEntityId { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
