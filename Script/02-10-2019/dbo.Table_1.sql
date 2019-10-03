CREATE TABLE [dbo].[Salario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Funcionario] NCHAR(50) NOT NULL, 
    [Valor] MONEY NULL,
	[Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL, 
    [UsuarioAlteracao] INT NULL, 
    [DataCriacao] DATETIME NULL, 
    [DataAlteracao] DATETIME NULL
)
