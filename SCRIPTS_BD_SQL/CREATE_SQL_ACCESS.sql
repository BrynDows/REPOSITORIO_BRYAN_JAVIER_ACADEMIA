CREATE TABLE empleados(
	_dni CHAR(9) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    cuenta INTEGER,
    puesto INTEGER,
    apellido VARCHAR(50) NOT NULL,
    telefono VARCHAR(50),
    direccion VARCHAR(50),
    email VARCHAR(80)
);

CREATE TABLE puestos(
	_id COUNTER NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) not null UNIQUE
);

CREATE TABLE idiomas(
	_id COUNTER NOT NULL PRIMARY KEY,
    idioma VARCHAR(50) not null UNIQUE
);

CREATE TABLE empleados_idiomas(
	_dni_empleado CHAR(9) NOT NULL,
    _id_idioma INTEGER NOT NULL,
    hora_inicio VARCHAR(20) NOT NULL,
    hora_fin VARCHAR(20) NOT NULL
);

CREATE TABLE cuentasUsuario(
	_id COUNTER NOT NULL PRIMARY KEY,
    nombre_usuario VARCHAR(80) NOT NULL UNIQUE,
    contrasenya VARCHAR(50) NOT NULL,
    rol VARCHAR(50) NOT NULL
);

CREATE TABLE alumnos(
	_dni CHAR(9) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    telefono VARCHAR(50),
    email VARCHAR(80),
    direccion varchar(80)
    
);

CREATE TABLE empleados_alumnos(
	_dni_profesor CHAR(9) NOT NULL,
    _dni_alumno CHAR(9) NOT NULL,
    nota FLOAT
);
