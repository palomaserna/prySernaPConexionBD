CREATE DATABASE Comercio;
USE Comercio;
CREATE TABLE Categorias (
Id INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(50)
);

CREATE TABLE Productos (
Codigo INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Descripcion NVARCHAR(255),
Precio DECIMAL(10,2),
Stock INT,
CategoriaId INT,
FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
);

CREATE TABLE Usuarios (
Codigo INT PRIMARY KEY IDENTITY,
Usuario NVARCHAR(100),
Contrase�a NVARCHAR (50)
);
Create table Contactos(
Codigo INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Apellido NVARCHAR(100),
Telefono INT,
Correo NVARCHAR(100),
CategoriaId INT);

-- Insertar categor�as
INSERT INTO Categorias (Nombre) VALUES ('Tecnolog�a'), ('Hogar'), ('Ropa');

-- Insertar productos
INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
('Notebook Lenovo', 'Notebook i5 8GB RAM', 850000, 10, 1),
('Licuadora Philips&', '600W, vaso de vidrio', 320000, 5, 2),
('Camisa Blanca', 'Manga larga, algod�n', 180000, 15, 3);

Insert into Usuarios (Usuario, Contrase�a) Values
('PalomaSerna', '45833499'),
('SernaPaloma', '45833499');
INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, CategoriaId) VALUES 
('Juan', 'P�rez', 555123456, 'juan.perez@example.com', 1),
('Mar�a', 'G�mez', 555987654, 'maria.gomez@example.com', 2),
('Luis', 'Rodr�guez', 555654321, 'luis.rodriguez@example.com', 1),
('Ana', 'L�pez', 555112233, 'ana.lopez@example.com', 3),
('Carlos', 'Mart�nez', 555223344, 'carlos.martinez@example.com', 2),
('Luc�a', 'Hern�ndez', 555334455, 'lucia.hernandez@example.com', 1),
('Pedro', 'Ram�rez', 555445566, 'pedro.ramirez@example.com', 3),
('Sof�a', 'Torres', 555556677, 'sofia.torres@example.com', 2),
('Diego', 'S�nchez', 555667788, 'diego.sanchez@example.com', 1),
('Laura', 'Castro', 555778899, 'laura.castro@example.com', 3);
