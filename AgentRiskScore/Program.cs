using AgentRiskScore.Data;
using AgentRiskScore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using Newtonsoft.Json;
using AgentRiskScore.Classes;
using AgentRiskScore.Exceptions;
using System.Data.Common;

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
            /* Main Loop:
             * 1. Check if enough arguments are passed to the program
             * 2. Validate the arguments with data to check whether they exist or not and whether the status is set to "active" or not
             * 3. Get all the Calculations for Risk Assessment Id
             * 4. Loop over each RISK_CALC object
             * 5. Check the RISK_CALC_TYPE and execute the appropriate method
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

            //Check whether able to connect to DB or not
            if(!new CommonContext().Database.CanConnect())
            {
                throw new DatabaseException("Cannot connect to Database. Problem with connection string");
            }

            //Check if Job Id and Job Step Id exists or not
            using (var context = new CommonContext())
            {
                bool jobIdExists = context.ConfigJobs.Any(r => r.JobId == JobId);
                bool jobStepIdExists = context.ConfigJobSteps.Any(r => r.JobId == JobId && r.StepId == StepId);

                //UNCOMMENT
                /*if (!jobIdExists || !jobStepIdExists)
                    throw new IdDoesNotExistException("Job Id and/or Job Step Id does not exist. Aborting.");*/
            }

            //Risk assessment Id is used as the Step Id, therefore it's taken directly from the Step Id
            string riskAssessmentId = StepId;
            logger.Debug($"riskAssessmentId:{riskAssessmentId}");


            List<RiskCalc> riskCalc;
            using (var context = new CommonContext())
            {
                //UNCOMMENT
                //Check if Risk Assessment Id exists or not
                /*bool idExists = context.ConfigRiskassessments.Where(r => r.AssessmentId == riskAssessmentId).Any();
                if (!idExists)
                    throw new IdDoesNotExistException("Risk Assessment Id does not exist");
                //Check if Risk Assessment is set to active or not
                bool isActive = context.ConfigRiskassessments.Where(r => r.AssessmentId == riskAssessmentId).All(r => r.Status == 1);
                if (!isActive)
                    throw new Exception("Risk Assessment is Inactive. Cannot proceed with Risk Calculation");*/

                //Get All Calculations for Risk Assessment ID
                riskCalc = context.RiskCalcs.Where(r => r.AssessmentId == riskAssessmentId && r.Status == 1).ToList();
            }
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