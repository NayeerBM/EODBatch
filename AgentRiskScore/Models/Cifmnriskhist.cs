using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Cifmnriskhist
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Master no of client
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// CIF Number
        /// </summary>
        public string NoCif { get; set; }
        public short RiskLevel { get; set; }
        public string RiskDesc { get; set; }
        public short ModifiedRiskLevel { get; set; }
        public string ModifiedRiskDesc { get; set; }
        public short? RiskLevel1 { get; set; }
        public string RiskDesc1 { get; set; }
        public short? ModifiedRiskLevel1 { get; set; }
        public string ModifiedRiskDesc1 { get; set; }
        public int? UpdateDate { get; set; }
        public int? ModifiedDate { get; set; }
        public string Remarks { get; set; }
        public string DoneUserId { get; set; }
        public short? ApprovalStatus { get; set; }
        public string ApprovedBy1 { get; set; }
        public int? ApprovedDt1 { get; set; }
        public int? ApprovedTm1 { get; set; }
        public string RjRemarks { get; set; }
        public string UserId { get; set; }
        public string UserId1 { get; set; }
        public DateTime? StampDttm { get; set; }
        public string ModeMn { get; set; }
        public int? BatchDate { get; set; }
        public string BatchNo { get; set; }
    }
}
