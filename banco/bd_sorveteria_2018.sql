
create database bd_SORVETERIA
go
use bd_SORVETERIA

go
drop database bd_SORVETERIA


create  table Categoria
(
	ID_Categoria int identity(1,1) primary key,
	Nome_Categoria varchar(30) not null, -- MASSA, PALITO, POTE ou OUTROS
	
)
go
insert into Categoria ( Nome_Categoria) values ( 'Palito')
insert into Categoria ( Nome_Categoria) values ( 'Pote')
insert into Categoria ( Nome_Categoria) values ( 'Bebida')

select * from PAGTO_VENDA
select * from Funcionario;
select * from Produto
select * from Categoria
select * from Cupom

create table  Fornecedor 
(
    ID_Fornecedor int identity(1,1) primary key,
	NomeFantasia_Fornecedor varchar(50) not null,
	RazaoSocial_Fornecedor varchar(50) null, 
	CNPJ_CPF_Fornecedor varchar(50) not null,
	Telefone_Fornecedor varchar(20) not null,
	Email_Fornecedor varchar(100) not null,
	WebSite_Fornecedor varchar(100) not null,
	Celular_Fornecedor varchar(255),
	Logradouro_Fornecedor	VARCHAR(60)	,		
    CEP_Fornecedor		varchar(255),   		
    Bairro_Fornecedor		VARCHAR(60), 			
    Cidade_Fornecedor	VARCHAR(60), 			
    UF_Fornecedor			varCHAR(2), 				
    Numero_Fornecedor		int	, 		
    Complemento_Fornecedor	VARCHAR(60),			

	 Status_Fornecedor BIT DEFAULT 1
)
go

select * from Fornecedor

select * from Categoria

--drop table Produto
--alter table Produto add Nome_Categoria varchar(255)
create table Produto
(
	ID_Produto int identity(1,1) primary key,
	Nome_Produto varchar(100) not null,
	Descricao_Produto varchar(100) not null,
	
	qtdeATUAL_Produto int null,
	QuantEntrada_Produto int,
	DATA_Produto datetime, 
	Preco_Produto  decimal (10,2), 
	ID_Cat int not null,
      ID_Fornecedor  int not null,
	Status_Produto BIT default 1,

	
	constraint fk_tabCat_Produto foreign key (ID_Cat)	
				references Categoria(ID_Categoria),
	constraint fk_FORNEC_Produto foreign key (ID_Fornecedor)	
				references Fornecedor(ID_Fornecedor)	
)
go
select * from Funcionario order by Nome_Funcionario

select distinct Categoria.* from Categoria inner join Produto
on Categoria.ID_Categoria = Produto.ID_Cat where Status_Produto = 1 


select* from Produto 

create table Cargo
(
	ID_Cargo int identity(1,1) primary key,
	Nome_Cargo varchar(50) not null
)

SELECT  (Preco_Produto)   from Produto where ID_Produto = 1 
go
select * from Cargo;
insert into Cargo (Nome_Cargo) Values ('Caixa')
insert into Cargo (Nome_Cargo) Values ('Faxineiro')
insert into Cargo(Nome_Cargo) values ('Conferente')
insert into Cargo(Nome_Cargo) values ('Administrador')
insert into Cargo(Nome_Cargo) values ('Administrador2')







 

CREATE TABLE Funcionario

(
ID_Funcionario	INT IDENTITY PRIMARY KEY,
Nome_Funcionario VARCHAR(60) NOT NULL,
Sexo_Funcionario CHAR(1)		NOT NULL,
CPF_Funcionario			varCHAR(255)	UNIQUE	NOT NULL,
RG_Funcionario			varCHAR(255)		NOT NULL,
DataNasc_Funcionario		DateTime		NOT NULL,
Logradouro_Funcionario	VARCHAR(60)			NOT NULL,
CEP_Funcionario		varchar(255)  	NOT NULL,	
Bairro_Funcionario		VARCHAR(60)			NOT NULL,
Cidade_Funcionario	VARCHAR(60)			NOT NULL,
UF_Funcionario			varCHAR(2)				NOT NULL,
Numero_Funcionario		int			NOT NULL,
Complemento_Funcionario	VARCHAR(60)			NOT NULL,
Telefone_Funcionario	varchar(20) not null,
Email_Funcionario		varchar(100) not null,
ID_Cargo		int, 
Status_Funcionario BIT default 1  null,
Celular_Funcionario varchar(255), 



constraint fk_FUNC_Cargo foreign key (ID_Cargo)	
				references Cargo(ID_Cargo)


)

select * from Login
select * from Cupom
insert into Cupom values ('kingnaldo', 1, 1, '15%') 
select * from Funcionario where Status_Funcionario = 0;
select * from Funcionario where Status_Funcionario = 1
update Funcionario set Status_Funcionario = 1 where ID_Funcionario = 1


create table Cliente
(
  ID_CLiente int primary key identity(1,1),
  Nome_Cliente varchar(255),
  Telefone_Cliente varchar(255),
  Email_Cliente varchar(255), 
  Status_Cliente bit default 1 
)
--DEPOIS LEMBRAR DE COLOCAR O STATUS DO CLIENTE, 
alter table Cliente add 
insert into Cliente (Nome_Cliente, Telefone_Cliente, Email_Cliente) values ('Pedro', '11932798986', 'pedro@gmail.com')
Select ID_Cliente, Nome_Cliente, Telefone_Cliente, Email_Cliente from Cliente order by Nome_Cliente
select * from Cliente
insert into Cliente(Nome_Cliente, Telefone_Cliente, Email_Cliente) values ('Pedro', '11932846958', 'pedro46tr@gmail.com')
drop table Cliente
create table Cupom(
ID_Cupom int primary key identity(1,1),
Numero_Cupom varchar(255),
Status_Cupom bit default 1,
tipoDesconto_Cupom varchar(30),
ID_Cliente int foreign key references Cliente(ID_Cliente)
)
drop table Cupom
insert into Cupom values ('11', 1, 1, '10%')
alter table Cupom add 

create table Usu_Cliente(
ID_Usu int primary key identity(1,1),
Email_Usu varchar(100) not null,
Senha_Usu varchar(100) not null,
ID_Usu_Cliente int foreign key references Cliente(ID_Cliente));

select * from Cliente
select * from Cupom
select * from Cupom where Numero_Cupom = '1234'
insert into Cupom(Numero_Cupom, ID_Cliente, tipoDesconto_Cupom) values('12', 1, '10%')

alter table Cliente drop column Status_Cliente
alter table Cliente drop column ID_Cupom
alter table Cliente add Status_Cliente bit default 1
alter table Cliente add ID_Cupom int foreign key references Cupom(ID_Cupom)
select Max(ID_Cliente) as ID from Cliente;
select * from Cliente where ID_Cliente >= 18 
select * from Login
select * from Cupom where (ID_Cliente = 14) and  (Status_Cupom = 0)
CREATE TABLE VENDA
(
ID_Venda	INT IDENTITY PRIMARY KEY,
ID_Funcionario INT,
DATA_Venda	DATETIME ,
VALOR_TOTAL_Venda DECIMAL(10,2) NULL,
QTDE_ITEM_Venda	INT NULL,
Status_Venda	bit default 1,

constraint fk_FUNC_vENDA foreign key (ID_Funcionario)	
				references Funcionario(ID_Funcionario)
)
insert into VENDA values(1, '06/08/2019', 3.00, 4, 1)
GO
select Max(ID_Venda) as ID_Venda from Venda
select * from VENDA
select * from ITENS_VENDA
select * from Produto

select * from ITENS_VENDA
drop table ITENS_VENDA

CREATE TABLE ITENS_VENDA
(
ID_ITENS_VENDA int primary key identity(1,1),
ID_Venda INT FOREIGN KEY 
				REFERENCES VENDA,
 ID_Produto INT FOREIGN KEY 
				REFERENCES PRODUTO,
QTDADE_Itens INT,

)
insert into ITENS_VENDA values(13, 1, 3)
select sum(SUBTOTAL_VENDA) from ITENS_VENDA where ID_Venda = 2
GO
insert ITENS_VENDA values (3, 3, 2)
Select Min(ID_Funcionario) as Func from Login

----******
select * from Funcionario

select * from venda
INSERT INTO VENDA ( Data_Venda, VALOR_TOTAL_Venda, QTDE_ITEM_Venda)  Values (getdate(), '13.60',  2);



create table FormaPGTO
(
	ID_FormaPagamento int identity(1,1) primary key,
	Nome_FormaPagamento varchar(50) not null
)
insert into FormaPGTO values('Dinheiro')
insert into FormaPGTO values('Cartao de Crédito')
insert into FormaPGTO values('Cartão de Débito')

go
select * from PAGTO_VENDA

update Venda set Status_Venda = 0 where ID_Venda = 3;
select * from VENDA where Status_Venda = 0

select * from Venda where Status_Venda = 0;
select * from Produto
select * from VENDA
CREATE TABLE PAGTO_VENDA
(
ID_Venda INT FOREIGN KEY 
				REFERENCES VENDA,
ID_FormaPagamento INT FOREIGN KEY 
				REFERENCES formaPGTO,
ValorPago_PAGTO_VENDA decimal(10,2) Not Null
)
Insert into PAGTO_VENDA values(13, 1, 3.00)

Insert into PAGTO_VENDA values(13, 2, 3.00)

select * from PAGTO_VENDA
GO

CREATE TABLE PEDIDO_COMPRA
(
ID_Pedido	INT IDENTITY PRIMARY KEY,
ID_Funcionario INT NOT NULL,
DATA_Pedido		SMALLDATETIME NOT NULL,
VALOR_TOTAL_Pedido DECIMAL(10,2) NULL,
QTDE_ITEM_Pedido	INT NULL,
Status_Pedido bit default 1	 not null,

constraint fk_FUNC_PEDIDO foreign key (ID_Funcionario)	
				references Funcionario(ID_Funcionario)
)
GO
select * from Produto
CREATE TABLE ITENS_PEDIDO_COMPRA
(
ID_Pedido INT FOREIGN KEY 
				REFERENCES PEDIDO_COMPRA,
ID_Produto INT FOREIGN KEY 
				REFERENCES PRODUTO,
QTDADE_Itens_Compra INT
)
GO
Select Min(ID_Funcionario) from Login

create  TABLE Contas
(
ID_Conta	INT IDENTITY PRIMARY KEY,
TipoNOME_Conta VARCHAR(100) NOT NULL,
ID_Funcionario INT NOT NULL,
DATA_VENCTO_Conta		DATETIME NULL,
DATA_PGTO_Conta		DATETIME NULL,
VALOR_Conta DECIMAL(10,2) NULL,
Status_Conta	bit default 1,
ID_FormaPagamento int, 

constraint fk_FUNC_Conta foreign key (ID_Funcionario)	
				references Funcionario(ID_Funcionario),
constraint fk_PAGAMENTO_Conta foreign key (ID_FormaPagamento) 
               references  FormaPGTO(ID_FormaPagamento)
)
select * from Contas where DATA_PGTO_Conta between '09/06/2019' and '12/06/2019' 
select * from Produto
GO
CREATE TABLE ENTRADA_PRODUTO
(
 ID_ENTRADA_PROD INT IDENTITY PRIMARY KEY,
 ID_Produto INT FOREIGN KEY 
				REFERENCES PRODUTO,
 DATA SMALLDATETIME,
 QTDADE_PRODUTO INT
)
GO
select * from Entrada_Produto
select * from Produto
update Produto
set qtdeATUAL_Produto = qtdeATUAL_Produto - (select ITENS_VENDA.QTDADE_Itens from venda inner join ITENS_VENDA
on venda.ID_Venda = ITENS_VENDA.ID_Venda inner join Produto on Produto.ID_Produto = ITENS_VENDA.ID_Produto
where venda.ID_Venda = 12 and Produto.ID_Produto = 2) 
where ID_Produto = 2

update Produto set qtdeATUAL_Produto = qtdeATUAL_Produto + var where ID_Produto = 2


update Produto set qtdeATUAL_Produto = qtdeATUAL_Produto + QTDADE_Itens   where ID_Produto = 2
 
 select * from ITENS_VENDA


create TABLE Login (
  ID_Login INT PRIMARY KEY IDENTITY (1,1) ,
  Usuario_Login VARCHAR(100)  NOT NULL  ,
  Senha_Login VARCHAR(255)  NOT NULL    ,
  Status_Login BIT DEFAULT 1,
  ID_Funcionario INT,
  nivelAcesso varchar(20),
  CONSTRAINT FK_LOGIN_FUNCIONARIO FOREIGN KEY (ID_Funcionario) REFERENCES Funcionario (ID_Funcionario)
);

SELECT ID_Login, Usuario_Login, Senha_Login, nivelAcesso, ID_Funcionario FROM Login

insert into Login(Usuario_Login, Senha_Login, nivelAcesso) values ('Pedro', '123456', 'ADM')
insert into Login(Usuario_Login, Senha_Login, nivelAcesso) values ('Jonathan' , 'saopaulo', 'CAIXA')
INSERT INTO Login(Usuario_Login, Senha_Login, nivelAcesso) values ('Gabriel','lopes', 'TECNICO') 
insert into Login(Usuario_Login, Senha_Login, nivelAcesso) values ('Carlos', '123456', 'ADM')

Select*from Login
select*from Funcionario
select * from Cliente
select * from Cliente  where Status_Cliente = 1 ORDER BY Nome_Cliente

select * from Cupom where ID_Cupom = 5
select * from Cupom
select count(ID_Cupom) from Cupom
update Login set Status_Login = 0 where ID_Login = 7
select Email_Cliente from Cliente where Nome_Cliente = 'JEANE'
select * from VENDA
select * from Produto
--select * from Cep


drop table Cupom
alter table Cupom add ID_Cliente int foreign key references Cliente(ID_Cliente)
alter table Cupom drop column Status_Cupom bit default 0;


select * from Cupom
select * from Produto

select distinct Categoria.* from Categoria inner join Produto on Categoria.ID_Categoria = Produto.ID_Cat ORDER BY Categoria.NOME_CATEGORIA
SELECT * FROM Produto WHERE ID_Cat = 1 and Status_Produto = 1 ORDER BY Nome_Produto

SELECT ITENS_VENDA.ID_PRODUTO, PRODUTO.Nome_Produto, Produto.Preco_Produto, ITENS_VENDA.QTDADE_Itens, VENDA.VALOR_TOTAL_Venda  FROM 
Produto INNER JOIN ITENS_VENDA ON PRODUTO.ID_PRODUTO = ITENS_VENDA.ID_Produto
INNER JOIN VENDA ON VENDA.ID_Venda = ITENS_VENDA.ID_Venda
WHERE VENDA.ID_VENDA = 3
select min(Preco_Produto) from Produto inner join


select* from Funcionario where Status_Funcionario = 0
insert into Fornecedor ( Nome_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Email_Fornecedor, WebSite_Fornecedor, Celular_Fornecedor, Status_Fornecedor) values ('Jundiá', '12345678901234', '1197304738', 'pedro@gmail.com', 'pedro.com', '11973048765', 1) 
update Produto
set qtdeATUAL_Produto = qtdeATUAL_Produto - (select QTDADE_Itens from ITENS_VENDA where ID_Produto = 2 AND ID_Venda = 15) 
where ID_Produto = 2
insert into VENDA (ID_Funcionario, DATA_Venda, VALOR_TOTAL_Venda, QTDE_ITEM_Venda, Status_Venda) values( 1, '10/09/2017', 13.75, 9, 1)
insert into Produto ( Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto, ID_Cat, ID_Fornecedor, Status_Produto) values ('Sorvete Uva', ' Sorvete de Uva da Jundiá', 1.75, 9, 1, 1, 1)
insert into Fornecedor ( Nome_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Email_Fornecedor, WebSite_Fornecedor, Celular_Fornecedor, Status_Fornecedor) values ('Jundiá', '12345678901234', '1197304738', 'pedro@gmail.com', 'pedro.com', '11973048765', 1) 




SELECT * FROM ITENS_VENDA
select * from Produto where ID_Fornecedor = 2
select * from Venda
DELETE FROM Categoria WHERE ID_Categoria= 1

UPDATE Produto SET qtdeATUAL_Produto  = qtdeATUAL_Produto - (select QTDADE_Itens from ITENS_VENDA  
WHERE ID_Produto = 3)



UPDATE Produto SET qtdeATUAL_Produto = qtdeATUAL_Produto + 10 where ID_Produto = 3


UPDATE Venda
SET VALOR_TOTAL_Venda = VAR,
	QTDE_ITEM_Venda = VAR,
	Status_Venda = 0
WHERE ID_Venda = VAR
insert PAGTO_VENDA values(1, 1, 13.00)

select * from Produto where qtdeATUAL_Produto between 300 and 400

select (qtdeATUAL_Produto) from Produto where ID_Produto = 1


update Produto   
set qtdeATUAL_Produto = qtdeATUAL_Produto - (select sum(ITENS_VENDA.QTDADE_Itens) from venda inner join ITENS_VENDA
 on venda.ID_Venda = ITENS_VENDA.ID_Venda inner join Produto on Produto.ID_Produto = ITENS_VENDA.ID_Produto 
 where venda.ID_Venda = 1 and Produto.ID_Produto = 1) where ID_Produto = 1



select *  from VENDA where CAST(DATA_Venda as date)  = '30/06/2019'

create table Fale_Conosco(
ID_MSG_Fale int primary key identity(1,1),
Email_Fale varchar(50) not null,
Nome_Fale varchar(50) not null,
Telefone_Fale varchar(20) not null,
Mensagem_Fale varchar(400) not null,
Data_MSG_Fale datetime not null,
Status_MSG_Fale varchar(20) not null
);
insert into Fale_Conosco(Email_Fale, Nome_Fale, Telefone_Fale, Mensagem_Fale, Data_MSG_Fale, Status_MSG_Fale) values 
('pedro@gmail.com', 'Pedro','11932464532', 'Ola', '11/09/2019','enviado' )

insert into Fale_Conosco(Email_Fale, Nome_Fale, Telefone_Fale, Mensagem_Fale, Data_MSG_Fale, Status_MSG_Fale) values 
('ctcavalcante76@gmail.com', 'Vinicius','11932464532', 'Ola', '11/09/2019','enviado' )

insert into Fale_Conosco(Email_Fale, Nome_Fale, Telefone_Fale, Mensagem_Fale, Data_MSG_Fale, Status_MSG_Fale) values 
('raimunda9931@gmail.com', 'Pedro','11932464532', 'Ola', '11/09/2019','enviado' )

insert into Fale_Conosco(Email_Fale, Nome_Fale, Telefone_Fale, Mensagem_Fale, Data_MSG_Fale, Status_MSG_Fale) values 
('pedro@gmail.com', 'Pedro','11932464532', 'Ola', '11/09/2019','enviado' )
Select * from Fale_Conosco order by Email_Fale

create table Resposta(
ID_Funcionario int Foreign key references Funcionario,
Data_Resposta_MSG datetime null,
Mensagem_Resposta varchar(400) null


);
alter table Resposta add MensagemRecebida_Resposta varchar(255)
select * from Cliente
alter table Resposta add ID_MSG int foreign key references Fale_Conosco(ID_MSG_Fale);
alter table Resposta drop column Email_fale
select *from Resposta
  insert into Resposta (ID_Funcionario, Data_Resposta_MSG, Mensagem_Resposta, ID_MSG ) values (1, '11/09/2019', 'Ola', 1) select *from Fale_Conosco where Email_Fale = 'pedro@gmail.com'
select *from Fale_Conosco where Email_Fale = 'pedro@gmail.com'

select * from Usu_Cliente