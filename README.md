# Projeto Senac - Lava_Rápido

<h1 align="center">:car: Sistema de Acompanhamento de Serviço de Lava-rápido :car:</h1>

## Descrição do Projeto :heavy_check_mark:

Este projeto compreende a jornada de um usuário individual que deseja consultar o andamento do serviço de lavagem.

### Tecnologia :computer:

- C#
- MySQL

### Recursos :pushpin:

- Visual Studio Code
- Visual Studio Community 2022

### Sobre :triangular_flag_on_post:

Dentro do perfil escolhido [Usuário Particular]

## DoD

- Tela de Login
   - [x] Tela com campos de Email e Senha
   - [x] Validação de e-mail e Senha

- Tela Menu
   - [x] Componentes com Ícones e nome do serviço

- Tela Status
   - [x] Campo Input para pesquisa da Placa
   - [x] Validação da placa e retorno com os dados do status do veículo pesquisado.

- Tela Timeline
   - [x] Linha do Tempo que é preenchida com as informações obtidas a partir da pesquisa da placa

## Como Usar :file_folder:

### Criando Banco de Dados

   ```bash
-- Schema Lava_Rapido
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Lava_Rapido` ;

-- -----------------------------------------------------
-- Schema Lava_Rapido
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Lava_Rapido` DEFAULT CHARACTER SET utf8 ;
SHOW WARNINGS;
-- -----------------------------------------------------
-- Schema BDLocal
-- -----------------------------------------------------
SHOW WARNINGS;
USE `Lava_Rapido` ;

-- -----------------------------------------------------
-- Table `Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clientes` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clientes` (
  `id` INT NOT NULL DEFAULT auto_increment,
  `NomeCompleto` VARCHAR(300) NOT NULL,
  `Email` VARCHAR(300) NOT NULL,
  `Celular` INT NOT NULL,
  `Comentario` VARCHAR(400) NULL,
  `TipoPessoa` INT NULL,
  `CriadoEm` DATETIME NULL,
  `AtualizadoEm` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
ROW_FORMAT = DEFAULT;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Email_UNIQUE` ON `Clientes` (`Email` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Celular_UNIQUE` ON `Clientes` (`Celular` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `PistaLavagens`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `PistaLavagens` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `PistaLavagens` (
  `id` INT NOT NULL DEFAULT auto_increment,
  `status` INT NULL,
  `VeiculoId` INT NULL,
  `TipoServicoId` INT NULL,
  `CriadoEm` DATETIME NULL,
  `AtualizadoEm` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `TipoServico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TipoServico` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `TipoServico` (
  `id` INT NOT NULL DEFAULT auto_increment,
  `Nome` VARCHAR(100) NOT NULL,
  ` Descricao` VARCHAR(300) NULL,
  `Preco` DECIMAL(10,2) NULL,
  `CriadoEm` DATETIME NULL,
  `AtualizadoEm` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Veiculos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Veiculos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Veiculos` (
  `id` INT NOT NULL DEFAULT auto_increment,
  `Placa` VARCHAR(7) NULL,
  `Marca` VARCHAR(45) NULL,
  `Modelo` VARCHAR(45) NULL,
  `Ano` INT NULL,
  `Observacao` VARCHAR(300) NULL,
  `CriadoEm` DATETIME NULL,
  `AtualizadoEm` DATETIME NULL,
  `ClienteId` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Placa_UNIQUE` ON `Veiculos` (`Placa` ASC) VISIBLE;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


ALTER TABLE `Lava_Rapido`.`Clientes` 
ADD COLUMN `Senha` VARCHAR(45) NOT NULL AFTER `AtualizadoEm`;INSERT INTO `Lava_Rapido`.`Veiculos`
ALTER TABLE `LavaRapido`.`Clientes` 
CHANGE COLUMN `Celular` `Celular` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL ;
    
   ```



[![Alt text] Configurar a string de conexão no arquivo appsettings.json.

#-[Pacotes e Bibliotecas](#Pacotes e Bibliotecas)
net8.0
AutoMapper(13.0.1)
Pomelo.EntityFrameworkCore.MySql (8.0.0)
Microsoft.EntityFrameworkCore.Tools (8.0.2)
Microsoft.EntityFrameworkCore.Design(8.0.2)
