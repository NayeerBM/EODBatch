using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class NoMasterHist
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        public string NoMaster { get; set; }
        public string NoCif { get; set; }
        public string AuditNoCifOld { get; set; }
        public string AuditNoMasterOld { get; set; }
        public string InfoNameFull { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public DateTime? AuditMergedDate { get; set; }
        public DateTime? AuditUnmergedDate { get; set; }
    }
}
