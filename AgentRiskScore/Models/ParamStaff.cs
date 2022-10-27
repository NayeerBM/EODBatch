using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Default setup of user
    /// </summary>
    public partial class ParamStaff
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// 1-AML Accessible / 0-AML Maintenance Mode (inaccessible)
        /// </summary>
        public int? FlagAml { get; set; }
        /// <summary>
        /// 1-BI Accessible / 0-BI Maintenance Mode (inaccessible)
        /// </summary>
        public int? FlagBi { get; set; }
        /// <summary>
        /// Minimum length of user id
        /// </summary>
        public int? UserMinlength { get; set; }
        /// <summary>
        /// Maximum length of user id
        /// </summary>
        public int? UserMaxlength { get; set; }
        /// <summary>
        /// To auto generate user id base on system running number
        /// </summary>
        public int? UserAutoid { get; set; }
        /// <summary>
        /// 0-Disable authorization\n1-Require 1 level to approve user\n2-Require 2 level to approve user
        /// </summary>
        public int? UserAuth { get; set; }
        /// <summary>
        /// 0-Disable same admin authorization\n1-Enable same admin authorization
        /// </summary>
        public int? UserAuthSameLevel { get; set; }
        /// <summary>
        /// No of day require for next password changes
        /// </summary>
        public int? PwChangeFreq { get; set; }
        /// <summary>
        /// 1-Required password change on next login (after reset) / 0- using password set on field PW_DEFAULT_TYPE
        /// </summary>
        public int? PwChangeForce { get; set; }
        /// <summary>
        /// Minimum length of password
        /// </summary>
        public int? PwMinlength { get; set; }
        /// <summary>
        /// Maximum length of password
        /// </summary>
        public int? PwMaxlength { get; set; }
        /// <summary>
        /// No of character allowed consecutive identical
        /// </summary>
        public int? PwConsecutive { get; set; }
        /// <summary>
        /// Allow blank char password
        /// </summary>
        public int? PwBlankchar { get; set; }
        /// <summary>
        /// Required special character in password
        /// </summary>
        public int? PwSpecialchar { get; set; }
        /// <summary>
        /// 1-same as default value / 2-same as userid / 3-same as last 4 digit IC
        /// </summary>
        public int? PwDefaultType { get; set; }
        /// <summary>
        /// Default password value
        /// </summary>
        public string PwDefaultVal { get; set; }
        /// <summary>
        /// List of restricted password in the system
        /// </summary>
        public string PwRestricted { get; set; }
        /// <summary>
        /// No of login attempt allowed
        /// </summary>
        public int? LoginTryAllow { get; set; }
        /// <summary>
        /// Start date allow for whole system user
        /// </summary>
        public DateTime? LoginStartDate { get; set; }
        /// <summary>
        /// End date allow for whole system user
        /// </summary>
        public DateTime? LoginEndDate { get; set; }
        /// <summary>
        /// Start time allow for whole system user
        /// </summary>
        public double? LoginStartTime { get; set; }
        /// <summary>
        /// End time allow for whole system user
        /// </summary>
        public double? LoginEndTime { get; set; }
        /// <summary>
        /// Secondary system language
        /// </summary>
        public string LoginLanguageRec { get; set; }
        /// <summary>
        /// Primary theme
        /// </summary>
        public int? LoginTheme { get; set; }
        /// <summary>
        /// Primary system language
        /// </summary>
        public string LoginLanguage { get; set; }
        /// <summary>
        /// License expiry date
        /// </summary>
        public DateTime? LicExpiryDate { get; set; }
        /// <summary>
        /// License grace period
        /// </summary>
        public int? LicGracePeriod { get; set; }
        /// <summary>
        /// Last license verified
        /// </summary>
        public int? LicVerifiedLicensedt { get; set; }
        public int? EmailLinkExpiry { get; set; }
        /// <summary>
        /// For existing user to change password after reset. 1-Required password change on next login (after reset) / 0- using password set on field PW_DEFAULT_TYPE
        /// </summary>
        public int? PwChangeForceReset { get; set; }
        /// <summary>
        /// Allow Strong Password Policy 1 - true / 0 - false
        /// </summary>
        public int? PwStrongAllow { get; set; }
        /// <summary>
        /// Company Name
        /// </summary>
        public string LicCompName { get; set; }
        /// <summary>
        /// Date of this record created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created this record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this record updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated this record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        /// <summary>
        /// Single SignOn\n0-NoSSO\n1-AD\n2-MultiAD
        /// </summary>
        public int? LoginSso { get; set; }
    }
}
