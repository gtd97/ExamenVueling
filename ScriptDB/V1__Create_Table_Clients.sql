USE ExamenVueling
GO

IF OBJECT_ID(N'Covalco.dbo.Clients', N'U') IS NULL
BEGIN

CREATE TABLE dbo.Clients
(
	id uniqueidentifier NOT NULL PRIMARY KEY,
	nombre [NVARCHAR] (50) NOT NULL,
	email [NVARCHAR] (150) NOT NULL,
	[role] [NVARCHAR] (14) NOT NULL
);
END