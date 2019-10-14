CREATE TABLE [dbo].[Funcionarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] NCHAR(50) NOT NULL, 
    [DataInicio] DATETIME NULL, 
    [DataSaida] DATETIME NULL, 
    [Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL, 
    [UsuarioAlteracao] INT NULL, 
    [DataCriacao] DATETIME NULL, 
    [DataAlteracao] DATETIME NULL
)
