CREATE TABLE [dbo].[empleados_alumnos] (
    [_dni_profesor] CHAR (9)   NOT NULL,
    [_dni_alumno]   CHAR (9)   NOT NULL,
    [nota]          FLOAT (53) NULL,
    CONSTRAINT [pk_empleadosAlumnos] PRIMARY KEY CLUSTERED ([_dni_profesor] ASC, [_dni_alumno] ASC),
    CONSTRAINT [fk_empleadosAlumnos_alumnos] FOREIGN KEY ([_dni_alumno]) REFERENCES [dbo].[alumnos] ([_dni]),
    CONSTRAINT [fk_empleadosAlumnos_empleados] FOREIGN KEY ([_dni_profesor]) REFERENCES [dbo].[empleados] ([_dni])
);

