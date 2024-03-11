# Projeto Senac - Lava_Rápido

<h1 align="center">:car: Sistema de Acompanhamento de Serviço de Lava-rápido :car:</h1>

## Descrição do Projeto :heavy_check_mark:

Este projeto consiste em uma aplicação desenvolvida em C# para um lava rápido, onde os clientes podem agendar suas lavagens de forma conveniente. Apresenta-se a jornada de um usuário individual que deseja consultar o andamento do serviço de lavagem.

### Funcionalidades Principais
1. **Agendamento de Lavagem:** Permitir que os clientes agendem suas lavagens, escolhendo data e horário disponíveis.
2. **Histórico de Lavagens:** Manter um registro do histórico de lavagens para cada cliente.
3. **Notificações:** Enviar notificações aos clientes para confirmar agendamentos e lembrá-los das próximas lavagens

### Pré-requisitos
- Visual Studio instalado
- Conexão com banco de dados configurada (SQL Server, MySQL, etc.)
  
### Tecnologia :computer:

- C#
- MySQL

### Recursos :pushpin:

- Visual Studio Code
- Visual Studio Community 2022

### Sobre :triangular_flag_on_post:

O Aplicativo para Lava Rápido foi desenvolvido com o objetivo de modernizar e simplificar a gestão de serviços de lavagem de veículos. A inspiração para este projeto surgiu da necessidade de oferecer aos proprietários de lava-rápidos e aos usuários uma solução eficiente para agendamento e pagamento de serviços.

### Principais Pontos:

- **Simplicidade e Conveniência:** Nosso aplicativo visa proporcionar uma experiência de lavagem de veículos sem complicações, permitindo que os usuários agendem serviços com facilidade e efetuem pagamentos online de forma segura.

- **Tecnologias Utilizadas:** O aplicativo é construído utilizando C#, garantindo eficiência e desempenho. A base de dados é alimentada por MySQL.

Agradecemos por fazer parte do nosso projeto e esperamos que o Aplicativo para Lava Rápido melhore sua experiência de lavagem de veículos.


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

### Instalação e Configuração
1. Clone o repositório: `git clone [https://github.com/monica88lima/Projeto_LavaRapido.git]`
2. Abra o projeto no Visual Studio.
3. Configure a conexão com o banco de dados no arquivo de configuração `appsettings.json`.
4. Execute o script SQL fornecido para criar as tabelas necessárias.

### Executando o Projeto
1. Compile e execute o projeto no Visual Studio.
2. Abra o navegador e acesse `http://localhost:porta` para utilizar a aplicação.

### Licença
A licença do projeto é MIT License.

### Contato

https://www.linkedin.com/in/monicalima/
https://www.linkedin.com/in/roberto-pacheco-527920238/
https://br.linkedin.com/in/jo%C3%A3o-ant%C3%B4nio-neto-2820b0182

### Criando Banco de Dados
 ```
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

> :warning: **Importante:**  Configurar a string de conexão no arquivo appsettings.json.

### Pacotes e Bibliotecas :triangular_flag_on_post:

- .NET 8.0
- AutoMapper (13.0.1)
- Pomelo.EntityFrameworkCore.MySql (8.0.0)
- Microsoft.EntityFrameworkCore.Tools (8.0.2)
- Microsoft.EntityFrameworkCore.Design (8.0.2)

