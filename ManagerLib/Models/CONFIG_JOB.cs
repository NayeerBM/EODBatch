using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class CONFIG_JOB
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 2)]
        public int CODE_COMP { get; set; }
        [Key, Column(Order = 3)]
        public int CODE_ORG { get; set; }
        [Key, Column(Order = 4)]
        public int JOB_SEQ { get; set; }
        public string JOB_NAME { get; set; }
        public int JOB_GROUP { get; set; }
        public int JOB_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        #endregion

    }
    [Table("CONFIG_JOB")]
    public class _CONFIG_JOB
    {
        public _CONFIG_JOB() { }

        public _CONFIG_JOB(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            JOB_ID = "";
            JOB_SEQ = 0;
            JOB_NAME = "";
            JOB_GROUP = 0;
            JOB_STATUS = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public string JOB_ID { get; set; }
        [Key, Column(Order = 2)]
        public int CODE_COMP { get; set; }
        [Key, Column(Order = 3)]
        public int CODE_ORG { get; set; }
        [Key, Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JOB_SEQ { get; set; }
        public string JOB_NAME { get; set; }
        public int JOB_GROUP { get; set; }
        public int JOB_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        #endregion

    }
}
