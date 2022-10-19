using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentEWLDtlDeDb.Shared
{
    public static class GlobalVariables
    {

        public static Int16 AppSetting_CompCode = GetInt16Value("CompCode", 1);
        public static string AppSetting_UserId = GetStringValue("UserId");
        public static string AppSetting_LogFileName = GetStringValue("LogFileName");

        public static string AppSetting_AlertTranTableGroup = GetStringValue("AlertTranTableGroup");
        public static string AppSetting_AssignBrInd = GetStringValue("AssignBrInd");
        public static string AppSetting_AssignToBrCode = GetStringValue("AssignToBrCode");
        public static string AppSetting_AlertTranCode = GetStringValue("AlertTranCode");
        public static string AppSetting_DeletionMethod = GetStringValue("DeletionMethod");
        public static int AppSetting_FilterSetting = GetIntValue("FilterSetting");



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
