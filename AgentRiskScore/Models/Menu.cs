using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Menu
    {
        public int IdModule { get; set; }
        public int IdMenu { get; set; }
        public string InfoName { get; set; }
        public string InfoLink { get; set; }
        public int FlagEnable { get; set; }
        public string InfoVersion { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditModifiedDate { get; set; }
        public string AuditModifiedUser { get; set; }
    }
}
