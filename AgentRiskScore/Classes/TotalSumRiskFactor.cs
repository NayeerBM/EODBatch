using AgentRiskScore.Data;
using AgentRiskScore.Models;
using Microsoft.EntityFrameworkCore;
using NLog;
using System.Data.Common;
using System.Text;

namespace AgentRiskScore.Classes
{
    public class TotalSumRiskFactor
    {
        private static readonly Logger logger = LogManager.GetLogger("Logger");
        public static void CalcTotalRisk(string assessmentId, short RiskCalcId)
        {
            using (var context = new CommonContext())
            {
                List<string> riskScoreFields = new();
                List<RiskCalcSource> riskCalcSources;
                string strRiskSourceFields = String.Empty;
                StringBuilder riskFactorStatement = new();
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
                riskFactorStatement.Insert(0, $"INSERT INTO RISK_TEMP\r\nSELECT NO_MASTER, NO_CIF, SUM({strRiskSourceFields}), 0 as SUM_RISK_CALC_TYPE2, 0 as SUM_RISK_CALC_TYPE3, 0 as FINAL_SCORE FROM(\r\nSELECT\r\nCUSTOMER.NO_MASTER,\r\nCUSTOMER.NO_CIF,\r\n");
                riskFactorStatement.AppendLine("FROM CUSTOMER\r\n");
                var riskFilterTables = context.RiskCalcFilters.Where(x=>x.AssessmentId==assessmentId && x.RiskCalcId==RiskCalcId).Select(y=>new[] {y.FilterTable}).ToArray();
                foreach (var riskFilterTable in riskFilterTables)
                {
                    if (riskFilterTable[0] != riskCalcSources[0].SourceTable)
                        riskFactorStatement.AppendLine($"INNER JOIN {riskFilterTable[0]} ON CUSTOMER.NO_CIF={riskFilterTable[0]}.NO_CIF AND CUSTOMER.NO_MASTER={riskFilterTable[0]}.NO_MASTER");
                }

                riskFactorStatement.AppendLine($"WHERE");
                foreach (var riskCalcFilter in context.RiskCalcFilters.AsNoTracking().Where(x=>x.AssessmentId==assessmentId && x.RiskCalcId==RiskCalcId).ToList())
                {
                    Console.WriteLine(riskCalcFilter);
                    riskFactorStatement.AppendLine($"{riskCalcFilter.FilterQuery} {riskCalcFilter.FilterOperator}");
                }
                riskFactorStatement.AppendLine("\r\n");
                riskFactorStatement.AppendLine(") TEMP \r\nGROUP BY NO_MASTER, NO_CIF\r\n");
                logger.Info(riskFactorStatement.ToString());
                Console.WriteLine("-------------------Start of Query : NORMAL CALCULATION-------------------\n");
                Console.WriteLine(riskFactorStatement.ToString());
                Console.WriteLine("-------------------End of Query : NORMAL CALCULATION-------------------\n");
                
                var watch = new System.Diagnostics.Stopwatch();
                try
                {
                    //UNCOMMENT
                    watch.Start();
                    var executeQuery = context.Database.ExecuteSqlRaw(riskFactorStatement.ToString());
                    logger.Debug($"Number of rows affected: {executeQuery}");
                    watch.Stop();
                    Console.WriteLine($"Elapsed Time {watch.ElapsedMilliseconds}ms");
                }
                catch (DbException db)
                {
                    logger.Error(db, "Error executing query inside method: CalcTotalRisk");
                    throw new Exception("Failed to execute SQL Query");
                }
            }
        }
    }
}
