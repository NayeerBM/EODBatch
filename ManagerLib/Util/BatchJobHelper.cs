using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerLib.Database;
using ManagerLib.Models;
using ManagerLib.Query;

namespace ManagerLib.Util
{
    public static class BatchJobHelper
    {
        private static void UpdateNewBatchNo(CommonContext context, int intBatchNo, int intCompCode)
        {
            context.Database.ExecuteSqlCommand(BatchJobQuery.GetStatement(BatchJobQuery.SqlCase.UpdateNewBatchNo)
                                                                            , new SqlParameter("CompCode", intCompCode)
                                                                            , new SqlParameter("NewBatchNo", intBatchNo));
        }

        public static int GetNewBatchNo(CommonContext context, int intCompCode)
        {
            var param = context.PARAM.Where<_PARAM>(l => l.COMP_CODE == intCompCode).FirstOrDefault();

            if (param == null)
                return -1;

            var intBatchNo = param.LAST_IMPORT_BATCH_NO + 1;
            //var strBatchNo = param.CURRENT_PROCESS_DATE.ToString() + intBatchNo.ToString("D4");

            UpdateNewBatchNo(context, intBatchNo, intCompCode);

            return intBatchNo;
        }

    }
}
