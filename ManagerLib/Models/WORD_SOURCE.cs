using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WORD_SOURCE
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public string word { get; set; }
        #endregion

    }
    [Table("WORD_SOURCE")]
    public class _WORD_SOURCE
    {

        public _WORD_SOURCE() { }

        public _WORD_SOURCE(bool setDefaultValue)
        {
            id = 0;
            word = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public string word { get; set; }
        #endregion

    }

}