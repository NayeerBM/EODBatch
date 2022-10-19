using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScore.Shared
{
    public class GlobalVariables
    {
        public static IConfigurationSection ConnectionString { get; } = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings");
    }
}
