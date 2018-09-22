CREATE TABLE [dbo].[VendaItens] (
    [Id_VendaItem]  INT           IDENTITY (1, 1) NOT NULL,
    [Id_Venda]      NVARCHAR(50)           NOT NULL,
    [Id_Cliente]    NVARCHAR(50)           NOT NULL,
    [ProdutoCodEan] NVARCHAR(50)           NOT NULL,
    [Descricao]     NVARCHAR (50) NOT NULL,
    [Valor_Unit]     NVARCHAR (50) NOT NULL,
    [Qtde]          NVARCHAR(50)           NOT NULL,
    [Total_Item]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_VendaItem] ASC)
);
