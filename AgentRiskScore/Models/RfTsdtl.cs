using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfTsdtl
    {
        /// <summary>
        /// company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// red flag ID
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// link to the actual transaction in TXN table
        /// </summary>
        public long TranId { get; set; }
        public long TranSeq { get; set; }
        public string ModuleId { get; set; }
        public string TypeProduct { get; set; }
        /// <summary>
        /// credit / debit / both
        /// </summary>
        public short? TranType { get; set; }
        /// <summary>
        /// date of transaction made
        /// </summary>
        public int? TranDate { get; set; }
        /// <summary>
        /// posting date of transaction performed
        /// </summary>
        public int? TranPostDate { get; set; }
        /// <summary>
        /// value date of transaction performed
        /// </summary>
        public int? TranValDate { get; set; }
        /// <summary>
        /// transaction code of transaction performed
        /// </summary>
        public string TranCode { get; set; }
        /// <summary>
        /// customer&apos;s account number
        /// </summary>
        public string NoAcc { get; set; }
        /// <summary>
        /// customer&apos;s identification number
        /// </summary>
        public string NoCif { get; set; }
        public string InfoBranch { get; set; }
        /// <summary>
        /// total amount of transaction performed
        /// </summary>
        public double? TranAmount { get; set; }
        /// <summary>
        /// currency of transaction performed
        /// </summary>
        public string TranCur { get; set; }
        /// <summary>
        /// total amount of transaction of foreign currency
        /// </summary>
        public double? TranCurAmount { get; set; }
        /// <summary>
        /// conversion rate of currency
        /// </summary>
        public double? TranRate { get; set; }
        public short? TranRev { get; set; }
        /// <summary>
        /// location of transaction take place
        /// </summary>
        public string TranLocation { get; set; }
        /// <summary>
        /// reserve char field 01
        /// </summary>
        public string ResChar01 { get; set; }
        /// <summary>
        /// reserve char field 02
        /// </summary>
        public string ResChar02 { get; set; }
        /// <summary>
        /// reserve char field 03
        /// </summary>
        public string ResChar03 { get; set; }
        /// <summary>
        /// reserve char field 04
        /// </summary>
        public string ResChar04 { get; set; }
        /// <summary>
        /// reserve char field 05
        /// </summary>
        public string ResChar05 { get; set; }
        /// <summary>
        /// reserve char field 06
        /// </summary>
        public string ResChar06 { get; set; }
        /// <summary>
        /// reserve char field 07
        /// </summary>
        public string ResChar07 { get; set; }
        /// <summary>
        /// reserve char field 08
        /// </summary>
        public string ResChar08 { get; set; }
        /// <summary>
        /// reserve char field 09
        /// </summary>
        public string ResChar09 { get; set; }
        /// <summary>
        /// reserve char field 10
        /// </summary>
        public string ResChar10 { get; set; }
        /// <summary>
        /// reserve float field 01
        /// </summary>
        public double? ResFlt01 { get; set; }
        /// <summary>
        /// reserve float field 02
        /// </summary>
        public double? ResFlt02 { get; set; }
        /// <summary>
        /// reserve float field 03
        /// </summary>
        public double? ResFlt03 { get; set; }
        /// <summary>
        /// reserve float field 04
        /// </summary>
        public double? ResFlt04 { get; set; }
        /// <summary>
        /// reserve float field 05
        /// </summary>
        public double? ResFlt05 { get; set; }
        /// <summary>
        /// reserve int field 01
        /// </summary>
        public int? ResInt01 { get; set; }
        /// <summary>
        /// reserve int field 02
        /// </summary>
        public int? ResInt02 { get; set; }
        /// <summary>
        /// reserve int field 03
        /// </summary>
        public int? ResInt03 { get; set; }
        /// <summary>
        /// reserve int field 04
        /// </summary>
        public int? ResInt04 { get; set; }
        /// <summary>
        /// reserve int field 05
        /// </summary>
        public int? ResInt05 { get; set; }
        /// <summary>
        /// to differentiate between daily/historical
        /// </summary>
        public string TypeData { get; set; }
        public string TypeEnt { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
