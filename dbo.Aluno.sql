﻿CREATE TABLE [dbo].[Aluno]
(
	[Matricula] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Endereco] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL
)