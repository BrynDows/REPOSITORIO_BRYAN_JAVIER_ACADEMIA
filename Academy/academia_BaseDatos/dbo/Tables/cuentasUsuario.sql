CREATE TABLE [dbo].[cuentasUsuario] (
    [_id]            INT          IDENTITY (1, 1) NOT NULL,
    [nombre_usuario] VARCHAR (80) NOT NULL,
    [contrasenya]    VARCHAR (50) NOT NULL,
    [puesto]         VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([_id] ASC),
    CONSTRAINT [fk_cuentasUsuario_empleados] FOREIGN KEY ([_id]) REFERENCES [dbo].[empleados] ([cuenta])
);

