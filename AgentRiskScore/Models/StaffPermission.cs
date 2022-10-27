using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class StaffPermission
    {
        public string UserId { get; set; }
        public short? UserType { get; set; }
        public string Watchlist { get; set; }
        public string RiskProfile { get; set; }
        public string TransactionScreening { get; set; }
        public string Onboard { get; set; }
        public string TransactionMonitoring { get; set; }
        public string Reports { get; set; }
        public string Portfolio { get; set; }
        public string People { get; set; }
        public string Setting { get; set; }
        public string History { get; set; }
        public string JobStatus { get; set; }
        public short? WatchlistRf { get; set; }
        public short? TxnMonitoringRf { get; set; }
        public short? OnboardRf { get; set; }
        public short? OddRf { get; set; }
    }
}
