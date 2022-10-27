using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class Wcfwlhitapproval
    {
        public short CompCode { get; set; }
        public int ScanNo { get; set; }
        public string YourRef { get; set; }
        public int HitDate { get; set; }
        public int HitTime { get; set; }
        public string BrCode { get; set; }
        public string DoneUserId { get; set; }
        public string ScanFullPartil { get; set; }
        public string ScanInput { get; set; }
        public short ReturnOk { get; set; }
        public short ApprovalStatus { get; set; }
        public short NoOfApprovalDone { get; set; }
        public short NoOfApprovalRequired { get; set; }
        public short NoOfRejectedDone { get; set; }
        public short DismissInd { get; set; }
        public short DismissBrInd { get; set; }
        public string ApprovedBy1 { get; set; }
        public int ApprovedDt1 { get; set; }
        public int ApprovedTm1 { get; set; }
        public short ApprovalStatus1 { get; set; }
        public string ApprovedBy2 { get; set; }
        public int? ApprovedDt2 { get; set; }
        public int ApprovedTm2 { get; set; }
        public short ApprovalStatus2 { get; set; }
        public string ApprovedBy3 { get; set; }
        public int ApprovedDt3 { get; set; }
        public int ApprovedTm3 { get; set; }
        public short ApprovalStatus3 { get; set; }
        public string Remarks { get; set; }
        public string RjRemarks { get; set; }
        public string Sysname { get; set; }
        public long AlertId { get; set; }
        public string CifId { get; set; }
        public short ScanType { get; set; }
        public string UserId1 { get; set; }
        public string UserId2 { get; set; }
        public string UserId3 { get; set; }
        public string RiskUsedInd { get; set; }
        public short DismissInd2 { get; set; }
        public string ProductCode { get; set; }
        public string UploadFileName { get; set; }
    }
}
