using System;
using System.Collections.Generic;
using System.Data.Common;
using AgentRiskScore.Data;
using AgentRiskScore.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NLog;

namespace AgentRiskScore.Classes
{
    public class AddScores
    {
        private static readonly Logger logger = LogManager.GetLogger("Logger");
        //NOT PROPERLY DONE
        public static void CalcScore(string assessmentId, short RiskCalcId)
        {
            /*
                public static int AddScores(){
                    0. Initialize empty key-value pair object
                    1. Based on Assessment_ID && Risk_Calc_Id, get (PARAM_CODE,SOURCE_TABLE,SOURCE_FIELD,)
                    2. Iterate over each row of data:
                        i. for each row in the SOURCE_TABLE //Account
                            - var RiskCode= context.SOURCE_TABLE.Select(SOURCE_FIELD)//ValueField01
                            - var RiskScore= context.RawSQLQuery("SELECT RISKSCORE FROM C_C_DTL WHERE CODE_PRIME
                              = {ParamCode} && CODE_SUB={RiskCode}");
                            - Insert RiskScore into array based on CIF
                        ii. forEach row in key-value object
                            - var cif=get key
                            - var sumValue= value.Sum()
                            -Update into SUM_RISK_CALC_TYPE3 based on CIF NO
            
                }
            */
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
