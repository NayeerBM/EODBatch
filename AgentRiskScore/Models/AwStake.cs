using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwStake
    {
        public string EntityId { get; set; }
        public int SysId { get; set; }
        public string InfoSource { get; set; }
        public short Stake1Id { get; set; }
        public string Stake1Desc { get; set; }
        public short Stake2Id { get; set; }
        public string Stake2Desc { get; set; }
        public short Stake3Id { get; set; }
        public string Stake3Desc { get; set; }
        public string StakeNotes { get; set; }
        public string StakePrct { get; set; }
        public string BatchNo { get; set; }
        public int BatchDate { get; set; }
    }
}
