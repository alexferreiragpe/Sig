CREATE TABLE [dbo].[Produto] (
    [Id_Produto]    INT           IDENTITY (1, 1) NOT NULL,
    [Descri]        VARCHAR (100) NOT NULL,
    [Qtde]          INT           NULL,
    [CodEAN]        VARCHAR (20)  NOT NULL,
    [Categoria]     VARCHAR (50)  NOT NULL,
    [PrecoCompra]   FLOAT (53)    NOT NULL,
    [Lucro]         FLOAT (53)    NOT NULL,
    [PrecoVenda]    FLOAT (53)    NOT NULL,
    [SubCateg]      VARCHAR (50)  NOT NULL,
    [EstoqueMin]    INT           NOT NULL,
    [EstoqueMax]    INT           NOT NULL,
    [Fabricante]    VARCHAR (50)  NOT NULL,
    [ICMS]          INT           NOT NULL,
    [IPI]           INT           NOT NULL,
    [Unidade]       VARCHAR (50)  NOT NULL,
    [CadastradoPor] VARCHAR (50)  NOT NULL,
    [DataCad]       DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Produto] ASC)
);

