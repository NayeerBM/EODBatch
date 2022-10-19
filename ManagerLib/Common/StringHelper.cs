using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Common
{
    public static class StringHelper
    {
        public static string FormatString(string inputString, params KeyValuePair<string, string>[] param)
        {
            var str = inputString;

            foreach (var p in param)
                str = str.Replace("{" + p.Key + "}", p.Value);

            return str;
        }
    }
}
