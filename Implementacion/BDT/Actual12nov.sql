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
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `area` (
  `Nombre` varchar(45) NOT NULL COMMENT 'Representa el nombre completo de la familia de ingresos (servicio) que representa, por ejemplo licencia tipo B, A-1, etc...',
  `Alias` varchar(45) DEFAULT NULL COMMENT 'Representa al código que se usa para identificar producto que pertenece al área.',
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES ('A-2','Licencia de conducir clase A-2'),('A-3','Licencia de conducir clase A-3'),('A-4','Licencia de conducir clase A-4'),('A-5','Licencia de conducir clase A-5'),('B','Licencia de conducir clase B'),('D','Licencia de conducir clase D');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

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
  KEY `fk_ASISITENCIA_PRACTICA-PRACTICA_idx` (`Practica`),
  CONSTRAINT `fk_ASISITENCIA_PRACTICA-PRACTICA` FOREIGN KEY (`Practica`) REFERENCES `practica` (`idPRACTICA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
-- Table structure for table `atencion_cliente_potencial`
--

DROP TABLE IF EXISTS `atencion_cliente_potencial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `atencion_cliente_potencial` (
  `idATENCION_CLIENTE_POTENCIAL` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(45) NOT NULL,
  `Cliente_Potencial` int(11) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Tipo` varchar(3) NOT NULL COMMENT 'Se refiere a si la atención fue en',
  PRIMARY KEY (`idATENCION_CLIENTE_POTENCIAL`),
  KEY `fk_ATENCION-USUARIO_idx` (`Usuario`),
  KEY `fk_ATENCION-CLIENTE_idx` (`Cliente_Potencial`),
  CONSTRAINT `fk_ATENCION-CLIENTE` FOREIGN KEY (`Cliente_Potencial`) REFERENCES `cliente_potencial` (`idCLIENTE_POTENCIAL`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ATENCION-USUARIO` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atencion_cliente_potencial`
--

LOCK TABLES `atencion_cliente_potencial` WRITE;
/*!40000 ALTER TABLE `atencion_cliente_potencial` DISABLE KEYS */;
/*!40000 ALTER TABLE `atencion_cliente_potencial` ENABLE KEYS */;
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
INSERT INTO `auto_escuela` VALUES ('BBDD03','Jeep Compass','Disponible'),('BBFD54','Nissan Terrano','Disponible'),('BBSS76','Ford Focus','Disponible'),('FFDT64','Ford Ranger','No Disponible'),('XXYY21','Chevrolet Spark','Disponible'),('XXZZ23','Nissan V16','Disponible');
/*!40000 ALTER TABLE `auto_escuela` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boleta`
--

DROP TABLE IF EXISTS `boleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `boleta` (
  `Codigo` varchar(6) NOT NULL,
  PRIMARY KEY (`Codigo`),
  CONSTRAINT `fk_PAGO-BOLETA` FOREIGN KEY (`Codigo`) REFERENCES `pago` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boleta`
--

LOCK TABLES `boleta` WRITE;
/*!40000 ALTER TABLE `boleta` DISABLE KEYS */;
/*!40000 ALTER TABLE `boleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cambio_rueda`
--

DROP TABLE IF EXISTS `cambio_rueda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cambio_rueda` (
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Horario` time NOT NULL,
  `Instructor` int(11) NOT NULL,
  PRIMARY KEY (`Codigo`,`Documento`),
  UNIQUE KEY `Fecha_UNIQUE` (`Fecha`,`Horario`) COMMENT 'No se pueden repetir ambos juntos, Fecha ni horario',
  KEY `fk_CAMBIO_RUEDA-INSTRUCTOR_idx` (`Instructor`),
  KEY `fk_CAMBIO_RUEDA-DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_CAMBIO_RUEDA-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
  CONSTRAINT `fk_CLASE_ESTUDIANTE-CAMBIO_RUEDA` FOREIGN KEY (`ClaseCambioRueda`) REFERENCES `cambio_rueda` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-CLASE` FOREIGN KEY (`Clase`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-EXAMEN_VISUAL` FOREIGN KEY (`ExamenVisual`) REFERENCES `examen_visual` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLASE_ESTUDIANTE-PSICOTECNICO` FOREIGN KEY (`Psicotecnico`) REFERENCES `psicotecnico` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `RUT` varchar(11) NOT NULL,
  `Fecha_Nac` date NOT NULL,
  `Telefono` decimal(10,0) NOT NULL,
  `e-Mail` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idCLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente_potencial`
--

DROP TABLE IF EXISTS `cliente_potencial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente_potencial` (
  `idCLIENTE_POTENCIAL` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  `Telefono` decimal(10,0) DEFAULT NULL,
  `Producto` varchar(10) NOT NULL COMMENT 'Representa el producto por el cual el cliente muestra interés.',
  `Extra` text COMMENT 'Algún comentario o informacion adicional que se quisiese guardar.',
  PRIMARY KEY (`idCLIENTE_POTENCIAL`),
  KEY `fk_CLIENTE-CURSO_idx` (`Producto`),
  CONSTRAINT `fk_CLIENTE-CURSO` FOREIGN KEY (`Producto`) REFERENCES `producto` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente_potencial`
--

LOCK TABLES `cliente_potencial` WRITE;
/*!40000 ALTER TABLE `cliente_potencial` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente_potencial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
  `idCOMPRA` int(11) NOT NULL,
  `Cliente` int(11) NOT NULL,
  `Producto` varchar(40) NOT NULL,
  `Fecha` date NOT NULL COMMENT 'Fecha en que se realiza la compra',
  PRIMARY KEY (`idCOMPRA`),
  KEY `fk_COMPRA-CLIENTE_idx` (`Cliente`),
  KEY `fk_COMPRA-PRODUCTO_idx` (`Producto`),
  CONSTRAINT `fk_COMPRA-CLIENTE` FOREIGN KEY (`Cliente`) REFERENCES `cliente` (`idCLIENTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_COMPRA-PRODUCTO` FOREIGN KEY (`Producto`) REFERENCES `producto` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curso` (
  `Codigo` varchar(10) NOT NULL,
  `Producto` varchar(40) NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaTermino` date NOT NULL,
  PRIMARY KEY (`Codigo`,`Producto`),
  KEY `fk_CLASE-CURSO_idx` (`Producto`),
  CONSTRAINT `fk_CURSO-PRODUCTO` FOREIGN KEY (`Producto`) REFERENCES `producto` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
INSERT INTO `curso` VALUES ('A2-001','A2-001','2015-06-12','2015-12-12'),('A2-002','A2-002','2015-06-12','2015-12-12'),('A3-001','A3-001','2015-06-12','2015-12-12'),('A4-001','A4-001','2015-06-12','2015-12-12'),('A5-001','A5-001','2015-06-12','2015-12-12'),('B-001','B-001','2015-06-12','2015-12-12'),('B-002','B-002','2015-06-12','2015-12-12'),('D-001','D-001','2015-06-12','2015-12-12');
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
  `Telefono` varchar(45) NOT NULL,
  `Tipo` varchar(3) NOT NULL COMMENT 'PRO',
  PRIMARY KEY (`idDOCENTE`),
  CONSTRAINT `fk_DOCENTE_FUNCIONARIO` FOREIGN KEY (`idDOCENTE`) REFERENCES `funcionario` (`idFUNCIONARIO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docente`
--

LOCK TABLES `docente` WRITE;
/*!40000 ALTER TABLE `docente` DISABLE KEYS */;
INSERT INTO `docente` VALUES (16,'0','PRO'),(17,'2321232','PRO'),(18,'2321232','INS');
/*!40000 ALTER TABLE `docente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documento`
--

DROP TABLE IF EXISTS `documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `documento` (
  `idDOCUMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(45) NOT NULL,
  PRIMARY KEY (`idDOCUMENTO`),
  UNIQUE KEY `Tipo_UNIQUE` (`Tipo`),
  CONSTRAINT `fk_DOCUMENTO-TIPO_DOCUMENTO` FOREIGN KEY (`Tipo`) REFERENCES `tipo_documento` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documento`
--

LOCK TABLES `documento` WRITE;
/*!40000 ALTER TABLE `documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `documento` ENABLE KEYS */;
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
INSERT INTO `estado_auto` VALUES ('Disponible'),('No Disponible');
/*!40000 ALTER TABLE `estado_auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiante`
--

DROP TABLE IF EXISTS `estudiante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estudiante` (
  `idESTUDIANTE` int(11) NOT NULL,
  `FotosCarnet` int(11) NOT NULL DEFAULT '0' COMMENT 'Indica la cantidad de Fotos tamaño carnet que ha entregado el estudiante',
  `CertEstudios` tinyint(1) NOT NULL DEFAULT '0',
  `CertAlumnRegular` tinyint(1) NOT NULL DEFAULT '0',
  `AutNotarial` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idESTUDIANTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiante`
--

LOCK TABLES `estudiante` WRITE;
/*!40000 ALTER TABLE `estudiante` DISABLE KEYS */;
/*!40000 ALTER TABLE `estudiante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiante_documento`
--

DROP TABLE IF EXISTS `estudiante_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estudiante_documento` (
  `Estudiante` int(11) NOT NULL,
  `Documento` varchar(45) NOT NULL,
  PRIMARY KEY (`Estudiante`,`Documento`),
  KEY `fk_ESTUDIANTE_DOCUMENTO-DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_ESTUDIANTE_DOCUMENTO-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`Tipo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ESTUDIANTE_DOCUMENTO-ESTUDIANTE` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiante_documento`
--

LOCK TABLES `estudiante_documento` WRITE;
/*!40000 ALTER TABLE `estudiante_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `estudiante_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen_municipal`
--

DROP TABLE IF EXISTS `examen_municipal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examen_municipal` (
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Instructor` int(11) NOT NULL COMMENT 'Instructor que le enseñó',
  `Estado` varchar(45) NOT NULL COMMENT 'Aprobado o reprobado',
  `Comentario` text COMMENT 'Motivo en caso de reprobar',
  PRIMARY KEY (`Codigo`,`Documento`),
  KEY `fk_EXAMEN_MUNICIPAL-DOCUMENTO_idx` (`Documento`),
  KEY `fk_EXAMEN_MUNICIPAL-INSTRUCTOR_idx` (`Instructor`),
  CONSTRAINT `fk_EXAMEN_MUNICIPAL-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_EXAMEN_MUNICIPAL-INSTRUCTOR` FOREIGN KEY (`Instructor`) REFERENCES `instructor` (`idINSTRUCTOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen_municipal`
--

LOCK TABLES `examen_municipal` WRITE;
/*!40000 ALTER TABLE `examen_municipal` DISABLE KEYS */;
/*!40000 ALTER TABLE `examen_municipal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen_practico`
--

DROP TABLE IF EXISTS `examen_practico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examen_practico` (
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Instructor` int(11) NOT NULL,
  `Calificacion` decimal(10,0) NOT NULL COMMENT 'el estado del examen se deduce de la calificación, de 75% hacia arriba es aprobado.',
  PRIMARY KEY (`Codigo`,`Documento`),
  KEY `fk_EXAMEN_PRACTICO_INSTRUCTOR_idx` (`Instructor`),
  KEY `fk_EXAMEN_PRACTICO-DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_EXAMEN_PRACTICO-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Examinador` varchar(255) NOT NULL,
  `Calificacion` decimal(10,0) NOT NULL,
  PRIMARY KEY (`Codigo`,`Documento`),
  KEY `fk_EXAMEN_TEORICO-DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_EXAMEN_TEORICO-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Examinador` int(11) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  `Certificado` tinyint(1) NOT NULL DEFAULT '0',
  `Fecha` date NOT NULL,
  PRIMARY KEY (`Codigo`,`Documento`),
  KEY `fk_EXAMEN_VISUAL-FUNCIONARIO_idx` (`Examinador`),
  KEY `fk_EXAMEN_VISUAL-DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_EXAMEN_VISUAL-DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_EXAMEN_VISUAL-FUNCIONARIO` FOREIGN KEY (`Examinador`) REFERENCES `funcionario` (`idFUNCIONARIO`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `Codigo` varchar(6) NOT NULL,
  PRIMARY KEY (`Codigo`),
  CONSTRAINT `fk_FACTURA-PAGO` FOREIGN KEY (`Codigo`) REFERENCES `pago` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcionario` (
  `idFUNCIONARIO` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Tipo` varchar(20) NOT NULL COMMENT 'crear trigger on insert',
  PRIMARY KEY (`idFUNCIONARIO`),
  KEY `fk_FUNCIONARIO-TIPO_FUNCIONARIO_idx` (`Tipo`),
  CONSTRAINT `fk_FUNCIONARIO-TIPO_FUNCIONARIO` FOREIGN KEY (`Tipo`) REFERENCES `tipo_funcionario` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'Desarrollador','Administrador'),(2,'Dirección','Administrador'),(3,'Cristina Avilés Montoya','Oficina'),(4,'Milba Echevarría Mata','Oficina'),(5,'Ivon Armenta Cerda','Docente'),(6,'Arián Romero Dueñas','Docente'),(7,'Apollo Guzmán Núñez','Docente'),(8,'Germana Navarrete Zamora','Docente'),(9,'Nolan Martínez Castro','Docente'),(10,'Amadis Escobedo Carranza','Docente'),(11,'','Docente'),(12,'','Docente'),(13,'','Docente'),(14,'','Docente'),(15,'','Docente'),(16,'Andres','Docente'),(17,'Luis','Docente'),(18,'Luis','Docente');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
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
INSERT INTO `instructor` VALUES (18,'BBDD03');
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
  `CodigoCompra` int(11) NOT NULL,
  `Curso` varchar(10) NOT NULL,
  `HoraTeoria` time NOT NULL,
  `HoraPractica` time NOT NULL,
  `Documento` varchar(45) NOT NULL,
  `Estudiante` int(11) NOT NULL,
  PRIMARY KEY (`Codigo`,`Estudiante`,`Documento`),
  KEY `fk_MATRICULA-COMPRA_idx` (`CodigoCompra`),
  KEY `fk_MATRICULA_DOCUMENTO_idx` (`Documento`),
  KEY `fk_MATRICULA_ESTUDIANTE1_idx` (`Estudiante`),
  KEY `fk_MATRICULA-CURSO_idx` (`Curso`),
  CONSTRAINT `fk_MATRICULA-COMPRA` FOREIGN KEY (`CodigoCompra`) REFERENCES `compra` (`idCOMPRA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_MATRICULA-CURSO` FOREIGN KEY (`Curso`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_MATRICULA_DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`Tipo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_MATRICULA_ESTUDIANTE1` FOREIGN KEY (`Estudiante`) REFERENCES `estudiante` (`idESTUDIANTE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matricula`
--

LOCK TABLES `matricula` WRITE;
/*!40000 ALTER TABLE `matricula` DISABLE KEYS */;
/*!40000 ALTER TABLE `matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medio_pago`
--

DROP TABLE IF EXISTS `medio_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medio_pago` (
  `Nombre` varchar(25) NOT NULL,
  PRIMARY KEY (`Nombre`)
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
  `Codigo` varchar(6) NOT NULL,
  `Monto` decimal(10,0) NOT NULL,
  `Medio_Pago` varchar(25) NOT NULL,
  `Compra` int(11) NOT NULL COMMENT 'Compra a la que corresponde',
  `Fecha` date NOT NULL COMMENT 'Fecha en que es realizado el pago (ideal = a la compra)',
  PRIMARY KEY (`Codigo`),
  KEY `fk_PAGO_MEDIO_PAGO1_idx` (`Medio_Pago`),
  KEY `fk_PAGO-COMPRA_idx` (`Compra`),
  CONSTRAINT `fk_PAGO-COMPRA` FOREIGN KEY (`Compra`) REFERENCES `compra` (`Cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PAGO_MEDIO_PAGO1` FOREIGN KEY (`Medio_Pago`) REFERENCES `medio_pago` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
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
  CONSTRAINT `fk_PRACTICA-CLASE` FOREIGN KEY (`Clase`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRACTICA-INSTRUCTOR` FOREIGN KEY (`Instructor`) REFERENCES `instructor` (`idINSTRUCTOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practica`
--

LOCK TABLES `practica` WRITE;
/*!40000 ALTER TABLE `practica` DISABLE KEYS */;
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
  CONSTRAINT `fk_PRACTICA_ESTUDIANTE-EXAMEN_PRACTICO` FOREIGN KEY (`ExamenPractico`) REFERENCES `examen_practico` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
-- Table structure for table `precio`
--

DROP TABLE IF EXISTS `precio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `precio` (
  `Producto` varchar(45) NOT NULL,
  `Tipo_Cliente` varchar(10) NOT NULL,
  `Monto` decimal(10,0) NOT NULL DEFAULT '0' COMMENT 'Reprecenta el precio del producto ''Producto'' para el un cliente dado su ''Tipo_Cliente''',
  PRIMARY KEY (`Producto`,`Tipo_Cliente`),
  KEY `fk_PRECIO-TIPO_CLIENTE_idx` (`Tipo_Cliente`),
  CONSTRAINT `fk_PRECIO-PRODUCTO` FOREIGN KEY (`Producto`) REFERENCES `producto` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRECIO-TIPO_CLIENTE` FOREIGN KEY (`Tipo_Cliente`) REFERENCES `tipo_cliente` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `precio`
--

LOCK TABLES `precio` WRITE;
/*!40000 ALTER TABLE `precio` DISABLE KEYS */;
/*!40000 ALTER TABLE `precio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `Nombre` varchar(40) NOT NULL,
  `Area` varchar(45) NOT NULL,
  PRIMARY KEY (`Nombre`),
  KEY `fk_CURSO_AREA1_idx` (`Area`),
  CONSTRAINT `fk_CURSO_AREA1` FOREIGN KEY (`Area`) REFERENCES `area` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES ('A2-001','A-2'),('A2-002','A-2'),('A3-001','A-3'),('A4-001','A-4'),('A5-001','A-5'),('B-001','B'),('B-002','B'),('D-001','D');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_tipo_documento`
--

DROP TABLE IF EXISTS `producto_tipo_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_tipo_documento` (
  `Producto` varchar(10) NOT NULL,
  `Documento` varchar(45) NOT NULL,
  PRIMARY KEY (`Producto`,`Documento`),
  KEY `fk_PRODUCTO_DOCUMENTO-TIPO_DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_PRODUCTO_DOCUMENTO-PRODUCTO` FOREIGN KEY (`Producto`) REFERENCES `producto` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUCTO_DOCUMENTO-TIPO_DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `tipo_documento` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_tipo_documento`
--

LOCK TABLES `producto_tipo_documento` WRITE;
/*!40000 ALTER TABLE `producto_tipo_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto_tipo_documento` ENABLE KEYS */;
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
INSERT INTO `profesor` VALUES (16),(17);
/*!40000 ALTER TABLE `profesor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `psicotecnico`
--

DROP TABLE IF EXISTS `psicotecnico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `psicotecnico` (
  `Codigo` int(11) NOT NULL,
  `Documento` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Examinador` int(11) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo`,`Documento`),
  KEY `fk_PSICOTECNICO_FUNCIONARIO_idx` (`Examinador`),
  KEY `fk_PSICOTECNICO_DOCUMENTO_idx` (`Documento`),
  CONSTRAINT `fk_PSICOTECNICO_DOCUMENTO` FOREIGN KEY (`Documento`) REFERENCES `documento` (`idDOCUMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PSICOTECNICO_FUNCIONARIO` FOREIGN KEY (`Examinador`) REFERENCES `funcionario` (`idFUNCIONARIO`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  CONSTRAINT `fk_TEORIA-CLASE` FOREIGN KEY (`Clase`) REFERENCES `curso` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEORIA-PROFESOR` FOREIGN KEY (`Profesor`) REFERENCES `profesor` (`idPROFESOR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teoria`
--

LOCK TABLES `teoria` WRITE;
/*!40000 ALTER TABLE `teoria` DISABLE KEYS */;
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
  CONSTRAINT `fk_TEORIA_ESTUDIANTE-EXAMEN_TEORICO` FOREIGN KEY (`ExameTeorico`) REFERENCES `examen_teorico` (`Codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
-- Table structure for table `tipo_cliente`
--

DROP TABLE IF EXISTS `tipo_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_cliente` (
  `Nombre` varchar(10) NOT NULL COMMENT 'Se refiere al tipo de ',
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_cliente`
--

LOCK TABLES `tipo_cliente` WRITE;
/*!40000 ALTER TABLE `tipo_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_documento`
--

DROP TABLE IF EXISTS `tipo_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_documento` (
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_documento`
--

LOCK TABLES `tipo_documento` WRITE;
/*!40000 ALTER TABLE `tipo_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_funcionario`
--

DROP TABLE IF EXISTS `tipo_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_funcionario` (
  `Nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_funcionario`
--

LOCK TABLES `tipo_funcionario` WRITE;
/*!40000 ALTER TABLE `tipo_funcionario` DISABLE KEYS */;
INSERT INTO `tipo_funcionario` VALUES ('Administrador'),('Docente'),('Oficina');
/*!40000 ALTER TABLE `tipo_funcionario` ENABLE KEYS */;
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
INSERT INTO `tipo_usuario` VALUES ('Administrador'),('Docente'),('Oficina');
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
  `Tipo` varchar(45) NOT NULL COMMENT 'Se usa para identificar los privilegios:',
  `Funcionario` int(11) NOT NULL COMMENT 'Asociacion a un funcionario de la nomina',
  PRIMARY KEY (`Nombre`),
  KEY `fk_USUARIO-TIPO_idx` (`Tipo`),
  KEY `fk_USUARIO_FUNCIONARIO1_idx` (`Funcionario`),
  CONSTRAINT `fk_USUARIO-TIPO` FOREIGN KEY (`Tipo`) REFERENCES `tipo_usuario` (`Tipo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_USUARIO_FUNCIONARIO` FOREIGN KEY (`Funcionario`) REFERENCES `funcionario` (`idFUNCIONARIO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('Desarrollador','1234asd','Administrador',1);
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

-- Dump completed on 2014-11-13  1:25:21
