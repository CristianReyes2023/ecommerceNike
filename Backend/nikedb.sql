
CREATE DATABASE nikedb;

USE nikedb;

CREATE TABLE `Country` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameCountry` varchar(50) NOT NULL
);

CREATE TABLE `State` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameState` varchar(50) NOT NULL,
  `IdCountryFk` integer(11) NOT NULL
);

CREATE TABLE `City` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameCity` varchar(50) NOT NULL,
  `IdStateFk` integer(11) NOT NULL
);

CREATE TABLE `Address` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipo_via` varchar(50),
  `numero_principal` smallint,
  `letra_principal` char(2),
  `bis` char(10),
  `letra_secundaria` char(2),
  `cardinal_primario` char(10),
  `numero_secundario` smallint,
  `cardinal_secundario` char(10),
  `complemento` varchar(50),
  `IdCityFk` integer NOT NULL
);

CREATE TABLE `Client` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `IdClient` varchar(30) NOT NULL,
  `Telephone` varchar(40) NOT NULL,
  `IdAddressFk` integer NOT NULL
);

CREATE TABLE `GamaProdruct` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameGama` varchar(50) NOT NULL
);

CREATE TABLE `Product` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameProduct` varchar(50) NOT NULL,
  `Price` int NOT NULL,
  `StockMin` integer NOT NULL,
  `StockMax` integer NOT NULL,
  `StateStock` integer NOT NULL,
  `IdGamaProductFk` int NOT NULL
);

CREATE TABLE `Order` (
  `Id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `IdClientFk` integer(11) NOT NULL
);

CREATE TABLE `Order_Product` (
  `IdOrderFk` integer NOT NULL,
  `IdProductFk` integer NOT NULL ,
  PRIMARY KEY (`IdOrderFk`, `IdProductFk`)
);

ALTER TABLE `State` ADD FOREIGN KEY (`IdCountryFk`) REFERENCES `Country` (`Id`);

ALTER TABLE `City` ADD FOREIGN KEY (`IdStateFk`) REFERENCES `State` (`Id`);

ALTER TABLE `Address` ADD FOREIGN KEY (`IdCityFk`) REFERENCES `City` (`Id`);

ALTER TABLE `Client` ADD FOREIGN KEY (`IdAddressFk`) REFERENCES `Address` (`Id`);

ALTER TABLE `Product` ADD FOREIGN KEY (`IdGamaProductFk`) REFERENCES `GamaProdruct` (`Id`);

ALTER TABLE `Order` ADD FOREIGN KEY (`IdClientFk`) REFERENCES `Client` (`Id`);

ALTER TABLE `Order_Product` ADD FOREIGN KEY (`IdProductFk`) REFERENCES `Product` (`Id`);

ALTER TABLE `Order_Product` ADD FOREIGN KEY (`IdOrderFk`) REFERENCES `Order` (`Id`);
