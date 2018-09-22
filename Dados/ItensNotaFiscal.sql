CREATE TABLE [dbo].[ItensNotaFiscal] (
    [Id_ItemNotaFiscal] INT          IDENTITY (1, 1) NOT NULL,
    [Id_Produto]        INT          NOT NULL,
	[Cod_EAN]           VARCHAR (20) NOT NULL,
    [Descricao]         VARCHAR (50) NOT NULL,
    [Quantidade]        INT          NOT NULL,
    [PrecoUnitario]     FLOAT NOT NULL,    
    [Fabricante]        VARCHAR (50) NOT NULL,
    [NumeroNF]          INT          NOT NULL,
	[DataLanc] DATE         NOT NULL,   
    PRIMARY KEY CLUSTERED ([Id_ItemNotaFiscal] ASC)
);