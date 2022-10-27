using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class EsAccessToken
    {
        public short CompCode { get; set; }
        public int AutoSeqNo { get; set; }
        public string AccessToken { get; set; }
        public string ExpiresIn { get; set; }
        public string Username { get; set; }
        public string ClientId { get; set; }
        public DateTime? Issued { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime? StampDttm { get; set; }
    }
}
