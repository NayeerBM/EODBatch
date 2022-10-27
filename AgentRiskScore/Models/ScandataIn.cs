using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ScandataIn
    {
        public long JobId { get; set; }
        public long SysId { get; set; }
        public string FileFormat { get; set; }
        public string WatchlistType { get; set; }
        public string AccountNo { get; set; }
        public string CifNo { get; set; }
        public string BranchCode { get; set; }
        public string RemarkField { get; set; }
        public string ScanEntityName { get; set; }
        public string ScanIdValue { get; set; }
        public string ScanCountryName { get; set; }
        public string ScanDob { get; set; }
        public string InUserId { get; set; }
        public string MacTag { get; set; }
        public double? TranAmount { get; set; }
        public string ThirdPartyPayor { get; set; }
        public string ScanGender { get; set; }
        public string ScanEntityType { get; set; }
        public string ScanNativeName { get; set; }
    }
}
