
CREATE DATABASE BD_CLIENTES;
GO

USE BD_CLIENTES;
GO

CREATE TABLE TiposDocumentos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Descripcion VARCHAR(100) NOT NULL
);
GO

INSERT INTO TiposDocumentos (Descripcion) VALUES ('DNI');
INSERT INTO TiposDocumentos (Descripcion) VALUES ('RUC');
INSERT INTO TiposDocumentos (Descripcion) VALUES ('Pasaporte');
GO