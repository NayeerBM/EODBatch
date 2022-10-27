using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Bankfintran
    {
        public long TranId { get; set; }
        public short CodeComp { get; set; }
        public string RecType { get; set; }
        public string UnloadInd { get; set; }
        public string RecIdentityNo { get; set; }
        public string InwardOutwardCode { get; set; }
        public short CreditDebit { get; set; }
        public int TranDate { get; set; }
        public int PostingDate { get; set; }
        public int ValueDate { get; set; }
        public string TranCode { get; set; }
        public string AccountNo { get; set; }
        public string CifId { get; set; }
        public string BrCode { get; set; }
        public double LocalAmount { get; set; }
        public string LocalCurrency { get; set; }
        public double ForeignAmount { get; set; }
        public double FxRate { get; set; }
        public short TranReversalInd { get; set; }
        public string ReferanceNo { get; set; }
        public string ReferanceDt { get; set; }
        public string TranLocation { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public double Field21 { get; set; }
        public double Field22 { get; set; }
        public double Field23 { get; set; }
        public double Field24 { get; set; }
        public double Field25 { get; set; }
        public double Field26 { get; set; }
        public double Field27 { get; set; }
        public double Field28 { get; set; }
        public double Field29 { get; set; }
        public double Field30 { get; set; }
        public int Field31 { get; set; }
        public int Field32 { get; set; }
        public int Field33 { get; set; }
        public int Field34 { get; set; }
        public int Field35 { get; set; }
        public int Field36 { get; set; }
        public int Field37 { get; set; }
        public int Field38 { get; set; }
        public int Field39 { get; set; }
        public int Field40 { get; set; }
        public string Field50 { get; set; }
        public string Field51 { get; set; }
        public string Field52 { get; set; }
        public string Field53 { get; set; }
        public string Field54 { get; set; }
        public string Field55 { get; set; }
        public short CrInd { get; set; }
        public double CrAmount { get; set; }
        public short DrInd { get; set; }
        public double DrAmount { get; set; }
        public int BatchDate { get; set; }
        public string BatchNo { get; set; }
        public string ModeMn { get; set; }
        /// <summary>
        /// Date of this record created
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created this record
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date of this record updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated this record
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
