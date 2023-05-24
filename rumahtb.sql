-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 02:25 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rumah`
--

-- --------------------------------------------------------

--
-- Table structure for table `rumahtb`
--

CREATE TABLE `rumahtb` (
  `Id_Rumah` varchar(25) NOT NULL,
  `Tipe_Rumah` int(5) NOT NULL,
  `Blok_Rumah` varchar(5) NOT NULL,
  `No.Rumah` int(5) NOT NULL,
  `Harga_Rumah` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rumahtb`
--

INSERT INTO `rumahtb` (`Id_Rumah`, `Tipe_Rumah`, `Blok_Rumah`, `No.Rumah`, `Harga_Rumah`) VALUES
('AN2', 48, 'A', 12, 1000000000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `rumahtb`
--
ALTER TABLE `rumahtb`
  ADD PRIMARY KEY (`Id_Rumah`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
