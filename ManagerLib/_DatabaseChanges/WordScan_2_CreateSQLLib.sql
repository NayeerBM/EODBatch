
DECLARE @DLL_LOCATION varchar(200) = 'D:\SQLLib.dll'

-------------------------------

EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;
EXEC sp_configure 'clr strict security', 0;
RECONFIGURE;
-------------------------------

----DROP FUNCTION GetLevenshteinDistance  
----DROP ASSEMBLY SQLLib  
CREATE ASSEMBLY SQLLib from @DLL_LOCATION WITH PERMISSION_SET = SAFE
GO

CREATE FUNCTION GetLevenshteinDistance(@str1 [nvarchar](4000), @str2 [nvarchar](4000))
RETURNS [float] WITH EXECUTE AS CALLER, RETURNS NULL ON NULL INPUT
AS
	EXTERNAL NAME [SQLLib].[SQLLib.StringHelper].[GetLevenshteinDistance]
GO

-------------------------------
sp_configure 'clr enabled', 1
RECONFIGURE
--EXEC sp_configure 'clr strict security', 1;
--RECONFIGURE;
EXEC sp_configure 'show advanced options', 0;
RECONFIGURE;

GO