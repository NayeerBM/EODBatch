using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ParamCtrDtl
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// STR template ID
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// The latest sequence generated due to changes of data
        /// </summary>
        public int CtrHist { get; set; }
        /// <summary>
        /// 0-Disable question (skip all field checking)\n1-Enable question
        /// </summary>
        public int CtrStatus { get; set; }
        /// <summary>
        /// Category if the questionnaire\n1-Client Info\n2-Account Info\n3-Transaction Info\n4-Finding info
        /// </summary>
        public int QuestCategory { get; set; }
        /// <summary>
        /// Question No
        /// </summary>
        public int QuestNo { get; set; }
        /// <summary>
        /// Field in REPORT_STR to be displayed
        /// </summary>
        public string QuestField { get; set; }
        /// <summary>
        /// Question to be displayed on left hand side
        /// </summary>
        public string QuestText { get; set; }
        /// <summary>
        /// Additional remark to be displayed above the answer field, this usually represent the sample answer for user to understand the actual question
        /// </summary>
        public string QuestRemarks { get; set; }
        /// <summary>
        /// Question indicator whether it is for Individual (1) or Organization/LegalEntity/Corporate (2) or both/common (0)
        /// </summary>
        public int QuestTypeInd { get; set; }
        /// <summary>
        /// Field Name from dropdownlist
        /// </summary>
        public string AnsField { get; set; }
        /// <summary>
        /// 0-Display Quest Text as header\n1-Open Text (Text Box)\n2-Dropdown\n3-Radio Button\n4-1 day Calendar\n5-Text Area (expandable)\n
        /// </summary>
        public int AnsType { get; set; }
        /// <summary>
        /// Code_Sub to link to CONFIG_CODES_DTL
        /// </summary>
        public int? AnsCode { get; set; }
        public int? DisableInput { get; set; }
        /// <summary>
        /// Default answer to be fill if no input
        /// </summary>
        public string AnsDefault { get; set; }
        /// <summary>
        /// To reject the submission if this field is empty\nTo enable the compulsory tag (*) on the question
        /// </summary>
        public int AnsCompulsory { get; set; }
        /// <summary>
        /// 0 - Display QUEST_TEXT\n1 - Display QUEST_TEXT
        /// </summary>
        public int DispText { get; set; }
        /// <summary>
        /// 0 - Display QUEST_REMARKS\n1 - Display QUEST_REMARKS
        /// </summary>
        public int DispRemarks { get; set; }
        /// <summary>
        /// 0 - Display answer field\n1 - Display answer field\n2 - Display aswer field with disable state (uneditable)
        /// </summary>
        public int DispAns { get; set; }
        /// <summary>
        /// To change the theme text as an header\n0-default (normal)\n1-header
        /// </summary>
        public int DispHdr { get; set; }
        public int? IndivUpt { get; set; }
        public int? LegalUpt { get; set; }
        public int? GovUpt { get; set; }
        public int? NgoUpt { get; set; }
        /// <summary>
        /// Output indicator 0 (BOTH) 1 (EXCEL) 2 (XML)
        /// </summary>
        public int OutputInd { get; set; }
        public string XmlLevel1 { get; set; }
        public string XmlLevel2 { get; set; }
        public string XmlLevel3 { get; set; }
        public string XmlLevel4 { get; set; }
        public string XmlLevel5 { get; set; }
        public string XmlLevel6 { get; set; }
        public short XmlSectionNo { get; set; }
        public short XmlSeqNo { get; set; }
        public short XmlSubSeq { get; set; }
        public short XmlAction1 { get; set; }
        public short XmlAction2 { get; set; }
        public short XmlAction3 { get; set; }
        /// <summary>
        /// Date created
        /// </summary>
        public DateTime AuditCreatedDate { get; set; }
        /// <summary>
        /// User creating this record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date record updated
        /// </summary>
        public DateTime AuditUpdatedDate { get; set; }
        /// <summary>
        /// User updating this record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
