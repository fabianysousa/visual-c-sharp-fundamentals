CREATE DATABASE BDAula;

USE BDAula;
GO

CREATE TABLE Clientes (
CodigoCliente int not null primary key,
Nome varchar(30) not null,
Endereco varchar(50) not null,
Cidade varchar(20),
Estado char(2)
);

CREATE TABLE Filiais (
CodigoFilial int not null primary key,
Cidade varchar(30) not null,
Regiao varchar(20)
)

CREATE TABLE Vendedores (
CodigoVendedor int not null primary key,
Nome varchar(30) not null,
Sexo char(1) not null,
DataNascimento date not null,
Vendas real not null,
Codfifial int not null foreign key references Filiais(CodigoFilial)
)

INSERT INTO Clientes (CodigoCliente,Nome,Endereco,Cidade,Estado)
VALUES (1,'Mateus','Rua- ABC 100','Fortaleza','CE');

GO

INSERT INTO Clientes (CodigoCliente,Nome,Endereco,Cidade,Estado)
VALUES (2,'Adriana','Av. XYZ, 54','Recife','PE');

GO

UPDATE Clientes
SET Cidade = 'Sobral'
WHERE Cidade = 'Fortaleza';

GO

DELETE FROM Clientes
WHERE Cidade = 'Fortaleza';

GO