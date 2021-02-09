-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.22 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para prod_petshop
CREATE DATABASE IF NOT EXISTS `prod_petshop` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `prod_petshop`;

-- Copiando estrutura para procedure prod_petshop.cadastraProdutos
DELIMITER //
CREATE PROCEDURE `cadastraProdutos`(nome VARCHAR(45), descricao VARCHAR(200), marca VARCHAR(10), quant int, valorCompra float, valorVenda float)
BEGIN
INSERT INTO `prod_petshop`.`produtos`
(`nome`,
`descricao`,
`marca`,
`quant`,
`valorCompra`,
`valorVenda`)
VALUES
(nome,
descricao,
marca,
quant,
valorCompra,
valorVenda);
END//
DELIMITER ;

-- Copiando estrutura para procedure prod_petshop.listaProdutos
DELIMITER //
CREATE PROCEDURE `listaProdutos`()
BEGIN
select * from produtos;
END//
DELIMITER ;

-- Copiando estrutura para tabela prod_petshop.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `idProduto` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `descricao` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `marca` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `quant` int DEFAULT NULL,
  `valorCompra` float NOT NULL,
  `valorVenda` float NOT NULL,
  PRIMARY KEY (`idProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela prod_petshop.produtos: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`idProduto`, `nome`, `descricao`, `marca`, `quant`, `valorCompra`, `valorVenda`) VALUES
	(3, 'Simparic', 'comprimido via oral p/ controle de carraptos', 'bayer', 50, 2000.8, 150),
	(4, 'Pedigree Adulto', 'ração para cães adultos', 'pedigree', 20, 2000, 115),
	(5, 'Shampoo Clean', 'shampoo para cães filhotes', 'dogMaster', 15, 200, 10),
	(6, 'Shampoo Clean AntiPulgas', 'shampoo antipulgas para cães filhotes', 'dogMaster', 10, 255, 23.5),
	(7, 'teste', 'teste', 'teste', 1, 1, 1),
	(8, 'teste2', 'teste2', 'teste2', 2, 2234, 223),
	(9, 'teste3', 'teste3', 'teste3', 3, 3, 3),
	(10, 'teste4', 'teste4', 'teste4', 4, 4, 4),
	(11, 't5', 't5', 't5', 5, 5, 55);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
