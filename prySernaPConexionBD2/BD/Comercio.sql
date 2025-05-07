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
Contraseña NVARCHAR (50)
);
Create table Contactos(
Codigo INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Apellido NVARCHAR(100),
Telefono INT,
Correo NVARCHAR(100),
CategoriaId INT);

-- Insertar categorías
INSERT INTO Categorias (Nombre) VALUES ('Tecnología'), ('Hogar'), ('Ropa');

-- Insertar productos
INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
('Notebook Lenovo', 'Notebook i5 8GB RAM', 850000, 10, 1),
('Licuadora Philips&', '600W, vaso de vidrio', 320000, 5, 2),
('Camisa Blanca', 'Manga larga, algodón', 180000, 15, 3);

Insert into Usuarios (Usuario, Contraseña) Values
('PalomaSerna', '45833499'),
('SernaPaloma', '45833499');
INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, CategoriaId) VALUES 
('Juan', 'Pérez', 555123456, 'juan.perez@example.com', 1),
('María', 'Gómez', 555987654, 'maria.gomez@example.com', 2),
('Luis', 'Rodríguez', 555654321, 'luis.rodriguez@example.com', 1),
('Ana', 'López', 555112233, 'ana.lopez@example.com', 3),
('Carlos', 'Martínez', 555223344, 'carlos.martinez@example.com', 2),
('Lucía', 'Hernández', 555334455, 'lucia.hernandez@example.com', 1),
('Pedro', 'Ramírez', 555445566, 'pedro.ramirez@example.com', 3),
('Sofía', 'Torres', 555556677, 'sofia.torres@example.com', 2),
('Diego', 'Sánchez', 555667788, 'diego.sanchez@example.com', 1),
('Laura', 'Castro', 555778899, 'laura.castro@example.com', 3);
