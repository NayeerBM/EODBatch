using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class WORD_COMPARE
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public Int64 sourceid { get; set; }
        public Int64 compareid { get; set; }
        public string source_word { get; set; }
        public string compare_word { get; set; }
        public decimal score1 { get; set; }
        public decimal score2 { get; set; }
        public decimal score3 { get; set; }
        public decimal score4 { get; set; }
        public decimal score5 { get; set; }
        public decimal score6 { get; set; }
        public decimal score7 { get; set; }
        public decimal score8 { get; set; }
        public decimal score9 { get; set; }
        #endregion

    }
    [Table("WORD_COMPARE")]
    public class _WORD_COMPARE
    {

        public _WORD_COMPARE() { }

        public _WORD_COMPARE(bool setDefaultValue)
        {
            id = 0;
            sourceid = 0;
            compareid = 0;
            source_word = "";
            compare_word = "";
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            score5 = 0;
            score6 = 0;
            score7 = 0;
            score8 = 0;
            score9 = 0;
        }

        #region Properties

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public Int64 sourceid { get; set; }
        public Int64 compareid { get; set; }
        public string source_word { get; set; }
        public string compare_word { get; set; }
        public decimal score1 { get; set; }
        public decimal score2 { get; set; }
        public decimal score3 { get; set; }
        public decimal score4 { get; set; }
        public decimal score5 { get; set; }
        public decimal score6 { get; set; }
        public decimal score7 { get; set; }
        public decimal score8 { get; set; }
        public decimal score9 { get; set; }
        #endregion

    }

}
