using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class EventViewerW
    {
        public long Id { get; set; }
        public short CompCode { get; set; }
        public int TranDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Action { get; set; }
        public string PageName { get; set; }
        public string RoomName { get; set; }
        public string MenuName { get; set; }
        public string Userid { get; set; }
        public string BrCode { get; set; }
        public string SysName { get; set; }
        public string SearchName { get; set; }
        public string SearchId { get; set; }
        public string RefField { get; set; }
        public string SearchName2 { get; set; }
        public string SearchId2 { get; set; }
        public string RefField2 { get; set; }
        public string ResultVal { get; set; }
        public string RequestChannel { get; set; }
        public string SearchCountry { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}
