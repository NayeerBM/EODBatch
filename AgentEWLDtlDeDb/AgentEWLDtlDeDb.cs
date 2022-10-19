using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using AgentEWLDtlDeDb.Shared;
using ManagerLib.Database;
//using ManagerLib.Manager;
using ManagerLib.Models;
using ManagerLib.Query;
using ManagerLib.Util;
using F23.StringSimilarity;
using static ManagerLib.Util.StringHelper;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Data;
using ManagerLib.Manager;

namespace AgentEWLDtlDeDb
{
    class AgentEWLDtlDeDb
    {
        static void Main(string[] args)
        {
            #region Variables

            var strJobCode = args.Length >= 1 ? args[0] : "";
            var strFullScanScheduleKey = args.Length >=  2 ? args[1] : "";
            var strREC_TYPE = "";
            WatchListSource strWatchlistSource;

            #endregion


            using (var context = new CommonContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        #region Validation

                        //var JOBCONTROL = context.JOBCONTROL.Where(l => l.COMP_CODE == GlobalVariables.AppSetting_CompCode && l.JOB_ID == strJobCode).FirstOrDefault();

                        //if (JOBCONTROL == null)
                        //    throw new Exception("Error: Job ID " + strJobCode + " not exists (107)");
                        //else if (JOBCONTROL.STATUS == 1)
                        //    throw new Exception("Error: Job Status is isactive (106)");

                        //////-------------------------------------

                        //var CONFIGJOBPROCESS = context.CONFIGJOBPROCESS.Where(l => l.COMP_CODE == GlobalVariables.AppSetting_CompCode && l.JOB_CODE == strJobCode).FirstOrDefault();

                        //if (CONFIGJOBPROCESS == null)
                        //    throw new Exception("Error: Unregistered Job " + strJobCode + " (108)");
                        //else if (JOBCONTROL.PROCESSOR_TYPE != 69)
                        //    throw new Exception("Error: Invalid Agent ID " + JOBCONTROL.PROCESSOR_TYPE + " (Should Be 69) (109)");

                        //////-------------------------------------

                        //////Get batch info and update new batch no if parameter record exist
                        //var param = context.PARAM.Where<_PARAM>(l => l.COMP_CODE == GlobalVariables.AppSetting_CompCode).FirstOrDefault();

                        //if (param == null)
                        //    throw new Exception("Error: Parameter record not found (109)");

                        #endregion

                        ////Init Batch Job
                        var BatchJob = new BatchJobManager(context, (Int16)GlobalVariables.AppSetting_CompCode, GlobalVariables.AppSetting_UserId, strJobCode);
                        BatchJob.InitProcess();
                        BatchJob.CheckProcessorType(69);

                        if (GlobalVariables.AppSetting_DeletionMethod == "1")
                            context.Database.ExecuteSqlCommand(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.Delete_ATEMPALERTTRANWLISTDTL));
                        else
                            context.Database.ExecuteSqlCommand(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.Truncate_ATEMPALERTTRANWLISTDTL));


                        var GROUPINGLINK_INFO = context.Database.SqlQuery<GROUPINGLINK_INFO>(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.GetGroupingLinkInfo)
                                                                                                                        , new SqlParameter("CompCode", GlobalVariables.AppSetting_CompCode)
                                                                                                                        , new SqlParameter("JobCode", strJobCode)
                                                                                                                        , new SqlParameter("GroupingType", "RULE")).FirstOrDefault();

                        var strSqlDetails = context.Database.SqlQuery<BuildSql_Details>(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.BuildSql_Details)
                                                                                        , new SqlParameter("CompCode", GlobalVariables.AppSetting_CompCode)
                                                                                        , new SqlParameter("ER_DETECTION_METHOD", GROUPINGLINK_INFO.ER_DETECTION_METHOD)).ToList();
                        
                        foreach (var r in strSqlDetails)
                        {
                            switch (r.TABLE_FD_ID)
                            {
                                case 1:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT1;
                                    break;
                                case 2:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT2;
                                    break;
                                case 3:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT3;
                                    break;
                                case 4:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT4;
                                    break;
                                case 5:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT5;
                                    break;
                                case 6:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT6;
                                    break;
                                case 7:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT7;
                                    break;
                                case 8:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT8;
                                    break;
                                case 9:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT9;
                                    break;
                                case 10:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT10;
                                    break;
                                case 11:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT11;
                                    break;
                                case 12:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT12;
                                    break;
                                case 13:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT13;
                                    break;
                                case 14:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT14;
                                    break;
                                case 15:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT15;
                                    break;
                                case 16:
                                    r.EQ_LIST_PERCENT = GROUPINGLINK_INFO.EQ_LIST_PERCENT16;
                                    break;
                            }
                        }

                        var strSQLStmtSkipRec = String.Join(" or ", strSqlDetails.Where(l => l.TABLE_FD_ID >= 8 && l.TABLE_FD_ID <= 10 && l.EQ_LIST_PERCENT != 0).Select(l => l.strSQLStmtSkipRec));
                        strSQLStmtSkipRec = (string.IsNullOrEmpty(strSQLStmtSkipRec.Trim()) ? "" : "(" + strSQLStmtSkipRec + ")");

                        var BuildSql_Header = context.Database.SqlQuery<BuildSql_Header>(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.BuildSql_Header) 
                                                                                        , new SqlParameter("CompCode", GlobalVariables.AppSetting_CompCode)
                                                                                        , new SqlParameter("JobCode", strJobCode)
                                                                                        , new SqlParameter("strSQLStmtSkipRec", strSQLStmtSkipRec)
                                                                                        , new SqlParameter("ER_DETECTION_METHOD", GROUPINGLINK_INFO.ER_DETECTION_METHOD)).FirstOrDefault();

                        if (BuildSql_Header != null)
                        {
                            if (BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "DOWJONES" || BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "DJ")
                            {
                                strWatchlistSource = WatchListSource.DOWJONES;
                                strREC_TYPE = "WD01";
                            }
                            else if (BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "OFAC" || BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "STD")
                            {
                                strWatchlistSource = WatchListSource.OFAC;
                                strREC_TYPE = "WW01";
                            }
                            else if (BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "WCHECK" || BuildSql_Header.WATCHLIST_SOURCE.ToUpper() == "WORLDCHECK")
                            {
                                strWatchlistSource = WatchListSource.WORLDCHECK;
                                strREC_TYPE = "WC01";
                            }
                            else
                            {
                                strWatchlistSource = WatchListSource.LEXISNEXIS;
                                strREC_TYPE = "WL01";
                            }

                            var strWatchlistFieldValue = String.Join(",", strSqlDetails.Select(l => l.strWatchlistFieldValue));
                            strWatchlistFieldValue = (string.IsNullOrEmpty(strWatchlistFieldValue.Trim()) ? "" : "," + strWatchlistFieldValue.Trim());
                            var strWatchlistFieldValueDistict = String.Join(",", strSqlDetails.Select(l => l.strWatchlistFieldValueDistict));
                            var strWatchlistFieldUsed = String.Join(",", strSqlDetails.Select(l => l.strWatchlistFieldUsed));
                            var strIndividualSQLStmt = BuildSql_Header.strSQLCommonFdsUsedStmt + strWatchlistFieldValue + BuildSql_Header.strTable_Name_Used;
                            var strFullScanCondition = "";

                            if (strFullScanScheduleKey != "")
                            {
                                var WATCHLISTDBSCANCONTROL = context.WATCHLISTDBSCANCONTROL.Where(l => l.COMP_CODE == GlobalVariables.AppSetting_CompCode &&
                                                                                                        l.TABLE_ID == strFullScanScheduleKey &&
                                                                                                        l.PROCESS_DATE == BatchJob.lsParam.CURRENT_PROCESS_DATE &&
                                                                                                        l.RUN_DATE == 0 &&
                                                                                                        l.RUN_STATUS == 0).FirstOrDefault();

                                if (WATCHLISTDBSCANCONTROL != null)
                                {
                                    if (strFullScanScheduleKey.StartsWith("ACCOUNTMISC"))
                                        strFullScanCondition = String.Format(" and (M.MISC_KEY1 between '{0}' and '{1}' ", WATCHLISTDBSCANCONTROL.KEY_FROM, WATCHLISTDBSCANCONTROL.KEY_TO);
                                    else if (strFullScanScheduleKey.StartsWith("ACCOUNT"))
                                        strFullScanCondition = String.Format(" and B.ACCOUNT_NO between '{0}' and '{1}' ", WATCHLISTDBSCANCONTROL.KEY_FROM, WATCHLISTDBSCANCONTROL.KEY_TO);
                                    else if (strFullScanScheduleKey.StartsWith("CIF"))
                                        strFullScanCondition = String.Format(" and (C.CIF_NO between '{0}' and '{1}' ", WATCHLISTDBSCANCONTROL.KEY_FROM, WATCHLISTDBSCANCONTROL.KEY_TO);
                                }
                            }

                            var @strSqlSelectStmt = strIndividualSQLStmt + strFullScanCondition + BuildSql_Header.strSQLCommonSortOrderStmt;

                            var lsWatchlistResult = context.Database.SqlQuery<WatchlistResult>(@strSqlSelectStmt).ToList();





                            //var WatchlistAlgorightmDetails = context.SqlQueryDynamic<WatchlistAlgorightmDetails>(WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.GetWatchlistAlgorithmDetails)
                            //                                                                                    , new SqlParameter("CompCode", GlobalVariables.AppSetting_CompCode)).ToList();
                            
                            //var WLAlgorithmList = new Dictionary<Int16, WatchlistAlgorightmDetails>();
                            //var WordFilterScoreList = new Dictionary<Int16, Int16>();

                            //foreach (var algo in WatchlistAlgorightmDetails)
                            //{
                            //    if(!WLAlgorithmList.ContainsKey(algo.WL_ALGO))
                            //        WLAlgorithmList.Add(algo.WL_ALGO, algo);

                            //    if (algo.WL_ALGO == (Int16)WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_MULTI_WORD_SCORE)
                            //        WordFilterScoreList.Add(Int16.Parse(algo.WL_KEY), Int16.Parse(algo.WL_VALUE));
                            //}

                            var strCIF_ID = "";
                            var strBR_CODE = "";
                            var strACCOUNT_NO = "";

                            var watchlistAlgorithmManager = new WatchlistAlgorithmManager(context, GlobalVariables.AppSetting_CompCode);

                            foreach (var watchlist in lsWatchlistResult)
                            {
                                if (BuildSql_Header.TABLE_PARENT_ID == 1 || BuildSql_Header.TABLE_PARENT_ID == 2 || BuildSql_Header.TABLE_PARENT_ID == 3)
                                    strCIF_ID = watchlist.CIF_NO == null ? "" : watchlist.CIF_NO.Trim();
                                else
                                    strCIF_ID = watchlist.CIF_NO_X == null ? "" : watchlist.CIF_NO_X.Trim();

                                if (GlobalVariables.AppSetting_AssignBrInd == "1")
                                    strBR_CODE = watchlist.BR_CODE_CIF == null ? "" : watchlist.BR_CODE_CIF.Trim();
                                
                                strACCOUNT_NO = watchlist.ACCOUNT_NO_X == null ? "" : watchlist.ACCOUNT_NO_X.Trim();
                                var Search_ID = watchlist.FdCIFAcctValue8 == null ? "" : watchlist.FdCIFAcctValue8.Trim();
                                var Search_Name = watchlist.FdCIFAcctValue10 == null ? "" : watchlist.FdCIFAcctValue10.Trim();
                                var Search_Country = watchlist.FdCIFAcctValue11 == null ? "" : watchlist.FdCIFAcctValue11.Trim();
                                var Search_DOB = watchlist.FdCIFAcctValue12 == null ? "" : watchlist.FdCIFAcctValue12.Trim();
                                var Search_Gender = watchlist.FdCIFAcctValue13 == null ? "" : watchlist.FdCIFAcctValue13.Trim();
                                var Search_EntityType = watchlist.FdCIFAcctValue14 == null ? "" : watchlist.FdCIFAcctValue14.Trim();
                                var Search_NativeName = watchlist.FdCIFAcctValue15 == null ? "" : watchlist.FdCIFAcctValue15.Trim();

                                ////var WLAlgorithmHelper = new WatchlistAlgorithmHelper(context, WLAlgorithmList, GlobalVariables.AppSetting_CompCode);
                                ////Search_Country = WLAlgorithmHelper.ReplaceSpecialCharacter(Search_Country, "'", "");
                                ////Search_Gender = WLAlgorithmHelper.ReplaceSpecialCharacter(Search_Gender, "'", "");
                                ////Search_EntityType = WLAlgorithmHelper.ReplaceSpecialCharacter(Search_EntityType, "'", "");
                                ////Search_NativeName = WLAlgorithmHelper.ReplaceSpecialCharacter(Search_NativeName, "'", "");

                                Search_Country = watchlistAlgorithmManager.ReplaceSpecialCharacter(Search_Country, "'", "");
                                Search_Gender = watchlistAlgorithmManager.ReplaceSpecialCharacter(Search_Gender, "'", "");
                                Search_EntityType = watchlistAlgorithmManager.ReplaceSpecialCharacter(Search_EntityType, "'", "");
                                Search_NativeName = watchlistAlgorithmManager.ReplaceSpecialCharacter(Search_NativeName, "'", "");

                                var strACCOUNT_NAME = "";
                                var strSQLWatchListSearchText = "";
                                var strSearchStringIDStmt = "";
                                var strSqlFullStmtForEntityName = "";
                                var strFullTextSQLStmtId = "";
                                var strFullTextSQLStmtId2 = "";
                                var strFullTextSQLStmtName = "";
                                var strFullTextSQLStmtName2 = "";
                                var strFullTextSQLStmtFinal = "";

                                switch (strWatchlistSource)
                                {
                                    case WatchListSource.DOWJONES:
                                        strFullTextSQLStmtId = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID_DowJones);
                                        strFullTextSQLStmtId2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID2_DowJones);
                                        strFullTextSQLStmtName = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name_DowJones);
                                        strFullTextSQLStmtName2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name2_DowJones);
                                        break;
                                    case WatchListSource.OFAC:
                                        strFullTextSQLStmtId = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID_OFAC);
                                        strFullTextSQLStmtId2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID2_OFAC);
                                        strFullTextSQLStmtName = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name_OFAC);
                                        strFullTextSQLStmtName2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name2_OFAC);
                                        break;
                                    case WatchListSource.WORLDCHECK:
                                        strFullTextSQLStmtId = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID_WorldCheck);
                                        strFullTextSQLStmtId2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID2_WorldCheck);
                                        strFullTextSQLStmtName = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name_WorldCheck);
                                        strFullTextSQLStmtName2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name2_WorldCheck);
                                        break;
                                    case WatchListSource.LEXISNEXIS:
                                        strFullTextSQLStmtId = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID_LexisNexis);
                                        strFullTextSQLStmtId2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_ID2_LexisNexis);
                                        strFullTextSQLStmtName = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name_LexisNexis);
                                        strFullTextSQLStmtName2 = WatchlistQuery.GetStatement(WatchlistQuery.SqlCase.FullTextSql_Name2_LexisNexis);
                                        break;
                                }

                                if (!String.IsNullOrEmpty(Search_Name))
                                {
                                    ////Search_Name = WLAlgorithmHelper.Process(Search_Name, WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_NAME
                                    ////                                    , WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_NAME);
                                    Search_Name = watchlistAlgorithmManager.Process(Search_Name, WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_NAME
                                                                        , WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_NAME);
                                    strACCOUNT_NAME = Search_Name;
                                    strSQLWatchListSearchText = Search_Name.ToUpper();
                                    Search_Name = watchlistAlgorithmManager.Process(Search_Name, WatchListAlgorithmType.FILTER_STOP_LIST_TABLE);

                                    var arrSearch_Name = Search_Name.Split(' ').ToList();
                                    if (arrSearch_Name.Count > 1)
                                    {
                                        arrSearch_Name.Reverse();
                                        strSqlFullStmtForEntityName = String.Format("\"{0}\" or \"{1}\"", Search_Name, String.Join(" ", arrSearch_Name));
                                    }
                                    else
                                        strSqlFullStmtForEntityName = String.Format("\"{0}\"", arrSearch_Name);

                                    var strSqlLikeStmtForEntityName = "";
                                    foreach (var word in arrSearch_Name.Select(l => l.Length > 3)) ////Word length greater than 3 only
                                        strSqlLikeStmtForEntityName += String.Format("\"{0}*\" or \"*{1}\"", word, word);

                                    strFullTextSQLStmtName = String.Format(strFullTextSQLStmtName, strSqlFullStmtForEntityName);
                                    strFullTextSQLStmtName2 = String.Format(strFullTextSQLStmtName2, strSqlLikeStmtForEntityName);

                                    if (String.IsNullOrEmpty(strSqlLikeStmtForEntityName))
                                        strFullTextSQLStmtName += ") AS SCAN_DS_NAME1";
                                    else
                                        strFullTextSQLStmtName += " Union All " + strFullTextSQLStmtName2;
                                }
                                else
                                {
                                    strFullTextSQLStmtName = null;
                                    strFullTextSQLStmtName2 = null;
                                }
                                if (!String.IsNullOrEmpty(Search_ID))
                                {
                                    strSearchStringIDStmt = "\"" + Search_ID + "\"";

                                    var Search_ID_Ori = Search_ID;
                                    //Search_ID = WLAlgorithmHelper.Process(Search_ID, WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID
                                    //                                    , WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID);
                                    Search_ID = watchlistAlgorithmManager.Process(Search_ID, WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID
                                                                        , WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID);

                                    if (Search_ID_Ori != Search_ID)
                                        strSearchStringIDStmt += " or \"" + Search_ID + "\"";

                                    strFullTextSQLStmtId = String.Format(strFullTextSQLStmtId, strSearchStringIDStmt);

                                    strACCOUNT_NAME += " / " + Search_ID;
                                    strACCOUNT_NAME = strACCOUNT_NAME.Length > 100 ? strACCOUNT_NAME.Substring(0, 100) : strACCOUNT_NAME;
                                    strSQLWatchListSearchText += " / " + Search_ID;
                                }
                                else
                                    strFullTextSQLStmtId = null;

                                strFullTextSQLStmtFinal = String.Join(" union all", strFullTextSQLStmtId, strFullTextSQLStmtName);  ////!!!!!!NOT IN USE...WHY????

                                ////---------------------------------------------------------

                                if (String.IsNullOrEmpty(Search_ID))
                                {
                                    var lsAW_NAME = context.Database.SqlQuery<AW_NAME>(strFullTextSQLStmtId2, new SqlParameter("Search_EntityType", Search_EntityType)
                                                                                                            , new SqlParameter("strSearchStringIDStmt", strSearchStringIDStmt)).ToList();

                                    //bool bolID_HIT = false;
                                    //var intMatchScore = int.Parse(WLAlgorithmHelper.GetValue(WatchlistAlgorithmHelper.WatchListAlgorithmType.MATCH_SCORE) ?? "60");
                                    var intMatchScore = int.Parse(watchlistAlgorithmManager.GetValue(WatchListAlgorithmType.MATCH_SCORE) ?? "60");

                                    #region Get Filtering Setting ES

                                    var strFilterPEP = "";
                                    var strFilterSIPSIE = "";
                                    var strFilterCategory = "";
                                    var strFilterSubCategory = "";
                                    var strFilterSanction = "";
                                    var arrFilterCategory = new List<string>();
                                    var arrFilterSanction = new List<string>();

                                    if (GlobalVariables.AppSetting_FilterSetting != 0)
                                    {
                                        var AlgorithmCategory = context.WatchlistAlgorithmCAT
                                                                .Where(l => l.COMP_CODE == GlobalVariables.AppSetting_CompCode &&
                                                                        l.CATEGROY_TYPE == GlobalVariables.AppSetting_FilterSetting)
                                                                .OrderBy(l => l.CATEGROY_TYPE).FirstOrDefault();

                                        if (!String.IsNullOrEmpty(AlgorithmCategory.CAT1) && AlgorithmCategory.CAT1.ToUpper() != "ALL")
                                            strFilterPEP = (strWatchlistSource == WatchListSource.DOWJONES && AlgorithmCategory.CAT1 == "|A11|") ? "|11|,|12|" : AlgorithmCategory.CAT1;
                                        if (!String.IsNullOrEmpty(AlgorithmCategory.CAT2) && AlgorithmCategory.CAT2.ToUpper() != "ALL")
                                            strFilterSIPSIE = (strWatchlistSource == WatchListSource.DOWJONES && AlgorithmCategory.CAT2 == "|A13|") ? "|13|,|14|,|15|,|16|" : AlgorithmCategory.CAT2;

                                        if (!String.IsNullOrEmpty(strFilterPEP.Trim()))
                                            arrFilterCategory.AddRange(strFilterPEP.Split(','));
                                        if (!String.IsNullOrEmpty(strFilterSIPSIE.Trim()))
                                            arrFilterCategory.AddRange(strFilterSIPSIE.Split(','));
                                        strFilterCategory = String.Join(",", arrFilterCategory);

                                        strFilterSubCategory = AlgorithmCategory.CAT3 ?? AlgorithmCategory.CAT3;
                                        strFilterSanction = (!String.IsNullOrEmpty(AlgorithmCategory.CAT4) && AlgorithmCategory.CAT4.ToUpper() != "ALL") ? AlgorithmCategory.CAT4 : "";
                                        if (!String.IsNullOrEmpty(strFilterSanction.Trim()))
                                            arrFilterSanction.AddRange(strFilterSanction.Split(','));

                                    }

                                    #endregion

                                    var dsTemp = new DataSet();

                                    foreach (var item in lsAW_NAME)
                                    {
                                        double intScoring = 0;
                                        item.IS_ID_HIT = false;
                                        item.IS_PEP_HIT = false;
                                        item.IS_SANCTION_HIT = false;

                                        if (item.ID_VALUE == Search_ID)
                                            intScoring = 100;
                                        else
                                        {
                                            ////var strModifyText = WLAlgorithmHelper.Process(item.ID_VALUE, WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID
                                            ////                                                            , WatchlistAlgorithmHelper.WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID);
                                            var strModifyText = watchlistAlgorithmManager.Process(item.ID_VALUE, WatchListAlgorithmType.FILTER_REMOVE_SPECIAL_CHAR_ID
                                                                                                        , WatchListAlgorithmType.FILTER_REPLACE_SPECIAL_CHAR_ID);
                                            intScoring = StringHelper.CompareStringSimilarity(Search_ID, strModifyText);
                                        }

                                        if (intScoring >= intMatchScore)
                                        {
                                            item.IS_ID_HIT = true;
                                            //bolID_HIT = true;
                                            item.PERCENTAGE = 0;
                                        }

                                        if (new[] { "DJ", "DJSOC", "DJAME", "DJAME", "LEXISNEXIS" }.Contains(item.INFO_SOURCE))
                                        {
                                            if (arrFilterCategory.Contains(item.CATEGORY1))
                                                item.IS_PEP_HIT = true;

                                            if (arrFilterSanction.Contains(item.SANCTION))
                                                item.IS_SANCTION_HIT = true;
                                        }


                                        ////--------------------------------------------------

                                        var APIProperties = APIManager.GetAPIProperties(context, GlobalVariables.AppSetting_CompCode);
                                        var content = String.Format("name={0}&entity={1}&country={2}&categorynum={3}&sanction={4}&gender={5}&nativename={6}"
                                                        , HttpUtility.UrlEncode(Search_Name)
                                                        , HttpUtility.UrlEncode(Search_EntityType)
                                                        , HttpUtility.UrlEncode(Search_Country)
                                                        , HttpUtility.UrlEncode(strFilterCategory)
                                                        , HttpUtility.UrlEncode(strFilterSanction)
                                                        , HttpUtility.UrlEncode(Search_Gender)
                                                        , HttpUtility.UrlEncode(Search_NativeName));
                                        var jsonString = APIManager.Post(APIProperties, "search/wl", content);

                                        ////-----------------------------------------------------

                                        #region Process ES Search Result

                                        var responseMsgData2 = JsonConvert.DeserializeXmlNode(jsonString, "ES");
                                        var sw = new StringWriter();
                                        var xw = new XmlTextWriter(sw);
                                        responseMsgData2.WriteTo(xw);
                                        var theReader = new StringReader(sw.ToString());

                                        dsTemp.ReadXml(theReader, XmlReadMode.Auto);

                                        if (dsTemp.Tables.Count == 1)
                                        {
                                            var dt = new DataTable();
                                            dt.Columns.Add("colNO", typeof(string));
                                            dt.Columns.Add("ENTITY_ID", typeof(string));
                                            dt.Columns.Add("SYS_ID", typeof(string));
                                            dt.Columns.Add("INFO_SOURCE", typeof(string));
                                            dt.Columns.Add("ENTITY_TYPE", typeof(string));
                                            dt.Columns.Add("NAME_TYPE", typeof(string));
                                            dt.Columns.Add("SINGLE_STRING_NAME2", typeof(string));
                                            dt.Columns.Add("GENDER", typeof(string));
                                            dt.Columns.Add("CATEGORY", typeof(string));
                                            dt.Columns.Add("DOB", typeof(string));
                                            dt.Columns.Add("COUNTRY", typeof(string));
                                            dt.Columns.Add("CATEGORY1", typeof(string));
                                            dt.Columns.Add("CATEGORY2", typeof(string));
                                            dt.Columns.Add("NAMESOURCE", typeof(string));
                                            dt.Columns.Add("SANCTION", typeof(string));
                                            dt.Columns.Add("MATCH", typeof(string));
                                            dt.Columns.Add("NAME_HIT", typeof(string));
                                            dt.Columns.Add("ID_HIT", typeof(string));
                                            dt.Columns.Add("ID_VALUE", typeof(string));
                                            dt.Columns["colNO"].DefaultValue = 0;

                                            var lsHitNames = lsAW_NAME.Where(l => l.IS_ID_HIT == true && l.IS_PEP_HIT == true && l.IS_SANCTION_HIT == true);
                                            var strBaseCurrency = context.cor_parameter.Where(l => l.cor_comp_code == GlobalVariables.AppSetting_CompCode).FirstOrDefault()?.cor_curr_cd;   ////check if null
                                            var intSEQ_NO = 0;
                                            var strTABLE_NAME_USED = "";
                                            var intNoOfTotalHits = lsHitNames.Count();
                                            var intNoOfIdHits = lsAW_NAME.Where(l => l.IS_ID_HIT == true).ToList().Count();
                                            //var intNoOfNameHits = lsAW_NAME.Where(l => l.NAME_HIT == "1").ToList().Count();

                                            foreach (var aw_name in lsHitNames)
                                            {
                                                intSEQ_NO++;
                                                
                                                if (BuildSql_Header.TABLE_PARENT_ID == 1)
                                                    strTABLE_NAME_USED = BatchJob.lsJobProcess.JOB_HIST_TABLE;
                                                else if (BuildSql_Header.TABLE_PARENT_ID == 2)
                                                    strTABLE_NAME_USED = BatchJob.lsJobProcess.JOB_ACCT_TABLE;
                                                else if (BuildSql_Header.TABLE_PARENT_ID == 3)
                                                    strTABLE_NAME_USED = BatchJob.lsJobProcess.JOB_CIF_TABLE;
                                                else
                                                    strTABLE_NAME_USED = BatchJob.lsJobProcess.JOB_ADDR_TABLE;

                                                SaveDetails(context, intSEQ_NO, aw_name, strACCOUNT_NO, strACCOUNT_NAME, strCIF_ID, BatchJob.lsParam, strREC_TYPE, GROUPINGLINK_INFO
                                                    , BatchJob.lsJobProcess, watchlist, strBaseCurrency, strTABLE_NAME_USED, strWatchlistFieldUsed, strSQLWatchListSearchText
                                                    , intNoOfTotalHits, intNoOfIdHits, BatchJob.intNewBatchNo, BatchJob.strNewBatchNo);
                                            }
                                        }
                                        else if (dsTemp.Tables.Count == 2)
                                        { 
                                        
                                        }

                                        #endregion
                                    }


                                }
                            }
                        }
                        else
                            throw new Exception("Error: Sql Header not setup");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unhandled exception", ex);
                    }

                    transaction.Commit();
                }
            }
            
        }

        private static void SaveDetails(CommonContext context, int intSEQ_NO, AW_NAME aw_name, string strACCOUNT_NO, string strACCOUNT_NAME, string strCIF_ID, _PARAM param
            , string strREC_TYPE, GROUPINGLINK_INFO grouplink, _CONFIGJOBPROCESS config, WatchlistResult watchlist, string strLOCAL_CURRENCY, string strTABLE_NAME_USED
            , string strWatchlistFieldUsed, string strSQLWatchListSearchText, int intNoOfTotalHits, int intNoOfIdHits, int intALERT_ID, string strBATCH_NO)
        {
            //var AlertTranTableName;
            //var AlertTranDtlTableName;
            //var AlertTranWlistTableName;

            ////var intALERT_ID = BatchJobHelper.GetNewBatchNo(context, GlobalVariables.AppSetting_CompCode);
            ////var strBATCH_NO = param.CURRENT_PROCESS_DATE + "-" + intALERT_ID.ToString("D4");
            var dtCurrentDT = DateTime.Now;

            var intCurrentDt = int.Parse(dtCurrentDT.ToString("yyyyMMdd"));
            var intCurrentTime = int.Parse(dtCurrentDT.ToString("HHmmss"));
            var strHIT_RL_RISK_LEVEL = "";
            var strBR_CODE = GlobalVariables.AppSetting_AssignBrInd == "1" ? watchlist.BR_CODE_CIF : GlobalVariables.AppSetting_AssignToBrCode;

            if (grouplink.GRP_RANK == 1)
                strHIT_RL_RISK_LEVEL = "LOW";
            else if (grouplink.GRP_RANK == 3)
                strHIT_RL_RISK_LEVEL = "MEDUIM";
            else if (grouplink.GRP_RANK > 3)
                strHIT_RL_RISK_LEVEL = "HIGH";

            if (GlobalVariables.AppSetting_AlertTranTableGroup == "1")
            {
                //AlertTranTableName = new _ALERTWLTRAN();
                //AlertTranDtlTableName = new _ALERTWLTRANDTLHIT();
                //AlertTranWlistTableName = new _ALERTWLTRANWLIST();
                //AlertTranWlistDtlTableName = new _ALERTWLTRANWLISTDTL();

                context.ALERTWLTRANWLISTDTL.Add(new _ALERTWLTRANWLISTDTL()
                                                    {
                                                        COMP_CODE = ((Int16)GlobalVariables.AppSetting_CompCode),
                                                        ////ALERT_ID = BatchJobHelper.GetNewBatchNo(context, GlobalVariables.AppSetting_CompCode),
                                                        ALERT_ID = intALERT_ID,
                                                        ENTITY_ID = aw_name.ENTITY_ID,
                                                        SYS_ID = aw_name.SYS_ID,
                                                        HIT_ID_OR_NAME = ((Int16)(aw_name.NAME_HIT == "1" ? 1 : 0)),
                                                        INFO_SOURCE = aw_name.INFO_SOURCE,
                                                        NAME_TYPE = aw_name.NAME_TYPE,
                                                        SINGLE_STRING_NAME = aw_name.SINGLE_STRING_NAME,
                                                        ID_VALUE = aw_name.ID_VALUE,
                                                        COUNTRY = aw_name.COUNTRY,
                                                        DOBS = aw_name.DOB,
                                                        CATEGORY = aw_name.CATEGORY,
                                                        NAMESOURCE = aw_name.NAMESOURCE,
                                                        MATCH_PERCENT = 0,
                                                        INVESTIGATE_STATUS = 0,
                                                        TYPE_OF_EXPOSITION = 0,
                                                        REMARKS = "",
                                                        LAST_UPT_DATE = int.Parse(DateTime.Now.ToString("yyyyMMdd")),
                                                        LAST_UPT_TIME = int.Parse(DateTime.Now.ToString("hhmmss")),
                                                        ACCOUNT_NO = strACCOUNT_NO,
                                                        CIF_ID = strCIF_ID,
                                                        FALSE_POSITIVE_IND = 1,
                                                        BATCH_DATE = param.CURRENT_PROCESS_DATE,
                                                        USER_ID = "None",
                                                        MODE_MN = "A",
                                                        GENDER = aw_name.GENDER,
                                                        ////The following fields ot exists in database
                                                        //ORIGINAL_SCRIPT_NAME = aw_name.ORIGINAL_SCRIPT_NAME,
                                                        //MATCH = aw_name.MATCH,
                                                        //SUBCATEGORY = aw_name.CATEGORY2,
                                                        //SANCTION = aw_name.SANCTION,
                                                        //ENTITY_TYPE = aw_name.ENTITY_TYPE,
                                                        //CATEGORYNUM = aw_name.CATEGORY1,
                                                    });

                context.ALERTWLTRAN.Add(new _ALERTWLTRAN());

                context.ALERTWLTRANDTLHIT.Add(new _ALERTWLTRANDTLHIT());

                context.ALERTWLTRANWLIST.Add(new _ALERTWLTRANWLIST());

            }
            else
            {
                //AlertTranTableName = new _ALERTTRAN();
                //AlertTranDtlTableName = new _ALERTTRANDTLHIT();
                //AlertTranWlistTableName = new _ALERTTRANWLIST();
                //AlertTranWlistDtlTableName = new _ALERTTRANWLISTDTL();

                context.ALERTTRANWLISTDTL.Add(new _ALERTTRANWLISTDTL() {
                    COMP_CODE = ((Int16)GlobalVariables.AppSetting_CompCode),
                    ALERT_ID = intALERT_ID,
                    ENTITY_ID = aw_name.ENTITY_ID,
                    SYS_ID = aw_name.SYS_ID,
                    HIT_ID_OR_NAME = ((Int16)(aw_name.NAME_HIT == "1" ? 1 : 0)),
                    INFO_SOURCE = aw_name.INFO_SOURCE,
                    NAME_TYPE = aw_name.NAME_TYPE,
                    SINGLE_STRING_NAME = aw_name.SINGLE_STRING_NAME,
                    ID_VALUE = aw_name.ID_VALUE,
                    COUNTRY = aw_name.COUNTRY,
                    DOBS = aw_name.DOB,
                    CATEGORY = aw_name.CATEGORY,
                    NAMESOURCE = aw_name.NAMESOURCE,
                    MATCH_PERCENT = 0,
                    INVESTIGATE_STATUS = 0,
                    TYPE_OF_EXPOSITION = 0,
                    REMARKS = "",
                    LAST_UPT_DATE = int.Parse(DateTime.Now.ToString("yyyyMMdd")),
                    LAST_UPT_TIME = int.Parse(DateTime.Now.ToString("hhmmss")),
                    ACCOUNT_NO = strACCOUNT_NO,
                    CIF_ID = strCIF_ID,
                    FALSE_POSITIVE_IND = 1,
                    BATCH_DATE = param.CURRENT_PROCESS_DATE,
                    USER_ID = "None",
                    MODE_MN = "A",
                    GENDER = aw_name.GENDER,
                    ////The following fields ot exists in database
                    //ORIGINAL_SCRIPT_NAME = aw_name.ORIGINAL_SCRIPT_NAME,
                    //MATCH = aw_name.MATCH,
                    //SUBCATEGORY = aw_name.CATEGORY2,
                    //SANCTION = aw_name.SANCTION,
                    //ENTITY_TYPE = aw_name.ENTITY_TYPE,
                    //CATEGORYNUM = aw_name.CATEGORY1,
                });

                context.ALERTTRAN.Add(new _ALERTTRAN() {
                    COMP_CODE = ((Int16)GlobalVariables.AppSetting_CompCode),
                    ALERT_ID = intALERT_ID,
                    REC_TYPE = strREC_TYPE,
                    REC_IDENTITY_NO = strBATCH_NO,
                    HIT_DATE = intCurrentDt,
                    HIT_GRP_ID = grouplink.GRP_ID,
                    HIT_ER_ID = grouplink.ER_ID,
                    HIT_ER_NAME = grouplink.ER_NAME,
                    HIT_ER_THRESHOLD = grouplink.ER_THRESHOLD,
                    HIT_EQ_ID = grouplink.EQ_ID,
                    HIT_EQ_WEIGHT = grouplink.EQ_WEIGHT,
                    HIT_EQ_NO_OF_DAYS = 0,
                    HIT_EQ_ID_MULTIPLE = String.Format("NA;{0};{1};NA;{2};NA;NA;", config.JOB_ACCT_TABLE, config.JOB_HIST_TABLE, config.JOB_HIT_TRAN_TABLE),
                    HIT_RL_RISK_LEVEL = strHIT_RL_RISK_LEVEL,
                    HIT_ASSESSMENT_IND = "0000",
                    HIT_RANKING = grouplink.GRP_RANK,
                    ACCOUNT_NO = strACCOUNT_NO,
                    ACCOUNT_NAME = strACCOUNT_NAME,
                    CIF_ID = strCIF_ID,
                    CREDIT_DEBIT = 3,
                    TRAN_DATE = intCurrentDt,
                    POSTING_DATE = intCurrentDt,
                    VALUE_DATE = intCurrentDt,
                    TRAN_CODE = GlobalVariables.AppSetting_AlertTranCode,
                    BR_CODE = strBR_CODE,
                    ALERT_BR = strBR_CODE,
                    TRAN_LOCATION = strBR_CODE,
                    TRANS_COUNT = 0,
                    LOCAL_AMOUNT = 0,//????
                    FOREIGN_AMOUNT = 0,
                    LOCAL_CURRENCY = strLOCAL_CURRENCY,
                    FX_RATE = 0,
                    TRAN_REVERSAL_IND = 0,
                    REFERANCE_NO = "",
                    REFERANCE_DT = "",
                    PRODUCT_CODE = config.JOB_PRODUCT_CODE,
                    PRIMARY_ALERT_REC = 0,
                    STATUS = 100,
                    LAST_STATUS = 100,
                    STATUS_UPT_DT = 0,
                    USER_UPT_COUNT = 0,
                    ACTION_GUIDE_NO = grouplink.GRP_ACTION_GUIDE_NO,
                    ALERT_HIT_STATUS = 1,
                    DISMISS_IND = 0,
                    DISMISS_DATE = 0,
                    DISMISS_TIME = 0,
                    DISMISS_VIEW_DATE = 0,
                    DISMISS_VIEW_TIME = 0,
                    DISMISS_VIEW_BY = "",
                    ESTABLISH_DATE = intCurrentDt,
                    ESTABLISH_TIME = intCurrentTime,
                    LAST_UPT_DATE = 0,
                    LAST_UPT_TIME = 0,
                    HQ_TRAN_IND = 0,
                    STAFF_IND = 0,
                    AML_FRAUD_IND = "A",
                    BATCH_DATE = param.CURRENT_PROCESS_DATE,
                    BATCH_NO = strBATCH_NO,
                    RUSER_ID = "None",
                    ////The following fields ot exists in database
                    //Stamp_DtTm = dtCurrentDT,
                    //User_Id = gstrUserId,
                    //Mode_Mn = "A"
                });

                context.ALERTTRANDTLHIT.Add(new _ALERTTRANDTLHIT() {
                    COMP_CODE = ((Int16)GlobalVariables.AppSetting_CompCode),
                    ALERT_ID = intALERT_ID,
                    ALERT_SEQNO = 1,
                    HIT_DTL_GRP_ID = grouplink.GRP_ID,
                    HIT_DTL_ER_ID = grouplink.ER_ID,
                    HIT_DTL_ER_THRESHOLD = grouplink.ER_THRESHOLD,
                    HIT_DTL_ER_RANK = grouplink.ER_RANK,
                    HIT_DTL_EQ_RULE_TYPE = grouplink.EQ_RULE_TYPE,
                    HIT_DTL_EQ_NAME = grouplink.EQ_NAME,
                    HIT_DTL_EQ_ID = grouplink.EQ_ID,
                    HIT_DTL_EQ_WEIGHT = grouplink.ER_COMPUTED_THRESHOLD,
                    HIT_DTL_EQ_NO_OF_DAYS = 0,
                    TRAN_DATE = intCurrentDt,
                    CREDIT_DEBIT = 3,
                    TRAN_CODE = GlobalVariables.AppSetting_AlertTranCode,
                    LOCAL_CURRENCY = strLOCAL_CURRENCY,
                    FX_RATE = 0,
                    TRANS_COUNT = 0,
                    LOCAL_AMOUNT = 0,
                    FOREIGN_AMOUNT = 0,
                    HIST_TRANS_COUNT = 0,
                    HIST_LOCAL_AMOUNT = 0,
                    HIST_FOREIGN_AMOUNT = 0,
                    HIT_STATUS = 1,
                    ACCOUNT_NO = strACCOUNT_NO,
                    FILTER_TRANHIST_STATUS = 0,
                    TRANHIST_SQL_STMT = "",
                    BATCH_DATE = param.CURRENT_PROCESS_DATE,
                    BATCH_NO = strBATCH_NO,
                    ////The following fields ot exists in database
                    //Stamp_DtTm = dtCurrentDT,
                    //User_Id = gstrUserId,
                    //Mode_Mn = "A"
                });

                context.ALERTTRANWLIST.Add(new _ALERTTRANWLIST() {

                    COMP_CODE = ((Int16)GlobalVariables.AppSetting_CompCode),
                    ALERT_ID = intALERT_ID,
                    SEQ_NO = intSEQ_NO,
                    SEARCH_TYPE = "T",
                    TABLE_NAME_USED = strTABLE_NAME_USED,
                    KEY_FIELD1 = strCIF_ID,
                    KEY_FIELD2 = strACCOUNT_NO,
                    SQL_WATCHLIST_FD_USED = strWatchlistFieldUsed,
                    SQL_SEARCH_STMT = strSQLWatchListSearchText,
                    WATCH_LIST_HIT = "",
                    NO_OF_ROWS_HIT = intNoOfTotalHits,
                    NAME_HIT = intNoOfIdHits,
                    ID_HIT = intNoOfIdHits,
                    BATCH_DATE = param.CURRENT_PROCESS_DATE,
                    BATCH_NO = strBATCH_NO,
                    CIF_ID = strCIF_ID,
                    DETECTION_METHOD = grouplink.ER_DETECTION_METHOD,
                    WATCH_LIST_SCORE1 = 0,
                    WATCH_LIST_SCORE2 = 0,
                    WATCH_LIST_SCORE3 = 0,
                    WATCH_LIST_SCORE4 = 0,
                    WATCH_LIST_SCORE5 = 0,
                    WATCH_LIST_SCORE6 = 0,
                    WATCH_LIST_SCORE7 = 0,
                    WATCH_LIST_SCORE8 = 0,
                    WATCH_LIST_SCORE9 = 0,
                    WATCH_LIST_SCORE10 = 0,
                    WATCH_LIST_SCORE11 = 0,
                    WATCH_LIST_SCORE12 = 0,
                    WATCH_LIST_SCORE13 = 0,
                    WATCH_LIST_SCORE14 = 0,
                    WATCH_LIST_SCORE15 = 0,
                    WATCH_LIST_SCORE16 = 0,
                    EQ_AND_OR_STRING = grouplink.EQ_AND_OR_STRING,
                    EQ_APPLY_FULL_MATCH = 0,
                    EQ_APPLY_SOUNDEX = grouplink.EQ_APPLY_SOUNDEX,
                    STAMP_DTTM = dtCurrentDT,
                    USER_ID = "None",
                    MODE_MN = "A"
                });

            }

            context.SaveChanges();
        }

        public enum WatchListSource
        {
            DOWJONES, WORLDCHECK, OFAC, LEXISNEXIS
        }
        //public enum WatchListAlgorithmType : Int16
        //{
        //    RANK_SCORE = 1, MATCH_SCORE = 2, FILTER_SCRIPT_NAME = 4,
        //    STRING_EDIT_DISTANT = 5, FILTER_MULTI_WORD_SCORE = 6, WORD_EDIT_DISTANT = 7,
        //    SHOW_ALL_HIT_RESULT_FOR_ONE_WORD = 8, LENGTH_OF_IN_NAME_ALLOW = 9, LENGTH_OF_IN_WORD_ALLOW = 10,
        //    FILTER_REMOVE_SPECIAL_CHAR_NAME = 11, FILTER_REPLACE_SPECIAL_CHAR_NAME = 12, FILTER_REMOVE_SPECIAL_CHAR_ID = 13,
        //    FILTER_REPLACE_SPECIAL_CHAR_ID = 14, REMOVE_NON_NUMEIRIC_CHAR_IN_ID_FIELD = 15, CONTROL_FALSE_POS_RESULT = 16,
        //    FILTER_STOP_LIST_TABLE = 17, SHOW_GENDER = 18, SHOW_HIGH_RISK_COUNTRY = 25, VERIFY_DOB = 36
        //}
        //public enum MultiWordFilteringScoreType : Int16
        //{
        //    FullHit = 10, Score1_1 = 11, Score1_2 = 21, Score2_2 = 22, Score1_3 = 31, Score2_3 = 32, Score3_3 = 33, Score1_4 = 41, Score2_4 = 42, Score3_4 = 43, Score4_4 = 44
        //}
    }
}
