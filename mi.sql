-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Dec 15, 2024 at 04:55 AM
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
('Es Campur', 'Minuman', '20000.00', 99, 'Es campur dengan berbagai isian buah segar dan sirup'),
('Es Jeruk', 'Minuman', '8000.00', 99, 'Minuman jeruk dingin dengan es batu segar'),
('Es Teh', 'Minuman', '6000.00', 99, 'Teh dingin dengan es batu segar'),
('Ice Cream', 'Minuman', '12000.00', 99, 'Es krim lembut dengan berbagai rasa pilihan'),
('Jeruk', 'Minuman', '7000.00', 99, 'Minuman jeruk hangat dengan rasa segar'),
('Jus Alpukat', 'Minuman', '15000.00', 99, 'Jus alpukat dengan tambahan susu dan gula'),
('Jus Jambu', 'Minuman', '14000.00', 99, 'Jus jambu merah segar tanpa tambahan gula'),
('Mie Ayam', 'Makanan', '17000.00', 99, 'Mie ayam dengan saus kecap dan daging ayam lembut'),
('Mie Ayam Spesial', 'Makanan', '22000.00', 99, 'Mie ayam dengan tambahan pangsit dan bakso'),
('Mie Bakso', 'Makanan', '18000.00', 100, 'Mie dengan kuah gurih dan bakso sapi'),
('Mie Bakso Spesial', 'Makanan', '22000.00', 100, 'Mie bakso dengan tambahan telur dan pangsit'),
('Mie Goreng', 'Makanan', '15000.00', 100, 'Mie goreng dengan bumbu khas dan sayuran segar'),
('Mie Goreng Spesial', 'Makanan', '20000.00', 100, 'Mie goreng dengan tambahan telur dan ayam'),
('Ramen Ayam', 'Makanan', '30000.00', 100, 'Ramen khas Jepang dengan kuah kaldu ayam'),
('Ramen Babi', 'Makanan', '35000.00', 99, 'Ramen khas Jepang dengan kuah kaldu babi'),
('Teh', 'Minuman', '5000.00', 99, 'Teh hangat yang menyegarkan');

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
  `no_antrian` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `who` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`id`, `username`, `nama_Menu`, `kategori`, `jumlah`, `harga_total`, `waktu`, `no_antrian`, `who`) VALUES
(124, 'admin', 'Es Campur', 'Minuman', 1, '20000.00', '2024-12-15 11:08:46', 'antrian00001', ''),
(125, 'admin', 'Es Jeruk', 'Minuman', 1, '8000.00', '2024-12-15 11:09:49', 'antrian00002', ''),
(126, 'admin', 'Es Teh', 'Minuman', 1, '6000.00', '2024-12-15 11:13:16', 'antrian00003', 'ica'),
(127, 'admin', 'Ice Cream', 'Minuman', 1, '12000.00', '2024-12-15 11:14:10', 'antrian00004', 'dea'),
(128, 'admin', 'Jeruk', 'Minuman', 1, '7000.00', '2024-12-15 11:14:10', 'antrian00004', 'dea'),
(129, 'admin', 'Jus Alpukat', 'Minuman', 1, '15000.00', '2024-12-15 11:14:10', 'antrian00004', 'dea'),
(130, 'el', 'Jus Jambu', 'Minuman', 1, '14000.00', '2024-12-15 11:25:30', 'antrian00005', NULL),
(131, 'el', 'Mie Ayam', 'Makanan', 1, '17000.00', '2024-12-15 11:25:30', 'antrian00005', NULL),
(132, 'el', 'Mie Ayam Spesial', 'Makanan', 1, '22000.00', '2024-12-15 11:25:30', 'antrian00005', NULL),
(133, 'admin', 'Teh', 'Minuman', 1, '5000.00', '2024-12-15 11:40:33', 'antrian00006', 'fio'),
(134, 'admin', 'Ramen Babi', 'Makanan', 1, '35000.00', '2024-12-15 11:40:33', 'antrian00006', 'fio');

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
('admin-ely', '123456', '123456789010', 'owner'),
('al', '12345', '081234567891', 'customer'),
('dea', '0987', '123456789011', 'customer'),
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
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=135;

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
