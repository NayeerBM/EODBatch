using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScoreHistUpt.Shared
{
    public static class GlobalVariables
    {
        public static Int16 AppSetting_CodeComp = GetInt16Value("CodeComp", 1);
        public static Int16 AppSetting_CodeOrg = GetInt16Value("CodeOrg", 1);
        public static string AppSetting_UserId = GetStringValue("UserId");
        public static string AppSetting_LogFileName = GetStringValue("LogFileName");

        public static string AppSetting_RiskChangePartAt = GetStringValue("RiskChangePartAt");
        public static string AppSetting_TargetedTable = GetStringValue("TargetedTable");
        public static string AppSetting_SourceTable = GetStringValue("SourceTable");
        public static string AppSetting_ChangeTable = GetStringValue("ChangeTable");
        public static string AppSetting_TempTable = GetStringValue("TempTable");

        public static int AppSetting_UpdatePreviousScoreInd = GetIntValue("UpdatePreviousScoreInd");
        public static int AppSetting_RiskScoreCode = GetIntValue("RiskScoreCode", 1700);
        public static string AppSetting_CurrentRiskScoreField = GetStringValue("CurrentRiskScoreField");
        public static string AppSetting_PreviousRiskScoreField = GetStringValue("PreviousRiskScoreField");

        public static int AppSetting_Risk_Column_Table = GetIntValue("Risk_Column_Table");
        public static int AppSetting_Risk_Setting = GetIntValue("Risk_Setting", 2147);
        public static string AppSetting_Participant_Filter = GetStringValue("Participant_Filter");

        private static string GetStringValue(string key, string defaultValue = "")
        { 
            return ConfigurationManager.AppSettings[key] != null ? ConfigurationManager.AppSettings[key] : defaultValue;
        }
        private static int GetIntValue(string key, int defaultValue = 0)
        {
            return ConfigurationManager.AppSettings[key] != null ? int.Parse(ConfigurationManager.AppSettings[key]) : defaultValue;
        }
        private static Int16 GetInt16Value(string key, Int16 defaultValue = 0)
        {
            return ConfigurationManager.AppSettings[key] != null ? Int16.Parse(ConfigurationManager.AppSettings[key]) : defaultValue;
        }
    }

}
