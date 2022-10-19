using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Models;

namespace CoreLib.Database
{
    public class CommonContext : DbContext
    {
        public CommonContext() : base("CommonContext")
        {

        }

        #region Entity Classes


        public DbSet<cor_code> cor_code { get; set; }
        //public DbSet<cor_menu> cor_menu { get; set; }

        #endregion

        #region Functions

        public List<T> SqlQueryDynamic<T>(string sql, params OleDbParameter[] param)
        {
            List<T> returnList;
            using (var cmd = this.Database.Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                cmd.Parameters.AddRange(param);

                using (var dr = cmd.ExecuteReader())
                {
                    returnList = DataReaderToList<T>(dr);
                }
            }

            return returnList;
        }


        public List<T> SqlQueryDynamic<T>(string sql, params SqlParameter[] param)
        {
            List<T> returnList;
            using (var cmd = this.Database.Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                cmd.Parameters.AddRange(param);

                using (var dr = cmd.ExecuteReader())
                {
                    returnList = DataReaderToList<T>(dr);
                }
            }

            return returnList;
        }

        private List<T> DataReaderToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);

            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    bool isFieldExists = true;
                    try
                    { var a = dr[prop.Name]; }
                    catch (Exception e)
                    { isFieldExists = false; }

                    if (isFieldExists && !object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        #endregion

    }
}
