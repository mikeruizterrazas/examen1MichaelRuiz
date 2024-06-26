CREATE DATABASE GESTIONDEEMPLEADOS


CREATE TABLE Persona (
IDPersona INT IDENTITY (1,1)NOT NULL,
Nombre	NVARCHAR(255) NOT NULL,
Apellido NVARCHAR(255) NOT NULL,
Estado NVARCHAR(20) NOT NULL,
PRIMARY KEY(IDPERSONA),
);

CREATE TABLE Empleado(
IDEmpleado INT IDENTITY (1,1) NOT NULL,
IDPersona INT NOT NULL,
Puesto NVARCHAR(20) NOT NULL,
Salario MONEY NOT NULL,
FechaContratacion DATETIME NOT NULL,
PRIMARY KEY(IDEmpleado),
FOREIGN KEY (IDPersona) REFERENCES Persona (IDPersona),
);