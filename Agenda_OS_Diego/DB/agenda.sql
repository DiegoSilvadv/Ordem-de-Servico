create database agenda;

use agenda;

create table empresa(
  id_empresa int primary key AUTO_INCREMENT,
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
  data_nascimento datetime
) ENGINE = innodb;

create table ordemservico (
  id_os int primary key auto_increment,
  fk_empresa int,
  fk_tecnico int,
  solicitante VARCHAR(200),
  info_extra VARCHAR(250),
  assunto VARCHAR(250),
  descricao text,
  atendimento VARCHAR(150),
  sistema VARCHAR(150),
  solucao text,
  abertura datetime,
  conclusao datetime,
  status_os VARCHAR(150)
) ENGINE = innodb;

ALTER TABLE ordemservico
ADD CONSTRAINT id_empresa
FOREIGN KEY (fk_empresa) 
REFERENCES empresa (id_empresa);

ALTER TABLE ordemservico
ADD CONSTRAINT id_tecnico
FOREIGN KEY (fk_tecnico) 
REFERENCES tecnico (id_tecnico);

insert into ordemservico VALUES(0, 2, 2, "Diego", "outro telefone 123"
, "pinpad", "pinpad nao funciona", "Telefone", "TEF", "colocou novamento na porta usb", now(), now(), "Finalizado");

insert into empresa VALUES(0, "nike", "nike ltd", "12345678912345",
 "Pulo holtz", "Inocoop", "Tatuí", "123", "18555236", "153053333", "15996286530");

 insert into tecnico VALUES (0, "diego", "123", "Diego da Silva", "12345678998745698562"
, "TAtuí", "Centro", "XV de novembro", "1234", "105831256", "15996989530", now() );

select t.nome, e.fantasia, e.cnpj, os.solicitante, os.info_extra, os.assunto, os.descricao, os.atendimento, os.sistema, os.solucao, os.abertura, os.conclusao, os.status_os from tecnico as t inner join empresa as e inner join ordemservico as os where os.fk_tecnico = t.id_tecnico and os.fk_empresa = e.id_empresa;




exec listarordemservico;
