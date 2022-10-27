using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwDate
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public string DateType { get; set; }
        public string DateGiven { get; set; }
        public string DateNotes { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
