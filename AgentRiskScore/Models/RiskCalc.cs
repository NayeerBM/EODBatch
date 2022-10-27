using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RiskCalc
    {
        /// <summary>
        /// company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        public string AssessmentId { get; set; }
        public short RiskCalcId { get; set; }
        public short SeqNo { get; set; }
        public int? RiskCalcType { get; set; }
        public string RiskCalcDesc { get; set; }
        public int? FirsttimeRp { get; set; }
        public short Status { get; set; }
        public int? FilterStatus { get; set; }
        public short? TableParentId { get; set; }
        public string GrpCifTable { get; set; }
        public string GrpAcctTable { get; set; }
        public string GrpMiscTable { get; set; }
        public string GrpMaxSoureTable { get; set; }
        public short GrpMaxSoureParentId { get; set; }
        public short GrpComputeMethod { get; set; }
        public short GrpLinkAcc { get; set; }
        public string ScoreFd { get; set; }
        public string MaxScoreFd { get; set; }
        public short RiskModelNo { get; set; }
        public string GrpLinkScoreFd { get; set; }
        public short LinkCodetableNo { get; set; }
        public short GrpFilterStatus { get; set; }
        /// <summary>
        /// Full Query
        /// </summary>
        public string GrpSqlStmt { get; set; }
        /// <summary>
        /// Filtered Condition
        /// </summary>
        public string GrpFilterStmt { get; set; }
        public short GrpFilterMiscStatus { get; set; }
        public string GrpMiscSqlStmt { get; set; }
        public short GrpFilterAcctStatus { get; set; }
        public string GrpAcctSqlStmt { get; set; }
        public short GrpFilterCifStatus { get; set; }
        public string GrpCifSqlStmt { get; set; }
        public short GrpFilterMiscStatus1 { get; set; }
        public string GrpMiscSqlStmt1 { get; set; }
        public short GrpFilterAcctStatus1 { get; set; }
        public string GrpAcctSqlStmt1 { get; set; }
        public short GrpFilterCifStatus1 { get; set; }
        public string GrpCifSqlStmt1 { get; set; }
        public int? SqlVerifyInd { get; set; }
        /// <summary>
        /// Date the record being created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User created the record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the record being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// user who modify the record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
