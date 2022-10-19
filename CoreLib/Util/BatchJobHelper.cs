using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Database;

namespace CoreLib.Util
{
    public static class BatchJobHelper
    {
        public static void GetBatchJobInfo(CommonContext context)
        {
            context.Database.ExecuteSqlCommand(BatchJobQuery)
        }
        public static void UpdateNewBatchNo(CommonContext context)
        {

        }

    }
}
