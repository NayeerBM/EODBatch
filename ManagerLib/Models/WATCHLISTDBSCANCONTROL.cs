using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WATCHLISTDBSCANCONTROL
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string TABLE_ID { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_SEQ { get; set; }
        public int PROCESS_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string KEY_FROM { get; set; }
        public string KEY_TO { get; set; }
        public Int16 RUN_STATUS { get; set; }
        public int RUN_DATE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("WATCHLISTDBSCANCONTROL")]
    public class _WATCHLISTDBSCANCONTROL
    {

        public _WATCHLISTDBSCANCONTROL() { }

        public _WATCHLISTDBSCANCONTROL(bool setDefaultValue)
        {
            COMP_CODE = 0;
            TABLE_ID = "";
            RUN_SEQ = 0;
            PROCESS_DATE = 0;
            DESCRIPTION = "";
            KEY_FROM = "";
            KEY_TO = "";
            RUN_STATUS = 0;
            RUN_DATE = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string TABLE_ID { get; set; }
        [Key, Column(Order = 3)]
        public int RUN_SEQ { get; set; }
        public int PROCESS_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string KEY_FROM { get; set; }
        public string KEY_TO { get; set; }
        public Int16 RUN_STATUS { get; set; }
        public int RUN_DATE { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}