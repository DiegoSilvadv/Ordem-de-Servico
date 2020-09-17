-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 16-Set-2020 às 23:41
-- Versão do servidor: 5.7.31
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `agenda`
--
CREATE DATABASE IF NOT EXISTS `agenda` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `agenda`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `id_empresa` int(11) NOT NULL AUTO_INCREMENT,
  `razao` varchar(300) DEFAULT NULL,
  `fantasia` varchar(300) DEFAULT NULL,
  `cnpj` char(18) DEFAULT NULL,
  `inscricao_estadual` char(9) DEFAULT NULL,
  `rua` varchar(200) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `numero` varchar(5) DEFAULT NULL,
  `cep` char(10) DEFAULT NULL,
  `uf` char(2) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `email_contador` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `inativado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `ordemservico`
--

DROP TABLE IF EXISTS `ordemservico`;
CREATE TABLE IF NOT EXISTS `ordemservico` (
  `id_os` int(11) NOT NULL AUTO_INCREMENT,
  `fk_empresa` int(11) DEFAULT NULL,
  `fk_tecnico` int(11) DEFAULT NULL,
  `solicitante` varchar(200) DEFAULT NULL,
  `info_extra` varchar(250) DEFAULT NULL,
  `assunto` varchar(250) DEFAULT NULL,
  `descricao` text,
  `atendimento` varchar(150) DEFAULT NULL,
  `sistema` varchar(150) DEFAULT NULL,
  `solucao` text,
  `abertura` datetime DEFAULT NULL,
  `conclusao` datetime DEFAULT NULL,
  `status_os` varchar(150) DEFAULT NULL,
  `inativado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_os`),
  KEY `id_empresa` (`fk_empresa`),
  KEY `id_tecnico` (`fk_tecnico`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tecnico`
--

DROP TABLE IF EXISTS `tecnico`;
CREATE TABLE IF NOT EXISTS `tecnico` (
  `id_tecnico` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) DEFAULT NULL,
  `senha` varchar(20) DEFAULT NULL,
  `nome_tecnico` varchar(200) DEFAULT NULL,
  `cnh` char(20) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `rua` varchar(150) DEFAULT NULL,
  `numero` varchar(5) DEFAULT NULL,
  `cep` char(10) DEFAULT NULL,
  `uf` char(2) DEFAULT NULL,
  `complemento` varchar(150) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `data_nascimento` datetime DEFAULT NULL,
  `inativado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_tecnico`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tecnico`
--

INSERT INTO `tecnico` (`id_tecnico`, `usuario`, `senha`, `nome_tecnico`, `cnh`, `cidade`, `bairro`, `rua`, `numero`, `cep`, `uf`, `complemento`, `celular`, `data_nascimento`, `inativado`) VALUES
(0, 'Default', '123456', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0);

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `ordemservico`
--
ALTER TABLE `ordemservico`
  ADD CONSTRAINT `id_empresa` FOREIGN KEY (`fk_empresa`) REFERENCES `empresa` (`id_empresa`),
  ADD CONSTRAINT `id_tecnico` FOREIGN KEY (`fk_tecnico`) REFERENCES `tecnico` (`id_tecnico`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
