using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    /// <summary>
    /// Store the details of fields being mapped
    /// </summary>
    public partial class ParamMappingDtl
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        /// <summary>
        /// To map between HDR table and DTL, ID for mapping type (CLIENT/ACCOUNT/TXN)
        /// </summary>
        public int MapType { get; set; }
        public int MapProduct { get; set; }
        /// <summary>
        /// ID for column
        /// </summary>
        public int MapCategory { get; set; }
        /// <summary>
        /// Name of the table affected
        /// </summary>
        public string MapTableName { get; set; }
        /// <summary>
        /// Name of the field
        /// </summary>
        public string MapFieldName { get; set; }
        /// <summary>
        /// Additional Desription on the field name
        /// </summary>
        public string MapDisplayName { get; set; }
        /// <summary>
        /// To be display on KYC Module (0D1E)
        /// </summary>
        public int? ConfigKyc { get; set; }
        /// <summary>
        /// To be display on watchlist module (0D1E)
        /// </summary>
        public int? ConfigWatchlist { get; set; }
        /// <summary>
        /// To link the description on PARAM_CODES : Parameter Code
        /// </summary>
        public int? ConfigCode { get; set; }
        public int? DataType { get; set; }
        public int? DataLength { get; set; }
        public int? ConfigStatus { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
    }
}
