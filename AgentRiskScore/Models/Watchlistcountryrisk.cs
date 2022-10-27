using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchlistcountryrisk
    {
        public short CompCode { get; set; }
        public short RiskType { get; set; }
        public string HighRiskKey { get; set; }
        public short DisplayOreder { get; set; }
        public string RiskDescription { get; set; }
        public string Category { get; set; }
        public string IsoAlpha3 { get; set; }
        public string IsoNumericCode { get; set; }
        public string CurrencyDescr { get; set; }
        public string IsoCurrCode { get; set; }
        public short HighRiskScore1 { get; set; }
        public short HighRiskScore2 { get; set; }
        public short HighRiskScore3 { get; set; }
        public short HighRiskScore4 { get; set; }
        public short HighRiskScore5 { get; set; }
        public short? Status { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updating
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        public string ModeMn { get; set; }
    }
}
