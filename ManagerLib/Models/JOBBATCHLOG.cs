using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class JOBBATCHLOG
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public int CODE_COMP { get; set; }
        [Key, Column(Order = 2)]
        public int CODE_ORG { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_DATE { get; set; }
        [Key, Column(Order = 4)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 5)]
        public string STEP_ID { get; set; }
        [Key, Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UNIQUE_KEY { get; set; }
        public int RUN_TIME { get; set; }
        public string REF_NO1 { get; set; }
        public string REF_NO2 { get; set; }
        public string ERROR_MSG { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        #endregion

    }
    [Table("JOBBATCHLOG")]
    public class _JOBBATCHLOG
    {

        public _JOBBATCHLOG() { }

        public _JOBBATCHLOG(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RUN_DATE = 0;
            JOB_ID = "";
            STEP_ID = "";
            UNIQUE_KEY = 0;
            RUN_TIME = 0;
            REF_NO1 = "";
            REF_NO2 = "";
            ERROR_MSG = "";
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public int CODE_COMP { get; set; }
        [Key, Column(Order = 2)]
        public int CODE_ORG { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_DATE { get; set; }
        [Key, Column(Order = 4)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 5)]
        public string STEP_ID { get; set; }
        [Key, Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UNIQUE_KEY { get; set; }
        public int RUN_TIME { get; set; }
        public string REF_NO1 { get; set; }
        public string REF_NO2 { get; set; }
        public string ERROR_MSG { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        #endregion

    }

}
