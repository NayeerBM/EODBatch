using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScoreHistUpt.Shared
{
    public enum AlertTranTableGroup { 
        ALERT_POOL = 0, 
        WATCHLIST_ALERT_POOL = 1, 
        CSV = 2
    }
    public enum ScanFullPartial
    {
        SCAN_FULL = 0,
        SCAN_PARTIAL = 1
    }

    public static class GlobalVariables
    {
        public static Int16 AppSetting_CompCode = GetInt16Value("CompCode", 1);
        public static string AppSetting_UserId = GetStringValue("UserId");

        public static string AppSetting_LogFileName = GetStringValue("LogFileName");
        public static int AppSetting_AlertTranTableGroup = GetIntValue("AlertTranTableGroup", 0);
        public static int AppSetting_AssignBrInd = GetIntValue("AssignBrInd");
        public static int AppSetting_AssignToBrCode = GetIntValue("AssignToBrCode");
        public static int AppSetting_AlertTranCode = GetIntValue("AlertTranCode");
        public static string AppSetting_BatchResultFolder = GetStringValue("BatchResultFolder");
        public static int AppSetting_ScanFullPartial = GetIntValue("ScanFullPartial", 1);
        public static int AppSetting_DetectionInd = GetIntValue("DetectionInd");
        public static int AppSetting_Amount = GetIntValue("Amount", 0);


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
