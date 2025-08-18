  CREATE DATABASE CONTROL_ESCOLAR;
USE CONTROL_ESCOLAR;

-- Tabla ALUMNO
CREATE TABLE ALUMNO (
    Matricula INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50),
    Apellidos VARCHAR(80),
    Fecha_Nac DATE,
    Correo VARCHAR(100),
    Estatus VARCHAR(10) DEFAULT 'ACTIVO' CHECK (Estatus IN ('ACTIVO', 'INACTIVO'))
);

-- Tabla ASIGNATURA
CREATE TABLE ASIGNATURA (
    ID_Asignatura INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50),
    Descripcion VARCHAR(255)

);

select * from ALUMNO 
where Matricula = 4


select STRING_AGG(ASIGNATURA.Nombre, ', ')
from ASIGNATURA, CURSA, ALUMNO
where ASIGNATURA.ID_Asignatura = CURSA.ID_Asignatura
AND CURSA.Matricula = ALUMNO.Matricula
AND ALUMNO.Matricula = 1;

UPDATE ALUMNO
SET Nombre = '', Apellidos = '', Correo = ''
WHERE Matricula = '';
-- Tabla CURSA
CREATE TABLE CURSA (
    Matricula INT FOREIGN KEY REFERENCES ALUMNO(Matricula),
    ID_Asignatura INT FOREIGN KEY REFERENCES ASIGNATURA(ID_Asignatura),
    Periodo VARCHAR(20),
    Calificacion DECIMAL(4,2) NULL, 
    PRIMARY KEY (Matricula, ID_Asignatura, Periodo)
);

-- Nueva tabla ASISTENCIA
CREATE TABLE ASISTENCIA (
    ID_Asistencia INT PRIMARY KEY IDENTITY(1,1),
    Matricula INT FOREIGN KEY REFERENCES ALUMNO(Matricula),
    ID_Asignatura INT FOREIGN KEY REFERENCES ASIGNATURA(ID_Asignatura),
    Fecha DATE, -- Fecha de la asistencia
    Estado VARCHAR(11) CHECK (Estado IN ('PRESENTE', 'AUSENTE', 'JUSTIFICADO')), -- Estado de la asistencia

);

select *  from ALUMNO
select *  from ASIGNATURA
select *  from ASISTENCIA
select *  from CURSA
insert into ASIGNATURA ( Nombre, Descripcion) VALUES ('MATEMÁTICAS', 'Esta materia aborda la resolución de problemas con operaciones básicas, el uso de fracciones y decimales, y la introducción a la geometría.');

insert into ASIGNATURA  ( NOMBRE, Descripcion) VALUES ( 'CIENCIAS NATURALES', 'En esta materia se explora el cuerpo humano, el ecosistema, la relación entre los seres vivos y su entorno, y las propiedades de la materia.');

insert into ASIGNATURA ( NOMBRE, Descripcion) VALUES ( 'HISTORIA', 'Esta materia se enfoca en los principales eventos y personajes de la historia de México, desde la Conquista hasta el México independiente.');

insert into ASIGNATURA ( NOMBRE, Descripcion) VALUES ( 'GEOGRAFÍA', 'Aquí se estudian los componentes naturales, sociales, económicos y políticos del espacio geográfico de México y el mundo.');

insert into ASIGNATURA  ( NOMBRE, Descripcion) VALUES ( 'CÍVICA Y ÉTICA', 'Esta materia promueve los valores para la convivencia, el respeto a los derechos humanos y la importancia de la participación ciudadana.');




