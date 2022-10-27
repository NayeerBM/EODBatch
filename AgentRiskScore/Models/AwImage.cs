using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwImage
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string ImageId { get; set; }
        public string ImageType { get; set; }
        public string ImageUrl { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
