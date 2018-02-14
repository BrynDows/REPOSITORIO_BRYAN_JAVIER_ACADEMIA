ALTER TABLE empleados_idiomas 
	ADD CONSTRAINT pk_empleadosIdiomas PRIMARY KEY(_dni_empleado,_id_idioma);
    
ALTER TABLE empleados_alumnos
	ADD CONSTRAINT pk_empleadosAlumnos PRIMARY KEY(_dni_profesor, _dni_alumno);

ALTER TABLE cuentasUsuario
	ADD CONSTRAINT fk_cuentasUsuario_empleados FOREIGN KEY(_id) REFERENCES empleados(cuenta);
    
ALTER TABLE puestos
	ADD CONSTRAINT fk_puestos_empleados FOREIGN KEY(_id) REFERENCES empleados(cuenta);
    
ALTER TABLE empleados_idiomas
	ADD CONSTRAINT fk_empleadosIdiomas_idiomas FOREIGN KEY (_id_idioma) REFERENCES idiomas(_id),
    ADD CONSTRAINT fk_empleadosIdiomas_empleados FOREIGN KEY (_dni_empleado) REFERENCES empleados(_dni);
    
ALTER TABLE empleados_alumnos
	ADD CONSTRAINT fk_empleadosAlumnos_empleados FOREIGN KEY (_dni_profesor) REFERENCES empleados(_dni),
    ADD CONSTRAINT fk_empleadosAlumnos_alumnos FOREIGN KEY (_dni_alumno) REFERENCES  alumnos(_dni);