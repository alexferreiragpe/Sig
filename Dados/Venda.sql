CREATE TABLE [dbo].[Venda] (
    [Id_Venda]    INT           IDENTITY (1, 1) NOT NULL,
    [CodCliente]  INT           NOT NULL,
    [NomeCliente] NVARCHAR (50) NOT NULL,
    [Data]        DATE          NOT NULL,
    [Valor]       NVARCHAR(50)    NOT NULL,
    [FormaPag]    NVARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Venda] ASC)
);