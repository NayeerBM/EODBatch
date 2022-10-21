using AgentRiskScore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using System.Configuration;


namespace AgentRiskScore
{
    public class Program
    {
        private static readonly Logger logger = LogManager.GetLogger("Logger");
        private static readonly Logger consoleLogger = LogManager.GetLogger("ConsoleLogger");
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
            /*
                int overallSum=0;
                var riskid= get risk assessment id
                var calcType= get all the calculation steps
                var cifIds= get all CIF_ID from CUSTOMER table
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
                Console.WriteLine(arg);
            }

            //Get JobId and StepId
            int JobId= int.Parse(args[0]);
            int StepId= int.Parse(args[1]);
            logger.Debug($"JobId:{JobId}, StepId:{StepId}");

            //Risk assessment Id is used as the Step Id, therefore it's taken directly from the Step Id
            int riskAssessmentId = StepId;
            logger.Debug($"riskAssessmentId:{riskAssessmentId}");

            
        }
    }
}