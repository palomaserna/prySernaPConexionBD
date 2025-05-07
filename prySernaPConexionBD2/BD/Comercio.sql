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
