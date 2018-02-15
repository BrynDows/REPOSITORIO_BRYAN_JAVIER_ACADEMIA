use academy;
select * from puestos;
insert into puestos(nombre) values('profesor');
insert into puestos(nombre) values('director');
insert into puestos(nombre) values('cocinero');

select * from empleados;
insert into empleados values('59999978W', 'Bryan', 1, 3, ' salgado', '633554679', 'Calle da la toronja 69', 'juan@hotmail.com');
insert into empleados values('54351578W', 'Juan', null, 3, ' salgado', '633554679', 'Calle da la toronja 69', 'juan@hotmail.com');

select * from cuentasusuario;
insert into cuentasusuario (nombre_usuario, contrasenya, rol) values ('profesor_bryan@hotmail.com','1234', 1);

select * from idiomas;
insert into idiomas(idioma) values('inglés');
insert into idiomas(idioma) values('fracés');

select * from alumnos;
insert into alumnos values('sssssssss', 'Bryan', 'Tiban', '633554679', 'bryan@tiban.com', 'callde la ventisca');

select * from empleados_alumnos;
insert into empleados_alumnos values('59999978W','sssssssss',0);

select * from empleados_idiomas;
insert into empleados_idiomas values('59999978W',1,now(),now());