using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Wcfwslog
    {
        public int LogSeq { get; set; }
        public string Authuser { get; set; }
        public string Authpswd { get; set; }
        public string Username { get; set; }
        public string Brcode { get; set; }
        public string SysName { get; set; }
        public string Scanoption { get; set; }
        public string Uniqueno { get; set; }
        public string Searchname { get; set; }
        public string Searchcountry { get; set; }
        public string Searchdob { get; set; }
        public string Searchid { get; set; }
        public string Passportverify { get; set; }
        /// <summary>
        /// Passport Number
        /// </summary>
        public string Passportno { get; set; }
        public string Securityno1 { get; set; }
        public string Passexpirydtverify { get; set; }
        public string Passexpirydate { get; set; }
        public string Securityno2 { get; set; }
        public string Riskfactors { get; set; }
        public string Content { get; set; }
        public string Rtnhit { get; set; }
        public string Rtnscanid { get; set; }
        public string Rtnencryptscanid { get; set; }
        public DateTime? LogStart { get; set; }
        public DateTime? LogEnd { get; set; }
        public string Searchgender { get; set; }
    }
}
