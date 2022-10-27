using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class WsAccessToken
    {
        public long AutoSeqNo { get; set; }
        public short CompCode { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
        public DateTime StampDttm { get; set; }
    }
}
