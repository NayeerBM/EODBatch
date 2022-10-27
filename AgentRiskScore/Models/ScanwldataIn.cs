using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class ScanwldataIn
    {
        public long JobId { get; set; }
        public long SysId { get; set; }
        public string AddDelMode { get; set; }
        public string ScanUptInd { get; set; }
        public string WatchlistType { get; set; }
        public string EntityUid { get; set; }
        public string FullName { get; set; }
        public string AlsoKnownAs { get; set; }
        public string NativeName { get; set; }
        public string IdType1 { get; set; }
        public string IdValue1 { get; set; }
        public string IdType2 { get; set; }
        public string IdValue2 { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string NameSource { get; set; }
        public string AliasesName1 { get; set; }
        public string AliasesName2 { get; set; }
        public string AliasesName3 { get; set; }
        public string AliasesName4 { get; set; }
        public string AliasesName5 { get; set; }
        public string AliasesName6 { get; set; }
        public string InUserId { get; set; }
        public string MacTag { get; set; }
        public short? AddDelInd { get; set; }
        public string AddDelUid { get; set; }
        public short? BatchScanInd1 { get; set; }
        public short? BatchScanInd2 { get; set; }
        public short? BatchScanInd3 { get; set; }
        public short? BatchScanInd4 { get; set; }
        public string EntryType { get; set; }
        public string Gender { get; set; }
        public string Remarks { get; set; }
        public string IdType3 { get; set; }
        public string IdValue3 { get; set; }
        public string IdType4 { get; set; }
        public string IdValue4 { get; set; }
        public string NameSource2 { get; set; }
        public string NameSource3 { get; set; }
    }
}
