using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfT
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
        public short? TranType { get; set; }
        /// <summary>
        /// date of transaction made
        /// </summary>
        public int? TranDate { get; set; }
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
        public short? TagRev { get; set; }
        /// <summary>
        /// product code of transaction take place
        /// </summary>
        public string InfoProduct { get; set; }
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
        public string FileId { get; set; }
        public string MsgId { get; set; }
        /// <summary>
        /// Channel: SWIFT, CITAD, VCB, etc
        /// </summary>
        public string Source { get; set; }
        public string PayInstructionId { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitSender { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitBene { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitId { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitSanctionCountry { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitTxnPurpose { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitAmount { get; set; }
        /// <summary>
        /// Y/N
        /// </summary>
        public string HitBic { get; set; }
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
    }
}
