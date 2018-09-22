CREATE TABLE [dbo].[Fornecedor] (
    [Id_Fornecedor] INT           IDENTITY (1, 1) NOT NULL,
    [RazaoSocial]   NVARCHAR (50) NULL,
    [CNPJ]          NVARCHAR (20) NULL,
    [NomeFantasia]  NVARCHAR (50) NULL,
    [InEstadual]    NVARCHAR (20) NULL,
    [Endereco]      NVARCHAR (50) NULL,
    [TipoPessoa]    NVARCHAR (12) NULL,
    [Cidade]        NVARCHAR (50) NULL,
    [Bairro]        NVARCHAR (50) NULL,
    [Estado]        NVARCHAR (30) NULL,
    [Cep]           NVARCHAR (10) NULL,
    [FoneFixo]      NVARCHAR (15) NULL,
    [FoneComercial] NVARCHAR (15) NULL,
    [Celular]       NVARCHAR (15) NULL,
    [HomePage]      NVARCHAR (50) NULL,
    [CadastradoPor] NVARCHAR (15) NULL,
    [Email]         NVARCHAR (50) NULL,
    [DataNasc]      DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id_Fornecedor] ASC)
);

