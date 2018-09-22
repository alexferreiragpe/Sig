  CREATE DATABASE [Dados]
  GO
  USE [Dados]
  GO
  IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Dados] MODIFY FILEGROUP [PRIMARY] DEFAULT
  GO
  /*
  Alterar Permiss�o do banco
  ALTER AUTHORIZATION ON DATABASE::[Dados] TO sa
  */
  CREATE TABLE [dbo].[Clientes] (
    [Id_Cliente]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]              VARCHAR(50) NOT NULL,
    [Sexo]              VARCHAR(50) NOT NULL,
    [Endereco]          VARCHAR(50) NOT NULL,
    [Bairro]            VARCHAR(50) NOT NULL,
    [Cidade]            VARCHAR(50) NOT NULL,
    [Cep]               VARCHAR(50) NOT NULL,
    [Estado]            VARCHAR(50) NOT NULL,
    [FoneFixo]      VARCHAR(50) NOT NULL,
    [FoneComercial] VARCHAR(50) NOT NULL,
    [Celular]           VARCHAR(50) NOT NULL,
    [RG]                VARCHAR(50) NOT NULL,
    [Email]             VARCHAR(50) NOT NULL,
    [CPF]         VARCHAR (50)  NOT NULL,
    [DataNascimento]    DATE          NOT NULL,
    [DataCad] DATETIME NOT NULL,
    [Id_Usuario] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC)
  );


  CREATE TABLE [dbo].[VendaItens] (
    [Id_VendaItem]  INT           IDENTITY (1, 1) NOT NULL,
    [Id_Venda]      INT NOT NULL,
    [Id_Produto]    INT NOT NULL,
    [Descricao] VARCHAR(50) NOT NULL,
    [Valor_Unit]    MONEY NOT NULL,
    [Qtd]          INT NOT NULL,
    [Total_Item]    MONEY NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_VendaItem] ASC)
  );


  CREATE TABLE [dbo].[Venda] (
    [Id_Venda]    INT           IDENTITY (1, 1) NOT NULL,
    [Id_Cliente]  INT           NOT NULL,
    [DataVenda] DATETIME NOT NULL,
    [Total]        MONEY          NOT NULL,
    [FormaPag]       VARCHAR(50) NOT NULL,
    [Id_Usuario]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Venda] ASC)
  );

  CREATE TABLE [dbo].[Usuario] (
    [Id_Usuario] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR(50) NOT NULL,
    [Email]      VARCHAR(50) NOT NULL,
    [Usuario]    VARCHAR(50) NOT NULL,
    [Senha]      VARCHAR(50) NOT NULL,
    [Tipo] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC)
  );

  CREATE TABLE [dbo].[Produto] (
    [Id_Produto]    INT           IDENTITY (1, 1) NOT NULL,
    [Descricao]        VARCHAR (100) NOT NULL,
    [Qtd]          INT           NOT NULL,
    [EAN]        VARCHAR (20)  NOT NULL,
    [Categoria]     VARCHAR (50)  NOT NULL,
    [PrecoCompra]   MONEY    NOT NULL,
    [Lucro]         FLOAT (53)    NOT NULL,
    [PrecoVenda]    MONEY    NOT NULL,
    [SubCateg]      VARCHAR (50)  NOT NULL,
    [EstoqueMin]    INT           NOT NULL,
    [EstoqueMax]    INT           NOT NULL,
    [Fabricante]    VARCHAR (50)  NOT NULL,
    [ICMS]          FLOAT           NOT NULL,
    [IPI]           FLOAT           NOT NULL,
    [Unidade]       VARCHAR (10)  NOT NULL,
    [DataCad] DATETIME  NOT NULL,
    [Id_Usuario]       INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Produto] ASC)
  );

  CREATE TABLE [dbo].[Fornecedor] (
    [Id_Fornecedor] INT           IDENTITY (1, 1) NOT NULL,
    [RazaoSocial]   VARCHAR(50) NOT NULL,
    [CNPJ]          VARCHAR(50) NOT NULL,
    [NomeFantasia]  VARCHAR(50) NOT NULL,
    [IE]			VARCHAR(50) NOT NULL,
    [Endereco]      VARCHAR(50) NOT NULL,
    [TipoPessoa]    VARCHAR(50) NOT NULL,
    [Cidade]        VARCHAR(50) NOT NULL,
    [Bairro]        VARCHAR(50) NOT NULL,
    [Estado]        VARCHAR(50) NOT NULL,
    [Cep]           VARCHAR(10) NOT NULL,
    [FoneFixo]      VARCHAR(50) NOT NULL,
    [FoneComercial] VARCHAR(50) NOT NULL,
    [Celular]       VARCHAR(50) NOT NULL,
    [Site]			VARCHAR(50) NOT NULL,
    [Email]			VARCHAR(50) NOT NULL,
    [DataCad]       DATETIME NOT NULL,
    [Id_Usuario]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Fornecedor] ASC)
  );

  CREATE TABLE [dbo].[ItensNotaFiscal] (
    [Id_ItemNotaFiscal] INT          IDENTITY (1, 1) NOT NULL,
    [Id_Produto]        INT          NOT NULL,
    [Qtd]           INT NOT NULL,
    [Descricao]         VARCHAR (50) NOT NULL,
    [PrecoUnitario]        MONEY          NOT NULL,
    [Id_NotaFiscal]     INT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_ItemNotaFiscal] ASC)
  );

  CREATE TABLE [dbo].[NotaFiscal] (
    [Id_NotaFiscal] INT          IDENTITY (1, 1) NOT NULL,
    [NotaFiscalNumero]    INT          NOT NULL,
    [TotalNota]     FLOAT (53)   NOT NULL,
    [DataLanc]      DATETIME         NOT NULL,
    [DataVenc]      DATE         NOT NULL,
    [Id_Fornecedor]    INT NOT NULL,
    [Id_Usuario] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_NotaFiscal] ASC)
  );

  insert into Usuario (nome,email,usuario,senha,Tipo) values ('Alex Ferreira','alexferreira@hotmail.com.br','Admin','12345','Admin');
