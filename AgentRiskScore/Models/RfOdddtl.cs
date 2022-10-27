using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfOdddtl
    {
        /// <summary>
        /// company code
        /// </summary>
        public int CodeComp { get; set; }
        /// <summary>
        /// organization code
        /// </summary>
        public int CodeOrg { get; set; }
        /// <summary>
        /// red flag id
        /// </summary>
        public long RfId { get; set; }
        /// <summary>
        /// system running number (index purpose)
        /// </summary>
        public int SysSeq { get; set; }
        /// <summary>
        /// entity id for watchlist
        /// </summary>
        public string HitWlId { get; set; }
        /// <summary>
        /// indicator hit (name/id/country etc)
        /// </summary>
        public short? TypeHit { get; set; }
        /// <summary>
        /// account no of customer
        /// </summary>
        public string NoAccount { get; set; }
        /// <summary>
        /// cif no of customer
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// watchlist provider
        /// </summary>
        public string HitSource { get; set; }
        /// <summary>
        /// name type (primary/aka/secondary etc)
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// watchlist name
        /// </summary>
        public string SingleStringName { get; set; }
        /// <summary>
        /// watchlist id
        /// </summary>
        public string HitId { get; set; }
        /// <summary>
        /// watchlist country
        /// </summary>
        public string HitCountry { get; set; }
        /// <summary>
        /// watchlist YOB
        /// </summary>
        public string HitDobs { get; set; }
        /// <summary>
        /// watchlist category
        /// </summary>
        public string HitCategory { get; set; }
        public string HitNamesource { get; set; }
        /// <summary>
        /// match percentage group
        /// </summary>
        public short? HitStrong { get; set; }
        /// <summary>
        /// investigation status assigned by user
        /// </summary>
        public short? StatusInv { get; set; }
        /// <summary>
        /// exposition assigned by user
        /// </summary>
        public short? TypeExpo { get; set; }
        /// <summary>
        /// remarks
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// flag of false positive
        /// </summary>
        public short? FlagFalsepos { get; set; }
        /// <summary>
        /// gender field in watchlist
        /// </summary>
        public string HitGender { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public string TypeEnt { get; set; }
    }
}
