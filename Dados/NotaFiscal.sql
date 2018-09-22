CREATE TABLE [dbo].[NotaFiscal] (
    [Id_NotaFiscal]  INT          IDENTITY (1, 1) NOT NULL,
    [NotaFiscal]     INT          NOT NULL,
	[TotalNota]      FLOAT (53)   NOT NULL,
    [DataLanc] DATE         NOT NULL,
	[DataVenc] DATE         NOT NULL,    
	[Fornecedor]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_NotaFiscal] ASC)
);

