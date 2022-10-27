using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfOdd
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
        /// Display the date that ODD is generated
        /// </summary>
        public DateTime? CommDate { get; set; }
        /// <summary>
        /// Display the date that ODD needs to complete be review before next renewal date
        /// </summary>
        public DateTime? NextReviewDate { get; set; }
        /// <summary>
        /// Display the follow up status of the ODD. Allow user to update.
        /// </summary>
        public string FollowupStatus { get; set; }
        /// <summary>
        /// Display the reason review of the ODD. Allow user to update.
        /// </summary>
        public string Reason { get; set; }
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
