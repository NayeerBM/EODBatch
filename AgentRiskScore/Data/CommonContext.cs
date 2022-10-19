﻿using AgentRiskScore.Model;
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
        /*public CommonContext(DbContextOptions<CommonContext> options) : base(options)
        {
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GlobalVariables.ConnectionString["DefaultConnection"]);
        }
        /*public DbSet<>Test{ get; set; }*/
        public DbSet<WL_BATCHLOG> WL_BATCHLOG { get; set; }
    }
}
