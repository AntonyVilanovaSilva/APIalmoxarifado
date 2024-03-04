use master
go
create database dbAlmoxarifado
go
use dbAlmoxarifado
go
create table Produto(
   id int identity(1,1) primary key,
   nome  varchar(100) not null,
   estoque int null default(0),
   photourl varchar(255) null
)
go
Insert Produto (nome, estoque,photourl) values ('HP Turbo',20,null)
go
Insert Produto (nome, estoque,photourl) values ('MONITOR GOT',40,null)

select * from departamento

Create table Categoria
(
id int identity(1,1) primary key,
descricao varchar(100) not null
)

Insert Categoria (descricao) values ('Latícinios')
go
Insert Categoria (descricao) values ('Eletronicos')
go
Insert Categoria (descricao) values ('Bebidas')
go

drop table Departamento

Create table Departamento(
  id int identity(1,1) primary key,
  descricao varchar(100) not null,
  ativado bit default 0,
)

Insert Departamento (descricao) values ('1')

Create table Funcionario(
 id int identity(1,1) primary key,
 nome varchar(100) not null,
 cargo varchar(100) not null,
 datanascimento datetime,
 salario decimal,
 endereco varchar(100) not null,
 cidade varchar(100) not null,
 uf varchar(100) not null
)

Insert Funcionario (nome,cargo,datanascimento,salario,endereco,cidade,uf) values ('Antony','Engenheiro Agronomo','18/03/2007','20000','Valadares','Estancia','SE')

Create Table CategoriaMotivo(
CatId int identity(1,1) primary key,
descricao varchar(100) not null
)

Insert CategoriaMotivo (descricao) values ('')

Create Table MoitvoSaida(
MotId int identity(1,1) primary key,
descricao varchar(100) not null,
CatId int,
FOREIGN KEY (CatId) REFERENCES CategoriaMotivo(CatId)
)

Insert Motivo (descricao) values ('')

Select * from Departamento
Select * from Produto
Select * from Categoria
Select * from Funcionario