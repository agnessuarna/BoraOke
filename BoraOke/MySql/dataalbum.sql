-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 28, 2021 at 09:07 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dataalbum`
--

-- --------------------------------------------------------

--
-- Table structure for table `aespaalbum`
--

CREATE TABLE `aespaalbum` (
  `id_Album` int(11) NOT NULL,
  `Nama_Album` varchar(50) NOT NULL,
  `realease_Album` date NOT NULL,
  `track_list` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aespaalbum`
--

INSERT INTO `aespaalbum` (`id_Album`, `Nama_Album`, `realease_Album`, `track_list`) VALUES
(1, 'Black Mamba', '2020-11-17', 1),
(2, 'Hope', '2021-02-05', 1);

-- --------------------------------------------------------

--
-- Table structure for table `datamember`
--

CREATE TABLE `datamember` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Usia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datamember`
--

INSERT INTO `datamember` (`ID`, `Nama`, `Usia`) VALUES
(15, 'baekhyun', 23);

-- --------------------------------------------------------

--
-- Table structure for table `exoalbum`
--

CREATE TABLE `exoalbum` (
  `id_Album` int(11) NOT NULL,
  `Nama_Album` varchar(50) NOT NULL,
  `realease_Album` date NOT NULL,
  `track_list` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `exoalbum`
--

INSERT INTO `exoalbum` (`id_Album`, `Nama_Album`, `realease_Album`, `track_list`) VALUES
(1, 'XOXO', '2013-06-11', 14),
(2, 'OBSESSION', '2019-11-29', 10),
(3, 'EXODUS', '2015-03-30', 10),
(4, 'EX\'ACT', '2016-08-18', 11),
(5, 'THE WAR', '2017-07-18', 9);

-- --------------------------------------------------------

--
-- Table structure for table `nct127album`
--

CREATE TABLE `nct127album` (
  `id_Album` int(11) NOT NULL,
  `Nama_Album` varchar(50) NOT NULL,
  `realease_Album` datetime NOT NULL,
  `track_list` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nct127album`
--

INSERT INTO `nct127album` (`id_Album`, `Nama_Album`, `realease_Album`, `track_list`) VALUES
(1, 'NEOZONE', '2020-03-06 18:04:18', 13),
(2, 'We Are Superhuman', '2019-05-24 16:00:00', 6),
(3, 'Regulate', '2018-11-24 16:00:00', 14);

-- --------------------------------------------------------

--
-- Table structure for table `nctdreamalbum`
--

CREATE TABLE `nctdreamalbum` (
  `id_Album` int(11) NOT NULL,
  `Nama_Album` varchar(50) NOT NULL,
  `realease_Album` datetime NOT NULL,
  `track_list` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nctdreamalbum`
--

INSERT INTO `nctdreamalbum` (`id_Album`, `Nama_Album`, `realease_Album`, `track_list`) VALUES
(1, 'We BOOM', '2019-07-16 16:00:00', 6),
(2, 'Reload', '2020-04-29 16:00:00', 5);

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `id` int(11) NOT NULL,
  `tanggal_peminjaman` date NOT NULL,
  `lama_peminjaman` date NOT NULL,
  `nama_peminjam` varchar(50) NOT NULL,
  `album_peminjam` varchar(50) NOT NULL,
  `tanggal_pengembalian` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `peminjaman`
--

INSERT INTO `peminjaman` (`id`, `tanggal_peminjaman`, `lama_peminjaman`, `nama_peminjam`, `album_peminjam`, `tanggal_pengembalian`) VALUES
(1, '0001-01-01', '0000-00-00', '', '', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `redvelvetalbum`
--

CREATE TABLE `redvelvetalbum` (
  `id_Album` int(11) NOT NULL,
  `Nama_Album` varchar(50) NOT NULL,
  `realease_Album` date NOT NULL,
  `track_list` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `redvelvetalbum`
--

INSERT INTO `redvelvetalbum` (`id_Album`, `Nama_Album`, `realease_Album`, `track_list`) VALUES
(1, 'Ice Cream Cake', '2015-09-09', 6),
(2, 'Russian Roulette', '2016-09-07', 7),
(3, 'The ReVe Festival Finale', '2019-12-23', 16);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aespaalbum`
--
ALTER TABLE `aespaalbum`
  ADD PRIMARY KEY (`id_Album`);

--
-- Indexes for table `datamember`
--
ALTER TABLE `datamember`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `exoalbum`
--
ALTER TABLE `exoalbum`
  ADD PRIMARY KEY (`id_Album`);

--
-- Indexes for table `nct127album`
--
ALTER TABLE `nct127album`
  ADD PRIMARY KEY (`id_Album`);

--
-- Indexes for table `nctdreamalbum`
--
ALTER TABLE `nctdreamalbum`
  ADD PRIMARY KEY (`id_Album`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `redvelvetalbum`
--
ALTER TABLE `redvelvetalbum`
  ADD PRIMARY KEY (`id_Album`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `peminjaman`
--
ALTER TABLE `peminjaman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
