using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ManagerLib.Database;
using ManagerLib.Models;

namespace ManagerLib.Util
{
    public class WatchlistAlgorithmHelper
    {
        private CommonContext context;
        private Dictionary<Int16, WatchlistAlgorightmDetails> WLAlgorithmList;
        private int CompCode;
        private List<string> WLStopList;
        private string strStopList;

        public WatchlistAlgorithmHelper(CommonContext context, Dictionary<Int16, WatchlistAlgorightmDetails> WLAlgorithmList, int CompCode)
        {
            context = this.context;
            WLAlgorithmList = this.WLAlgorithmList;
            CompCode = this.CompCode;

            if (WLAlgorithmList.ContainsKey((Int16)WatchListAlgorithmType.FILTER_STOP_LIST_TABLE))
            {
                WLStopList = context.WATCHLISTSTOPLIST.Where(l => l.COMP_CODE == CompCode).Select(l => l.ABBR_VALUE).ToList();
                strStopList = " " + String.Join(" ", WLStopList) + " ";
            }
        }

        public string Process(string text, params WatchListAlgorithmType[] WatchListAlgorithmTypes)
        {
            string result = text;

            foreach (var wl in WatchListAlgorithmTypes)
            {
                switch (wl)
                {
                    case WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID:
                        result = ReplaceSpecialCharacter(text, WLAlgorithmList[(Int16)WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID].WL_VALUE, "");
                        break;

                    case WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID:
                        result = ReplaceSpecialCharacter(text, WLAlgorithmList[(Int16)WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID].WL_VALUE, " ");
                        break;

                    case WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_NAME:
                        result = ReplaceSpecialCharacter(text, WLAlgorithmList[(Int16)WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_NAME].WL_VALUE, "");
                        break;

                    case WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_NAME:
                        result = ReplaceSpecialCharacter(text, WLAlgorithmList[(Int16)WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_NAME].WL_VALUE, " ");
                        break;

                    case WatchListAlgorithmType.FILTER_STOP_LIST_TABLE:

                        //var WLStopList = context.WATCHLISTSTOPLIST.Where(l => l.COMP_CODE == CompCode).Select(l => l.ABBR_VALUE).ToList();
                        //var strStopList = " " + String.Join(" ", WLStopList) + " ";
                        var arrText = result.Split(' ');
                        var arrResult = arrText.Where(l => !strStopList.Contains(" " + l + " "));

                        result = String.Join(" ", arrResult);
                        break;

                        
                }
            }

            return result;
        }

        public string ReplaceSpecialCharacter(string text, string pattern, string replaceText)
        {
            string result = "";

            var regex = new Regex(@"[""'']");
            result = regex.Replace(text, "`");
            regex = new Regex(@"[" + pattern + "]");
            result = regex.Replace(text, replaceText);

            return result;
        }

        public string GetValue(WatchListAlgorithmType type)
        {
            if (!WLAlgorithmList.ContainsKey((Int16)type))
                return null;

            return WLAlgorithmList[(Int16)type].WL_VALUE;
        }

        public enum WatchListAlgorithmType : Int16
        {
            RANK_SCORE = 1, MATCH_SCORE = 2, FILTER_SCRIPT_NAME = 4,
            STRING_EDIT_DISTANT = 5, FILTER_MULTI_WORD_SCORE = 6, WORD_EDIT_DISTANT = 7,
            SHOW_ALL_HIT_RESULT_FOR_ONE_WORD = 8, LENGTH_OF_IN_NAME_ALLOW = 9, LENGTH_OF_IN_WORD_ALLOW = 10,
            FILTER_REMOVE_SPECIAL_CHAR_NAME = 11, FILTER_REPLACE_SPECIAL_CHAR_NAME = 12, FILTER_REMOVE_SPECIAL_CHAR_ID = 13,
            FILTER_REPLACE_SPECIAL_CHAR_ID = 14, REMOVE_NON_NUMEIRIC_CHAR_IN_ID_FIELD = 15, CONTROL_FALSE_POS_RESULT = 16,
            FILTER_STOP_LIST_TABLE = 17, SHOW_GENDER = 18, SHOW_HIGH_RISK_COUNTRY = 25, VERIFY_DOB = 36
        }
        public enum MultiWordFilteringScoreType : Int16
        {
            FullHit = 10, Score1_1 = 11, Score1_2 = 21, Score2_2 = 22, Score1_3 = 31, Score2_3 = 32, Score3_3 = 33, Score1_4 = 41, Score2_4 = 42, Score3_4 = 43, Score4_4 = 44
        }
    }
}
