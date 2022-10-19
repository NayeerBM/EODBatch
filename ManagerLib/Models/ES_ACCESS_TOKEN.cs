using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class COMMON_ACCESS_TOKEN
    {
        public string access_token { get; set; }
    }

    public class ES_ACCESS_TOKEN
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 AUTO_SEQ_NO { get; set; }
        public Int16 COMP_CODE { get; set; }
        public string ACCESS_TOKEN { get; set; }
        public int EXPIRES_IN { get; set; }
        public string USERNAME { get; set; }
        public string CLIENT_ID { get; set; }
        public DateTime? ISSUED { get; set; }
        public DateTime? EXPIRES { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        #endregion

    }
    [Table("ES_ACCESS_TOKEN")]
    public class _ES_ACCESS_TOKEN
    {

        public _ES_ACCESS_TOKEN() { }

        public _ES_ACCESS_TOKEN(bool setDefaultValue)
        {
            AUTO_SEQ_NO = 0;
            COMP_CODE = 0;
            ACCESS_TOKEN = "";
            EXPIRES_IN = 0;
            USERNAME = "";
            CLIENT_ID = "";
            ISSUED = null;
            EXPIRES = null;
            STAMP_DTTM = null;
        }

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 AUTO_SEQ_NO { get; set; }
        public Int16 COMP_CODE { get; set; }
        public string ACCESS_TOKEN { get; set; }
        public int EXPIRES_IN { get; set; }
        public string USERNAME { get; set; }
        public string CLIENT_ID { get; set; }
        public DateTime? ISSUED { get; set; }
        public DateTime? EXPIRES { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        #endregion

    }

}
