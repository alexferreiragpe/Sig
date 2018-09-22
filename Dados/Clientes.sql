CREATE TABLE [dbo].[Clientes] (
    [Id_Cliente]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]              NVARCHAR (50) NULL,
    [Sexo]              NVARCHAR (50) NULL,
    [Endereco]          NVARCHAR (50) NULL,
    [Bairro]            NVARCHAR (50) NULL,
    [Cidade]            NVARCHAR (50) NULL,
    [Cep]               NVARCHAR (50) NULL,
    [Estado]            NVARCHAR (50) NULL,
    [TelefoneFixo]      NVARCHAR (50) NULL,
    [TelefoneComercial] NVARCHAR (50) NULL,
    [Celular]           NVARCHAR (50) NULL,
    [RG]                NVARCHAR (50) NULL,
    [Email]             NVARCHAR (50) NULL,
    [CPFNumero]         VARCHAR (50)  NULL,
    [DataNascimento]    DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC)
);

