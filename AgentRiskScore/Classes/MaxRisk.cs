using AgentRiskScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AgentRiskScore.Classes
{
    public class MaxRisk
    {
        public static void GetMaxRisk(string assessmentId, short RiskCalcId)
        {
            throw new NotImplementedException();
            /*UPDATE RISK_TEMP
            SET SUM_RISK_CALC_TYPE2 = MAX_VALUE
            FROM RISK_TEMP as TEMP INNER JOIN(
                        SELECT no_master,
                       no_cif,
                       Max(data_valuei1) AS MAX_VALUE
                       FROM   account A

                       LEFT JOIN config_codes_dtl B

                              ON B.code_prime = 1607

                                 AND A.data_value03 = B.code_sub

                GROUP BY no_master, no_cif
            ) TEMP_TABLE on TEMP.NO_CIF = TEMP_TABLE.NO_CIF and TEMP.NO_MASTER = TEMP_TABLE.NO_MASTER*/
        }
    }
}
