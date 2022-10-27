using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RfPortfolio
    {
        public int CodeComp { get; set; }
        public int CodeOrg { get; set; }
        /// <summary>
        /// Master No for each customer
        /// </summary>
        public string NoMaster { get; set; }
        /// <summary>
        /// Customer Identification No
        /// </summary>
        public string NoCif { get; set; }
        /// <summary>
        /// To sort out the priority portfolio to be review\nCondition will be calculated based on respective RF
        /// </summary>
        public int RiskPriority { get; set; }
        /// <summary>
        /// Customer risk level\n- To decide the risk criteria
        /// </summary>
        public int RiskLevel { get; set; }
        /// <summary>
        /// Customer Name
        /// </summary>
        public string InfoName { get; set; }
        public int RfTm { get; set; }
        public int RfWl { get; set; }
        public int RfRp { get; set; }
        public int RfOb { get; set; }
        public int RfPm { get; set; }
        public int RfModule01 { get; set; }
        public int RfModule02 { get; set; }
        public int RfModule03 { get; set; }
        public int RfModule04 { get; set; }
        public int RfModule05 { get; set; }
        /// <summary>
        /// Store the status of each module\n01|00|00|00|00|01|00|00|02|03\n\n00 - Nothing\n01 - New\n02 - Addon\n03 - Late
        /// </summary>
        public string StatusRf { get; set; }
        /// <summary>
        /// 0 for Temporary 1 for Existing
        /// </summary>
        public short ExistingInd { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        /// <summary>
        /// User who created this PF
        /// </summary>
        public string AuditCreatedUser { get; set; }
        public DateTime AuditUpdatedDate { get; set; }
        /// <summary>
        /// User who updated this PF
        /// </summary>
        public string AuditUpdatedUser { get; set; }
    }
}
