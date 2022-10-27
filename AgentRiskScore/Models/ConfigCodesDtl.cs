using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// To list out the detail of the parameter codes available in the system
    /// </summary>
    public partial class ConfigCodesDtl
    {
        /// <summary>
        /// Company Code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// Organization Code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// Primary Grouping Code
        /// </summary>
        public int CodePrime { get; set; }
        /// <summary>
        /// Paramater Code
        /// </summary>
        public string CodeSub { get; set; }
        /// <summary>
        /// To define the order of the paramater (usually in dropdownlist)
        /// </summary>
        public int? InfoOrder { get; set; }
        /// <summary>
        /// Category name for the codes
        /// </summary>
        public string InfoCategory { get; set; }
        /// <summary>
        /// Desription of the paramater registered
        /// </summary>
        public string InfoDesc { get; set; }
        /// <summary>
        /// Other description for registered paramater
        /// </summary>
        public string InfoDescOther { get; set; }
        /// <summary>
        /// Custom integer field 1
        /// </summary>
        public int? DataValuei1 { get; set; }
        /// <summary>
        /// Custom integer field 2
        /// </summary>
        public int? DataValuei2 { get; set; }
        /// <summary>
        /// Custom float field 1
        /// </summary>
        public double? DataValuef1 { get; set; }
        /// <summary>
        /// Custom float field 2
        /// </summary>
        public double? DataValuef2 { get; set; }
        /// <summary>
        /// Custom text field 1
        /// </summary>
        public string DataValuet1 { get; set; }
        /// <summary>
        /// Custom text field 2
        /// </summary>
        public string DataValuet2 { get; set; }
        /// <summary>
        /// Custom decimal field 1
        /// </summary>
        public decimal? DataValued1 { get; set; }
        /// <summary>
        /// Custom decimal field 2
        /// </summary>
        public decimal? DataValued2 { get; set; }
        public int ConfigStatus1 { get; set; }
        public int ConfigStatus2 { get; set; }
        /// <summary>
        /// Date of the parameter being registered
        /// </summary>
        public DateTime? AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created the paramater
        /// </summary>
        public string AuditCreatedUser { get; set; }
        /// <summary>
        /// Date the parameter being updated
        /// </summary>
        public DateTime? AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated the parameter
        /// </summary>
        public string AuditUpdatedUser { get; set; }
        public int Rg1 { get; set; }
        public int Rg2 { get; set; }
        public int Rg3 { get; set; }
        public int Rg4 { get; set; }
        public int Rg5 { get; set; }
    }
}
