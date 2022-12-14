
CREATE PROCEDURE [dbo].[sp_Word_Scan]
AS
BEGIN

	update WORD_SCAN_SOURCE
	set word_tmp = TRIM(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(word, '''', ' '), '~', ' '), '`', ' '), '!', ' '), '@', ' '), '#', ' '), '$', ' '), '%', ' '), '^', ' '), '&', ' '), '*', ' '), '(', ' '), ')', ' '), '-', ' '), '_', ' '), '+', ' '), '=', ' '), ':', ' '), ';', ' '), '"', ' '), '<', ' '), '>', ' '), ',', ' '), '.', ' '), '?', ' '), '/', ' '))
	, subword=null

	print GETDATE()

	DECLARE @cnt int = 1
	truncate table WORD_SCAN_TEMP

	WHILE EXISTS(select 1 from WORD_SCAN_SOURCE where word_tmp!='')
	BEGIN

		update WORD_SCAN_SOURCE
		set subword=NULL
		where word_tmp='' and subword!=''

		update WORD_SCAN_SOURCE
		set subword = IIF(CHARINDEX(' ', TRIM(word_tmp)) = 0, word_tmp, TRIM(SUBSTRING(word_tmp, 1, CHARINDEX(' ', word_tmp) - 1)))
		, word_tmp = IIF(CHARINDEX(' ', TRIM(word_tmp)) = 0, '', TRIM(SUBSTRING(word_tmp, CHARINDEX(' ', word_tmp) + 1, LEN(word_tmp) - CHARINDEX(' ', word_tmp))))
		where word_tmp!=''

		insert into WORD_SCAN_TEMP
		(id, seq, fullname, partialname)
		select id, @cnt as seq, word, subword from WORD_SCAN_SOURCE 
		where subword is not null
		and not exists (select 1 from WATCHLISTSTOPLIST where ABBR_VALUE=subword)
		
		set @cnt = @cnt + 1
	END
END
GO


CREATE PROCEDURE [dbo].[sp_Scan_Name_Watchlist]
	@SourceStatement varchar(max)
	, @WatchlistStatement varchar(max)
AS
BEGIN

	
	truncate table WORD_SCAN_SOURCE
	exec (@SourceStatement)

	exec sp_Word_Scan

	TRUNCATE TABLE WORD_SCAN_SPLIT1
	
	insert into WORD_SCAN_SPLIT1
	(wordid, partialNameSeq, redundantNameSeq, fullname, partialname)
	select id, ROW_NUMBER() OVER (PARTITION BY id ORDER BY id, partialname) as partialNameSeq
			, ROW_NUMBER() OVER (PARTITION BY id, partialname ORDER BY id, partialname) as redundantNameSeq
			, fullname, partialname 
	from WORD_SCAN_TEMP
	order by id, partialname

	-----------------------------------------------------------

	truncate table WORD_SCAN_SOURCE
	exec (@WatchlistStatement)

	exec sp_Word_Scan
	
	TRUNCATE TABLE WORD_SCAN_SPLIT2

	insert into WORD_SCAN_SPLIT2
	(wordid, partialNameSeq, redundantNameSeq, fullname, partialname)
	select id, ROW_NUMBER() OVER (PARTITION BY id ORDER BY id, partialname) as partialNameSeq
			, ROW_NUMBER() OVER (PARTITION BY id, partialname ORDER BY id, partialname) as redundantNameSeq
			, fullname, partialname 
	from WORD_SCAN_TEMP
	order by id, partialname
	
	-----------------------------------------------------------

	----drop table #WORD_SCAN_MAP
	select a.wordid as id1, a.partialNameSeq as partialNameSeq1, a.redundantNameSeq as redundantNameSeq1, a.fullname as fullname1, a.partialname as partialname1
					, b.wordid as id2, b.partialNameSeq as partialNameSeq2, b.redundantNameSeq as redundantNameSeq2, b.fullname as fullname2, b.partialname as partialname2
	into #WORD_SCAN_MAP
	from WORD_SCAN_SPLIT1 as a
	inner join WORD_SCAN_SPLIT2 as b on b.partialname=a.partialname and b.redundantNameSeq=a.redundantNameSeq
	
	-----------------------------------------------------------
	
	select map.id1, map.id2, a.fullname, string_agg(a.partialname, '') as concatname, SUM(IIF(TRIM(a.partialname)='', 0, 1)) as unmatchedCount
	into #WORD_SCAN_CONCAT1
	from (select distinct id1, id2 from #WORD_SCAN_MAP) as map
	inner join WORD_SCAN_SPLIT1 as a on a.wordid=map.id1
	where NOT EXISTS (select 1 from #WORD_SCAN_MAP 
	where id1=map.id1 and id2=map.id2
	and partialname1=a.partialname
	and redundantNameSeq1=a.redundantNameSeq
	)
	group by map.id1, map.id2, a.fullname

	select map.id1, map.id2, a.fullname, string_agg(a.partialname, '') as concatname, SUM(IIF(TRIM(a.partialname)='', 0, 1)) as unmatchedCount
	into #WORD_SCAN_CONCAT2
	from (select distinct id1, id2 from #WORD_SCAN_MAP) as map
	inner join WORD_SCAN_SPLIT2 as a on a.wordid=map.id2
	where NOT EXISTS (select 1 from #WORD_SCAN_MAP 
	where id1=map.id1 and id2=map.id2
	and partialname2=a.partialname
	and redundantNameSeq2=a.redundantNameSeq
	)
	group by map.id1, map.id2, a.fullname

	--drop table #WORD_SCAN_CONCAT
	
	select IIF(map.id1 < map.id2, map.id1, map.id2) as idSeq1, IIF(map.id1 < map.id2, map.id2, map.id1) as idSeq2
	, map.id1, map.id2, map.fullname1, map.fullname2, map.matchedWord
	, IIF(LEN(ISNULL(a.concatname, '')) <= LEN(ISNULL(b.concatname, '')), LEN(ISNULL(a.concatname, '')), LEN(ISNULL(b.concatname, ''))) as minLength
	, IIF(LEN(ISNULL(a.concatname, '')) > LEN(ISNULL(b.concatname, '')), LEN(ISNULL(a.concatname, '')), LEN(ISNULL(b.concatname, ''))) as maxLength
	, ISNULL(a.concatname, '') as unmatchedWord1, ISNULL(b.concatname, '') as unmatchedWord2
	, map.matchedCount, ISNULL(a.unmatchedCount, 0) as unmatchedCount1, ISNULL(b.unmatchedCount, 0) as unmatchedCount2, 0 as score
	into #WORD_SCAN_CONCAT
	from (select id1, id2, fullname1, fullname2, string_agg(partialname1, '') as matchedWord, count(1) as matchedCount
		  from #WORD_SCAN_MAP
		  group by id1, id2, fullname1, fullname2
	  ) as map
	left join #WORD_SCAN_CONCAT1 as a on a.id1=map.id1 and a.id2=map.id2
	left join #WORD_SCAN_CONCAT2 as b on b.id1=map.id1 and b.id2=map.id2
	
	truncate table WORD_SCAN_CONCAT
	insert into WORD_SCAN_CONCAT
	(id1,id2,fullname1,fullname2,matchedWord,minLength,maxLength,unmatchedWord1,unmatchedWord2,matchedCount,unmatchedCount1,unmatchedCount2,score)
	select id1,id2,fullname1,fullname2,matchedWord,minLength,maxLength,unmatchedWord1,unmatchedWord2,matchedCount,unmatchedCount1,unmatchedCount2,score 
	from (
		select ROW_NUMBER() OVER (PARTITION BY idSeq1, idSeq2 ORDER BY idSeq1, idSeq2) as r
			, id1,id2,fullname1,fullname2,matchedWord,minLength,maxLength,unmatchedWord1,unmatchedWord2,matchedCount,unmatchedCount1,unmatchedCount2,score
		from #WORD_SCAN_CONCAT
	) as t
	where r=1

	--truncate table WORD_SCAN_CONCAT
	--insert into WORD_SCAN_CONCAT
	--(id1,id2,fullname1,fullname2,matchedWord,minLength,maxLength,unmatchedWord1,unmatchedWord2,score)
	--select map.id1, map.id2, map.fullname1, map.fullname2, map.matchedWord
	--, IIF(LEN(ISNULL(a.concatname, '')) <= LEN(ISNULL(b.concatname, '')), LEN(ISNULL(a.concatname, '')), LEN(ISNULL(b.concatname, ''))) as minLength
	--, IIF(LEN(ISNULL(a.concatname, '')) > LEN(ISNULL(b.concatname, '')), LEN(ISNULL(a.concatname, '')), LEN(ISNULL(b.concatname, ''))) as maxLength
	--, ISNULL(a.concatname, '') as unmatchedWord1, ISNULL(b.concatname, '') as unmatchedWord2, 0 as score
	--from (select id1, id2, fullname1, fullname2, string_agg(partialname1, '') as matchedWord
	--      from #WORD_SCAN_MAP
	--      group by id1, id2, fullname1, fullname2
	--  ) as map
	--left join #WORD_SCAN_CONCAT1 as a on a.id1=map.id1 and a.id2=map.id2
	--left join #WORD_SCAN_CONCAT2 as b on b.id1=map.id1 and b.id2=map.id2
	
	-----------------------------------------------------------
	
	update WORD_SCAN_CONCAT
	set score=dbo.GetLevenshteinDistance(unmatchedWord1, unmatchedWord2)

	update WORD_SCAN_CONCAT
	set score=1 - (score / maxLength)
	where score > 0 and maxLength > 0

	----select * from WORD_SCAN_CONCAT

	-----------------------------------------------------------
	
	drop table #WORD_SCAN_MAP
	drop table #WORD_SCAN_CONCAT1
	drop table #WORD_SCAN_CONCAT2
	drop table #WORD_SCAN_CONCAT

END
GO