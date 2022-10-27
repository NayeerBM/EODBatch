using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwReference
    {
        public int RefNo { get; set; }
        public string RefKey1 { get; set; }
        public string RefKey2 { get; set; }
        public string RefType { get; set; }
        public string RefDesc { get; set; }
        public int RefValuei1 { get; set; }
        public int RefValuei2 { get; set; }
        public string RefValuet1 { get; set; }
        public string RefValuet2 { get; set; }
    }
}
