-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 28-Jul-2020 às 19:59
-- Versão do servidor: 8.0.18
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `agenda`
--

DELIMITER $$
--
-- Procedimentos
--
DROP PROCEDURE IF EXISTS `AdcPermissoes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdcPermissoes` (`UsuMod` INT, `Busca` CHAR(1))  BEGIN
DECLARE Usuario INT;
DECLARE Modulo INT;
    DECLARE TotalU INT;
    DECLARE TotalM INT;
    DECLARE Total INT;
    DECLARE Seq INT DEFAULT 0;    
    SET Usuario = UsuMod;
SET Modulo = UsuMod;
SET TotalU = (SELECT COUNT(*) FROM `usuario`);
SET TotalM = (SELECT COUNT(*) FROM `modulo`);
    IF Busca = 'M' THEN
SET Total = TotalM;
ELSE
SET Total = TotalU;
END IF;
    Loop_Busca: LOOP
IF Busca = 'M' THEN
SET Modulo = (SELECT `id` FROM `modulo` LIMIT Seq,1);
ELSE
SET Usuario = (SELECT `id` FROM `usuario` LIMIT Seq,1);
END IF;        
IF Seq < Total THEN
INSERT INTO `permissao` VALUES(Usuario, Modulo, TRUE);
            SET Seq = Seq + 1;
ELSE
LEAVE Loop_Busca;
END IF;
END LOOP Loop_Busca;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cnpj` char(14) DEFAULT NULL,
  `razao` varchar(60) DEFAULT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `endereco` varchar(300) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefone` char(10) DEFAULT NULL,
  `celular` char(11) DEFAULT NULL,
  `del` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `empresa`
--

INSERT INTO `empresa` (`id`, `cnpj`, `razao`, `nome`, `endereco`, `cep`, `telefone`, `celular`, `del`) VALUES
(1, '12345678998745', 'NIKE', 'NIKE LTD', 'TATUI', '12345678', '1234567891', '23145678998', 0),
(2, '12345678998745', 'NIKE teste', 'NIKE LTD', 'TATUI-SP', '12345678', '1234567891', '23145678998', 0),
(3, '12345678998745', 'NIKE teste', 'NIKE LTD', 'TATUI-SP', '12345678', '1234567891', '23145678998', 0),
(4, '12234234231432', 'Diego', 'ds', 'asddasdas', '12234234', '1223423423', '12234234231', NULL),
(5, '12234234231432', 'Diego', 'ds', 'asddasdas', '12234234', '1223423423', '12234234231', NULL),
(7, '11111111111111', 'abc', 'abcteste', '123456', '12345633', '2222222222', '22222222222', NULL),
(8, '11111111111111', 'abc', 'abc', '123456', '12345633', '2222222222', '22222222222', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE IF NOT EXISTS `log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datahora` datetime NOT NULL,
  `descricao` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `log`
--

INSERT INTO `log` (`id`, `datahora`, `descricao`) VALUES
(1, '2020-07-07 17:00:03', 'Novo usuário ( 1 | Default | Default | 2020-01-01 |  | 000000000 | 00000000000 | 00000000000 )'),
(2, '2020-07-07 17:06:40', 'Novo usuário ( 2 | Diego | Diego Silva | 2020-01-01 |  | 000000000 | 00000000000 | 00000000000 )'),
(3, '2020-07-24 14:18:22', 'Novo usuário ( 3 |  |  | 2000-01-01 |  |  |  |  )'),
(4, '2020-07-24 14:20:34', 'Novo usuário ( 4 | joao | Joao | 2000-01-01 | Masculino | 123456789 | 12345678999 | 12345671101 )'),
(5, '2020-07-24 14:20:51', 'Usuário alterado de (4 | joao | Joao | 2000-01-01 | Masculino | 123456789 | 12345678999 | 12345671101 ) para ( 4 | joao | Joao Oliveira | 2000-01-01 | Masculino | 123456789 | 12345678999 | 12345671101 )');

-- --------------------------------------------------------

--
-- Estrutura da tabela `modulo`
--

DROP TABLE IF EXISTS `modulo`;
CREATE TABLE IF NOT EXISTS `modulo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `grupo` varchar(20) DEFAULT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `restricao` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `modulo`
--

INSERT INTO `modulo` (`id`, `grupo`, `descricao`, `restricao`) VALUES
(1, 'Geral', 'Login', 1),
(2, 'Usuários', 'Ler Usuários', 0),
(3, 'Usuários', 'Gravar Usuários', 0),
(4, 'Usuários', 'Inativar Usuários', 0);

--
-- Acionadores `modulo`
--
DROP TRIGGER IF EXISTS `AI_Modulo`;
DELIMITER $$
CREATE TRIGGER `AI_Modulo` AFTER INSERT ON `modulo` FOR EACH ROW BEGIN
CALL `AdcPermissoes` (new.id,'U');
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `os`
--

DROP TABLE IF EXISTS `os`;
CREATE TABLE IF NOT EXISTS `os` (
  `id` int(11) NOT NULL,
  `empresa` int(11) DEFAULT NULL,
  `solicitante` varchar(45) DEFAULT NULL,
  `usuario` int(11) DEFAULT NULL,
  `assunto` varchar(50) DEFAULT NULL,
  `descricao` text,
  `solucao` text,
  `produto` varchar(20) DEFAULT NULL,
  `atendimento` varchar(20) DEFAULT NULL,
  `abertura` datetime DEFAULT NULL,
  `fechamento` datetime DEFAULT NULL,
  `situacao` varchar(20) DEFAULT NULL,
  `del` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `empresa` (`empresa`),
  KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `os`
--

INSERT INTO `os` (`id`, `empresa`, `solicitante`, `usuario`, `assunto`, `descricao`, `solucao`, `produto`, `atendimento`, `abertura`, `fechamento`, `situacao`, `del`) VALUES
(3, 2, 'Diego', 2, 'pinpad', 'Pinpad estava fora da porta usb', 'corrigido', NULL, 'whatsapp', '2020-07-24 16:06:43', '2020-07-24 16:06:43', 'pendente', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `permissao`
--

DROP TABLE IF EXISTS `permissao`;
CREATE TABLE IF NOT EXISTS `permissao` (
  `usuario` int(11) NOT NULL,
  `modulo` int(11) NOT NULL,
  `acesso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`usuario`,`modulo`),
  KEY `modulo` (`modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `permissao`
--

INSERT INTO `permissao` (`usuario`, `modulo`, `acesso`) VALUES
(1, 1, 1),
(1, 2, 1),
(1, 3, 1),
(1, 4, 1),
(2, 1, 1),
(2, 2, 1),
(2, 3, 1),
(2, 4, 1),
(3, 1, 1),
(3, 2, 1),
(3, 3, 1),
(3, 4, 1),
(4, 1, 1),
(4, 2, 1),
(4, 3, 1),
(4, 4, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `nasc` date DEFAULT NULL,
  `sexo` set('Feminino','Masculino') DEFAULT NULL,
  `rg` char(9) DEFAULT NULL,
  `cpf` char(11) DEFAULT NULL,
  `cnh` char(11) DEFAULT NULL,
  `imgperfil` varchar(250) DEFAULT NULL,
  `del` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `login`, `senha`, `nome`, `nasc`, `sexo`, `rg`, `cpf`, `cnh`, `imgperfil`, `del`) VALUES
(1, 'Default', '123', 'Default', '2020-01-01', '', '000000000', '00000000000', '00000000000', '..\\..\\Imagens\\usuarios\\user.png', 0),
(2, 'Diego', '123', 'Diego Silva', '2020-01-01', '', '000000000', '00000000000', '00000000000', '..\\..\\Imagens\\usuarios\\user.png', 0),
(3, '', '', '', '2000-01-01', '', '', '', '', NULL, 0),
(4, 'joao', '123', 'Joao Oliveira', '2000-01-01', 'Masculino', '123456789', '12345678999', '12345671101', '', 0);

--
-- Acionadores `usuario`
--
DROP TRIGGER IF EXISTS `AI_Usuario`;
DELIMITER $$
CREATE TRIGGER `AI_Usuario` AFTER INSERT ON `usuario` FOR EACH ROW BEGIN
INSERT INTO `log` VALUES (0,NOW(),CONCAT(
"Novo usuário ( ",
        new.id," | ",new.login," | ",new.nome," | ",
        new.nasc," | ",new.sexo," | ",new.rg," | ",
        new.cpf," | ",new.cnh," )"));
CALL `AdcPermissoes` (new.id,'M');
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `AU_Usuario`;
DELIMITER $$
CREATE TRIGGER `AU_Usuario` AFTER UPDATE ON `usuario` FOR EACH ROW BEGIN
INSERT INTO `log` VALUES (0,NOW(),CONCAT(
"Usuário alterado de (",
        old.id," | ",old.login," | ",old.nome," | ",
        old.nasc," | ",old.sexo," | ",old.rg," | ",
        old.cpf," | ",old.cnh," ) para ( ",
        new.id," | ",new.login," | ",new.nome," | ",
        new.nasc," | ",new.sexo," | ",new.rg," | ",
        new.cpf," | ",new.cnh," )"));
END
$$
DELIMITER ;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `os`
--
ALTER TABLE `os`
  ADD CONSTRAINT `os_ibfk_1` FOREIGN KEY (`empresa`) REFERENCES `empresa` (`id`),
  ADD CONSTRAINT `os_ibfk_2` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`id`);

--
-- Limitadores para a tabela `permissao`
--
ALTER TABLE `permissao`
  ADD CONSTRAINT `permissao_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`id`),
  ADD CONSTRAINT `permissao_ibfk_2` FOREIGN KEY (`modulo`) REFERENCES `modulo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
