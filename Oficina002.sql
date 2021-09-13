create database oficina002

use oficina002

create table oficina(
	idOficina int not null primary key identity(1,1),
	nome varchar(50) not null
)

create table cliente(
	idCliente int not null primary key identity(1,1),
	nome varchar(50) not null,
	email varchar(50) not null
)

create table marca(
	idMarca int not null primary key identity(1,1),
	nome varchar(50)
)

create table carro(
	idCarro int not null primary key identity(1,1),
	placa varchar(50) not null,
	descricao varchar(50) not null,
	id_cliente int not null references cliente(idCliente),
	id_marca int not null references marca(idMarca)
)

create table funcionario(
	idFuncionario int not null primary key identity(1,1),
	nome varchar(50) not null,
	id_oficina int not null references oficina(idOficina)
)

create table atendimento (
	idAtendimento int not null primary key identity(1,1),
	descricao varchar(255) not null
)

create table cadastro_atendimento(
	idCadastroAtendimento int not null primary key identity(1,1),
	id_atendimento int not null references atendimento(idAtendimento),
	id_cliente int not null references cliente(idCliente)
)

create table tipo_pagamento(
	idTipoPagamento int not null primary key identity(1,1),
	descricao varchar(50) not null,
	parcela int not null default(1),
	id_atendimento int not null references atendimento(idAtendimento)
)

create table servico(
	idServico int not null primary key identity(1,1),
	descricao varchar(50) not null,
	preco numeric(10,2) not null default(0),
	prazo int not null default(1),
	id_atendimento int not null references atendimento(idAtendimento)
)

create table tipo_servico(
	idTipoServico int not null primary key identity(1,1),
	id_funcionario int not null references funcionario(idFuncionario),
	id_servico int not null references servico(idServico)
)

insert into oficina(nome) values ('Carlao Oficina')
insert into oficina(nome) values ('Novo Carro Velho')
insert into oficina(nome) values ('Mecanica Arlicar LTDA')
insert into oficina(nome) values ('NipponCar')
insert into oficina(nome) values ('Moto 13')

insert into funcionario(nome, id_oficina) values ('Douglas', 4)
insert into funcionario(nome, id_oficina) values ('Yuri', 4)
insert into funcionario(nome, id_oficina) values ('Yabusame', 4)
insert into funcionario(nome, id_oficina) values ('Joao', 4)
insert into funcionario(nome, id_oficina) values ('Cleber', 4)
insert into funcionario(nome, id_oficina) values ('Carlos', 1)
insert into funcionario(nome, id_oficina) values ('Jurandir', 2)
insert into funcionario(nome, id_oficina) values ('Paula', 3)
insert into funcionario(nome, id_oficina) values ('Enzo', 5)

insert into cliente(nome, email) values ('Lucas', 'lucas@gmail.com')
insert into cliente(nome, email) values ('Thiago', 'thiago@gmail.com')
insert into cliente(nome, email) values ('Marcus', 'marcus@gmail.com')
insert into cliente(nome, email) values ('Junior', 'junior@gmail.com')
insert into cliente(nome, email) values ('Misael', 'misael@gmail.com')

insert into atendimento(descricao) values ('Gol preto funilaria, pintura, troca de farol e óleo')

insert into servico(descricao, preco, prazo, id_atendimento) values ('martelinho de ouro no capô', 500, 3, 1)
insert into servico(descricao, preco, prazo, id_atendimento) values ('martelinho de ouro no para-choque', 350, 2, 1)
insert into servico(descricao, preco, prazo, id_atendimento) values ('pintura cor preto capô', 250, 4, 1)
insert into servico(descricao, preco, prazo, id_atendimento) values ('pintura cor preto para-choque', 150, 2, 1)
insert into servico(descricao, preco, prazo, id_atendimento) values ('instalação de novo farol', 400, 1, 1)
insert into servico(descricao, preco, prazo, id_atendimento) values ('troca de óleo', 150, 1, 1)

insert into tipo_servico(id_funcionario, id_servico) values (1,1)
insert into tipo_servico(id_funcionario, id_servico) values (1,2)
insert into tipo_servico(id_funcionario, id_servico) values (2,3)
insert into tipo_servico(id_funcionario, id_servico) values (2,4)
insert into tipo_servico(id_funcionario, id_servico) values (3,5)
insert into tipo_servico(id_funcionario, id_servico) values (8,6)

insert into tipo_servico(id_funcionario, id_servico) values (1,1)
insert into tipo_servico(id_funcionario, id_servico) values (1,2)
insert into tipo_servico(id_funcionario, id_servico) values (1,3)
insert into tipo_servico(id_funcionario, id_servico) values (1,4)
insert into tipo_servico(id_funcionario, id_servico) values (1,5)
insert into tipo_servico(id_funcionario, id_servico) values (1,6)

insert into cadastro_atendimento(id_atendimento, id_cliente) values (1,1)

insert into tipo_pagamento(descricao, parcela, id_atendimento) values ('Cartão Crédito', 12, 1)

insert into marca(nome) values ('Volksvagem')
insert into marca(nome) values ('Toyota')
insert into marca(nome) values ('Honda')
insert into marca(nome) values ('Fiat')
insert into marca(nome) values ('Ford')

insert into carro(placa, descricao, id_cliente, id_marca) values ('HJG2541','Corolla Prata', 1, 2)
insert into carro(placa, descricao, id_cliente, id_marca) values ('HYR8471','Gol Preto', 1, 1)
insert into carro(placa, descricao, id_cliente, id_marca) values ('HOD6258','Golf GTI 2.0 Roxo', 1, 1)
insert into carro(placa, descricao, id_cliente, id_marca) values ('HJG2541','Fusca 2.0 Preto', 2,1)
insert into carro(placa, descricao, id_cliente, id_marca) values ('HJG8754','Up TSI Branco', 3, 1)

select * from oficina
select * from funcionario
select * from servico
select * from tipo_servico
select * from atendimento
select * from tipo_pagamento
select * from cadastro_atendimento
select * from cliente
select * from carro
select * from marca





