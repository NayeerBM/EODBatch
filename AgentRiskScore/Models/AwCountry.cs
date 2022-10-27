using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwCountry
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string CountryType { get; set; }
        public string CountryCode { get; set; }
        public string CountryDesc { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
