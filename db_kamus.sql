-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 26, 2018 at 04:14 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kamus`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_angka`
--

CREATE TABLE `tb_angka` (
  `indo` varchar(8) NOT NULL,
  `bali` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_angka`
--

INSERT INTO `tb_angka` (`indo`, `bali`) VALUES
('1', 'Besik'),
('10', 'Dasa'),
('100', 'Satus'),
('11', 'solas'),
('12', 'roras'),
('1200', 'nem bangsit'),
('1400', 'pitung bangsit'),
('150', 'karo belah'),
('1600', 'sepaa'),
('175', 'lebak'),
('18', 'plekutus'),
('1800', 'sia bangsit'),
('2', 'Kalih'),
('20', 'Duang dasa'),
('200', 'Satak'),
('21', 'selikur'),
('25', 'Selae'),
('3', 'Telu'),
('30', 'Telung Dasa'),
('35', 'pasasur'),
('4', 'Papat'),
('40', 'Petang Dasa'),
('400', 'samas'),
('45', 'setiman'),
('5', 'Lima'),
('50', 'Seket'),
('6', 'Nenem'),
('60', 'Nem Dasa'),
('7', 'Pitu'),
('70', 'Pitung Dasa'),
('75', 'telung benang'),
('8', 'Kutus'),
('80', 'Ulung Dasa'),
('800', 'domas'),
('9', 'Sia');

-- --------------------------------------------------------

--
-- Table structure for table `tb_kata`
--

CREATE TABLE `tb_kata` (
  `indonesia` varchar(20) NOT NULL,
  `baliandap` varchar(20) NOT NULL,
  `balisor` varchar(20) NOT NULL,
  `balisinggih` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_kata`
--

INSERT INTO `tb_kata` (`indonesia`, `baliandap`, `balisor`, `balisinggih`) VALUES
('bicara', 'munyi', 'atur', 'baos'),
('bodoh', 'belog', 'tambet', 'awidia'),
('dapur', 'paon', 'pawaregan', 'paratengan'),
('hidup', 'idup', 'urip', 'nyeneng'),
('kakek', 'pekak', 'kaki', 'kakiang'),
('lihat', 'iwas', 'kanten', 'cingak'),
('makan', 'medaar', 'nunas', 'mrayunan'),
('melihat', 'ningalin', 'ngantenang', 'nyingakin'),
('memberikan', 'ngamaang', 'ngwehin', 'ngicen'),
('meminta', 'ngidih', 'tunas', 'ngarsayang'),
('mendengar', 'ningeh', 'miragi', 'mireng'),
('meninggal', 'mati', 'padem', 'seda'),
('nama', 'adan', 'wasta', 'pasengen'),
('pikiran', 'keneh', 'manah', 'kayun'),
('sakit', 'gelem', 'sinengkaon', 'sungkan'),
('salah', 'pelih', 'sisip', 'iwang'),
('senang', 'suka', 'gargita', 'seneng'),
('sendiri', 'padidi', 'ndewek', 'praragan'),
('tempat tidur', 'pedeman', 'pesarean', 'pemereman'),
('tidur', 'pules', 'sirep', 'mekolem'),
('tinggal', 'ngoyong', 'magenah', 'meneng');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_angka`
--
ALTER TABLE `tb_angka`
  ADD PRIMARY KEY (`indo`);

--
-- Indexes for table `tb_kata`
--
ALTER TABLE `tb_kata`
  ADD PRIMARY KEY (`indonesia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
