DROP DATABASE IF EXISTS academy;
CREATE DATABASE academy ;
USE academy;

CREATE TABLE IF NOT EXISTS empleados(
	_dni CHAR(9) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    cuenta INTEGER UNIQUE KEY,
    puesto INTEGER UNIQUE KEY,
    apellido VARCHAR(50) NOT NULL,
    telefono VARCHAR(50),
    direccion VARCHAR(50),
    email VARCHAR(80)
);

CREATE TABLE IF NOT EXISTS puestos(
	_id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50) not null
);

CREATE TABLE IF NOT EXISTS idiomas(
	_id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    idioma VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS empleados_idiomas(
	_dni_empleado CHAR(9) NOT NULL,
    _id_idioma INTEGER NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL
);

CREATE TABLE IF NOT EXISTS cuentasUsuario(
	_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_usuario VARCHAR(80) NOT NULL,
    contrasenya VARCHAR(50) NOT NULL,
    puesto VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS alumnos(
	_dni CHAR(9) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    telefono VARCHAR(50),
    email VARCHAR(80),
    direccion varchar(80)
    
);

CREATE TABLE IF NOT EXISTS empleados_alumnos(
	_dni_profesor CHAR(9) NOT NULL,
    _dni_alumno CHAR(9) NOT NULL,
    nota DOUBLE
);
