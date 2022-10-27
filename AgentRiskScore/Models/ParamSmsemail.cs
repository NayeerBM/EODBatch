using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// To configure template group for email / sms
    /// </summary>
    public partial class ParamSmsemail
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CompCode { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Key ID for email group
        /// </summary>
        public int GrpKey { get; set; }
        /// <summary>
        /// Module applicable for this sms/email
        /// </summary>
        public int? GrpModule { get; set; }
        /// <summary>
        /// Description of email group
        /// </summary>
        public string GrpDesc { get; set; }
        /// <summary>
        /// To send email/sms within these template no
        /// </summary>
        public string GrpTemplateNo { get; set; }
        /// <summary>
        /// 0-both / 1-SMS / 2 Email
        /// </summary>
        public short? FlagType { get; set; }
        /// <summary>
        /// receiver of message
        /// </summary>
        public string SmsSendTo { get; set; }
        /// <summary>
        /// CC to for sent message
        /// </summary>
        public string SmsCc { get; set; }
        /// <summary>
        /// Message of email
        /// </summary>
        public string SmsMsg { get; set; }
        /// <summary>
        /// Title of email (subject)
        /// </summary>
        public string EmailSubject { get; set; }
        /// <summary>
        /// Sender email
        /// </summary>
        public string EmailSendfrom { get; set; }
        /// <summary>
        /// Receiver email
        /// </summary>
        public string EmailSendto { get; set; }
        /// <summary>
        /// CC email
        /// </summary>
        public string EmailCc { get; set; }
        /// <summary>
        /// Email attachment
        /// </summary>
        public string EmailAttachment { get; set; }
        /// <summary>
        /// Email message
        /// </summary>
        public string EmailMsg { get; set; }
        /// <summary>
        /// remarks for template
        /// </summary>
        public string InfoRemarks { get; set; }
        /// <summary>
        /// active / inactive
        /// </summary>
        public short? InfoStatus { get; set; }
        /// <summary>
        /// Date of this template created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created this template
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this template updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated this template
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
