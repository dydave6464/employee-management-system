-- MySQL dump 10.13  Distrib 9.2.0, for Win64 (x86_64)
--
-- Host: localhost    Database: winformproj
-- ------------------------------------------------------
-- Server version	9.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pkEmpID` varchar(255) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `contact_number` varchar(255) DEFAULT NULL,
  `salary` int DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL,
  `insert_date` date DEFAULT NULL,
  `update_date` date DEFAULT NULL,
  `delete_date` date DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `image` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`,`pkEmpID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'EID-01','Dave','Male','2323',20000,'Mobile Application Developer','2025-03-25',NULL,'2025-04-21','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EID-01.jpg'),(2,'EID-02','dave','Male','2323',20000,'Web Developer','2025-03-25',NULL,'2025-04-21','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EID-02.jpg'),(3,'EID-03','Dave','Male','2323',20000,'Web Developer','2025-03-25',NULL,'2025-04-21','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EID-03.jpg'),(4,'EID-04','Dave','Male','094366676612313131',20000,'Web Developer','2025-03-25',NULL,'2025-04-21','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EID-04.jpg'),(5,'EID-05','Mark','Others','093333444',50000,'Web Developer','2025-03-25','2025-04-21','2025-04-21','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EID-05.jpg'),(6,'EMID-01','Dave','Male','0943666666',200000,'Data Analyst','2025-04-21',NULL,'2025-04-22','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-01.jpg'),(7,'EMID-02','Ray','Female','029301312',20000,'Network Engineer','2025-04-22',NULL,NULL,'Inactive','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-02.jpg'),(8,'EMID-03','Mark','Female','029301312',20000,'Network Engineer','2025-04-22',NULL,'2025-04-22','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-03.jpg'),(9,'EMID-03','Ray','Female','029301312',20000,'Network Engineer','2025-04-22',NULL,'2025-04-22','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-03.jpg'),(10,'EMID-04','Rayawa','Female','029301312',20000,'DevOps Engineer','2025-04-22',NULL,'2025-04-22','Inactive','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-04.jpg'),(11,'EMID-05','Rayawas','Male','029301312',20000,'DevOps Engineer','2025-04-22',NULL,'2025-04-22','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-05.jpg'),(12,'EMID-06','Maria','Female','029301312',20000,'DevOps Engineer','2025-04-22','2025-04-22',NULL,'Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-06.jpg'),(13,'EMID-07','Rayawa','Female','029301312',20000,'DevOps Engineer','2025-04-22',NULL,'2025-04-22','Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-07.jpg'),(14,'EMID-08','Rayawa','Female','029301312',20000,'DevOps Engineer','2025-04-22',NULL,'2025-04-22','Inactive','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-08.jpg'),(15,'EMID-09','Rayawa','Female','029301312',20000,'DevOps Engineer','2025-04-22','2025-04-22',NULL,'Inactive','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-09.jpg'),(16,'EMID-10','Rayawa','Female','029301312',20000,'DevOps Engineer','2025-04-22',NULL,NULL,'Active','C:\\Users\\Debdeb\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Directory\\EMID-10.jpg');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `pkEmpID` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `date_register` date DEFAULT NULL,
  PRIMARY KEY (`pkEmpID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (4,'admin','admin123','2025-03-13'),(5,'dave','dave1','2025-03-25');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-23 12:47:55
