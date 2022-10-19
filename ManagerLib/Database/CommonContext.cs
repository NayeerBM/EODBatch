using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ManagerLib.Models;

namespace ManagerLib.Database
{
    public class CommonContext : DbContext
    {
        public CommonContext() : base("CommonContext")
        {

        }

        #region Entity Classes

        public DbSet<_cor_code> cor_code { get; set; }
        public DbSet<_PARAM> PARAM { get; set; }
        public DbSet<_cor_parameter> cor_parameter { get; set; }
        public DbSet<_JOBBATCHERRORLOG> JOBBATCHERRORLOG { get; set; }
        public DbSet<_JOBCONTROL> JOBCONTROL { get; set; }
        public DbSet<_JOBTRAN> JOBTRAN { get; set; }
        public DbSet<_CONFIGJOBPROCESS> CONFIGJOBPROCESS { get; set; }
        public DbSet<_WATCHLISTDBSCANCONTROL> WATCHLISTDBSCANCONTROL { get; set; }
        public DbSet<_WATCHLISTSTOPLIST> WATCHLISTSTOPLIST { get; set; }
        public DbSet<_WatchlistAlgorithmCAT> WatchlistAlgorithmCAT { get; set; }
        public DbSet<_ALERTTRANWLISTDTL> ALERTTRANWLISTDTL { get; set; }
        public DbSet<_ALERTWLTRAN> ALERTWLTRAN { get; set; }
        public DbSet<_ALERTWLTRANDTLHIT> ALERTWLTRANDTLHIT { get; set; }
        public DbSet<_ALERTWLTRANWLIST> ALERTWLTRANWLIST { get; set; }
        public DbSet<_ALERTWLTRANWLISTDTL> ALERTWLTRANWLISTDTL { get; set; }
        public DbSet<_ALERTTRAN> ALERTTRAN { get; set; }
        public DbSet<_ALERTTRANDTLHIT> ALERTTRANDTLHIT { get; set; }
        public DbSet<_ALERTTRANWLIST> ALERTTRANWLIST { get; set; }
        public DbSet<_ES_ACCESS_TOKEN> ES_ACCESS_TOKEN { get; set; }
        public DbSet<_JOBBATCHLOG> JOBBATCHLOG { get; set; }
        public DbSet<_CONFIG_JOB> CONFIG_JOB { get; set; }
        public DbSet<_CONFIG_JOB_STEP> CONFIG_JOB_STEP { get; set; }

        internal object SqlQueryDynamic<T>(string v, SqlParameter sqlParameter)
        {
            throw new NotImplementedException();
        }

        //public DbSet<_WORD_PARTIAL_NAME> WORD_PARTIAL_NAME { get; set; }
        //public DbSet<_WORD_SOURCE> WORD_SOURCE { get; set; }
        //public DbSet<_WORD_COMPARE> WORD_COMPARE { get; set; }


        #endregion

        #region Functions

        //public List<T> SqlQueryDynamic<T>(string sql, params SqlParameter[] param)
        //{
        //    List<T> returnList;
        //    using (var cmd = this.Database.Connection.CreateCommand())
        //    {
        //        cmd.CommandText = sql;
        //        if (cmd.Connection.State != ConnectionState.Open)
        //            cmd.Connection.Open();

        //        cmd.Parameters.AddRange(param);
        //        cmd.Transaction = this.Database.CurrentTransaction.UnderlyingTransaction;

        //        using (var dr = cmd.ExecuteReader())
        //        {
        //            returnList = DataReaderToList<T>(dr);
        //        }
        //    }

        //    return returnList;
        //}

        //private List<T> DataReaderToList<T>(IDataReader dr)
        //{
        //    List<T> list = new List<T>();
        //    T obj = default(T);

        //    while (dr.Read())
        //    {
        //        obj = Activator.CreateInstance<T>();
        //        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        //        {
        //            bool isFieldExists = true;
        //            try
        //            { var a = dr[prop.Name]; }
        //            catch (Exception e)
        //            { isFieldExists = false; }

        //            if (isFieldExists && !object.Equals(dr[prop.Name], DBNull.Value))
        //            {
        //                prop.SetValue(obj, dr[prop.Name], null);
        //            }
        //        }
        //        list.Add(obj);
        //    }
        //    return list;
        //}

        #endregion

    }
}
