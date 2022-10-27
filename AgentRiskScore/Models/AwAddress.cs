using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwAddress
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string Url { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
