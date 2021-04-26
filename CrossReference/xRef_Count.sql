set nocount on
select count(*) AS [Count xref_AppInstance] from xref_AppInstance
go
select count(*) AS [Count xref_AppType] from xref_AppType
go
select count(*) AS [Count xref_IDXRef] from xref_IDXRef
go
select count(*) AS [Count xref_IDXRefData] from xref_IDXRefData
go
select count(*) AS [Count xref_MessageArgument] from xref_MessageArgument
go
select count(*) AS [Count xref_MessageDef] from xref_MessageDef
go
select count(*) AS [Count xref_MessageText] from xref_MessageText
go
select count(*) AS [Count xref_ValueXRef] from xref_ValueXRef
go
select count(*) AS [Count xref_ValueXRefData] from xref_ValueXRefData
go