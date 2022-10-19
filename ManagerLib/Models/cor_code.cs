using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
    public class cor_code_RiskType3
    {
        public int rm_cor_CodeNo { get; set; }
        public string rm_cor_CodeKey { get; set; }
        public string rm_cor_Desc { get; set; }
        public double rm_cor_ValueF2 { get; set; }
        public int rm_cor_ValueI1 { get; set; }
        public int h1_cor_ValueI1 { get; set; }
        public string h1_cor_ValueT1 { get; set; }
        public double h1_cor_ValueF2 { get; set; }
        public int h2_cor_ValueI1 { get; set; }
        public string h2_cor_ValueT1 { get; set; }
        public double h2_cor_ValueF2 { get; set; }

    }

    public class cor_code
    {

        #region Extra Properties

        #endregion

        #region Properties

        [Key, Column(Order = 1)]
        public int cor_CodeNo { get; set; }
        [Key, Column(Order = 2)]
        public string cor_CodeKey { get; set; }
        public Int16 cor_Display_order { get; set; }
        public string cor_CodeCategory { get; set; }
        public string cor_Desc { get; set; }
        public int cor_ValueI1 { get; set; }
        public int cor_ValueI2 { get; set; }
        public double cor_ValueF1 { get; set; }
        public double cor_ValueF2 { get; set; }
        public string cor_ValueT1 { get; set; }
        public string cor_ValueT2 { get; set; }
        public int cor_ValueD1 { get; set; }
        public int cor_ValueD2 { get; set; }
        public string cor_Desc_Other { get; set; }
        public DateTime? cor_created_date { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_date { get; set; }
        public string cor_modified_user { get; set; }
        public Int16 RG1 { get; set; }
        public Int16 RG2 { get; set; }
        public Int16 RG3 { get; set; }
        public Int16 RG4 { get; set; }
        public Int16 RG5 { get; set; }
        public Int16 RG6 { get; set; }
        public Int16 RG7 { get; set; }
        public Int16 RG8 { get; set; }
        public Int16 RG9 { get; set; }
        public Int16 RG10 { get; set; }
        public Int16 RG11 { get; set; }
        public Int16 RG12 { get; set; }
        public Int16 RG13 { get; set; }
        public Int16 RG14 { get; set; }
        public Int16 RG15 { get; set; }
        public Int16 RG16 { get; set; }
        public Int16 RG17 { get; set; }
        public Int16 RG18 { get; set; }
        public Int16 RG19 { get; set; }
        public Int16 RG20 { get; set; }
        #endregion

    }
    [Table("cor_code")]
    public class _cor_code
    {

        public _cor_code() { }

        public _cor_code(bool setDefaultValue)
        {
            cor_CodeNo = 0;
            cor_CodeKey = "";
            cor_Display_order = 0;
            cor_CodeCategory = "";
            cor_Desc = "";
            cor_ValueI1 = 0;
            cor_ValueI2 = 0;
            cor_ValueF1 = 0;
            cor_ValueF2 = 0;
            cor_ValueT1 = "";
            cor_ValueT2 = "";
            cor_ValueD1 = 0;
            cor_ValueD2 = 0;
            cor_Desc_Other = "";
            cor_created_date = null;
            cor_created_user = "";
            cor_modified_date = null;
            cor_modified_user = "";
            RG1 = 0;
            RG2 = 0;
            RG3 = 0;
            RG4 = 0;
            RG5 = 0;
            RG6 = 0;
            RG7 = 0;
            RG8 = 0;
            RG9 = 0;
            RG10 = 0;
            RG11 = 0;
            RG12 = 0;
            RG13 = 0;
            RG14 = 0;
            RG15 = 0;
            RG16 = 0;
            RG17 = 0;
            RG18 = 0;
            RG19 = 0;
            RG20 = 0;
        }

        #region Properties

        [Key, Column(Order = 1)]
        public int cor_CodeNo { get; set; }
        [Key, Column(Order = 2)]
        public string cor_CodeKey { get; set; }
        public Int16 cor_Display_order { get; set; }
        public string cor_CodeCategory { get; set; }
        public string cor_Desc { get; set; }
        public int cor_ValueI1 { get; set; }
        public int cor_ValueI2 { get; set; }
        public double cor_ValueF1 { get; set; }
        public double cor_ValueF2 { get; set; }
        public string cor_ValueT1 { get; set; }
        public string cor_ValueT2 { get; set; }
        public int cor_ValueD1 { get; set; }
        public int cor_ValueD2 { get; set; }
        public string cor_Desc_Other { get; set; }
        public DateTime? cor_created_date { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_date { get; set; }
        public string cor_modified_user { get; set; }
        public Int16 RG1 { get; set; }
        public Int16 RG2 { get; set; }
        public Int16 RG3 { get; set; }
        public Int16 RG4 { get; set; }
        public Int16 RG5 { get; set; }
        public Int16 RG6 { get; set; }
        public Int16 RG7 { get; set; }
        public Int16 RG8 { get; set; }
        public Int16 RG9 { get; set; }
        public Int16 RG10 { get; set; }
        public Int16 RG11 { get; set; }
        public Int16 RG12 { get; set; }
        public Int16 RG13 { get; set; }
        public Int16 RG14 { get; set; }
        public Int16 RG15 { get; set; }
        public Int16 RG16 { get; set; }
        public Int16 RG17 { get; set; }
        public Int16 RG18 { get; set; }
        public Int16 RG19 { get; set; }
        public Int16 RG20 { get; set; }
        #endregion

    }

}