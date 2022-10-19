using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WATCHLISTSTOPLIST
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ABBR_VALUE { get; set; }
        public string ABBR_REPLACEMENT { get; set; }
        public string ORG_DESCRIPTION { get; set; }
        public Int16 STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }
    [Table("WATCHLISTSTOPLIST")]
    public class _WATCHLISTSTOPLIST
    {

        public _WATCHLISTSTOPLIST() { }

        public _WATCHLISTSTOPLIST(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ABBR_VALUE = "";
            ABBR_REPLACEMENT = "";
            ORG_DESCRIPTION = "";
            STATUS = 0;
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }
        [Key, Column(Order = 2)]
        public string ABBR_VALUE { get; set; }
        public string ABBR_REPLACEMENT { get; set; }
        public string ORG_DESCRIPTION { get; set; }
        public Int16 STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        #endregion

    }

}