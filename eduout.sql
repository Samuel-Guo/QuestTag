-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: edu
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `quest_def`
--

DROP TABLE IF EXISTS `quest_def`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `quest_def` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `caption` varchar(45) DEFAULT NULL,
  `file_path` varchar(100) DEFAULT NULL,
  `detail` varchar(100) DEFAULT NULL,
  `is_valid` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quest_def`
--

LOCK TABLES `quest_def` WRITE;
/*!40000 ALTER TABLE `quest_def` DISABLE KEYS */;
INSERT INTO `quest_def` VALUES (1,'math1','C:\\Users\\Samuel\\Pictures\\1.jpg','m',1),(2,'eng2','C:\\Users\\Samuel\\Pictures\\2.jpg','en',1);
/*!40000 ALTER TABLE `quest_def` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quest_tag_map`
--

DROP TABLE IF EXISTS `quest_tag_map`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `quest_tag_map` (
  `quest_id` int(11) NOT NULL,
  `tag_id` varchar(45) NOT NULL,
  `is_valid` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`quest_id`,`tag_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quest_tag_map`
--

LOCK TABLES `quest_tag_map` WRITE;
/*!40000 ALTER TABLE `quest_tag_map` DISABLE KEYS */;
INSERT INTO `quest_tag_map` VALUES (1,'10',1),(1,'2',1),(1,'9',1);
/*!40000 ALTER TABLE `quest_tag_map` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag_def`
--

DROP TABLE IF EXISTS `tag_def`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tag_def` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `caption` varchar(45) NOT NULL DEFAULT '未命名',
  `group_id` int(11) NOT NULL DEFAULT '1',
  `is_valid` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag_def`
--

LOCK TABLES `tag_def` WRITE;
/*!40000 ALTER TABLE `tag_def` DISABLE KEYS */;
INSERT INTO `tag_def` VALUES (1,'undefined',1,1),(2,'简单',2,1),(3,'中等',2,1),(4,'困难',2,1),(5,'难度',2,1),(8,'哈哈',9,1),(9,'10分以下',3,1),(10,'5分以下',3,1);
/*!40000 ALTER TABLE `tag_def` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag_group_def`
--

DROP TABLE IF EXISTS `tag_group_def`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tag_group_def` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `caption` varchar(100) DEFAULT NULL,
  `is_unique` int(11) NOT NULL DEFAULT '0',
  `is_valid` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `caption_UNIQUE` (`caption`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag_group_def`
--

LOCK TABLES `tag_group_def` WRITE;
/*!40000 ALTER TABLE `tag_group_def` DISABLE KEYS */;
INSERT INTO `tag_group_def` VALUES (1,'undefined',0,1),(2,'难度',1,1),(3,'分值',0,1),(9,'点的',0,0);
/*!40000 ALTER TABLE `tag_group_def` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-02 18:57:35
