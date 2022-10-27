using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfTm
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
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// Assigned case ID
        /// </summary>
        public int? CaseId { get; set; }
        /// <summary>
        /// module of redflag
        /// </summary>
        public string ModuleId { get; set; }
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
        public string NoMaster { get; set; }
        /// <summary>
        /// customer&apos;s account number
        /// </summary>
        public string NoAccount { get; set; }
        /// <summary>
        /// customer&apos;s name
        /// </summary>
        public string InfoName { get; set; }
        /// <summary>
        /// customer&apos;s identification number
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// credit / debit / both
        /// </summary>
        public string TranType { get; set; }
        /// <summary>
        /// date of transaction made
        /// </summary>
        public int? TranDate { get; set; }
        /// <summary>
        /// posting date of transaction performed
        /// </summary>
        public int? TranPostDate { get; set; }
        /// <summary>
        /// value date of transaction performed
        /// </summary>
        public int? TranValDate { get; set; }
        /// <summary>
        /// transaction code of transaction performed
        /// </summary>
        public string TranCode { get; set; }
        /// <summary>
        /// customer&apos;s account opening branch
        /// </summary>
        public string InfoBranch { get; set; }
        /// <summary>
        /// routed alert for customer branch
        /// </summary>
        public string HitBranch { get; set; }
        /// <summary>
        /// location of transaction take place
        /// </summary>
        public string TranLocation { get; set; }
        /// <summary>
        /// total number of transaction performed
        /// </summary>
        public int? TranVol { get; set; }
        /// <summary>
        /// total amount of transaction performed
        /// </summary>
        public double? TranAmount { get; set; }
        /// <summary>
        /// currency of transaction performed
        /// </summary>
        public string TranCur { get; set; }
        /// <summary>
        /// total amount of transaction of foreign currency
        /// </summary>
        public double? TranCurAmount { get; set; }
        /// <summary>
        /// conversion rate of currency
        /// </summary>
        public double? TranRate { get; set; }
        public short? TagRev { get; set; }
        /// <summary>
        /// product code of transaction take place
        /// </summary>
        public string InfoProduct { get; set; }
        /// <summary>
        /// current redflag status
        /// </summary>
        public short? AuditStatus { get; set; }
        /// <summary>
        /// update date of current redflag status
        /// </summary>
        public int? AuditStatusDate { get; set; }
        /// <summary>
        /// date of this record created
        /// </summary>
        public int? AuditDateCreated { get; set; }
        /// <summary>
        /// time of this record created
        /// </summary>
        public int? AuditTimeCreated { get; set; }
        /// <summary>
        /// date of this record updated
        /// </summary>
        public int? AuditDateUpdated { get; set; }
        /// <summary>
        /// time of this record updated
        /// </summary>
        public int? AuditTimeUpdated { get; set; }
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
        /// indicator of this redflag has been raised as case
        /// </summary>
        public short TagCase { get; set; }
        /// <summary>
        /// total transaction history volume
        /// </summary>
        public int? TranHvol { get; set; }
        /// <summary>
        /// total transaction history amount
        /// </summary>
        public double? TranHamount { get; set; }
        /// <summary>
        /// total amount foreign
        /// </summary>
        public double? TranHcurAmount { get; set; }
        /// <summary>
        /// flag filtering sql statement
        /// </summary>
        public short? FlagFiltersql { get; set; }
        /// <summary>
        /// filtering used to capture history transaction
        /// </summary>
        public string InfoFiltersql { get; set; }
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
