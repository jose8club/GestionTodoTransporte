CREATE DATABASE  IF NOT EXISTS `ttpt` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ttpt`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: ttpt
-- ------------------------------------------------------
-- Server version	5.6.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia` (
  `idASISTENCIA` int(11) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Horario` time NOT NULL,
  PRIMARY KEY (`idASISTENCIA`),
  KEY `fk_ASISTENCIA-ESTUDIANTE_idx` (`Estudiante`),
  CONSTRAINT `fk_ASISTENCIA-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencia_practica`
--

DROP TABLE IF EXISTS `asistencia_practica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia_practica` (
  `Asistencia` int(11) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `Practica` int(11) NOT NULL,
  `Auto` varchar(6) NOT NULL,
  PRIMARY KEY (`Asistencia`,`Estudiante`,`Practica`),
  KEY `fk_ASISTENCIA_PRACTICA-PRACTICA_ESTUDIANTE_idx` (`Estudiante`,`Practica`),
  KEY `fk_ASISTENCIA_PRACTICA-AUTO-ESCUELA_idx` (`Auto`),
  CONSTRAINT `fk_ASISTENCIA_PRACTICA-ASISTENCIA` FOREIGN KEY (`Asistencia`) REFERENCES `asistencia` (`idASISTENCIA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ASISTENCIA_PRACTICA-AUTO-ESCUELA` FOREIGN KEY (`Auto`) REFERENCES `auto_escuela` (`Matricula`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ASISTENCIA_PRACTICA-PRACTICA_ESTUDIANTE` FOREIGN KEY (`Estudiante`, `Practica`) REFERENCES `practica_estudiante` (`Estudiante`, `Practica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia_practica`
--

LOCK TABLES `asistencia_practica` WRITE;
/*!40000 ALTER TABLE `asistencia_practica` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia_practica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencia_teoria`
--

DROP TABLE IF EXISTS `asistencia_teoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia_teoria` (
  `Asistencia` int(11) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `Teoria` int(11) NOT NULL,
  PRIMARY KEY (`Asistencia`,`Estudiante`,`Teoria`),
  KEY `fk_ASISTENCIA_TEORIA-TEORIA_ESTUDIANTE_idx` (`Estudiante`,`Teoria`),
  CONSTRAINT `fk_ASISTENCIA_TEORIA-ASISTENCIA` FOREIGN KEY (`Asistencia`) REFERENCES `asistencia` (`idASISTENCIA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ASISTENCIA_TEORIA-TEORIA_ESTUDIANTE` FOREIGN KEY (`Estudiante`, `Teoria`) REFERENCES `teoria_estudiante` (`Estudiante`, `Teoria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia_teoria`
--

LOCK TABLES `asistencia_teoria` WRITE;
/*!40000 ALTER TABLE `asistencia_teoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia_teoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `atencion`
--

DROP TABLE IF EXISTS `atencion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `atencion` (
  `Nombre` varchar(10) NOT NULL,
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atencion`
--

LOCK TABLES `atencion` WRITE;
/*!40000 ALTER TABLE `atencion` DISABLE KEYS */;
INSERT INTO `atencion` VALUES ('Tipo1'),('Tipo2'),('Tipo3');
/*!40000 ALTER TABLE `atencion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `atencion_cliente`
--

DROP TABLE IF EXISTS `atencion_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `atencion_cliente` (
  `idATENCION_CLIENTE` int(11) NOT NULL,
  `Usuario` varchar(45) NOT NULL,
  `Cliente` int(11) NOT NULL,
  PRIMARY KEY (`idATENCION_CLIENTE`),
  KEY `fk_ATENCION-USUARIO_idx` (`Usuario`),
  KEY `fk_ATENCION-CLIENTE_idx` (`Cliente`),
  CONSTRAINT `fk_ATENCION-CLIENTE` FOREIGN KEY (`Cliente`) REFERENCES `cliente` (`idCLIENTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ATENCION-USUARIO` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atencion_cliente`
--

LOCK TABLES `atencion_cliente` WRITE;
/*!40000 ALTER TABLE `atencion_cliente` DISABLE KEYS */;
INSERT INTO `atencion_cliente` VALUES (8,'luzhow',10),(9,'luzhow',11),(10,'luzhow',12),(11,'luzhow',13),(12,'luzhow',14),(13,'Luzhow',15);
/*!40000 ALTER TABLE `atencion_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auto_escuela`
--

DROP TABLE IF EXISTS `auto_escuela`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `auto_escuela` (
  `Matricula` varchar(6) NOT NULL,
  `Modelo` varchar(45) DEFAULT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`Matricula`),
  KEY `fk_AUTO-ESCUELA-ESTADO_AUTO_idx` (`Estado`),
  CONSTRAINT `fk_AUTO-ESCUELA-ESTADO_AUTO` FOREIGN KEY (`Estado`) REFERENCES `estado_auto` (`Estado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auto_escuela`
--

LOCK TABLES `auto_escuela` WRITE;
/*!40000 ALTER TABLE `auto_escuela` DISABLE KEYS */;
INSERT INTO `auto_escuela` VALUES ('zzxx22','Chevrolet','Mantencion'),('zzyy00','Nissan','Activo');
/*!40000 ALTER TABLE `auto_escuela` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cambio_rueda`
--

DROP TABLE IF EXISTS `cambio_rueda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cambio_rueda` (
  `idCAMBIO_RUEDA` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Horario` time NOT NULL,
  `Instructor` int(11) NOT NULL,
  PRIMARY KEY (`idCAMBIO_RUEDA`),
  KEY `fk_CAMBIO_RUEDA-INSTRUCTOR_idx` (`Instructor`),
  CONSTRAINT `fk_CAMBIO_RUEDA-INSTRUCTOR` FOREIGN KEY (`Instructor`) REFERENCES `instructor` (`idINSTRUCTOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cambio_rueda`
--

LOCK TABLES `cambio_rueda` WRITE;
/*!40000 ALTER TABLE `cambio_rueda` DISABLE KEYS */;
/*!40000 ALTER TABLE `cambio_rueda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clase`
--

DROP TABLE IF EXISTS `clase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clase` (
  `Codigo` varchar(10) NOT NULL,
  `Curso` varchar(10) NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaTermino` date NOT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `fk_CLASE-CURSO_idx` (`Curso`),
  CONSTRAINT `fk_CLASE-CURSO` FOREIGN KEY (`Curso`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clase`
--

LOCK TABLES `clase` WRITE;
/*!40000 ALTER TABLE `clase` DISABLE KEYS */;
INSERT INTO `clase` VALUES ('0','A','2013-01-12','2013-02-12'),('1','B','2013-01-12','2013-02-12'),('2','C','2013-01-12','2013-02-12'),('3','A','2013-01-13','2013-02-13');
/*!40000 ALTER TABLE `clase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clase_estudiante`
--

DROP TABLE IF EXISTS `clase_estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clase_estudiante` (
  `Clase` varchar(10) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `ExamenVisual` int(11) DEFAULT NULL,
  `Psicotecnico` int(11) DEFAULT NULL,
  `ClaseCambioRueda` int(11) DEFAULT NULL,
  PRIMARY KEY (`Clase`,`Estudiante`),
  KEY `fk_CLASE_ESTUDIANTE-ESTUDIANTE_idx` (`Estudiante`),
  KEY `fk_CLASE_ESTUDIANTE-EXAMEN_VISUAL_idx` (`ExamenVisual`),
  KEY `fk_CLASE_ESTUDIANTE-PSICOTECNICO_idx` (`Psicotecnico`),
  KEY `fk_CLASE_ESTUDIANTE-CAMBIO_RUEDA_idx` (`ClaseCambioRueda`),
  CONSTRAINT `fk_CLASE_ESTUDIANTE-CAMBIO_RUEDA` FOREIGN KEY (`ClaseCambioRueda`) REFERENCES `cambio_rueda` (`idCAMBIO_RUEDA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-CLASE` FOREIGN KEY (`Clase`) REFERENCES `clase` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-EXAMEN_VISUAL` FOREIGN KEY (`ExamenVisual`) REFERENCES `examen_visual` (`idEXAMEN_VISUAL`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-PSICOTECNICO` FOREIGN KEY (`Psicotecnico`) REFERENCES `psicotecnico` (`idPSICOTECNICO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clase_estudiante`
--

LOCK TABLES `clase_estudiante` WRITE;
/*!40000 ALTER TABLE `clase_estudiante` DISABLE KEYS */;
/*!40000 ALTER TABLE `clase_estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCLIENTE` int(11) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Fecha` date NOT NULL,
  `Telefono` decimal(10,0) DEFAULT NULL,
  `Curso` varchar(10) NOT NULL,
  `Atención` varchar(10) NOT NULL,
  `Extra` text,
  PRIMARY KEY (`idCLIENTE`),
  KEY `fk_CLIENTE-ATENCION_idx` (`Atención`),
  KEY `fk_CLIENTE-CURSO_idx` (`Curso`),
  CONSTRAINT `fk_CLIENTE-ATENCION` FOREIGN KEY (`Atención`) REFERENCES `atencion` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLIENTE-CURSO` FOREIGN KEY (`Curso`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (10,'Mario Araya Andrade','2014-10-12',63209889,'B','Tipo1','Pretende matricularse el proximo año'),(11,'','2014-10-12',0,'A','Tipo1',''),(12,'q','2014-10-12',0,'A','Tipo1',''),(13,'Luis Barrientos','2014-10-08',1234567,'C','Tipo1','Prueba'),(14,'dsasda','2014-10-12',0,'B','Tipo1',''),(15,'asdfasdfasf','2014-10-13',123123123,'C','Tipo1','afdfweyh');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curso` (
  `Codigo` varchar(10) NOT NULL,
  `PrecioAdulto` decimal(10,0) NOT NULL,
  `PrecioEstudiante` decimal(10,0) NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
INSERT INTO `curso` VALUES ('A',1,2),('B',3,3),('C',4,6);
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docente`
--

DROP TABLE IF EXISTS `docente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `docente` (
  `idDOCENTE` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  PRIMARY KEY (`idDOCENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docente`
--

LOCK TABLES `docente` WRITE;
/*!40000 ALTER TABLE `docente` DISABLE KEYS */;
INSERT INTO `docente` VALUES (2,'Jose','87654321'),(4,'Luis ','12344321'),(33,'Kurt ','12345678');
/*!40000 ALTER TABLE `docente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_auto`
--

DROP TABLE IF EXISTS `estado_auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estado_auto` (
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`Estado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_auto`
--

LOCK TABLES `estado_auto` WRITE;
/*!40000 ALTER TABLE `estado_auto` DISABLE KEYS */;
INSERT INTO `estado_auto` VALUES ('Activo'),('Mantención');
/*!40000 ALTER TABLE `estado_auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiante`
--

DROP TABLE IF EXISTS `estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estudiante` (
  `idESTUDIANTE` int(11) NOT NULL DEFAULT '0',
  `Matricula` varchar(6) NOT NULL,
  `FotosCarnet` int(11) NOT NULL,
  `CertEstudios` tinyint(1) NOT NULL,
  `CertAlumnRegular` tinyint(1) NOT NULL,
  `AutNotarial` tinyint(1) NOT NULL,
  PRIMARY KEY (`idESTUDIANTE`),
  KEY `fk_ESTUDIANTE-MATRICULA_idx` (`Matricula`),
  CONSTRAINT `fk_ESTUDIANTE-MATRICULA` FOREIGN KEY (`Matricula`) REFERENCES `matricula` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiante`
--

LOCK TABLES `estudiante` WRITE;
/*!40000 ALTER TABLE `estudiante` DISABLE KEYS */;
INSERT INTO `estudiante` VALUES (0,'11',0,1,1,0);
/*!40000 ALTER TABLE `estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen_practico`
--

DROP TABLE IF EXISTS `examen_practico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examen_practico` (
  `idEXAMEN_PRACTICO` int(11) NOT NULL,
  `Instructor` int(11) NOT NULL,
  `Calificacion` decimal(10,0) NOT NULL COMMENT 'el estado del examen se deduce de la calificación, de 75% hacia arriba es aprobado.',
  `Fecha` date NOT NULL,
  PRIMARY KEY (`idEXAMEN_PRACTICO`),
  KEY `fk_EXAMEN_PRACTICO_INSTRUCTOR_idx` (`Instructor`),
  CONSTRAINT `fk_EXAMEN_PRACTICO-INSTRUCTOR` FOREIGN KEY (`Instructor`) REFERENCES `instructor` (`idINSTRUCTOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen_practico`
--

LOCK TABLES `examen_practico` WRITE;
/*!40000 ALTER TABLE `examen_practico` DISABLE KEYS */;
/*!40000 ALTER TABLE `examen_practico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen_teorico`
--

DROP TABLE IF EXISTS `examen_teorico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examen_teorico` (
  `idEXAMEN_TEORICO` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Examinador` varchar(255) NOT NULL,
  `Calificacion` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idEXAMEN_TEORICO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen_teorico`
--

LOCK TABLES `examen_teorico` WRITE;
/*!40000 ALTER TABLE `examen_teorico` DISABLE KEYS */;
/*!40000 ALTER TABLE `examen_teorico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen_visual`
--

DROP TABLE IF EXISTS `examen_visual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examen_visual` (
  `idEXAMEN_VISUAL` int(11) NOT NULL AUTO_INCREMENT,
  `Examinador` varchar(255) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  `Certificado` tinyint(1) NOT NULL,
  `Fecha` date NOT NULL,
  PRIMARY KEY (`idEXAMEN_VISUAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen_visual`
--

LOCK TABLES `examen_visual` WRITE;
/*!40000 ALTER TABLE `examen_visual` DISABLE KEYS */;
/*!40000 ALTER TABLE `examen_visual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `instructor`
--

DROP TABLE IF EXISTS `instructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `instructor` (
  `idINSTRUCTOR` int(11) NOT NULL,
  `Auto` varchar(6) NOT NULL,
  PRIMARY KEY (`idINSTRUCTOR`),
  KEY `fk_INSTRUCTOR-AUTO-ESCUELA_idx` (`Auto`),
  CONSTRAINT `fk_INSTRUCTOR-AUTO-ESCUELA` FOREIGN KEY (`Auto`) REFERENCES `auto_escuela` (`Matricula`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_INSTRUCTOR-DOCENTE` FOREIGN KEY (`idINSTRUCTOR`) REFERENCES `docente` (`idDOCENTE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `instructor`
--

LOCK TABLES `instructor` WRITE;
/*!40000 ALTER TABLE `instructor` DISABLE KEYS */;
INSERT INTO `instructor` VALUES (4,'zzxx22'),(33,'zzyy00');
/*!40000 ALTER TABLE `instructor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matricula`
--

DROP TABLE IF EXISTS `matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matricula` (
  `Codigo` varchar(6) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `RUT` varchar(10) NOT NULL,
  `Edad` int(11) NOT NULL,
  `Fecha` varchar(45) NOT NULL,
  `Telefono` decimal(10,0) NOT NULL,
  `CodigoPago` int(11) NOT NULL,
  `Curso` varchar(10) NOT NULL,
  `HoraTeoria` time NOT NULL,
  `HoraPractica` time NOT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `fk_MATRICULA-CURSO_idx` (`Curso`),
  KEY `fk_MATRICULA-PAGO_idx` (`CodigoPago`),
  CONSTRAINT `fk_MATRICULA-CURSO` FOREIGN KEY (`Curso`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_MATRICULA-PAGO` FOREIGN KEY (`CodigoPago`) REFERENCES `pago` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matricula`
--

LOCK TABLES `matricula` WRITE;
/*!40000 ALTER TABLE `matricula` DISABLE KEYS */;
INSERT INTO `matricula` VALUES ('11','luis','181312866',25,'2014-10-16',123534,22,'A','19:00:00','13:00:00');
/*!40000 ALTER TABLE `matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medio_pago`
--

DROP TABLE IF EXISTS `medio_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medio_pago` (
  `Medio` varchar(255) NOT NULL,
  PRIMARY KEY (`Medio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medio_pago`
--

LOCK TABLES `medio_pago` WRITE;
/*!40000 ALTER TABLE `medio_pago` DISABLE KEYS */;
INSERT INTO `medio_pago` VALUES ('Convenio'),('Efectivo'),('Tarjeta');
/*!40000 ALTER TABLE `medio_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pago` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Monto` decimal(10,0) NOT NULL,
  `Medio` varchar(255) NOT NULL,
  PRIMARY KEY (`Codigo`),
  KEY `fk_PAGO-MEDIO_PAGO_idx` (`Medio`),
  CONSTRAINT `fk_PAGO-MEDIO_PAGO` FOREIGN KEY (`Medio`) REFERENCES `medio_pago` (`Medio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=89 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
INSERT INTO `pago` VALUES (1,0,'Convenio'),(22,1,'Convenio');
/*!40000 ALTER TABLE `pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `practica`
--

DROP TABLE IF EXISTS `practica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `practica` (
  `idPRACTICA` int(11) NOT NULL,
  `Clase` varchar(10) NOT NULL,
  `Instructor` int(11) NOT NULL,
  `Horario` time NOT NULL,
  PRIMARY KEY (`idPRACTICA`),
  KEY `fk_PRACTICA-CLASE_idx` (`Clase`),
  KEY `fk_PRACTICA-INSTRUCTOR_idx` (`Instructor`),
  CONSTRAINT `fk_PRACTICA-CLASE` FOREIGN KEY (`Clase`) REFERENCES `clase` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRACTICA-INSTRUCTOR` FOREIGN KEY (`Instructor`) REFERENCES `instructor` (`idINSTRUCTOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practica`
--

LOCK TABLES `practica` WRITE;
/*!40000 ALTER TABLE `practica` DISABLE KEYS */;
INSERT INTO `practica` VALUES (0,'1',33,'12:00:00'),(1,'3',4,'13:00:00');
/*!40000 ALTER TABLE `practica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `practica_estudiante`
--

DROP TABLE IF EXISTS `practica_estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `practica_estudiante` (
  `Practica` int(11) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `ExamenPractico` int(11) DEFAULT NULL,
  PRIMARY KEY (`Practica`,`Estudiante`),
  KEY `fk_PRACTICA_ESTUDIANTE_ESTUDIANTE_idx` (`Estudiante`),
  KEY `fk_PRACTICA_ESTUDIANTE_EXAMEN_PRACTICO_idx` (`ExamenPractico`),
  CONSTRAINT `fk_PRACTICA_ESTUDIANTE-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRACTICA_ESTUDIANTE-EXAMEN_PRACTICO` FOREIGN KEY (`ExamenPractico`) REFERENCES `examen_practico` (`idEXAMEN_PRACTICO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRACTICA_ESTUDIANTE-PRACTICA` FOREIGN KEY (`Practica`) REFERENCES `practica` (`idPRACTICA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practica_estudiante`
--

LOCK TABLES `practica_estudiante` WRITE;
/*!40000 ALTER TABLE `practica_estudiante` DISABLE KEYS */;
/*!40000 ALTER TABLE `practica_estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesor`
--

DROP TABLE IF EXISTS `profesor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profesor` (
  `idPROFESOR` int(11) NOT NULL,
  PRIMARY KEY (`idPROFESOR`),
  CONSTRAINT `fk_PROFESOR-DOCENTE` FOREIGN KEY (`idPROFESOR`) REFERENCES `docente` (`idDOCENTE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesor`
--

LOCK TABLES `profesor` WRITE;
/*!40000 ALTER TABLE `profesor` DISABLE KEYS */;
INSERT INTO `profesor` VALUES (2),(4);
/*!40000 ALTER TABLE `profesor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `psicotecnico`
--

DROP TABLE IF EXISTS `psicotecnico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `psicotecnico` (
  `idPSICOTECNICO` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Examinador` varchar(255) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`idPSICOTECNICO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `psicotecnico`
--

LOCK TABLES `psicotecnico` WRITE;
/*!40000 ALTER TABLE `psicotecnico` DISABLE KEYS */;
/*!40000 ALTER TABLE `psicotecnico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teoria`
--

DROP TABLE IF EXISTS `teoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teoria` (
  `idTEORIA` int(11) NOT NULL,
  `Clase` varchar(10) NOT NULL,
  `Horario` time NOT NULL,
  `Duracion` int(11) NOT NULL,
  `Profesor` int(11) NOT NULL,
  PRIMARY KEY (`idTEORIA`),
  KEY `fk_TEORIA-PROFESOR_idx` (`Profesor`),
  KEY `fk_TEORIA-CLASE_idx` (`Clase`),
  CONSTRAINT `fk_TEORIA-CLASE` FOREIGN KEY (`Clase`) REFERENCES `clase` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEORIA-PROFESOR` FOREIGN KEY (`Profesor`) REFERENCES `profesor` (`idPROFESOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teoria`
--

LOCK TABLES `teoria` WRITE;
/*!40000 ALTER TABLE `teoria` DISABLE KEYS */;
INSERT INTO `teoria` VALUES (0,'0','19:00:00',45,2),(1,'1','19:00:00',45,4);
/*!40000 ALTER TABLE `teoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teoria_estudiante`
--

DROP TABLE IF EXISTS `teoria_estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teoria_estudiante` (
  `Teoria` int(11) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  `ExameTeorico` int(11) DEFAULT NULL,
  PRIMARY KEY (`Teoria`,`Estudiante`),
  KEY `fk_TEORIA_ESTUDIANTE_ESTUDIANTE_idx` (`Estudiante`),
  KEY `fk_TEORIA_ESTUDIANTE_EXAMEN_TEORICO_idx` (`ExameTeorico`),
  CONSTRAINT `fk_TEORIA_ESTUDIANTE-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEORIA_ESTUDIANTE-EXAMEN_TEORICO` FOREIGN KEY (`ExameTeorico`) REFERENCES `examen_teorico` (`idEXAMEN_TEORICO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEORIA_ESTUDIANTE-TEORIA` FOREIGN KEY (`Teoria`) REFERENCES `teoria` (`idTEORIA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teoria_estudiante`
--

LOCK TABLES `teoria_estudiante` WRITE;
/*!40000 ALTER TABLE `teoria_estudiante` DISABLE KEYS */;
/*!40000 ALTER TABLE `teoria_estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_usuario` (
  `Tipo` varchar(45) NOT NULL,
  PRIMARY KEY (`Tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES ('1');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `Nombre` varchar(45) NOT NULL,
  `Contraseña` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  PRIMARY KEY (`Nombre`),
  KEY `fk_USUARIO-TIPO_idx` (`Tipo`),
  CONSTRAINT `fk_USUARIO-TIPO` FOREIGN KEY (`Tipo`) REFERENCES `tipo_usuario` (`Tipo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('Luzhow','1234asd','1');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-10-23  4:04:13
