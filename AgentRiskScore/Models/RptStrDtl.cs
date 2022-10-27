using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RptStrDtl
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
        /// History sequence for selected NO_CIF
        /// </summary>
        public int StrSeq { get; set; }
        /// <summary>
        /// Template STR used from PARAM_STR
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// History question being used during submission STR
        /// </summary>
        public int StrHistQuest { get; set; }
        /// <summary>
        /// Sequence to tag STR between DTL and HDR
        /// </summary>
        public int StrHdrSeq { get; set; }
        public int? StrCategory { get; set; }
        /// <summary>
        /// No CIF
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// No Master
        /// </summary>
        public string NoMaster { get; set; }
        public string Tfield001 { get; set; }
        public string Tfield002 { get; set; }
        public string Tfield003 { get; set; }
        public string Tfield004 { get; set; }
        public string Tfield005 { get; set; }
        public string Tfield006 { get; set; }
        public string Tfield007 { get; set; }
        public string Tfield008 { get; set; }
        public string Tfield009 { get; set; }
        public string Tfield010 { get; set; }
        public string Tfield011 { get; set; }
        public string Tfield012 { get; set; }
        public string Tfield013 { get; set; }
        public string Tfield014 { get; set; }
        public string Tfield015 { get; set; }
        public string Tfield016 { get; set; }
        public string Tfield017 { get; set; }
        public string Tfield018 { get; set; }
        public string Tfield019 { get; set; }
        public string Tfield020 { get; set; }
        public string Tfield021 { get; set; }
        public string Tfield022 { get; set; }
        public string Tfield023 { get; set; }
        public string Tfield024 { get; set; }
        public string Tfield025 { get; set; }
        public string Tfield026 { get; set; }
        public string Tfield027 { get; set; }
        public string Tfield028 { get; set; }
        public string Tfield029 { get; set; }
        public string Tfield030 { get; set; }
        public string Tfield031 { get; set; }
        public string Tfield032 { get; set; }
        public string Tfield033 { get; set; }
        public string Tfield034 { get; set; }
        public string Tfield035 { get; set; }
        public string Tfield036 { get; set; }
        public string Tfield037 { get; set; }
        public string Tfield038 { get; set; }
        public string Tfield039 { get; set; }
        public string Tfield040 { get; set; }
        public string Tfield041 { get; set; }
        public string Tfield042 { get; set; }
        public string Tfield043 { get; set; }
        public string Tfield044 { get; set; }
        public string Tfield045 { get; set; }
        public string Tfield046 { get; set; }
        public string Tfield047 { get; set; }
        public string Tfield048 { get; set; }
        public string Tfield049 { get; set; }
        public string Tfield050 { get; set; }
        public string Tfield051 { get; set; }
        public string Tfield052 { get; set; }
        public string Tfield053 { get; set; }
        public string Tfield054 { get; set; }
        public string Tfield055 { get; set; }
        public string Tfield056 { get; set; }
        public string Tfield057 { get; set; }
        public string Tfield058 { get; set; }
        public string Tfield059 { get; set; }
        public string Tfield060 { get; set; }
        public string Tfield061 { get; set; }
        public string Tfield062 { get; set; }
        public string Tfield063 { get; set; }
        public string Tfield064 { get; set; }
        public string Tfield065 { get; set; }
        public string Tfield066 { get; set; }
        public string Tfield067 { get; set; }
        public string Tfield068 { get; set; }
        public string Tfield069 { get; set; }
        public string Tfield070 { get; set; }
        public string Tfield071 { get; set; }
        public string Tfield072 { get; set; }
        public string Tfield073 { get; set; }
        public string Tfield074 { get; set; }
        public string Tfield075 { get; set; }
        public string Tfield076 { get; set; }
        public string Tfield077 { get; set; }
        public string Tfield078 { get; set; }
        public string Tfield079 { get; set; }
        public string Tfield080 { get; set; }
        public string Tfield081 { get; set; }
        public string Tfield082 { get; set; }
        public string Tfield083 { get; set; }
        public string Tfield084 { get; set; }
        public string Tfield085 { get; set; }
        public string Tfield086 { get; set; }
        public string Tfield087 { get; set; }
        public string Tfield088 { get; set; }
        public string Tfield089 { get; set; }
        public string Tfield090 { get; set; }
        public string Tfield091 { get; set; }
        public string Tfield092 { get; set; }
        public string Tfield093 { get; set; }
        public string Tfield094 { get; set; }
        public string Tfield095 { get; set; }
        public string Tfield096 { get; set; }
        public string Tfield097 { get; set; }
        public string Tfield098 { get; set; }
        public string Tfield099 { get; set; }
        public string Tfield100 { get; set; }
        public int? AuditUserLevel { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
