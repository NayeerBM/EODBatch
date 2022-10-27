using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Riskrulemodeldtl
    {
        public short CompCode { get; set; }
        public short RiskNo { get; set; }
        public short AutoSeqNo { get; set; }
        public short DisplayOrder { get; set; }
        public string RiskItemDesc { get; set; }
        public short TableParentId { get; set; }
        public string TableIdUsed { get; set; }
        public string GrpLinkScoreFd { get; set; }
        public string GrpLinkScoreFdDesc { get; set; }
        public short LinkCodetableNo { get; set; }
        public short MinScoreValue { get; set; }
        public short MaxScoreValue { get; set; }
        public short Status { get; set; }
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
