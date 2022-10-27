using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// To setup the workflow configuration on Transaction Module (to confirm can merged with other modules)
    /// </summary>
    public partial class ConfigWfDtl
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
        /// Module ID
        /// </summary>
        public int WfModule { get; set; }
        /// <summary>
        /// ID of workflow template
        /// </summary>
        public int WfId { get; set; }
        /// <summary>
        /// Workflow level under template
        /// </summary>
        public int WfLevel { get; set; }
        /// <summary>
        /// To declare the source type of data\n0 - system generated\n1 - manually raised
        /// </summary>
        public int WfSource { get; set; }
        /// <summary>
        /// Description of the configured workflow
        /// </summary>
        public string WfDescription { get; set; }
        /// <summary>
        /// To indicate the filtering is being used on following template (0D1E)
        /// </summary>
        public int? WfFilterStatus { get; set; }
        /// <summary>
        /// To indicate the status of template (0D1E)
        /// </summary>
        public int WfStatus { get; set; }
        /// <summary>
        /// Allowing  bypass on following level (0D1E)
        /// </summary>
        public int? WfBypass { get; set; }
        /// <summary>
        /// To configure access on picking alert below accessible level
        /// </summary>
        public int? WfSkipLevel { get; set; }
        /// <summary>
        /// Enable draft report (0D1E)
        /// </summary>
        public int? WfRptDraft { get; set; }
        /// <summary>
        /// Enable mandatory to draft report (0D1E)
        /// </summary>
        public int? WfRptMandatory { get; set; }
        /// <summary>
        /// Display name for button 1
        /// </summary>
        public string Btn1Name { get; set; }
        /// <summary>
        /// Enable button (0D1E)
        /// </summary>
        public int? Btn1Status { get; set; }
        /// <summary>
        /// Allow monitoring for selected case (0D1E)
        /// </summary>
        public int? Btn1AllowMonitoring { get; set; }
        /// <summary>
        /// Allow Skip Level (0D1E)
        /// </summary>
        public int? Btn1AllowSkip { get; set; }
        /// <summary>
        /// Allow case to be reviewed (0D1E)
        /// </summary>
        public int? Btn1AllowReview { get; set; }
        /// <summary>
        /// Assigned the review status into selected status
        /// </summary>
        public int? Btn1ReviewStatus { get; set; }
        /// <summary>
        /// Allow selected case to be reopen (0D1E)
        /// </summary>
        public int? Btn1AllowReopen { get; set; }
        /// <summary>
        /// Assigned the reopen status into selected status
        /// </summary>
        public int? Btn1ReopenStatus { get; set; }
        /// <summary>
        /// Assigned the reopen status into selected template
        /// </summary>
        public int? Btn1ReopenTemplate { get; set; }
        /// <summary>
        /// Allow selected case to assign STR Flag (0D1E)
        /// </summary>
        public int? Btn1AllowStr { get; set; }
        /// <summary>
        /// Assign report status to selected status
        /// </summary>
        public int? Btn1StrReport { get; set; }
        /// <summary>
        /// STR Selected field 1
        /// </summary>
        public int? Btn1StrField1 { get; set; }
        /// <summary>
        /// STR Selected field 2
        /// </summary>
        public int? Btn1StrField2 { get; set; }
        /// <summary>
        /// Allow selected case to view PEP Flag (0D1E)
        /// </summary>
        public int? Btn1AllowPep { get; set; }
        /// <summary>
        /// PEP selected field 1
        /// </summary>
        public int? Btn1PepField1 { get; set; }
        /// <summary>
        /// PEP selected field 2
        /// </summary>
        public int? Btn1PepField2 { get; set; }
        /// <summary>
        /// Assign email template to follow (0-Disable/1-Group/2-Individual)
        /// </summary>
        public int? Btn1EmailType { get; set; }
        /// <summary>
        /// Assign grouping template to selected group
        /// </summary>
        public int? Btn1EmailTemplate { get; set; }
        /// <summary>
        /// Allow AMLC case to go to approval
        /// </summary>
        public int? Btn1AllowAmlc { get; set; }
        /// <summary>
        /// Assigned status AMLC to selected status
        /// </summary>
        public int? Btn1AmlcStatus { get; set; }
        /// <summary>
        /// No of AMLC Approval assigned
        /// </summary>
        public int? Btn1AmlcAppoval { get; set; }
        public string Btn2Name { get; set; }
        public int? Btn2Status { get; set; }
        public int? Btn2AllowMonitoring { get; set; }
        public int? Btn2AllowSkip { get; set; }
        public int? Btn2AllowReview { get; set; }
        public int? Btn2ReviewStatus { get; set; }
        public int? Btn2AllowReopen { get; set; }
        public int? Btn2ReopenStatus { get; set; }
        public int? Btn2ReopenTemplate { get; set; }
        public int? Btn2AllowStr { get; set; }
        public int? Btn2StrReport { get; set; }
        public int? Btn2StrField1 { get; set; }
        public int? Btn2StrField2 { get; set; }
        public int? Btn2AllowPep { get; set; }
        public int? Btn2PepField1 { get; set; }
        public int? Btn2PepField2 { get; set; }
        public int? Btn2EmailType { get; set; }
        public int? Btn2EmailTemplate { get; set; }
        public int? Btn2AllowAmlc { get; set; }
        public int? Btn2AmlcStatus { get; set; }
        public int? Btn2AmlcAppoval { get; set; }
        public string Btn3Name { get; set; }
        public int? Btn3Status { get; set; }
        public int? Btn3AllowMonitoring { get; set; }
        public int? Btn3AllowSkip { get; set; }
        public int? Btn3AllowReview { get; set; }
        public int? Btn3ReviewStatus { get; set; }
        public int? Btn3AllowReopen { get; set; }
        public int? Btn3ReopenStatus { get; set; }
        public int? Btn3ReopenTemplate { get; set; }
        public int? Btn3AllowStr { get; set; }
        public int? Btn3StrReport { get; set; }
        public int? Btn3StrField1 { get; set; }
        public int? Btn3StrField2 { get; set; }
        public int? Btn3AllowPep { get; set; }
        public int? Btn3PepField1 { get; set; }
        public int? Btn3PepField2 { get; set; }
        public int? Btn3EmailType { get; set; }
        public int? Btn3EmailTemplate { get; set; }
        public int? Btn3AllowAmlc { get; set; }
        public int? Btn3AmlcStatus { get; set; }
        public int? Btn3AmlcAppoval { get; set; }
        public string Btn4Name { get; set; }
        public int? Btn4Status { get; set; }
        public int? Btn4AllowMonitoring { get; set; }
        public int? Btn4AllowSkip { get; set; }
        public int? Btn4AllowReview { get; set; }
        public int? Btn4ReviewStatus { get; set; }
        public int? Btn4AllowReopen { get; set; }
        public int? Btn4ReopenStatus { get; set; }
        public int? Btn4ReopenTemplate { get; set; }
        public int? Btn4AllowStr { get; set; }
        public int? Btn4StrReport { get; set; }
        public int? Btn4StrField1 { get; set; }
        public int? Btn4StrField2 { get; set; }
        public int? Btn4AllowPep { get; set; }
        public int? Btn4PepField1 { get; set; }
        public int? Btn4PepField2 { get; set; }
        public int? Btn4EmailType { get; set; }
        public int? Btn4EmailTemplate { get; set; }
        public int? Btn4AllowAmlc { get; set; }
        public int? Btn4AmlcStatus { get; set; }
        public int? Btn4AmlcAppoval { get; set; }
        public string Btn5Name { get; set; }
        public int? Btn5Status { get; set; }
        public int? Btn5AllowMonitoring { get; set; }
        public int? Btn5AllowSkip { get; set; }
        public int? Btn5AllowReview { get; set; }
        public int? Btn5ReviewStatus { get; set; }
        public int? Btn5AllowReopen { get; set; }
        public int? Btn5ReopenStatus { get; set; }
        public int? Btn5ReopenTemplate { get; set; }
        public int? Btn5AllowStr { get; set; }
        public int? Btn5StrReport { get; set; }
        public int? Btn5StrField1 { get; set; }
        public int? Btn5StrField2 { get; set; }
        public int? Btn5AllowPep { get; set; }
        public int? Btn5PepField1 { get; set; }
        public int? Btn5PepField2 { get; set; }
        public int? Btn5EmailType { get; set; }
        public int? Btn5EmailTemplate { get; set; }
        public int? Btn5AllowAmlc { get; set; }
        public int? Btn5AmlcStatus { get; set; }
        public int? Btn5AmlcAppoval { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public int Btn1Level { get; set; }
        public int Btn2Level { get; set; }
        public int Btn3Level { get; set; }
        public int Btn4Level { get; set; }
        public int Btn5Level { get; set; }
        public int Btn1Casestatus { get; set; }
        public int Btn2Casestatus { get; set; }
        public int Btn3Casestatus { get; set; }
        public int Btn4Casestatus { get; set; }
        public int Btn5Casestatus { get; set; }
        public int Btn1Substatus { get; set; }
        public int Btn2Substatus { get; set; }
        public int Btn3Substatus { get; set; }
        public int Btn4Substatus { get; set; }
        public int Btn5Substatus { get; set; }
        public int? Btn1EmailApprove { get; set; }
        public int? Btn1EmailApproveStatus { get; set; }
        public int? Btn2EmailApprove { get; set; }
        public int? Btn2EmailApproveStatus { get; set; }
        public int? Btn3EmailApprove { get; set; }
        public int? Btn3EmailApproveStatus { get; set; }
        public int? Btn4EmailApprove { get; set; }
        public int? Btn4EmailApproveStatus { get; set; }
        public int? Btn5EmailApprove { get; set; }
        public int? Btn5EmailApproveStatus { get; set; }
        /// <summary>
        /// allow to reasign case
        /// </summary>
        public int? WfReassign { get; set; }
        /// <summary>
        /// allow to rework case
        /// </summary>
        public int? WfRework { get; set; }
        /// <summary>
        /// Allow to pickup case at any level
        /// </summary>
        public int? WfPickup { get; set; }
        public int? WfManageOdd { get; set; }
        public int? WfChangeRiskLvl { get; set; }
        public int? WfManageExposure { get; set; }
        public int? WfManageRedFlag { get; set; }
        public int? WfManageClientMonitoring { get; set; }
        /// <summary>
        /// API Source Name
        /// </summary>
        public string Btn1OmApi { get; set; }
        /// <summary>
        /// Onboard approval API status
        /// </summary>
        public int? Btn1OmApiStatus { get; set; }
        /// <summary>
        /// Single (0) Multiple (1)
        /// </summary>
        public int? Btn1EndpointType { get; set; }
        /// <summary>
        /// API Source Name
        /// </summary>
        public string Btn2OmApi { get; set; }
        /// <summary>
        /// Onboard approval API status
        /// </summary>
        public int? Btn2OmApiStatus { get; set; }
        /// <summary>
        /// Single (0) Multiple (1)
        /// </summary>
        public int? Btn2EndpointType { get; set; }
        /// <summary>
        /// API Source Name
        /// </summary>
        public string Btn3OmApi { get; set; }
        /// <summary>
        /// Onboard approval API status
        /// </summary>
        public int? Btn3OmApiStatus { get; set; }
        /// <summary>
        /// Single (0) Multiple (1)
        /// </summary>
        public int? Btn3EndpointType { get; set; }
        /// <summary>
        /// API Source Name
        /// </summary>
        public string Btn4OmApi { get; set; }
        /// <summary>
        /// Onboard approval API status
        /// </summary>
        public int? Btn4OmApiStatus { get; set; }
        /// <summary>
        /// Single (0) Multiple (1)
        /// </summary>
        public int? Btn4EndpointType { get; set; }
        /// <summary>
        /// API Source Name
        /// </summary>
        public string Btn5OmApi { get; set; }
        /// <summary>
        /// Onboard approval API status
        /// </summary>
        public int? Btn5OmApiStatus { get; set; }
        /// <summary>
        /// Single (0) Multiple (1)
        /// </summary>
        public int? Btn5EndpointType { get; set; }
    }
}
