using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchlistalgorithmdtl
    {
        public short CompCode { get; set; }
        public short WlAlgo { get; set; }
        public string WlType { get; set; }
        public string WlKey { get; set; }
        public string WlDtlDesc { get; set; }
        public short SetHitPercents { get; set; }
        public short ApplyEditDistant { get; set; }
        public short ShowNoOfTopRec { get; set; }
        public int? NumericValue { get; set; }
        public string TextValue { get; set; }
        public int BooleanValue { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
