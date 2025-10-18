-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 06, 2022 at 11:59 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `id` int(11) NOT NULL,
  `name` varchar(10) NOT NULL,
  `stream` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `information`
--

CREATE TABLE `information` (
  `id` int(11) NOT NULL,
  `info` longtext NOT NULL,
  `date` date NOT NULL,
  `Author` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `results`
--

CREATE TABLE `results` (
  `id` int(11) NOT NULL,
  `english` int(11) NOT NULL,
  `kiswahili` int(11) NOT NULL,
  `maths` int(11) NOT NULL,
  `geography` int(11) NOT NULL,
  `history` int(11) NOT NULL,
  `cre` int(11) NOT NULL,
  `business` int(11) NOT NULL,
  `computer` int(11) NOT NULL,
  `agriculture` int(11) NOT NULL,
  `music` int(11) NOT NULL,
  `chemistry` int(11) NOT NULL,
  `physics` int(11) NOT NULL,
  `biology` int(11) NOT NULL,
  `regNo` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `subjects` int(11) NOT NULL,
  `average` int(11) NOT NULL,
  `grade` int(11) NOT NULL,
  `deviation` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `stream`
--

CREATE TABLE `stream` (
  `name` varchar(10) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `dob` date NOT NULL,
  `handicapped` tinyint(1) NOT NULL,
  `insession` tinyint(1) NOT NULL,
  `class` varchar(10) NOT NULL,
  `stream` varchar(10) NOT NULL,
  `subjects` enum('english','maths','kiswahili','geography','history','cre','business','chemistry','physics','biology','music','computer','agriculture') NOT NULL,
  `allergies` enum('bees') NOT NULL,
  `regNo` int(11) NOT NULL,
  `guardian` varchar(50) NOT NULL,
  `guardianphone` bigint(20) NOT NULL,
  `guardianemail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id` int(11) NOT NULL,
  `subject` varchar(30) NOT NULL,
  `core` tinyint(1) NOT NULL,
  `A` int(11) NOT NULL,
  `A-` int(11) NOT NULL,
  `B+` int(11) NOT NULL,
  `B` int(11) NOT NULL,
  `B-` int(11) NOT NULL,
  `C+` int(11) NOT NULL,
  `C` int(11) NOT NULL,
  `C-` int(11) NOT NULL,
  `D+` int(11) NOT NULL,
  `D` int(11) NOT NULL,
  `D-` int(11) NOT NULL,
  `E` int(11) NOT NULL,
  `F` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `class` varchar(10) NOT NULL,
  `fees` int(11) NOT NULL,
  `regNo` varchar(10) NOT NULL,
  `paid` int(11) NOT NULL,
  `extracharge` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `role` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` bigint(20) NOT NULL,
  `password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstname`, `lastname`, `role`, `email`, `phone`, `password`) VALUES
(1, 'duncan', 'ndegwa', 'admin', 'whizydan@gmail.com', 799725502, 'meltdown6057');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `information`
--
ALTER TABLE `information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `results`
--
ALTER TABLE `results`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stream`
--
ALTER TABLE `stream`
  ADD PRIMARY KEY (`regNo`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `information`
--
ALTER TABLE `information`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `results`
--
ALTER TABLE `results`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `stream`
--
ALTER TABLE `stream`
  MODIFY `regNo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
