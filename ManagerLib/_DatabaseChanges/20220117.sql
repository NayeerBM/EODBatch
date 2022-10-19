
IF OBJECT_ID('ES_ACCESS_TOKEN') IS NOT NULL
	DROP TABLE ES_ACCESS_TOKEN
GO
CREATE TABLE [dbo].[ES_ACCESS_TOKEN](
	[AUTO_SEQ_NO] [bigint] IDENTITY(1,1) NOT NULL,
	[COMP_CODE] [smallint] NOT NULL,
	[ACCESS_TOKEN] [varchar](500) NOT NULL,
	[EXPIRES_IN] [int] NULL,
	[USERNAME] [nvarchar](30) NULL,
	[CLIENT_ID] [varchar](100) NULL,
	[ISSUED] [datetime] NOT NULL,
	[EXPIRES] [datetime] NOT NULL,
	[STAMP_DTTM] [datetime] NOT NULL,
 CONSTRAINT [PK_ES_ACCESS_TOKEN_1] PRIMARY KEY CLUSTERED 
(
	[AUTO_SEQ_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


IF OBJECT_ID('WatchlistAlgorithmDtl_DefaultValue') is not null
	DROP TABLE WatchlistAlgorithmDtl_DefaultValue
GO
CREATE TABLE WatchlistAlgorithmDtl_DefaultValue
(
	COMP_CODE smallint
	, WL_ALGO smallint
	, WL_TYPE nvarchar(40)
	, WL_KEY nvarchar(40)
	, DEFAULT_VALUE nvarchar(100)
)

insert into WatchlistAlgorithmDtl_DefaultValue
(COMP_CODE, WL_ALGO, WL_TYPE, WL_KEY, DEFAULT_VALUE)
select 1, 1, 'NUM', '1', '40'
union select 1, 2, 'NUM', '1', '60'
union select 1, 6, 'W', '10', '0'
union select 1, 6, 'W', '11', '0'
union select 1, 6, 'W', '21', '0'
union select 1, 6, 'W', '22', '0'
union select 1, 6, 'W', '31', '0'
union select 1, 6, 'W', '32', '0'
union select 1, 6, 'W', '33', '0'
union select 1, 6, 'W', '41', '0'
union select 1, 6, 'W', '42', '0'
union select 1, 6, 'W', '43', '0'
union select 1, 6, 'W', '44', '0'
union select 1, 7, 'NUM', '1', '0'
union select 1, 9, 'NUM', '1', '3'
union select 1, 10, 'NUM', '1', '3'
union select 1, 11, 'TXT', '1', ''
union select 1, 12, 'TXT', '1', ''
union select 1, 13, 'TXT', '1', ''
union select 1, 14, 'TXT', '1', ''
union select 1, 15, 'NUM', '1', '0'
GO


