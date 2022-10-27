using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwBirthinfo
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public short InfoType { get; set; }
        public string BirthinfoDate { get; set; }
        public string BirthinfoPlace { get; set; }
        public string BirthinfoCountry { get; set; }
        public short MainEntry { get; set; }
        public string SubEntityId { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
