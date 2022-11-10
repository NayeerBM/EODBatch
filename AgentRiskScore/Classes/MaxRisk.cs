using AgentRiskScore.Data;
using AgentRiskScore.Models;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NLog;

namespace AgentRiskScore.Classes
{
    public class MaxRisk
    {
        private static readonly Logger logger = LogManager.GetLogger("Logger");
        public static void GetMaxRisk(string assessmentId, short RiskCalcId)
        {
            
            /*UPDATE RISK_TEMP
            SET SUM_RISK_CALC_TYPE2 = MAX_VALUE
            FROM RISK_TEMP as TEMP INNER JOIN(
                        SELECT no_master,
                       no_cif,
                       Max(data_valuei1) AS MAX_VALUE
                       FROM   {DESTINATION_TABLE} A

                       LEFT JOIN config_codes_dtl B

                              ON B.code_prime = {PARAM_CODE}

                                 AND A.{SOURCE_FIELD} = B.code_sub

                GROUP BY no_master, no_cif
            ) TEMP_TABLE on TEMP.NO_CIF = TEMP_TABLE.NO_CIF and TEMP.NO_MASTER = TEMP_TABLE.NO_MASTER*/

            using(var context= new CommonContext())
            {
                List<string> riskScoreFields = new();
                RiskCalcSource riskCalcSource = context.RiskCalcSources.AsNoTracking().FirstOrDefault(x => x.AssessmentId == assessmentId && x.RiskCalcId == RiskCalcId);
                logger.Debug($"riskCalcSource: {JsonConvert.SerializeObject(riskCalcSource)}");

                string queryString = $"UPDATE RISK_TEMP\r\n"+
                $"SET SUM_RISK_CALC_TYPE2 = MAX_VALUE\r\n"+
                $"FROM RISK_TEMP as TEMP INNER JOIN(\r\n"+
                    $"SELECT no_master,\r\n"+
                    $"no_cif,\r\n"+
                    $"Max(data_valuei1) AS MAX_VALUE\r\n"+
                $"FROM   {riskCalcSource.SourceTable} A\r\n"+
                $"LEFT JOIN config_codes_dtl B\r\n"+
                $"ON B.code_prime = {riskCalcSource.ParamCode}\r\n"+
                $"AND A.{riskCalcSource.SourceField} = B.code_sub\r\n"+
                $"GROUP BY no_master, no_cif) TEMP_TABLE on TEMP.NO_CIF = TEMP_TABLE.NO_CIF and TEMP.NO_MASTER = TEMP_TABLE.NO_MASTER\r\n";
                Console.WriteLine("-------------------Start of Query-------------------\n");
                Console.WriteLine(queryString);
                Console.WriteLine("-------------------End of Query-------------------\n");
                var watch = new System.Diagnostics.Stopwatch();
                try
                {
                    /*watch.Start();
                    var executeQuery = context.Database.ExecuteSqlRaw(queryString);
                    watch.Stop();
                    logger.Debug($"Number of rows affected: {executeQuery}");
                    logger.Debug($"Elapsed Time {watch.ElapsedMilliseconds}ms");*/
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
