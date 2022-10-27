using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class staff
    {
        /// <summary>
        /// Code to distinguish which company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Coed to distinguish which organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// User ID use to access system
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Distinguishing user type as :\n- system admin\n- user admin\n- user
        /// </summary>
        public short UserType { get; set; }
        /// <summary>
        /// To assign user workflow process
        /// </summary>
        public string UserWorkflow { get; set; }
        /// <summary>
        /// To assign a group of user to following user
        /// </summary>
        public string UserOffice { get; set; }
        /// <summary>
        /// To assign viewable redflag to following user
        /// </summary>
        public string UserRouting { get; set; }
        /// <summary>
        /// To assign an email for BAU to following user
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// To configure which menu is accessible by following user
        /// </summary>
        public string UserMenu { get; set; }
        /// <summary>
        /// To configure which module is accessible by following user
        /// </summary>
        public string UserModule { get; set; }
        public string UserDasboard { get; set; }
        /// <summary>
        /// User Full Name
        /// </summary>
        public string InfoNameFull { get; set; }
        /// <summary>
        /// User first name
        /// </summary>
        public string InfoNameFirst { get; set; }
        /// <summary>
        /// User middle name
        /// </summary>
        public string InfoNameMiddle { get; set; }
        /// <summary>
        /// User last name
        /// </summary>
        public string InfoNameLast { get; set; }
        public string Position { get; set; }
        /// <summary>
        /// Store the first date user login into system
        /// </summary>
        public int? AuditFirstLogindate { get; set; }
        /// <summary>
        /// Store the first time user login into system
        /// </summary>
        public int? AuditFirstLogintime { get; set; }
        /// <summary>
        /// Store the latest time user login into system
        /// </summary>
        public int? AuditLastLogintime { get; set; }
        /// <summary>
        /// Store the latest date user login into system
        /// </summary>
        public int? AuditLastLogindate { get; set; }
        /// <summary>
        /// To store current no of retry attempt by user
        /// </summary>
        public int? AuditRetry { get; set; }
        /// <summary>
        /// Indicate status of current user (active,inactive,lock)
        /// </summary>
        public short? ConfigStatus { get; set; }
        /// <summary>
        /// Storing SHA-256 password
        /// </summary>
        public string ConfigPassword { get; set; }
        /// <summary>
        /// Temporary password stored for reset purpose
        /// </summary>
        public string FlagPasswordReset { get; set; }
        /// <summary>
        /// To indicate user is accessing to AD/non AD credentials
        /// </summary>
        public short? ConfigAd { get; set; }
        /// <summary>
        /// To configure when this ID to be expired
        /// </summary>
        public int? ConfigExpiryDate { get; set; }
        /// <summary>
        /// To configure how long (days) this ID will active
        /// </summary>
        public int? ConfigExpiryDay { get; set; }
        /// <summary>
        /// To configure max number of retry
        /// </summary>
        public int? ConfigMaxRetry { get; set; }
        /// <summary>
        /// To configure first date user able to login
        /// </summary>
        public int? ConfigAccessDateFrom { get; set; }
        /// <summary>
        /// To configure last date user able to login
        /// </summary>
        public int? ConfigAccessDateTo { get; set; }
        /// <summary>
        /// To configure earliest time user able to login
        /// </summary>
        public int? ConfigAccessTimeFrom { get; set; }
        /// <summary>
        /// To configure latest time user able to login
        /// </summary>
        public int? ConfigAccessTimeTo { get; set; }
        /// <summary>
        /// Date of this user created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who create the ID
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of user profile being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who update the record of this ID
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        public short? ConfigTheme { get; set; }
        public string ConfigAuthUser { get; set; }
        public int? ConfigAuthDate { get; set; }
        public int? ConfigAuthTime { get; set; }
        public short? ConfigAuthNo { get; set; }
        public short? ConfigLanguage { get; set; }
        public string UserRole { get; set; }
        /// <summary>
        /// TM Workflow template ID
        /// </summary>
        public string WfTmTemplate { get; set; }
        /// <summary>
        /// TM Workflow template level
        /// </summary>
        public int WfTmLevel { get; set; }
        /// <summary>
        /// WM Workflow template ID
        /// </summary>
        public string WfWmTemplate { get; set; }
        /// <summary>
        /// WM Workflow template level
        /// </summary>
        public int WfWmLevel { get; set; }
        /// <summary>
        /// RP Workflow template ID
        /// </summary>
        public string WfRpTemplate { get; set; }
        /// <summary>
        /// RP Workflow template level
        /// </summary>
        public int WfRpLevel { get; set; }
        /// <summary>
        /// Payment Monitoring workflow template ID
        /// </summary>
        public string WfPmTemplate { get; set; }
        /// <summary>
        /// Onboard Monitoring workflow template ID
        /// </summary>
        public string WfOmTemplate { get; set; }
        /// <summary>
        /// Payment Monitoring workflow template level
        /// </summary>
        public int WfPmLevel { get; set; }
        /// <summary>
        /// Onboard Monitoring workflow template level
        /// </summary>
        public int WfOmLevel { get; set; }
        /// <summary>
        /// Transaction Screening workflow template ID
        /// </summary>
        public string WfTsTemplate { get; set; }
        /// <summary>
        /// Transaction Screening workflow template level
        /// </summary>
        public int WfTsLevel { get; set; }
        public string AccessToken { get; set; }
    }
}
