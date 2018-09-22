CREATE TABLE [dbo].[Usuario] (
    [Id_Usuario] INT           IDENTITY (1, 1) NOT NULL,
    [Usuario]    NVARCHAR (50) NOT NULL,
    [Senha]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC)
);
