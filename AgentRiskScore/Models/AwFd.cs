using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwFd
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public short FdsType { get; set; }
        public string FdsTypedesc { get; set; }
        public string FdsCode { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
