insert into Funcionarios

(Nome)
values
('Henrique','06/07/2019' ),
('Rogerio', '07/05/2019' ),
('Cleiton', '08,07/2019' )
UPDATE Funcionarios
set Ativo = 1
select * from Funcionarios

CREATE TABLE [dbo].[Funcionarios] 
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (50) NOT NULL,
    [DataInicio]       DATETIME   NOT NULL,
    [DataSaida]        DATETIME   NULL,
    [Ativo]            BIT  NULL  DEFAULT ((1)),
    [UsuarioCriacao]   INT        NULL DEFAULT ((0)),
    [UsuarioAlteracao] INT        NULL DEFAULT ((0)),
    [DataCriacao]      DATETIME   NULL DEFAULT (GETDATE()),
    [DataAlteracao]    DATETIME   NULL DEFAULT (GETDATE()),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Salario] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Funcionario]      NCHAR (50) NOT NULL,
    [Valor]            MONEY      NOT NULL,
    [Ativo]            BIT        DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT        NULL,
    [UsuarioAlteracao] INT        NULL,
    [DataCriacao]      DATETIME   NULL,
    [DataAlteracao]    DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

 