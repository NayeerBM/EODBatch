using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class WlUpdateLog
    {
        public int Id { get; set; }
        public string WatchlistType { get; set; }
        public string FileName { get; set; }
        public int FileDate { get; set; }
        public string FileType { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateStatus { get; set; }
    }
}
