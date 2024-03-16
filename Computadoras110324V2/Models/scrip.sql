create database ComputadorasEYCD110324DbV2

USE ComputadorasEYCD110324DbV2

CREATE TABLE Computadoras(
Id INT PRIMARY KEY IDENTITY(1,1),
FechaLlegada date NOT NULL,
Marca VARCHAR (50) NOT NULL,
Tipo VARCHAR (50) NOT NULL
)

CREATE TABLE Componentes(
Id INT PRIMARY KEY IDENTITY (1,1),
IdComputadoras INT NOT NULL,
Procesador VARCHAR(50) NOT NULL,
MemoriaRAMGB INT NOT NULL,
AlmacenamientoGB INT NOT NULL,
FOREIGN KEY (IdComputadoras) REFERENCES Computadoras (Id)
)