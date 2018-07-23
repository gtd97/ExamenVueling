USE ExamenVueling
GO
IF OBJECT_ID(N'Covalco.dbo.Policies', N'U') IS NULL
BEGIN

CREATE TABLE dbo.Policies
(
	id uniqueidentifier NOT NULL PRIMARY KEY,
	amountInsured [Float] NOT NULL,
	email [NVARCHAR] (150) NOT NULL,
	inceptionDate [Date] NOT NULL,
	installmentPayment [Bit] NOT NULL,
	clientId uniqueidentifier NOT NULL,
	CONSTRAINT FK_IdClient FOREIGN KEY (clientId) REFERENCES Clients (id) ON DELETE CASCADE ON UPDATE CASCADE
);

END