using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchlistalgorithmcat
    {
        public short CompCode { get; set; }
        public short CategoryType { get; set; }
        public string CatDesc { get; set; }
        public string Cat1 { get; set; }
        public string Cat2 { get; set; }
        public string Cat3 { get; set; }
        public string Cat4 { get; set; }
        public string Cat5 { get; set; }
        public short ExcludedCat1 { get; set; }
        public short ExcludedCat2 { get; set; }
        public short ExcludedCat3 { get; set; }
        public short ExcludedCat4 { get; set; }
        public short ExcludedCat5 { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
