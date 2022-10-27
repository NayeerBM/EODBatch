using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ConfigRiskassessment
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public string AssessmentId { get; set; }
        public string AssessmentDesc { get; set; }
        public int? TotalRisklevel { get; set; }
        public int? AssessmentModule { get; set; }
        public int? Status { get; set; }
        public string RiskLvl1Desc { get; set; }
        public int? RiskLvl1SysMinscore { get; set; }
        public int? RiskLvl1SysMaxscore { get; set; }
        public int? RiskLvl1CustMinscore { get; set; }
        public int? RiskLvl1CustMaxscore { get; set; }
        public string RiskLvl2Desc { get; set; }
        public int? RiskLvl2SysMinscore { get; set; }
        public int? RiskLvl2SysMaxscore { get; set; }
        public int? RiskLvl2CustMinscore { get; set; }
        public int? RiskLvl2CustMaxscore { get; set; }
        public string RiskLvl3Desc { get; set; }
        public int? RiskLvl3SysMinscore { get; set; }
        public int? RiskLvl3SysMaxscore { get; set; }
        public int? RiskLvl3CustMinscore { get; set; }
        public int? RiskLvl3CustMaxscore { get; set; }
        public string RskLvl4Desc { get; set; }
        public int? RiskLvl4SysMinscore { get; set; }
        public int? RiskLvl4SysMaxscore { get; set; }
        public int? RiskLvl4CustMinscore { get; set; }
        public int? RiskLvl4CustMaxscore { get; set; }
        public string RiskLvl5Desc { get; set; }
        public int? RiskLvl5SysMinscore { get; set; }
        public int? RiskLvl5SysMaxscore { get; set; }
        public int? RiskLvl5CustMinscore { get; set; }
        public int? RiskLvl5CustMaxscore { get; set; }
        public string RiskLvl6Desc { get; set; }
        public int? RiskLvl6SysMinscore { get; set; }
        public int? RiskLvl6SysMaxscore { get; set; }
        public int? RiskLvl6CustMinscore { get; set; }
        public int? RiskLvl6CustMaxscore { get; set; }
        public string RiskScoreCode { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod1 { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod2 { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod3 { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod4 { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod5 { get; set; }
        /// <summary>
        /// Review Period (Month)
        /// </summary>
        public int? ReviewPeriod6 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl1 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl2 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl3 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl4 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl5 { get; set; }
        /// <summary>
        /// Risk Level Need to be review? true or false
        /// </summary>
        public int? ReviewRiskLvl6 { get; set; }
        public int? RiskLvl1Status { get; set; }
        public int? RiskLvl2Status { get; set; }
        public int? RiskLvl3Status { get; set; }
        public int? RiskLvl4Status { get; set; }
        public int? RiskLvl5Status { get; set; }
        public int? RiskLvl6Status { get; set; }
        /// <summary>
        /// Date of this user being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created record for this ID
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update record for this ID
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        public int? EodBatchStatus { get; set; }
    }
}
