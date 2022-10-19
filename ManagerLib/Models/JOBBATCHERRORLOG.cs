using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class JOBBATCHERRORLOG
    {

        #region Extra Properties
        #endregion

        #region Properties

        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 1)]
        public Int16 CODE_COMP { get; set; }
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
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public bool EMAIL_SEND { get; set; }
        #endregion

    }
    [Table("JOBBATCHERRORLOG")]
    public class _JOBBATCHERRORLOG
    {

        public _JOBBATCHERRORLOG() { }

        public _JOBBATCHERRORLOG(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CODE_COMP = 1;
            CODE_ORG = 1;
            RUN_DATE = 0;
            JOB_ID = "";
            UNIQUE_KEY = 0;
            RUN_TIME = 0;
            REF_NO1 = "";
            REF_NO2 = "";
            ERROR_MSG = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
            EMAIL_SEND = false;
        }

        #region Properties

        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 1)]
        public Int16 CODE_COMP { get; set; }
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
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public bool EMAIL_SEND { get; set; }
        #endregion

    }

}