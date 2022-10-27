using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Storing parameter error coming from system
    /// </summary>
    public partial class ParamError
    {
        /// <summary>
        /// Company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Module ID
        /// </summary>
        public short ModuleId { get; set; }
        /// <summary>
        /// Error code to be used by system
        /// </summary>
        public short InfoCode { get; set; }
        /// <summary>
        /// Description of error to be displayed at the front end
        /// </summary>
        public short? InfoDescription { get; set; }
        /// <summary>
        /// To indicate the status of the error (warning, error, etc)
        /// </summary>
        public short? ConfigStatus { get; set; }
        /// <summary>
        /// (TBC) Order of sequence to be used during setting up at front end
        /// </summary>
        public short? ConfigSeq { get; set; }
        /// <summary>
        /// To differentiate the language used on displaying description of error
        /// </summary>
        public short? ConfigLanguage { get; set; }
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
    }
}
