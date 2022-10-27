using AgentRiskScore.Data;
using AgentRiskScore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using Newtonsoft.Json;
using AgentRiskScore.Classes;

namespace AgentRiskScore
{
    public class Program
    {
        //Use following command to update DB modesl directly from DB
        //Scaffold-DbContext "Server=192.168.2.70,50679\\MSSQLSERVER19; initial catalog=ISEM_PANDA_STG;User ID=pandaDev; pwd=sa123qwe!@#; Integrated Security=false;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -Tables RISK_CALC,RISK_CALC_SOURCE,CUSTOMER,ACCOUNT -OutputDir Models -ContextDir Data -Context CommonContext -Force
        //GlobalVariables.ConnectionString["DefaultConnection"]

        private static readonly Logger logger = LogManager.GetLogger("Logger");
        static void Main(string[] args)
        {
            //DEPENDENCY INJECTION HERE
            //DO NOT WRITE ANY CODE HERE OTHER THAN FOR DEPENDENCY INJECTION
            try
            {
                /*consoleLogger.Info("test");*/
                logger.Trace("Application has started");
                Run(args);
                logger.Trace("Application has stopped");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Application stopped due to unexpected error");
            }
            
            
        }

        /// <summary>
        /// Represents the main entrypoint of the application. All developer written code needs to be implemented here.
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentException"></exception>
        static void Run(string[] args)
        {
            /* Sample arguments : 12 RA005 
             * Steps:
             * 1. Check if whether enough arguments have been passed or not
             * 2. Cast JobId and StepId to variables
             * 3. Cast Risk Assessment Id
             * 
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
                int overallSum=0;
                var riskid= get risk assessment id
                var calcType= get all the calculation steps
                forEach type in calcType{
                    switch (type.Calculation_Type){
                        case 1:
                        NormalCalculation()
        
                        case 2:
                        GetMaxRisk()

                        case 3:
                        AddScores()
                    }
                }
                context.useRawSQLQuery("SUM(all)")//Sum all 3 columns, check the risk level from C_C_DTL 
                table and update Final_Score and Final_Risk_Level
             */

            //Checking whether enough arguments have been passed to the program or not
            if (args.Length < 2)
                throw new ArgumentException("Not enough arguments have been provided to program");
            foreach (var arg in args)
            {
                logger.Info(arg);
            }

            //Get JobId and StepId
            string JobId= args[0];
            string StepId= args[1];
            logger.Debug($"JobId:{JobId}, StepId:{StepId}");

            //Risk assessment Id is used as the Step Id, therefore it's taken directly from the Step Id
            string riskAssessmentId = StepId;
            logger.Debug($"riskAssessmentId:{riskAssessmentId}");

            //Get All Calculations for Risk Assessment ID
            List<RiskCalc> riskCalc;
            using (var context = new CommonContext())
            { riskCalc = context.RiskCalcs.Where(r => r.AssessmentId == riskAssessmentId).ToList(); }
            logger.Debug($"riskCalc : {JsonConvert.SerializeObject(riskCalc)}");

            foreach (var row in riskCalc)
            {
                logger.Debug($"RiskCalcType : {row.RiskCalcType}");
                switch (row.RiskCalcType)
                {
                    case 1:
                        logger.Trace($"Started method TotalSumRiskFactor.CalcTotalRisk");
                        TotalSumRiskFactor.CalcTotalRisk(riskAssessmentId, row.RiskCalcId);
                        logger.Trace($"Ended method TotalSumRiskFactor.CalcTotalRisk");
                        break;
                    case 2:
                        logger.Trace($"Started method MaxRisk.GetMaxRisk");
                        MaxRisk.GetMaxRisk(riskAssessmentId, row.RiskCalcId);
                        logger.Trace($"Ended method MaxRisk.GetMaxRisk");
                        break;
                    case 3:
                        logger.Trace($"Started method AddScores.CalcScore");
                        AddScores.CalcScore(riskAssessmentId, row.RiskCalcId);
                        logger.Trace($"Ended method AddScores.CalcScore");
                        break;
                }
            }
        }
    }
}