CREATE TABLE [dbo].[alumnos] (
    [_dni]      CHAR (9)     NOT NULL,
    [nombre]    VARCHAR (50) NULL,
    [apellido]  VARCHAR (50) NULL,
    [telefono]  VARCHAR (50) NULL,
    [email]     VARCHAR (80) NULL,
    [direccion] VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([_dni] ASC)
);

