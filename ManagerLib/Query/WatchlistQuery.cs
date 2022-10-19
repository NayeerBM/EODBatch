using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLib.Query
{
    public class WatchlistQuery
    {
        public enum SqlCase
        {
            Delete_ATEMPALERTTRANWLISTDTL
            , Truncate_ATEMPALERTTRANWLISTDTL
            , GetGroupingLinkInfo
            , BuildSql_Header
            , BuildSql_Details
            , FullTextSql_ID_DowJones
            , FullTextSql_ID_WorldCheck
            , FullTextSql_ID_OFAC
            , FullTextSql_ID_LexisNexis
            , FullTextSql_ID2_DowJones
            , FullTextSql_ID2_WorldCheck
            , FullTextSql_ID2_OFAC
            , FullTextSql_ID2_LexisNexis
            , FullTextSql_Name_DowJones
            , FullTextSql_Name_WorldCheck
            , FullTextSql_Name_OFAC
            , FullTextSql_Name_LexisNexis
            , FullTextSql_Name2_DowJones
            , FullTextSql_Name2_WorldCheck
            , FullTextSql_Name2_OFAC
            , FullTextSql_Name2_LexisNexis
            , GetWatchlistAlgorithmDetails
            , GetWatchlistAlgorithmCat
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";
            switch (sqlCase)
            {
                //case SqlCase.GetJobProcess:
                //    sqlStatement = "select JOB_ACCT_TABLE, JOB_CIF_TABLE, JOB_HIST_TABLE, JOB_ADDR_TABLE, JOB_HIT_TRAN_TABLE, JOB_TASK_ID, JOB_PROCESSOR_TYPE" + Environment.NewLine +
                //                    "from CONFIGJOBPROCESS " + Environment.NewLine +
                //                    "where COMP_CODE=@CompCode" + Environment.NewLine +
                //                    "and JOB_CODE=@JobCode";
                //    break;

                case SqlCase.Delete_ATEMPALERTTRANWLISTDTL:
                    sqlStatement = "delete from ATEMPALERTTRANWLISTDTL";
                    break;
                case SqlCase.Truncate_ATEMPALERTTRANWLISTDTL:
                    sqlStatement = "truncate table ATEMPALERTTRANWLISTDTL";
                    break;

                case SqlCase.GetGroupingLinkInfo:
                    #region
                    sqlStatement = "Select GROUPINGLINK.COMP_CODE, GROUPMASTER.GRP_ID, ISNULL(GROUPMASTER.GRP_RANK, 0) as GRP_RANK, EXPERTRULE.ER_DETECTION_METHOD, GROUPMASTER.GRP_FILTER_STATUS, GROUPMASTER.GRP_ACTION_GUIDE_NO" + Environment.NewLine +
                                    "	, IIF(GROUPMASTER.GRP_FILTER_STATUS = '1', ' and ' + ISNULL(REPLACE(GROUPMASTER.GRP_FILTER_SQL_STMT, '|', ''''), ''), '') as GRP_FILTER_SQL_STMT" + Environment.NewLine +
                                    "	, IIF(GROUPMASTER.GRP_FILTER_ACCT_STATUS = '1', ' and ' + ISNULL(REPLACE(GROUPMASTER.GRP_ACCT_SQL_STMT, '|', ''''), ''), '') as GRP_ACCT_SQL_STMT" + Environment.NewLine +
                                    "	, IIF(GROUPMASTER.GRP_FILTER_HIST_STATUS = '1', ' and ' + ISNULL(REPLACE(GROUPMASTER.GRP_HIST_SQL_STMT, '|', ''''), ''), '') as GRP_HIST_SQL_STMT" + Environment.NewLine +
                                    "	, EXPERTRULE.ER_ID, EXPERTRULE.ER_NAME, EXPERTRULE.ER_THRESHOLD, EXPERTRULE.ER_COMPUTED_THRESHOLD, EXPERTRULE.ER_RANK, EQUATION.EQ_ID, EQUATION.EQ_NAME, EQUATION.EQ_RULE_TYPE, EQUATION.EQ_WEIGHT, EQUATION.EQ_LIST_PERCENT1, EQUATION.EQ_LIST_PERCENT2, EQUATION.EQ_LIST_PERCENT3, EQUATION.EQ_LIST_PERCENT4" + Environment.NewLine +
                                    "	, EQUATION.EQ_LIST_PERCENT5, EQUATION.EQ_LIST_PERCENT6, EQUATION.EQ_LIST_PERCENT7, EQUATION.EQ_LIST_PERCENT8" + Environment.NewLine +
                                    "	, EQUATION.EQ_LIST_PERCENT9, EQUATION.EQ_LIST_PERCENT10, EQUATION.EQ_LIST_PERCENT11, EQUATION.EQ_LIST_PERCENT12" + Environment.NewLine +
                                    "	, EQUATION.EQ_LIST_PERCENT13, EQUATION.EQ_LIST_PERCENT14, EQUATION.EQ_LIST_PERCENT15, EQUATION.EQ_LIST_PERCENT16" + Environment.NewLine +
                                    "FROM GROUPINGLINK" + Environment.NewLine +
                                    "INNER JOIN GROUPMASTER		ON GROUPINGLINK.COMP_CODE = GROUPMASTER.COMP_CODE		AND GROUPINGLINK.GROUPING_ID = GROUPMASTER.GRP_ID" + Environment.NewLine +
                                    "INNER JOIN GROUPTASKLINK	ON GROUPINGLINK.COMP_CODE = GROUPTASKLINK.COMP_CODE		AND GROUPINGLINK.GROUPING_ID = GROUPTASKLINK.TASK_GROUP_ID" + Environment.NewLine +
                                    "INNER JOIN EXPERTRULE		ON GROUPINGLINK.COMP_CODE = EXPERTRULE.COMP_CODE		AND GROUPINGLINK.GROUPING_LINK_ID = EXPERTRULE.ER_ID" + Environment.NewLine +
                                    "INNER JOIN EXPERTRULEEQLINK ON GROUPINGLINK.COMP_CODE = EXPERTRULEEQLINK.COMP_CODE	AND EXPERTRULE.ER_ID = EXPERTRULEEQLINK.LINK_ER_ID" + Environment.NewLine +
                                    "INNER JOIN EQUATION			ON GROUPINGLINK.COMP_CODE = EQUATION.COMP_CODE			AND EXPERTRULEEQLINK.LINK_EQ_ID = EQUATION.EQ_ID" + Environment.NewLine +
                                    "Where GROUPINGLINK.COMP_CODE=@CompCode" + Environment.NewLine +
                                    "And GROUPTASKLINK.TASK_ID=@JobCode" + Environment.NewLine +
                                    "And GROUPINGLINK.GROUPING_TYPE=@GroupingType" + Environment.NewLine +
                                    "And GROUPMASTER.GRP_STATUS=0" + Environment.NewLine +
                                    "And EXPERTRULE.ER_STATUS = 0";
                    #endregion

                    break;

                case SqlCase.BuildSql_Header:
                    #region
                    sqlStatement = "select hdr.WATCHLIST_SOURCE, hdr.TABLE_PARENT_ID" + Environment.NewLine +
                                    "       , strWatchlistType = " + Environment.NewLine +
                                    "           (CASE WHEN WATCHLIST_SOURCE IN ('DOWJONES','DJ') THEN 'DJ' WHEN WATCHLIST_SOURCE IN ('WCHECK','WORLDCHECK') THEN 'WC'" + Environment.NewLine +
                                    "					WHEN WATCHLIST_SOURCE IN ('LEXISNEXIS','NEXISLEXIS') THEN 'LN' WHEN WATCHLIST_SOURCE IN ('OFAC','STD') THEN 'STD'" + Environment.NewLine +
                                    "					ELSE 'LN' END)" + Environment.NewLine +
                                    "		, strCountrySQLStmt1=" + Environment.NewLine +
                                    "			(CASE	WHEN hdr.WATCHLIST_SOURCE in ('DOWJONES','DJ') THEN 'and (AW_NAME.COUNTRY = N'' or AW_NAME.COUNTRY = N''|CNTRY1|'') '--WD01" + Environment.NewLine +
                                    "					WHEN hdr.WATCHLIST_SOURCE in ('WCHECK','WORLDCHECK') THEN 'and (AWC_NAME.COUNTRY = N'' or AWC_NAME.COUNTRY = N''|CNTRY1|'') '--WC01" + Environment.NewLine +
                                    "					WHEN hdr.WATCHLIST_SOURCE in ('OFAC','STD') THEN 'and (AWS_NAME.COUNTRY = N'' or AWS_NAME.COUNTRY = N''|CNTRY1|'') '--WW01" + Environment.NewLine +
                                    "					ELSE ' and (AWL_NAME.COUNTRY = N'' or AWL_NAME.COUNTRY = N''|CNTRY1|'') '--WL01 (including NEXISLEXIS, BLACKLIST)" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "		, strCountrySQLStmt2=" + Environment.NewLine +
                                    "			(CASE	WHEN hdr.WATCHLIST_SOURCE in ('DOWJONES','DJ') THEN 'and (AW_NAME.COUNTRY = N'' or AW_NAME.COUNTRY = N''|CNTRY2|'') '--WD01" + Environment.NewLine +
                                    "					WHEN hdr.WATCHLIST_SOURCE in ('WCHECK','WORLDCHECK') THEN 'and (AWC_NAME.COUNTRY = N'' or AWC_NAME.COUNTRY = N''|CNTRY2|'') '--WC01" + Environment.NewLine +
                                    "					WHEN hdr.WATCHLIST_SOURCE in ('OFAC','STD') THEN 'and (AWS_NAME.COUNTRY = N'' or AWS_NAME.COUNTRY = N''|CNTRY2|'') '--WW01" + Environment.NewLine +
                                    "					ELSE ' and (AWL_NAME.COUNTRY = N'' or AWL_NAME.COUNTRY = N''|CNTRY2|'') '--WL01 (including NEXISLEXIS, BLACKLIST)" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "		, strGenderSQLStmt1=IIF(hdr.WATCHLIST_SOURCE in ('DOWJONES','DJ','WCHECK','WORLDCHECK','OFAC','STD'), '', ' and (AWL_NAME.GENDER <> ''|GENDER1|'') ')" + Environment.NewLine +
                                    "		, strGenderSQLStmt2=IIF(hdr.WATCHLIST_SOURCE in ('DOWJONES','DJ','WCHECK','WORLDCHECK','OFAC','STD'), '', ' and (AWL_NAME.GENDER <> ''|GENDER2|'') ')" + Environment.NewLine +
                                    "		, strSQLCommonFdsUsedStmt=" + Environment.NewLine +
                                    "			(CASE	WHEN TABLE_PARENT_ID='1' THEN ''" + Environment.NewLine +
                                    "					WHEN TABLE_PARENT_ID='2' THEN 'Select distinct B.ACCOUNT_NAME as FIRST_NAME, B.CIF_ID as CIF_NO, B.BR_CODE as BR_CODE_CIF, B.ACCOUNT_NO as ACCOUNT_NO_X, '' as CIF_NO_X '" + Environment.NewLine +
                                    "					WHEN TABLE_PARENT_ID='3' THEN 'Select distinct C.FIRST_NAME, C.CIF_NO, C.BR_CODE as BR_CODE_CIF, '''' as ACCOUNT_NO_X, '''' as CIF_NO_X '" + Environment.NewLine +
                                    "					ELSE 'Select distinct B.ACCOUNT_NAME as FIRST_NAME, B.CIF_ID as CIF_NO, B.BR_CODE as BR_CODE_CIF, B.ACCOUNT_NO as ACCOUNT_NO_X, '''' as CIF_NO_X '" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "		, strSQLCommonSortOrderStmt = " + Environment.NewLine +
                                    "			(CASE	WHEN TABLE_PARENT_ID='1' THEN ''" + Environment.NewLine +
                                    "					WHEN TABLE_PARENT_ID='2' THEN ' order by B.ACCOUNT_NO '" + Environment.NewLine +
                                    "					WHEN TABLE_PARENT_ID='3' THEN ' order by C.CIF_NO '" + Environment.NewLine +
                                    "					ELSE ' order by M.MISC_KEY1 '" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "		, strTable_Name_Used = " + Environment.NewLine +
                                    "			(CASE " + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='1' ----D." + Environment.NewLine +
                                    "					THEN ''" + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='2' ----B." + Environment.NewLine +
                                    "					THEN ' from ' + prc.JOB_ACCT_TABLE + ' as B  Where (B.COMP_CODE=' + CAST(@CompCode as varchar(10)) + ') '" + Environment.NewLine +
                                    "							+ IIF(ISNULL(@strSQLStmtSkipRec, '') != '', ' and ' + @strSQLStmtSkipRec, '')" + Environment.NewLine +
                                    "							+ ' and B.FALSE_POSITIVE_IND_WL=0 '" + Environment.NewLine +
                                    "							+ IIF(grp.GRP_FILTER_ACCT_STATUS = 1 and ISNULL(grp.GRP_ACCT_SQL_STMT, '') != '', ' and ' + REPLACE(grp.GRP_ACCT_SQL_STMT, '|', ''''), '')" + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='3' ----C." + Environment.NewLine +
                                    "					THEN ' from ' + prc.JOB_CIF_TABLE + ' as C  Where (C.COMP_CODE=' + CAST(@CompCode as varchar(10)) + ') '" + Environment.NewLine +
                                    "							+ IIF(ISNULL(@strSQLStmtSkipRec, '') != '', ' and ' + @strSQLStmtSkipRec, '')" + Environment.NewLine +
                                    "							+ ' and C.CIF_FALSE_POSITIVE_IND_WL=0 '" + Environment.NewLine +
                                    "							+ IIF(grp.GRP_FILTER_STATUS = 1 and ISNULL(grp.GRP_FILTER_SQL_STMT, '') != '', ' and ' + REPLACE(grp.GRP_FILTER_SQL_STMT, '|', ''''), '')" + Environment.NewLine +
                                    "				ELSE ----M." + Environment.NewLine +
                                    "					' from ' + prc.JOB_ADDR_TABLE + ' as M  Where (M.COMP_CODE=' + CAST(@CompCode as varchar(10)) + ' and M.MISC_KEY1 = B.ACCOUNT_NO) '" + Environment.NewLine +
                                    "					+ IIF(ISNULL(@strSQLStmtSkipRec, '') != '', ' and ' + @strSQLStmtSkipRec, '')" + Environment.NewLine +
                                    "					+ ' and B.FALSE_POSITIVE_IND_WL=0 '" + Environment.NewLine +
                                    "					+ IIF(grp.GRP_FILTER_HIST_STATUS = 1 and ISNULL(grp.GRP_HIST_SQL_STMT, '') != '', ' and ' + REPLACE(grp.GRP_HIST_SQL_STMT, '|', ''''), '')" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "       , strTable_Name = " + Environment.NewLine +
                                    "			(CASE " + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='1' THEN ''" + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='2' THEN prc.JOB_ACCT_TABLE" + Environment.NewLine +
                                    "				WHEN TABLE_PARENT_ID='3' THEN prc.JOB_CIF_TABLE" + Environment.NewLine +
                                    "				ELSE prc.JOB_ADDR_TABLE" + Environment.NewLine +
                                    "			END)" + Environment.NewLine +
                                    "from CONFIGPRODWLRULEHDR as hdr" + Environment.NewLine +
                                    "inner join CONFIGJOBPROCESS as prc on prc.COMP_CODE=hdr.COMP_CODE and prc.JOB_CODE=@JobCode" + Environment.NewLine +
                                    "inner join GROUPMASTER as grp on grp.COMP_CODE=hdr.COMP_CODE and grp.GRP_ID=@JobCode" + Environment.NewLine +
                                    "where hdr.COMP_CODE=@CompCode" + Environment.NewLine +
                                    "and hdr.WL_TEMPLATE_ID=@ER_DETECTION_METHOD";
                    #endregion
                    break;

                case SqlCase.BuildSql_Details:
                    #region
                    sqlStatement = "select dtl.TABLE_FD_ID" + Environment.NewLine +
                                    "		, strWatchlistFieldValue = 'CAST('+" + Environment.NewLine +
                                    "           (CASE	WHEN dtl.TABLE_PARENT_ID=1 THEN 'D.'" + Environment.NewLine +
                                    "				WHEN dtl.TABLE_PARENT_ID=2 THEN 'B.'" + Environment.NewLine +
                                    "				WHEN dtl.TABLE_PARENT_ID=3 THEN 'C.'" + Environment.NewLine +
                                    "				ELSE 'M.'" + Environment.NewLine +
                                    "		    END) + dtl.TABLE_FD_TARGET_NAME+' AS VARCHAR(1000)) as FdCIFAcctValue' + CAST(dtl.TABLE_FD_ID AS VARCHAR(5))" + Environment.NewLine +
                                    "		, strWatchlistFieldUsed = dtl.TABLE_FD_TARGET_NAME" + Environment.NewLine +
                                    "		, strWatchlistFieldValueDistict = 'FdCIFAcctValue' + CAST(dtl.TABLE_FD_ID AS VARCHAR(5))" + Environment.NewLine +
                                    "		, strSQLStmtSkipRec = " + Environment.NewLine +
                                    "           (CASE	WHEN dtl.TABLE_PARENT_ID=1 THEN 'D.'" + Environment.NewLine +
                                    "				WHEN dtl.TABLE_PARENT_ID=2 THEN 'B.'" + Environment.NewLine +
                                    "				WHEN dtl.TABLE_PARENT_ID=3 THEN 'C.'" + Environment.NewLine +
                                    "				ELSE 'M.'" + Environment.NewLine +
                                    "		    END) + dtl.TABLE_FD_TARGET_NAME+'>'''' '" + Environment.NewLine +
                                    "from CONFIGPRODWLRULEDTL as dtl" + Environment.NewLine +
                                    "Where dtl.COMP_CODE=@CompCode" + Environment.NewLine +
                                    "and dtl.WL_TEMPLATE_ID=@ER_DETECTION_METHOD" + Environment.NewLine +
                                    "and dtl.FIELD_USED_IND=0 ----0 - Active, 1 - Inactive" + Environment.NewLine +
                                    "and ISNULL(dtl.TABLE_FD_TARGET_NAME, '')!='' " + Environment.NewLine +
                                    "and dtl.TABLE_FD_TARGET_NAME!='None'";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID_OFAC:
                    #region
                    sqlStatement = "select distinct * from (" + Environment.NewLine +
                                    "	Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE," + Environment.NewLine +
                                    "	aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME," + Environment.NewLine +
                                    "	aw.DOB, aw.CATEGORY, aw.COUNTRY, tempIdDB.IDNUMBER, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK" + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select distinct * " + Environment.NewLine +
                                    "		from (" + Environment.NewLine +
                                    "			Select ENTITY_ID, ID_VALUE as IDNUMBER " + Environment.NewLine +
                                    "			from AWS_IDNUMBER " + Environment.NewLine +
                                    "			where contains (ID_VALUE, N'{0}')" + Environment.NewLine +
                                    "		) as SCAN_DS_NAME" + Environment.NewLine +
                                    "	) as tempIdDB " + Environment.NewLine +
                                    "	inner Join AWS_NAME as aw on tempIdDB.ENTITY_ID = aw.ENTITY_ID" + Environment.NewLine +
                                    "	where 0 = 0" + Environment.NewLine +
                                    ") as SCAN_DS_NAME";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID_DowJones:
                    #region
                    sqlStatement = "select distinct * " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "	aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME," + Environment.NewLine +
                                    "	aw.DOB, aw.CATEGORY, aw.COUNTRY, tempIdDB.IDNUMBER, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK" + Environment.NewLine +
                                    "	, aw.MAIDEN_NAME, aw.SINGLE_STRING_NAME3" + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select distinct * " + Environment.NewLine +
                                    "		from (" + Environment.NewLine +
                                    "			Select ENTITY_ID, ID_VALUE as IDNUMBER " + Environment.NewLine +
                                    "			from AW_IDNUMBER " + Environment.NewLine +
                                    "			where contains (ID_VALUE, N'{0}')" + Environment.NewLine +
                                    "		) as SCAN_DS_NAME" + Environment.NewLine +
                                    "	) as tempIdDB " + Environment.NewLine +
                                    "	inner Join AW_NAME as aw on tempIdDB.ENTITY_ID = aw.ENTITY_ID" + Environment.NewLine +
                                    "	where 0 = 0 " + Environment.NewLine +
                                    ") as SCAN_DS_NAME ";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID_WorldCheck:
                    #region
                    sqlStatement = "select distinct *" + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	Select aw.UID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "	aw.ALIASES_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "	aw.DOB, aw.CATEGORY, aw.SUBCATEGORY, aw.COUNTRY, tempIdDB.IDNUMBER, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK" + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select distinct *" + Environment.NewLine +
                                    "		from (" + Environment.NewLine +
                                    "			Select UID, IDENTIFICATIONNUMBERS as IDNUMBER" + Environment.NewLine +
                                    "			from AWC_IDSSNPASSPORT" + Environment.NewLine +
                                    "			where contains (IDENTIFICATIONNUMBERS, N'{0}')" + Environment.NewLine +
                                    "		) as SCAN_DS_NAME" + Environment.NewLine +
                                    "	) as tempIdDB" + Environment.NewLine +
                                    "	inner Join AWC_NAME as aw on tempIdDB.UID = aw.UID" + Environment.NewLine +
                                    "   where 0 = 0" + Environment.NewLine +
                                    ") as SCAN_DS_NAME";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID_LexisNexis:
                    #region
                    sqlStatement = "select distinct * " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	Select aw.ENT_ID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, aw.AKA_NAME, " + Environment.NewLine +
                                    "	aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3, aw.ORIGINAL_SCRIPT_NAME, aw.NAMESOURCE, " + Environment.NewLine +
                                    "	aw.GENDER, aw.DOB, aw.COUNTRY, aw.CATEGORY, tempIdDB.IDNUMBER, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK " + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select distinct * " + Environment.NewLine +
                                    "		from (" + Environment.NewLine +
                                    "			Select ENT_ID, IDNUMBER " + Environment.NewLine +
                                    "			from AWL_IDNUMBER " + Environment.NewLine +
                                    "			where contains (IDNUMBER, N'{0}')" + Environment.NewLine +
                                    "		) as SCAN_DS_NAME" + Environment.NewLine +
                                    "	) as tempIdDB " + Environment.NewLine +
                                    "	inner Join AWL_NAME as aw on tempIdDB.ENT_ID = aw.ENT_ID  " + Environment.NewLine +
                                    "	where 0 = 0 " + Environment.NewLine +
                                    ") as SCAN_DS_NAME ";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID2_OFAC:
                    #region
                    sqlStatement = "Select distinct aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE" + Environment.NewLine +
                                    ", aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, '' as SINGLE_STRING_NAME3" + Environment.NewLine +
                                    ", aw.ORIGINAL_SCRIPT_NAME, aw.CATEGORY, aw.DOB, aw.COUNTRY, aw.CATEGORY as CATEGORY1, '' as CATEGORY2, '' as NAMESOURCE, 0 as NO, SANCTION" + Environment.NewLine +
                                    ", tempIdDB.ID_VALUE, tempIdDB.ENTITY_TYPE, tempIdDB.GENDER, 'ID' as MATCH, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	select distinct * " + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select AWS_IDNUMBER.ENTITY_ID, ID_VALUE, ENTITY_TYPE, GENDER " + Environment.NewLine +
                                    "		from AWS_IDNUMBER " + Environment.NewLine +
                                    "		Inner join AWS_MASTER on AWS_IDNUMBER.ENTITY_ID = AWS_MASTER.ENTITY_ID and AWS_MASTER.FALSE_POSITIVE = 0" + Environment.NewLine +
                                    "								and (@Search_EntityType or AWS_MASTER.ENTITY_TYPE=@Search_EntityType OR AWS_MASTER.ENTITY_TYPE = '')" + Environment.NewLine +
                                    "		where contains  (ID_VALUE, @strSearchStringIDStmt)" + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    ") as tempIdDB" + Environment.NewLine +
                                    "inner join AWS_NAME as aw on tempIdDB.ENTITY_ID = aw.ENTITY_ID " + Environment.NewLine +
                                    "where 0 = 0 " + Environment.NewLine +
                                    "and aw.NAME_TYPE in ('Primary','Primary Name')" + Environment.NewLine +
                                    "and aw.FALSE_POSITIVE = 0";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID2_DowJones:
                    #region
                    sqlStatement = "Select distinct aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE" + Environment.NewLine +
                                    ", aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3" + Environment.NewLine +
                                    ", aw.ORIGINAL_SCRIPT_NAME, aw.CATEGORY, aw.DOB, aw.COUNTRIES as COUNTRY, CATEGORYNUM as CATEGORY1, '' as CATEGORY2, '' as NAMESOURCE, 0 as NO, SANCTION" + Environment.NewLine +
                                    ", tempIdDB.ID_VALUE, tempIdDB.ENTITY_TYPE, tempIdDB.GENDER, 'ID' as MATCH, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "		select distinct * " + Environment.NewLine +
                                    "        from (" + Environment.NewLine +
                                    "			select AW_IDNUMBER.ENTITY_ID, ID_VALUE, ENTITY_TYPE, GENDER " + Environment.NewLine +
                                    "			from AW_IDNUMBER " + Environment.NewLine +
                                    "			inner join AW_MASTER as awm on AW_IDNUMBER.ENTITY_ID = awm.ENTITY_ID and awm.FALSE_POSITIVE = 0" + Environment.NewLine +
                                    "											and (Search_EntityType='' or awm.ENTITY_TYPE=@Search_EntityType or awm.ENTITY_TYPE='') " + Environment.NewLine +
                                    "			where contains  (ID_VALUE, @strSearchStringIDStmt)" + Environment.NewLine +
                                    "		) as SCAN_DS_NAME " + Environment.NewLine +
                                    " ) as tempIdDB" + Environment.NewLine +
                                    "inner join AW_NAME as aw on tempIdDB.ENTITY_ID = aw.ENTITY_ID " + Environment.NewLine +
                                    "where 0 = 0 " + Environment.NewLine +
                                    "and aw.NAME_TYPE in ('Primary','Primary Name')" + Environment.NewLine +
                                    "and aw.FALSE_POSITIVE = 0";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID2_WorldCheck:
                    #region
                    sqlStatement = "Select distinct AWC_NAME.UID as ENTITY_ID, AWC_NAME.SYS_ID_AUTO as SYS_ID, AWC_NAME.INFO_SOURCE, AWC_NAME.NAME_TYPE" + Environment.NewLine +
                                    ", AWC_NAME.SINGLE_STRING_NAME, AWC_NAME.SINGLE_STRING_NAME2, '' as SINGLE_STRING_NAME3" + Environment.NewLine +
                                    ", AWC_NAME.ORIGINAL_SCRIPT_NAME, AWC_NAME.CATEGORY, AWC_NAME.DOB, AWC_NAME.COUNTRY, AWC_NAME.CATEGORY as CATEGORY1, SUBCATEGORY as CATEGORY2, '' as NAMESOURCE, 0 as NO, SANCTION" + Environment.NewLine +
                                    ", tempIdDB.ID_VALUE, tempIdDB.ENTITY_TYPE, GENDER, 'ID' as MATCH, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	select distinct * " + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		select AWC_IDSSNPASSPORT.UID, IDENTIFICATIONNUMBERS as ID_VALUE, ENTITY_TYPE from AWC_IDSSNPASSPORT " + Environment.NewLine +
                                    "		Inner join AWC_MASTER on AWC_IDSSNPASSPORT.UID = AWC_MASTER.UID and AWC_MASTER.FALSE_POSITIVE = 0" + Environment.NewLine +
                                    "							and (@Search_EntityType='' or AWC_MASTER.ENTITY_TYPE = @Search_EntityType OR AWC_MASTER.ENTITY_TYPE = '')" + Environment.NewLine +
                                    "		where contains(IDENTIFICATIONNUMBERS, @strSearchStringIDStmt)" + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    " ) as tempIdDB" + Environment.NewLine +
                                    "inner join AWC_NAME on tempIdDB.UID = AWC_NAME.UID " + Environment.NewLine +
                                    "where 0 = 0 " + Environment.NewLine +
                                    "and AWC_NAME.NAME_TYPE in ('Primary','Primary Name')" + Environment.NewLine +
                                    "and AWC_NAME.FALSE_POSITIVE = 0";
                    #endregion
                    break;

                case SqlCase.FullTextSql_ID2_LexisNexis:
                    #region
                    sqlStatement = "Select distinct aw.ENT_ID as ENTITY_ID, aw.SYS_ID_AUTO as SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE" + Environment.NewLine +
                                    ", aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3" + Environment.NewLine +
                                    ", aw.ORIGINAL_SCRIPT_NAME, aw.CATEGORY, aw.DOB, aw.COUNTRY, aw.CATEGORY as CATEGORY1, SUBCATEGORY as CATEGORY2, NAMESOURCE, 0 as NO, '' as SANCTION" + Environment.NewLine +
                                    ", tempIdDB.ID_VALUE, tempIdDB.ENTITY_TYPE, GENDER, 'ID' as MATCH, 0 as NAME_HIT, 1 as ID_HIT, 100 as RANK " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	 select distinct * " + Environment.NewLine +
                                    "	 from (" + Environment.NewLine +
                                    "		select AWL_IDNUMBER.ENT_ID, IDNUMBER as ID_VALUE, ENTRYTYPE as ENTITY_TYPE " + Environment.NewLine +
                                    "		from AWL_IDNUMBER " + Environment.NewLine +
                                    "		Inner join AWL_MASTER on AWL_IDNUMBER.ENT_ID = AWL_MASTER.ENT_ID and AWL_MASTER.FALSE_POSITIVE = 0 " + Environment.NewLine +
                                    "							and (@Search_EntityType='' or AWL_MASTER.ENTRYTYPE=@Search_EntityType OR AWL_MASTER.ENTRYTYPE = '')" + Environment.NewLine +
                                    "		where contains  (IDNUMBER, @strSearchStringIDStmt)" + Environment.NewLine +
                                    "	 ) as SCAN_DS_NAME " + Environment.NewLine +
                                    " ) as tempIdDB" + Environment.NewLine +
                                    "inner join AWL_NAME as aw on tempIdDB.ENT_ID = AWL_NAME.ENT_ID " + Environment.NewLine +
                                    "where 0 = 0 " + Environment.NewLine +
                                    "and aw.NAME_TYPE in ('Primary','Primary Name') " + Environment.NewLine +
                                    "and aw.FALSE_POSITIVE = 0";
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name_DowJones:
                    #region
                    sqlStatement = "select distinct * from (" + Environment.NewLine +
                                    "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE, aw.MAIDEN_NAME, " + Environment.NewLine +
                                    "		aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AW_NAME as aw" + Environment.NewLine +
                                    "		Inner Join FreeTextTable (AW_NAME, SINGLE_STRING_NAME3, N'|NAME1|', @rankTopRec) as KEY_TABLE on aw.SYS_ID = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore" + Environment.NewLine +
                                    "	) as SCAN_DS_NAME" + Environment.NewLine;
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name_WorldCheck:
                    #region
                    sqlStatement = "select distinct * " + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	select distinct * " + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		Select aw.UID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "		aw.ALIASES_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.SUBCATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWC_NAME as aw" + Environment.NewLine +
                                    "		Inner Join FreeTextTable (AWC_NAME, SINGLE_STRING_NAME2, N'|NAME1|', @rankTopRec) as KEY_TABLE on aw.SYS_ID_AUTO = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore" + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine;
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name_OFAC:
                    #region
                    sqlStatement = "select distinct * from (" + Environment.NewLine +
                                    "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "		aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWS_NAME as aw" + Environment.NewLine +
                                    "		Inner Join FreeTextTable (AWS_NAME, SINGLE_STRING_NAME2, N'|NAME1|', @rankTopRec) as KEY_TABLE on aw.SYS_ID = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY = @Search_Country)" + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore ) as SCAN_DS_NAME " + Environment.NewLine;
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name_LexisNexis:
                    #region
                    sqlStatement = "select distinct * from (" + Environment.NewLine +
                                    "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENT_ID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, aw.AKA_NAME, " + Environment.NewLine +
                                    "		aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3, aw.ORIGINAL_SCRIPT_NAME, aw.NAMESOURCE, " + Environment.NewLine +
                                    "		aw.GENDER, aw.DOB, aw.COUNTRY, aw.CATEGORY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWL_NAME as aw " + Environment.NewLine +
                                    "		Inner Join FreeTextTable (AWL_NAME, SINGLE_STRING_NAME3, N'|NAME1|', @rankTopRec) as KEY_TABLE on aw.SYS_ID_AUTO = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		 and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		 and (aw.GENDER <> '|GENDER1|') " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore " + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine;
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name2_DowJones:
                    #region
                    sqlStatement = "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE, aw.MAIDEN_NAME, " + Environment.NewLine +
                                    "		aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AW_NAME as aw" + Environment.NewLine +
                                    "		Inner Join Containstable (AW_NAME, SINGLE_STRING_NAME3, N'|NAME2|', @rankTopRec) as KEY_TABLE on aw.SYS_ID = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore" + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    ") as SCAN_DS_NAME2";
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name2_WorldCheck:
                    #region
                    sqlStatement = "	select distinct * " + Environment.NewLine +
                                    "	from (" + Environment.NewLine +
                                    "		Select aw.UID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "		aw.ALIASES_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.SUBCATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWC_NAME as aw" + Environment.NewLine +
                                    "		Inner Join Containstable (AWC_NAME, SINGLE_STRING_NAME2, N'|NAME2|', @rankTopRec) as KEY_TABLE on aw.SYS_ID_AUTO = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore " + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    ") as SCAN_DS_NAME2";
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name2_OFAC:
                    #region
                    sqlStatement = "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENTITY_ID, aw.SYS_ID, aw.INFO_SOURCE, aw.NAME_TYPE, " + Environment.NewLine +
                                    "		aw.ENTITY_NAME, aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.ORIGINAL_SCRIPT_NAME, " + Environment.NewLine +
                                    "		aw.DOB, aw.CATEGORY, aw.COUNTRY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWS_NAME as aw" + Environment.NewLine +
                                    "		Inner Join Containstable (AWS_NAME, SINGLE_STRING_NAME2, N'|NAME2|', @rankTopRec) as KEY_TABLE on aw.SYS_ID = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY = @Search_Country) " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore " + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    ") as SCAN_DS_NAME2";
                    #endregion
                    break;

                case SqlCase.FullTextSql_Name2_LexisNexis:
                    #region
                    sqlStatement = "	select distinct * from (" + Environment.NewLine +
                                    "		Select aw.ENT_ID, aw.SYS_ID_AUTO, aw.INFO_SOURCE, aw.NAME_TYPE, aw.AKA_NAME, " + Environment.NewLine +
                                    "		aw.SINGLE_STRING_NAME, aw.SINGLE_STRING_NAME2, aw.SINGLE_STRING_NAME3, aw.ORIGINAL_SCRIPT_NAME, aw.NAMESOURCE, " + Environment.NewLine +
                                    "		aw.GENDER, aw.DOB, aw.COUNTRY, aw.CATEGORY, '' as IDNUMBER, 1 as NAME_HIT, 0 as ID_HIT, 100 as RANK  " + Environment.NewLine +
                                    "		from AWL_NAME as aw" + Environment.NewLine +
                                    "		Inner Join Containstable (AWL_NAME, SINGLE_STRING_NAME3, N'|NAME2|', @rankTopRec) as KEY_TABLE on aw.SYS_ID_AUTO = KEY_TABLE.[KEY] " + Environment.NewLine +
                                    "		 and (aw.COUNTRY = N'' or @Search_Country='' or aw.COUNTRY=@Search_Country) " + Environment.NewLine +
                                    "		 and (aw.GENDER <> '|GENDER2|') " + Environment.NewLine +
                                    "		where KEY_TABLE.rank > @rankScore " + Environment.NewLine +
                                    "	) as SCAN_DS_NAME " + Environment.NewLine +
                                    ") as SCAN_DS_NAME2";
                    #endregion
                    break;

                case SqlCase.GetWatchlistAlgorithmDetails:
                    #region
                    sqlStatement = "select a.WL_ALGO, a.ENABLED, b.WL_TYPE, b.WL_KEY" + Environment.NewLine +
                                    ", (CASE WHEN b.WL_TYPE = 'NUM' THEN IIF(ISNULL(b.NUMERIC_VALUE, 0)=0, ISNULL(c.DEFAULT_VALUE, '0'), cast(b.NUMERIC_VALUE as varchar(50)))" + Environment.NewLine +
                                    "		WHEN b.WL_TYPE = 'TXT' THEN IIF(ISNULL(b.TEXT_VALUE, '')='',  ISNULL(c.DEFAULT_VALUE, ''), b.TEXT_VALUE)" + Environment.NewLine +
                                    "		WHEN b.WL_TYPE = 'W' THEN IIF(ISNULL(b.SET_HIT_PERCENTS, 0)=0, ISNULL(c.DEFAULT_VALUE, '0'), cast(b.SET_HIT_PERCENTS as varchar(50)))" + Environment.NewLine +
                                    "	END) as WL_VALUE" + Environment.NewLine +
                                    ", CAST(IIF(ISNULL(b.SHOW_NO_OF_TOP_REC, 100) < 100, 100, b.SHOW_NO_OF_TOP_REC) AS SMALLINT) as SHOW_NO_OF_TOP_REC" + Environment.NewLine +
                                    "from WatchlistAlgorithm as a" + Environment.NewLine +
                                    "inner join WatchlistAlgorithmDtl as b on b.COMP_CODE=a.COMP_CODE and b.WL_ALGO=a.WL_ALGO and b.WL_TYPE=a.LINK_TABLE_TYPE" + Environment.NewLine +
                                    "left join WatchlistAlgorithmDtl_DefaultValue as c on c.COMP_CODE=b.COMP_CODE and c.WL_ALGO=b.WL_ALGO and c.WL_TYPE=b.WL_TYPE and c.WL_KEY=b.WL_KEY" + Environment.NewLine +
                                    "where a.COMP_CODE=@CompCode" + Environment.NewLine +
                                    "and a.ENABLED=1" + Environment.NewLine +
                                    "order by a.WL_ALGO, b.WL_KEY";
                    #endregion
                    break;

                case SqlCase.GetWatchlistAlgorithmCat:
                    #region
                    sqlStatement = "select strFilterPEP = (CASE WHEN @strWatchlistType = 'DJ' AND CAT1 = '|A11|' THEN '|11|,|12|' ELSE IIF(ISNULL(CAT1, '')='' or CAT1='ALL', NULL, CAT1) END)" + Environment.NewLine +
                                    "	, strFilterSIPSIE = (CASE WHEN @strWatchlistType = 'DJ' AND CAT2 = '|A13|' THEN '|13|,|14|,|15|,|16|' ELSE IIF(ISNULL(CAT2, '')='' or CAT2='ALL', NULL, CAT2) END)" + Environment.NewLine +
                                    "	, strFilterSubCategory = IIF(CAT3='ALL', '', ISNULL(CAT3, ''))" + Environment.NewLine +
                                    "	, strFilterSanction = IIF(CAT4='ALL', '', ISNULL(CAT4, ''))" + Environment.NewLine +
                                    "	, iFilterCategory_CAT1 = IIF(ISNULL(CAT1, '')='' or CAT1='ALL', 0, 1)" + Environment.NewLine +
                                    "	, iFilterCategory_CAT2 = (CASE WHEN @strWatchlistType='DJ' and (ISNULL(CAT1, '')='' or CAT1='ALL') THEN 0" + Environment.NewLine +
                                    "									WHEN @strWatchlistType='DJ' THEN 1 " + Environment.NewLine +
                                    "									ELSE 0 " + Environment.NewLine +
                                    "							END)" + Environment.NewLine +
                                    "from WatchlistAlgorithmCAT" + Environment.NewLine +
                                    "where COMP_CODE=@CompCode" + Environment.NewLine +
                                    "and CATEGROY_TYPE=@FilterSetting" + Environment.NewLine +
                                    "order by CATEGROY_TYPE";
                    #endregion
                    break;
            }

#if DEBUG
            System.Diagnostics.Debug.WriteLine("GetStatement " + sqlCase.ToString() + System.Environment.NewLine + sqlStatement);
#endif

            return sqlStatement;
        }
    }
}
