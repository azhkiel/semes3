-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Dec 13, 2024 at 08:58 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mi`
--

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `nama_Menu` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `kategori` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `harga` decimal(10,2) NOT NULL,
  `stok` int NOT NULL,
  `deskripsi` text COLLATE utf8mb4_general_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`nama_Menu`, `kategori`, `harga`, `stok`, `deskripsi`) VALUES
('Es Coklat', 'Minuman', '12000.00', 111, 'Es coklat manis dengan es serut yang segar.'),
('Es Teh', 'Minuman', '8000.00', 174, 'Es teh manis segar dengan es batu.'),
('Jeruk', 'Minuman', '10000.00', 156, 'Jus jeruk segar yang menyegarkan.'),
('mi', 'Makanan', '15000.00', 1, NULL),
('Mi Ayam', 'Makanan', '15000.00', 81, 'Mi ayam dengan potongan ayam dan sayuran segar.'),
('Mi Ayam Jumbo', 'Makanan', '20000.00', 8, 'Mi ayam dengan porsi jumbo dan ekstra ayam.'),
('Mi Ayam Jumbo Spesial', 'Makanan', '22000.00', 6, 'Mi ayam jumbo dengan tambahan topping spesial dan ekstra ayam.'),
('Mi Ayam Spesial', 'Makanan', '18000.00', 40, 'Mi ayam dengan tambahan topping spesial seperti pangsit dan bakso.'),
('Ramen', 'Makanan', '25000.00', 36, 'Ramen khas Jepang dengan kuah gurih dan daging babi panggang.');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `id` int NOT NULL,
  `username` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `nama_Menu` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `kategori` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `jumlah` int NOT NULL,
  `harga_total` decimal(10,2) NOT NULL,
  `waktu` datetime NOT NULL,
  `no_antrian` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`id`, `username`, `nama_Menu`, `kategori`, `jumlah`, `harga_total`, `waktu`, `no_antrian`) VALUES
(71, 'el', 'Es Coklat', 'Minuman', 2, '24000.00', '2024-12-11 17:21:12', 'antrian00001'),
(72, 'el', 'Es Teh', 'Minuman', 3, '24000.00', '2024-12-11 17:21:12', 'antrian00002'),
(73, 'el', 'Es Coklat', 'Minuman', 2, '24000.00', '2024-12-11 17:44:11', 'antrian00003'),
(74, 'el', 'Es Teh', 'Minuman', 2, '16000.00', '2024-12-11 17:44:11', 'antrian00004'),
(75, 'el', 'Jeruk', 'Minuman', 2, '20000.00', '2024-12-11 17:44:11', 'antrian00005'),
(76, 'el', 'Mi Ayam Jumbo Spesial', 'Makanan', 1, '22000.00', '2024-12-11 17:46:10', 'antrian00006'),
(77, 'el', 'Mi Ayam Jumbo', 'Makanan', 1, '20000.00', '2024-12-11 17:46:10', 'antrian00007'),
(78, 'el', 'Mi Ayam', 'Makanan', 1, '15000.00', '2024-12-11 17:46:10', 'antrian00008'),
(79, 'el', 'Es Coklat', 'Minuman', 1, '12000.00', '2024-12-11 17:51:07', 'antrian00009'),
(80, 'el', 'Es Teh', 'Minuman', 2, '16000.00', '2024-12-11 17:51:07', 'antrian00009'),
(81, 'el', 'Jeruk', 'Minuman', 2, '20000.00', '2024-12-11 17:51:07', 'antrian00009'),
(82, 'el', 'Es Teh', 'Minuman', 2, '16000.00', '2024-12-11 17:52:52', 'antrian00010'),
(83, 'el', 'Jeruk', 'Minuman', 2, '20000.00', '2024-12-11 17:52:52', 'antrian00010'),
(84, 'el', 'Mi Ayam Jumbo', 'Makanan', 2, '40000.00', '2024-12-11 17:54:08', 'antrian00011'),
(85, 'el', 'Mi Ayam Jumbo Spesial', 'Makanan', 2, '44000.00', '2024-12-11 17:54:08', 'antrian00012'),
(86, 'el', 'Mi Ayam Jumbo', 'Makanan', 2, '40000.00', '2024-12-11 17:58:23', 'antrian00013'),
(87, 'el', 'Mi Ayam', 'Makanan', 2, '30000.00', '2024-12-11 17:58:23', 'antrian00013'),
(88, 'el', 'Es Coklat', 'Minuman', 2, '24000.00', '2024-12-11 17:58:23', 'antrian00013'),
(89, 'el', 'Mi Ayam Jumbo Spesial', 'Makanan', 2, '44000.00', '2024-12-11 17:59:19', 'antrian00013'),
(90, 'el', 'Mi Ayam', 'Makanan', 2, '30000.00', '2024-12-11 17:59:19', 'antrian00013'),
(91, 'el', 'Es Teh', 'Minuman', 2, '16000.00', '2024-12-11 18:10:51', 'antrian00014'),
(92, 'el', 'Mi Ayam', 'Makanan', 2, '30000.00', '2024-12-11 18:10:51', 'antrian00014'),
(93, 'el', 'Es Coklat', 'Minuman', 2, '24000.00', '2024-12-11 18:12:49', 'antrian00015'),
(94, 'el', 'Jeruk', 'Minuman', 2, '20000.00', '2024-12-11 18:12:49', 'antrian00015'),
(95, 'el', 'Mi Ayam', 'Makanan', 2, '30000.00', '2024-12-11 18:14:57', 'antrian00016'),
(96, 'el', 'Es Coklat', 'Minuman', 2, '24000.00', '2024-12-11 18:14:57', 'antrian00016'),
(97, 'el', 'Jeruk', 'Minuman', 2, '20000.00', '2024-12-11 22:26:01', 'antrian00017'),
(98, 'el', 'Mi Ayam Jumbo', 'Makanan', 2, '40000.00', '2024-12-11 22:26:01', 'antrian00017'),
(99, 'fina', 'Es Coklat', 'Minuman', 1, '12000.00', '2024-12-13 15:18:38', 'antrian00018'),
(100, 'fina', 'Mi Ayam', 'Makanan', 1, '15000.00', '2024-12-13 15:18:38', 'antrian00018'),
(101, 'fina', 'Mi Ayam Jumbo', 'Makanan', 2, '100000.00', '2024-12-13 15:18:38', 'antrian00018');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `notel` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `role` enum('owner','admin','customer') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `notel`, `role`) VALUES
('admin', '12345', '012345678901', 'admin'),
('al', '12345', '081234567891', 'customer'),
('el', '12345', '081234567894', 'customer'),
('ex', '12345', '0', 'owner'),
('fina', '1', '1234567890112', 'customer'),
('il', '12345', '081234567892', 'customer'),
('ol', '12345', '081234567895', 'customer'),
('owner', '12345', '0', 'owner'),
('ul', '12345', '081234567893', 'customer');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`nama_Menu`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_order_user` (`username`),
  ADD KEY `fk_order_menu` (`nama_Menu`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `fk_order_menu` FOREIGN KEY (`nama_Menu`) REFERENCES `menu` (`nama_Menu`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_order_user` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
