create database agenda;

use agenda;

create table empresa(
  id int primary key AUTO_INCREMENT,
  razao VARCHAR(300),
  fantasia VARCHAR(300),
  cnpj CHAR(18),
  rua VARCHAR(200),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  numero VARCHAR(5),
  cep CHAR(10),
  telefone VARCHAR(20),
  celular VARCHAR(20)
) ENGINE = innodb;

CREATE table tecnico(
  id_tecnico int primary key auto_increment,
  usuario VARCHAR(20),
  senha VARCHAR(20),
  nome VARCHAR(200),
  cnh CHAR(20),
  cidade VARCHAR(100),
  bairro VARCHAR(100),
  rua VARCHAR(150),
  numero VARCHAR(5),
  cep CHAR(10),
  celular VARCHAR(20),
  data_nascimento VARCHAR(12)
) ENGINE = innodb;

create table ordemservico (
  id_os int primary key auto_increment,
  usuario VARCHAR(200),
  solicitante VARCHAR(200),
  fantasia VARCHAR(300),
  cnpj CHAR(18),
  telefone VARCHAR(20),
  celular VARCHAR(20),
  info_extra VARCHAR(250),
  assunto VARCHAR(250),
  descricao text,
  atendimento VARCHAR(150),
  sistema VARCHAR(150),
  solucao text,
  abertura varchar(30),
  conclusao varchar(30),
  status_os VARCHAR(150)
);

insert into ordemservico VALUES(0, "Diego", "Joao", "Nike", "123456789654789654"
, "12553662525", "15996363232", "Telefone funcionario 132"
, "Erro pinpad", "Foi conectado ao pc", "Whatssapp", "tef sitef"
, "foi feito correcao", "25/10/2020 13:52", "25/10/2020 13:52", "pendente"
);

insert into empresa VALUES(0, "nike", "nike ltd", "12345678912345",
 "Pulo holtz", "Inocoop", "Tatuí", "123", "18555236", "153053333", "15996286530");
update empresa set razao = "nike teste" where id = 1;
DELETE from empresa WHERE id= 1;