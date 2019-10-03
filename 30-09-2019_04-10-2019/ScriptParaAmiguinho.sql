create database BaseSistemaLocacao--criamos nssa base de dados 
go
use BaseSistemaLocacao-- indicamos que estamos utilizando ela para os comando logo abaixo
go
/*criação da nossa primeira tabela deo banco de dados*/
create table Usuarios
(
	   [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome ]            NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
go
create table Marcas
(
	 [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
go

CREATE TABLE [dbo].[Locacoes] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NULL,
    [CarroId]          INT      NULL,
    [Valor ]           MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DateDevolucao]    DATETIME DEFAULT (dateadd(day, (5), getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
go
CREATE TABLE [dbo].[Carros] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Marca]            NCHAR (50) NULL,
    [Modelo]           NCHAR (50) NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

Insert into Usuarios
(Nome, Login, Senha)
values
('Nando','Admin','Admin')

go

insert into Marcas
(Codigo, Nome)
values
(1,'Volkswagen'),
(2,'Chevrolet')
-- inesrir um usuario padrão como Admin Admin
--inserir dados da tabela marcas ou seja os insert