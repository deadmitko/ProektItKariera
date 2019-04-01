-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.12 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for proekt
CREATE DATABASE proekt /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE [proekt];

-- Dumping structure for table proekt.files
CREATE TABLE files (
  [id] int NOT NULL IDENTITY,
  [id_user] int DEFAULT NULL,
  [file] varchar(50),
  [name] varchar(50) DEFAULT NULL,
  [size] varchar(50) DEFAULT NULL,
  [ext] varchar(50) DEFAULT NULL,
  PRIMARY KEY ([id])
)   ;

-- Data exporting was unselected.
-- Dumping structure for table proekt.users
CREATE TABLE users (
  [id] int NOT NULL IDENTITY,
  [username] varchar(50) DEFAULT NULL,
  [password] varchar(50) DEFAULT NULL,
  [first] varchar(50) DEFAULT NULL,
  [last] varchar(50) DEFAULT NULL,
  [email] varchar(50) DEFAULT NULL,
  PRIMARY KEY ([id])
)   ;

-- Data exporting was unselected.
-- Dumping structure for table proekt.user_ui
CREATE TABLE user_ui (
  [id] int NOT NULL IDENTITY,
  [id_user] int NOT NULL DEFAULT '0',
  [ui1] varchar(50) NOT NULL DEFAULT 'black',
  [ui2] varchar(50) NOT NULL DEFAULT 'gray',
  PRIMARY KEY ([id])
)  ;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;