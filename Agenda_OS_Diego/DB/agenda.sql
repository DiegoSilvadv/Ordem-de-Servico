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
  telefone VARCHAR(14),
  celular VARCHAR(16)
) ENGINE = innodb;

insert into empresa VALUES(0, "nike", "nike ltd", "12345678912345",
 "Pulo holtz", "Inocoop", "Tatuí", "123", "18555236", "153053333", "15996286530")

update empresa set razao = "nike teste" where id = 1;

DELETE from empresa WHERE id= 1;