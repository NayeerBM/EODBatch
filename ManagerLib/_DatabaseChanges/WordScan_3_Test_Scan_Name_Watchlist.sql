
	Declare @SourceStatement varchar(max) = '

	insert into WORD_SCAN_SOURCE
	(id, word)
	select 1, ''chee wei wong''
	union all select 2, ''wong chee chee wei''
	union all select 3, ''theo wei chong''
	union all select 4, ''chee lee weng''
	union all select 5, ''shi tu wang wei''
	--select id, word from WORD_SOURCE
	--where id between 300001 and 400000
	'
	Declare @WatchlistStatement varchar(max) = '
	
	insert into WORD_SCAN_SOURCE
	(id, word)
	select 1, ''wong chee wei''
	union all select 2, ''wong yuan chee''
	union all select 3, ''wong chee chee''
	union all select 4, ''tan chee wei''
	union all select 5, ''vincent wong chee wei''
	--select id, word from WORD_SOURCE
	--where id between 200001 and 300000
	'

	exec [dbo].[sp_Scan_Name_Watchlist] @SourceStatement, @WatchlistStatement


	--truncate table WORD_SCAN_CONCAT

	select * from WORD_SCAN_CONCAT

