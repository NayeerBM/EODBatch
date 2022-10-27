using AgentRiskScore.Data;
using AgentRiskScore.Models;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScore.Classes
{
    public class TotalSumRiskFactor
    {
        private static readonly Logger logger = LogManager.GetLogger("Logger");
        public static void CalcTotalRisk(string assessmentId , short RiskCalcId)
        {
            using (var context = new CommonContext())
            {
                List<string> riskScoreFields = new();
                List<RiskCalcSource> riskCalcSources;
                string strRiskSourceFields = String.Empty;
                StringBuilder riskFactorStatement = new StringBuilder();
                riskCalcSources = context.RiskCalcSources.Where(x => x.AssessmentId == assessmentId && x.RiskCalcId == RiskCalcId).ToList();
                var lastItem = riskCalcSources.Last();
                foreach (var riskCalcSource in riskCalcSources)
                {
                    riskScoreFields.Add(riskCalcSource.SourceField);
                    if (riskCalcSource.Equals(lastItem))
                    {
                        riskFactorStatement.Append($"ISNULL((SELECT DATA_VALUEI1 FROM CONFIG_CODES_DTL WHERE CODE_PRIME={riskCalcSource.ParamCode} AND CODE_SUB={riskCalcSource.SourceField}),0) AS {riskCalcSource.SourceField}\n");

                    }
                    else
                    {
                        riskFactorStatement.Append($"ISNULL((SELECT DATA_VALUEI1 FROM CONFIG_CODES_DTL WHERE CODE_PRIME={riskCalcSource.ParamCode} AND CODE_SUB={riskCalcSource.SourceField}),0) AS {riskCalcSource.SourceField},\n");
                    }
                }
                strRiskSourceFields = string.Join(" + ", riskScoreFields);
                riskFactorStatement.Insert(0, $"INSERT INTO RISK_TEMP\r\nSELECT NO_MASTER, NO_CIF, SUM({strRiskSourceFields}), 0 as SUM_RISK_CALC_TYPE2, 0 as SUM_RISK_CALC_TYPE3, 0 as FINAL_SCORE FROM(\r\nSELECT\r\nNO_MASTER,\r\nNO_CIF,\r\n");
                riskFactorStatement.AppendLine("FROM CUSTOMER) TEMP\r\nGROUP BY NO_MASTER, NO_CIF");
                logger.Info(riskFactorStatement.ToString());
                Console.WriteLine("-------------------Start of Query-------------------\n");
                Console.WriteLine(riskFactorStatement.ToString());
                Console.WriteLine("-------------------End of Query-------------------\n");

                var executeQuery = context.Database.ExecuteSqlRaw(riskFactorStatement.ToString());
                logger.Debug($"Number of rows affected: {executeQuery}");
            }
        }
    }
}
