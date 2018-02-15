CREATE TABLE empleados(
	_dni CHAR(9) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    cuenta INTEGER UNIQUE,
    puesto INTEGER UNIQUE,
    apellido VARCHAR(50) NOT NULL,
    telefono VARCHAR(50),
    direccion VARCHAR(50),
    email VARCHAR(80)
);

CREATE TABLE puestos(
	_id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    nombre VARCHAR(50) not null
);

CREATE TABLE idiomas(
	_id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    idioma VARCHAR(50)
);

CREATE TABLE empleados_idiomas(
	_dni_empleado CHAR(9) NOT NULL,
    _id_idioma INTEGER NOT NULL,
    hora_inicio TIME(0) NOT NULL,
    hora_fin TIME(0) NOT NULL
);

CREATE TABLE cuentasUsuario(
	_id INTEGER NOT NULL IDENTITY PRIMARY KEY,
    nombre_usuario VARCHAR(80) NOT NULL,
    contrasenya VARCHAR(50) NOT NULL,
    puesto VARCHAR(50) NOT NULL
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