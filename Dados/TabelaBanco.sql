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



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/09/2018 16:27:04 ******/
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Id_User] [int] NOT NULL,
	[DataCad][datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into Usuario (nome,email,usuario,senha,Tipo,Id_user,DataCad) values ('Alex Ferreira','alexferreira@hotmail.com.br','Admin','12345','Admin',1,GETDATE());

  /****** Object:  Table [dbo].[Clientes]    Script Date: 15/09/2018 16:23:26 ******/
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[Endereco] [varchar](50) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Cep] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[FoneFixo] [varchar](50) NOT NULL,
	[FoneComercial] [varchar](50) NOT NULL,
	[Celular] [varchar](50) NOT NULL,
	[RG] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CPF] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[DataCad] [datetime] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que Cadastrou o Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'CONSTRAINT',@level2name=N'FK_Clientes_Usuario'
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 15/09/2018 16:26:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[Id_Produto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Qtd] [int] NOT NULL,
	[EAN] [varchar](20) NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
	[PrecoCompra] [float] NOT NULL,
	[Lucro] [float] NOT NULL,
	[PrecoVenda] [float] NOT NULL,
	[SubCateg] [varchar](50) NOT NULL,
	[EstoqueMin] [int] NOT NULL,
	[EstoqueMax] [int] NOT NULL,
	[Fabricante] [varchar](50) NOT NULL,
	[ICMS] [float] NOT NULL,
	[IPI] [float] NOT NULL,
	[Unidade] [varchar](10) NOT NULL,
	[DataCad] [datetime] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que Cadastrou o Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produto', @level2type=N'CONSTRAINT',@level2name=N'FK_Produto_Usuario'
GO

/****** Object:  Table [dbo].[Fornecedor]    Script Date: 15/09/2018 16:25:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Fornecedor](
	[Id_Fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[RazaoSocial] [varchar](50) NOT NULL,
	[CNPJ] [varchar](50) NOT NULL,
	[NomeFantasia] [varchar](50) NOT NULL,
	[IE] [varchar](50) NOT NULL,
	[Endereco] [varchar](50) NOT NULL,
	[TipoPessoa] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Cep] [varchar](10) NOT NULL,
	[FoneFixo] [varchar](50) NOT NULL,
	[FoneComercial] [varchar](50) NOT NULL,
	[Celular] [varchar](50) NOT NULL,
	[Site] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DataCad] [datetime] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que Cadastrou o Fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Fornecedor', @level2type=N'CONSTRAINT',@level2name=N'FK_Fornecedor_Usuario'
GO

/****** Object:  Table [dbo].[NotaFiscal]    Script Date: 15/09/2018 16:26:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NotaFiscal](
	[Id_NotaFiscal] [int] IDENTITY(1,1) NOT NULL,
	[NotaFiscalNumero] [int] NOT NULL,
	[TotalNota] [float] NOT NULL,
	[DataLanc] [datetime] NOT NULL,
	[DataVenc] [date] NOT NULL,
	[Id_Fornecedor] [int] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_NotaFiscal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NotaFiscal]  WITH NOCHECK ADD  CONSTRAINT [FK_NotaFiscal_Fornecedor] FOREIGN KEY([Id_Fornecedor])
REFERENCES [dbo].[Fornecedor] ([Id_Fornecedor])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[NotaFiscal] NOCHECK CONSTRAINT [FK_NotaFiscal_Fornecedor]
GO

ALTER TABLE [dbo].[NotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_NotaFiscal_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[NotaFiscal] CHECK CONSTRAINT [FK_NotaFiscal_Usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fornecedor da Nota Fiscal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NotaFiscal', @level2type=N'CONSTRAINT',@level2name=N'FK_NotaFiscal_Fornecedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que Lançou a Nota Fiscal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NotaFiscal', @level2type=N'CONSTRAINT',@level2name=N'FK_NotaFiscal_Usuario'
GO


/****** Object:  Table [dbo].[ItensNotaFiscal]    Script Date: 15/09/2018 16:25:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ItensNotaFiscal](
	[Id_ItemNotaFiscal] [int] IDENTITY(1,1) NOT NULL,
	[Id_Produto] [int] NOT NULL,
	[Qtd] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[PrecoUnitario] [money] NOT NULL,
	[NFNumero][int] NOT NULL,
	[Id_NotaFiscal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_ItemNotaFiscal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItensNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItensNotaFiscal_NotaFiscal] FOREIGN KEY([Id_NotaFiscal])
REFERENCES [dbo].[NotaFiscal] ([Id_NotaFiscal])
GO

ALTER TABLE [dbo].[ItensNotaFiscal] CHECK CONSTRAINT [FK_ItensNotaFiscal_NotaFiscal]
GO

ALTER TABLE [dbo].[ItensNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItensNotaFiscal_Produto] FOREIGN KEY([Id_Produto])
REFERENCES [dbo].[Produto] ([Id_Produto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ItensNotaFiscal] CHECK CONSTRAINT [FK_ItensNotaFiscal_Produto]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Itens da Nota Fiscal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItensNotaFiscal', @level2type=N'CONSTRAINT',@level2name=N'FK_ItensNotaFiscal_NotaFiscal'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Itens Nota Fiscal pode ter vários Produtos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ItensNotaFiscal', @level2type=N'CONSTRAINT',@level2name=N'FK_ItensNotaFiscal_Produto'
GO



/****** Object:  Table [dbo].[Venda]    Script Date: 15/09/2018 16:28:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Venda](
	[Id_Venda] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[DataVenda] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
	[FormaPag] [varchar](50) NOT NULL,
	[Id_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO

ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Clientes]
GO

ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Usuario]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Compras realizada pelo Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Venda', @level2type=N'CONSTRAINT',@level2name=N'FK_Venda_Clientes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuário que realizou a Venda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Venda', @level2type=N'CONSTRAINT',@level2name=N'FK_Venda_Usuario'
GO


/****** Object:  Table [dbo].[VendaItens]    Script Date: 15/09/2018 16:29:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VendaItens](
	[Id_VendaItem] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venda] [int] NOT NULL,
	[Id_Produto] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Valor_Unit] [money] NOT NULL,
	[Qtd] [int] NOT NULL,
	[Total_Item] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_VendaItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[VendaItens]  WITH CHECK ADD  CONSTRAINT [FK_VendaItens_Produto] FOREIGN KEY([Id_Produto])
REFERENCES [dbo].[Produto] ([Id_Produto])
GO

ALTER TABLE [dbo].[VendaItens] CHECK CONSTRAINT [FK_VendaItens_Produto]
GO

ALTER TABLE [dbo].[VendaItens]  WITH CHECK ADD  CONSTRAINT [FK_VendaItens_Venda] FOREIGN KEY([Id_Venda])
REFERENCES [dbo].[Venda] ([Id_Venda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[VendaItens] CHECK CONSTRAINT [FK_VendaItens_Venda]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Venda Especifica pode ter vários Produtos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VendaItens', @level2type=N'CONSTRAINT',@level2name=N'FK_VendaItens_Produto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Itens da Venda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VendaItens', @level2type=N'CONSTRAINT',@level2name=N'FK_VendaItens_Venda'
GO
