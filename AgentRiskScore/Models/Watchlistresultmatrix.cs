using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchlistresultmatrix
    {
        public short CompCode { get; set; }
        public short HitPercent { get; set; }
        public short ShowRangeFr { get; set; }
        public short ShowRangeTo { get; set; }
        public short ShowRangeFr1 { get; set; }
        public short ShowRangeTo1 { get; set; }
        public short ShowTopRec { get; set; }
        public short RelGroup { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
