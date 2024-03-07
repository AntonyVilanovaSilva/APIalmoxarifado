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

Create Table MotivoSaida(
MotId int identity(1,1) primary key,
descricao varchar(100) not null,
CatId int,
FOREIGN KEY (CatId) REFERENCES CategoriaMotivo(CatId)
)

Insert MotivoSaida (descricao) values ('')

Create Table Requisicao(
Codigo int identity(1,1) primary key,
DataRequisicao datetime null,
)

Create Table ItensRequisicao(
IteId int identity(1,1) primary key,
CodigoRequisicao int not null,
CodigoProduto int not null,
Preco float null default(0),
Quantidade int not null default(0),
CONSTRAINT FK_itenRequisicao FOREIGN KEY (CodigoRequisicao)
REFERENCES Requisicao(Codigo),
CONSTRAINT FK_itenProducao FOREIGN KEY (CodigoProduto)
REFERENCES Requisicao(id)
)

Create Table Motivo(
Codigo int identity(1,1) primary key,
Descricao varchar(100) not null,
CodigoCategoriaMotivo int not null,
Constraint Fk_CategoriaMotivo_Motivo Foreign key(Codigo)
References CategoriaMotivo(CatId)
)

Create table Cargo(
CaId int identity(1,1) primary key,
descricao varchar(100) not null,
localizacao varchar(100) not null,
)

Create table RestricaoCargo(
CONSTRAINT FK_codfuncionario FOREIGN KEY (id)
REFERENCES Funcionario(id),
CONSTRAINT FK_codproduto FOREIGN KEY (id)
REFERENCES Produto (id)

)

Select * from Requisicao
Select * from Departamento
Select * from Produto
Select * from Categoria
Select * from Funcionario
Select * from MoitvoSaida
Select * from CategoriaMotivo
Select * from Cargo
Select * from RestricaoCargo