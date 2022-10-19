using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SQLLib
{
    public class StringHelper
    {
        [SqlProcedure]
        public static double GetLevenshteinDistance(string str1, string str2)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));

            if (str2 == null)
                throw new ArgumentNullException(nameof(str2));

            if (str1 == str2)
                return 1;

            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return 0;

            int n = str1.Length;
            int m = str2.Length;
            int[,] distance = new int[n + 1, m + 1]; // matrix
            int cost = 0;
            if (n == 0) return m;
            if (m == 0) return n;
            //init1
            for (int i = 0; i <= n; distance[i, 0] = i++) ;
            for (int j = 0; j <= m; distance[0, j] = j++) ;
            //find min distance
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    cost = (str2.Substring(j - 1, 1) == str1.Substring(i - 1, 1) ? 0 : 1);
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            //#region PRINT

            //var str = "";
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= m; j++)
            //    {
            //        str += distance[i, j].ToString() + "\t";
            //    }
            //    str += "\n";
            //}
            //Console.WriteLine(str);
            //System.Diagnostics.Debug.WriteLine(str);

            //#endregion

            return distance[n, m];
            //float dis = distance[n, m];
            //float maxLen = (str1.Length <= str2.Length) ? str1.Length : str2.Length;
            //if (maxLen == 0.0F)
            //    return 1;
            //else
            //    return 1 - (dis / maxLen);
        }
    }
}
