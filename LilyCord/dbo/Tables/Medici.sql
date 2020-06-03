CREATE TABLE [dbo].[Medici]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
    MedicId int not null,
    [Nume] VARCHAR(50) NOT NULL, 
    [Prenume] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL,
    [Grad_profesional] varchar(100) not null,
    Telefon int not null, 
    Specializare varchar(100) not null
)
