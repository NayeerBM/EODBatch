using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Configmisctabledatalist
    {
        public short CompCode { get; set; }
        public string TemplateCode { get; set; }
        public short QuestItemNo { get; set; }
        public short? DisplayOrder { get; set; }
        public string FieldId { get; set; }
        public short FieldMaxLen { get; set; }
        public string ShortFdDesc { get; set; }
        public string QuestText { get; set; }
        public short DispQuesttextInd { get; set; }
        public short DispScoringInd { get; set; }
        public short AnsType { get; set; }
        public int DdlTableno { get; set; }
        public int MinScoringReq { get; set; }
        public int MaxScoringReq { get; set; }
        public int ScoringText { get; set; }
        public int ScoringYes { get; set; }
        public int ScoringNo { get; set; }
        public string OptionA { get; set; }
        public int ScoringA { get; set; }
        public string OptionB { get; set; }
        public int ScoringB { get; set; }
        public string OptionC { get; set; }
        public int ScoringC { get; set; }
        public string OptionD { get; set; }
        public int ScoringD { get; set; }
        public string OptionE { get; set; }
        public int ScoringE { get; set; }
        public short ImportFieldseq { get; set; }
        public short OperatorValue { get; set; }
        public short EditableInd { get; set; }
        public short EditableInd1 { get; set; }
        public short EditableInd2 { get; set; }
        public short EditableInd3 { get; set; }
        public short EditableInd4 { get; set; }
        public string DefaultValue { get; set; }
        public short CompulsaryInd { get; set; }
        public short MultiplelineHeight { get; set; }
        public short Status { get; set; }
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
        public DateTime? StampDttm { get; set; }
        public string UserId { get; set; }
        public string ModeMn { get; set; }
    }
}
