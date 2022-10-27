using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Storing global parameter to be access from the whole solution
    /// </summary>
    public partial class ConfigWeb
    {
        /// <summary>
        /// Storing company code
        /// </summary>
        public int? CodeComp { get; set; }
        /// <summary>
        /// storing organization code
        /// </summary>
        public int? CodeOrg { get; set; }
        /// <summary>
        /// To indicate the Single Sign On (SSO) Setup \n0 - No SSO provider\n1 - Single domain active directory\n2 - Multiple domain active directory
        /// </summary>
        public int? AdType { get; set; }
        /// <summary>
        /// To locate the path of uploaded file to be store\nD:\AML_UPLOAD\IsemAttachFiles\Temp_Files\
        /// </summary>
        public string PathFiletemp { get; set; }
        /// <summary>
        /// To locate the path of uploaded file to be store\nD:\AML_UPLOAD\IsemAttachFiles\Actual_Files\
        /// </summary>
        public string PathFileact { get; set; }
        /// <summary>
        /// To locate the path of batch file\nD:\AML_INTEGRATOR\AML_JOBSPOOL
        /// </summary>
        public string PathFilebatch { get; set; }
        /// <summary>
        /// To locate the path of output data from the system\nD:\AML_UPLOAD
        /// </summary>
        public string PathFileoutput { get; set; }
        /// <summary>
        /// To locate the path of western union file to be store\nD:\AML_INTEGRATOR\AML_DATA\WW
        /// </summary>
        public string PathWu { get; set; }
        /// <summary>
        /// To locate the path of uploaded file to be store\nD:\AML_UPLOAD\
        /// </summary>
        public string PathFilestr { get; set; }
        /// <summary>
        /// To set the DNS connection when AD is being used\nhttp://SERVERNEWNBLOCK.com
        /// </summary>
        public string PathDns { get; set; }
        /// <summary>
        /// To indicate the maximum file size allowed to be upload
        /// </summary>
        public int? SizeUpfile { get; set; }
        /// <summary>
        /// To indicate the maximum file size allowed on the batch file
        /// </summary>
        public int? SizeBatchfile { get; set; }
        /// <summary>
        /// To navigate user to watchlist search page when system is not read\n0 - Disable\n1 - Enable
        /// </summary>
        public int? FlagOffline { get; set; }
        /// <summary>
        /// To insert scan log into system\n0 - Disable\n1 - Enable
        /// </summary>
        public int? FlagWatchlistLog { get; set; }
        /// <summary>
        /// To indicate which watchlist provider is being used by system\nSTD - Standard\nDJ - Dowjones\nWC - WorldCheck\nLN - Lexis Nexis\nACT - Accuity
        /// </summary>
        public string FlagWlType { get; set; }
        /// <summary>
        /// To set default theme by system\n0 - Basic\n1 - Dark Mode
        /// </summary>
        public int? FlagTheme { get; set; }
        /// <summary>
        /// To set default page language by the system\n0 - English\n1 - Configurable
        /// </summary>
        public int? FlagLanguage { get; set; }
        /// <summary>
        /// To set the default format of datetime in the system\n0 - DD-MMM-YYYY\n1 - DD-MM-YYYY
        /// </summary>
        public int? DateFormat { get; set; }
        /// <summary>
        /// To set the default format of time in the system\n0 - 24 hours\n1 - 12 hours
        /// </summary>
        public int? TimeFormat { get; set; }
        /// <summary>
        /// To setup the email exchange connection\n0 - Turn off email exchange server\n1 - Turn on email exchange server\n2 - Turn on demo email exchange server
        /// </summary>
        public int? EmailExchange { get; set; }
        /// <summary>
        /// To configure the email hosting url\nwpplus04.mschosting.com
        /// </summary>
        public string EmailHost { get; set; }
        /// <summary>
        /// To declare the userid used to access email hosting\nsmtpuser@tessinternational.com
        /// </summary>
        public string EmailUserid { get; set; }
        /// <summary>
        /// To declare the password used by the system\n****
        /// </summary>
        public string EmailPassword { get; set; }
        /// <summary>
        /// To declare the port used to access the email hosting\n587
        /// </summary>
        public int? EmailPort { get; set; }
        /// <summary>
        /// To declare the type of security encryption to be uesd for emails\n0 - Standard SSL/TLS Connection\n1 - STARTTLSL
        /// </summary>
        public int? EmailSecurity { get; set; }
        public int? FlagAnalysis { get; set; }
        public int? SessionLockDur { get; set; }
        public int? SessionExpireDur { get; set; }
    }
}
