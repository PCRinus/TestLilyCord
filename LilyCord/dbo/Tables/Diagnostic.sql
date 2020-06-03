CREATE TABLE [dbo].[Diagnostic]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Diagnostic] VARCHAR(1000) NOT NULL, 
    [Investigatii_efectuate] VARCHAR(1000) NOT NULL, 
    [Rezultat_investigatii] VARCHAR(1000) NOT NULL, 
    [Tratament] VARCHAR(1000) NULL, 
    [Medicatie] VARCHAR(1000) NULL, 
    [Email] VARCHAR(1000) NULL

)
