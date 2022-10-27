using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class AwHitlogger
    {
        public short CompCode { get; set; }
        public int SeqNo { get; set; }
        public int SubSeqNo { get; set; }
        public int HitDate { get; set; }
        public int HitTime { get; set; }
        public string BrCode { get; set; }
        public string UserId { get; set; }
        public string ScanFullPartil { get; set; }
        public string ScanEntityName { get; set; }
        public string ScanFirstName { get; set; }
        public string ScanLastName { get; set; }
        public string ScanIdValue { get; set; }
        public string ScanDobs { get; set; }
        public string ScanCountryName { get; set; }
        public string ScanCategory { get; set; }
        public string ScanSanctionCountry { get; set; }
        public string ReturnEntityId { get; set; }
        public int ReturnSysIdAuto { get; set; }
        public string ReturnHighRiskCountry { get; set; }
        public string ReturnEntityName { get; set; }
        public string ReturnIdValue { get; set; }
        public string ReturnDobs { get; set; }
        public string ReturnCategory { get; set; }
        public string ReturnSubCategory { get; set; }
        public string ReturnInfoSource { get; set; }
        public short ReturnMatchPercent { get; set; }
        public short ReturnOk { get; set; }
        public int KivOk { get; set; }
        public string ReturnDob { get; set; }
        public string ScanPurpose { get; set; }
        public string ScanGender { get; set; }
        public string ReturnGender { get; set; }
        public string ScanEntityType { get; set; }
        public string ReturnEntityType { get; set; }
        public string ReturnMatch { get; set; }
        public string ScanCategorynum { get; set; }
        public string ReturnCategorynum { get; set; }
        public string ScanSanction { get; set; }
        public string ReturnSanction { get; set; }
        public string ScanNativeName { get; set; }
        public int? ModuleId { get; set; }
        public string ScanSecurityNo { get; set; }
        public string ReturnSecurityNo { get; set; }
        public int? ScanExpiryDate { get; set; }
        public int? ReturnExpiryDate { get; set; }
    }
}
