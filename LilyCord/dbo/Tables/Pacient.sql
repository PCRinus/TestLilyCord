CREATE TABLE [dbo].[Pacient]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Email] varchar(1000) Not null,
    [Nume] VARCHAR(100) NOT NULL, 
    [Prenume] VARCHAR(100) NOT NULL,  
    [CNP] BIGINT NOT NULL, 
    [Adresa] VARCHAR(2000) NOT NULL, 
    [Telefon] BIGINT NOT NULL, 
    [Varsta] INT NOT NULL, 
    [Inaltime] INT NOT NULL, 
    [Greutate] INT NOT NULL, 
    [Diagnostic] VARCHAR(1000) NULL

)
