
ALTER PROCEDURE [dbo].[CodeHelperCS_BuildEntityClass]
	-- Add the parameters for the stored procedure here
	@tablename varchar(100)
AS
BEGIN

Declare @property varchar(MAX) = '', @defaultvalue varchar(MAX)

select 
@property = COALESCE(@property + CHAR(13) + CHAR(10) + 

ISNULL((SELECT '[Key, Column(Order = '+CAST(ORDINAL_POSITION AS VARCHAR(3))+')]' + CHAR(13) + CHAR(10) 
FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE TABLE_NAME=col.TABLE_NAME
AND COLUMN_NAME=col.COLUMN_NAME
AND CONSTRAINT_NAME LIKE 'PK%'), '') +

IIF(COLUMNPROPERTY(object_id(col.TABLE_NAME), col.COLUMN_NAME, 'IsIdentity') = 1, '[DatabaseGenerated(DatabaseGeneratedOption.Identity)]' + CHAR(13) + CHAR(10), '') +

'public ' + (CASE 
WHEN DATA_TYPE like '%varchar%' or DATA_TYPE like '%text%' THEN 'string'
--WHEN DATA_TYPE='smallint' OR DATA_TYPE='int' OR DATA_TYPE='bigint' THEN 'int'
WHEN DATA_TYPE='bit' THEN 'bool'
WHEN DATA_TYPE='smallint' THEN 'Int16'
WHEN DATA_TYPE='tinyint' THEN 'Byte'
WHEN DATA_TYPE='int' THEN 'int'
WHEN DATA_TYPE='bigint' THEN 'Int64'
WHEN DATA_TYPE='money' or DATA_TYPE='numeric' THEN 'decimal'
WHEN DATA_TYPE='float' THEN 'double'
WHEN DATA_TYPE='datetime' or DATA_TYPE='smalldatetime' THEN 'DateTime?'
ELSE ''
END) + ' ' + COLUMN_NAME + '{ get; set; }'
, 
'public ' + 
(CASE 
WHEN DATA_TYPE like '%varchar%' or DATA_TYPE like '%text%' THEN 'string'
--WHEN DATA_TYPE='smallint' OR DATA_TYPE='int' OR DATA_TYPE='bigint' THEN 'int'
WHEN DATA_TYPE='bit' THEN 'bool'
WHEN DATA_TYPE='smallint' THEN 'Int16'
WHEN DATA_TYPE='tinyint' THEN 'Byte'
WHEN DATA_TYPE='int' THEN 'int'
WHEN DATA_TYPE='bigint' THEN 'Int64'
WHEN DATA_TYPE='money' or DATA_TYPE='numeric' THEN 'decimal'
WHEN DATA_TYPE='float' THEN 'double'
WHEN DATA_TYPE='datetime' or DATA_TYPE='smalldatetime' THEN 'DateTime?'
ELSE ''
END) + ' ' + COLUMN_NAME + '{ get; set; }')
from INFORMATION_SCHEMA.COLUMNS as col
where TABLE_NAME=@tablename

set @property = '#region Properties' + CHAR(13) + CHAR(10) + @property + CHAR(13) + CHAR(10) + '#endregion' + CHAR(13) + CHAR(10)

-----------------------------------

select 
@defaultvalue = COALESCE(@defaultvalue + CHAR(13) + CHAR(10) + 
 COLUMN_NAME + ' = ' + 
(CASE 
WHEN DATA_TYPE like '%varchar%' or DATA_TYPE like '%text%' THEN '""'
WHEN DATA_TYPE='bit' THEN 'false'
WHEN DATA_TYPE='smallint' THEN '0'
WHEN DATA_TYPE='tinyint' THEN '0'
WHEN DATA_TYPE='int' THEN '0'
WHEN DATA_TYPE='bigint' THEN '0'
WHEN DATA_TYPE='money' or DATA_TYPE='numeric' THEN '0'
WHEN DATA_TYPE='float' THEN '0'
WHEN DATA_TYPE='datetime' or DATA_TYPE='smalldatetime' THEN 'null'
ELSE ''
END), 
COLUMN_NAME + ' = ' + 
(CASE 
WHEN DATA_TYPE like '%varchar%' or DATA_TYPE like '%text%' THEN '""'
WHEN DATA_TYPE='bit' THEN 'false'
WHEN DATA_TYPE='smallint' THEN '0'
WHEN DATA_TYPE='tinyint' THEN '0'
WHEN DATA_TYPE='int' THEN '0'
WHEN DATA_TYPE='bigint' THEN '0'
WHEN DATA_TYPE='money' or DATA_TYPE='numeric' THEN '0'
WHEN DATA_TYPE='float' THEN '0'
WHEN DATA_TYPE='datetime' or DATA_TYPE='smalldatetime' THEN 'null'
ELSE ''
END)) + ';'
from INFORMATION_SCHEMA.COLUMNS 
where TABLE_NAME=@tablename

set @defaultvalue = 'public _' + @tablename + '() {' + '}' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) +
					'public _' + @tablename + '(bool setDefaultValue) {' + CHAR(13) + CHAR(10) + @defaultvalue + CHAR(13) + CHAR(10) + '}'

-----------------------------------

print 'using System;' + CHAR(13) + CHAR(10) 
print 'using System.ComponentModel.DataAnnotations;' + CHAR(13) + CHAR(10) 
print 'using System.ComponentModel.DataAnnotations.Schema;' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) 
print 'namespace ManagerLib.Models {' + CHAR(13) + CHAR(10) 


print 'public class ' + @tablename + '{' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
print '#region Extra Properties' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
print '#endregion' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) 
print @property + CHAR(13) + CHAR(10) 
print '}' + CHAR(13) + CHAR(10) 

print '[Table("' + @tablename + '")]'+CHAR(13) + CHAR(10)+'public class _' + @tablename + '{' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) 

print @defaultvalue + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10) 
print @property + CHAR(13) + CHAR(10) 

print '}' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
print '}' + CHAR(13) + CHAR(10) 

END
GO