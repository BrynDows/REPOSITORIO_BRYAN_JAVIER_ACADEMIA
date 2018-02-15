CREATE TABLE [dbo].[puestos] (
    [_id]    INT          IDENTITY (1, 1) NOT NULL,
    [nombre] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([_id] ASC),
    CONSTRAINT [fk_puestos_empleados] FOREIGN KEY ([_id]) REFERENCES [dbo].[empleados] ([cuenta])
);

