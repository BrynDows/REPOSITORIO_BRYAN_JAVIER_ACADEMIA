CREATE TABLE [dbo].[empleados_idiomas] (
    [_dni_empleado] CHAR (9) NOT NULL,
    [_id_idioma]    INT      NOT NULL,
    [hora_inicio]   TIME (0) NOT NULL,
    [hora_fin]      TIME (0) NOT NULL,
    CONSTRAINT [pk_empleadosIdiomas] PRIMARY KEY CLUSTERED ([_dni_empleado] ASC, [_id_idioma] ASC),
    CONSTRAINT [fk_empleadosIdiomas_empleados] FOREIGN KEY ([_dni_empleado]) REFERENCES [dbo].[empleados] ([_dni]),
    CONSTRAINT [fk_empleadosIdiomas_idiomas] FOREIGN KEY ([_id_idioma]) REFERENCES [dbo].[idiomas] ([_id])
);

