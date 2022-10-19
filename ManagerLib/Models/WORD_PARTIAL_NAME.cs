using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WORD_PARTIAL_NAME
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public int seq { get; set; }
        public string fullname { get; set; }
        public string partialname { get; set; }
        #endregion

    }
    [Table("WORD_PARTIAL_NAME")]
    public class _WORD_PARTIAL_NAME
    {

        public _WORD_PARTIAL_NAME() { }

        public _WORD_PARTIAL_NAME(bool setDefaultValue)
        {
            id = 0;
            seq = 0;
            fullname = "";
            partialname = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public int seq { get; set; }
        public string fullname { get; set; }
        public string partialname { get; set; }
        #endregion

    }

}