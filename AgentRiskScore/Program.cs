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
        private static readonly Logger consoleLogger = LogManager.GetLogger("ColoredConsole");
        static void Main(string[] args)
        {
            //DEPENDENCY INJECTION
            consoleLogger.Warn("Test");
            try
            {
                logger.Debug("Application has started");
                //ENTRYPOINT OF APPLICATION STARTS HERE
                Run(args);
                logger.Debug("Application has stopped");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Application stopped due to error");
            }
            
            
        }

        /// <summary>
        /// Represents the main entrypoint of the application. All user written code needs to be implemented here.
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentException"></exception>
        static void Run(string[] args)
        {
            //Checking whether enough arguments have been passed to the program or not
            if (args.Length < 2)
                throw new ArgumentException("Not enough arguments have been provided to program");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}