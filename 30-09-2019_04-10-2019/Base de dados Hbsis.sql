CREATE DATABASE BaseDeDadosHbsis

GO

USE BaseDeDadosHbsis

GO

CREATE TABLE [dbo].[Marca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Codigo] INT NOT NULL, 
    [Marca] NCHAR(15) NOT NULL
)

GO

CREATE TABLE [dbo].[Veiculos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [TipodeVeiculo] INT NOT NULL, --(0)MOTO, (1)CARRO, (2)VEICULOS DE CARGA
    [CodigoMarca ] INT NOT NULL, 
    [Modelo] NCHAR(15) NOT NULL
)
