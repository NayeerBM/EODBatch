using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Query
{
    public class AgentBatchScanPartialWLAutoQuery
    {
        public enum SqlCase
        {
            Truncate_ATEMPALERTTRANWLISTDTL
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";
            switch (sqlCase)
            {
                case SqlCase.Truncate_ATEMPALERTTRANWLISTDTL:
                    sqlStatement = "TRUNCATE TABLE ATEMPALERTTRANWLISTDTL";
                    break;

                default:
                    sqlStatement = "";
                    break;
            }

#if DEBUG
            System.Diagnostics.Debug.WriteLine("GetStatement " + sqlCase.ToString() + System.Environment.NewLine + sqlStatement);
#endif

            return sqlStatement;
        }
    }
}
