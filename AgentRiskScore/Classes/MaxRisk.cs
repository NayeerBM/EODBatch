using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScore.Classes
{
    public class MaxRisk
    {
        public static void GetMaxRisk(string assessmentId, short RiskCalcId)
        {
            throw new NotImplementedException();
            /*
                public static int GetMaxRisk(){
                    0. Initialize empty key-value pair object
                    1. Based on Assessment_ID && Risk_Calc_Id, get (PARAM_CODE,SOURCE_TABLE,SOURCE_FIELD,)
                    2. Iterate over each row of data:
                        i. for each row in the SOURCE_TABLE //Account
                            - var RiskCode= context.SOURCE_TABLE.Select(SOURCE_FIELD)//ValueField01
                            - var RiskScore= context.RawSQLQuery("SELECT RISKSCORE FROM C_C_DTL WHERE CODE_PRIME
                              = {ParamCode} && CODE_SUB={RiskCode}");
                            -Replace with SQLQuery
                        ii. forEach row in key-value object
                            - var cif=get key
                            - var maxValue= value.Max()
                            -Update into SUM_RISK_CALC_TYPE2 based on CIF NO
            
                }
             */
        }
    }
}
