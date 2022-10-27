using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwStr
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string AccountNo { get; set; }
        public string RefCaseNo { get; set; }
        public string RefNoticeNo { get; set; }
        public string DocType { get; set; }
        public string DocControlNo { get; set; }
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
        public short? DownloadableInd { get; set; }
        public short? PublicInd { get; set; }
    }
}
