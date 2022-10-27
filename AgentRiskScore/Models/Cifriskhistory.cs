using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Cifriskhistory
    {
        /// <summary>
        /// Code Company
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Code Organization
        /// </summary>
        public int CodeOrg { get; set; }
        public int SeqNo { get; set; }
        /// <summary>
        /// Master no of client
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// CIF Number
        /// </summary>
        public string NoCif { get; set; }
        public int RsDate { get; set; }
        public int RiskLevel { get; set; }
        public string RiskDesc { get; set; }
        public int ModifiedRiskLevel { get; set; }
        public string ModifiedRiskDesc { get; set; }
        public int LastRiskLevelValue { get; set; }
        public string LastRiskLevel { get; set; }
        public int FinalScore { get; set; }
        public int Rsfdscore { get; set; }
        public int Rsfdscore1 { get; set; }
        public int Rsfdscore2 { get; set; }
        public int Rsfdscore3 { get; set; }
        public int Rsfdscore4 { get; set; }
        public int Rsfdscore5 { get; set; }
        public int Rsfdscore6 { get; set; }
        public int Rsfdscore7 { get; set; }
        public int Rsfdscore8 { get; set; }
        public int Rsfdscore9 { get; set; }
        public int Rsfdscore10 { get; set; }
        public int Rsfdscore11 { get; set; }
        public int Rsfdscore12 { get; set; }
        public int Rsfdscore13 { get; set; }
        public int Rsfdscore14 { get; set; }
        public int Rsfdscore15 { get; set; }
        public int Rsfdscore16 { get; set; }
        public int Rsfdscore17 { get; set; }
        public int Rsfdscore18 { get; set; }
        public int Rsfdscore19 { get; set; }
        public int Rsfdscore20 { get; set; }
        public string Rsfdvalue1 { get; set; }
        public string Rsfdvalue2 { get; set; }
        public string Rsfdvalue3 { get; set; }
        public string Rsfdvalue4 { get; set; }
        public string Rsfdvalue5 { get; set; }
        public string Rsfdvalue6 { get; set; }
        public string Rsfdvalue7 { get; set; }
        public string Rsfdvalue8 { get; set; }
        public string Rsfdvalue9 { get; set; }
        public string Rsfdvalue10 { get; set; }
        public string Rsfdvalue11 { get; set; }
        public string Rsfdvalue12 { get; set; }
        public string Rsfdvalue13 { get; set; }
        public string Rsfdvalue14 { get; set; }
        public string Rsfdvalue15 { get; set; }
        public string Rsfdvalue16 { get; set; }
        public string Rsfdvalue17 { get; set; }
        public string Rsfdvalue18 { get; set; }
        public string Rsfdvalue19 { get; set; }
        public string Rsfdvalue20 { get; set; }
        public string BatchNo { get; set; }
        public short? RiskModel { get; set; }
        public string Remarks { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
    }
}
