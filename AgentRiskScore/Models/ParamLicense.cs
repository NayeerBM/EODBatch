using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamLicense
    {
        public int LicenseId { get; set; }
        public string OrgNumber { get; set; }
        public string OrgName { get; set; }
        public string LicenseCategory { get; set; }
        public DateTime? LicenseEstablish { get; set; }
        public DateTime? LicenseExpire { get; set; }
        public int? GracePeriod { get; set; }
        public string KeyValidator { get; set; }
        public int? StatusLicense { get; set; }
        public int? Portfolio { get; set; }
        public int? TxnScreening { get; set; }
        public int? TxnMonitoring { get; set; }
        public int? RiskProfile { get; set; }
        public int? WlMonitoring { get; set; }
        public int? OdMonitoring { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
