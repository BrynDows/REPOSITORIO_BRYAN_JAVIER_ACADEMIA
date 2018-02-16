insert into puestos(nombre) values('profesor');
insert into puestos(nombre) values('jefe');
insert into puestos(nombre) values('administrador');
insert into puestos(nombre) values('recepcionista');
insert into puestos(nombre) values('limpiador');
insert into puestos(nombre) values('contable');
select * from puestos;

insert into empleados values('11111111A', 'Arturo', null, 4, ' Gonzalez Paredes', '611111111', 'Calle de la luz 10 bajo 2', 'arturo_gonzalez@hotmail.com');
insert into empleados values('22222222B', 'Marina',null, 1, ' Gutierrez Marín', '622222222', 'Calle da la toronja 69 ', 'marina_gutierres@hotmil.com');
insert into empleados values('88888888B', 'Javier',null, 1, ' Gutierrez Marín', '622222222', 'Calle da la toronja 69 ', 'marina_gutierres@hotmil.com');
insert into empleados values('33333333C', 'Ana', null, 3, 'López López', '611122211', 'Calle de alberto quesada 85 piso 4F', 'ana_lopez_lopez@hotmail.com');
insert into empleados values('44444444E', 'Marcos',null,2, 'Nevada', '611144558', 'Calle puerta castañeda nº6 9E', 'marcos_nevada@gmail.com');
insert into empleados values('55555555F', 'Andrés', null, 5, 'Tolín', '666666655', 'Calle emilio torres portal 5 piso 2E', 'andres_savaedra@hotmail.com');
insert into empleados values('66666666G', 'Ricardo', null, 6, 'Alarcón', '654125852', 'Calle doctor quesada portal 3 4F', 'ricardo_alarcon@hotmail.com');
select * from empleados;

insert into cuentasusuario (nombre_usuario, contrasenya, rol) values ('marina@academy.com','1234', 1);
insert into cuentasusuario (nombre_usuario, contrasenya, rol) values ('marcos@academy.com','1234', 2);
insert into cuentasusuario (nombre_usuario, contrasenya, rol) values ('javier@academy.com','1234', 1);
select * from cuentasusuario;

insert into idiomas(idioma) values('Inglés');
insert into idiomas(idioma) values('Francés');
insert into idiomas(idioma) values('Italiano');
insert into idiomas(idioma) values('Español');
select * from idiomas;

insert into alumnos values('00000000A', 'Alberto', 'Torres', '633554679', 'alberto_torres@hotmail.com', 'callde la ventisca porta 8 piso 4F');
insert into alumnos values('00000020A', 'Ramon', 'Ortíz', '633555679', 'ramon_ortiz@hotmail.com', 'callde la piedra porta 8 piso 4F');
insert into alumnos values('00000030A', 'Pamela', 'Torres', '636664679', 'pamela_torres@hotmail.com', 'callde la torre porta 8 piso 4F');
insert into alumnos values('00000040A', 'Jose', 'Pérez', '633777679','jose_perez@hotmail.com', 'callde la luna porta 8 piso 4F');
insert into alumnos values('00000050A', 'Sebastián', 'Teledo', '638884679', 'sebastian_teledo@hotmail.com', 'callde la rana porta 8 piso 4F');
insert into alumnos values('00000060A', 'Pedro', 'polo', '633999679', 'pedro_polo@hotmail.com', 'callde la patata porta 8 piso 4F');
select * from alumnos;

insert into empleados_alumnos values('22222222B', '00000000A',1);
insert into empleados_alumnos values('22222222B', '00000020A',1);
insert into empleados_alumnos values('88888888B', '00000030A',1);
insert into empleados_alumnos values('88888888B', '00000040A',2);
insert into empleados_alumnos values('88888888B', '00000050A',3);
insert into empleados_alumnos values('22222222B', '00000060A',4);
select * from empleados_alumnos;

insert into empleados_idiomas values('22222222B',1,getdate(),getdate());
insert into empleados_idiomas values('88888888B',2,getdate(),getdate());
insert into empleados_idiomas values('88888888B',3,getdate(),getdate());
insert into empleados_idiomas values('22222222B',4,getdate(),getdate());
select * from empleados_idiomas;
