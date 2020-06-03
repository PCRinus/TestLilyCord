CREATE TABLE [dbo].[Medici]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [medicID] INT NOT NULL, 
    [prenume] VARCHAR(50) NOT NULL, 
    [nume] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL
)
