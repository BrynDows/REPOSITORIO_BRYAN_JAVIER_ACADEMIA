CREATE TABLE [dbo].[empleados] (
    [_dni]      CHAR (9)     NOT NULL,
    [nombre]    VARCHAR (50) NOT NULL,
    [cuenta]    INT          NULL,
    [puesto]    INT          NULL,
    [apellido]  VARCHAR (50) NOT NULL,
    [telefono]  VARCHAR (50) NULL,
    [direccion] VARCHAR (50) NULL,
    [email]     VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([_dni] ASC),
    UNIQUE NONCLUSTERED ([cuenta] ASC),
    UNIQUE NONCLUSTERED ([puesto] ASC)
);

