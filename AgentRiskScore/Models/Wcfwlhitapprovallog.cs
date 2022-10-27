using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Wcfwlhitapprovallog
    {
        public int ScanNo { get; set; }
        public int AutoSysId { get; set; }
        public int EstDate { get; set; }
        public string ApprovalType { get; set; }
        public string Remark { get; set; }
        public string ApprovedBy { get; set; }
        public int ApprovalDate { get; set; }
        public int ApprovalTime { get; set; }
    }
}
