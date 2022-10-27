using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfWm
    {
        /// <summary>
        /// company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// module of redflag
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// assign case id
        /// </summary>
        public int? CaseId { get; set; }
        /// <summary>
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// Customer&apos;s identification no
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// date of redflag being generated
        /// </summary>
        public int? HitDate { get; set; }
        /// <summary>
        /// rule id for hit redflag
        /// </summary>
        public string HitRuleid { get; set; }
        /// <summary>
        /// rule name for hit redflag
        /// </summary>
        public string HitRulename { get; set; }
        public string InfoName { get; set; }
        /// <summary>
        /// customer&apos;s account opening branch
        /// </summary>
        public string InfoBranch { get; set; }
        /// <summary>
        /// product code of account take place
        /// </summary>
        public string TypeProduct { get; set; }
        /// <summary>
        /// current redflag status
        /// </summary>
        public short? AuditStatus { get; set; }
        /// <summary>
        /// tagging of staff
        /// </summary>
        public short? TagStaff { get; set; }
        /// <summary>
        /// tagging of fraud
        /// </summary>
        public string TagFraud { get; set; }
        /// <summary>
        /// case ID where this redflag being assigned
        /// </summary>
        public long? TagCaseAssign { get; set; }
        /// <summary>
        /// to differentiate type of search performed (partial, full, etc etc)
        /// </summary>
        public string TypeSearch { get; set; }
        /// <summary>
        /// search name resulting to hit
        /// </summary>
        public string HitSearch { get; set; }
        /// <summary>
        /// total volume watchlist hit
        /// </summary>
        public int? HitVol { get; set; }
        /// <summary>
        /// total volume watchlist hit base on name
        /// </summary>
        public int? HitVolName { get; set; }
        /// <summary>
        /// total volume watchlist hit base on ID
        /// </summary>
        public int? HitVolId { get; set; }
        /// <summary>
        /// table use for name screening
        /// </summary>
        public string ConfigTable { get; set; }
        /// <summary>
        /// table use for screening
        /// </summary>
        public string ConfigSqlfd { get; set; }
        /// <summary>
        /// to differentiate the method of detection
        /// </summary>
        public string ConfigDetect { get; set; }
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
