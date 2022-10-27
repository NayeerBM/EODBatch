using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Watchlistalgorithm
    {
        public short CompCode { get; set; }
        public short WlAlgo { get; set; }
        public string WlDesc { get; set; }
        public string WlRmk { get; set; }
        public short Enabled { get; set; }
        public short LinkTableNo { get; set; }
        public string LinkTableType { get; set; }
        public string LinkPageId { get; set; }
        public short LinkTableFmt { get; set; }
        public string NumericFieldDesc { get; set; }
        public string TextFieldDesc { get; set; }
        public string BooleanFieldDesc { get; set; }
        public string DispIconControl { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
