-- MySQL Script generated by MySQL Workbench
-- Fri Jul 15 16:16:56 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema batdongsan
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `batdongsan` ;

-- -----------------------------------------------------
-- Schema batdongsan
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `batdongsan` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `batdongsan` ;

-- -----------------------------------------------------
-- Table `batdongsan`.`doanhnghiep`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`doanhnghiep` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`doanhnghiep` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `ten` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 400
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`duan`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`duan` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`duan` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  `giam2` VARCHAR(1000) NULL DEFAULT NULL,
  `dientich` VARCHAR(1000) NULL DEFAULT NULL,
  `socanho` VARCHAR(1000) NULL DEFAULT NULL,
  `sonhatoa` VARCHAR(1000) NULL DEFAULT NULL,
  `diachi` VARCHAR(1000) NULL DEFAULT NULL,
  `congty` VARCHAR(1000) NULL DEFAULT NULL,
  `tinhtrang` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 361
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`nhadatban`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`nhadatban` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`nhadatban` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  `gia` VARCHAR(1000) NULL DEFAULT NULL,
  `giam2` VARCHAR(1000) NULL DEFAULT NULL,
  `dientich` VARCHAR(1000) NULL DEFAULT NULL,
  `diachi` VARCHAR(1000) NULL DEFAULT NULL,
  `ngaydangbai` VARCHAR(1000) NULL DEFAULT NULL,
  `nenxem` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 595
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`nhadatchothue`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`nhadatchothue` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`nhadatchothue` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  `gia` VARCHAR(1000) NULL DEFAULT NULL,
  `giam2` VARCHAR(1000) NULL DEFAULT NULL,
  `dientich` VARCHAR(1000) NULL DEFAULT NULL,
  `diachi` VARCHAR(1000) NULL DEFAULT NULL,
  `ngaydangbai` VARCHAR(1000) NULL DEFAULT NULL,
  `nenxem` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 368
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`nhamoigioi`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`nhamoigioi` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`nhamoigioi` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `ten` VARCHAR(1000) NULL DEFAULT NULL,
  `diachi` VARCHAR(1000) NULL DEFAULT NULL,
  `dienthoai` VARCHAR(1000) NULL DEFAULT NULL,
  `email` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 404
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`noingoaithat`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`noingoaithat` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`noingoaithat` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 422
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`phongthuy`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`phongthuy` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`phongthuy` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 432
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`tintuc`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`tintuc` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`tintuc` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 464
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `batdongsan`.`wiki`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `batdongsan`.`wiki` ;

CREATE TABLE IF NOT EXISTS `batdongsan`.`wiki` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `url` VARCHAR(1000) NULL DEFAULT NULL,
  `tieude` VARCHAR(1000) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 434
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
