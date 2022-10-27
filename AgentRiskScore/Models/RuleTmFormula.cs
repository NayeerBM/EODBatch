using System;
using System.Collections.Generic;

namespace AgentRiskScore.Models
{
    public partial class RuleTmFormula
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
        /// Rule ID
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// Formula ID
        /// </summary>
        public int FormulaId { get; set; }
        /// <summary>
        /// Display order
        /// </summary>
        public short FormulaDisplayOrder { get; set; }
        /// <summary>
        /// Formula description
        /// </summary>
        public string FormulaDesc { get; set; }
        /// <summary>
        /// Compute method
        /// </summary>
        public short FormulaCompute { get; set; }
        public string Formula { get; set; }
        /// <summary>
        /// Threshold
        /// </summary>
        public long FormulaThreshold { get; set; }
        public long MinFormulaThreshold { get; set; }
        public long MaxFormulaThreshold { get; set; }
        /// <summary>
        /// Transaction type: debit/credit
        /// </summary>
        public string FormulaTranType { get; set; }
        public string FormulaAggregate { get; set; }
        public short FormulaPercent { get; set; }
        public short FormulaDuration { get; set; }
        public double MinTranAmount { get; set; }
        public double MaxTranAmount { get; set; }
        public int MinTranCount { get; set; }
        public int MaxTranCount { get; set; }
        public string AuditCreatedUser { get; set; }
        public DateTime? AuditCreatedDate { get; set; }
        public string AuditUpdatedUser { get; set; }
        public DateTime? AuditUpdatedDate { get; set; }
        public string FilterOperator { get; set; }
    }
}
