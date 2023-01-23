CREATE TABLE [dbo].[Usuarios]
(
    [idUsuario] INT NOT NULL IDENTITY, 
    [login] NCHAR(50) NOT NULL, 
    [senha] NCHAR(50) NOT NULL, 
    PRIMARY KEY ([idUsuario])
)
