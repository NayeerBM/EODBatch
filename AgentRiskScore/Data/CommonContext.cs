using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentRiskScore.Shared;

namespace AgentRiskScore.Data
{
    public class CommonContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GlobalVariables.ConnectionString["DefaultConnection"]);
        }
    }
}
