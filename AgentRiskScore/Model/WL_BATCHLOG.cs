using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScore.Model
{
    public class WL_BATCHLOG
    {
        public int CODE_COMP { get; set; }
        public int CODE_ORG { get; set; }
        [Key]
        public int JOB_ID { get; set; }
        public Int16? UPLOAD_TYPE { get; set; }
        public string UPLOAD_SOURCE { get; set; } = String.Empty;
        public string UPLOAD_FILE_NAME { get; set; } = String.Empty;
        public int UPLOAD_FILE_SIZE { get; set; }
        public string RESULT_FILE_NAME { get; set; }=String.Empty;
        public int RESULT_FILE_SIZE { get; set; }
        public int TOTAL_PROCESSED { get; set; }
        public int TOTAL_RECORD { get; set; }
        public int TOTAL_HIT { get; set; }
        public Int16 STATUS { get; set; }
        public string MESSAGE { get; set; } = String.Empty;
        public DateTime AUDIT_CREATED_DATE { get; set; }
        public DateTime AUDIT_UPDATED_DATE { get; set; }
        public int ACTIVE { get; set; }
        public string FILE_ENCODE { get; set; }=String.Empty ;
        public string RESULT_FILE_ENCODE { get; set; } = String.Empty;

    }
}
