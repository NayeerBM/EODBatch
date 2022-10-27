using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Wcfwlinputtext
    {
        public short CompCode { get; set; }
        public int ScanNo { get; set; }
        public int SrcSeqNo { get; set; }
        public string YourRef { get; set; }
        public string SearchId { get; set; }
        public string SearchName { get; set; }
        public string SerachCountry { get; set; }
        public string SearchDob { get; set; }
        public string SerachAddress { get; set; }
        public string HitResultText { get; set; }
        public string HitResult { get; set; }
        public int SendDate { get; set; }
        public int SendTime { get; set; }
        public string UserId { get; set; }
        public string BrCode { get; set; }
        public string SysName { get; set; }
        public short ScanFullPartail { get; set; }
        public short ScanType { get; set; }
        public string SearchGender { get; set; }
        public string SearchEntityType { get; set; }
        public string SearchCategory { get; set; }
        public string SearchSubcategory { get; set; }
        public string SearchSanction { get; set; }
    }
}
