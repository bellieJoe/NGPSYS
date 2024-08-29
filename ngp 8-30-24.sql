-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 29, 2024 at 03:19 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ngp`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `user_id` int(11) NOT NULL,
  `account_type` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email_address` varchar(100) DEFAULT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(100) DEFAULT NULL,
  `middlename` varchar(100) DEFAULT NULL,
  `lastname` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `phone_num` varchar(100) DEFAULT NULL,
  `gender` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`user_id`, `account_type`, `username`, `email_address`, `password`, `firstname`, `middlename`, `lastname`, `address`, `phone_num`, `gender`) VALUES
(1, 'ADMIN', 'admin', 'ran12@gmail.com', '1234', 'Ranny', 'Maac', 'Natividad', 'Tagwak, Boac, Marinduque', '09777633512', 'Male'),
(3, 'ORDINARY USER', 'rakitzogi', 'ranzee09@gmail.com', '1209', 'Ranny', 'Macayaon', 'Natividad', 'Libtangin, Gasan, Marinduque', '0', 'Male'),
(11, 'Ordinary User', '4uSfHfWw', NULL, '8POH6HB**CS)', NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `activities_tbl`
--

CREATE TABLE `activities_tbl` (
  `activities_id` int(11) NOT NULL,
  `activities_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `activities_tbl`
--

INSERT INTO `activities_tbl` (`activities_id`, `activities_name`) VALUES
(1, 'Plantita'),
(2, 'transport'),
(3, 'Akyat gang');

-- --------------------------------------------------------

--
-- Table structure for table `amap_doc_tbl`
--

CREATE TABLE `amap_doc_tbl` (
  `amap_doc_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `url` varchar(500) NOT NULL,
  `unique_code` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `commodity_tbl`
--

CREATE TABLE `commodity_tbl` (
  `commodity_id` int(11) NOT NULL,
  `commodity_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `commodity_tbl`
--

INSERT INTO `commodity_tbl` (`commodity_id`, `commodity_name`) VALUES
(1, 'Bamboo'),
(2, 'Beach'),
(3, 'Fruit Trees'),
(4, 'Timber'),
(5, 'Indigenous Trees'),
(7, 'Mangrove'),
(8, 'High Value Crops'),
(9, 'Hedgerow'),
(10, 'NTFP');

-- --------------------------------------------------------

--
-- Table structure for table `commodity_unitcost_tbl`
--

CREATE TABLE `commodity_unitcost_tbl` (
  `commodity_unitcost_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `commodity_name` varchar(100) DEFAULT NULL,
  `seedlingcount` int(11) DEFAULT NULL,
  `unit_cost` int(11) DEFAULT NULL,
  `total_cost_seeds` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `commodity_unitcost_tbl`
--

INSERT INTO `commodity_unitcost_tbl` (`commodity_unitcost_id`, `unique_code`, `commodity_name`, `seedlingcount`, `unit_cost`, `total_cost_seeds`) VALUES
(1, '22-174000-0001-0012', 'Fruit Trees', 6000, 35, 210000),
(7, 'k9DOBQus4B', 'Indigenous Trees', 8125, NULL, NULL),
(8, 'k9DOBQus4B', 'Fruit Trees', 3500, NULL, NULL),
(9, '11-174001-0001-0034', 'Timber', 17000, 12, 207910),
(10, 'lggYyoQaHn', 'Timber', 500, NULL, NULL),
(11, '11-174001-0034-0003', 'Timber', 500, NULL, NULL),
(12, '11-174001-0002-0008', 'Timber', 4000, NULL, NULL),
(13, '11-174001-0003-0002', 'Fruit Trees', 1000, NULL, NULL),
(14, '11-174001-0004-0012', 'Timber', 6000, NULL, NULL),
(15, '11-174001-0005-0007', 'Timber', 3500, NULL, NULL),
(16, '11-174001-0006-0003', 'Timber', 1500, NULL, NULL),
(17, '11-174001-0008-0002', 'Timber', 500, NULL, NULL),
(18, '11-174001-0008-0002', 'Timber', 1000, NULL, NULL),
(19, '11-174001-0007-0001', 'Timber', 500, NULL, NULL),
(20, '11-174001-0008-0002', 'Timber', 1000, NULL, NULL),
(25, '22-174000-0003-0032', 'Indigenous Trees', 15000, 12, 180000),
(26, '22-174000-0003-0032', 'Fruit Trees', 4000, 35, 140000),
(27, '22-174000-0004-0020', 'Indigenous Trees', 8125, 12, 97500),
(28, '22-174000-0004-0020', 'Fruit Trees', 3500, 35, 122500),
(31, '22-174000-0002-0011', 'Fruit Trees', 5500, 35, 192500),
(32, '22-174000-0005-0024', 'Indigenous Trees', 8125, NULL, NULL),
(33, '22-174000-0005-0024', 'Fruit Trees', 6000, NULL, NULL),
(37, '21-174000-0001-0020/ 21-174000-0002-0050', 'Indigenous Trees', 22125, 12, 265500),
(38, '21-174000-0001-0020/ 21-174000-0002-0050', 'Fruit Trees', 17500, 35, 612500),
(40, '11-174001-0011-0030', 'Timber', 15000, NULL, NULL),
(41, '11-174001-0012-0003', 'Timber', 1500, NULL, NULL),
(42, '11-174001-0013-0003', 'Timber', 1500, NULL, NULL),
(43, '11-174001-0014-0004', 'Timber', 2000, NULL, NULL),
(44, '11-174001-0018-0003', 'Timber', 1500, NULL, NULL),
(45, '11-174001-0020-0010', 'Timber', 5000, NULL, NULL),
(46, '11-174001-0024-0003', 'Timber', 1500, NULL, NULL),
(47, '11-174001-0025-0003', 'Timber', 1500, NULL, NULL),
(48, '11-174001-0026-0004', 'Timber', 2000, NULL, NULL),
(49, '11-174001-0027-0003', 'Timber', 1500, NULL, NULL),
(50, '11-174001-0028-0003', 'Timber', 1500, NULL, NULL),
(51, '11-174001-0029-0003', 'Timber', 1500, NULL, NULL),
(52, '11-174001-0030-0003', 'Timber', 1500, NULL, NULL),
(53, '11-174001-0031-0003', 'Timber', 1500, NULL, NULL),
(54, '11-174001-0032-0005', 'Timber', 2500, NULL, NULL),
(55, '11-174001-0034-0003', 'Timber', 1500, NULL, NULL),
(56, '11-174001-0034-0003', 'Timber', 1500, NULL, NULL),
(57, '11-174001-0035-0003', 'Timber', 1500, NULL, NULL),
(58, '11-174001-0036-0002', 'Timber', 1500, NULL, NULL),
(59, '11-174001-0037-0003', 'Timber', 1500, NULL, NULL),
(60, '11-174001-0038-0003', 'Timber', 1500, NULL, NULL),
(61, '11-174001-0039-0003', 'Timber', 2000, NULL, NULL),
(62, '11-174001-0040-0002', 'Timber', 1500, NULL, NULL),
(63, '11-174001-0041-0003', 'Timber', 1500, NULL, NULL),
(64, '11-174001-0042-0003', 'Timber', 1500, NULL, NULL),
(65, '11-174001-0043-0003', 'Timber', 1500, NULL, NULL),
(66, '11-174001-0044-0003', 'Timber', 1500, NULL, NULL),
(67, '12-174001-0001-0014', 'Timber', 7000, NULL, NULL),
(68, '12-174001-0012-0050', 'Timber', 25000, NULL, NULL),
(69, '12-174001-0020-0045', 'Timber', 22500, NULL, NULL),
(70, '12-174001-0021-0027', 'Timber', 13500, NULL, NULL),
(71, '12-174001-0025-0011', 'Timber', 5500, NULL, NULL),
(72, '12-174001-0026-0031', 'Timber', 15500, NULL, NULL),
(73, '12-174001-0028-0011', 'Mangrove', 25000, NULL, NULL),
(74, '12-174001-0029-0020', 'Timber', 10000, NULL, NULL),
(75, '12-174001-0030-0003', 'Timber', 1500, NULL, NULL),
(76, '12-174001-0031-0003', 'Bamboo', 1500, NULL, NULL),
(77, '12-174001-0032-0005', 'Bamboo', 2500, NULL, NULL),
(78, '12-174001-0033-0004', 'Bamboo', 2000, NULL, NULL),
(79, '12-174001-0034-0006', 'Timber', 3500, NULL, NULL),
(80, '12-174001-0036-0005', 'Timber', 2500, NULL, NULL),
(81, '12-174001-0036-0005', 'Timber', 2500, NULL, NULL),
(82, '12-174001-0039-0005', 'Timber', 2500, NULL, NULL),
(83, '12-174001-0040-0007', 'Timber', 3000, NULL, NULL),
(84, '12-174001-0041-0007', 'Timber', 3500, NULL, NULL),
(85, '12-174001-0042-0001', 'Bamboo', 500, NULL, NULL),
(86, '12-174001-0043-0003', 'Timber', 1500, NULL, NULL),
(87, '12-174001-0044-0005', 'Timber', 2500, NULL, NULL),
(88, '12-174001-0045-0002', 'Timber', 1000, NULL, NULL),
(89, '12-174001-0046-0002', 'Timber', 1000, NULL, NULL),
(90, '12-174001-0047-0005', 'Timber', 3500, NULL, NULL),
(91, '12-174001-0038-0001', 'Bamboo', 120, NULL, NULL),
(92, '13-174001-0001-0001', 'Timber', 500, NULL, NULL),
(93, '13-174001-0002-0001', 'Timber', 500, NULL, NULL),
(94, '13-174001-0003-0005', 'Timber', 2500, NULL, NULL),
(95, '13-174001-0004-0014', 'Timber', 7000, NULL, NULL),
(96, '13-174001-0005-0004', 'Timber', 2000, NULL, NULL),
(97, '13-174001-0006-0043', 'Mangrove', 60000, NULL, NULL),
(98, '13-174001-0007-0002', 'Timber', 4000, NULL, NULL),
(99, 'i9FGnaZm0u', 'Fruit Trees', 6000, NULL, NULL),
(100, '13-174001-0008-0006', 'Timber', 3000, NULL, NULL),
(101, '13-174001-0009-0006', 'Timber', 3000, NULL, NULL),
(102, '13-174001-0010-0005', 'Timber', 2500, NULL, NULL),
(103, '13-174001-0011-0004', 'Timber', 2000, NULL, NULL),
(104, '13-174001-0012-0005', 'Timber', 2500, NULL, NULL),
(105, '13-174001-0013-0009', 'Timber', 4500, NULL, NULL),
(106, '13-174001-0014-0027', 'Fruit Trees', 13500, NULL, NULL),
(107, '13-174001-0015-0015', 'Timber', 7500, NULL, NULL),
(108, '13-174001-0016-0018', 'Timber', 9000, NULL, NULL),
(109, '13-174001-0017-0010', 'Timber', 5000, NULL, NULL),
(110, '11-174001-0033-0001', 'Timber', 1500, NULL, NULL),
(111, '11-174001-0034-0003', 'Timber', 1500, NULL, NULL),
(114, '11-174001-0021-0012', 'Timber', 11500, NULL, NULL),
(115, '11-174001-0022-0005', 'Timber', 0, NULL, NULL),
(116, '11-174001-0023-0006', 'Timber', 3000, NULL, NULL),
(117, '12-174001-0002-0001', 'High Value Crops', 16500, NULL, NULL),
(118, '12-174001-0003-0007', 'High Value Crops', 0, NULL, NULL),
(119, '12-174001-0004-0003', 'High Value Crops', 0, NULL, NULL),
(120, '12-174001-0005-0002', 'High Value Crops', 0, NULL, NULL),
(121, '12-174001-0006-0001', 'High Value Crops', 0, NULL, NULL),
(122, '12-174001-0007-0004', 'High Value Crops', 0, NULL, NULL),
(123, '12-174001-0008-0000', 'High Value Crops', 0, NULL, NULL),
(124, '12-174001-0009-0001', 'High Value Crops', 0, NULL, NULL),
(125, '12-174001-0010-0000', 'High Value Crops', 0, NULL, NULL),
(126, '12-174001-0011-0001', 'Timber', 0, NULL, NULL),
(127, '12-174001-0013-0001', 'High Value Crops', 0, NULL, NULL),
(128, '12-174001-0014-0001', 'High Value Crops', 0, NULL, NULL),
(129, '12-174001-0015-0002', 'High Value Crops', 0, NULL, NULL),
(130, '12-174001-0016-0001', 'High Value Crops', 0, NULL, NULL),
(131, '12-174001-0017-0001', 'High Value Crops', 0, NULL, NULL),
(132, '12-174001-0018-0001', 'High Value Crops', 0, NULL, NULL),
(133, '12-174001-0019-0000', 'Timber', 0, NULL, NULL),
(134, '12-174001-0022-0004', 'High Value Crops', 0, NULL, NULL),
(135, '12-174001-0023-0001', 'High Value Crops', 0, NULL, NULL),
(136, '12-174001-0024-0000', 'High Value Crops', 0, NULL, NULL),
(137, '12-174001-0027-0001', 'High Value Crops', 0, NULL, NULL),
(138, '12-174001-0027-0001', 'High Value Crops', 0, NULL, NULL),
(139, '12-174001-0027-0001', 'High Value Crops', 0, NULL, NULL),
(140, '12-174001-0036-0005', 'Timber', 2500, NULL, NULL),
(141, '12-174001-0048-0002', 'Timber', 3500, NULL, NULL),
(142, '13-174001-0015-0015', 'Timber', 7500, NULL, NULL),
(143, '12-174001-0037-0003', 'Timber', 1500, NULL, NULL),
(144, '13-174001-0018-0058', 'Timber', 29000, NULL, NULL),
(145, '13-174001-0019-0029', 'High Value Crops', 14500, NULL, NULL),
(146, '13-174001-0019-0029', 'High Value Crops', 14500, NULL, NULL),
(147, '13-174001-0020-0034', 'Timber', 17000, NULL, NULL),
(148, '13-174001-0021-0005', 'Timber', 2500, NULL, NULL),
(149, '13-174001-0026-0038', 'Timber', 19000, NULL, NULL),
(150, '13-174001-0027-0030', 'Timber', 15000, NULL, NULL),
(151, '13-174001-0024-0024', 'Timber', 12000, NULL, NULL),
(152, '13-174001-0035-0031', 'High Value Crops', 15500, NULL, NULL),
(153, '13-174001-0038-0006', 'High Value Crops', 20000, NULL, NULL),
(154, '13-174001-0039-0004', 'High Value Crops', 0, NULL, NULL),
(155, '13-174001-0040-0005', 'High Value Crops', 0, NULL, NULL),
(156, '13-174001-0041-0031', 'High Value Crops', 0, NULL, NULL),
(157, '13-174001-0042-0044', 'Timber', 22000, NULL, NULL),
(158, '13-174001-0042-0044', 'Timber', 22000, NULL, NULL),
(159, '13-174001-0031-0022', 'Timber', 11000, NULL, NULL),
(160, '13-174001-0046-0009', 'High Value Crops', 6000, NULL, NULL),
(161, '13-174001-0048-0005', 'Timber', 5000, NULL, NULL),
(162, '13-174001-0049-0002', 'Timber', 0, NULL, NULL),
(163, '13-174001-0050-0005', 'Timber', 0, NULL, NULL),
(164, '13-174001-0052-0013', 'Timber', 3500, NULL, NULL),
(165, '13-174001-0055-0091', 'High Value Crops', 45500, NULL, NULL),
(166, '13-174001-0056-0033', 'Timber', 16500, NULL, NULL),
(167, '13-174001-0045-0028', 'Timber', 56000, NULL, NULL),
(168, '13-174001-0032-0015', 'Timber', 30000, NULL, NULL),
(169, '13-174001-0023-0008', 'Timber', 4000, NULL, NULL),
(170, '13-174001-0036-0005', 'Timber', 2500, NULL, NULL),
(171, '13-174001-0030-0040', 'Timber', 20000, NULL, NULL),
(172, '13-174001-0051-0003', 'Timber', 1500, NULL, NULL),
(173, '13-174001-0053-0007', 'Timber', 3000, NULL, NULL),
(174, '13-174001-0022-0007', 'Timber', 3500, NULL, NULL),
(175, '13-174001-0028-0001', 'Timber', 1000, NULL, NULL),
(176, '13-174001-0054-0003', 'Timber', 1000, NULL, NULL),
(177, '13-174001-0033-0003', 'Timber', 900, NULL, NULL),
(178, '13-174001-0034-0004', 'Timber', 1500, NULL, NULL),
(179, '15-174001-0001-0005', 'Timber', 20000, NULL, NULL),
(180, '15-174001-0002-0004', 'Timber', 0, NULL, NULL),
(181, '15-174001-0003-0003', 'Timber', 37500, NULL, NULL),
(182, '15-174001-0003-0003', 'Timber', 37500, NULL, NULL),
(183, '15-174001-0004-0004', 'Timber', 0, NULL, NULL),
(184, '15-174001-0005-0008', 'Timber', 0, NULL, NULL),
(185, '15-174001-0007-0020', 'Timber', 50000, NULL, NULL),
(186, '15-174001-0010-0010', 'Timber', 27500, NULL, NULL),
(188, '15-174001-0012-0004', 'Timber', 10000, NULL, NULL),
(189, '15-174001-0019-0002', 'Timber', 5000, NULL, NULL),
(190, '15-174001-0013-0008', 'Timber', 127500, NULL, NULL),
(191, '15-174001-0014-0008', 'Timber', 0, NULL, NULL),
(192, '15-174001-0015-0015', 'Timber', 0, NULL, NULL),
(193, '15-174001-0016-0021', 'Timber', 0, NULL, NULL),
(194, '15-174001-0024-0004', 'Timber', 10000, NULL, NULL),
(195, '15-174001-0017-0007', 'Timber', 17500, NULL, NULL),
(196, '15-174001-0018-0005', 'Timber', 12500, NULL, NULL),
(197, '15-174001-0020-0004', 'Timber', 17500, NULL, NULL),
(198, '15-174001-0021-0003', 'Timber', 0, NULL, NULL),
(199, '15-174001-0022-0021', 'Timber', 65000, NULL, NULL),
(200, '15-174001-0023-0005', 'Timber', 0, NULL, NULL),
(201, '15-174001-0025-0040', 'Timber', 100000, NULL, NULL),
(202, '15-174001-0027-0015', 'Timber', 37500, NULL, NULL),
(203, '15-174001-0028-0002', 'Timber', 30000, NULL, NULL),
(204, '15-174001-0029-0010', 'Timber', 0, NULL, NULL),
(205, '15-174001-0030-0005', 'Timber', 50000, NULL, NULL),
(206, '15-174001-0031-0005', 'Timber', 0, NULL, NULL),
(207, '15-174001-0032-0002', 'Timber', 0, NULL, NULL),
(208, '15-174001-0033-0005', 'Timber', 0, NULL, NULL),
(209, '15-174001-0036-0002', 'Timber', 0, NULL, NULL),
(210, '15-174001-0034-0010', 'Timber', 70000, NULL, NULL),
(211, '15-174001-0035-0018', 'Timber', 0, NULL, NULL),
(212, '15-174001-0037-0002', 'Timber', 5000, NULL, NULL),
(213, '15-174001-0038-0012', 'Timber', 30000, NULL, NULL),
(215, '15-174001-0033-0001', 'Timber', 2500, NULL, NULL),
(216, '15-174001-0034-0002', 'Timber', 5000, NULL, NULL),
(217, '15-174001-0035-0002', 'Timber', 5000, NULL, NULL),
(218, '15-174001-0038-0017', 'Timber', 42500, NULL, NULL),
(219, '15-174001-0042-0006', 'Timber', 15000, NULL, NULL),
(220, '15-174001-0056-0007', 'Timber', 17500, NULL, NULL),
(221, '15-174001-0037-0009', 'Timber', 20000, NULL, NULL),
(222, '15-174001-0043-0053', 'Timber', 130000, NULL, NULL),
(224, '15-174001-0054-0002', 'Timber', 5000, NULL, NULL),
(225, '15-174001-0056-0007', 'Timber', 17500, NULL, NULL),
(226, '15-174001-0051-0012', 'Timber', 30000, NULL, NULL),
(227, '15-174001-0039-0010', 'Timber', 75000, NULL, NULL),
(228, '15-174001-0040-0010', 'Timber', 0, NULL, NULL),
(229, '15-174001-0041-0010', 'Timber', 0, NULL, NULL),
(230, '15-174001-0048-0006', 'Timber', 65000, NULL, NULL),
(231, '15-174001-0045-0021', 'Timber', 112500, NULL, NULL),
(232, '15-174001-0046-0024', 'Timber', 0, NULL, NULL),
(233, '16-174001-0001-0027', 'Timber', 44982, NULL, NULL),
(234, '17-174001-0001-0025', 'Timber', 0, NULL, NULL),
(235, '17-174001-0001-0025', 'Fruit Trees', 0, NULL, NULL),
(236, '17-174001-0002-0016', 'Timber', 0, NULL, NULL),
(237, '17-174001-0003-0049', 'Timber', 56250, NULL, NULL),
(238, '18-174000-0004-0010', 'Bamboo', 2040, NULL, NULL),
(239, '18-174000-0003-0010', 'Bamboo', 2040, NULL, NULL),
(240, '18-174000-0009-0030', 'Timber', 37206, NULL, NULL),
(241, '18-174000-0027-0040', 'Timber', 47474, NULL, NULL),
(242, '18-174000-0268-0002', 'Timber', 5087, NULL, NULL),
(243, '18-174000-0267-0001', 'Timber', 673, NULL, NULL),
(244, '18-174000-0266-0001', 'Timber', 662, NULL, NULL),
(246, '18-174000-0307-0013', 'Timber', 43260, NULL, NULL),
(247, '18-174000-0001-0006', 'Fruit Trees', 1224, NULL, NULL),
(248, '18-174000-0002-0004', 'NTFP', 816, NULL, NULL),
(249, '11-174001-0016-0041', 'Timber', 0, NULL, NULL),
(250, '20-174000-0001-0012', 'NTFP', 2448, NULL, NULL),
(251, '20-174000-0008-0001', 'NTFP', 1250, NULL, NULL),
(252, '20-174000-0009-0006', 'NTFP', 7500, NULL, NULL),
(253, 'TfEtQW2e3i', 'Timber', 10, NULL, NULL),
(254, 'TfEtQW2e3i', 'Fruit Trees', 10, NULL, NULL),
(255, '6Ki8QEcNLX', 'Timber', 0, NULL, NULL),
(256, '6Ki8QEcNLX', 'Mangrove', 0, NULL, NULL),
(257, 'T76iY3q2T8', 'Timber', 0, NULL, NULL),
(258, 'T76iY3q2T8', 'Beach', 0, NULL, NULL),
(260, '20-174000-0012-0002', 'NTFP', 2500, NULL, NULL),
(261, '20-174000-0013-0004', 'NTFP', 5000, NULL, NULL),
(262, '20-174000-0014-0008', 'NTFP', 10000, NULL, NULL),
(263, '20-174000-0015-0003', 'NTFP', 3750, NULL, NULL),
(264, '20-174000-0016-0002', 'NTFP', 2500, NULL, NULL),
(265, '11-174001-0019-0009', 'Timber', 4500, NULL, NULL),
(266, '12-174001-0002-0001', 'High Value Crops', 16500, NULL, NULL),
(267, '12-174001-0003-0007', 'High Value Crops', 0, NULL, NULL),
(268, 'gbZwMoBYO2', 'NTFP', 240, NULL, NULL),
(269, '12-174001-0048-0002', 'Timber', 3500, NULL, NULL),
(270, '12-174001-0049-0001', 'Timber', 0, NULL, NULL),
(271, '13-174001-0025-0025', 'High Value Crops', 12500, NULL, NULL),
(272, '13-174001-0043-0094', 'High Value Crops', 47000, NULL, NULL),
(273, '13-174001-0044-0030', 'Timber', 60000, NULL, NULL),
(274, '13-174001-0037-0017', 'Timber', 8500, NULL, NULL),
(276, '13-174001-0029-0001', 'Timber', 0, NULL, NULL),
(277, '13-174001-0047-0004', 'High Value Crops', 0, NULL, NULL),
(278, '15-174001-0006-0001', 'Mangrove', 16250, NULL, NULL),
(279, '15-174001-0008-0003', 'Mangrove', 0, NULL, NULL),
(280, '15-174001-0009-0002', 'Mangrove', 0, NULL, NULL),
(281, '15-174001-0026-0006', 'Mangrove', 12500, NULL, NULL),
(282, '15-174001-0039-0006', 'Mangrove', 15000, NULL, NULL),
(283, '15-174001-0041-0006', 'Mangrove', 15000, NULL, NULL),
(284, '15-174001-0036-0003', 'Mangrove', 7500, NULL, NULL),
(286, '18-174000-0309-0013', 'Mangrove', 36848, NULL, NULL),
(287, '18-174000-0310-0004', 'Mangrove', 31892, NULL, NULL),
(288, '18-174000-0310-0004', 'Mangrove', 31892, NULL, NULL),
(289, '18-174000-0005-0002', 'Bamboo', 3060, NULL, NULL),
(290, '18-174000-0011-0007', 'Bamboo', 2448, NULL, NULL),
(291, '18-174000-0014-0001', 'Bamboo', 102, NULL, NULL),
(292, '18-174000-0035-0000', 'Bamboo', 102, NULL, NULL),
(293, '18-174000-0029-0001', 'Bamboo', 204, NULL, NULL),
(294, '18-174000-0018-0001', 'Bamboo', 357, NULL, NULL),
(295, '18-174000-0020-0004', 'Bamboo', 1801, NULL, NULL),
(296, '18-174000-0024-0000', 'Bamboo', 302, NULL, NULL),
(297, '18-174000-0028-0001', 'Bamboo', 245, NULL, NULL),
(298, '18-174000-0026-0001', 'Bamboo', 245, NULL, NULL),
(299, '18-174000-0017-0001', 'Bamboo', 204, NULL, NULL),
(300, '18-174000-0030-0000', 'Bamboo', 92, NULL, NULL),
(301, '18-174000-0032-0001', 'Bamboo', 302, NULL, NULL),
(302, '18-174000-0033-0000', 'Bamboo', 20, NULL, NULL),
(303, '18-174000-0034-0003', 'Bamboo', 547, NULL, NULL),
(304, '18-174000-0036-0000', 'Bamboo', 16, NULL, NULL),
(305, '18-174000-0037-0002', 'Bamboo', 386, NULL, NULL),
(306, '18-174000-0038-0001', 'Bamboo', 261, NULL, NULL),
(307, '18-174000-0039-0008', 'Bamboo', 1428, NULL, NULL),
(308, '18-174000-0010-0005', 'Bamboo', 1020, NULL, NULL),
(309, '18-174000-0022-0028', 'Bamboo', 7140, NULL, NULL),
(310, '18-174000-0023-0007', 'Bamboo', 0, NULL, NULL),
(311, '18-174000-0015-0000', 'Bamboo', 118, NULL, NULL),
(312, '18-174000-0016-0000', 'Bamboo', 0, NULL, NULL),
(313, '18-174000-0019-0001', 'Bamboo', 0, NULL, NULL),
(314, '18-174000-0021-0005', 'Bamboo', 0, NULL, NULL),
(315, '18-174000-0031-0000', 'Bamboo', 0, NULL, NULL),
(316, '18-174000-0025-0001', 'Bamboo', 0, NULL, NULL),
(317, '18-174000-0006-0002', 'Bamboo', 0, NULL, NULL),
(318, '18-174000-0007-0005', 'Bamboo', 0, NULL, NULL),
(319, '18-174000-0008-0006', 'Bamboo', 0, NULL, NULL),
(320, '18-174000-0012-0001', 'Bamboo', 0, NULL, NULL),
(321, '18-174000-0307-0013', 'Mangrove', 43260, NULL, NULL),
(322, '18-174000-0308-0002', 'Mangrove', 0, NULL, NULL),
(323, '18-174000-0311-0008', 'Mangrove', 0, NULL, NULL),
(324, '18-174000-0013-0004', 'Bamboo', 0, NULL, NULL),
(325, '20-174000-0010-0007', 'Mangrove', 8750, NULL, NULL),
(326, '20-174000-0011-0007', 'Mangrove', 8750, NULL, NULL),
(327, '20-174000-0002-0007', 'Mangrove', 8750, NULL, NULL),
(328, '20-174000-0003-0007', 'Mangrove', 8750, NULL, NULL),
(329, '20-174000-0004-0006', 'Mangrove', 7500, NULL, NULL),
(330, '15-174001-0012-0000', 'Timber', 12500, NULL, NULL),
(331, '15-174001-0020-0000', 'Timber', 0, NULL, NULL),
(332, '15-174001-0021-0001', 'Timber', 0, NULL, NULL),
(333, '15-174001-0026-0001', 'Timber', 0, NULL, NULL),
(334, '15-174001-0013-0000', 'Timber', 0, NULL, NULL),
(335, '15-174001-0014-0001', 'Timber', 0, NULL, NULL),
(336, '15-174001-0015-0000', 'Timber', 0, NULL, NULL),
(337, '15-174001-0016-0001', 'Timber', 0, NULL, NULL),
(338, '15-174001-0001-0000', 'Timber', 0, NULL, NULL),
(339, '15-174001-0002-0002', 'Timber', 0, NULL, NULL),
(341, '15-174001-0008-0000', 'Timber', 0, NULL, NULL),
(342, '15-174001-0009-0000', 'Timber', 0, NULL, NULL),
(343, '15-174001-0010-0001', 'Timber', 0, NULL, NULL),
(344, '15-174001-0027-0000', 'Timber', 0, NULL, NULL),
(345, '15-174001-0028-0001', 'Timber', 0, NULL, NULL),
(346, '15-174001-0029-0000', 'Timber', 0, NULL, NULL),
(347, '15-174001-0023-0007', 'Timber', 0, NULL, NULL),
(348, '15-174001-0024-0001', 'Timber', 0, NULL, NULL),
(349, '15-174001-0003-0001', 'Timber', 0, NULL, NULL),
(350, '15-174001-0004-0001', 'Timber', 0, NULL, NULL),
(351, '15-174001-0005-0001', 'Timber', 0, NULL, NULL),
(352, '15-174001-0022-0001', 'Timber', 0, NULL, NULL),
(353, '15-174001-0018-0000', 'Timber', 0, NULL, NULL),
(354, '15-174001-0019-0001', 'Timber', 0, NULL, NULL),
(355, '15-174001-0031-0000', 'Timber', 0, NULL, NULL),
(357, '15-174001-0017-0000', 'Timber', 0, NULL, NULL),
(358, '15-174001-0025-0000', 'Timber', 0, NULL, NULL),
(360, '15-174001-0006-0000', 'Timber', 0, NULL, NULL),
(361, '15-174001-0040-0006', 'Mangrove', 17500, NULL, NULL),
(362, '15-174001-0044-0006', 'Mangrove', 15000, NULL, NULL),
(363, '15-174001-0047-0005', 'Mangrove', 0, NULL, NULL),
(364, '15-174001-0049-0007', 'Mangrove', 0, NULL, NULL),
(368, '15-174001-0671-0003', 'Mangrove', 0, NULL, NULL),
(372, '11-174001-0009-0030', 'Timber', 15000, NULL, NULL),
(374, '15-174001-0007-0001', 'Timber', 0, NULL, NULL),
(375, '15-174001-0011-0001Ba', 'Timber', 0, NULL, NULL),
(376, '15-174001-0011-0001Bb', 'Timber', 0, NULL, NULL),
(377, '15-174001-0011-0001Bba', 'Timber', 0, NULL, NULL),
(378, '15-174001-0011-0001Bbb', 'Timber', 0, NULL, NULL),
(379, '21-174000-0003-0010', 'Bamboo', 2040, NULL, NULL),
(380, '0TCYtI2YTu', 'Timber', 1000, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `component_tbl`
--

CREATE TABLE `component_tbl` (
  `component_id` int(11) NOT NULL,
  `component_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `component_tbl`
--

INSERT INTO `component_tbl` (`component_id`, `component_name`) VALUES
(1, 'Agroforestry'),
(2, 'Reforestation'),
(3, 'Reforestation (Urban)');

-- --------------------------------------------------------

--
-- Table structure for table `contact_tbl`
--

CREATE TABLE `contact_tbl` (
  `Contact_ID` int(11) NOT NULL,
  `Firstname` varchar(50) DEFAULT NULL,
  `Middlename` varchar(50) DEFAULT NULL,
  `Lastname` varchar(50) DEFAULT NULL,
  `Phone` varchar(100) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `contact_tbl`
--

INSERT INTO `contact_tbl` (`Contact_ID`, `Firstname`, `Middlename`, `Lastname`, `Phone`, `Address`) VALUES
(1, 'ranny', 'nati', 'vi', '09777633125', 'Gasan'),
(2, 'Ranx', 'fsd', 'fds', '233242422', 'Boac'),
(3, 'Ranyd', 'da', 'da', '323424', 'Gasan'),
(4, 'Marvin', 'gay', 'yow', 'Ex.09777633512', 'Baranggay,Municipality'),
(5, 'Barot', 'Macayaon', 'natividad', '09777633521', 'Gasan'),
(6, 'Ran', 'Mel', 'Nyok', '09777633512', 'Boac'),
(7, 'Hello', 'Kid', 'oda', '09777655432', 'boac'),
(8, 'Ryan', 'Malapote', 'Labog', '09777655221', 'Torrijos'),
(9, 'jomar', 'madla', 'rey', '097776554321', 'Torrijos'),
(10, 'Ralden', 'M.', 'Natividad', '097776554231', 'Gasan'),
(11, 'Lara', 'macayaon', 'Natividad', '09777644321', 'Gasan'),
(12, 'Ryan', 'Egor', 'Barlog', '097776335122', 'Gasan'),
(13, 'Ranny', 'M.', 'Natividad', '09777633512', 'Libtangin,Gasan'),
(14, 'Ranny', 'M', 'Natividad', '09777633512', 'Libtangin,Gasan'),
(15, 'Antero ', 'M.', 'Fiegalan', '09777633512', 'Sihi, Buenavista'),
(16, 'Aristeo', 'R.', 'Rodil', '09777633512', 'Makulapnit, Sta.cruz, Marinduque'),
(17, 'Michael', 'C.', 'Colopano', '09777633512', 'Bayakbakin, Sta. Cruz, Marinduque'),
(18, 'Delfin', '', 'Fellizar', '', 'Devilla, Sta. Cruz, Marinduque'),
(19, 'Sabino', 'P.', 'Rojo', '', 'Malibago, Buenavista, Marinduque'),
(20, 'Ruel', '', 'Macdon', '', 'Talawan, Torrijos, Marinduque'),
(21, 'Reden', 'G.', 'Fidelino', '', 'Sibuyao, Torrijos, Marinduque'),
(22, 'Teodoro', 'R.', 'Ramos', '', 'Masalukot, Sta. Cruz, Marinduque'),
(23, 'Ma. Teresita', '', 'Linga', 'Ex.09777633512', 'Tumagabok, Boac'),
(24, 'Ruben', '', 'Apostol', '', 'Tumagabok, Boac'),
(25, 'Isidro', '', 'Palomares', 'Ex.09777633512', 'Sibuyao, Torrijos'),
(26, 'Edgar', '', 'Perlas', '', 'Yook, Buenavista'),
(27, 'Edwin', '', 'Jalac', '', 'Hinanggayon, Boac, Marinduque'),
(28, 'Joseph', '', 'Montemar', 'Ex.09777633512', 'Binunga, Boac, Marinduque'),
(29, 'Mauro', 'M.', 'Labog', '', 'Canat, Boac, Marinduque'),
(30, 'Restituto', '', 'Pabalat', '', 'Malbog, Buenavista'),
(31, 'Mario', 'C.', 'Francisco II', '', 'Bagtingon, Buenavista'),
(32, 'Porferio', '', 'Manuba', '', 'San Isidro, Sta. Cruz, Marinduque'),
(33, 'Jose ', '', 'Nabos', '', 'Sabong, Boac, Marinduque'),
(34, 'Conrado', '', 'Melecia', '', 'Malabon, Sta. Cruz, Marinduque'),
(35, 'Nolie', '', 'Quindoza', '', 'Kilo - Kilo, Sta. Cruz, Marinduque'),
(36, 'Joel', '', 'Rey', '', 'Bonliw, Torrijos, Marinduque'),
(37, 'Ulpiano', '', 'Ugayre', '', 'Balagasan, Boac, Marinduque'),
(38, 'Jose', '', 'Lazarte', '', 'Hinapulan, Boac, Marinduque'),
(39, 'Allan', '', 'Hizole', '', 'Duyay, Boac, Marinduque'),
(40, 'Vidal', '', 'Sajo', '', 'Tiguion, Gasan, Marinduque'),
(41, 'Gonzalo', '', 'Magpili', '', 'Antipolo, Gasan, Marinduque'),
(42, 'Crisostomo', '', 'Monterey', '', 'Boi, Boac, Marinduque'),
(43, 'Samuel', '', 'Rescuber', '', 'Libjo, Sta. Cruz, Marinduque'),
(44, 'Alejandro', '', 'Opis', '', 'Tambunan, Boac, Marinduque'),
(45, 'Luis', '', 'Luha', '', 'Tugos, Boac, Marinduque'),
(46, 'Iluminada', '', 'Zulueta', '', 'Makulapnit, Sta. Cruz, Marinduque'),
(47, 'Victor', '', 'Riego, Sr', '', 'Masalukot, Sta. Cruz, Marinduque'),
(48, 'Joel', '', 'Regis', '', 'Malibago, Torrijos, Marinduque'),
(49, 'Danilo', '', 'Nabos', '', 'Bayuti, Boac, Marinduque'),
(50, 'Ruben', '', 'Pelandiana', '', 'Tambangan, Sta. Cruz, Marinduque'),
(51, 'Diosdado', '', 'Pastoral', '', 'Nangka, Torrijos, Marinduque'),
(52, 'Florencio', '', 'Mogol', '', 'Tabi, Boac, Marinduque'),
(53, 'Belardo', '', 'Salvacion', '', 'Bagacay, Buenavista, Marinduque'),
(54, 'Rolinio', '', 'Sajul', '', 'Malbog, Buenavista, Marinduque'),
(55, 'Diosdado', '', 'Pastoral', '', 'Nangka, Torrijos, Marinduque'),
(56, 'Marianito', '', 'Sena', '', 'Tabionan, Gasan, Marinduque'),
(57, 'Domingo', '', 'Estrella', '', 'Tawiran, Sta. Cruz, Marinduque'),
(58, 'Romeo', '', 'Pedrialva', '', 'Maranlig, Torrijos, Marinduque'),
(59, 'Reden', '', 'Maquimot', '', 'Bamban, Boac, Marinduque'),
(60, 'Jay', '', 'Montiano', '', 'Mainit, Boac, Marinduque'),
(61, 'Amelia', '', 'Magdurulan', '', 'Bantay, Boac, Marinduque'),
(62, 'Gerry', '', 'Magdalita', '', 'Ogbac, Boac, Marinduque'),
(63, 'Antonio', '', 'Jalotjot', '', 'Balimbing, Boac, Marinduque'),
(64, 'Xavier', '', 'Laton', '', 'Boton, Boac, Marinduque'),
(65, 'Imee', '', 'Lara', '', 'Tumapon, Boac, Marinduque'),
(66, 'Armando', '', 'Mayores', '', 'Tampus, Boac, Marinduque'),
(67, 'Teresita', '', 'Malapad', '', 'Daypay, Boac, Marinduque'),
(68, 'Miguel', '', 'Magcamit', '', 'Sawi, Boac, Marinduque'),
(69, 'Erlando', '', 'De Leon', '', 'Catubugan, Boac, Marinduque'),
(70, 'Rommel', '', 'Sadim', '', 'Dawis, Gasan, Marinduque'),
(71, 'Rolando', 'P.', 'Sapallo', '', 'Duyay, Gasan, Marinduque'),
(72, 'Bienvenido', '', 'Palma', 'Ex.09777633512', 'Tawiran, Sta. Cruz, Marinduque'),
(73, 'Restituto', 'P.', 'Ricamata', 'Ex.09777633512', 'Biga, Sta. Cruz, Marinduque'),
(74, 'Marion', 'C.', 'Francisco II', 'Ex.09777633512', 'Bagtingon, Gasan, Marinduque'),
(75, 'Pacifico', '', 'Mabato', '', 'Tugos, Boac, Marinduque'),
(76, 'Reden', 'G.', 'Fidelino', NULL, 'Sibuyao, Torrijos, Marinduque'),
(77, 'Reden', 'G.', 'Fidelino', '', 'Sabong, Boac, Marinduque'),
(78, 'Wenifredo', '', 'Riego', '', 'Bicas-bicas, Buenavista, Marinduque'),
(79, 'Russel', '', 'Madrigal', '', 'Buenavista, Marinduque'),
(80, 'Wenifredo', '', 'Riego', '', 'Buenavista, Marinduque'),
(81, 'Helen', '', 'Fiegalan', '', 'Sihi, Buenavista, Marindque'),
(82, 'Apolonio', '', 'Pinion', '', 'Makawayan, Torrijos, Marinduque'),
(83, 'Nilo', 'S.', 'Saludes', '', 'Yook, Buenavista, Marinduque'),
(84, 'Rodelio', '', 'Sotto', '', 'Lipata, Buenavista, Marinduque'),
(85, 'Reynante', '', 'Mayorga', '', 'Canat, Boac, Marinduque'),
(86, 'Celedonia', '', 'Naranjo', '', 'Tambunan, Boac, Marinduque'),
(87, 'Paciano', '', 'Rodelas', '', 'Dating Bayan, Sta. Cruz, Marinduque'),
(88, 'Felipe', '', ' Penales', '', 'Payanas, Torrijos, Marinduque'),
(89, 'Redugerio', '', 'Rizal', '', 'Balogo, Boac, Marinduque'),
(90, 'Enrico', '', 'Roqueza', '', 'Caigangan, Boac, Marinduque'),
(91, 'Delson', '', 'Leal', '', 'Mogpog, Marinduque'),
(92, 'Celso', 'J.', 'Quinto', '', 'Balanacan, Mogpog, Marinduque'),
(93, 'Ariel', '', 'Ola', '', 'Ino, Mogpog, Marinduque'),
(94, 'Samuel', '', 'Rondera', '', 'Angas, Sta. Cruz, Marinduquue'),
(95, 'Avelino', '', 'Garcia', '', 'Buyabod, Sta. Cruz, Marinduque'),
(96, 'Leonardo', '', 'Pena', '', 'Masaguisi, Sta. Cruz, Marinduque'),
(97, 'Sabino', '', 'Reginio', '', 'Ipil, Sta. Cruz, Marinduque'),
(98, 'German', '', 'Quindoza', '', 'Kalangkang, Sta. Cruz, Marinduque'),
(99, 'Leonardo', 'P.', 'Pena', '', 'Tagum, Sta. Cruz, Marinduque'),
(100, 'Diomedes', '', 'Revilla', '', 'Taytay, Sta. Cruz, Marinduque'),
(101, 'Jaime', '', 'Ribleza', '', 'Kasily, Sta. Cruz, Marinduque'),
(102, 'Apolonio', '', 'Regalia', 'Ex.09777633512', 'Hupi, Sta. Cruz, Marinduque'),
(103, 'Simon', 'P.', 'Rioveros', '', 'Kay Duke, Torrijos, Marinduque'),
(104, 'Enrique', '', 'Rejano', '', 'Botilao, Sta. Cruz, Marinduque'),
(105, 'Nelson', 'R.', 'Gonzales', '', 'Matalaba, Sta. Cruz, Marinduque'),
(106, 'Ruben', '', 'Ricafrente', '', 'Morales, Sta Cruz, Marinduque'),
(107, 'Juanito', '', 'Recafrac', '', 'Polo, Sta. Cruz, Marinduque'),
(108, 'PENRO', '', 'Marinduque', '', 'Bangbangalon, Boac, Marinduque'),
(109, 'Danilo', '', 'Marinduque', '', 'Sihi, Buenavista, Marinduque'),
(110, 'Joel', 'P.', 'Quizana', '', 'Ipil, Sta. Cruz'),
(111, 'Merian P. Catajay-Mani,Ed.D/', 'Diosdado P. Zulueta,FFP, DPA', '.', 'Ex.09777633512', 'Tanza, Boac, Marinduque'),
(112, 'Ran', 'N.', 'Ny', 'Ex.09777633512', 'gasan'),
(113, 'Condrado', '', 'Melecia', 'Ex.09777633512', 'Malabon, Sta. Cruz, Marinduque'),
(114, 'Crisostomo Montery,', '', 'Danilo Nabos', 'Ex.09777633512', 'Boac, Marinduqe'),
(115, 'Russel', '', 'Madrigal', '', 'Buenavista, Marindque'),
(116, 'David G. Vitto ,  Nilo Saludes', '', '.', 'Ex.09777633512', 'Yook, Buenavista, Marinduque'),
(117, 'Enrico Roqueza , Mario Francisco II', '', '.', '', 'Buenavista, Marinduque'),
(118, 'Zacarias', '', 'Palmero', '', 'Mabuhay, Torrijos');

-- --------------------------------------------------------

--
-- Table structure for table `contract_doc_tbl`
--

CREATE TABLE `contract_doc_tbl` (
  `contract_doc_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `url` varchar(500) NOT NULL,
  `unique_code` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contract_tbl`
--

CREATE TABLE `contract_tbl` (
  `contract_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `org_id` int(11) NOT NULL,
  `date_execution` date NOT NULL,
  `date_expiry` date NOT NULL,
  `zone` varchar(100) NOT NULL,
  `fund` varchar(100) NOT NULL,
  `activities` varchar(100) NOT NULL,
  `year` varchar(20) NOT NULL,
  `region` varchar(20) NOT NULL,
  `district` varchar(20) NOT NULL,
  `baranggay` varchar(100) NOT NULL,
  `municipality` varchar(50) NOT NULL,
  `province` varchar(50) NOT NULL,
  `penro` varchar(20) NOT NULL,
  `cenro` varchar(20) NOT NULL,
  `component` varchar(100) NOT NULL,
  `commodity` varchar(100) NOT NULL,
  `species` varchar(100) NOT NULL,
  `seed_reqdisplay` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `contract_tbl`
--

INSERT INTO `contract_tbl` (`contract_id`, `unique_code`, `org_id`, `date_execution`, `date_expiry`, `zone`, `fund`, `activities`, `year`, `region`, `district`, `baranggay`, `municipality`, `province`, `penro`, `cenro`, `component`, `commodity`, `species`, `seed_reqdisplay`) VALUES
(3, '22-174000-0001-0012', 20, '2022-06-15', '2024-12-15', '0', 'Regular fund', '0', '2022', 'MIMAROPA', 'Lone District', 'TALAWAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Fruit Trees', '0', '6000'),
(5, '22-174000-0004-0020', 18, '2022-06-15', '2024-12-15', '0', 'Regular fund', '0', '2022', 'MIMAROPA', 'Lone District', 'DEVILLA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Indigenous Trees\r\nFruit Trees\r\n', '0', '11625'),
(6, '11-174001-0001-0034', 15, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIHI', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '17000'),
(9, '11-174001-0002-0008', 23, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber, Fruit Trees\r\n', '0', '4000'),
(10, '11-174001-0003-0002', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1000'),
(11, '11-174001-0004-0012', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '6000'),
(12, '11-174001-0005-0007', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(13, '11-174001-0006-0003', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(16, '11-174001-0007-0001', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '500'),
(17, '11-174001-0008-0002', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber', '0', '1000'),
(20, '22-174000-0003-0032', 19, '2022-06-15', '2024-12-15', '0', 'Regular fund', '0', '2022', 'MIMAROPA', 'Lone District', 'MALIBAGO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Indigenous Trees\r\nFruit Trees\r\n', '0', '19000'),
(21, '22-174000-0002-0011', 21, '2022-06-15', '2024-12-15', '0', 'Regular fund', '0', '2022', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Fruit Trees', '0', '5500'),
(22, '22-174000-0005-0024', 22, '2022-06-15', '2024-12-15', '0', '0', '0', '2022', 'MIMAROPA', 'Lone District', 'MASALUKOT', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Indigenous Trees\r\nFruit Trees\r\n', '0', '14125'),
(24, '21-174000-0001-0020/ 21-174000-0002-0050', 16, '2021-02-08', '2023-12-08', '0', 'Regular fund', '0', '2021', 'MIMAROPA', 'Lone District', 'MAKULAPNIT', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Indigenous Trees\r\nFruit Trees\r\n', '0', '22125\r\n17500\r\n'),
(26, '11-174001-0010-0040', 27, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'HINANGGAYON', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber\r\nFruit Trees\r\n', '0', '20000'),
(27, '11-174001-0011-0030', 26, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'YOOK', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '15000'),
(28, '11-174001-0012-0003', 28, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BINUNGA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(29, '11-174001-0013-0003', 29, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'CANAT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(30, '11-174001-0014-0004', 30, '2011-11-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(31, '11-174001-0015-0018', 31, '2011-11-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TUNGIB-LIPATA', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber\r\nFruit Trees\r\n', '0', '30000'),
(32, '11-174001-0017-0009', 32, '2011-11-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SAN-ISIDRO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber\r\nFruit Trees\r\n', '0', '4500'),
(33, '11-174001-0018-0003', 33, '2011-11-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SABONG', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(34, '11-174001-0020-0010', 35, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'KILO-KILO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '5000'),
(35, '11-174001-0024-0003', 37, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BALAGASAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(36, '11-174001-0025-0003', 38, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'HINAPULAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(37, '11-174001-0026-0004', 15, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIHI', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(38, '11-174001-0027-0003', 39, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'DUYAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(39, '11-174001-0028-0003', 40, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TIGUION', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(40, '11-174001-0029-0003', 41, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(41, '11-174001-0030-0003', 42, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BOI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(42, '11-174001-0031-0003', 18, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'DEVILLA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(43, '11-174001-0032-0005', 43, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'LIBJO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(46, '11-174001-0035-0003', 45, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TUGOS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(47, '11-174001-0036-0002', 46, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'MAKULAPNIT', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(48, '11-174001-0037-0003', 47, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'MASALUKOT', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(49, '11-174001-0038-0003', 48, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'MALIBAGO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(50, '11-174001-0039-0003', 31, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BAGTINGON', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(51, '11-174001-0040-0002', 49, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BAYUTI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(52, '11-174001-0041-0003', 50, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TAMBANGAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(53, '11-174001-0042-0003', 51, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'NANGKA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(54, '11-174001-0043-0003', 25, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(55, '11-174001-0044-0003', 52, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TABIGUE', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(56, '12-174001-0001-0014', 53, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BAGACAY', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '7000'),
(57, '12-174001-0012-0050', 55, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'NANGKA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '25000'),
(58, '12-174001-0020-0045', 56, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TABIONAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '22500'),
(59, '12-174001-0021-0027', 56, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TABIONAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '13500'),
(60, '12-174001-0025-0011', 23, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '5500'),
(61, '12-174001-0026-0031', 23, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '15500'),
(62, '12-174001-0028-0011', 57, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '20000'),
(63, '12-174001-0029-0020', 58, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MARANLIG', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '10000'),
(64, '12-174001-0030-0003', 59, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BAMBAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '140'),
(65, '12-174001-0031-0003', 38, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'HINAPULAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'NFTP', '0', '340'),
(66, '12-174001-0032-0005', 38, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'HINAPULAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(67, '12-174001-0033-0004', 64, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BOTON', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'NTFP', '0', '2000'),
(68, '12-174001-0034-0006', 60, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MAINIT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(71, '12-174001-0039-0005', 62, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'OGBAC', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2500'),
(72, '12-174001-0040-0007', 63, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BALIMBING', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '3000'),
(73, '12-174001-0041-0007', 65, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TUMAPON', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(74, '12-174001-0042-0001', 66, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'TAMPUS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '500'),
(75, '12-174001-0043-0003', 67, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'DAYPAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(76, '12-174001-0044-0005', 68, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'SAWI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(77, '12-174001-0045-0002', 69, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'CATUBUGAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1000'),
(78, '12-174001-0046-0002', 37, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BALAGASAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1000'),
(79, '12-174001-0047-0005', 29, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'CANAT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(80, '12-174001-0038-0001', 28, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BINUNGA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1500'),
(81, '13-174001-0001-0001', 70, '2011-06-15', '2013-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'PINGGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '500'),
(82, '13-174001-0002-0001', 70, '2012-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '500'),
(83, '13-174001-0003-0005', 71, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'CABUGAO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(84, '13-174001-0004-0014', 71, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAPUYAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '7000'),
(85, '13-174001-0005-0004', 41, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(86, '13-174001-0006-0043', 72, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '60000'),
(87, '13-174001-0007-0002', 73, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '4000'),
(89, '13-174001-0008-0006', 54, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3000'),
(90, '13-174001-0009-0006', 28, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BINUNGA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3000'),
(91, '13-174001-0010-0005', 74, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BAGTINGON', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(92, '13-174001-0011-0004', 74, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BAGTINGON', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(93, '13-174001-0012-0005', 42, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BOI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(94, '13-174001-0013-0009', 75, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUGOS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '4500'),
(95, '13-174001-0014-0027', 76, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'SABONG', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Fruit Trees', '0', '13500'),
(97, '13-174001-0016-0018', 54, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '9000'),
(98, '13-174001-0017-0010', 54, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '5000'),
(99, '11-174001-0033-0001', 24, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(100, '11-174001-0034-0003', 44, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TAMBUNAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(103, '11-174001-0021-0012', 36, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '6000'),
(104, '11-174001-0022-0005', 36, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(105, '11-174001-0023-0006', 36, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3000'),
(106, '12-174001-0002-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '16500'),
(107, '12-174001-0003-0007', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(108, '12-174001-0004-0003', 54, '2012-11-29', '2014-12-29', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(109, '12-174001-0005-0002', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'LIBAS', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(110, '12-174001-0006-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(111, '12-174001-0007-0004', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(112, '12-174001-0008-0000', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(113, '12-174001-0009-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(114, '12-174001-0010-0000', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(115, '12-174001-0011-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(116, '12-174001-0013-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(117, '12-174001-0014-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(118, '12-174001-0015-0002', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(119, '12-174001-0016-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(120, '12-174001-0017-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(121, '12-174001-0018-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(122, '12-174001-0019-0000', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber', '0', '0'),
(123, '12-174001-0022-0004', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(124, '12-174001-0023-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(125, '12-174001-0024-0000', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(128, '12-174001-0027-0001', 54, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(129, '12-174001-0036-0005', 61, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BANTAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2500'),
(130, '12-174001-0048-0002', 79, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'MALBOG, TIMBO', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2000'),
(131, '13-174001-0015-0015', 80, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BICAS-BICAS', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '7500'),
(132, '12-174001-0037-0003', 28, '2012-12-05', '2014-12-05', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BINUNGA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'NTFP', '0', '1500'),
(133, '13-174001-0018-0058', 81, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'SIHI', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber\r\n', '0', '29000'),
(134, '13-174001-0019-0029', 82, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'SIHI', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '14500'),
(135, '13-174001-0020-0034', 71, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'DUYAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '17000'),
(136, '13-174001-0021-0005', 38, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'HINAPULAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(137, '13-174001-0026-0038', 83, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'YOOK', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '19000'),
(138, '13-174001-0027-0030', 84, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUNGIB-LIPATA', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '15000'),
(139, '13-174001-0024-0024', 84, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUNGIB-LIPATA', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '12000'),
(140, '13-174001-0035-0031', 85, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'CANAT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '15500'),
(141, '13-174001-0038-0006', 86, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAMBUNAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '20000'),
(142, '13-174001-0039-0004', 86, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAMBUNAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(143, '13-174001-0040-0005', 86, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAMBUNAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(144, '13-174001-0041-0031', 86, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TAMBUNAN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(145, '13-174001-0042-0044', 75, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUGOS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber, Fuel Wood', '0', '22000'),
(147, '13-174001-0031-0022', 75, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUGOS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '11000'),
(148, '13-174001-0046-0009', 87, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'DATING BAYAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '6000'),
(149, '13-174001-0048-0005', 88, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'PAYANAS', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '5000'),
(150, '13-174001-0049-0002', 88, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'PAYANAS', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(151, '13-174001-0050-0005', 88, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'PAYANAS', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(152, '13-174001-0052-0013', 75, '2013-12-06', '2015-12-06', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TUGOS', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(153, '13-174001-0055-0091', 86, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'TALAWAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '45500'),
(154, '13-174001-0056-0033', 76, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '16500'),
(155, '13-174001-0045-0028', 73, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '55200'),
(156, '13-174001-0032-0015', 89, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BALOGO', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '30000'),
(157, '13-174001-0023-0008', 70, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'DAWIS', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '4000'),
(158, '13-174001-0036-0005', 90, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '2500'),
(159, '13-174001-0030-0040', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'Nangka II , Sumangga , Malusak , Magapua , Banto, Butansapa , and Boc-boc', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '20000'),
(160, '13-174001-0051-0003', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BANTO, BUTANSAPA', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(161, '13-174001-0053-0007', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MALUSAK', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3000'),
(162, '13-174001-0022-0007', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'SUMANGGA', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '3500'),
(163, '13-174001-0028-0001', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'NANGKA II', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1000'),
(164, '13-174001-0054-0003', 91, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MAGAPUA', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1000'),
(165, '13-174001-0033-0003', 76, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'POBLACION', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(166, '13-174001-0034-0004', 76, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'MARANLIG, NANGKA', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(167, '15-174001-0001-0005', 92, '2015-06-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALANACAN', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '20000'),
(168, '15-174001-0002-0004', 92, '2015-06-15', '2018-06-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALANACAN', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(169, '15-174001-0003-0003', 93, '2015-12-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'INO', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '37500'),
(171, '15-174001-0004-0004', 93, '2015-06-18', '2018-06-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'INO', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(172, '15-174001-0005-0008', 93, '2015-06-18', '2018-06-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'INO', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(173, '15-174001-0007-0020', 94, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANGAS', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '50000'),
(174, '15-174001-0010-0010', 95, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BUYABOD', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '25000'),
(176, '15-174001-0012-0004', 96, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MASAGUISI', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '10000'),
(177, '15-174001-0019-0002', 96, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MASAGUISI', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '5000'),
(178, '15-174001-0013-0008', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '135000'),
(179, '15-174001-0014-0008', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(180, '15-174001-0015-0015', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(181, '15-174001-0016-0021', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(182, '15-174001-0024-0004', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '10000'),
(183, '15-174001-0017-0007', 98, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KALANGKANG', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '30000'),
(184, '15-174001-0018-0005', 98, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KALANGKANG', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '12500'),
(185, '15-174001-0020-0004', 99, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'TAGUM', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '17500'),
(186, '15-174001-0021-0003', 99, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'TAGUM', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(187, '15-174001-0022-0021', 100, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'Taytay', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '62500'),
(188, '15-174001-0023-0005', 100, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'TAYTAY', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(189, '15-174001-0025-0040', 101, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KASILY', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '100000'),
(190, '15-174001-0027-0015', 102, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'HUPI', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '37500'),
(191, '15-174001-0028-0002', 89, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALOGO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bakauan', '0', '31250'),
(192, '15-174001-0029-0010', 89, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALOGO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(193, '15-174001-0030-0005', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '50000'),
(194, '15-174001-0031-0005', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(195, '15-174001-0032-0002', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MALINAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(196, '15-174001-0033-0005', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(197, '15-174001-0036-0002', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '6000'),
(198, '15-174001-0034-0010', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'SUHA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '70000'),
(199, '15-174001-0035-0018', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'SUHA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(200, '15-174001-0037-0002', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '5000'),
(201, '15-174001-0038-0012', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '30000'),
(203, '15-174001-0033-0001', 92, '2015-06-18', '2018-05-22', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALANACAN', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '2500'),
(204, '15-174001-0034-0002', 73, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '5000'),
(205, '15-174001-0035-0002', 104, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BOTILAO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '5000'),
(206, '15-174001-0038-0017', 102, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'HUPI', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '42500'),
(207, '15-174001-0042-0006', 101, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KASILY', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '15000'),
(208, '15-174001-0056-0007', 103, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'SUHA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '17500'),
(209, '15-174001-0037-0009', 89, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALOGO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '20000'),
(210, '15-174001-0043-0053', 105, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MATALABA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '130000'),
(212, '15-174001-0054-0002', 103, '2015-06-18', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'SUHA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '55000'),
(214, '15-174001-0051-0012', 103, '2015-12-15', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(215, '15-174001-0039-0010', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '25000'),
(216, '15-174001-0040-0010', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '25000'),
(217, '15-174001-0041-0010', 97, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '25000'),
(218, '15-174001-0048-0006', 107, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'POLO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '65000'),
(219, '15-174001-0045-0021', 73, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'TAMAYO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '52500'),
(220, '15-174001-0046-0024', 73, '2015-06-18', '2017-12-18', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'TAMAYO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '60000'),
(221, '16-174001-0001-0027', 85, '2016-12-15', '2018-12-15', '0', '0', '0', '2016', 'MIMAROPA', 'Lone District', 'BINUNGA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '44982'),
(222, '17-174001-0001-0025', 39, '2017-01-15', '2019-12-15', '0', '0', '0', '2017', 'MIMAROPA', 'Lone District', 'DUYAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber,  High Value, Crops, Fruit Trees\r\n\r\n', '0', '47030'),
(223, '17-174001-0002-0016', 39, '2017-01-15', '2019-12-15', '0', '0', '0', '2017', 'MIMAROPA', 'Lone District', 'DUYAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber,  High Value, Crops, Fruit Trees\r\n', '0', '0'),
(224, '17-174001-0003-0049', 74, '2017-01-15', '2019-12-15', '0', '0', '0', '2017', 'MIMAROPA', 'Lone District', 'BAGTINGON', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '56250'),
(225, '18-174000-0004-0010', 108, '2018-01-16', '2020-12-16', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2040'),
(226, '18-174000-0003-0010', 108, '2018-06-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TUMAGABOK', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2040'),
(227, '18-174000-0009-0030', 109, '2018-06-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'SIHI', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber, Fruit Trees, High Value Crops, Hedgerows\r\n', '0', '37206'),
(228, '18-174000-0027-0040', 19, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALIBAGO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber, Fruit Trees, High Value Crops, Hedgerows\r\n', '0', '47474'),
(229, '18-174000-0268-0002', 103, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '5087'),
(230, '18-174000-0267-0001', 103, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '673'),
(231, '18-174000-0266-0001', 103, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '662'),
(233, '18-174000-0307-0013', 110, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'MAngrove', '0', '43260'),
(234, '18-174000-0001-0006', 108, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BANTAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'NTFP', '0', '1224'),
(235, '18-174000-0002-0004', 108, '2018-01-15', '2020-12-15', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'PUYOG', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'NTFP', '0', '816'),
(236, '11-174001-0016-0041', 31, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'TUNGIB-LIPATA', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber', '0', '0'),
(237, '20-174000-0001-0012', 21, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2448'),
(238, '20-174000-0008-0001', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'BULIASNIN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '1250'),
(239, '20-174000-0009-0006', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'PILI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '7500'),
(244, '20-174000-0012-0002', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'LAYLAY', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '2500'),
(245, '20-174000-0013-0004', 111, '2020-02-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'LAON', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '5000'),
(246, '20-174000-0014-0008', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '10000'),
(247, '20-174000-0015-0003', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'MORALES', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '3750'),
(248, '20-174000-0016-0002', 111, '2020-06-15', '2022-12-15', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '2500'),
(249, '11-174001-0019-0009', 34, '2011-06-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'NAPO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '4500'),
(252, '12-174001-0035-0013', 114, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'BOI', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '240'),
(254, '12-174001-0049-0001', 79, '2012-06-15', '2014-12-15', '0', '0', '0', '2012', 'MIMAROPA', 'Lone District', 'DAYKITIN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '1500'),
(255, '13-174001-0025-0025', 116, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'YOOK', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'Timber\r\nHigh Value Crops', '0', '12500'),
(256, '13-174001-0043-0094', 74, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BAGTINGON', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '47000'),
(257, '13-174001-0044-0030', 73, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '60600'),
(258, '13-174001-0037-0017', 117, '2013-06-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '8500'),
(260, '13-174001-0029-0001', 91, '2013-01-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'NANGKA II', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(261, '13-174001-0047-0004', 87, '2013-01-15', '2015-12-15', '0', '0', '0', '2013', 'MIMAROPA', 'Lone District', 'DATING BAYAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'High Value Crops', '0', '0'),
(262, '15-174001-0006-0001', 73, '2015-06-01', '2017-12-01', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ALOBO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '16250'),
(263, '15-174001-0008-0003', 73, '2015-06-01', '2017-12-01', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(264, '15-174001-0009-0002', 73, '2015-06-03', '2017-12-03', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BIGA', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(265, '15-174001-0026-0006', 73, '2015-06-03', '2017-12-03', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ALOBO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '12500'),
(266, '15-174001-0039-0006', 103, '2015-06-03', '2017-12-03', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '15000'),
(267, '15-174001-0041-0006', 103, '2015-06-03', '2017-12-03', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MALINAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '15000'),
(268, '15-174001-0036-0003', 89, '2015-05-03', '2017-12-03', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BALOGO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '7500'),
(270, '18-174000-0309-0013', 106, '2018-01-03', '2020-12-03', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MORALES', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '36848');
INSERT INTO `contract_tbl` (`contract_id`, `unique_code`, `org_id`, `date_execution`, `date_expiry`, `zone`, `fund`, `activities`, `year`, `region`, `district`, `baranggay`, `municipality`, `province`, `penro`, `cenro`, `component`, `commodity`, `species`, `seed_reqdisplay`) VALUES
(272, '18-174000-0310-0004', 103, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '31892'),
(273, '18-174000-0005-0002', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '3060'),
(274, '18-174000-0011-0007', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '2448'),
(275, '18-174000-0014-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BAYAKBAKIN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '102'),
(276, '18-174000-0035-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BOLO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '102'),
(277, '18-174000-0029-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALINAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '204'),
(278, '18-174000-0018-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BUANGAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '357'),
(279, '18-174000-0020-0004', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'CABUYO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1801'),
(280, '18-174000-0024-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MABUHAY', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '302'),
(281, '18-174000-0028-0001', 108, '2024-01-06', '2026-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MAKAWAYAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '245'),
(282, '18-174000-0026-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MAKAWAYAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '245'),
(283, '18-174000-0017-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BONLIW', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '204'),
(284, '18-174000-0030-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MARANLIG', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '92'),
(285, '18-174000-0032-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MARLANGGA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '302'),
(286, '18-174000-0033-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MATUYATUYA', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '20'),
(287, '18-174000-0034-0003', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'PAYANAS', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '547'),
(288, '18-174000-0036-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BARANGAY I', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '16'),
(289, '18-174000-0037-0002', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'POCTOY', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '386'),
(290, '18-174000-0038-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'SIBUYAO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '261'),
(291, '18-174000-0039-0008', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TIGWI', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1428'),
(292, '18-174000-0010-0005', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'CAPAYANG', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '1020'),
(293, '18-174000-0022-0028', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'DAMPULAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '7140'),
(294, '18-174000-0023-0007', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'DAMPULAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(295, '18-174000-0015-0000', 108, '2018-01-07', '2020-12-07', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BOLO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '118'),
(296, '18-174000-0016-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BOLO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(297, '18-174000-0019-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'BUANGAN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(298, '18-174000-0021-0005', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'CABUYO', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(299, '18-174000-0031-0000', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MARANLIG', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(300, '18-174000-0025-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MABUHAY', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(301, '18-174000-0006-0002', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(302, '18-174000-0007-0005', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(303, '18-174000-0008-0006', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'MALBOG', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(304, '18-174000-0012-0001', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(306, '18-174000-0308-0002', 110, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'IPIL', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(307, '18-174000-0311-0008', 103, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'KAY DUKE', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(308, '18-174000-0013-0004', 108, '2018-01-06', '2020-12-06', '0', '0', '0', '2018', 'MIMAROPA', 'Lone District', 'TAWIRAN', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Bamboo', '0', '0'),
(309, '20-174000-0010-0007', 111, '2020-01-07', '2022-12-07', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'LUPAC', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '8750'),
(310, '20-174000-0011-0007', 111, '2020-01-07', '2022-12-07', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'LUPAC', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '8750'),
(311, '20-174000-0002-0007', 111, '2020-01-07', '2022-12-07', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'BULIASNIN', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '8750'),
(312, '20-174000-0003-0007', 111, '2020-01-07', '2022-12-07', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'MALIGAYA', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '8750'),
(313, '20-174000-0004-0006', 111, '2020-01-07', '2022-12-07', '0', '0', '0', '2020', 'MIMAROPA', 'Lone District', 'JANAGDONG', 'MOGPOG', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '7500'),
(314, '15-174001-0012-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '12500'),
(315, '15-174001-0020-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BAHI', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(316, '15-174001-0021-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BAHI', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(317, '15-174001-0026-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(318, '15-174001-0013-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(319, '15-174001-0014-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(320, '15-174001-0015-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(321, '15-174001-0016-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(322, '15-174001-0001-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAWIT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(323, '15-174001-0002-0002', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAWIT', 'BOAC', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(325, '15-174001-0008-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'DAYKITIN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(326, '15-174001-0009-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'DAYKITIN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(327, '15-174001-0010-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'DAYKITIN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(328, '15-174001-0027-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0.1'),
(329, '15-174001-0028-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(330, '15-174001-0029-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(331, '15-174001-0023-0007', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MASIGA', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(332, '15-174001-0024-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MASIGA', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(333, '15-174001-0003-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(334, '15-174001-0004-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(335, '15-174001-0005-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(336, '15-174001-0022-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BAHI', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(337, '15-174001-0018-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(338, '15-174001-0019-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(339, '15-174001-0031-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'PINGAN', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(341, '15-174001-0017-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'ANTIPOLO', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(342, '15-174001-0025-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MASIGA', 'GASAN', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(344, '15-174001-0006-0000', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'CAIGANGAN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(345, '15-174001-0040-0006', 118, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MABUHAY', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '17500'),
(346, '15-174001-0044-0006', 106, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'MORALES', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '15000'),
(347, '15-174001-0047-0005', 107, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'POLO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(348, '15-174001-0049-0007', 107, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'POLO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(352, '15-174001-0671-0003', 107, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'POLO', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '0'),
(354, '11-174001-0009-0030', 26, '2011-01-15', '2013-12-15', '0', '0', '0', '2011', 'MIMAROPA', 'Lone District', 'YOOK', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '15000'),
(356, '15-174001-0007-0001', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'DAYKITIN', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(357, '15-174001-0011-0001Ba', 95, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BUYABOD', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(358, '15-174001-0011-0001Bb', 95, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BUYABOD', 'STA. CRUZ', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Mangrove', '0', '2500'),
(359, '15-174001-0011-0001Bba', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BARANGAY I', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(360, '15-174001-0011-0001Bbb', 84, '2015-01-15', '2017-12-15', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'BARANGAY I', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Reforestation', 'Timber', '0', '0'),
(361, '21-174000-0003-0010', 88, '2021-12-28', '2023-12-28', '0', '0', '0', '2021', 'MIMAROPA', 'Lone District', 'BAYAKBAKIN', 'TORRIJOS', 'MARINDUQUE', 'MARINDUQUE', 'N/A', 'Agroforestry', 'NTFP', '0', '2040'),
(362, '0TCYtI2YTu', 45, '2015-07-02', '2017-12-02', '0', '0', '0', '2015', 'MIMAROPA', 'Lone District', 'LIBAS', 'BUENAVISTA', 'MARINDUQUE', 'MARINDUQUE', 'N/A', '', 'Timber', '0', '1000');

-- --------------------------------------------------------

--
-- Table structure for table `data_tbl`
--

CREATE TABLE `data_tbl` (
  `data_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `target_area` decimal(10,0) NOT NULL,
  `area_planted` decimal(10,2) NOT NULL,
  `seed_req` int(11) NOT NULL,
  `seed_pro` int(11) NOT NULL,
  `seed_plant` int(11) NOT NULL,
  `polygon_covered` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `data_tbl`
--

INSERT INTO `data_tbl` (`data_id`, `unique_code`, `target_area`, `area_planted`, `seed_req`, `seed_pro`, `seed_plant`, `polygon_covered`) VALUES
(1, '22-174000-0001-0012', 0, 12.00, 6000, 6600, 6000, 0),
(3, '22-174000-0004-0020', 0, 20.00, 11625, 12831, 11625, 0),
(4, '11-174001-0001-0034', 0, 34.00, 17000, 17000, 17000, 0),
(5, 'lggYyoQaHn', 0, 1.00, 500, 0, 0, 0),
(7, '11-174001-0002-0008', 0, 8.00, 4000, 4000, 4000, 0),
(8, '11-174001-0003-0002', 0, 2.00, 1000, 1000, 1000, 0),
(9, '11-174001-0004-0012', 0, 12.00, 6000, 6000, 6000, 0),
(10, '11-174001-0005-0007', 0, 7.00, 3500, 3500, 3500, 0),
(11, '11-174001-0006-0003', 0, 3.00, 1500, 1500, 1500, 0),
(14, '11-174001-0007-0001', 0, 1.00, 500, 500, 500, 0),
(15, '11-174001-0008-0002', 0, 2.00, 1000, 1000, 1000, 0),
(18, '22-174000-0003-0032', 0, 32.00, 19000, 22720, 19000, 0),
(19, '22-174000-0002-0011', 0, 11.00, 5500, 5700, 5500, 0),
(20, '22-174000-0005-0024', 0, 25.00, 14125, 15500, 14125, 0),
(21, 'RE6bTcSAqc', 0, 70.00, 39625, 0, 0, 0),
(22, '21-174000-0001-0020/ 21-174000-0002-0050', 0, 70.00, 39625, 40656, 39375, 0),
(24, '11-174001-0010-0040', 0, 40.00, 20000, 20000, 20000, 0),
(25, '11-174001-0011-0030', 0, 30.00, 15000, 15000, 15000, 0),
(26, '11-174001-0012-0003', 0, 3.00, 1500, 1500, 1500, 0),
(27, '11-174001-0013-0003', 0, 3.00, 1500, 1500, 1500, 0),
(28, '11-174001-0014-0004', 0, 4.00, 2000, 2000, 2000, 0),
(29, '11-174001-0015-0018', 0, 18.50, 30000, 30000, 30000, 0),
(30, '11-174001-0017-0009', 0, 9.00, 4500, 4500, 4500, 0),
(31, '11-174001-0018-0003', 0, 3.00, 1500, 1500, 1500, 0),
(32, '11-174001-0020-0010', 0, 10.00, 5000, 5000, 5000, 0),
(33, '11-174001-0024-0003', 0, 3.00, 1500, 1500, 1500, 0),
(34, '11-174001-0025-0003', 0, 3.00, 1500, 1500, 1500, 0),
(35, '11-174001-0026-0004', 0, 4.00, 2000, 2000, 2000, 0),
(36, '11-174001-0027-0003', 0, 3.00, 1500, 1500, 1500, 0),
(37, '11-174001-0028-0003', 0, 3.00, 1500, 1500, 1500, 0),
(38, '11-174001-0029-0003', 0, 3.00, 1500, 1500, 1500, 0),
(39, '11-174001-0030-0003', 0, 3.00, 1500, 1500, 1500, 0),
(40, '11-174001-0031-0003', 0, 3.00, 1500, 1500, 1500, 0),
(41, '11-174001-0032-0005', 0, 5.00, 2500, 2500, 2500, 0),
(44, '11-174001-0035-0003', 0, 3.00, 1500, 1500, 1500, 0),
(45, '11-174001-0036-0002', 0, 3.00, 1500, 1500, 1500, 0),
(46, '11-174001-0037-0003', 0, 3.00, 1500, 1500, 1500, 0),
(47, '11-174001-0038-0003', 0, 3.00, 1500, 1500, 1500, 0),
(48, '11-174001-0039-0003', 0, 4.00, 2000, 2000, 2000, 0),
(49, '11-174001-0040-0002', 0, 3.00, 1500, 1500, 1500, 0),
(50, '11-174001-0041-0003', 0, 3.00, 1500, 1500, 1500, 0),
(51, '11-174001-0042-0003', 0, 3.00, 1500, 1500, 1500, 0),
(52, '11-174001-0043-0003', 0, 3.00, 1500, 1500, 1500, 0),
(53, '11-174001-0044-0003', 0, 3.00, 1500, 1500, 1500, 0),
(54, '12-174001-0001-0014', 0, 14.00, 7000, 7000, 7000, 0),
(55, '12-174001-0012-0050', 0, 50.00, 25000, 25000, 25000, 0),
(56, '12-174001-0020-0045', 0, 45.00, 22500, 22500, 22500, 0),
(57, '12-174001-0021-0027', 0, 27.00, 13500, 13500, 13500, 0),
(58, '12-174001-0025-0011', 0, 11.00, 5500, 5500, 5500, 0),
(59, '12-174001-0026-0031', 0, 31.00, 15500, 15500, 15500, 0),
(60, '12-174001-0028-0011', 0, 10.00, 20000, 20000, 20000, 0),
(61, '12-174001-0029-0020', 0, 20.00, 10000, 10000, 10000, 0),
(62, '12-174001-0030-0003', 0, 3.00, 140, 140, 140, 0),
(63, '12-174001-0031-0003', 0, 3.00, 340, 340, 340, 0),
(64, '12-174001-0032-0005', 0, 5.00, 0, 0, 0, 0),
(65, '12-174001-0033-0004', 0, 4.00, 2000, 40, 40, 0),
(66, '12-174001-0034-0006', 0, 7.00, 3500, 60, 60, 0),
(67, '12-174001-0036-0005', 0, 5.00, 2500, 20, 20, 0),
(69, '12-174001-0039-0005', 0, 5.00, 2500, 40, 40, 0),
(70, '12-174001-0040-0007', 0, 6.00, 3000, 40, 40, 0),
(71, '12-174001-0041-0007', 0, 7.00, 3500, 0, 0, 0),
(72, '12-174001-0042-0001', 0, 1.00, 500, 20, 20, 0),
(73, '12-174001-0043-0003', 0, 3.00, 1500, 200, 200, 0),
(74, '12-174001-0044-0005', 0, 5.00, 2500, 100, 100, 0),
(75, '12-174001-0045-0002', 0, 2.00, 1000, 40, 40, 0),
(76, '12-174001-0046-0002', 0, 2.00, 1000, 140, 140, 0),
(77, '12-174001-0047-0005', 0, 7.00, 3500, 720, 720, 0),
(78, '12-174001-0038-0001', 0, 1.00, 1500, 120, 120, 0),
(79, '13-174001-0001-0001', 0, 1.00, 500, 500, 500, 0),
(80, '13-174001-0002-0001', 0, 1.00, 500, 500, 500, 0),
(81, '13-174001-0003-0005', 0, 5.00, 2500, 2500, 2500, 0),
(82, '13-174001-0004-0014', 0, 14.00, 7000, 7000, 7000, 0),
(83, '13-174001-0005-0004', 0, 4.00, 2000, 2000, 2000, 0),
(84, '13-174001-0006-0043', 0, 30.00, 60000, 55050, 55050, 0),
(85, '13-174001-0007-0002', 0, 2.00, 4000, 4000, 4000, 0),
(87, '13-174001-0008-0006', 0, 6.00, 3000, 2850, 2850, 0),
(88, '13-174001-0009-0006', 0, 6.00, 3000, 3000, 3000, 0),
(89, '13-174001-0010-0005', 0, 5.00, 2500, 2500, 2500, 0),
(90, '13-174001-0011-0004', 0, 4.00, 2000, 2000, 2000, 0),
(91, '13-174001-0012-0005', 0, 5.00, 2500, 2500, 2500, 0),
(92, '13-174001-0013-0009', 0, 9.00, 4500, 4500, 4500, 0),
(93, '13-174001-0014-0027', 0, 27.00, 13500, 13500, 13500, 0),
(95, '13-174001-0016-0018', 0, 18.00, 9000, 8950, 8950, 0),
(96, '13-174001-0017-0010', 0, 10.00, 5000, 5000, 5000, 0),
(97, '11-174001-0033-0001', 0, 3.00, 1500, 1500, 1500, 0),
(98, '11-174001-0034-0003', 0, 3.00, 1500, 1500, 1500, 0),
(101, '11-174001-0021-0012', 0, 12.00, 6000, 6000, 6000, 0),
(102, '11-174001-0022-0005', 0, 5.00, 2500, 2500, 2500, 0),
(103, '11-174001-0023-0006', 0, 6.00, 3000, 3000, 3000, 0),
(104, '12-174001-0002-0001', 0, 1.42, 16500, 16500, 16500, 0),
(105, '12-174001-0003-0007', 0, 7.19, 0, 0, 0, 0),
(106, '12-174001-0004-0003', 0, 2.97, 0, 0, 0, 0),
(107, '12-174001-0005-0002', 0, 1.98, 0, 0, 0, 0),
(108, '12-174001-0006-0001', 0, 0.00, 0, 0, 0, 0),
(109, '12-174001-0007-0004', 0, 4.02, 0, 0, 0, 0),
(110, '12-174001-0008-0000', 0, 0.00, 0, 0, 0, 0),
(111, '12-174001-0009-0001', 0, 0.00, 0, 0, 0, 0),
(112, '12-174001-0010-0000', 0, 0.00, 0, 0, 0, 0),
(113, '12-174001-0011-0001', 0, 0.71, 0, 0, 0, 0),
(114, '12-174001-0013-0001', 0, 1.14, 0, 0, 0, 0),
(115, '12-174001-0014-0001', 0, 1.10, 0, 0, 0, 0),
(116, '12-174001-0015-0002', 0, 2.22, 0, 0, 0, 0),
(117, '12-174001-0016-0001', 0, 0.58, 0, 0, 0, 0),
(118, '12-174001-0017-0001', 0, 1.28, 0, 0, 0, 0),
(119, '12-174001-0018-0001', 0, 0.65, 0, 0, 0, 0),
(120, '12-174001-0019-0000', 0, 0.00, 0, 0, 0, 0),
(121, '12-174001-0022-0004', 0, 4.22, 0, 0, 0, 0),
(122, '12-174001-0023-0001', 0, 1.44, 0, 0, 0, 0),
(123, '12-174001-0024-0000', 0, 0.00, 0, 0, 0, 0),
(126, '12-174001-0027-0001', 0, 1.00, 0, 0, 0, 0),
(128, '12-174001-0048-0002', 0, 2.00, 2000, 2000, 2000, 0),
(129, '13-174001-0015-0015', 0, 15.00, 7500, 7450, 7450, 0),
(130, '12-174001-0037-0003', 0, 3.00, 1500, 0, 0, 0),
(131, '13-174001-0018-0058', 0, 58.00, 29000, 29000, 29000, 0),
(132, '13-174001-0019-0029', 0, 29.00, 14500, 14500, 14500, 0),
(133, '13-174001-0020-0034', 0, 34.00, 17000, 16900, 16900, 0),
(134, '13-174001-0021-0005', 0, 5.00, 2500, 2500, 2500, 0),
(135, '13-174001-0026-0038', 0, 38.00, 19000, 19000, 19000, 0),
(136, '13-174001-0027-0030', 0, 30.00, 15000, 15000, 15000, 0),
(137, '13-174001-0024-0024', 0, 24.00, 12000, 12000, 12000, 0),
(138, '13-174001-0035-0031', 0, 31.00, 15500, 15400, 15400, 0),
(139, '13-174001-0038-0006', 0, 40.00, 20000, 20000, 20000, 0),
(140, '13-174001-0039-0004', 0, 0.00, 0, 0, 0, 0),
(141, '13-174001-0040-0005', 0, 0.00, 0, 0, 0, 0),
(142, '13-174001-0041-0031', 0, 0.00, 0, 0, 0, 0),
(143, '13-174001-0042-0044', 0, 44.00, 22000, 22000, 22000, 0),
(145, '13-174001-0031-0022', 0, 22.00, 11000, 11000, 11000, 0),
(146, '13-174001-0046-0009', 0, 12.00, 6000, 6000, 6000, 0),
(147, '13-174001-0048-0005', 0, 10.00, 5000, 5000, 5000, 0),
(148, '13-174001-0049-0002', 0, 0.00, 0, 0, 0, 0),
(149, '13-174001-0050-0005', 0, 0.00, 0, 0, 0, 0),
(150, '13-174001-0052-0013', 0, 7.00, 3500, 3500, 3500, 0),
(151, '13-174001-0055-0091', 0, 91.00, 45500, 45500, 45500, 0),
(152, '13-174001-0056-0033', 0, 33.00, 16500, 16500, 16500, 0),
(153, '13-174001-0045-0028', 0, 28.00, 55200, 55200, 55200, 0),
(154, '13-174001-0032-0015', 0, 15.00, 30000, 29800, 29800, 0),
(155, '13-174001-0023-0008', 0, 8.00, 4000, 3950, 3950, 0),
(156, '13-174001-0036-0005', 0, 5.00, 2500, 2500, 2500, 0),
(157, '13-174001-0030-0040', 0, 40.00, 20000, 19900, 19900, 0),
(158, '13-174001-0051-0003', 0, 3.00, 1500, 1450, 1450, 0),
(159, '13-174001-0053-0007', 0, 6.00, 3000, 3000, 3000, 0),
(160, '13-174001-0022-0007', 0, 7.00, 3500, 3500, 3500, 0),
(161, '13-174001-0028-0001', 0, 2.00, 1000, 950, 950, 0),
(162, '13-174001-0054-0003', 0, 2.00, 1000, 1000, 1000, 0),
(163, '13-174001-0033-0003', 0, 3.00, 1500, 1500, 1500, 0),
(164, '13-174001-0034-0004', 0, 4.00, 2000, 2000, 2000, 0),
(165, '15-174001-0001-0005', 0, 4.00, 20000, 20000, 20000, 0),
(166, '15-174001-0002-0004', 0, 4.00, 0, 0, 0, 0),
(167, '15-174001-0003-0003', 0, 3.00, 37500, 37500, 37500, 0),
(169, '15-174001-0004-0004', 0, 4.00, 0, 0, 0, 0),
(170, '15-174001-0005-0008', 0, 8.00, 0, 0, 0, 0),
(171, '15-174001-0007-0020', 0, 20.00, 50000, 50000, 50000, 0),
(172, '15-174001-0010-0010', 0, 10.00, 25000, 25000, 25000, 0),
(174, '15-174001-0012-0004', 0, 4.00, 10000, 10000, 10000, 0),
(175, '15-174001-0019-0002', 0, 2.00, 5000, 5000, 5000, 0),
(176, '15-174001-0013-0008', 0, 7.00, 135000, 135000, 135000, 0),
(177, '15-174001-0014-0008', 0, 7.00, 0, 0, 0, 0),
(178, '15-174001-0015-0015', 0, 15.00, 0, 0, 0, 0),
(179, '15-174001-0016-0021', 0, 21.00, 0, 0, 0, 0),
(180, '15-174001-0024-0004', 0, 4.00, 10000, 0, 0, 0),
(181, '15-174001-0017-0007', 0, 7.00, 30000, 30000, 30000, 0),
(182, '15-174001-0018-0005', 0, 5.00, 12500, 0, 0, 0),
(183, '15-174001-0020-0004', 0, 4.00, 17500, 17500, 17500, 0),
(184, '15-174001-0021-0003', 0, 3.00, 0, 0, 0, 0),
(185, '15-174001-0022-0021', 0, 20.00, 62500, 62500, 62500, 0),
(186, '15-174001-0023-0005', 0, 5.00, 0, 0, 0, 0),
(187, '15-174001-0025-0040', 0, 40.00, 100000, 100000, 100000, 0),
(188, '15-174001-0027-0015', 0, 15.00, 37500, 37500, 37500, 0),
(189, '15-174001-0028-0002', 0, 2.50, 31250, 31250, 31250, 0),
(190, '15-174001-0029-0010', 0, 10.00, 0, 0, 0, 0),
(191, '15-174001-0030-0005', 0, 5.00, 50000, 50000, 44000, 0),
(192, '15-174001-0031-0005', 0, 5.00, 0, 0, 0, 0),
(193, '15-174001-0032-0002', 0, 2.60, 0, 0, 0, 0),
(194, '15-174001-0033-0005', 0, 5.00, 0, 0, 0, 0),
(195, '15-174001-0036-0002', 0, 2.40, 6000, 6000, 6000, 0),
(196, '15-174001-0034-0010', 0, 10.00, 70000, 70000, 70000, 0),
(197, '15-174001-0035-0018', 0, 18.00, 0, 0, 0, 0),
(198, '15-174001-0037-0002', 0, 2.00, 5000, 5000, 5000, 0),
(199, '15-174001-0038-0012', 0, 12.00, 30000, 30000, 30000, 0),
(201, '15-174001-0033-0001', 0, 1.00, 2500, 2500, 2500, 0),
(202, '15-174001-0034-0002', 0, 2.00, 5000, 5000, 5000, 0),
(203, '15-174001-0035-0002', 0, 2.00, 5000, 5000, 5000, 0),
(204, '15-174001-0038-0017', 0, 17.00, 42500, 42500, 42500, 0),
(205, '15-174001-0042-0006', 0, 6.00, 15000, 15000, 15000, 0),
(206, '15-174001-0056-0007', 0, 0.00, 17500, 0, 0, 0),
(207, '15-174001-0037-0009', 0, 8.00, 20000, 20000, 20000, 0),
(208, '15-174001-0043-0053', 0, 52.00, 130000, 130000, 130000, 0),
(210, '15-174001-0054-0002', 0, 22.00, 55000, 55000, 55000, 0),
(212, '15-174001-0051-0012', 0, 0.00, 0, 0, 0, 0),
(213, '15-174001-0039-0010', 0, 10.00, 25000, 25000, 25000, 0),
(214, '15-174001-0040-0010', 0, 10.00, 25000, 25000, 25000, 0),
(215, '15-174001-0041-0010', 0, 10.00, 25000, 25000, 25000, 0),
(216, '15-174001-0048-0006', 0, 26.00, 65000, 65000, 65000, 0),
(217, '15-174001-0045-0021', 0, 21.00, 52500, 52500, 52500, 0),
(218, '15-174001-0046-0024', 0, 24.00, 60000, 60000, 60000, 0),
(219, '16-174001-0001-0027', 0, 27.00, 44982, 44982, 44982, 0),
(220, '17-174001-0001-0025', 0, 25.00, 47030, 47030, 47030, 0),
(221, '17-174001-0002-0016', 0, 16.00, 0, 0, 0, 0),
(222, '17-174001-0003-0049', 0, 49.00, 56250, 56250, 56250, 0),
(223, '18-174000-0004-0010', 0, 10.00, 2040, 2040, 2040, 0),
(224, '18-174000-0003-0010', 0, 10.00, 2040, 2040, 2040, 0),
(225, '18-174000-0009-0030', 0, 30.00, 37206, 40190, 37206, 0),
(226, '18-174000-0027-0040', 0, 40.00, 47474, 51290, 47474, 0),
(227, '18-174000-0268-0002', 0, 1.82, 5087, 5087, 5087, 0),
(228, '18-174000-0267-0001', 0, 1.35, 673, 673, 673, 0),
(229, '18-174000-0266-0001', 0, 1.32, 662, 662, 662, 0),
(231, '18-174000-0307-0013', 0, 15.45, 43260, 43260, 43260, 0),
(232, '18-174000-0001-0006', 0, 6.00, 1224, 1224, 1224, 0),
(233, '18-174000-0002-0004', 0, 4.00, 816, 816, 816, 0),
(234, '11-174001-0016-0041', 0, 41.50, 0, 0, 0, 0),
(235, '20-174000-0001-0012', 0, 12.00, 2448, 2800, 2448, 0),
(236, '20-174000-0008-0001', 0, 1.00, 1250, 1250, 1250, 0),
(237, '20-174000-0009-0006', 0, 6.00, 7500, 7500, 7500, 0),
(242, '20-174000-0012-0002', 0, 2.00, 2500, 2500, 2500, 0),
(243, '20-174000-0013-0004', 0, 4.00, 5000, 5000, 5000, 0),
(244, '20-174000-0014-0008', 0, 8.00, 10000, 10000, 10000, 0),
(245, '20-174000-0015-0003', 0, 3.00, 3750, 3750, 3750, 0),
(246, '20-174000-0016-0002', 0, 2.00, 2500, 2500, 2500, 0),
(247, '11-174001-0019-0009', 0, 9.00, 4500, 4500, 4500, 0),
(250, '12-174001-0035-0013', 0, 12.00, 240, 240, 240, 0),
(252, '12-174001-0049-0001', 0, 1.00, 1500, 1500, 1500, 0),
(253, '13-174001-0025-0025', 0, 25.00, 12500, 12500, 12500, 0),
(254, '13-174001-0043-0094', 0, 94.00, 47000, 46950, 46950, 0),
(255, '13-174001-0044-0030', 0, 30.00, 60600, 60600, 60600, 0),
(256, '13-174001-0037-0017', 0, 17.00, 8500, 8500, 8500, 0),
(258, '13-174001-0029-0001', 0, 0.00, 0, 0, 0, NULL),
(259, '13-174001-0047-0004', 0, 0.00, 0, 0, 0, NULL),
(260, '15-174001-0006-0001', 0, 1.50, 16250, 16250, 16250, NULL),
(261, '15-174001-0008-0003', 0, 3.00, 0, 0, 0, NULL),
(262, '15-174001-0009-0002', 0, 2.00, 0, 0, 0, NULL),
(263, '15-174001-0026-0006', 0, 5.00, 12500, 12500, 12500, NULL),
(264, '15-174001-0039-0006', 0, 6.00, 15000, 15000, 15000, NULL),
(265, '15-174001-0041-0006', 0, 6.00, 15000, 15000, 15000, NULL),
(266, '15-174001-0036-0003', 0, 3.00, 7500, 7500, 7500, NULL),
(268, '18-174000-0309-0013', 0, 13.16, 36848, 36848, 32900, NULL),
(270, '18-174000-0310-0004', 0, 11.39, 31892, 31892, 28475, NULL),
(271, '18-174000-0005-0002', 0, 15.00, 3060, 3060, 3060, NULL),
(272, '18-174000-0011-0007', 0, 12.00, 2448, 2448, 2448, NULL),
(273, '18-174000-0014-0001', 0, 0.50, 102, 102, 102, NULL),
(274, '18-174000-0035-0000', 0, 0.50, 102, 102, 102, NULL),
(275, '18-174000-0029-0001', 0, 1.00, 204, 204, 204, NULL),
(276, '18-174000-0018-0001', 0, 1.75, 357, 357, 357, NULL),
(277, '18-174000-0020-0004', 0, 8.83, 1801, 1801, 1801, NULL),
(278, '18-174000-0024-0000', 0, 1.48, 302, 302, 302, NULL),
(279, '18-174000-0028-0001', 0, 1.20, 245, 245, 245, NULL),
(280, '18-174000-0026-0001', 0, 1.20, 245, 245, 245, NULL),
(281, '18-174000-0017-0001', 0, 1.00, 204, 204, 204, NULL),
(282, '18-174000-0030-0000', 0, 0.45, 92, 92, 92, NULL),
(283, '18-174000-0032-0001', 0, 1.48, 302, 302, 302, NULL),
(284, '18-174000-0033-0000', 0, 0.10, 20, 20, 20, NULL),
(285, '18-174000-0034-0003', 0, 2.68, 547, 547, 547, NULL),
(286, '18-174000-0036-0000', 0, 0.08, 16, 16, 16, NULL),
(287, '18-174000-0037-0002', 0, 1.89, 386, 386, 386, NULL),
(288, '18-174000-0038-0001', 0, 1.28, 261, 261, 261, NULL),
(289, '18-174000-0039-0008', 0, 7.00, 1428, 1428, 1428, NULL),
(290, '18-174000-0010-0005', 0, 5.00, 1020, 1020, 1020, NULL),
(291, '18-174000-0022-0028', 0, 28.00, 7140, 7140, 7140, NULL),
(292, '18-174000-0023-0007', 0, 7.00, 0, 0, 0, NULL),
(293, '18-174000-0015-0000', 0, 0.58, 118, 118, 118, NULL),
(294, '18-174000-0016-0000', 0, 0.00, 0, 0, 0, NULL),
(295, '18-174000-0019-0001', 0, 0.00, 0, 0, 0, NULL),
(296, '18-174000-0021-0005', 0, 0.00, 0, 0, 0, NULL),
(297, '18-174000-0031-0000', 0, 0.00, 0, 0, 0, NULL),
(298, '18-174000-0025-0001', 0, 0.00, 0, 0, 0, NULL),
(299, '18-174000-0006-0002', 0, 0.00, 0, 0, 0, NULL),
(300, '18-174000-0007-0005', 0, 0.00, 0, 0, 0, NULL),
(301, '18-174000-0008-0006', 0, 0.00, 0, 0, 0, NULL),
(302, '18-174000-0012-0001', 0, 0.00, 0, 0, 0, NULL),
(304, '18-174000-0308-0002', 0, 0.00, 0, 0, 0, NULL),
(305, '18-174000-0311-0008', 0, 0.00, 0, 0, 0, NULL),
(306, '18-174000-0013-0004', 0, 0.00, 0, 0, 0, NULL),
(307, '20-174000-0010-0007', 0, 10.00, 8750, 8750, 8750, NULL),
(308, '20-174000-0011-0007', 0, 7.00, 8750, 8750, 8750, NULL),
(309, '20-174000-0002-0007', 0, 7.00, 8750, 8750, 8750, NULL),
(310, '20-174000-0003-0007', 0, 7.00, 8750, 8750, 8750, NULL),
(311, '20-174000-0004-0006', 0, 3.00, 7500, 7500, 7500, NULL),
(312, '15-174001-0012-0000', 0, 0.20, 12500, 12500, 12500, NULL),
(313, '15-174001-0020-0000', 0, 0.20, 0, 0, 0, NULL),
(314, '15-174001-0021-0001', 0, 1.00, 0, 0, 0, NULL),
(315, '15-174001-0026-0001', 0, 1.10, 0, 0, 0, NULL),
(316, '15-174001-0013-0000', 0, 0.20, 0, 0, 0, NULL),
(317, '15-174001-0014-0001', 0, 0.20, 0, 0, 0, NULL),
(318, '15-174001-0015-0000', 0, 0.50, 0, 0, 0, NULL),
(319, '15-174001-0016-0001', 0, 0.90, 0, 0, 0, NULL),
(320, '15-174001-0001-0000', 0, 0.10, 0, 0, 0, NULL),
(321, '15-174001-0002-0002', 0, 1.50, 0, 0, 0, NULL),
(323, '15-174001-0008-0000', 0, 0.10, 0, 0, 0, NULL),
(324, '15-174001-0009-0000', 0, 0.20, 0, 0, 0, NULL),
(325, '15-174001-0010-0001', 0, 0.80, 0, 0, 0, NULL),
(326, '15-174001-0027-0000', 0, 0.10, 0, 0, 0, NULL),
(327, '15-174001-0028-0001', 0, 1.10, 0, 0, 0, NULL),
(328, '15-174001-0029-0000', 0, 0.00, 0, 0, 0, NULL),
(329, '15-174001-0023-0007', 0, 7.10, 0, 0, 0, NULL),
(330, '15-174001-0024-0001', 0, 0.80, 0, 0, 0, NULL),
(331, '15-174001-0003-0001', 0, 0.90, 0, 0, 0, NULL),
(332, '15-174001-0004-0001', 0, 1.50, 0, 0, 0, NULL),
(333, '15-174001-0005-0001', 0, 1.00, 0, 0, 0, NULL),
(334, '15-174001-0022-0001', 0, 1.50, 0, 0, 0, NULL),
(335, '15-174001-0018-0000', 0, 0.20, 0, 0, 0, NULL),
(336, '15-174001-0019-0001', 0, 0.90, 0, 0, 0, NULL),
(337, '15-174001-0031-0000', 0, 0.00, 0, 0, 0, NULL),
(339, '15-174001-0017-0000', 0, 0.30, 0, 0, 0, NULL),
(340, '15-174001-0025-0000', 0, 0.10, 0, 0, 0, NULL),
(342, '15-174001-0006-0000', 0, 0.00, 0, 0, 0, NULL),
(343, '15-174001-0040-0006', 0, 7.00, 17500, 17500, 17500, NULL),
(344, '15-174001-0044-0006', 0, 6.00, 15000, 15000, 15000, NULL),
(345, '15-174001-0047-0005', 0, 0.00, 0, 0, 0, NULL),
(346, '15-174001-0049-0007', 0, 0.00, 0, 0, 0, NULL),
(350, '15-174001-0671-0003', 0, 0.00, 0, 0, 0, NULL),
(352, '11-174001-0009-0030', 0, 30.00, 15000, 15000, 15000, NULL),
(354, '15-174001-0007-0001', 0, 0.90, 0, 0, 0, NULL),
(355, '15-174001-0011-0001Ba', 0, 0.60, 0, 0, 0, NULL),
(356, '15-174001-0011-0001Bb', 0, 1.00, 2500, 2500, 2500, NULL),
(357, '15-174001-0011-0001Bba', 0, 1.00, 0, 0, 0, NULL),
(358, '15-174001-0011-0001Bbb', 0, 0.60, 0, 0, 0, NULL),
(359, '21-174000-0003-0010', 0, 10.00, 2040, 2200, 2040, NULL),
(360, '0TCYtI2YTu', 0, 8.00, 1000, 0, 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `date_ticinspection_tbl`
--

CREATE TABLE `date_ticinspection_tbl` (
  `date_inspection_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `date_request` date NOT NULL,
  `date_inspected` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `date_turnover_tbl`
--

CREATE TABLE `date_turnover_tbl` (
  `turn_over_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `date_turnover` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `date_turnover_tbl`
--

INSERT INTO `date_turnover_tbl` (`turn_over_id`, `unique_code`, `date_turnover`) VALUES
(3, '17-174001-0001-0025', '2021-05-03'),
(4, '17-174001-0002-0016', '2021-05-03'),
(5, '17-174001-0003-0049', '2021-05-03'),
(6, '18-174000-0009-0030', '2022-08-23'),
(7, '18-174000-0027-0040', '2022-08-23'),
(8, '18-174000-0268-0002', '2022-08-23'),
(9, '18-174000-0267-0001', '2022-08-23'),
(10, '18-174000-0266-0001', '2022-08-23'),
(11, '18-174000-0307-0013', '2022-08-23'),
(12, '18-174000-0310-0004', '2022-08-23');

-- --------------------------------------------------------

--
-- Table structure for table `date_validation_report`
--

CREATE TABLE `date_validation_report` (
  `validation_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `date_validation` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `date_validation_report`
--

INSERT INTO `date_validation_report` (`validation_id`, `unique_code`, `date_validation`) VALUES
(4, '11-174001-0001-0034', '2015-01-15'),
(5, '11-174001-0012-0003', '2015-01-15'),
(6, '11-174001-0013-0003', '2015-01-15'),
(7, '11-174001-0014-0004', '2015-01-15'),
(8, '11-174001-0017-0009', '2015-01-15'),
(9, '11-174001-0018-0003', '2015-01-15'),
(10, '11-174001-0024-0003', '2015-01-15'),
(11, '11-174001-0025-0003', '2015-01-15'),
(12, '11-174001-0026-0004', '2015-01-15'),
(13, '11-174001-0027-0003', '2015-01-15'),
(14, '11-174001-0028-0003', '2015-01-15'),
(15, '11-174001-0029-0003', '2015-01-15'),
(16, '11-174001-0030-0003', '2015-01-15'),
(17, '11-174001-0031-0003', '2015-01-15'),
(19, '11-174001-0034-0003', '2015-01-15'),
(20, '11-174001-0035-0003', '2015-01-15'),
(21, '11-174001-0037-0003', '2015-01-15'),
(22, '11-174001-0038-0003', '2015-01-15'),
(23, '11-174001-0039-0003', '2015-01-15'),
(24, '11-174001-0040-0002', '2015-01-15'),
(25, '11-174001-0041-0003', '2015-01-15'),
(26, '11-174001-0042-0003', '2015-01-15'),
(27, '11-174001-0006-0003', '2015-01-15'),
(28, '11-174001-0002-0008', '2015-01-15'),
(29, '11-174001-0003-0002', '2015-01-15'),
(30, '11-174001-0004-0012', '2015-01-15'),
(31, '11-174001-0005-0007', '2015-01-15'),
(32, '11-174001-0006-0003', '2015-01-15'),
(33, '11-174001-0043-0003', '2015-01-15'),
(34, '11-174001-0007-0001', '2015-01-15'),
(35, '11-174001-0008-0002', '2015-01-15'),
(38, '11-174001-0010-0040', '2015-01-15'),
(39, '11-174001-0015-0018', '2015-01-15'),
(40, '11-174001-0020-0010', '2015-01-15'),
(41, '11-174001-0021-0012', '2015-01-15'),
(42, '11-174001-0022-0005', '2015-01-15'),
(43, '11-174001-0023-0006', '2015-01-15'),
(44, '11-174001-0032-0005', '2015-01-15'),
(45, '11-174001-0044-0003', '2015-01-15'),
(46, '12-174001-0001-0014', '2016-02-22'),
(47, '12-174001-0002-0001', '2016-02-22'),
(48, '12-174001-0003-0007', '2016-02-22'),
(49, '12-174001-0004-0003', '2016-02-22'),
(50, '12-174001-0005-0002', '2016-02-22'),
(51, '12-174001-0006-0001', '2016-02-22'),
(52, '12-174001-0007-0004', '2016-02-22'),
(53, '12-174001-0008-0000', '2016-02-22'),
(54, '12-174001-0009-0001', '2016-02-22'),
(55, '12-174001-0010-0000', '2016-02-22'),
(56, '12-174001-0011-0001', '2016-02-22'),
(57, '12-174001-0013-0001', '2016-02-22'),
(58, '12-174001-0014-0001', '2016-02-22'),
(59, '12-174001-0015-0002', '2016-02-22'),
(60, '12-174001-0016-0001', '2016-02-22'),
(61, '12-174001-0017-0001', '2016-02-22'),
(62, '12-174001-0018-0001', '2016-02-22'),
(63, '12-174001-0019-0000', '2016-02-22'),
(64, '12-174001-0022-0004', '2016-02-22'),
(65, '12-174001-0023-0001', '2016-02-22'),
(66, '12-174001-0024-0000', '2016-02-22'),
(67, '12-174001-0027-0001', '2016-02-22'),
(68, '12-174001-0012-0050', '2016-02-22'),
(69, '12-174001-0020-0045', '2016-02-22'),
(70, '12-174001-0021-0027', '2016-02-22'),
(71, '12-174001-0025-0011', '2016-02-22'),
(72, '12-174001-0026-0031', '2016-02-22'),
(73, '12-174001-0029-0020', '2016-02-22'),
(74, '12-174001-0028-0011', '2016-02-22'),
(75, '12-174001-0030-0003', '2016-02-22'),
(76, '12-174001-0031-0003', '2016-02-22'),
(77, '12-174001-0032-0005', '2016-02-22'),
(78, '12-174001-0038-0001', '2016-02-22'),
(79, '12-174001-0048-0002', '2016-02-22'),
(80, '13-174001-0005-0004', '2016-02-22'),
(81, '13-174001-0016-0018', '2016-02-22'),
(82, '13-174001-0008-0006', '2016-02-22'),
(83, '13-174001-0009-0006', '2016-02-22'),
(84, '13-174001-0012-0005', '2016-02-22'),
(85, '13-174001-0014-0027', '2016-02-22'),
(86, '13-174001-0015-0015', '2016-02-22'),
(87, '13-174001-0017-0010', '2016-02-22'),
(88, '11-174001-0011-0030', '2015-01-15'),
(89, '12-174001-0033-0004', '2016-02-22'),
(90, '12-174001-0034-0006', '2016-02-22'),
(91, '12-174001-0036-0005', '2016-02-22'),
(92, '12-174001-0037-0003', '2016-02-22'),
(93, '12-174001-0039-0005', '2016-02-22'),
(94, '12-174001-0040-0007', '2016-02-22'),
(95, '12-174001-0041-0007', '2016-02-22'),
(96, '12-174001-0042-0001', '2016-02-22'),
(97, '12-174001-0043-0003', '2016-02-22'),
(98, '12-174001-0044-0005', '2016-02-22'),
(99, '12-174001-0045-0002', '2016-02-22'),
(100, '12-174001-0046-0002', '2016-02-22'),
(101, '12-174001-0047-0005', '2016-02-22'),
(102, '13-174001-0018-0058', '2016-02-22'),
(103, '13-174001-0019-0029', '2016-02-22'),
(104, '13-174001-0020-0034', '2016-02-22'),
(105, '13-174001-0021-0005', '2016-02-22'),
(106, '13-174001-0026-0038', '2016-02-22'),
(107, '13-174001-0027-0030', '2016-02-22'),
(108, '13-174001-0024-0024', '2016-02-22'),
(109, '13-174001-0035-0031', '2016-02-22'),
(110, '13-174001-0038-0006', '2016-02-22'),
(111, '13-174001-0039-0004', '2016-02-22'),
(112, '13-174001-0040-0005', '2016-02-22'),
(113, '13-174001-0041-0031', '2016-02-22'),
(114, '13-174001-0042-0044', '2016-02-22'),
(115, '13-174001-0031-0022', '2016-02-22'),
(116, '13-174001-0046-0009', '2016-02-22'),
(117, '13-174001-0048-0005', '2016-02-22'),
(118, '13-174001-0013-0009', '2016-02-22'),
(119, '13-174001-0052-0013', '2016-02-22'),
(120, '13-174001-0055-0091', '2016-02-22'),
(121, '13-174001-0056-0033', '2016-02-22'),
(122, '13-174001-0006-0043', '2016-02-22'),
(123, '13-174001-0007-0002', '2016-02-22'),
(124, '13-174001-0045-0028', '2016-02-22'),
(125, '13-174001-0032-0015', '2016-02-22'),
(126, '13-174001-0003-0005', '2016-02-22'),
(127, '13-174001-0004-0014', '2016-02-22'),
(128, '13-174001-0010-0005', '2016-02-22'),
(129, '13-174001-0011-0004', '2016-02-22'),
(130, '13-174001-0001-0001', '2016-02-22'),
(131, '13-174001-0002-0001', '2016-02-22'),
(132, '13-174001-0023-0008', '2016-02-22'),
(133, '13-174001-0036-0005', '2016-02-22'),
(134, '13-174001-0030-0040', '2016-02-22'),
(135, '13-174001-0051-0003', '2016-02-22'),
(136, '13-174001-0053-0007', '2016-02-22'),
(137, '13-174001-0022-0007', '2016-02-22'),
(138, '13-174001-0028-0001', '2016-02-22'),
(139, '13-174001-0054-0003', '2016-02-22'),
(140, '13-174001-0033-0003', '2016-02-22'),
(141, '13-174001-0034-0004', '2016-02-22'),
(142, '15-174001-0001-0005', '2017-12-15'),
(143, '15-174001-0002-0004', '2017-12-15'),
(144, '15-174001-0004-0004', '2017-12-15'),
(145, '15-174001-0007-0020', '2017-12-15'),
(146, '15-174001-0010-0010', '2017-12-15'),
(147, '15-174001-0012-0004', '2017-12-15'),
(148, '15-174001-0013-0008', '2017-12-15'),
(149, '15-174001-0014-0008', '2017-12-15'),
(150, '15-174001-0015-0015', '2017-12-15'),
(151, '15-174001-0016-0021', '2017-12-15'),
(152, '15-174001-0024-0004', '2017-12-15'),
(153, '15-174001-0017-0007', '2017-12-15'),
(154, '15-174001-0018-0005', '2017-12-15'),
(155, '15-174001-0020-0004', '2017-12-15'),
(156, '15-174001-0021-0003', '2017-12-15'),
(157, '15-174001-0022-0021', '2017-12-15'),
(158, '15-174001-0023-0005', '2017-12-15'),
(159, '15-174001-0025-0040', '2017-12-15'),
(160, '15-174001-0027-0015', '2017-12-15'),
(161, '15-174001-0028-0002', '2017-12-15'),
(162, '15-174001-0029-0010', '2017-12-15'),
(163, '15-174001-0030-0005', '2017-12-15'),
(164, '15-174001-0031-0005', '2017-12-15'),
(165, '15-174001-0032-0002', '2017-12-15'),
(166, '15-174001-0033-0005', '2017-12-15'),
(167, '15-174001-0036-0002', '2017-12-15'),
(168, '15-174001-0034-0010', '2017-12-15'),
(169, '15-174001-0035-0018', '2017-12-15'),
(170, '15-174001-0037-0002', '2017-12-15'),
(171, '15-174001-0038-0012', '2017-12-15'),
(173, '15-174001-0033-0001', '2017-12-15'),
(174, '15-174001-0034-0002', '2017-05-22'),
(175, '15-174001-0035-0002', '2017-05-22'),
(176, '15-174001-0038-0017', '2018-05-22'),
(177, '15-174001-0042-0006', '2018-05-22'),
(178, '15-174001-0056-0007', '2017-12-15'),
(179, '15-174001-0043-0053', '2018-05-22'),
(181, '15-174001-0054-0002', '2018-05-22'),
(182, '15-174001-0051-0012', '2018-05-22'),
(183, '15-174001-0039-0010', '2018-05-22'),
(184, '15-174001-0040-0010', '2018-05-22'),
(185, '15-174001-0041-0010', '2018-05-22'),
(186, '15-174001-0048-0006', '2018-05-22'),
(187, '15-174001-0045-0021', '2018-05-22'),
(188, '16-174001-0001-0027', '2018-11-18'),
(189, '17-174001-0001-0025', '2020-11-18'),
(190, '17-174001-0003-0049', '2020-11-20'),
(191, '18-174000-0004-0010', '2020-12-15'),
(192, '11-174001-0016-0041', '2015-01-23'),
(193, '11-174001-0019-0009', '2015-01-21'),
(194, '12-174001-0035-0013', '2016-01-26'),
(195, '12-174001-0049-0001', '2016-02-22'),
(196, '13-174001-0025-0025', '2016-02-22'),
(197, '13-174001-0043-0094', '2016-02-22'),
(198, '13-174001-0044-0030', '2016-02-22'),
(199, '13-174001-0037-0017', '2016-02-22'),
(200, '11-174001-0036-0002', '2015-01-01'),
(201, '15-174001-0006-0001', '2017-12-03'),
(202, '15-174001-0008-0003', '2017-12-03'),
(203, '15-174001-0009-0002', '2017-12-03'),
(204, '15-174001-0026-0006', '2017-12-03'),
(205, '15-174001-0039-0006', '2017-12-03'),
(206, '15-174001-0041-0006', '2017-12-03'),
(207, '15-174001-0036-0003', '2018-05-22'),
(208, '15-174001-0003-0003', '2017-12-19'),
(209, '15-174001-0005-0008', '2017-12-19'),
(210, '15-174001-0044-0006', '2018-05-15');

-- --------------------------------------------------------

--
-- Table structure for table `disbursement_2nd`
--

CREATE TABLE `disbursement_2nd` (
  `disbursement_2nd_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `cheque_num` int(11) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `date_issued` date DEFAULT NULL,
  `date_released` date DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `retention_fee` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) DEFAULT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) DEFAULT NULL,
  `dv_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disbursement_2nd`
--

INSERT INTO `disbursement_2nd` (`disbursement_2nd_id`, `unique_code`, `cheque_num`, `payment`, `date_issued`, `date_released`, `total_cost`, `retention_fee`, `ob_no`, `ob_date`, `dv_no`, `dv_date`) VALUES
(1, '22-174000-0001-0012', 141575, 157500, '2022-09-30', '2022-10-12', 210000, 21000, 'CO-22-06-583', '2022-06-29', '22-09-1199F', '2022-09-30'),
(5, '22-174000-0004-0020', 141574, 165000, '2022-09-30', '2022-11-03', 220000, 22000, 'C0-22-06-582', '2022-06-29', 'Unavailable', '2023-11-09'),
(6, '22-174000-0002-0011', 141447, 144375, '2022-06-30', '2022-07-29', 192500, 19250, 'CO-22-06-584', '2022-06-29', 'Unavailable', '2023-11-10');

-- --------------------------------------------------------

--
-- Table structure for table `disbursement_3rd_mf`
--

CREATE TABLE `disbursement_3rd_mf` (
  `disbursement_3rd_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `cheque_num` int(11) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `date_issued` date DEFAULT NULL,
  `date_released` date DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) DEFAULT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) DEFAULT NULL,
  `dv_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disbursement_3rd_mf`
--

INSERT INTO `disbursement_3rd_mf` (`disbursement_3rd_id`, `unique_code`, `cheque_num`, `payment`, `date_issued`, `date_released`, `total_cost`, `ob_no`, `ob_date`, `dv_no`, `dv_date`) VALUES
(1, '4BmzLn2Ap0', 141567, 15300, '2022-09-29', '2022-10-07', 102000, 'C0-22-08-957', '2022-08-31', '22-09-1109', '2022-09-29'),
(5, '12000101-11-01', 141558, 25500, '2022-09-27', '2022-10-04', 170000, 'C0-22-08-959', '2023-08-31', '22-09-1065', '2022-09-21'),
(6, 'lTKYa8jTHd', 141559, 14025, '2022-09-27', '2022-10-18', 93500, 'C0-22-08-956', '2022-08-31', '22-09-1064', '2022-09-21');

-- --------------------------------------------------------

--
-- Table structure for table `disbursement_76_tbl`
--

CREATE TABLE `disbursement_76_tbl` (
  `disbursement_76_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `cheque_num` int(11) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `date_issued` date DEFAULT NULL,
  `date_released` date DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `retention_fee` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) DEFAULT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) DEFAULT NULL,
  `dv_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disbursement_76_tbl`
--

INSERT INTO `disbursement_76_tbl` (`disbursement_76_id`, `unique_code`, `cheque_num`, `payment`, `date_issued`, `date_released`, `total_cost`, `retention_fee`, `ob_no`, `ob_date`, `dv_no`, `dv_date`) VALUES
(1, '22-174000-0001-0012', 143066, 54468, '2023-03-03', '2023-03-24', 77520, 7752, 'C0-22-08-957', '2022-08-31', '23-03-220', '2023-03-10'),
(3, '22-174000-0004-0020', 143016, 91500, '2023-01-31', '2023-03-07', 130000, 13000, 'C0-22-08-959', '2023-08-31', '22-12-1618', '2022-12-29'),
(4, '22-174000-0002-0011', 143065, 49929, '2023-03-13', '2023-03-17', 71060, 7106, 'C0-22-08-956', '2022-08-31', '23-03-215', '2023-03-10');

-- --------------------------------------------------------

--
-- Table structure for table `disbursement_tbl`
--

CREATE TABLE `disbursement_tbl` (
  `disbursement_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `cheque_num` int(11) NOT NULL,
  `payment` int(11) NOT NULL,
  `date_issued` date NOT NULL,
  `date_released` date NOT NULL,
  `fund` varchar(100) NOT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) NOT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) NOT NULL,
  `dv_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disbursement_tbl`
--

INSERT INTO `disbursement_tbl` (`disbursement_id`, `unique_code`, `cheque_num`, `payment`, `date_issued`, `date_released`, `fund`, `total_cost`, `ob_no`, `ob_date`, `dv_no`, `dv_date`) VALUES
(1, '22-174000-0001-0012', 141434, 31500, '2022-06-30', '2022-07-22', 'Regular fund', 210000, 'CO-22-06-583', '2022-06-29', '22-06-667', '2022-06-30'),
(2, '22-174000-0003-0032', 141437, 48000, '2022-06-30', '2022-07-19', 'Regular fund', 320000, 'C0-22-06-580', '2022-06-29', '22-06-665', '2022-06-30'),
(4, '22-174000-0004-0020', 141436, 33000, '2022-06-30', '2022-07-13', 'Regular fund', 220000, 'C0-22-06-582', '2022-06-29', '22-06-666', '2022-06-30'),
(5, '22-174000-0002-0011', 141433, 28875, '2022-06-30', '2022-08-19', 'Regular fund', 192500, 'CO-22-06-584', '2022-06-29', '22-6-668', '2022-06-30'),
(6, '21-174000-0001-0020/ 21-174000-0002-0050', 137148, 220950, '2021-03-26', '2021-03-26', 'Regular fund', 878000, 'C0-21-03-17', '2021-03-22', '21-03-243', '2021-03-25');

-- --------------------------------------------------------

--
-- Table structure for table `disbursement_yearend_tbl`
--

CREATE TABLE `disbursement_yearend_tbl` (
  `disbursement_yearend_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `cheque_num` int(11) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `date_issued` date DEFAULT NULL,
  `date_released` date DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `retention_fee` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) DEFAULT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) DEFAULT NULL,
  `dv_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disbursement_yearend_tbl`
--

INSERT INTO `disbursement_yearend_tbl` (`disbursement_yearend_id`, `unique_code`, `cheque_num`, `payment`, `date_issued`, `date_released`, `total_cost`, `retention_fee`, `ob_no`, `ob_date`, `dv_no`, `dv_date`) VALUES
(1, '22-174000-0001-0012', 145114, 22032, '2022-04-19', '2022-05-05', 24480, 2448, 'C0-22-08-957', '2022-08-31', '23-03-366', '2023-03-31'),
(2, '22-174000-0004-0020', 143095, 36000, '2023-03-03', '2023-06-06', 40000, 4000, 'C0-22-08-959', '2022-08-31', '23-03-368', '2023-03-31'),
(3, '22-174000-0002-0011', 145115, 20196, '2023-04-19', '2023-04-28', 22440, 2244, 'C0-22-08-956', '2022-08-31', '23-03-369', '2023-03-31');

-- --------------------------------------------------------

--
-- Table structure for table `disturbances_tbl`
--

CREATE TABLE `disturbances_tbl` (
  `disturbances_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `date_occurence` date NOT NULL,
  `area_damaged` int(11) NOT NULL,
  `type_damage` varchar(100) NOT NULL,
  `status` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `disturbances_tbl`
--

INSERT INTO `disturbances_tbl` (`disturbances_id`, `unique_code`, `date_occurence`, `area_damaged`, `type_damage`, `status`) VALUES
(1, '22-174000-0001-0012', '2023-11-22', 12, 'Typhoon', 'x'),
(2, '11-174001-0003-0002', '2023-11-29', 1, 'force majeure', 'x'),
(3, '11-174001-0005-0007', '2023-11-29', 5, 'force majeure', 'x'),
(4, '11-174001-0043-0003', '2023-11-29', 1, 'force majeure', 'x'),
(5, '11-174001-0020-0010', '2023-11-29', 10, 'Fire Incidence', 'x'),
(6, '12-174001-0028-0011', '2023-11-30', 4, 'Typhoon', 'x'),
(7, '12-174001-0031-0003', '2023-11-30', 3, 'Typhoon', 'x'),
(8, '12-174001-0032-0005', '2023-11-30', 5, 'Typhoon', 'x'),
(9, '12-174001-0038-0001', '2023-11-30', 1, 'Typhoon', 'x'),
(10, '12-174001-0048-0002', '2023-11-30', 2, 'force majeure', 'x'),
(11, '12-174001-0033-0004', '2023-12-05', 4, 'Typhoon', 'x'),
(12, '12-174001-0037-0003', '2023-12-05', 1, 'Typhoon', 'x'),
(13, '12-174001-0042-0001', '2023-12-05', 1, 'Typhoon', 'x'),
(14, '12-174001-0047-0005', '2023-12-05', 2, 'force majeure', 'x'),
(15, '13-174001-0013-0009', '2023-12-06', 8, 'typhoon', 'x'),
(16, '13-174001-0052-0013', '2023-12-06', 6, 'typhoon', 'x'),
(17, '13-174001-0006-0043', '2023-12-06', 3, 'typhoon', 'x'),
(18, '13-174001-0032-0015', '2023-12-06', 3, 'typhoon', 'x'),
(19, '13-174001-0003-0005', '2023-12-06', 5, 'typhoon', 'x'),
(20, '13-174001-0004-0014', '2023-12-06', 12, 'typhoon', 'x'),
(21, '13-174001-0010-0005', '2023-12-06', 3, 'typhoon', 'x'),
(22, '13-174001-0011-0004', '2023-12-06', 2, 'typhoon', 'x'),
(23, '13-174001-0002-0001', '2023-12-06', 1, 'typhoon', 'x'),
(24, '13-174001-0023-0008', '2023-12-06', 8, 'typhoon', 'x'),
(25, '13-174001-0036-0005', '2023-12-06', 5, 'typhoon', 'x'),
(26, '13-174001-0030-0040', '2023-12-07', 39, 'typhoon', 'x'),
(27, '13-174001-0033-0003', '2023-12-07', 0, 'typhoon', 'x'),
(28, '13-174001-0034-0004', '2023-12-07', 4, 'typhoon', 'x'),
(29, '15-174001-0001-0005', '2023-12-07', 4, 'typhoon', 'x'),
(30, '15-174001-0007-0020', '2024-01-11', 17, 'typhoon', 'x'),
(31, '15-174001-0010-0010', '2024-01-11', 8, 'typhoon', 'x'),
(32, '15-174001-0012-0004', '2024-01-12', 4, 'typhoon', 'x'),
(33, '15-174001-0013-0008', '2024-01-12', 22, 'typhoon', 'x'),
(34, '15-174001-0024-0004', '2024-01-12', 2, 'typhoon', 'x'),
(35, '15-174001-0017-0007', '2024-01-12', 9, 'typhoon', 'x'),
(36, '15-174001-0020-0004', '2024-01-12', 5, 'typhoon', 'x'),
(37, '15-174001-0022-0021', '2024-01-12', 20, 'typhoon', 'x'),
(38, '15-174001-0023-0005', '2024-01-12', 1, 'typhoon', 'x'),
(39, '15-174001-0025-0040', '2024-01-12', 26, 'typhoon', 'x'),
(40, '15-174001-0027-0015', '2024-01-12', 14, 'typhoon', 'x'),
(41, '15-174001-0028-0002', '2024-01-12', 11, 'typhoon', 'x'),
(42, '15-174001-0030-0005', '2024-01-12', 1, 'typhoon', 'x'),
(43, '15-174001-0031-0005', '2024-01-12', 1, 'typhoon', 'x'),
(44, '15-174001-0032-0002', '2024-01-12', 2, 'typhoon', 'x'),
(45, '15-174001-0033-0005', '2024-01-12', 1, 'typhoon', 'x'),
(46, '15-174001-0036-0002', '2024-01-12', 1, 'typhoon', 'x'),
(47, '15-174001-0034-0010', '2024-01-12', 7, 'typhoon', 'x'),
(48, '15-174001-0035-0018', '2024-01-12', 12, 'typhoon', 'x'),
(49, '15-174001-0037-0002', '2024-01-12', 1, 'typhoon', 'x'),
(50, '15-174001-0035-0002', '2024-01-15', 1, 'typhoon', 'x'),
(51, '15-174001-0038-0017', '2024-01-15', 15, 'typhoon', 'x'),
(52, '15-174001-0042-0006', '2024-01-15', 4, 'typhoon', 'x'),
(53, '15-174001-0056-0007', '2024-01-15', 4, 'typhoon', 'x'),
(54, '15-174001-0043-0053', '2024-01-15', 34, 'typhoon', 'x'),
(56, '15-174001-0054-0002', '2024-01-15', 10, 'typhoon', 'x'),
(57, '15-174001-0039-0010', '2024-01-15', 7, 'typhoon', 'x'),
(58, '15-174001-0040-0010', '2024-01-15', 6, 'typhoon', 'x'),
(59, '15-174001-0041-0010', '2024-01-15', 6, 'typhoon', 'x'),
(60, '15-174001-0048-0006', '2024-01-15', 20, 'typhoon', 'x'),
(61, '16-174001-0001-0027', '2024-01-16', 12, 'typhoon', 'x'),
(62, '17-174001-0001-0025', '2024-01-16', 10, 'typhoon', '/'),
(63, '17-174001-0003-0049', '2024-01-16', 13, 'typhoon', '/'),
(64, '18-174000-0004-0010', '2024-01-16', 5, 'typhoon', '.'),
(65, '18-174000-0003-0010', '2024-01-16', 5, 'typhoon', '.'),
(66, '18-174000-0009-0030', '2024-01-16', 6, 'typhoon', '.'),
(67, '18-174000-0027-0040', '2024-01-16', 12, 'typhoon/fire incidence', '.'),
(68, '18-174000-0268-0002', '2024-01-16', 0, 'typhoon', '.'),
(69, '18-174000-0267-0001', '2024-01-16', 0, 'typhoon', '.'),
(70, '18-174000-0266-0001', '2024-01-16', 1, 'typhoon', '.'),
(71, '18-174000-0307-0013', '2024-01-23', 6, 'typhoon', '\''),
(72, '18-174000-0001-0006', '2024-01-23', 4, 'typhoon', '-'),
(73, '18-174000-0002-0004', '2024-01-23', 3, 'typhoon', '-'),
(74, 'gbZwMoBYO2', '2024-03-22', 1, 'typhoon', 'x'),
(75, '13-174001-0044-0030', '2024-03-22', 15, 'typhoon', 'x'),
(76, '13-174001-0037-0017', '2024-03-22', 17, 'typhoon', 'x'),
(77, '15-174001-0006-0001', '2024-05-03', 4, 'typhoon', 'x'),
(78, '15-174001-0026-0006', '2024-05-03', 3, 'typhoon', 'x'),
(79, '15-174001-0041-0006', '2024-05-03', 2, 'typhoon', 'x'),
(80, '15-174001-0036-0003', '2024-05-03', 2, 'typhoon', 'x'),
(81, '18-174000-0309-0013', '2024-05-03', 4, 'typhoon', '-'),
(82, '18-174000-0310-0004', '2024-05-06', 3, 'typhoon', 'x'),
(83, '18-174000-0005-0002', '2024-05-06', 10, 'typhoon', 'x'),
(84, '18-174000-0011-0007', '2024-05-06', 9, 'typhoon', 'x'),
(85, '18-174000-0014-0001', '2024-05-06', 0, 'typhoon', 'x'),
(86, '18-174000-0035-0000', '2024-05-06', 0, 'typhoon', 'x'),
(87, '18-174000-0029-0001', '2024-05-06', 1, 'typhoon', 'x'),
(88, '18-174000-0018-0001', '2024-05-06', 1, 'typhoon', 'x'),
(89, '18-174000-0020-0004', '2024-05-06', 7, 'typhoon', 'x'),
(90, '18-174000-0024-0000', '2024-05-06', 1, 'typhoon', 'x'),
(91, '18-174000-0028-0001', '2024-05-06', 1, 'typhoon', 'x'),
(92, '18-174000-0026-0001', '2024-05-06', 1, 'typhoon', 'x'),
(93, '18-174000-0017-0001', '2024-05-06', 1, 'typhoon', 'x'),
(94, '18-174000-0030-0000', '2024-05-06', 0, 'typhoon', 'x'),
(95, '18-174000-0032-0001', '2024-05-06', 1, 'typhoon', 'x'),
(96, '18-174000-0033-0000', '2024-05-06', 0, 'typhoon', 'x'),
(97, '18-174000-0034-0003', '2024-05-06', 2, 'typhoon', 'x'),
(98, '18-174000-0036-0000', '2024-05-06', 0, 'typhoon', 'x'),
(99, '18-174000-0037-0002', '2024-05-06', 1, 'typhoon', 'x'),
(100, '18-174000-0038-0001', '2024-05-06', 1, 'typhoon', 'x'),
(101, '18-174000-0039-0008', '2024-05-06', 5, 'typhoon', 'x'),
(102, '18-174000-0010-0005', '2024-05-06', 3, 'typhoon', 'x'),
(103, '18-174000-0022-0028', '2024-05-06', 22, 'typhoon', 'x'),
(104, '18-174000-0023-0007', '2024-05-06', 6, 'typhoon', 'x'),
(105, '18-174000-0015-0000', '2024-05-07', 0, 'typhoon', 'x'),
(106, '15-174001-0012-0000', '2024-05-15', 23, 'typhoon', 'x'),
(109, '15-174001-0003-0003', '2024-06-19', 8, 'typhoon', 'x'),
(110, '15-174001-0044-0006', '2024-06-19', 5, 'typhoon', 'x');

-- --------------------------------------------------------

--
-- Table structure for table `flexible_disbursement_tbl`
--

CREATE TABLE `flexible_disbursement_tbl` (
  `disbursement_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `disbursement_code` varchar(100) DEFAULT NULL,
  `cheque_num` int(11) DEFAULT NULL,
  `yearcode` varchar(10) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `date_issued` date DEFAULT NULL,
  `date_released` date DEFAULT NULL,
  `ob_mf` decimal(10,0) DEFAULT NULL,
  `ob_rf` decimal(10,0) DEFAULT NULL,
  `db_mf` decimal(10,0) DEFAULT NULL,
  `db_rf` decimal(10,0) DEFAULT NULL,
  `others` decimal(10,0) DEFAULT NULL,
  `total_payment` decimal(10,0) DEFAULT NULL,
  `ob_no` varchar(100) DEFAULT NULL,
  `ob_date` date DEFAULT NULL,
  `dv_no` varchar(100) DEFAULT NULL,
  `dv_date` date DEFAULT NULL,
  `obtc` decimal(10,0) DEFAULT NULL,
  `dvtc` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `flexible_disbursement_tbl`
--

INSERT INTO `flexible_disbursement_tbl` (`disbursement_id`, `unique_code`, `disbursement_code`, `cheque_num`, `yearcode`, `payment`, `date_issued`, `date_released`, `ob_mf`, `ob_rf`, `db_mf`, `db_rf`, `others`, `total_payment`, `ob_no`, `ob_date`, `dv_no`, `dv_date`, `obtc`, `dvtc`) VALUES
(5, '22-174000-0001-0012', '15% Mobilization Funds', 141434, 'year1', 31500, '2022-06-30', '2022-07-22', 31500, 0, 0, 0, 0, 31500, 'C0-22-06-583', '2022-06-29', '22-06-667', '2022-06-30', 210000, 31500),
(6, '22-174000-0001-0012', '2nd Payment', 141575, 'year1', 178500, '2022-09-30', '2022-09-30', 0, 21000, 0, 0, 0, 157500, 'C0-22-06-583', '2022-06-29', '22-09-1199F', '2022-09-30', 210000, 178500),
(7, '22-174000-0001-0012', '15% Mobilization', 141567, 'year1', 0, '2022-09-29', '2022-10-07', 15300, 0, 0, 0, 0, 15300, 'C0-22-08-957', '2022-08-31', '22-09-1109', '2022-09-29', 102000, 0),
(8, '22-174000-0001-0012', '76% Payment', 143066, 'year1', 77520, '2023-03-13', '2023-05-24', 15300, 0, 0, 7752, 0, 54468, 'C0-22-08-957', '2022-08-31', '23-03-220', '2023-03-10', 102000, 77520),
(9, '22-174000-0001-0012', 'Maintenance Payment', 145114, 'year1', 24480, '2023-04-19', '2023-05-03', 0, 0, 0, 2448, 0, 22032, 'M00E-22-08-957', '2022-08-31', '23-03-366', '2023-03-31', 102000, 24480),
(10, '22-174000-0004-0020', '15% Mobilization', 141436, 'year1', 0, '2022-06-30', '2022-07-13', 33000, 0, 0, 0, 0, 33000, 'C0-22-06-582', '2022-06-29', '', '2022-06-30', 220000, 0),
(11, '22-174000-0004-0020', '2nd Payment', 141574, 'year1', 187000, '2022-09-30', '2022-11-03', 0, 22000, 0, 0, 0, 165000, 'C0-22-06-582', '2023-11-21', 'N/A', '2023-11-21', 220000, 187000),
(12, '22-174000-0004-0020', '15% Mobilization Fund', 141558, 'year1', 25500, '2022-09-27', '2022-10-04', 25500, 0, 0, 0, 0, 25500, 'C0-22-08-959', '2022-08-31', '22-09-1065', '2022-09-21', 170000, 0),
(13, '22-174000-0004-0020', '76% Payment', 143016, 'year1', 130000, '2023-01-31', '2023-03-27', 25500, 0, 0, 13000, 0, 91500, 'C0-22-08-959', '2022-08-31', '22-12-1618', '2022-12-29', 170000, 130000),
(15, '22-174000-0002-0011', '15% Mobilization fund', 141433, 'year1', 0, '2022-06-30', '2022-08-19', 28875, 0, 0, 0, 0, 28875, 'C0-22-06584', '2022-06-29', '22-6-668', '2022-06-30', 192500, 0),
(16, '22-174000-0002-0011', '2nd Payment', 141447, 'year1', 192500, '2022-06-30', '2022-07-29', 28875, 0, 0, 19250, 0, 144375, 'C0-22-06-584', '2022-06-29', 'N/A', '2023-11-21', 192500, 192500),
(17, '22-174000-0002-0011', '3rd Payment', 142929, 'year1', 144275, '2022-11-07', '2022-12-02', 0, 0, 0, 0, 30000, 30000, 'C0-22-06-584', '2022-06-29', '22-10', '2022-10-24', 192500, 144275),
(18, '22-174000-0002-0011', 'iYNFJTkMvs', 141559, 'year1', 144275, '2022-09-27', '2022-10-18', 0, 0, 0, 0, 30000, 30000, 'C0-22-08-956', '2022-08-31', '22-09-1064', '2022-09-21', 192500, 144275),
(19, '22-174000-0002-0011', '15% Mobilization Fund', 141559, 'year1', 144275, '2022-09-27', '2022-10-18', 14025, 0, 0, 0, 0, 14025, 'C0-22-08-956', '2022-08-31', '22-09-1064', '2022-09-21', 93500, 0),
(21, '22-174000-0002-0011', '76% payment', 143065, 'year1', 71060, '2023-03-13', '2023-03-17', 14025, 0, 0, 7106, 0, 49929, 'C0-22-08-956', '2022-08-31', '23-03-215', '2023-03-10', 93500, 71060),
(22, '22-174000-0002-0011', 'Maintenance Payment', 145115, 'year1', 22440, '2023-04-19', '2023-04-28', 0, 0, 0, 2244, 0, 20196, 'M00E-22-08-956', '2022-08-31', '23-03-369', '2023-03-31', 93500, 22440),
(23, '22-174000-0003-0032', '15% Mobilization Fund', 141437, 'year1', 0, '2022-06-30', '2022-07-19', 48000, 0, 0, 0, 0, 48000, 'C0-22-06-580', '2022-06-29', '22-06-665', '2022-06-30', 320000, 0),
(24, '22-174000-0003-0032', '2nd Billing ', 141506, 'year1', 320000, '2022-08-09', '2022-08-11', 48000, 0, 0, 32000, 0, 240000, 'C0-22-06-580', '2022-06-29', '22-08-674', '2022-08-05', 320000, 320000),
(25, '22-174000-0003-0032', '15% Mobilization Fund', 141557, 'year1', 320000, '2022-09-27', '2022-08-12', 40800, 0, 0, 0, 0, 40800, 'C0-22-06-958', '2022-08-31', '22-09-1066', '2022-09-21', 272000, 320000),
(26, '22-174000-0003-0032', '76% Payment', 143067, 'year1', 206720, '2023-03-13', '2023-08-27', 40800, 0, 0, 20672, 0, 145248, 'C0-22-06-958', '2022-08-31', '23-03-221', '2023-03-10', 272000, 206720),
(27, '22-174000-0003-0032', 'Maintenance Payment', 143093, 'year1', 65280, '2023-03-31', '2023-04-17', 0, 0, 0, 6528, 0, 58752, 'M00E-22-08-958', '2022-08-31', '23-03-365', '2023-03-31', 272000, 65280),
(28, '22-174000-0005-0024', '15% Mobilization Fund', 141435, 'year1', 65280, '2022-06-30', '2022-07-14', 46125, 0, 0, 0, 0, 46125, 'C0-22-06-581', '2022-06-29', '22-6-669', '2022-06-30', 307500, 0),
(29, '22-174000-0005-0024', '2nd Billing', 141446, 'year1', 307500, '2022-06-30', '2022-08-02', 46125, 0, 0, 30750, 0, 230625, 'C0-22-06-581', '2022-06-29', '22-06-695 A', '2022-06-30', 307500, 307500),
(31, '22-174000-0005-0024', '15% Mobilization Fund', 141565, 'year1', 51000, '2022-09-29', '2022-10-04', 31875, 0, 0, 0, 0, 31875, 'C0-22-08-960', '2022-08-31', '22-09-1100', '2022-09-28', 212500, 0),
(32, '22-174000-0005-0024', '76% Billing', 142959, NULL, 161500, '2022-12-14', '2022-12-16', 31875, 0, 0, 16150, 0, 113475, 'C0-22-08-960', '2022-08-31', '22-12-1449', '2022-12-13', 212500, 161500),
(33, '22-174000-0005-0024', 'Maintenance Billing', 143094, NULL, 51000, '2023-03-31', '2022-04-12', 0, 0, 0, 5100, 0, 45900, 'C0-22-08-960', '2022-08-31', '23-03-367', '2023-03-31', 212500, 51000),
(35, '22-174000-0002-0011', 'Payment of 2nd Year (30%)', 145236, 'year2', 19800, '2023-09-12', '2023-09-21', 0, 0, 0, 1980, 0, 17820, 'C0-23-03-215', '2023-03-22', '23-09--1019', '2023-09-04', 66000, 19800),
(36, '22-174000-0002-0011', 'Payment of 50% for 2nd Year ', 145235, 'year2', 33000, '2023-09-12', '2023-09-21', 0, 0, 0, 3300, 0, 29700, 'C0-23-03-215', '2023-03-22', '23-09-1048', '2023-09-11', 66000, 33000),
(37, '22-174000-0001-0012', 'Payment of 30% for 2nd Year', 145220, 'year2', 21600, '2023-08-08', '2023-09-18', 0, 0, 0, 2160, 0, 19440, 'C0-23-03-216', '2023-03-22', '23-08-970', '2023-08-18', 72000, 21600),
(38, '22-174000-0001-0012', 'Payment of 50% for 2nd Year', 145265, 'year2', 36000, '2023-09-29', '2023-10-17', 0, 0, 0, 3600, 0, 32400, 'C0-23-03-216', '2023-03-23', '23-09-1207', '2023-09-29', 72000, 36000),
(39, '22-174000-0005-0024', 'Payment of 30% for 2nd year', 145232, 'year2', 45000, '2023-08-31', '2023-09-05', 0, 0, 0, 4500, 0, 40500, 'C0-23-03-212', '2023-03-22', '23-08-972', '2023-08-22', 150000, 45000),
(40, '22-174000-0005-0024', 'Payment of 50% for 2nd year', 145234, 'year2', 75000, '2023-09-12', '2023-09-27', 0, 0, 0, 7500, 0, 67500, 'C0-23-03-212', '2023-03-22', '23-09-1049', '2023-09-11', 150000, 75000),
(42, '21-174000-0001-0020/ 21-174000-0002-0050', '15% Mobilzation Fee 1st Year', 137148, 'year1', 220950, '2021-03-26', '2021-03-22', 220950, 0, 0, 0, 0, 220950, 'C0-21-03-17', '2021-03-22', '21-03-243', '2021-03-25', 1473000, 220950),
(43, '21-174000-0001-0020/ 21-174000-0002-0050', '2nd Payment of 1st Year', 137269, 'year1', 878000, '2021-06-30', '2021-07-26', 0, 0, 0, 0, 657050, 657050, 'C0-21-03-176', '2021-03-22', '21-06-697', '2021-06-30', 1473000, 878000),
(44, '21-174000-0001-0020/ 21-174000-0002-0050', '3rd Payment of 1st Year', 139832, 'year1', 455000, '2022-01-20', '2022-01-27', 0, 0, 0, 0, 321700, 321700, 'C0-21-03-176', '2021-03-22', '21-12-1547', '2021-12-29', 1473000, 455000),
(45, '21-174000-0001-0020/ 21-174000-0002-0050', '4th Payment of 1st Year', 139830, 'year1', 140000, '2022-01-20', '2022-02-17', 0, 0, 0, 14000, 0, 126000, 'C0-21-03-176', '2021-03-22', '21-12-1546', '2021-12-29', 1473000, 140000),
(46, '21-174000-0001-0020/ 21-174000-0002-0050', '100% accomplishment 70 ha 2nd Year maint. & Pro', 143092, 'year2', 350000, '2023-03-31', '2023-04-19', 0, 0, 0, 35000, 0, 315000, 'C0-22-03-202', '2022-03-24', '23-03-364', '2023-03-31', 350000, 350000),
(47, '21-174000-0001-0020/ 21-174000-0002-0050', '30% accomp. for 3rd Year Maintenance', 145237, 'year3', 126000, '2023-09-12', '2023-09-15', 0, 0, 0, 12600, 0, 113400, 'C0-23-03-217', '2023-03-22', '23-09-1036', '2023-09-06', 420000, 126000),
(58, '22-174000-0004-0020', '80% Accomplishment', 145238, 'year2', 96000, '2023-09-12', '2023-10-06', 0, 0, 0, 9600, 0, 86400, 'CO-23-03-213', '2023-03-22', '23-09-1047', '2023-09-18', 120000, 96000),
(59, '22-174000-0004-0020', '20% Accomplishment', 147294, 'year2', 24000, '2024-03-07', '2024-04-19', 0, 0, 0, 2400, 0, 21600, 'CO-23-03-213', '2023-03-22', '23-12-1578', '2023-12-29', 120000, 24000),
(60, '22-174000-0001-0012', '20 % Accomplishment', 147251, 'year2', 14400, '2024-01-11', '2024-01-11', 0, 0, 0, 1440, 0, 12960, 'CO-23-03-216', '2023-03-23', '23-12-1587', '2023-12-29', 72000, 14400),
(61, '22-174000-0002-0011', '20% Accomplishment', 147253, 'year2', 13200, '2024-01-11', '2024-01-11', 0, 0, 0, 1320, 0, 11880, 'CO-23-03-215', '2023-03-22', '23-12-1585', '2023-12-29', 66000, 13200),
(62, '22-174000-0005-0024', '20% Accomplishment', 147237, 'year2', 30000, '2023-12-29', '2024-01-05', 0, 0, 0, 3000, 0, 27000, 'CO-23-03-212', '2023-03-22', '23-12-1567', '2023-12-29', 150000, 30000),
(69, '21-174000-0003-0010', 'Payment of 15% Mobilization Fund', 137226, 'year1', 0, '2021-05-25', '2021-05-17', 10650, 0, 0, 0, 0, 10650, 'C0-20-12-1421', '2020-12-29', '21-04-266', '2021-04-12', 71000, 0),
(70, '21-174000-0003-0010', 'Payment of 100% Accomplishment ', 138877, 'year1', 71000, '2021-09-30', '2021-09-30', 10650, 0, 0, 7100, 0, 53250, 'C0-20-12-1421', '2020-12-29', '21-09-1035', '2021-09-30', 71000, 71000),
(71, '21-174000-0003-0010', 'Payment of 15% Mobilization Fund', 138873, 'year1', 71000, '2021-09-30', '2021-09-30', 12750, 0, 0, 0, 0, 12750, 'C0-21-08-799', '2021-08-25', '21-09-1002', '2021-09-29', 85000, 0),
(72, '21-174000-0003-0010', 'Payment of 100% (Established Plant.)', 138910, 'year1', 65000, '2021-09-30', '2021-09-30', 12750, 0, 0, 6500, 0, 45750, 'C0-21-08-799', '2021-08-25', '21-09-1054', '2021-09-30', 85000, 65000),
(73, '21-174000-0003-0010', 'Payment of 1 Year M&P Accomplishment', 139902, 'year1', 20000, '2022-03-30', '2022-03-31', 0, 0, 0, 2000, 0, 18000, 'C0-21-08-799', '2021-08-25', '21-09-1054', '2022-03-22', 85000, 20000),
(74, '22-174000-0003-0032', 'Payment of 80% (1st & 2nd Billing)', 147296, 'year2', 153600, '2024-03-07', '2024-03-12', 0, 0, 0, 15360, 0, 138240, 'C0-23-24-214', '2024-03-22', '23-12-2023', '2023-12-29', 192000, 153600),
(75, '22-174000-0003-0032', 'Payment of 20% (3rd Billing) ', 147296, 'year2', 38400, '2024-03-07', '2024-03-12', 0, 0, 0, 3840, 0, 34560, 'C0-23-24-214', '2024-03-22', '24-05-564', '2024-05-15', 192000, 38400);

-- --------------------------------------------------------

--
-- Table structure for table `funding_tbl`
--

CREATE TABLE `funding_tbl` (
  `funding_id` int(11) NOT NULL,
  `funding_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `funding_tbl`
--

INSERT INTO `funding_tbl` (`funding_id`, `funding_name`) VALUES
(1, 'Regular fund');

-- --------------------------------------------------------

--
-- Table structure for table `inspector_details_tbl`
--

CREATE TABLE `inspector_details_tbl` (
  `inspector_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `filter_code` varchar(10) DEFAULT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `job_position` varchar(100) NOT NULL,
  `date_request` date DEFAULT NULL,
  `date_inspection` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `inspector_details_tbl`
--

INSERT INTO `inspector_details_tbl` (`inspector_id`, `unique_code`, `filter_code`, `firstname`, `middlename`, `lastname`, `job_position`, `date_request`, `date_inspection`) VALUES
(3, '22-174000-0001-0012', NULL, 'Paul Brian ', 'D.', 'Mijares', 'Chairperson', '2022-06-30', '2022-07-26'),
(4, '22-174000-0001-0012', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-06-30', '2022-07-26'),
(5, '22-174000-0001-0012', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2022-06-30', '2022-07-26'),
(6, '22-174000-0001-0012', NULL, 'Mary Rose', '', 'Borreo', 'Member', '2022-06-30', '2022-07-26'),
(7, '22-174000-0001-0012', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-06-30', '2022-07-26'),
(16, '22-174000-0001-0012', 'Bke9', 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2023-06-19', '2023-06-20'),
(17, '22-174000-0001-0012', 'Bke9', 'Mary Rose', '', 'Borreo', 'Member', '2023-06-19', '2023-06-20'),
(18, '22-174000-0001-0012', 'Bke9', 'Ericka', 'M.', 'Macunat', 'Member', '2023-06-19', '2023-06-20'),
(19, '22-174000-0001-0012', 'Bke9', 'Julius Mark', '', 'Manoos', 'Member', '2023-06-19', '2023-06-20'),
(55, '22-174000-0003-0032', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-11-25', '2022-12-08'),
(56, '22-174000-0003-0032', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-11-25', '2022-12-08'),
(57, '22-174000-0003-0032', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-11-25', '2022-12-08'),
(58, '22-174000-0003-0032', NULL, 'Julius Mark', 'L.', 'Manoos', 'Member', '2022-11-25', '2022-12-08'),
(59, '22-174000-0003-0032', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-06-24', '2022-06-30'),
(60, '22-174000-0003-0032', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-06-24', '2022-06-30'),
(61, '22-174000-0003-0032', NULL, 'Mary Rose', 'L. ', 'Borreo', 'Member', '2022-06-24', '2022-06-30'),
(62, '22-174000-0003-0032', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2022-06-24', '2022-06-30'),
(63, '22-174000-0003-0032', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-06-24', '2022-06-30'),
(64, '22-174000-0003-0032', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-12-19', '2022-12-22'),
(65, '22-174000-0003-0032', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-12-19', '2022-12-22'),
(66, '22-174000-0003-0032', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-12-19', '2022-12-22'),
(67, '22-174000-0003-0032', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-12-19', '2022-12-22'),
(68, '22-174000-0003-0032', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2022-12-19', '2022-12-22'),
(69, '21-174000-0001-0020/ 21-174000-0002-0050', 'FNjc', 'Bernadine', 'I.', 'Jasul', 'Co-chairman', '2022-06-21', '2022-08-01'),
(70, '21-174000-0001-0020/ 21-174000-0002-0050', 'FNjc', 'Michael Vencint', 'M.', 'Sualog', 'Member', '2022-06-21', '2022-08-01'),
(71, '21-174000-0001-0020/ 21-174000-0002-0050', 'FNjc', 'Rica Quennie', '', 'Radovan', 'Member', '2022-06-21', '2022-08-01'),
(72, '21-174000-0001-0020/ 21-174000-0002-0050', 'FNjc', 'Sherwin', 'P.', 'Villavicencio', 'Member', '2022-06-21', '2022-08-01'),
(73, '21-174000-0001-0020/ 21-174000-0002-0050', 'FNjc', 'Joybert', 'F.', 'Mijares', 'Team Leader', '2022-06-21', '2022-08-01'),
(74, '22-174000-0004-0020', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-06-27', '2022-08-05'),
(76, '22-174000-0004-0020', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-06-27', '2022-08-05'),
(77, '22-174000-0004-0020', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2022-06-27', '2022-08-05'),
(79, '22-174000-0004-0020', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-06-27', '2022-08-05'),
(80, '22-174000-0004-0020', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-06-27', '2022-08-05'),
(81, '22-174000-0004-0020', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairpersom', '2022-11-24', '2022-12-07'),
(82, '22-174000-0004-0020', NULL, 'Jelomy', 'H.', 'Mahayag', 'Member', '2022-11-24', '2022-12-07'),
(83, '22-174000-0004-0020', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-11-24', '2022-12-07'),
(84, '22-174000-0004-0020', NULL, 'Julius Mark', 'L.', 'Manoos', 'Member', '2022-11-24', '2022-12-07'),
(85, '22-174000-0004-0020', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-12-20', '2022-12-23'),
(86, '22-174000-0004-0020', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-12-20', '2022-12-23'),
(87, '22-174000-0004-0020', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-12-20', '2022-12-23'),
(88, '22-174000-0004-0020', NULL, 'Ericka', 'M.', 'Macunat', 'Member', '2022-12-20', '2022-12-23'),
(89, '22-174000-0004-0020', NULL, 'Julius', 'Mark', 'Manoos', 'Member', '2022-12-20', '2022-12-23'),
(91, '22-174000-0004-0020', 'VBMV', 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2023-07-07', '2023-07-18'),
(92, '22-174000-0004-0020', 'VBMV', 'Mary Rose', 'L.', 'Borreo', 'Member', '2023-07-07', '2023-07-18'),
(93, '22-174000-0004-0020', 'VBMV', 'Ericka', 'L.', 'Macunat', 'Member', '2023-07-07', '2023-07-18'),
(94, '22-174000-0004-0020', 'VBMV', 'Julius Mark', 'L.', 'Manoos', 'Member', '2023-07-07', '2023-07-18'),
(96, '22-174000-0004-0020', 'VBMV', 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2023-07-07', '2023-07-18'),
(97, '22-174000-0001-0012', NULL, 'Paul Brian', 'D,', 'Mijares', 'Chairperson', '2022-12-08', '2022-12-08'),
(98, '22-174000-0001-0012', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-12-08', '2022-12-08'),
(99, '22-174000-0001-0012', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-12-08', '2022-12-08'),
(100, '22-174000-0001-0012', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-12-08', '2022-12-08'),
(101, '22-174000-0001-0012', NULL, 'Julius Mark', 'L.', 'Manoos', 'Member', '2022-12-08', '2022-12-08'),
(107, '22-174000-0001-0012', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2022-12-19', '2022-12-21'),
(108, '22-174000-0001-0012', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-chairperson', '2022-12-19', '2022-12-21'),
(109, '22-174000-0001-0012', NULL, 'Mary Rose', 'L.', 'Borreo', 'Member', '2022-12-19', '2022-12-21'),
(110, '22-174000-0001-0012', NULL, 'Ericka', 'L.', 'Macunat', 'Member', '2022-12-19', '2022-12-21'),
(111, '22-174000-0001-0012', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2022-12-19', '2022-12-21'),
(112, '22-174000-0001-0012', 'eBZD', 'Paul Brian', 'D.', 'Mijares', 'Chairperson', '2023-07-17', '2023-09-14'),
(113, '22-174000-0001-0012', 'eBZD', 'Jelomy', 'H.', 'Mahayag', 'Member', '2023-07-17', '2023-09-14'),
(114, '22-174000-0001-0012', 'eBZD', 'Mary Rose', 'L.', 'Borreo', 'Member', '2023-07-17', '2023-09-14'),
(115, '22-174000-0001-0012', 'eBZD', 'Mark Julius', 'L.', 'Manoos', 'Member', '2023-07-17', '2023-09-14'),
(116, '21-174000-0001-0020/ 21-174000-0002-0050', 'TrVl', 'Bernadine ', 'I.', 'Jasul', 'Co-chairman', '2022-06-30', '2022-08-01'),
(117, '21-174000-0001-0020/ 21-174000-0002-0050', 'TrVl', 'Michael Vencint', 'M.', 'Sualog', 'Member', '2022-06-30', '2022-08-01'),
(118, '21-174000-0001-0020/ 21-174000-0002-0050', 'TrVl', 'Rica Quennie', '', 'Radovan', 'Member', '2022-06-30', '2022-08-01'),
(119, '21-174000-0001-0020/ 21-174000-0002-0050', 'TrVl', 'Sherwin', 'P.', 'Villavicencio', 'Member', '2022-06-30', '2022-08-01'),
(120, '21-174000-0001-0020/ 21-174000-0002-0050', 'TrVl', 'Joybert', 'F.', 'Mijares', 'Team Leader', '2022-06-30', '2022-08-01'),
(128, '21-174000-0001-0020/ 21-174000-0002-0050', 'wAY8', 'Wilson', 'R.', 'Paez', 'Forest Technician 1', '2022-07-21', '2022-08-01'),
(129, '21-174000-0001-0020/ 21-174000-0002-0050', 'wAY8', 'Jomar', '', 'Cordova', 'Forest Extension Officer', '2022-07-21', '2022-08-01'),
(130, '21-174000-0001-0020/ 21-174000-0002-0050', 'wAY8', 'Joe Vert', 'N.', 'Beatriz', 'Forest Extension Officer', '2022-07-21', '2022-08-01'),
(131, '21-174000-0001-0020/ 21-174000-0002-0050', 'W6Uh', 'Joybert', 'F.', 'Mijares', 'Forester', '2022-07-21', '2022-08-01'),
(132, '21-174000-0001-0020/ 21-174000-0002-0050', 'Q0lbp', 'Bernadine', 'I.', 'Jasul', 'Forester 1', '2023-06-29', '2023-07-18'),
(133, '21-174000-0001-0020/ 21-174000-0002-0050', 'Q0lbp', 'Michael Vencint', 'M.', 'Sualog', 'Forest Technician 1', '2023-06-29', '2023-07-18'),
(134, '21-174000-0001-0020/ 21-174000-0002-0050', 'Q0lbp', 'Rica Quennie', '', 'Radovan', 'Forest Ranger', '2023-06-29', '2023-07-18'),
(135, '21-174000-0001-0020/ 21-174000-0002-0050', 'Q0lbp', 'Sherwin', 'P.', 'Villavicencio', 'Forest Ranger', '2023-06-29', '2023-07-18'),
(136, '21-174000-0001-0020/ 21-174000-0002-0050', 'Q0lbp', 'Joybert', 'F.', 'Mijares', 'SFMS Chairman', '2023-06-29', '2023-07-18'),
(140, '21-174000-0003-0010', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson / Forester I', '2021-06-24', '2021-07-27'),
(141, '21-174000-0003-0010', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-Chairperson / Forester I', '2021-06-24', '2021-07-27'),
(142, '21-174000-0003-0010', NULL, 'Michael Vencint', 'M.', 'Sualog', 'Member / Forest Technician I', '2021-06-24', '2021-07-27'),
(143, '21-174000-0003-0010', NULL, 'Jhonna Liza', '', 'Medenilla', 'Member / Planning Officer II', '2021-06-24', '2021-07-27'),
(144, '21-174000-0003-0010', NULL, 'Mark Julius', 'L.', 'Manoos', 'Member', '2021-09-24', '2021-09-29'),
(145, '21-174000-0003-0010', NULL, 'Michael Vencint', 'M.', 'Sualog', 'Member / Forest Technician I', '2021-09-24', '2021-09-29'),
(146, '21-174000-0003-0010', NULL, 'Jelomy', 'H.', 'Mahayag', 'Co-Chairperson / Forester I', '2021-09-24', '2021-09-29'),
(147, '21-174000-0003-0010', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson / Forester I', '2021-09-24', '2021-09-29'),
(148, '21-174000-0003-0010', NULL, 'Julius ', 'L.', 'Manoos', 'Member Forest Technician I', '2021-12-15', '2021-12-18'),
(149, '21-174000-0003-0010', NULL, 'Michael Vencint', 'M.', 'Sualog', 'Member / Forest Technician I', '2021-12-15', '2021-12-18'),
(150, '21-174000-0003-0010', NULL, 'Jelomy', 'H. ', 'Mahayag', 'Co-Chairperson', '2021-12-15', '2021-12-18'),
(151, '21-174000-0003-0010', NULL, 'Paul Brian', 'D.', 'Mijares', 'Chairperson / Forester I', '2021-12-15', '2021-12-18');

-- --------------------------------------------------------

--
-- Table structure for table `maintenance_pro_tbl`
--

CREATE TABLE `maintenance_pro_tbl` (
  `main_id` int(11) NOT NULL,
  `main_code` varchar(100) NOT NULL,
  `date_request` date NOT NULL,
  `date_inspected` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `maintenance_pro_tbl`
--

INSERT INTO `maintenance_pro_tbl` (`main_id`, `main_code`, `date_request`, `date_inspected`) VALUES
(9, 'QB', '2022-12-19', '2022-12-21'),
(10, 'Yj', '2011-01-01', '2011-01-01'),
(25, 'kl', '2022-12-19', '2022-12-22'),
(32, '86', '2022-12-20', '2022-12-23'),
(33, 'Vu', '2022-12-09', '2022-12-21'),
(34, 'Os', '2021-12-01', '2021-12-11'),
(35, 'Wa', '2021-12-15', '2021-12-18'),
(36, 'nY', '2024-06-18', '2024-06-17'),
(37, '2a', '2024-06-18', '2024-06-17'),
(38, 'lM', '2024-07-20', '2024-05-20');

-- --------------------------------------------------------

--
-- Table structure for table `maintenance_tbl`
--

CREATE TABLE `maintenance_tbl` (
  `maintenance_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `main_code` varchar(10) NOT NULL,
  `activities` varchar(100) NOT NULL,
  `uwm` varchar(10) NOT NULL,
  `total_cost` decimal(10,0) NOT NULL,
  `unit_cost` int(11) NOT NULL,
  `total_target` varchar(100) NOT NULL,
  `accomplishment` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `maintenance_tbl`
--

INSERT INTO `maintenance_tbl` (`maintenance_id`, `unique_code`, `main_code`, `activities`, `uwm`, `total_cost`, `unit_cost`, `total_target`, `accomplishment`) VALUES
(9, '22-174000-0001-0012', 'QB', 'Maintenance and Protection', 'ha', 24480, 2000, '12 ha', 100),
(10, '11-174001-0001-0034', 'Yj', 'Maintenance and Protection', 'Has', 0, 0, '34 ha', 100),
(24, '22-174000-0003-0032', 'kl', 'Maintenance and Protection', 'ha', 65280, 2000, '32 ha', 100),
(26, '22-174000-0004-0020', '86', 'Maintenance and Protection', 'ha', 40000, 2000, '20 ha', 100),
(27, '22-174000-0002-0011', 'Vu', 'Maintenance and Protection', 'ha', 22440, 2000, '11 ha', 100),
(28, '21-174000-0001-0020/ 21-174000-0002-0050', 'Os', 'Maintenance and Protection', 'ha', 140000, 2000, '70', 100),
(29, '21-174000-0003-0010', 'Wa', 'Maintenance and Protection', 'ha', 20000, 2000, '10', 100);

-- --------------------------------------------------------

--
-- Table structure for table `multispecies`
--

CREATE TABLE `multispecies` (
  `multispecies_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `seed_code` varchar(100) DEFAULT NULL,
  `seed_produce_code` varchar(100) DEFAULT NULL,
  `date_of_request` date DEFAULT NULL,
  `date_of_inspection` date DEFAULT NULL,
  `multispecies_name` varchar(100) NOT NULL,
  `multiseed_req` int(11) NOT NULL,
  `tic_counted` int(11) DEFAULT NULL,
  `died` int(11) DEFAULT NULL,
  `seed_planted` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `multispecies`
--

INSERT INTO `multispecies` (`multispecies_id`, `unique_code`, `seed_code`, `seed_produce_code`, `date_of_request`, `date_of_inspection`, `multispecies_name`, `multiseed_req`, `tic_counted`, `died`, `seed_planted`) VALUES
(3, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Guyabano', 65, 61, NULL, NULL),
(4, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Langka', 807, 753, NULL, NULL),
(5, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Calamansi', 30, 27, NULL, NULL),
(6, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Makopa', 125, 120, NULL, NULL),
(7, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Mango', 204, 193, NULL, NULL),
(8, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Pomelo', 305, 279, NULL, NULL),
(9, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Robusta Coffee', 4525, 4211, NULL, NULL),
(10, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Avocado', 130, 123, NULL, NULL),
(11, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Kamansi', 102, 102, NULL, NULL),
(12, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Santol', 92, 88, NULL, NULL),
(13, '22-174000-0001-0012', NULL, 'Sv', NULL, NULL, 'Star Apple', 215, 201, NULL, NULL),
(14, '11-174001-0001-0034', NULL, '2g', NULL, NULL, 'Narra', 17000, 17000, NULL, NULL),
(15, '22-174000-0003-0032', NULL, 'Xy', NULL, NULL, 'Narra', 9350, 8980, NULL, NULL),
(16, '22-174000-0003-0032', NULL, 'Xy', NULL, NULL, 'Acacia', 4950, 4589, NULL, NULL),
(17, '22-174000-0003-0032', NULL, 'Xy', NULL, NULL, 'Wisak', 3960, 3527, NULL, NULL),
(18, '22-174000-0003-0032', NULL, 'Xy', NULL, NULL, 'Coffee', 3800, 3414, NULL, NULL),
(19, '22-174000-0003-0032', NULL, 'Xy', NULL, NULL, 'Cacao', 660, 600, NULL, NULL),
(37, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Narra', 7761, 7098, NULL, NULL),
(38, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Wisak', 145, 132, NULL, NULL),
(39, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Batino', 1049, 968, NULL, NULL),
(40, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Langka', 1324, 1255, NULL, NULL),
(41, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Santol', 227, 210, NULL, NULL),
(42, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Cacao', 370, 340, NULL, NULL),
(43, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Guyabano', 303, 283, NULL, NULL),
(44, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Rambutan', 290, 272, NULL, NULL),
(45, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Coffee', 885, 812, NULL, NULL),
(46, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Mango', 65, 55, NULL, NULL),
(47, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Lucban', 35, 32, NULL, NULL),
(48, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Calamansi', 257, 238, NULL, NULL),
(49, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Makopa', 70, 62, NULL, NULL),
(50, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Dalanghita', 40, 35, NULL, NULL),
(51, '22-174000-0004-0020', NULL, 'BA', NULL, NULL, 'Avocado', 10, 7, NULL, NULL),
(52, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Coffee', 4450, 4311, NULL, NULL),
(53, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Kamansi', 600, 586, NULL, NULL),
(54, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Dalandan', 185, 157, NULL, NULL),
(55, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Cacao', 95, 86, NULL, NULL),
(56, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Langka', 175, 173, NULL, NULL),
(57, '22-174000-0002-0011', NULL, 'ya', NULL, NULL, 'Santol', 195, 189, NULL, NULL),
(58, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Narra', 3600, 3552, NULL, NULL),
(59, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Acacia', 3600, 3558, NULL, NULL),
(60, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Wisak', 100, 40, NULL, NULL),
(61, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Batino', 350, 292, NULL, NULL),
(62, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Guyong - guyong', 250, 199, NULL, NULL),
(63, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Lauan', 896, 788, NULL, NULL),
(64, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Cacao', 2550, 2500, NULL, NULL),
(65, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Calamansi', 83, 65, NULL, NULL),
(66, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Rambutan', 84, 45, NULL, NULL),
(67, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Langka', 2570, 2108, NULL, NULL),
(68, '22-174000-0005-0024', NULL, '9Q', NULL, NULL, 'Coffee', 1417, 1302, NULL, NULL),
(69, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Batino', 2447, 2447, NULL, NULL),
(70, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Makaasim', 1056, 1056, NULL, NULL),
(71, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Mulawin', 15, 15, NULL, NULL),
(72, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Mulawin', 15910, 15910, NULL, NULL),
(73, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Wisak', 3594, 3594, NULL, NULL),
(74, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Avocado', 60, 60, NULL, NULL),
(75, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Cacao', 1527, 1527, NULL, NULL),
(76, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Caimito', 154, 154, NULL, NULL),
(77, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Coffee', 2538, 2538, NULL, NULL),
(78, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Guyabano', 791, 791, NULL, NULL),
(79, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Langka', 2128, 2128, NULL, NULL),
(80, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Lanzones', 20, 20, NULL, NULL),
(81, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Mango', 2782, 2782, NULL, NULL),
(82, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Rambutan', 953, 953, NULL, NULL),
(83, '21-174000-0001-0020/ 21-174000-0002-0050', NULL, 'J8', NULL, NULL, 'Santol', 6681, 6681, NULL, NULL),
(86, '11-174001-0002-0008', NULL, 'Y3', NULL, NULL, 'Narra, Langka,Guyabano,Rambutan', 4000, 4000, NULL, NULL),
(87, '11-174001-0003-0002', NULL, 'Yb', NULL, NULL, 'Langka', 1000, 1000, NULL, NULL),
(88, '11-174001-0004-0012', NULL, 'Yy', NULL, NULL, 'Narra', 6000, 6000, NULL, NULL),
(89, '11-174001-0005-0007', NULL, '3U', NULL, NULL, 'Narra', 3500, 3500, NULL, NULL),
(90, '11-174001-0006-0003', NULL, 'Jq', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(91, '11-174001-0007-0001', NULL, 'TS', NULL, NULL, 'Narra', 500, 500, NULL, NULL),
(92, '11-174001-0008-0002', NULL, 'o1', NULL, NULL, 'Narra', 1000, 1000, NULL, NULL),
(94, '11-174001-0010-0040', NULL, 'dc', NULL, NULL, 'Narra,Gmelina,Citrus,Langka,Guyabano', 20000, 20000, NULL, NULL),
(95, '11-174001-0011-0030', NULL, 'dk', NULL, NULL, 'Narra, Fire Tree', 15000, 15000, NULL, NULL),
(96, '11-174001-0012-0003', NULL, 'IR', NULL, NULL, 'Narra,Fire Tree', 1500, 1500, NULL, NULL),
(97, '11-174001-0013-0003', NULL, 'S4', NULL, NULL, 'Narra, Fire Tree', 1500, 1500, NULL, NULL),
(98, '11-174001-0014-0004', NULL, 'iy', NULL, NULL, 'Narra, Fire Tree', 1500, 1500, NULL, NULL),
(100, '11-174001-0017-0009', NULL, '3C', NULL, NULL, 'Narra, Tuai, Langka, Guyabano', 4500, 4500, NULL, NULL),
(101, '11-174001-0015-0018', NULL, 'Ii', NULL, NULL, 'Narra, Guyabano, Langka', 30000, 30000, NULL, NULL),
(102, '11-174001-0018-0003', NULL, 'rq', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(103, '11-174001-0019-0009', NULL, '3U', NULL, NULL, 'Narra', 4500, 4500, NULL, NULL),
(104, '11-174001-0020-0010', NULL, 'Wh', NULL, NULL, 'Narra', 5000, 5000, NULL, NULL),
(105, '11-174001-0021-0012', NULL, '28', NULL, NULL, 'Narra', 6000, 6000, NULL, NULL),
(106, '11-174001-0022-0005', NULL, 'mT', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(107, '11-174001-0023-0006', NULL, 'bT', NULL, NULL, 'Narra', 3000, 3000, NULL, NULL),
(108, '11-174001-0024-0003', NULL, '2M', NULL, NULL, 'Narra, Fire Tree', 1500, 1500, NULL, NULL),
(109, '11-174001-0025-0003', NULL, 'V2', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(110, '11-174001-0026-0004', NULL, 'Zh', NULL, NULL, 'Narra, Fire tree', 2000, 2000, NULL, NULL),
(111, '11-174001-0027-0003', NULL, 'Bd', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(112, '11-174001-0028-0003', NULL, 'F7', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(113, '11-174001-0029-0003', NULL, 'n2', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(114, '11-174001-0030-0003', NULL, 'gw', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(115, '11-174001-0031-0003', NULL, 'C6', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(116, '11-174001-0032-0005', NULL, 'sn', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(117, '11-174001-0033-0001', NULL, 'OE', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(118, '11-174001-0034-0003', NULL, 'AM', NULL, NULL, 'Narra, Fire tree', 1500, 1500, NULL, NULL),
(119, '11-174001-0035-0003', NULL, 'n7', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(120, '11-174001-0036-0002', NULL, 'MP', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(121, '11-174001-0037-0003', NULL, 'tY', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(122, '11-174001-0038-0003', NULL, 'xk', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(123, '11-174001-0039-0003', NULL, 'Vy', NULL, NULL, 'Narra, Fire tree', 2000, 2000, NULL, NULL),
(124, '11-174001-0040-0002', NULL, '7T', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(125, '11-174001-0041-0003', NULL, 'LE', NULL, NULL, 'Narra, Fire Tree', 1500, 1500, NULL, NULL),
(126, '11-174001-0042-0003', NULL, 'CB', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(127, '11-174001-0043-0003', NULL, 'wD', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(128, '11-174001-0044-0003', NULL, '8A', NULL, NULL, 'Narra, Acacia', 1500, 1500, NULL, NULL),
(129, '12-174001-0001-0014', NULL, 'Q6', NULL, NULL, 'Narra', 7000, 7000, NULL, NULL),
(130, '12-174001-0002-0001', NULL, 'Qy', NULL, NULL, 'Cacao', 16500, 16500, NULL, NULL),
(132, '12-174001-0012-0050', NULL, 'qs', NULL, NULL, 'Narra', 25000, 25000, NULL, NULL),
(133, '12-174001-0020-0045', NULL, '68', NULL, NULL, 'Narra', 22500, 22500, NULL, NULL),
(134, '12-174001-0021-0027', NULL, 'GF', NULL, NULL, 'Narra', 13500, 13500, NULL, NULL),
(136, '12-174001-0025-0011', NULL, 'Qe', NULL, NULL, 'Narra', 5500, 5500, NULL, NULL),
(137, '12-174001-0026-0031', NULL, 'Je', NULL, NULL, 'Narra', 15500, 15500, NULL, NULL),
(139, '12-174001-0028-0011', NULL, 'yI', NULL, NULL, 'Bakauan', 20000, 20000, NULL, NULL),
(140, '12-174001-0029-0020', NULL, 'rm', NULL, NULL, 'Narra', 10000, 10000, NULL, NULL),
(141, '12-174001-0030-0003', NULL, '5K', NULL, NULL, 'Bamboo', 140, 140, NULL, NULL),
(142, '12-174001-0031-0003', NULL, 'Up', NULL, NULL, 'Bamboo', 340, 340, NULL, NULL),
(143, '12-174001-0033-0004', NULL, '67', NULL, NULL, 'Bamboo', 40, 40, NULL, NULL),
(146, '12-174001-0034-0006', NULL, 'ig', NULL, NULL, 'Narra', 60, 60, NULL, NULL),
(147, '12-174001-0035-0013', NULL, 'p6', NULL, NULL, 'Bamboo', 240, 240, NULL, NULL),
(148, '12-174001-0036-0005', NULL, 'o5', NULL, NULL, 'Bamboo', 20, 20, NULL, NULL),
(149, '12-174001-0038-0001', NULL, 'cJ', NULL, NULL, 'Bamboo', 120, 120, NULL, NULL),
(150, '12-174001-0039-0005', NULL, 'QV', NULL, NULL, 'Bamboo', 40, 40, NULL, NULL),
(151, '12-174001-0040-0007', NULL, 'lt', NULL, NULL, 'Bamboo', 40, 40, NULL, NULL),
(152, '12-174001-0042-0001', NULL, 'PL', NULL, NULL, 'Bamboo', 20, 20, NULL, NULL),
(153, '12-174001-0043-0003', NULL, 'p5', NULL, NULL, 'Narra', 200, 200, NULL, NULL),
(154, '12-174001-0044-0005', NULL, 'uR', NULL, NULL, 'Narra', 100, 100, NULL, NULL),
(155, '12-174001-0045-0002', NULL, 'BU', NULL, NULL, 'Bamboo', 40, 40, NULL, NULL),
(156, '12-174001-0046-0002', NULL, 'M0', NULL, NULL, 'Bamboo', 140, 140, NULL, NULL),
(157, '12-174001-0047-0005', NULL, 'xi', NULL, NULL, 'Narra', 720, 720, NULL, NULL),
(158, '12-174001-0048-0002', NULL, 'Xr', NULL, NULL, 'Narra', 2000, 2000, NULL, NULL),
(159, '12-174001-0049-0001', NULL, '1Z', NULL, NULL, 'Narra', 1500, 1500, NULL, NULL),
(160, '13-174001-0001-0001', NULL, 'oJ', NULL, NULL, 'Narra', 500, 500, NULL, NULL),
(161, '13-174001-0002-0001', NULL, 'sp', NULL, NULL, 'Narra', 500, 500, NULL, NULL),
(162, '13-174001-0003-0005', NULL, 'E3', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(163, '13-174001-0004-0014', NULL, 'pS', NULL, NULL, 'Narra', 7000, 7000, NULL, NULL),
(164, '13-174001-0005-0004', NULL, '91', NULL, NULL, 'Narra', 2000, 2000, NULL, NULL),
(165, '13-174001-0006-0043', NULL, 'D1', NULL, NULL, 'Bakauan', 55050, 55050, NULL, NULL),
(166, '13-174001-0007-0002', NULL, 'n1', NULL, NULL, 'Bakauan', 4000, 4000, NULL, NULL),
(167, '13-174001-0008-0006', NULL, 'sB', NULL, NULL, 'Narra', 2850, 2850, NULL, NULL),
(169, '13-174001-0009-0006', NULL, 'FG', NULL, NULL, 'Narra', 3000, 3000, NULL, NULL),
(170, '13-174001-0010-0005', NULL, 'AK', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(171, '13-174001-0012-0005', NULL, 'GH', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(173, '13-174001-0013-0009', NULL, 'Cr', NULL, NULL, 'Narra', 4500, 4500, NULL, NULL),
(174, '13-174001-0014-0027', NULL, 'B4', NULL, NULL, 'Coffee', 13500, 13500, NULL, NULL),
(175, '13-174001-0015-0015', NULL, 'mn', NULL, NULL, 'Narra', 7450, 7450, NULL, NULL),
(176, '13-174001-0016-0018', NULL, '2P', NULL, NULL, 'Narra', 8950, 8950, NULL, NULL),
(177, '13-174001-0017-0010', NULL, 'SU', NULL, NULL, 'Narra', 5000, 5000, NULL, NULL),
(178, '13-174001-0018-0058', NULL, 'vL', NULL, NULL, 'Narra', 29000, 29000, NULL, NULL),
(179, '13-174001-0019-0029', NULL, 'H6', NULL, NULL, 'Coffee', 14500, 14500, NULL, NULL),
(180, '13-174001-0020-0034', NULL, 'oc', NULL, NULL, 'Narra', 16900, 16900, NULL, NULL),
(181, '13-174001-0021-0005', NULL, 'JX', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(182, '13-174001-0022-0007', NULL, 'dT', NULL, NULL, 'Narra', 3500, 3500, NULL, NULL),
(183, '13-174001-0023-0008', NULL, 'Kg', NULL, NULL, 'Narra', 3950, 3950, NULL, NULL),
(184, '13-174001-0024-0024', NULL, 'y1', NULL, NULL, 'Narra', 12000, 12000, NULL, NULL),
(185, '13-174001-0025-0025', NULL, 'Xw', NULL, NULL, 'Narra,Coffee', 12500, 12500, NULL, NULL),
(186, '13-174001-0026-0038', NULL, 'iF', NULL, NULL, 'Coffee', 19000, 19000, NULL, NULL),
(187, '13-174001-0028-0001', NULL, 'Q7', NULL, NULL, 'Narra', 950, 950, NULL, NULL),
(188, '13-174001-0030-0040', NULL, 'SQ', NULL, NULL, 'Narra', 19900, 19900, NULL, NULL),
(189, '13-174001-0031-0022', NULL, 'Kn', NULL, NULL, 'Narra, Mahogany, Anchoan Dilaw, Kakawate', 11000, 11000, NULL, NULL),
(190, '13-174001-0032-0015', NULL, 'DQ', NULL, NULL, 'Bakauan', 29800, 29800, NULL, NULL),
(191, '13-174001-0033-0003', NULL, 't3', NULL, NULL, 'Narra, Mahagony, Fire Tree', 1500, 1500, NULL, NULL),
(192, '13-174001-0034-0004', NULL, 'PR', NULL, NULL, 'Narra,Fire Tree', 2000, 2000, NULL, NULL),
(193, '13-174001-0035-0031', NULL, 'af', NULL, NULL, 'Coffee', 15400, 15400, NULL, NULL),
(195, '13-174001-0036-0005', NULL, 'yU', NULL, NULL, 'Narra', 2500, 2500, NULL, NULL),
(196, '13-174001-0037-0017', NULL, 'ds', NULL, NULL, 'Narra', 8500, 8500, NULL, NULL),
(197, '13-174001-0038-0006', NULL, 'Tg', NULL, NULL, 'Coffee', 20000, 20000, NULL, NULL),
(198, '13-174001-0042-0044', NULL, '9X', NULL, NULL, 'Narra, Mahogany, Anchoan Dilaw, Kakawate', 22000, 22000, NULL, NULL),
(199, '13-174001-0043-0094', NULL, 'Nl', NULL, NULL, 'Coffee', 46950, 46950, NULL, NULL),
(200, '13-174001-0044-0030', NULL, '02', NULL, NULL, 'Bakauan', 60600, 60600, NULL, NULL),
(201, '13-174001-0045-0028', NULL, 'Db', NULL, NULL, 'Bakauan', 55200, 55200, NULL, NULL),
(202, '13-174001-0046-0009', NULL, 'X1', NULL, NULL, 'Coffee', 6000, 6000, NULL, NULL),
(203, '13-174001-0048-0005', NULL, 'Bk', NULL, NULL, 'Narra', 5000, 5000, NULL, NULL),
(204, '13-174001-0051-0003', NULL, 'IS', NULL, NULL, 'Narra', 1450, 1450, NULL, NULL),
(205, '13-174001-0052-0013', NULL, '07', NULL, NULL, 'Narra', 3500, 3500, NULL, NULL),
(207, '13-174001-0053-0007', NULL, 'Qw', NULL, NULL, 'Narra', 3000, 3000, NULL, NULL),
(208, '13-174001-0054-0003', NULL, 'pZ', NULL, NULL, 'Narra', 1000, 1000, NULL, NULL),
(209, '13-174001-0055-0091', NULL, 'Zw', NULL, NULL, 'Coffee', 45500, 45500, NULL, NULL),
(210, '13-174001-0056-0033', NULL, 'FN', NULL, NULL, 'Narra', 16500, 16500, NULL, NULL),
(211, '15-174001-0006-0001', NULL, 'GR', NULL, NULL, 'Bakauan', 16250, 16250, NULL, NULL),
(213, '15-174001-0026-0006', NULL, 'MZ', NULL, NULL, 'Bakauan', 12500, 12500, NULL, NULL),
(214, '15-174001-0039-0006', NULL, 'i1', NULL, NULL, 'Bakauan', 15000, 15000, NULL, NULL),
(216, '15-174001-0036-0003', NULL, 'jp', NULL, NULL, 'Bakauan', 7500, 7500, NULL, NULL),
(217, '15-174001-0001-0005', NULL, 'qi', NULL, NULL, 'Bakauan', 20000, 20000, NULL, NULL),
(218, '16-174001-0001-0027', NULL, 's3', NULL, NULL, 'Narra', 44982, 44982, NULL, NULL),
(219, '17-174001-0001-0025', NULL, 'zP', NULL, NULL, 'Narra', 47030, 47030, NULL, NULL),
(221, '17-174001-0003-0049', NULL, 'tc', NULL, NULL, 'Narra', 56250, 56250, NULL, NULL),
(222, '18-174000-0309-0013', NULL, '7K', NULL, NULL, 'Pipisik', 32900, 32900, NULL, NULL),
(223, '18-174000-0310-0004', NULL, 'mE', NULL, NULL, 'Pipisik', 28475, 28475, NULL, NULL),
(224, '18-174000-0029-0001', NULL, '9o', NULL, NULL, 'Kawayan Tinik', 204, 204, NULL, NULL),
(225, '18-174000-0020-0004', NULL, 'nD', NULL, NULL, 'Kawayang Tinik', 1801, 1801, NULL, NULL),
(227, '18-174000-0024-0000', NULL, 'lF', NULL, NULL, 'Kawayan Tinik', 302, 302, NULL, NULL),
(228, '18-174000-0028-0001', NULL, '99', NULL, NULL, 'Kawayang Tinik', 245, 245, NULL, NULL),
(229, '18-174000-0026-0001', NULL, 'ze', NULL, NULL, 'Kawayang Tinik', 245, 245, NULL, NULL),
(231, '18-174000-0017-0001', NULL, 'fe', NULL, NULL, 'Kawayang Tinik', 204, 204, NULL, NULL),
(232, '18-174000-0032-0001', NULL, 'T9', NULL, NULL, 'Kawayang Tinik', 302, 302, NULL, NULL),
(234, '18-174000-0033-0000', NULL, 'oz', NULL, NULL, 'Kawayang Tinik', 20, 20, NULL, NULL),
(235, '18-174000-0034-0003', NULL, 'uz', NULL, NULL, 'Kawayang Tinik', 547, 547, NULL, NULL),
(237, '18-174000-0036-0000', NULL, 'A8', NULL, NULL, 'Kawayang Tinik', 16, 16, NULL, NULL),
(238, '18-174000-0037-0002', NULL, 'oo', NULL, NULL, 'Kawayang Tinik', 386, 386, NULL, NULL),
(240, '18-174000-0038-0001', NULL, 'ZY', NULL, NULL, 'Kawayang Tinik', 261, 261, NULL, NULL),
(241, '18-174000-0039-0008', NULL, 'PQ', NULL, NULL, 'Kawayang Tinik', 1428, 1428, NULL, NULL),
(242, '18-174000-0010-0005', NULL, 'n4', NULL, NULL, 'Kawayang Tinik', 1020, 1020, NULL, NULL),
(243, '18-174000-0022-0028', NULL, '83', NULL, NULL, 'Kawayang Tinik', 7140, 7140, NULL, NULL),
(244, '18-174000-0015-0000', NULL, 'hb', NULL, NULL, 'Kawayang Tinik', 118, 118, NULL, NULL),
(245, '18-174000-0001-0006', NULL, 'bL', NULL, NULL, 'Kawayang Tinik', 1224, 1224, NULL, NULL),
(246, '18-174000-0002-0004', NULL, 'KU', NULL, NULL, 'Kawayang Tinik', 816, 816, NULL, NULL),
(248, '18-174000-0014-0001', NULL, 'nK', NULL, NULL, 'Kawayang Tinik', 102, 102, NULL, NULL),
(249, '18-174000-0018-0001', NULL, 'RC', NULL, NULL, 'Kawayang Tinik', 357, 357, NULL, NULL),
(250, '18-174000-0030-0000', NULL, 'V8', NULL, NULL, 'Kawayang Tinik', 92, 92, NULL, NULL),
(251, '18-174000-0035-0000', NULL, 'tr', NULL, NULL, 'Kawayang Tinik', 102, 102, NULL, NULL),
(252, '18-174000-0004-0010', NULL, 'Z7', NULL, NULL, 'Kawayang Tinik', 2040, 2040, NULL, NULL),
(253, '18-174000-0005-0002', NULL, 'Xx', NULL, NULL, 'Kawayang Tinik', 3060, 3060, NULL, NULL),
(254, '18-174000-0011-0007', NULL, 'o8', NULL, NULL, 'Kawayang Tinik', 2448, 2448, NULL, NULL),
(255, '18-174000-0003-0010', NULL, 'nM', NULL, NULL, 'Kawayang Tinik', 2040, 2040, NULL, NULL),
(257, '18-174000-0009-0030', NULL, 'RU', NULL, NULL, 'Narra, Guyabano, Cacao, Coffee Robusta, Madre de Cacao', 40190, 40190, NULL, NULL),
(258, '18-174000-0027-0040', NULL, '7D', NULL, NULL, 'Narra, Guyabano, Cacao, Coffee Robusta, Madre de Cacao', 51290, 51290, NULL, NULL),
(259, '18-174000-0307-0013', NULL, 'Vt', NULL, NULL, 'Pipisik', 43260, 43260, NULL, NULL),
(260, '18-174000-0266-0001', NULL, 'PB', NULL, NULL, 'Talisay', 662, 662, NULL, NULL),
(262, '18-174000-0267-0001', NULL, 'to', NULL, NULL, 'Talisay', 673, 673, NULL, NULL),
(263, '18-174000-0268-0002', NULL, '7r', NULL, NULL, 'Pipisik', 5087, 5087, NULL, NULL),
(264, '20-174000-0010-0007', NULL, 'zj', NULL, NULL, 'Nipa', 8750, 8750, NULL, NULL),
(265, '20-174000-0011-0007', NULL, 'i9', NULL, NULL, 'Nipa', 8750, 8750, NULL, NULL),
(266, '20-174000-0002-0007', NULL, 'bM', NULL, NULL, 'Nipa', 8750, 8750, NULL, NULL),
(268, '20-174000-0003-0007', NULL, 'nJ', NULL, NULL, 'Nipa', 8750, 8750, NULL, NULL),
(269, '20-174000-0004-0006', NULL, '5v', NULL, NULL, 'Nipa', 7500, 7500, NULL, NULL),
(270, '20-174000-0001-0012', NULL, 'Cv', NULL, NULL, 'Kawayang Tinik', 2800, 2800, NULL, NULL),
(271, '20-174000-0008-0001', NULL, 'jA', NULL, NULL, 'Nipa', 1250, 1250, NULL, NULL),
(273, '20-174000-0009-0006', NULL, '8z', NULL, NULL, 'Nipa', 7500, 7500, NULL, NULL),
(274, '20-174000-0012-0002', NULL, 'Hx', NULL, NULL, 'Nipa', 2500, 2500, NULL, NULL),
(275, '20-174000-0013-0004', NULL, '3Z', NULL, NULL, 'Nipa', 5000, 5000, NULL, NULL),
(277, '20-174000-0014-0008', NULL, 'ia', NULL, NULL, 'Nipa', 10000, 10000, NULL, NULL),
(278, '20-174000-0015-0003', NULL, 'hP', NULL, NULL, 'Nipa', 3750, 3750, NULL, NULL),
(279, '20-174000-0016-0002', NULL, 'y9', NULL, NULL, 'Nipa', 2500, 2500, NULL, NULL),
(280, '15-174001-0012-0000', NULL, 'Zg', NULL, NULL, 'Talisay', 12500, 12500, NULL, NULL),
(281, '11-174001-0009-0030', NULL, 'eZ', NULL, NULL, 'Narra', 15000, 15000, NULL, NULL),
(282, '15-174001-0003-0003', NULL, 'XC', NULL, NULL, 'Bakauan', 37500, 37500, NULL, NULL),
(283, '15-174001-0007-0020', NULL, 'en', NULL, NULL, 'Bakauan', 50000, 50000, NULL, NULL),
(285, '15-174001-0010-0010', NULL, 'dD', NULL, NULL, 'Bakauan', 25000, 25000, NULL, NULL),
(288, '15-174001-0011-0001Bb', NULL, 'gb', NULL, NULL, 'Bakauan', 2500, 2500, NULL, NULL),
(289, '15-174001-0012-0004', NULL, 'WO', NULL, NULL, 'Bakauan', 10000, 10000, NULL, NULL),
(290, '15-174001-0013-0008', NULL, 'SG', NULL, NULL, 'Bakauan', 135000, 135000, NULL, NULL),
(291, '15-174001-0017-0007', NULL, 'aE', NULL, NULL, 'Bakauan', 30000, 30000, NULL, NULL),
(292, '15-174001-0009-0002', NULL, 'zC', NULL, NULL, 'Bakauan', 0, 0, NULL, NULL),
(294, '15-174001-0020-0004', NULL, 'l0', NULL, NULL, 'Bakauan', 17500, 17500, NULL, NULL),
(295, '15-174001-0025-0040', NULL, 'C2', NULL, NULL, 'Bakauan', 100000, 100000, NULL, NULL),
(296, '15-174001-0027-0015', NULL, 'qt', NULL, NULL, 'Bakauan', 37500, 37500, NULL, NULL),
(297, '15-174001-0028-0002', NULL, 'ZV', NULL, NULL, 'Bakauan', 31250, 31250, NULL, NULL),
(298, '15-174001-0030-0005', NULL, 'uk', NULL, NULL, 'Bakauan', 50000, 50000, NULL, NULL),
(300, '15-174001-0033-0001', NULL, '0q', NULL, NULL, 'Bakauan', 2500, 2500, NULL, NULL),
(301, '15-174001-0034-0002', NULL, 'FS', NULL, NULL, 'Bakauan', 5000, 5000, NULL, NULL),
(302, '15-174001-0034-0010', NULL, '7W', NULL, NULL, 'Bakauan', 70000, 70000, NULL, NULL),
(303, '15-174001-0035-0002', NULL, 'T1', NULL, NULL, 'Bakauan', 5000, 5000, NULL, NULL),
(304, '15-174001-0036-0002', NULL, 'EU', NULL, NULL, 'Bakauan', 6000, 6000, NULL, NULL),
(305, '15-174001-0037-0002', NULL, 'c7', NULL, NULL, 'Bakauan', 5000, 5000, NULL, NULL),
(306, '15-174001-0037-0009', NULL, '4H', NULL, NULL, 'Bakauan', 20000, 20000, NULL, NULL),
(307, '15-174001-0038-0017', NULL, '44', NULL, NULL, 'Bakauan', 42500, 42500, NULL, NULL),
(308, '15-174001-0039-0010', NULL, 'hF', NULL, NULL, 'Bakauan', 25000, 25000, NULL, NULL),
(309, '15-174001-0040-0006', NULL, 'rz', NULL, NULL, 'Bakauan', 17500, 17500, NULL, NULL),
(310, '15-174001-0040-0010', NULL, '0Y', NULL, NULL, 'Bakauan', 25000, 25000, NULL, NULL),
(311, '15-174001-0041-0006', NULL, '5o', NULL, NULL, 'Bakauan', 15000, 15000, NULL, NULL),
(312, '15-174001-0041-0010', NULL, '3p', NULL, NULL, 'Bakauan', 25000, 25000, NULL, NULL),
(313, '15-174001-0042-0006', NULL, '8W', NULL, NULL, 'Bakauan', 15000, 15000, NULL, NULL),
(314, '15-174001-0043-0053', NULL, 'GD', NULL, NULL, 'Bakauan', 130000, 130000, NULL, NULL),
(315, '15-174001-0044-0006', NULL, 'Yt', NULL, NULL, 'Bakauan', 15000, 15000, NULL, NULL),
(317, '15-174001-0045-0021', NULL, 'a1', NULL, NULL, 'Bakauan', 52500, 52500, NULL, NULL),
(318, '15-174001-0046-0024', NULL, 'Lc', NULL, NULL, 'Bakauan', 60000, 60000, NULL, NULL),
(319, '15-174001-0048-0006', NULL, 'o9', NULL, NULL, 'Bakauan', 65000, 65000, NULL, NULL),
(320, '15-174001-0054-0002', NULL, 'b6', NULL, NULL, 'Bakauan', 55000, 55000, NULL, NULL),
(321, '15-174001-0019-0002', NULL, '76', NULL, NULL, 'Bakauan', 5000, 5000, NULL, NULL),
(322, '15-174001-0022-0021', NULL, 'Lm', NULL, NULL, 'Bakauan', 62500, 62500, NULL, NULL),
(323, '15-174001-0038-0012', NULL, '14', NULL, NULL, 'Bakauan', 30000, 30000, NULL, NULL),
(324, '21-174000-0003-0010', NULL, 'eF', NULL, NULL, 'Kawayang Tinik', 2200, 2200, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `ngpalldate`
--

CREATE TABLE `ngpalldate` (
  `No` int(11) DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  `Region` varchar(100) DEFAULT NULL,
  `District` varchar(100) DEFAULT NULL,
  `CENRO` varchar(100) DEFAULT NULL,
  `PENRO` varchar(100) DEFAULT NULL,
  `Municipality` varchar(100) DEFAULT NULL,
  `Barangay` varchar(73) DEFAULT NULL,
  `Name_of_Org` varchar(86) DEFAULT NULL,
  `Contact_Person` varchar(40) DEFAULT NULL,
  `Type_org` varchar(100) DEFAULT NULL,
  `Tenure` varchar(100) DEFAULT NULL,
  `Target_area` decimal(4,2) DEFAULT NULL,
  `Area_planted` double DEFAULT NULL,
  `Seedling_req` double DEFAULT NULL,
  `Seedling_pro` double DEFAULT NULL,
  `Seedling_plant` double DEFAULT NULL,
  `Contract_c` double DEFAULT NULL,
  `Component` varchar(30) DEFAULT NULL,
  `Commodity` varchar(48) DEFAULT NULL,
  `Narra` varchar(54) DEFAULT NULL,
  `Zone` varchar(32) DEFAULT NULL,
  `Unique_code` varchar(19) DEFAULT NULL,
  `Dis_date` varchar(19) DEFAULT NULL,
  `Dis_area_dam` varchar(100) DEFAULT NULL,
  `Dis_type_dam` varchar(27) DEFAULT NULL,
  `Activities_conducted` varchar(55) DEFAULT NULL,
  `Funding_source` varchar(15) DEFAULT NULL,
  `Final_date` varchar(24) DEFAULT NULL,
  `Survival_rate11_20` decimal(4,2) DEFAULT NULL,
  `Classification` varchar(10) DEFAULT NULL,
  `After_date` varchar(13) DEFAULT NULL,
  `After_area_dam` varchar(13) DEFAULT NULL,
  `After_type_dam` varchar(14) DEFAULT NULL,
  `third_date` varchar(10) DEFAULT NULL,
  `third_survival` varchar(10) DEFAULT NULL,
  `Date_visit` varchar(18) DEFAULT NULL,
  `Final_inspect_date` varchar(14) DEFAULT NULL,
  `Survival_rate(11-20)` decimal(4,2) DEFAULT NULL,
  `Remarks` varchar(109) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `ngpalldate`
--

INSERT INTO `ngpalldate` (`No`, `Year`, `Region`, `District`, `CENRO`, `PENRO`, `Municipality`, `Barangay`, `Name_of_Org`, `Contact_Person`, `Type_org`, `Tenure`, `Target_area`, `Area_planted`, `Seedling_req`, `Seedling_pro`, `Seedling_plant`, `Contract_c`, `Component`, `Commodity`, `Narra`, `Zone`, `Unique_code`, `Dis_date`, `Dis_area_dam`, `Dis_type_dam`, `Activities_conducted`, `Funding_source`, `Final_date`, `Survival_rate11_20`, `Classification`, `After_date`, `After_area_dam`, `After_type_dam`, `third_date`, `third_survival`, `Date_visit`, `Final_inspect_date`, `Survival_rate(11-20)`, `Remarks`) VALUES
(1, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Sihi', 'LGU Sihi', 'PB Antero Fiegalan', 'LGU', 'PA', 34.02, 34, 17000, 17000, 17000, 85782, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0001-0034', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.95, '', '', '', '', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.15, 'SR noted was during PENRO monthly site visit'),
(2, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'Tumagabok Small Farmers Association', 'Ma. Teresita Linga', 'PO', 'CBFM', 8.04, 8, 4000, 4000, 4000, 21309, 'Agroforestry', 'Timber, Fruit Trees', 'Narra, Langka, Guyabano, Rambutan', 'Production', '11-174001-0002-0008', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', 'April 16, 2019', 'April 16, 2019', 0.76, 'SR noted was during PENRO monthly site visit'),
(3, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 2.00, 2, 1000, 1000, 1000, 134261, 'Agroforestry', 'Fruit Trees', 'Langka', 'Production', '11-174001-0003-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.91, '', '', '', '', '', '', '', '', 0.00, ''),
(4, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 12.01, 12.01, 6000, 6000, 6000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0004-0012', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.86, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/5 of Site Code 11-174001-0004-0012'),
(5, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 7.04, 7.04, 3500, 3500, 3500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0005-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.86, '', '', '', '', '', '', 'February 28, 2020', 'Feb. 28, 2020', 0.30, 'Parcel 2/5 of Site Code 11-174001-0004-0012/ SR noted was during PENRO monthly site visit'),
(6, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 3.00, 3, 1500, 1500, 1500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0006-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.89, '', '', '', '', '', '', '', '', 0.00, 'Parcel 3/5 of Site Code 11-174001-0004-0012'),
(7, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 1.05, 1.05, 500, 500, 500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0007-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.87, '', '', '', '', '', '', '', '', 0.00, 'Parcel 4/5 of Site Code 11-174001-0004-0012'),
(8, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isidro Palomares', 'LGU', 'CBFM', 2.03, 2.03, 1000, 1000, 1000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0008-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', '', '', 0.00, 'Parcel 5/5 of Site Code 11-174001-0004-0012'),
(9, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Yook', 'LGU Yook', 'PB Edgar Perlas', 'LGU', 'Other Area', 30.02, 30, 15000, 15000, 15000, 75690, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0009-0030', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.93, '', '', '', '', '', '', '', '', 0.00, ''),
(10, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Hinangayon', 'LGU Hinanggayon', 'PB Edwin Jalac', 'LGU', 'CBFM', 40.05, 40, 20000, 20000, 20000, 102720, 'Agroforestry', 'Timber, Fruit Trees', 'Narra, Gmelina, Citrus, Langka, Guyabano', 'Protection', '11-174001-0010-0040', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.80, 'SR noted was during PENRO monthly site visit'),
(11, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Yook', 'LGU Yook', 'PB Edgar Perlas', 'LGU', 'Other Area', 30.01, 30, 15000, 15000, 15000, 75690, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0011-0030', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.94, '', '', '', '', '', '', '', '', 0.00, ''),
(12, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Binunga', 'LGU Binunga', 'PB Joseph Montemar', 'LGU', 'PA', 3.02, 3, 1500, 1500, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire Tree', 'Protection', '11-174001-0012-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.93, '', '', '', '', '', '', '', '', 0.00, ''),
(13, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Canat', 'LGU Canat', 'PB Mauro M. Labog', 'LGU', 'PA', 3.00, 3, 1500, 1500, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire Tree', 'Protection', '11-174001-0013-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', 'May 29, 2020', 'May 29, 2020', 0.15, 'SR noted was during PENRO monthly site visit'),
(14, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'LGU Malbog', 'Restituto Pabalat', 'LGU', 'PA', 4.07, 4, 2000, 2000, 2000, 10092, 'Reforestation', 'Timber', 'Narra, Fire Tree', 'Protection', '11-174001-0014-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.95, '', '', '', '', '', '', '', '', 0.00, ''),
(15, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Tungib, Lipata', 'LGU Bagtingon', 'PB Mario C. Francisco II', 'LGU', 'CBFM', 18.01, 60, 30000, 30000, 30000, 156555, 'Agroforestry', 'Timber, Fruit Trees', 'Narra, Guyabano', 'Production', '11-174001-0015-0018', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.85, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.69, 'Parcel 1/2 of Site Code 11-174001-0015-0018/SR noted was during PENRO monthly site visit'),
(16, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Tungib, Lipata', 'LGU Bagtingon', 'PB Mario C. Francisco II', 'LGU', 'CBFM', 41.05, 0, 0, 0, 0, 0, 'Agroforestry', 'Timber, Fruit Trees', 'Narra, Guyabano, Langka', 'Production', '11-174001-0016-0041', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.80, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.69, 'Parcel 2/2 of Site Code 11-174001-0015-0018'),
(17, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'San Isidro', 'LGU San Isidro', 'PB Porferio Manuba', 'LGU', 'CBFM', 8.66, 9, 4500, 4500, 4500, 23607, 'Reforestation', 'Timber. Fruit Trees', 'Narra, Tuai, Langka, Guyabano', 'Protection', '11-174001-0017-0009', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.80, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.60, 'SR noted was during PENRO monthly site visit'),
(18, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Sabong', 'LGU Sabong', 'PB Jose Nabos', 'LGU', 'PA', 3.01, 3, 1500, 1500, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0018-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.30, 'SR noted was during PENRO monthly site visit'),
(19, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Malabon', 'LGU Malabon', 'PB Conrado Melecia', 'LGU', 'Other Area', 9.00, 9, 4500, 4500, 4500, 22707, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0019-0009', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', 'January 18, 2020', 'Jan. 18, 2020', 0.50, 'SR noted was during PENRO monthly site visit'),
(20, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Kilo-kilo', 'LGU Kilo-kilo', 'PB Nolie Quindoza', 'LGU', 'Other Area', 10.04, 10, 5000, 5000, 5000, 25230, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0020-0010', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', '', '', 0.00, ''),
(21, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'LGU Bonliw', 'PB Joel Rey', 'LGU', 'Other Area', 11.66, 23, 6000, 0, 6000, 58029, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0021-0012', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.87, '', '', '', '', '', '', 'January 18, 2020', 'Jan. 18, 2020', 0.65, 'Parcel 1/3 of Site Code 11-174001-0021-0012'),
(22, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'LGU Bonliw', 'PB Joel Rey', 'LGU', 'Other Area', 5.04, 0, 2500, 0, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0022-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.85, '', '', '', '', '', '', 'January 18, 2020', 'Jan. 18, 2020', 0.65, 'Parcel 2/3 of Site Code 11-174001-0021-0012'),
(23, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'LGU Bonliw', 'PB Joel Rey', 'LGU', 'Other Area', 6.02, 0, 3000, 0, 3000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0023-0006', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.80, '', '', '', '', '', '', 'January 18, 2020', 'Jan. 18, 2020', 0.65, 'Parcel 3/3 of Site Code 11-174001-0021-0012'),
(24, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Balagasan', 'LGU Balagasan', 'PB Ulpiano Ugayre', 'LGU', 'Within/coinciding the PA', 3.03, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0024-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', '', '', 0.00, ''),
(25, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Hinapulan', 'LGU Hinapulan', 'PB Jose Lazarte', 'LGU', 'Within/coinciding the PA', 3.01, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0025-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', '', '', 0.00, ''),
(26, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Sihi', 'LGU Sihi', 'PB Antero Fiegalan', 'LGU', 'Within/coinciding the PA', 4.04, 4, 2000, 0, 2000, 10092, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0026-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.85, '', '', '', '', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.35, 'SR noted was during PENRO monthly site visit'),
(27, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Duyay', 'LGU Duyay', 'PB Allan Hizole', 'LGU', 'Within/coinciding the PA', 3.02, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0027-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.80, '', '', '', '', '', '', '', '', 0.00, ''),
(28, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Tiguion', 'LGU Tiguion', 'PB Vidal Sajo', 'LGU', 'PA', 3.03, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0028-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.96, '', '', '', '', '', '', '', '', 0.00, ''),
(29, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Antipolo', 'LGU Antipolo', 'PB Gonzalo Magpili', 'LGU', 'Within/coinciding the PA', 3.04, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0029-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.75, '', '', '', '', '', '', '', '', 0.00, ''),
(30, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Boi', 'LGU Boi', 'PB Crisostomo Monterey', 'LGU', 'Within/coinciding the PA', 3.01, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0030-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', '', '', 0.00, ''),
(31, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Devilla', 'LGU Devilla', 'PB Delfin Fellizar', 'LGU', 'PA', 3.05, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0031-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.92, '', '', '', '', '', '', '', '', 0.00, ''),
(32, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Libjo', 'LGU Libjo', 'Samuel Rescober', 'LGU', 'Other Area', 5.03, 5, 2500, 0, 2500, 12615, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0032-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', '', '', 0.00, ''),
(33, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'LGU Tumagabok', 'PB Ruben Apostol', 'LGU', 'Within/coinciding the PA', 1.07, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0033-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.48, '', '', '', '', '', '', 'June 24, 2020', 'June 24, 2020', 0.48, 'SR noted was during PENRO monthly site visit'),
(34, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tambunan', 'LGU Tambunan', 'PB Alejandro Opis', 'LGU', 'Within/coinciding the PA', 3.01, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0034-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.76, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13. 2020', 0.41, 'SR noted was during PENRO monthly site visit'),
(35, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tugos', 'LGU Tugos', 'PB Luis Luha', 'LGU', 'Within/coinciding the PA', 2.74, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0035-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.85, '', '', '', '', '', '', '', '', 0.00, ''),
(36, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Makulapnit', 'LGU Makulapnit', 'PB Iluminada Zulueta', 'LGU', 'Within/coinciding the PA', 2.12, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0036-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.83, '', '', '', '', '', '', '', '', 0.00, ''),
(37, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Masalukot', 'LGU Masalukot', 'PB Victor Riego, Sr', 'LGU', 'PA', 3.06, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0037-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.90, '', '', '', '', '', '', '', '', 0.00, ''),
(38, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Malibago', 'LGU Malibago', 'PB Joel Regis', 'LGU', 'Within/coinciding the PA', 2.65, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0038-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.75, '', '', '', '', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.32, 'SR noted was during PENRO monthly site visit'),
(39, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagtingon', 'LGU Bagtingon', 'PB Mario Frnacisco II', 'LGU', 'Within/coinciding the PA', 3.40, 4, 2000, 0, 2000, 10092, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0039-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.85, '', '', '', '', '', '', '', '', 0.00, ''),
(40, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Bayuti', 'LGU Bayuti', 'PB Danilo Nabos', 'LGU', 'Within/coinciding the PA', 2.24, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0040-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.80, '', '', '', '', '', '', '', '', 0.00, ''),
(41, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Tambangan', 'LGU Tambangan', 'PB Ruben Pelandiana', 'LGU', 'Within/coinciding the PA', 2.67, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Fire tree', 'Protection', '11-174001-0041-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.93, '', '', '', '', '', '', '', '', 0.00, ''),
(42, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Nangka', 'LGU Nangka', 'PB Diosdado Pastoral', 'LGU', 'PA', 3.06, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0042-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.88, '', '', '', '', '', '', '', '', 0.00, ''),
(43, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'LGU Sibuyao', 'PB Isdro Palomares', 'LGU', 'PA', 3.03, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra', 'Protection', '11-174001-0043-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.89, '', '', '', '', '', '', 'June 24, 2020', 'June 24, 2020', 0.40, ''),
(44, 2011, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tabi', 'LGU Tabi', 'PB Florencio Mogol', 'LGU', 'Other Area', 3.01, 3, 1500, 0, 1500, 7569, 'Reforestation', 'Timber', 'Narra, Acacia', 'Protection', '11-174001-0044-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan-15', 0.00, '', '', '', '', '', '', 'December 07, 2019', 'Dec. 07, 2019', 0.00, ''),
(45, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagacay', 'LGU Bagacay', 'Belardo Salvacion', 'LGU', 'Other Area', 14.39, 14, 7000, 0, 7000, 119000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0001-0014', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.92, '', '', '', '', '', '', '', '', 0.00, ''),
(46, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.42, 33, 15000, 0, 15000, 412500, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0002-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 1/21 of Site Code 12-174001-0002-0001'),
(47, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 7.19, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0003-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 2/21 of Site Code 12-174001-0002-0001'),
(48, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 2.97, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0004-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 3/21 of Site Code 12-174001-0002-0001'),
(49, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.98, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0005-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 4/21 of Site Code 12-174001-0002-0001'),
(50, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.51, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0006-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 5/21 of Site Code 12-174001-0002-0001'),
(51, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 4.02, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0007-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.84, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 6/21 of Site Code 12-174001-0002-0001'),
(52, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.31, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0008-0000', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 7/21 of Site Code 12-174001-0002-0001'),
(53, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.52, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0009-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.90, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 8/21 of Site Code 12-174001-0002-0001'),
(54, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.26, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0010-0000', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 1.00, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 9/21 of Site Code 12-174001-0002-0001'),
(55, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.71, 0, 0, 0, 0, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0011-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 1.00, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 10/21 of Site Code 12-174001-0002-0001'),
(56, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.14, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0013-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 11/21 of Site Code 12-174001-0002-0001'),
(57, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.10, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0014-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.98, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 12/21 of Site Code 12-174001-0002-0001'),
(58, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 2.22, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0015-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 13/21 of Site Code 12-174001-0002-0001'),
(59, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.58, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0016-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 1.00, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 14/21 of Site Code 12-174001-0002-0001'),
(60, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.28, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0017-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.90, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 15/21 of Site Code 12-174001-0002-0001'),
(61, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.65, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0018-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 1.00, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 16/21 of Site Code 12-174001-0002-0001'),
(62, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.17, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0019-0000', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 1.00, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 17/21 of Site Code 12-174001-0002-0001'),
(63, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 4.22, 0, 0, 0, 0, 0, 'Agroforestry', 'Coffee', 'Coffee', 'Production', '12-174001-0022-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 18/21 of Site Code 12-174001-0002-0001'),
(64, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.44, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Cacao', 'Production', '12-174001-0023-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.88, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 19/21 of Site Code 12-174001-0002-0001'),
(65, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 0.04, 0, 0, 0, 0, 0, 'Agroforestry', 'Coffee', 'Coffee', 'Production', '12-174001-0024-0000', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 20/21 of Site Code 12-174001-0002-0001'),
(66, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio Sajul', 'PO', 'CBFM', 1.00, 0, 0, 0, 0, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '12-174001-0027-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.85, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.71, 'Parcel 21/21 of Site Code 12-174001-0002-0001'),
(67, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Nangka', 'Naampias Watershed Association Inc. (NWAI)', 'Diosdado Pastoral', 'PO', 'CBFM', 50.38, 50, 25000, 0, 25000, 425000, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '12-174001-0012-0050', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', '', '', 0.00, ''),
(68, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Tabionan', 'LGU Tabionan', 'Marianito Sena', 'LGU', 'PA', 45.45, 45, 22500, 0, 22500, 612000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0020-0045', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.85, '', '', '', '', '', '', '', '', 0.00, ''),
(69, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Tabionan', 'LGU Tabionan', 'Marianito Sena', 'LGU', 'Untenured', 27.46, 27, 13500, 0, 13500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0021-0027', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', '', '', 0.00, ''),
(70, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'Tumagabok Small Farmers Association', 'Ma. Teresita Linga', 'PO', 'PA', 11.05, 11, 5500, 0, 5500, 357000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0025-0011', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', '', '', 0.00, ''),
(71, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'Tumagabok Small Farmers Association', 'Ma. Teresita Linga', 'PO', 'PA', 31.38, 31, 15500, 0, 15500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0026-0031', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.85, '', '', '', '', '', '', 'February 28, 2020', 'Feb. 28, 2020', 0.40, 'SR noted was during PENRO monthly site visit'),
(72, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Tawiran', 'LGU Tawiran', 'PB Domingo Estrella', 'LGU', 'Untenured', 10.76, 10, 25000, 0, 25000, 60000, 'Reforestation', 'Mangrove', 'Bakauan Babae, Bakauan Lalake', 'Protection', '12-174001-0028-0011', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'January 18, 2020', 'Jan. 18, 2020', 0.92, 'SR noted was during PENRO monthly site visit'),
(73, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Maranlig', 'LGU Maranlig', 'Romeo Pedrialva', 'LGU', 'Untenured', 20.40, 20, 10000, 0, 10000, 170000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0029-0020', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.86, '', '', '', '', '', '', 'April 16, 2019', 'Apr. 16, 2019', 0.83, 'SR noted was during PENRO monthly site visit'),
(74, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Bamban', 'LGU Bamban', 'PB Reden Maquimot', 'LGU', '', 3.15, 3, 1500, 0, 1500, 30000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0030-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.73, '', '', '', '', '', '', 'February 21, 2020', 'Feb. 21, 2020', 0.00, 'Affected by dike construction.'),
(75, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Hinapulan', 'LGU Hinapulan', 'PB Jose Lazarte', 'LGU', '', 3.05, 3, 1500, 0, 1500, 80000, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0031-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.74, '', '', '', '', '', '', '', '', 0.00, ''),
(76, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Hinapulan', 'LGU Hinapulan', 'PB Jose Lazarte', 'LGU', '', 5.43, 5, 2500, 0, 2500, 0, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0032-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.71, '', '', '', '', '', '', '', '', 0.00, ''),
(77, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Boton', 'LGU Boton', 'PB Xavier Laton', 'LGU', '', 4.14, 4, 2000, 0, 2000, 40000, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0033-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.72, '', '', '', '', '', '', 'December 07, 2019', 'Dec. 07, 2019', 0.00, ''),
(78, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Mainit', 'LGU Mainit', 'Kgwd. Jay Montiano', 'LGU', '', 6.19, 7, 3500, 0, 3500, 70000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0034-0006', 'October 25-26, 2012', 'Riverbank', 'Typhoon \"Ofel\" & flashflood', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.71, '', '', '', '', '', '', 'June 25, 2020', 'June 25, 2020', 0.00, 'Affected by typhoons & flashflood.'),
(79, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Boi and Bayuti', 'LGU Boi , LGU Bayuti', 'PB Crisostomo Monterey , PB Danilo Nabos', 'LGU', '', 12.85, 12, 6000, 0, 6000, 120000, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0035-0013', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.75, '', '', '', '', '', '', '', '', 0.00, ''),
(80, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Bantay', 'LGU Bantay', 'PB Amelia Magdurulan', 'LGU', '', 5.03, 5, 2500, 0, 2500, 50000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0036-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.48, '', '', '', '', '', '', 'May 29, 2020', 'May 29, 2020', 0.00, 'Affected by typhoons & flashflood.'),
(81, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Ogbac', 'LGU Ogbac', 'PB Gerry Magdalita', 'LGU', '', 4.67, 5, 2500, 0, 2500, 50000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0039-0005', 'October 25-26, 2012', 'Riverbank', 'Typhoon \"Ofel\" & flashflood', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.35, '', '', '', '', '', '', 'June 27, 2020', 'June 27, 2020', 0.00, 'Affected by typhoons & flashflood.'),
(82, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Balimbing', 'LGU Balimbing', 'PB Antonio  Jalotjot', 'LGU', '', 7.16, 6, 3000, 0, 3000, 60000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0040-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.14, '', '', '', '', '', '', 'May 29, 2020', 'May 29, 2020', 0.00, 'Affected by dike construction.'),
(83, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumapon , Daig , Poctoy', 'LGU Tumapon', 'PB Imee Lara', 'LGU', '', 7.08, 2, 3500, 0, 3500, 20000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0041-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.79, '', '', '', '', '', '', 'February 21, 2020', 'Feb. 21, 2020', 0.00, 'Affected by dike construction.'),
(84, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tampus', 'LGU Tampus', 'PB Armando Mayores', 'LGU', '', 1.06, 1, 500, 0, 500, 10000, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0042-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.71, '', '', '', '', '', '', 'December 07, 2019', 'Dec. 07, 2019', 0.00, ''),
(85, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Daypay', 'LGU Daypay', 'PB Teresita Malapad', 'LGU', 'Untenured', 3.00, 3, 1500, 0, 1500, 30000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0043-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.72, '', '', '', '', '', '', 'December 07, 2019', 'Dec. 07, 2019', 0.00, ''),
(86, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Sawi', 'LGU Sawi', 'PB Miguel Magcamit', 'LGU', '', 5.15, 5, 2500, 0, 2500, 50000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0044-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.72, '', '', '', '', '', '', 'December 07, 2019', 'Dec. 07, 2019', 0.00, ''),
(87, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Catubugan', 'LGU Catubugan', 'PB Erlando De Leon', 'LGU', '', 2.05, 2, 1000, 0, 1000, 20000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0045-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.72, '', '', '', '', '', '', 'February 21, 2020', 'Feb. 21, 2020', 0.00, 'Affected by dike construction.'),
(88, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Balagasan', 'LGU Balagasan', 'PB Ulpiano Ugayre', 'LGU', '', 2.05, 2, 1000, 0, 1000, 20000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0046-0002', 'October 25-26, 2012', 'Riverbank', 'Typhoon \"Ofel\" & flashflood', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.71, '', '', '', '', '', '', 'June 27, 2020', 'June 27, 2020', 0.00, 'Affected by typhoons & flashflood.'),
(89, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Canat', 'LGU Canat', 'PB Mauro Labog', 'LGU', '', 5.18, 7, 3500, 0, 3500, 70000, 'Reforestation', 'Timber', 'Narra', 'Protection', '12-174001-0047-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.76, '', '', '', '', '', '', '', '', 0.00, ''),
(90, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog, Timbo', 'LGU Buenavista', 'Mayor Russel Madrigal', 'Municipal LGU', 'Untenured', 1.84, 2, 2000, 0, 2000, 120150, 'Reforestation (Urban)', 'Timber', 'Narra', 'Protection', '12-174001-0048-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.20, 'SR noted was during PENRO monthly site visit- affected by road widening.'),
(91, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Caigangan , Poblacion, Antipolo, and Daykitin', 'LGU  Buenavista', 'Mayor Russel Madrigal', 'Municipal LGU', 'Untenured', 1.32, 1, 1500, 0, 1500, 0, 'Reforestation (Urban)', 'Timber', 'Narra', 'Protection', '12-174001-0049-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.87, '', '', '', '', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.20, 'SR noted was during PENRO monthly site visit- affected by road widening.'),
(92, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Binunga', 'LGU Binunga', 'PB Joseph Montemar', 'LGU', '', 1.00, 1, 1500, 0, 1500, 60000, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0038-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.12, '', '', '', '', '', '', '', '', 0.00, ''),
(93, 2012, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Binunga', 'LGU Binunga', 'PB Joseph Montemar', 'LGU', '', 3.00, 3, 1500, 0, 1500, 0, 'Reforestation', 'Bamboo', 'Bamboo', 'Protection', '12-174001-0037-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 22, 2016', 0.19, '', '', '', '', '', '', '', '', 0.00, ''),
(94, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Pinggan', 'LGU Dawis', 'Rommel Sadim', 'LGU', 'Untenured', 1.18, 1, 500, 500, 500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0001-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.76, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.68, 'The last SR noted was during PENRO monthly site visit.'),
(95, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Pinggan', 'LGU Dawis', 'Rommel Sadim', 'LGU', 'Untenured', 1.32, 1, 500, 500, 500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0002-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.74, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.68, 'The last SR noted was during PENRO monthly site visit.'),
(96, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Cabugao', 'Samahan ng Nagkakaisang Magsasaka ng Brgy. Duyay', 'Rolando P. Sapallo', 'PO', 'Untenured', 5.50, 5, 2500, 2500, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0003-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan 26 to Feb. 29, 2016', 0.80, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.60, 'The last SR noted was during PENRO monthly site visit.'),
(97, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Tapuyan', 'Samahan ng Nagkakaisang Magsasaka ng Brgy. Duyay', 'RolandoP.  Sapallo', 'PO', 'Untenured', 14.19, 14, 7000, 7000, 7000, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0004-0014', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.84, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.60, 'The last SR noted was during PENRO monthly site visit.'),
(98, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Antipolo', 'LGU Antipolo', 'Gonzalo Magpili', 'LGU', '', 4.40, 4, 2000, 2000, 2000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0005-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.76, '', '', '', '', '', '', '', '', 0.00, ''),
(99, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Tawiran', 'LGU Tawiran', 'Bienvenido Palma', 'LGU', '', 43.38, 30, 60000, 60000, 60000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '13-174001-0006-0043', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.80, '', '', '', '', '', '', '', '', 0.00, ''),
(100, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', '', 2.32, 2, 4000, 4000, 4000, 0, 'Reforestation', 'Timber', 'Bakauan', 'Protection', '13-174001-0007-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.87, '', '', '', '', '', '', 'February 20, 2019', 'Feb. 20, 2019', 0.00, ''),
(101, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio  Sajul', 'PO', 'Within/coinciding the PA', 5.71, 6, 3000, 3000, 3000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0008-0006', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.76, '', '', '', '', '', '', '', '', 0.00, ''),
(102, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Binunga', 'LGU Binunga', 'Joseph Montemar', 'LGU', '', 6.32, 6, 3000, 3000, 3000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0009-0006', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.88, '', '', '', '', '', '', '', '', 0.00, ''),
(103, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagtingon', 'Bagtingon Butterfly Breeders Association (B3A), Inc.', 'Mario C. Francisco II', 'PO', 'Untenured', 5.11, 5, 2500, 2500, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0010-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', 'January 25, 2019', 'Jan. 25, 2019', 0.78, 'The last SR noted was during PENRO monthly site visit.'),
(104, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagtingon', 'Bagtingon Butterfly Breeders Association (B3A), Inc.', 'Mario Francisco II', 'PO', 'Untenured', 4.18, 4, 2000, 2000, 2000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0011-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', '', '', 0.00, ''),
(105, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Boi', 'LGU Boi', 'Crisostomo Monterey', 'LGU', 'Untenured', 5.03, 5, 2500, 2500, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0012-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.86, '', '', '', '', '', '', '', '', 0.00, ''),
(106, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tugos', 'Tanikala ng Pagkakaisa Multi-Purpose Cooperative', 'Pacifico Mabato', 'PO', 'Untenured', 9.01, 9, 4500, 4500, 4500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0013-0009', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.87, '', '', '', '', '', '', '', '', 0.00, ''),
(107, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Sabong', 'Sibuyao Vegetable Growers Association', 'Reden G. Fidelino', 'PO', '', 27.36, 27, 13500, 13500, 13500, 0, 'Agroforestry', 'Fruit Trees', 'Coffee/Pili', 'Production', '13-174001-0014-0027', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.86, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.50, 'The last SR noted was during PENRO monthly site visit.'),
(108, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bicas-bicas', 'LGU Libas', 'Wenifredo Riego', 'LGU', 'Untenured', 14.90, 15, 7500, 7500, 7500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0015-0015', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.76, '', '', '', '', '', '', '', '', 0.00, ''),
(109, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio  Sajul', 'PO', '', 17.98, 18, 9000, 9000, 9000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0016-0018', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', '', '', 0.00, ''),
(110, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Malbog Upland Farmers Association (MUFA)', 'Rolinio  Sajul', 'PO', 'Untenured', 10.31, 10, 5000, 5000, 5000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0017-0010', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.80, '', '', '', '', '', '', '', '', 0.00, ''),
(111, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Sihi', 'Sariling Sikap Farmers Association', 'Helen Fiegalan', 'PO', 'Untenured', 58.28, 58, 29000, 29000, 29000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0018-0058', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', '', '', 0.00, ''),
(112, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Makawayan', 'Makawayan Upland Farmers Association', 'Apolonio Pinion', 'PO', 'ISF', 29.31, 29, 14500, 0, 14500, 0, 'Agroforestry', 'Fruit Trees', 'Coffee', 'Production', '13-174001-0019-0029', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.84, '', '', '', '', '', '', '', '', 0.00, ''),
(113, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Duyay', 'Samahan ng Nagkakaisang Magsasaka ng Brgy. Duyay', 'Rolando Sapallo', 'PO', '', 33.84, 34, 17000, 17000, 17000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0020-0034', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.90, '', '', '', '', '', '', '', '', 0.00, ''),
(114, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Hinapulan', 'LGU Hinapulan', 'Jose Lazarte', 'LGU', 'Untenured', 5.08, 5, 2500, 2500, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0021-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.92, '', '', '', '', '', '', '', '', 0.00, ''),
(115, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Sumangga', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Untenured', 7.29, 7, 3500, 3500, 3500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0022-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.82, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'The last SR noted was during PENRO monthly site visit.'),
(116, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Gasan', 'Dawis', 'LGU Dawis', 'Rommel Sadim', 'LGU', 'Untenured', 7.97, 8, 4000, 4000, 4000, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0023-0008', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.75, '', '', '', '', '', '', 'June 26, 2019', 'June 26, 2019', 0.68, 'The last SR noted was during PENRO monthly site visit.'),
(117, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Lipata', 'Samahang Kapit Bisig ng Magsasaka sa Tungib-Lipata', 'Rodelio Sotto', 'PO', 'Untenured', 24.20, 24, 12000, 12000, 12000, 0, 'Reforestation', 'Timber', 'Narra, Pili', 'Protection', '13-174001-0024-0024', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.85, '', '', '', '', '', '', '', '', 0.00, ''),
(118, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Yook', 'Mt. Malindig Producers Cooperative (MMPC) , Samahan ng Magsasaka sa Pinagbulugan (SMP)', 'David G. Vitto ,  Nilo Saludes', 'PO', '', 25.20, 25, 12500, 12500, 12500, 0, 'Agroforestry and Reforestation', 'Timber, High Value Crops', 'Coffee', 'Production', '13-174001-0025-0025', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.75, '', '', '', '', '', '', '', '', 0.00, ''),
(119, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Yook', 'Samahan ng Magsasaka sa Pinagbulugan (SMP)', 'Nilo S. Saludes', 'PO', '', 38.33, 38, 19000, 19000, 19000, 0, 'Agroforestry', 'Timber, Fruit Trees', 'Narra, Coffee, Pili', 'Production', '13-174001-0026-0038', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.85, '', '', '', '', '', '', 'January 25, 2019', 'Jan. 25, 2019', 0.85, 'The last SR noted was during PENRO monthly site visit.'),
(120, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Lipata', 'Samahang Kapit-Bisig ng Magsasaka sa Tungib-Lipata', 'Rodelio Sotto', 'PO', '', 30.24, 30, 15000, 15000, 15000, 0, 'Agroforestry', 'Timber', 'Narra, Pili', 'Production and Protection', '13-174001-0027-0030', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.85, '', '', '', '', '', '', '', '', 0.00, '');
INSERT INTO `ngpalldate` (`No`, `Year`, `Region`, `District`, `CENRO`, `PENRO`, `Municipality`, `Barangay`, `Name_of_Org`, `Contact_Person`, `Type_org`, `Tenure`, `Target_area`, `Area_planted`, `Seedling_req`, `Seedling_pro`, `Seedling_plant`, `Contract_c`, `Component`, `Commodity`, `Narra`, `Zone`, `Unique_code`, `Dis_date`, `Dis_area_dam`, `Dis_type_dam`, `Activities_conducted`, `Funding_source`, `Final_date`, `Survival_rate11_20`, `Classification`, `After_date`, `After_area_dam`, `After_type_dam`, `third_date`, `third_survival`, `Date_visit`, `Final_inspect_date`, `Survival_rate(11-20)`, `Remarks`) VALUES
(121, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Nangka II', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Riverbanks', 1.42, 2, 1000, 1000, 1000, 240000, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0028-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'Parcel 1/2 of site code 13-174001-0028-0001/ The last SR noted was during PENRO monthly site visit.'),
(122, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Nangka II', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Riverbanks', 0.59, 1, 500, 500, 500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0029-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'Parcel 2/2 of site code 13-174001-0028-0001/ The last SR noted was during PENRO monthly site visit.'),
(123, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Nangka II , Sumangga , Malusak , Magapua , Banto, Butansapa , and Boc-boc', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Riverbanks', 39.88, 40, 20000, 0, 20000, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0030-0040', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.80, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'The last SR noted was during PENRO monthly site visit'),
(124, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tugos', 'Tanikala ng Pagkakaisa Multi-Purpose Cooperative', 'Pacifico Mabato', 'PO', 'PA', 22.23, 22, 11000, 11000, 11000, 0, 'Reforestation', 'Timber and Fuelwood', 'Narra, Mahogany , Anchoan Dilaw, Kakawate', 'Protection', '13-174001-0031-0022', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.85, '', '', '', '', '', '', '', '', 0.00, ''),
(125, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Balogo', 'LGU Balogo', 'Redugerio Rizal', 'LGU', '', 14.93, 15, 30000, 30000, 30000, 195000, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '13-174001-0032-0015', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', 'Dec. 26, 2016', 'Mangrove area', 'Typhoon \"Nina\"', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.55, 'The last SR noted was during PENRO monthly site visit.'),
(126, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Poblacion and Maranlig', 'Sibuyao Vegetable Growers Association', 'Reden Fidelino', 'PO', 'Untenured', 3.19, 3, 1204, 1204, 1204, 210000, 'Reforestation (Urban)', 'Timber', 'Narra , Mahogany, Fire tree', 'Protection', '13-174001-0033-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', 'April 16, 2019', 'Apr. 16, 2019', 0.30, 'The last SR noted was during PENRO monthly site visit.'),
(127, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Maranlig and Nangka', 'Sibuyao Vegetable Grower Association', 'Reden Fidelino', 'PO', 'Untenured', 4.32, 4, 1596, 1596, 1596, 0, 'Reforestation (Urban)', 'Timber', 'Narra , Mahogany, Fire tree', 'Protection', '13-174001-0034-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.76, '', '', '', '', '', '', 'April 16, 2019', 'Apr. 16, 2019', 0.30, 'The last SR noted was during PENRO monthly site visit.'),
(128, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Canat', 'Canat Upland Farmers Association', 'Reynante Mayorga', 'PO', 'CBFMA', 30.82, 31, 15500, 15500, 15500, 275900, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0035-0031', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.84, '', '', '', '', '', '', 'May 29, 2020', 'May 29, 2020', 0.40, 'The last SR noted was during PENRO monthly site visit.'),
(129, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Caigangan', 'Caigangan Credit Cooperative (CCC)', 'Enrico Roqueza', 'PO', 'Riverbanks', 5.46, 5, 2500, 2500, 2500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0036-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', 'Dec. 26, 2016', 'Riverbanks', 'Typhoon \"Nina\"', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.28, 'The last SR noted was during PENRO monthly site visit.'),
(130, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Caigangan and Bagtingon', 'Caigangan Credit Cooperative (CCC) ,  Butterfly Breeders Association (B3A)', 'Enrico Roqueza , Mario Francisco II', 'PO', 'Riverbanks', 17.27, 17, 8500, 8500, 8500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0037-0017', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', 'Dec. 26, 2016', 'Riverbanks', 'Typhoon \"Nina\"', '', '', 'October 25, 2019', 'Oct. 25, 2019', 0.28, 'The last SR noted was during PENRO monthly site visit.'),
(131, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tambunan', 'Tambunan Farmers Association (TFA)', 'Celedonia Naranjo', 'PO', 'ISF', 5.98, 40, 20000, 20000, 20000, 236000, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0038-0006', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.45, 'Parcel 1/4 of Site Code 13-174001-0038-0006/ The last SR noted was during PENRO monthly site visit.'),
(132, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tambunan', 'Tambunan Farmers Association (TFA)', 'Celedonia Naranjo', 'PO', 'ISF', 4.28, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0039-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.45, 'Parcel 2/4 of Site Code 13-174001-0038-0006/ The last SR noted was during PENRO monthly site visit.'),
(133, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tambunan', 'Tambunan Farmers Association (TFA)', 'Celedonia Naranjo', 'PO', 'ISF', 5.05, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0040-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.45, 'Parcel 3/4 of Site Code 13-174001-0038-0006/ The last SR noted was during PENRO monthly site visit.'),
(134, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tambunan', 'Tambunan Farmers Association (TFA)', 'Celedonia Naranjo', 'PO', 'ISF', 31.31, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0041-0031', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.83, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.45, 'Parcel 4/4 of Site Code 13-174001-0038-0006/ The last SR noted was during PENRO monthly site visit.'),
(135, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tugos', 'Tanikala ng Pagkakaisa Multi-Purpose Cooperative', 'Pacifico Mabato', 'PO', '', 45.00, 44, 22000, 0, 22000, 0, 'Reforestation', 'Timber, Fuelwood', 'Narra, Mahogany , Anchoan Dilaw, and Kakawate', 'Production and Protection', '13-174001-0042-0044', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.84, '', '', '', '', '', '', '', '', 0.00, ''),
(136, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagtingon', 'Butterfly Breeders Association (B3A)', 'Mario Francisco II', 'PO', 'CBFMA', 93.99, 94, 47000, 47000, 47000, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0043-0094', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.86, '', '', '', '', '', '', '', '', 0.00, ''),
(137, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', 'Mangrove', 30.39, 58, 116000, 120000, 116000, 0, 'Reforestation', 'Timber', 'Bakauan', 'Protection', '13-174001-0044-0030', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.90, '', '', '', '', '', '', 'February 20, 2019', 'Feb. 20, 2019', 0.00, 'Parcel 1/2 of Site Code 13-174001-0044-0030/ The last SR noted was during PENRO monthly site visit.'),
(138, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', 'Mangrove', 27.63, 0, 0, 0, 0, 0, 'Reforestation', 'Timber', 'Bakauan', 'Protection', '13-174001-0045-0028', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', 'February 20, 2019', 'Feb. 20, 2019', 0.00, 'Parcel 2/2 of Site Code 13-174001-0044-0030/ The last SR noted was during PENRO monthly site visit.'),
(139, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Dating Bayan and Punong', 'Samahan ng Maliliit na Mangingisda sa Dating Bayan at Punong', 'Paciano Rodelas', 'PO', 'ISF', 8.80, 12, 6000, 6000, 6000, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0046-0009', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.81, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 13-174001-0046-0009'),
(140, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Dating Bayan and Punong', 'Samahan ng Maliliit na Mangingisda sa Dating Bayan at Punong', 'Paciano Rodelas', 'PO', 'ISF', 3.88, 0, 0, 0, 0, 0, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0047-0004', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 13-174001-0046-0009'),
(141, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Payanas', 'LGU Bayakbakin', 'Felipe Penales', 'LGU', 'CBFMA', 4.69, 10, 5000, 5000, 5000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0048-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.77, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/3 of Site Code 13-174001-0048-0005'),
(142, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Payanas', 'LGU Bayakbakin', 'Felipe Penales', 'LGU', '', 1.66, 0, 0, 0, 0, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0049-0002', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/3 of Site Code 13-174001-0048-0005'),
(143, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Payanas', 'LGU Bayakbakin', 'Felipe Penales', 'LGU', '', 5.23, 0, 0, 0, 0, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0050-0005', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 3/3 of Site Code 13-174001-0048-0005'),
(144, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Banto and Butansapa', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Untenured', 2.98, 3, 1500, 1500, 1500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0051-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.80, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'The last SR noted was during PENRO monthly site visit.'),
(145, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tugos', 'Tanikala ng Pagkakaisa Multi-Purpose Cooperative', 'Pacifico Mabato', 'PO', 'Untenured', 10.54, 7, 3500, 3500, 3500, 0, 'Reforestation', 'Timber', 'Narra', 'Production and Protection', '13-174001-0052-0013', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.81, '', '', '', '', '', '', '', '', 0.00, ''),
(146, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Malusak', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Untenured', 6.24, 6, 3000, 3000, 3000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0053-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.81, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'The last SR noted was during PENRO monthly site visit.'),
(147, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Magapua', 'Federation of Mogpog Farmers Association', 'Delson Leal', 'PO', 'Untenured', 2.13, 2, 1000, 1000, 1000, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0054-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.78, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.38, 'The last SR noted was during PENRO monthly site visit.'),
(148, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Talawan', 'Tambunan Farmers Association (TFA)', 'Celedonia Naranjo', 'PO', 'ISF', 91.23, 91, 45500, 45500, 45500, 536900, 'Agroforestry', 'High Value Crops', 'Coffee', 'Production', '13-174001-0055-0091', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.89, '', '', '', '', '', '', 'March 13, 2020', 'Mar. 13, 2020', 0.55, 'The last SR noted was during PENRO monthly site visit.'),
(149, 2013, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'Sibuyao Vegetable Growers Association', 'Reden Fidelino', 'PO', 'Within/coinciding the PA', 33.37, 33, 16500, 16500, 16500, 0, 'Reforestation', 'Timber', 'Narra', 'Protection', '13-174001-0056-0033', '', '', '', 'Regular Target', 'Regular Fund', 'Jan. 26 to Feb. 29, 2016', 0.82, '', '', '', '', '', '', '', '', 0.00, ''),
(150, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 5.14, 5, 50000, 0, 50000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0030-0005', '', '', '', '', 'Regular Fund', 'Dec-17', 0.45, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.85, 'Parcel 1/5 of Site Code 15-174001-0030-0005/The last SR noted was during PENRO monthly site visit.'),
(151, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 5.03, 5, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0031-0005', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.85, 'Parcel 2/5 of Site Code 15-174001-0030-0005/ The last SR noted was during PENRO monthly site visit.'),
(152, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Malinao', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 2.44, 2.6, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0032-0002', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.85, 'Parcel 3/5 of Site Code 15-174001-0030-0005/The last SR noted was during PENRO monthly site visit.'),
(153, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 5.03, 5, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0033-0005', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.85, 'Parcel 4/5 of Site Code 15-174001-0030-0005/ The last SR noted was during PENRO monthly site visit.'),
(154, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 2.32, 2.4, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bacauan', 'Protection', '15-174001-0036-0002', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.85, 'Parcel 5/5 of Site Code 15-174001-0030-0005/ The last SR noted was during PENRO monthly site visit.'),
(155, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrjos', 'Malinao', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', '', 6.07, 6, 65000, 0, 65000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0041-0006', '', '', '', '', 'Regular Fund', 'Dec-17', 0.33, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 84.58, 'Parcel 1/4 of Site Code 15-174001-0041-0006/ The last SR noted was during PENRO monthly site visit.'),
(156, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', '', 2.08, 2, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0037-0002', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'December 16, 2018', 'Dec. 16, 2018', 0.92, 'Parcel 2/4 of Site Code 15-174001-0041-0006/ The last SR noted was during PENRO monthly site visit.'),
(157, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', '', 11.77, 12, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0038-0012', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'December 16, 2018', 'Dec. 16, 2018', 0.92, 'Parcel 3/4 of Site Code 15-174001-0041-0006/ The last SR noted was during PENRO monthly site visit.'),
(158, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', '', 6.17, 6, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0039-0006', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'December 16, 2018', 'Dec. 16, 2018', 0.92, 'Parcel 4/4 of Site Code 15-174001-0041-0006/ The last SR noted was during PENRO monthly site visit.'),
(159, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Alobo', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', '', 1.43, 1.5, 16250, 0, 16250, 71012.5, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0006-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.61, '', '', '', '', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.50, 'Parcel 1/3 of Site Code 15-174001-0006-0001/ The last SR noted was during the PENRO monthly site visit.'),
(160, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', '', 3.01, 3, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0008-0003', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/3 of Site Code 15-174001-0006-0001'),
(161, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituto P. Ricamata', 'PO', '', 2.23, 2, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0009-0002', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 3/3 of Site Code 15-174001-0006-0001'),
(162, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Angas', 'LGU Angas', 'Samuel Rondera', 'LGU', '', 20.17, 20, 50000, 50000, 50000, 218500, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0007-0020', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.21, '', '', '', '', '', '', '', '', 0.00, ''),
(163, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Balanacan', 'Bigkis Lakas ng Mangingisda ng Balanacan', 'Celso J. Quinto', 'PO', '', 4.69, 4.69, 20000, 20000, 20000, 111400, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0001-0005', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.28, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.76, 'Parcel 1/2 of Site Code 15-174001-0001-0005/ The last SR noted was during PENRO monthly site visit/'),
(164, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Balanacan', 'Bigkis Lakas ng Mangingisda ng Balanacan', 'Celso J. Quinto', 'PO', '', 3.58, 3.58, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0002-0004', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'May 28, 2019', 'May 28, 2019', 0.76, 'Parcel 2/2 of Site Code 15-174001-0001-0005/ The last SR noted was during PENRO monthly site visit.'),
(165, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Buyabod', 'LGU Buyabod', 'Avelino Garcia', 'LGU', '', 10.48, 10, 25000, 0, 25000, 120175, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0010-0010', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.54, '', '', '', '', '', '', 'February 20, 2019', 'Feb. 20, 2019', 0.00, 'Parcel 1/2 of Site Code 15-174001-0010-0010'),
(166, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Buyabod', 'LGU Buyabod', 'Avelino Garcia', 'LGU', '', 1.01, 1, 2500, 0, 2500, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0011-0001', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.54, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0010-0010'),
(167, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Masaguisi', 'LGU Masaguisi', 'Leonardo Pena', 'LGU', '', 4.22, 4, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0012-0004', '', '', '', '', 'Regular Fund', 'Dec-17', 0.77, '', '', '', '', '', '', 'January 28, 2020', 'Jan. 28, 2020', 0.75, 'The last SR noted was during the PENRO monthly site visit.'),
(168, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samahang Walang Katapusang Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino Reginio', 'PO', '', 7.50, 7, 0, 12500, 12500, 751950, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0013-0008', '', '', '', '', 'Regular Fund', 'Dec-17', 0.28, '', '', '', '', '', '', 'July 20, 2019', 'July 20, 2019', 0.85, 'Parcel 1/4 of Site Code 15-174001-0013-0008/ The last SR noted was during PENRO monthly site visit'),
(169, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samahang Walang Katapusang Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino Reginio', 'PO', '', 7.71, 7, 13500, 20000, 20000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0014-0008', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'July 20, 2019', 0.85, 'Parcel 2/4  of Site Code 15-174001-0014-0008'),
(170, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samahang Walang Katapusang Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino Reginio', 'PO', '', 15.20, 15, 0, 37500, 37500, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0015-0015', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'July 20, 2019', 0.85, 'Parcel 3/4 of Site Code 15-174001-0015-0015'),
(171, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samahang Walang Katapusang Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino Reginio', 'PO', '', 21.21, 21, 0, 52500, 52500, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0016-0021', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'July 20, 2019', 0.85, 'Parcel 4/4 of Site Code 15-174001-0016-0021'),
(172, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samahang Walang Katapusang Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino Reginio', 'PO', '', 3.91, 4, 0, 10000, 10000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0024-0004', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'July 20, 2019', 0.85, 'The last SR noted was during the PENRO monthly site visit.'),
(173, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Kalangkang', 'LGU Kalangkang', 'German Quindoza', 'LGU', '', 7.02, 7, 30000, 30000, 30000, 131100, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0017-0007', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.22, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 15-174001-0017-0007'),
(174, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Kalangkang', 'LGU Kalangkang', 'German Quindoza', 'LGU', '', 5.04, 5, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0018-0005', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0017-0007'),
(175, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Masaguisi', 'LGU Masaguisi', 'Leonardo Pena', 'LGU', '', 1.90, 2, 0, 5000, 5000, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0019-0002', '', '', '', '', 'Regular Fund', 'Dec-17', 0.77, '', '', '', '', '', '', 'January 28, 2020', 'Jan. 28, 2020', 0.75, 'The last SR noted was during the PENRO monthly site visit.'),
(176, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Suha', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', '', 9.74, 10, 70000, 0, 70000, 305900, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0034-0010', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.76, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 15-174001-0034-0010'),
(177, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Suha', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', '', 18.01, 18, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0035-0018', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0034-0010'),
(178, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Tagum', 'LGU Tagum', 'Leonardo P. Pena', 'LGU', '', 4.49, 4, 17500, 0, 17500, 76475, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0020-0004', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.46, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28,2019', 0.85, 'Parcel 1/2 of Site Code 15-174001-0020-0004'),
(179, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Tagum', 'LGU Tagum', 'Leonardo P. Pena', 'LGU', '', 3.34, 3, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0021-0003', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.86, 'Parcel 2/2 of Site Code 15-174001-0020-0004'),
(180, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Taytay', 'LGU Taytay', 'Diomedes Revilla', 'LGU', '', 20.92, 20, 62500, 65000, 62500, 273125, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0022-0021', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.20, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 15-174001-0022-0021'),
(181, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Taytay', 'LGU Taytay', 'Diomedes Revilla', 'LGU', '', 5.06, 5, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0023-0005', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0022-0021'),
(182, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Ino', 'Capayang Aqua-Silviculture Association', 'Ariel Ola', 'PO', '', 3.22, 3, 37500, 37500, 37500, 163875, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0003-0003', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.32, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/3 of Site Code 15-174001-0003-0003'),
(183, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Ino', 'Capayang Aqua-Silviculture Association', 'Ariel Ola', 'PO', '', 4.38, 4, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0004-0004', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/3 of Site Code 15-174001-0003-0003'),
(184, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Ino', 'Capayang Aqua-Silviculture Association', 'Ariel Ola', 'PO', '', 8.18, 8, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0005-0008', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 3/3 of Site Code 15-174001-0003-0003'),
(185, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Kasily', 'LGU Kasily', 'Jaime Ribleza', 'LGU', '', 40.02, 40, 100000, 100000, 100000, 557000, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0025-0040', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.31, '', '', '', '', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.60, 'The last SR noted was during the PENRO monthly site visit.'),
(186, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Alobo', 'Samahan ng mga Mangingisda ng Barangay Biga', 'Restituo Ricamata', 'PO', '', 6.00, 5, 15000, 15000, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0026-0006', '', '', '', '', 'Regular Fund', 'Dec-17', 0.61, '', '', '', '', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.50, 'The last SR noted was during the PENRO monthly site visit.'),
(187, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Hupi', 'LGU Hupi', 'Apolonio Regalia', 'LGU', '', 15.16, 15, 37500, 0, 37500, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0027-0015', '', '', '', '', 'Regular Fund', 'Dec-17', 0.20, '', '', '', '', '', '', '', '', 0.00, ''),
(188, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Balogo', 'LGU Balogo', 'Rizal Redugerio', 'LGU', '', 2.45, 2.5, 31250, 0, 31250, 136562.5, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0028-0002', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.20, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 15-174001-0028-0002'),
(189, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta. Cruz', 'Balogo', 'LGU Balogo', 'Rizal Redugerio', 'LGU', '', 9.75, 10, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0029-0010', '', '', '', 'Regular Target', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0028-0002'),
(190, 2015, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Mabuhay', 'LGU Mabuhay', 'Zacarias L. Palmero', 'LGU', '', 5.88, 7, 17500, 0, 17500, 76475, 'Reforestation', 'Mangrove', 'Bakauan', 'Protection', '15-174001-0040-0006', '', '', '', 'Regular Target', 'Regular Fund', 'Dec-17', 0.33, '', '', '', '', '', '', 'March 28, 2019', 'Mar. 28, 2019', 0.75, 'The last SR noted was during PENRO monthly site visit.'),
(191, 2017, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Duyay', 'LGU Duyay', 'Allan Hizole', 'LGU', 'ISF', 25.35, 25, 47030, 56436, 47030, 1235883.7, 'Agroforest and Reforestation', 'Timber,  High Value, Crops, Fruit Trees', 'Narra, Cacao, Coffee, ,Guyabano and kakawate', 'Production', '17-174001-0001-0025', '', '', '', 'Regular Target', 'Regular Fund', 'Nov-20', 0.30, '', '', '', '', '', '', '', 'Nov-20', 0.30, 'Parcel 1/2 of Site Code 17-174001-0001-0025'),
(192, 2017, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Duyay', 'LGU Duyay', 'Allan Hizole', 'LGU', 'ISF', 16.17, 16, 0, 0, 0, 0, 'Agroforest and Reforestation', 'Timber,  High Value, Crops, Fruit Trees', 'Narra, Cacao, Coffee, ,Guyabano and kakawate', 'Production', '17-174001-0002-0016', '', '', '', 'Regular Target', 'Regular Fund', '', 0.30, '', '', '', '', '', '', '', '', 0.30, 'Parcel 2/2 of Site Code 17-174001-0001-0025'),
(193, 2017, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Bagtingon', 'Bagtingon Butterfly Breeders Association(B3A), Inc.', 'Mario C. Francisco II', 'PO', 'Protected Area', 49.48, 49, 56250, 67500, 56250, 1467116.3, 'Agroforest and Reforestation', 'Timber,Fruit Trees and High Value Crops', 'Narra, Cacao, Coffee, ,Guyabano and kakawate', 'Production', '17-174001-0003-0049', '', '', '', 'Regular Target', 'Regular Fund', 'Nov-20', 0.31, '', '', '', '', '', '', '', 'Nov-20', 0.31, ''),
(194, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Bantay', 'Administration', 'Evangeline M. Ogayre', 'DENR-PENRO', 'Untenured', 6.00, 120, 1224, 0, 1224, 2100000, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0001-0006', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Dec-20', 0.13, 'Parcel 1/37 of Site Code 18-174000-0001-0006'),
(195, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bayakbakin', 'Administration', 'Michael C. Colopano', 'DENR-PENRO', 'Untenured', 0.50, 0, 102, 0, 102, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0014-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.24, 'Parcel 2/37 of Site Code 18-174000-0001-0006'),
(196, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bolo', 'Administration', 'Recto V. Rioveros', 'DENR-PENRO', 'Untenured', 0.28, 0, 118, 0, 118, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0015-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.26, 'Parcel 3/37 of Site Code 18-174000-0001-0006'),
(197, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bolo', 'Administration', 'Recto V. Rioveros', 'DENR-PENRO', 'Untenured', 0.30, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0016-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.26, 'Parcel 4/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0015-0000.'),
(198, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Buangan', 'Administration', 'Tomas C. Palma', 'DENR-PENRO', 'Untenured', 0.79, 0, 356, 0, 356, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0018-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.10, 'Parcel 5/37 of Site Code 18-174000-0001-0006'),
(199, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Buangan', 'Administration', 'Tomas C. Palma', 'DENR-PENRO', 'Untenured', 0.96, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0019-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.10, 'Parcel 6/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0018-0001'),
(200, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Cabuyo', 'Administration', 'Andres R. Villalva', 'DENR-PENRO', 'Untenured', 4.20, 0, 1834, 0, 1834, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0020-0004', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.13, 'Parcel 7/37 of Site Code 18-174000-0001-0006'),
(201, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Cabuyo', 'Administration', 'Andres R. Villalva', 'DENR-PENRO', 'Untenured', 4.81, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0021-0005', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.13, 'Parcel 8/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0020-0004'),
(202, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Capayang', 'Administration', 'Rommel N. Moreno', 'DENR-PENRO', 'Untenured', 5.05, 0, 1020, 0, 1020, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0010-0005', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'June 28, 2019', 'Dec-20', 0.46, 'Parcel 9/37 of Site Code 18-174000-0001-0006'),
(203, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Dampulan', 'Administration', 'Eleuterio P. Apostol', 'DENR-PENRO', 'Untenured', 28.06, 0, 7140, 0, 7140, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0022-0028', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'January 25, 2019', 'Dec-20', 0.29, 'Parcel 10/37 of Site Code 18-174000-0001-0006'),
(204, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Dampulan', 'Administration', 'Eleuterio P. Apostol', 'DENR-PENRO', 'Untenured', 7.06, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0023-0007', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.29, 'Parcel 11/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0022-0028'),
(205, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Maranlig', 'Administration', 'Vivencio F. Pedrialva', 'DENR-PENRO', 'Untenured', 0.21, 0, 92, 0, 92, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0030-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.35, 'Parcel 12/37 of Site Code 18-174000-0001-0006'),
(206, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Maranlig', 'Administration', 'Vivencio F. Pedrialva', 'DENR-PENRO', 'Untenured', 0.24, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0031-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.35, 'Parcel 13/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0031-0000'),
(207, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Marlangga', 'Administration', 'Alex R. Quitoriano', 'DENR-PENRO', 'Untenured', 1.49, 0, 302, 0, 302, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0032-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.17, 'Parcel 14/37 of Site Code 18-174000-0001-0006'),
(208, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Matuyatuya', 'Administration', 'Leandro M. Montevirgen', 'DENR-PENRO', 'Untenured', 0.10, 0, 20, 0, 20, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0033-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.30, 'Parcel 15/37 of Site Code 18-174000-0001-0006'),
(209, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Nangka', 'Administration', 'Jessie R. Peralta', 'DENR-PENRO', 'Untenured', 2.69, 0, 547, 0, 547, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0034-0003', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.27, 'Parcel 16/37 of Site Code 18-174000-0001-0006'),
(210, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Payanas', 'Administration', 'Ricardo R. Fernandez', 'DENR-PENRO', 'Untenured', 0.59, 0, 118, 0, 118, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0035-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.34, 'Parcel 17/37 of Site Code 18-174000-0001-0006'),
(211, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Poblacion', 'Administration', 'Ronulfo R. Del Mundo', 'DENR-PENRO', 'Untenured', 0.08, 0, 16, 0, 16, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0036-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.19, 'Parcel 18/37 of Site Code 18-174000-0001-0006'),
(212, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Poctoy', 'Administration', 'Rosita R. Roldan', 'DENR-PENRO', 'Untenured', 1.89, 0, 386, 0, 386, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0037-0002', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.15, 'Parcel 19/37 of Site Code 18-174000-0001-0006'),
(213, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Puyog', 'Administration', 'Evangeline M. Ogayre', 'DENR-PENRO', 'Untenured', 4.09, 0, 816, 0, 816, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0002-0004', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', 'Dec-20', 0.12, 'Parcel 20/37 of Site Code 18-174000-0001-0006'),
(214, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Sibuyao', 'Administration', 'Reden G. Fidelino', 'DENR-PENRO', 'Untenured', 1.28, 0, 261, 0, 261, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0038-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.59, 'Parcel 21/37 of Site Code 18-174000-0001-0006'),
(216, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'Administration', 'Lorna Jimena', 'DENR-PENRO', 'Untenured', 10.08, 0, 2040, 0, 2040, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0004-0010', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'April 16, 2019', 'Dec-20', 0.46, 'Parcel 23/37 of Site Code 18-174000-0001-0006'),
(217, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Bonliw', 'Administration', 'Joel P. Rey', 'DENR-PENRO', 'Untenured', 1.15, 0, 204, 0, 204, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0017-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.34, 'Parcel 24/37 of Site Code 18-174000-0001-0006'),
(218, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Mabuhay', 'Administration', 'Zacarias L. Palmero', 'DENR-PENRO', 'Untenured', 0.48, 0, 302, 0, 302, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0024-0000', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'Dec-20', 0.17, 'Parcel 25/37 of Site Code 18-174000-0001-0006'),
(219, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Mabuhay', 'Administration', 'Zacarias L. Palmero', 'DENR-PENRO', 'Untenured', 1.02, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0025-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'Dec-20', 0.17, 'Parcel 26/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0024-0000'),
(220, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Malinao', 'Administration', 'Romeo Q. Ricafranca', 'DENR-PENRO', 'Untenured', 1.18, 0, 204, 0, 204, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0029-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'September 28, 2019', 'Dec-20', 0.11, 'Parcel 27/37 of Site Code 18-174000-0001-0006'),
(221, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Tigwi', 'Administration', 'Gregorio P. Palatino', 'DENR-PENRO', 'Untenured', 7.87, 0, 1428, 0, 1428, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0039-0008', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.14, 'Parcel 28/37 of Site Code 18-174000-0001-0006'),
(222, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Administration', 'Restituto L. Pabalat', 'DENR-PENRO', 'Untenured', 2.01, 0, 3060, 0, 3060, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0005-0002', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.24, 'Parcel 29/37 of Site Code 18-174000-0001-0006'),
(223, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Administration', 'Restituto L. Pabalat', 'DENR-PENRO', 'Untenured', 2.04, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0006-0002', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.24, 'Parcel 30/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0005-0002'),
(224, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Administration', 'Restituto L. Pabalat', 'DENR-PENRO', 'Untenured', 5.01, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0007-0005', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.24, 'Parcel 31/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0005-0002'),
(225, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Malbog', 'Administration', 'Restituto L. Pabalat', 'DENR-PENRO', 'Untenured', 6.00, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0008-0006', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.24, 'Parcel 32/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0005-0002'),
(226, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Malibago', 'Administration', 'Sabino Rojo', 'DENR-PENRO', 'Untenured', 1.27, 0, 245, 0, 245, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0028-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.11, 'Parcel 33/37 of Site Code 18-174000-0001-0006'),
(227, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Makawayan', 'Administration', 'Glenn F. Del Mundo', 'DENR-PENRO', 'Untenured', 1.27, 0, 245, 0, 245, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0026-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', 'August 21, 2019', 'Dec-20', 0.16, 'Parcel 34/37 of Site Code 18-174000-0001-0006'),
(228, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Tawiran', 'Administration', 'Bienvenido P. Palma', 'DENR-PENRO', 'Untenured', 6.63, 0, 2488, 0, 2488, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0011-0007', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.16, 'Parcel 35/37 of Site Code 18-174000-0001-0006'),
(229, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Tawiran', 'Administration', 'Bienvenido P. Palma', 'DENR-PENRO', 'Untenured', 1.39, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0012-0001', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.16, 'Parcel 36/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0011-0007'),
(230, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Tawiran', 'Administration', 'Bienvenido P. Palma', 'DENR-PENRO', 'Untenured', 4.02, 0, 0, 0, 0, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0013-0004', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec-20', 0.16, 'Parcel 37/37 of Site Code 18-174000-0001-0006; Same no. of seedlings planted to Site Code 18-174000-0011-0007'),
(231, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Tumagabok', 'Administration', 'Lorna Jimena', 'DENR-PENRO', 'Untenured', 10.07, 10, 2040, 0, 2040, 0, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '18-174000-0003-0010', '', '', '', 'CO Based', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'April 16, 2019', 'Dec-20', 0.70, ''),
(232, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Buenavista', 'Sihi', 'LGU of Brgy. Sihi', 'Dante Marinduque', 'LGU', 'Protected Area', 30.13, 30, 37206, 0, 37206, 630550, 'Agroforestry', 'Timber, Fruit Trees, High Value Crops, Hedgerows', 'Narra, Guyabano, Cacao, Coffee Robusta, Madre de Cacao', 'Protection and Production forest', '18-174000-0009-0030', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Nov. 27, 2020', 0.87, '');
INSERT INTO `ngpalldate` (`No`, `Year`, `Region`, `District`, `CENRO`, `PENRO`, `Municipality`, `Barangay`, `Name_of_Org`, `Contact_Person`, `Type_org`, `Tenure`, `Target_area`, `Area_planted`, `Seedling_req`, `Seedling_pro`, `Seedling_plant`, `Contract_c`, `Component`, `Commodity`, `Narra`, `Zone`, `Unique_code`, `Dis_date`, `Dis_area_dam`, `Dis_type_dam`, `Activities_conducted`, `Funding_source`, `Final_date`, `Survival_rate11_20`, `Classification`, `After_date`, `After_area_dam`, `After_type_dam`, `third_date`, `third_survival`, `Date_visit`, `Final_inspect_date`, `Survival_rate(11-20)`, `Remarks`) VALUES
(233, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Malibago', 'LGU of Brgy.Malibago', 'Sabino Rojo', 'LGU', 'Protected Area', 40.42, 40, 47474, 0, 47474, 836450, 'Agroforestry', 'Timber, Fruit Trees, High Value Crops, Hedgerows', 'Narra, Guyabano, Cacao, Coffee Robusta, Madre de Cacao', 'Protection and Production forest', '18-174000-0027-0040', '', '', '', 'Regular Target', 'Continuing Fund', '', 0.00, '', '', '', '', '', '', '', 'Nov. 27, 2020', 0.87, ''),
(234, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Morales', 'LGU Morales', 'Ruben Ricafrente', 'LGU', 'Untenured', 13.16, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik', 'Protection', '18-174000-0309-0013', '', '', '', 'CMEMP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', '', 'Nov. 17, 2020', 0.90, ''),
(235, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Ipil', 'LGU Ipil', 'Joel P. Quizana', 'LGU', 'Untenured', 13.79, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik', 'Protection', '18-174000-0307-0013', '', '', '', 'CMEMP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'Nov. 17, 2020', 0.89, ''),
(236, 2018, 'MIMAROPA', 'Lone Distric', '', 'Marinduque', 'Sta.Cruz', 'Ipil', 'LGU Ipil', 'Joel P. Quizana', 'LGU', 'Untenured', 1.66, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik', 'Protection', '18-174000-0308-0002', '', '', '', 'CMEMP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', '', 0.89, ''),
(237, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon Rioveros', 'LGU', 'Untenured', 3.54, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik, Tangal', 'Protection', '18-174000-0310-0004', '', '', '', 'CMEMP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', '', 'Nov. 18, 2020', 0.90, ''),
(238, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon P. Rioveros/Myrna R. Grimaldo', 'LGU', 'Untenured', 7.86, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik, Tangal', 'Protection', '18-174000-0311-0008', '', '', '', 'CMEMP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'March 28, 2019', '', 0.90, ''),
(239, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Ipil', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', 'Untenured', 1.32, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '18-174000-0266-0001', '', '', '', 'YRRP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', 'Nov. 18, 2020', 0.89, ''),
(240, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Maligaya', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', 'Untenured', 1.35, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '18-174000-0267-0001', '', '', '', 'YRRP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', '', 0.89, ''),
(241, 2018, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU Kay Duke', 'Simon P. Rioveros', 'LGU', 'Untenured', 1.82, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Pipisik, Tangal', 'Protection', '18-174000-0268-0002', '', '', '', 'YRRP', 'CO Based (ERDB)', '', 0.00, '', '', '', '', '', '', 'July 20, 2019', '', 0.89, ''),
(242, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Mogpog', 'Balanacan', 'Bigkis Lakas ng Maliliit Na Mangisngisda  ng Balanacan', 'Celso J. Quinto', 'PO', 'Untenured', 1.05, 1, 2500, 0, 2500, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0033-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.27, '', '', '', '', '', '', 'May 28, 2019', 'Mar. 28, 2019', 0.35, 'Last SR noted was during the PENRO monthly site visit.'),
(243, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Balogo', 'LGU of Balogo', 'Rizal F. Redugerio', 'LGU', 'Untenured', 3.21, 4, 2500, 0, 2500, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae', 'Protection', '15-174001-0036-0003', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.35, 'Last SR noted was during the PENRO monthly site visit.'),
(244, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Balogo', 'LGU of Balogo', 'Rizal F. Redugerio', 'LGU', 'Untenured', 8.50, 8.5, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae', 'Protection', '15-174001-0037-0009', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'November 28, 2019', 'Nov. 28, 2019', 0.35, 'Last SR noted was during the PENRO monthly site visit.'),
(245, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Biga', 'Samahang Mangigisda ng Brgy. Biga', 'Restituto Recama', 'PO', 'Untenured', 2.30, 2, 5000, 0, 5000, 0, 'Reforestation', 'Mangrove', 'Bakauan Babae,Bakauan Lalaki', 'Protection', '15-174001-0034-0002', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.12, '', '', '', '', '', '', '', '', 0.00, ''),
(246, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Botilao', 'LGU of Botilao, Sta. Cruz', 'Enrique Rejano', 'LGU', 'Untenured', 2.21, 2, 5000, 0, 5000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae', 'Protection', '15-174001-0035-0002', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.21, '', '', '', '', '', '', '', '', 0.00, ''),
(247, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Hupi', 'LGU of Hupi', 'Apolonio Regalia', 'LGU', 'Untenured', 17.37, 17, 42500, 0, 42500, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae', 'Protection', '15-174001-0038-0017', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(248, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samhang Walang Katapusan Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino R. Regino', 'PO', 'Untenured', 10.19, 10, 25000, 0, 25000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0039-0010', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.01, '', '', '', '', '', '', '', '', 0.00, ''),
(249, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samhang Walang Katapusan Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino R. Regino', 'PO', 'Untenured', 10.24, 10, 25000, 0, 25000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0040-0010', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', '', '', 0.00, ''),
(250, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Ipil', 'Samhang Walang Katapusan Nagtataguyod sa mga Mangingisda ng Ipil', 'Sabino R. Regino', 'PO', 'Untenured', 10.49, 10, 25000, 0, 25000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0041-0010', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.20, '', '', '', '', '', '', '', '', 0.00, ''),
(251, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Kasily', 'LGU of Kasily', 'Jaime Rebliza', 'LGU', 'Untenured', 6.04, 6, 15000, 0, 15000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae', 'Protection', '15-174001-0042-0006', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(252, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Matalaba', 'LGU of Matalaba', 'Nelson R. Gonzales', 'LGU', 'Untenured', 52.55, 52, 130000, 0, 130000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0043-0053', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', 'July 20, 2019', '', 0.00, ''),
(253, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Torrijos', 'Suha', 'LGU of Kay Duke', 'Simon Rioveros', 'LGU', 'Untenured', 2.40, 2, 5000, 0, 5000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0054-0002', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.36, '', '', '', '', '', '', '', '', 0.00, ''),
(254, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Morales', 'LGU of Morales', 'Ruben Ricafrente', 'LGU', 'Untenured', 6.20, 6, 15000, 0, 15000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0044-0006', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.15, '', '', '', '', '', '', '', '', 0.00, ''),
(255, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Polo', 'LGU of Polo', 'Juanito Recafrac', 'LGU', 'Untenured', 4.68, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0047-0005', '', '', '', 'MBFDP', 'ERDB', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(256, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Polo', 'LGU of Polo', 'Juanito Recafrac', 'LGU', 'Untenured', 6.48, 26, 65000, 0, 65000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0048-0006', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/2 of Site Code 15-174001-0048-0006'),
(257, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Polo', 'LGU of Polo', 'Juanito Recafrac', 'LGU', 'Untenured', 6.70, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0049-0007', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/2 of Site Code 15-174001-0048-0006'),
(258, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Tamayo', 'Samahang Mangigisda ng Brgy. Biga', 'Restituto Recama', 'PO', 'Untenured', 21.26, 21, 52500, 0, 52500, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0045-0021', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.42, '', '', '', '', '', '', '', '', 0.00, ''),
(259, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Sta. Cruz', 'Tamayo', 'Samahang Mangigisda ng Brgy. Biga', 'Restituto Recama', 'PO', 'Untenured', 24.08, 24, 60000, 0, 60000, 0, 'Reforestation', 'Mangrove', 'Bakawan Babae and Lalake', 'Protection', '15-174001-0046-0024', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.03, '', '', '', '', '', '', '', '', 0.00, ''),
(260, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisigng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.24, 25, 62500, 0, 62500, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0012-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.01, '', '', '', '', '', '', '', '', 0.00, 'Parcel 1/27 of Site Code 15-174001-0012-0000'),
(261, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Bahi', 'Samahan Kapit Bisigng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.25, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0020-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', '', '', 0.00, 'Parcel 2/27 of Site Code 15-174001-0012-0000'),
(262, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Bahi', 'Samahan Kapit BiSamahan Kapit Bisigng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.02, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0021-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 3/27 of Site Code 15-174001-0012-0000'),
(263, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisigng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.14, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0026-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 4/27 of Site Code 15-174001-0012-0000'),
(264, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Samahan Kapit Bisig  ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.23, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0013-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.03, '', '', '', '', '', '', '', '', 0.00, 'Parcel 5/27 of Site Code 15-174001-0012-0000'),
(265, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.46, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0014-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 6/27 of Site Code 15-174001-0012-0000'),
(266, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.48, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0015-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 7/27 of Site Code 15-174001-0012-0000'),
(267, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.88, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0016-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 8/27 of Site Code 15-174001-0012-0000'),
(268, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Boac', 'Cawit', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.13, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0001-0000', '', '', '', 'MBFDP', 'ERDB', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 9/27 of Site Code 15-174001-0012-0000'),
(269, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Boac', 'Cawit', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.54, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0002-0002', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.06, '', '', '', '', '', '', '', '', 0.00, 'Parcel 10/27 of Site Code 15-174001-0012-0000'),
(270, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Daykitin', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.95, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0007-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 11/27 of Site Code 15-174001-0012-0000'),
(271, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Daykitin', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.14, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0008-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.09, '', '', '', '', '', '', '', '', 0.00, 'Parcel 12/27 of Site Code 15-174001-0012-0000'),
(272, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Daykitin', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.18, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0009-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.12, '', '', '', '', '', '', '', '', 0.00, 'Parcel 13/27 of Site Code 15-174001-0012-0000'),
(273, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Daykitin', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.85, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0010-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', '', '', 0.00, 'Parcel 14/27 of Site Code 15-174001-0012-0000'),
(274, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.10, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0027-0000', '', '', '', 'MBFDP', 'ERDB', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 15/27 of Site Code 15-174001-0012-0000'),
(275, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.05, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0028-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 16/27 of Site Code 15-174001-0012-0000'),
(276, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.19, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0029-0000', '', '', '', 'MBFDP', 'ERDB', '', 0.00, '', '', '', '', '', '', '', '', 0.00, 'Parcel 17/27 of Site Code 15-174001-0012-0000'),
(277, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Masiga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 7.08, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0023-0007', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 18/27 of Site Code 15-174001-0012-0000'),
(278, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Masiga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.76, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0024-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 19/27 of Site Code 15-174001-0012-0000'),
(279, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Caigangan', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.91, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0003-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.04, '', '', '', '', '', '', '', '', 0.00, 'Parcel 20/27 of Site Code 15-174001-0012-0000'),
(280, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Caigangan', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.49, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0004-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.01, '', '', '', '', '', '', '', '', 0.00, 'Parcel 21/27 of Site Code 15-174001-0012-0000'),
(281, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Caigangan', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.95, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0005-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.02, '', '', '', '', '', '', '', '', 0.00, 'Parcel 22/27 of Site Code 15-174001-0012-0000'),
(282, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Bahi', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 1.49, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0022-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.01, '', '', '', '', '', '', '', '', 0.00, 'Parcel 23/27 of Site Code 15-174001-0012-0000'),
(283, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.25, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0018-0000', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.06, '', '', '', '', '', '', '', '', 0.00, 'Parcel 24/27 of Site Code 15-174001-0012-0000'),
(284, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.93, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0019-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.50, '', '', '', '', '', '', '', '', 0.00, 'Parcel 25/27 of Site Code 15-174001-0012-0000'),
(285, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.12, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0031-0000', '', '', '', 'MBFDP; Merge with Site_ID 0032', 'ERDB', 'May 15 to 23, 2018', 0.09, '', '', '', '', '', '', '', '', 0.00, 'Parcel 26/27 of Site Code 15-174001-0012-0000'),
(286, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Poblacion', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.65, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0011-0001', '', '', '', 'MBFDP', 'ERDB', 'May 15 to 23, 2018', 0.01, '', '', '', '', '', '', '', '', 0.00, 'Parcel 27/27 of Site Code 15-174001-0012-0000'),
(287, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Antipolo', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.26, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0017-0000', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(288, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Masiga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.14, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0025-0000', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(289, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Gasan', 'Pinga', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.05, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0030-0000', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(290, 2015, 'MIMAROPA', 'Lone District', 'Boac', 'Marinduque', 'Buenavista', 'Caigangan', 'Samahan Kapit Bisig ng Magsasaka sa Tungib', 'Rodelio E. Sotto', 'PO', 'Untenured', 0.00, 0, 0, 0, 0, 0, 'Reforestation', 'Beach', 'Talisay', 'Protection', '15-174001-0006-0000', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(291, 2015, 'MIMAROPA', 'Lone', 'Boac', 'Marinduque', 'Boac', 'Polo', 'LGU of Polo', 'Juanito Recafrac', 'LGU', 'Untenured', 5.90, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan', 'Protection', '15-174001-0050-0006', '', '', '', '', '', '', 0.00, '', '', '', '', '', '', 'November 28, 2019', '', 0.00, ''),
(292, 2015, 'MIMAROPA', 'Lone', 'Boac', 'Marinduque', 'Torrijos', 'Suha', 'LGU of Kay Duke', 'Simon Rioveros', 'LGU', 'Untenured', 7.37, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan', 'Protection', '15-174001-0056-0007', '', '', '', 'Merged with Site_ID 0055', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(293, 2015, 'MIMAROPA', 'Lone', 'Boac', 'Marinduque', 'Torrijos', 'Kay Duke', 'LGU of Kay Duke', 'Simon Rioveros', 'LGU', 'Untenured', 12.37, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan', 'Protection', '15-174001-0051-0012', '', '', '', 'Merged with Site_ID 0052 and 0053', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(294, 2015, 'MIMAROPA', 'Lone', 'Boac', 'Marinduque', 'Boac', 'Polo', 'LGU of Polo', 'Juanito Recafrac', 'LGU', 'Untenured', 3.44, 0, 0, 0, 0, 0, 'Reforestation', 'Mangrove', 'Bakawan', 'Protection', '15-174001-0671-0003', '', '', '', 'Parcel 2 of Site_ID 0050', '', '', 0.00, '', '', '', '', '', '', '', '', 0.00, ''),
(295, 2016, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Binunga', 'Canat Upland Farmers Association', 'Reynante Mayorga', 'PO', '', 27.04, 27, 44982, 0, 44982, 0, 'Reforestation', 'Timber', 'Narra,Molave', 'Protection', '16-174001-0001-0027', '', '', '', 'Regular Target', 'Regular Fund', 'Sept to Oct, 2018', 0.07, '', '', '', '', '', '', '', '', 0.00, ''),
(296, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Buliasnin', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 7.26, 7, 8750, 8750, 8750, 166250, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0002-0007', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.88, 'Parcel 1/3 of Site Code 20-174000-0002-0007'),
(297, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Maligaya', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 7.23, 7, 8750, 8750, 8750, 166250, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0003-0007', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.88, 'Parcel 2/3 of Site Code 20-174000-0002-0007'),
(298, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Janagdong', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 6.01, 6, 7500, 7500, 7500, 142500, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0004-0006', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.85, 'Parcel 3/3 of Site Code 20-174000-0002-0007'),
(299, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Torrijos and Boac', 'Sibuyao and Tumagabok', 'LGU Sibuyao', 'Reden  G. Fidelino', 'LGU', 'Untenured', 12.02, 12, 2800, 2800, 2800, 200000, 'Reforestation', 'Bamboo', 'Kawayan Tinik', 'Protection and Production forest', '20-174000-0001-0012', '', '', '', 'Bamboo Plantation', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', '', 0.86, ''),
(300, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Buliasnin', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 1.30, 1, 1250, 1250, 1250, 23750, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0008-0001', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.87, 'Parcel 1/9 of Site Code 20-174000-0008-0001'),
(301, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Pili', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 6.05, 6, 7500, 7500, 7500, 142500, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0009-0006', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.80, 'Parcel 2/9 of Site Code 20-174000-0008-0002'),
(302, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Lupac 1', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 7.00, 7, 8750, 8750, 8750, 166250, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0010-0007', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.87, 'Parcel 3/9 of Site Code 20-174000-0008-0003'),
(303, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Lupac 2', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 7.02, 7, 8750, 8750, 8750, 166250, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0011-0007', '', '', '', 'Nipa Plantation Establishment; Parcel 2 of Site_ID 0010', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.85, 'Parcel 4/9 of Site Code 20-174000-0008-0004'),
(304, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Boac', 'Laylay', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 2.03, 2, 2500, 2500, 2500, 47500, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0012-0002', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.81, 'Parcel 5/9 of Site Code 20-174000-0008-0005'),
(305, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Mogpog', 'Laon', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 4.30, 4, 5000, 5000, 5000, 95000, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0013-0004', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.84, 'Parcel 6/9 of Site Code 20-174000-0008-0006'),
(306, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Ipil', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 8.03, 8, 10000, 10000, 10000, 190000, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0014-0008', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.90, 'Parcel 7/9 of Site Code 20-174000-0008-0007'),
(307, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Morales', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 3.01, 3, 3750, 3750, 3750, 71250, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0015-0003', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.89, 'Parcel 8/9 of Site Code 20-174000-0008-0008'),
(308, 2020, 'MIMAROPA', 'Lone District', '', 'Marinduque', 'Sta.Cruz', 'Tawiran', 'MSC', 'Merian P. Catajay-Mani,Ed.D', 'Government', 'Untenured', 2.02, 2, 2500, 2500, 2500, 47500, 'Reforestation', 'Mangrove', 'Nipa', 'Protection and Production forest', '20-174000-0016-0002', '', '', '', 'Nipa Plantation Establishment', 'Regular Fund', '', 0.00, '', '', '', '', '', '', '', 'Dec. 2020', 0.92, 'Parcel 9/9 of Site Code 20-174000-0008-0009');

-- --------------------------------------------------------

--
-- Table structure for table `organizational_tbl`
--

CREATE TABLE `organizational_tbl` (
  `Org_ID` int(11) NOT NULL,
  `Org_name` varchar(100) NOT NULL,
  `Org_type` varchar(50) NOT NULL,
  `Org_tenure` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `organizational_tbl`
--

INSERT INTO `organizational_tbl` (`Org_ID`, `Org_name`, `Org_type`, `Org_tenure`) VALUES
(15, 'LGU - Sihi', 'LGU', 'PA'),
(16, 'LGU - Makulapnit', 'LGU', 'Within/conciding PA'),
(17, 'LGU - Bayakbakin', 'LGU', 'CBFMA'),
(18, 'LGU - Devilla', 'LGU', 'PA'),
(19, 'LGU - Malibago', 'LGU', 'Within/conciding PA'),
(20, 'LGU - Talawan', 'LGU', 'Within/conciding PA'),
(21, 'LGU - Sibuyao', 'LGU', 'CBFM'),
(22, 'LGU - Masalukot', 'LGU', 'PA'),
(23, 'Tumagabok Small Farmers Association', 'PO', 'PA'),
(24, 'LGU - Tumagabok', 'LGU', 'Within/conciding PA'),
(25, 'LGU - Sibuyao (2011)', 'LGU', 'Other Area'),
(26, 'LGU - Yook', 'LGU', 'Other Area'),
(27, 'LGU - Hinanggayon', 'LGU', 'Other Area'),
(28, 'LGU - Binunga', 'LGU', 'PA'),
(29, 'LGU - Canat', 'LGU', 'PA'),
(30, 'LGU - Malbog', 'LGU', 'PA'),
(31, 'LGU - Bagtingon', 'LGU', 'CBFM'),
(32, 'LGU - San Isidro', 'LGU', 'CBFM'),
(33, 'LGU - Sabong', 'LGU', 'PA'),
(34, 'LGU - Malabon', 'LGU', 'Other Area'),
(35, 'LGU - Kilo Kilo', 'LGU', 'Other Area'),
(36, 'LGU - Bonliw', 'LGU', 'Other Area'),
(37, 'LGU - Balagasan', 'LGU', 'Within/conciding PA'),
(38, 'LGU - Hinapulan', 'LGU', 'Within/conciding PA'),
(39, 'LGU - Duyay', 'LGU', 'Within/conciding PA'),
(40, 'LGU - Tiguion', 'LGU', 'PA'),
(41, 'LGU - Antipolo', 'LGU', 'Within/conciding PA'),
(42, 'LGU - BOI', 'LGU', 'Within/conciding PA'),
(43, 'LGU - Libjo', 'LGU', 'Other Area'),
(44, 'LGU - Tambunan', 'LGU', 'Within/conciding PA'),
(45, 'LGU - Tugos', 'LGU', 'Within/conciding PA'),
(46, 'LGU - Makulapnit (2011)', 'LGU', 'Within/conciding PA'),
(47, 'LGU - Masalukot (2011)', 'LGU', 'PA'),
(48, 'LGU - Malibago (2011)', 'LGU', 'Within/conciding PA'),
(49, 'LGU - Bayuti', 'LGU', 'Within/conciding PA'),
(50, 'LGU - Tambangan', 'LGU', 'Within/conciding PA'),
(51, 'LGU - Nangka', 'LGU', 'PA'),
(52, 'LGU - Tabi', 'LGU', 'Other Area'),
(53, 'LGU - Bagacay', 'LGU', 'Other Area'),
(54, 'Malbog Upland Farmers Association (MUFA)', 'PO', 'Other Area'),
(55, 'Naampias Watershed Association Inc. (NWAI)', 'PO', 'CBFM'),
(56, 'LGU - Tabionan', 'LGU', 'Other Area'),
(57, 'LGU - Tawiran', 'LGU', 'Other Area'),
(58, 'LGU - Maranlig', 'LGU', 'Other Area'),
(59, 'LGU - Bamban', 'LGU', 'N/A'),
(60, 'LGU - Mainit', 'LGU', 'N/A'),
(61, 'LGU - Bantay', 'LGU', 'N/A'),
(62, 'LGU - Ogbac', 'LGU', 'N/A'),
(63, 'LGU - Balimbing', 'LGU', 'N/A'),
(64, 'LGU - Boton', 'LGU', 'N/A'),
(65, 'LGU - Tumapon', 'LGU', 'N/A'),
(66, 'LGU - Tampus', 'LGU', 'N/A'),
(67, 'LGU - Daypay', 'LGU', 'Untenured'),
(68, 'LGU - Sawi', 'LGU', 'N/A'),
(69, 'LGU - Catubugan', 'LGU', 'N/A'),
(70, 'LGU - Dawis', 'LGU', 'Other Area'),
(71, 'Samahan ng Nagkakaisang Magsasaka ng Brgy. Duyay', 'PO', 'Untenured'),
(72, 'LGU - Tawiran (2013)', 'LGU', 'N/A'),
(73, 'Samahan ng mga Mangingisda ng Barangay Biga', 'PO', 'N/A'),
(74, 'Bagtingon Butterfly Breeders Association (B3A), Inc.', 'PO', 'Other Area'),
(75, 'Tanikala ng Pagkakaisa Multi-Purpose Cooperative', 'PO', 'Other Area'),
(76, 'Sibuyao Vegetable Growers Association', 'PO', 'Within/coinciding PA'),
(77, 'LGU - Bicas bicas', 'PO', 'Untenured'),
(79, 'LGU - Buenavista', 'LGU', 'Other Area'),
(80, 'LGU - Libas', 'LGU', 'Other Area'),
(81, 'Sariling Sikap Farmers Association', 'PO', 'Other Area'),
(82, 'Makawayan Upland Farmers Association', 'PO', 'CBFM'),
(83, 'Samahan ng Magsasaka sa Pinagbulugan (SMP)', 'PO', 'Other Area'),
(84, 'Samahang Kapit Bisig ng Magsasaka sa Tungib-Lipata', 'PO', 'Other Area'),
(85, 'Canat Upland Farmers Association', 'PO', 'ISF'),
(86, 'Tambunan Farmers Association (TFA)', 'PO', 'ISF'),
(87, 'Samahan ng Maliit na Mangingisda sa Dating Bayan at Punong', 'PO', 'ISF'),
(88, 'LGU - Bayakyakin', 'LGU', 'Other Area'),
(89, 'LGU - Balogo', 'LGU', 'Other Area'),
(90, 'Caigangan Credit Cooperative (CCC)', 'PO', 'Other Area'),
(91, 'Federation of Mogpog Farmers Association', 'PO', 'Other Area'),
(92, 'Bigkis Lakas ng Mangingisda ng Balanacan', 'PO', 'Other Area'),
(93, 'Capayang Aqua-Silviculture Association', 'PO', 'Other Area'),
(94, 'LGU - Angas', 'LGU', 'PA'),
(95, 'LGU - Buyabod', 'LGU', 'Other Area'),
(96, 'LGU - Masaguisi', 'LGU', 'Other Area'),
(97, 'Samahan ng Walang Katapusan Nagtataguyod sa mga Mangingisda ng Ipil', 'PO', 'Other Area'),
(98, 'LGU - Kalangkang', 'PO', 'Other Area'),
(99, 'LGU - Tagum', 'LGU', 'Other Area'),
(100, 'LGU - Taytay', 'LGU', 'Other Area'),
(101, 'LGU - Kasily', 'LGU', 'Other Area'),
(102, 'LGU - Hupi', 'LGU', 'Other Area'),
(103, 'LGU - Kay Duke', 'LGU', 'Other Area'),
(104, 'LGU - Botiloa', 'LGU', 'Other Area'),
(105, 'LGU - Matalaba', 'LGU', 'Other Area'),
(106, 'LGU - Morales', 'LGU', 'Other Area'),
(107, 'LGU - Polo', 'LGU', 'Other Area'),
(108, 'Administration', 'DENR-PENRO', 'Untenured'),
(109, 'LGU - Sihi (2018)', 'LGU', 'PA'),
(110, 'LGU - Ipil', 'LGU', 'Other Area'),
(111, 'MSC', 'Government', 'Other Area'),
(113, 'LGU - Malabon', 'LGU', 'Other Area'),
(114, 'LGU - Boi & Bayuti', 'LGU', 'Other Area'),
(115, 'LGU - Buenavista', 'LGU', 'Other Area'),
(116, 'Mt. Malindig Producers Cooperative (MMPC), Samahan ng Magsasaka sa Pinagbulugan (SMP)', 'PO', 'Other Area'),
(117, 'Caigangan Credit Cooperative (CCC) ,  Butterfly Breeders Association (B3A)', 'PO', 'Other Area'),
(118, 'LGU - Mabuhay', 'LGU', 'Other Area');

-- --------------------------------------------------------

--
-- Table structure for table `plantation_estab_tbl`
--

CREATE TABLE `plantation_estab_tbl` (
  `plantation_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `seed_code` varchar(10) NOT NULL,
  `activities` varchar(100) NOT NULL,
  `UWM` varchar(10) NOT NULL,
  `total_contract` decimal(10,0) DEFAULT NULL,
  `unit_cost` int(11) DEFAULT NULL,
  `total_target` varchar(100) DEFAULT NULL,
  `accomplishment` decimal(10,0) DEFAULT NULL,
  `seed_planted` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `plantation_estab_tbl`
--

INSERT INTO `plantation_estab_tbl` (`plantation_id`, `unique_code`, `seed_code`, `activities`, `UWM`, `total_contract`, `unit_cost`, `total_target`, `accomplishment`, `seed_planted`) VALUES
(4, '22-174000-0001-0012', '6F', 'Fruit Trees', 'Has', 77520, 6500, '12 ha', 100, 6000),
(5, '11-174001-0001-0034', 'tH', 'Timber', 'ha', 0, 0, '34 ha', 100, 17000),
(16, '22-174000-0003-0032', 'Zk', 'Indigenous Trees', 'ha', 155040, 6500, '24 ha', 100, 19000),
(17, '22-174000-0003-0032', 'Zk', 'Fruit Trees', 'ha', 51680, 6500, '8 ha', 100, 19000),
(18, '22-174000-0004-0020', 'Qk', 'Indigenous Tree', 'ha', 84500, 6500, '13 ha', 100, 11625),
(19, '22-174000-0004-0020', 'Qk', 'Fruit Trees', 'ha', 45500, 6500, '7 ha', 100, 11625),
(20, '22-174000-0002-0011', 'iZ', 'Fruit Trees', 'ha', 71060, 6500, '11 ha', 100, 5500),
(22, '22-174000-0005-0024', 'QE', 'Indigenous Trees', 'ha', 8125, 6500, '13', 100, 14125),
(23, '22-174000-0005-0024', 'QE', 'Fruit Trees', 'ha', 6000, 6500, '12', 100, 14125),
(24, '21-174000-0001-0020/ 21-174000-0002-0050', '8j', 'Indigenous Trees', 'ha', 157500, 4500, 'n/a', 100, 39375),
(25, '21-174000-0001-0020/ 21-174000-0002-0050', '8j', 'Fruit Trees', 'ha', 157500, 4500, 'n/a', 100, 39375),
(26, '21-174000-0003-0010', 'Bi', 'Bamboo', 'ha', 85000, 4500, '10', 100, 2040);

-- --------------------------------------------------------

--
-- Table structure for table `polygon_tbl`
--

CREATE TABLE `polygon_tbl` (
  `polygon_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `polygon_site` int(11) DEFAULT NULL,
  `polygon_code` varchar(100) NOT NULL,
  `remark` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `projectcost_tbl`
--

CREATE TABLE `projectcost_tbl` (
  `cost_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `project_cost` decimal(10,0) DEFAULT NULL,
  `year1` decimal(10,0) DEFAULT NULL,
  `year2` decimal(10,0) DEFAULT NULL,
  `year3` decimal(10,0) DEFAULT NULL,
  `gross_amount` decimal(10,0) DEFAULT NULL,
  `polygon_code` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `projectcost_tbl`
--

INSERT INTO `projectcost_tbl` (`cost_id`, `unique_code`, `project_cost`, `year1`, `year2`, `year3`, `gross_amount`, `polygon_code`) VALUES
(5, '11-174001-0001-0034', 292910, 207910, 85000, NULL, 220660, 'test-1'),
(6, '11-174001-0012-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(7, '11-174001-0013-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(8, '11-174001-0014-0004', 39292, 26000, 10092, 3200, 39292, NULL),
(9, '11-174001-0017-0009', 117252, 86445, 23607, 7200, 117252, NULL),
(10, '11-174001-0018-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(11, '11-174001-0024-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(12, '11-174001-0025-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(13, '11-174001-0026-0004', 39292, 26000, 10092, 3200, 39292, NULL),
(14, '11-174001-0027-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(15, '11-174001-0028-0003', 27069, 19500, 7569, 0, 27069, NULL),
(16, '11-174001-0029-0003', 27069, 19500, 7569, 0, 27069, NULL),
(17, '11-174001-0030-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(18, '11-174001-0031-0003', 27069, 19500, 7569, 0, 27069, NULL),
(20, '11-174001-0034-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(21, '11-174001-0035-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(23, '11-174001-0037-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(24, '11-174001-0038-0003', 29469, 19500, 7569, 2400, 27577, NULL),
(25, '11-174001-0039-0003', 39292, 26000, 10092, 3200, 39292, NULL),
(26, '11-174001-0040-0002', 29469, 19500, 7569, 2400, 29469, NULL),
(27, '11-174001-0041-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(28, '11-174001-0042-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(29, '11-174001-0006-0003', 29469, 19500, 7569, 2400, 29469, NULL),
(30, '11-174001-0002-0008', 117159, 89450, 21309, 6400, 110759, NULL),
(31, '11-174001-0003-0002', 272196, 15083, 5079, 0, 213911, 'sites-00318'),
(32, '11-174001-0004-0012', 0, 90500, 30476, 0, NULL, 'sites-00318'),
(33, '11-174001-0005-0007', 0, 52792, 17778, 0, NULL, 'sites-00318'),
(35, '11-174001-0043-0003', 0, 22625, 7619, 0, NULL, 'sites-00318'),
(36, '11-174001-0007-0001', 0, 7542, 2540, 0, NULL, 'sites-00318'),
(37, '11-174001-0008-0002', 0, 15083, 5079, 0, NULL, 'sites-00318'),
(40, '11-174001-0010-0040', 235200, 100480, 102720, 32000, 449600, NULL),
(41, '11-174001-0015-0018', 673280, 161345, 46250, 0, 161345, 'sites-35316'),
(42, '11-174001-0020-0010', 57130, 23900, 25230, 8000, 86380, NULL),
(43, '11-174001-0021-0012', 131399, 28680, 30276, 9600, 103656, 'sites-05649'),
(44, '11-174001-0022-0005', 0, 11950, 12615, 4000, 43190, 'sites-05649'),
(45, '11-174001-0023-0006', 0, 14340, 15138, 4800, 51828, 'sites-05649'),
(46, '11-174001-0032-0005', 28565, 11950, 12615, 4000, 47190, NULL),
(47, '11-174001-0044-0003', 14739, 7170, 7569, 0, 25914, NULL),
(48, '12-174001-0001-0014', 182000, 119000, 35000, 28000, 147000, NULL),
(49, '12-174001-0002-0001', 561000, 17750, 3550, 2840, 561000, 'sites-43089'),
(50, '12-174001-0003-0007', 0, 89875, 17975, 14380, NULL, 'sites-43089'),
(51, '12-174001-0004-0003', 0, 37125, 7425, 5940, NULL, 'sites-43089'),
(52, '12-174001-0005-0002', 0, 24750, 4950, 3960, NULL, 'sites-43089'),
(53, '12-174001-0006-0001', 0, 6250, 1250, 1000, NULL, 'sites-43089'),
(54, '12-174001-0007-0004', 0, 50000, 10000, 8000, NULL, 'sites-43089'),
(55, '12-174001-0008-0000', 0, 3750, 750, 600, NULL, 'sites-43089'),
(56, '12-174001-0009-0001', 0, 6250, 1250, 1000, NULL, 'sites-43089'),
(57, '12-174001-0010-0000', 0, 3250, 650, 520, NULL, 'sites-43089'),
(58, '12-174001-0011-0001', 0, 8750, 1750, 1400, NULL, 'sites-43089'),
(59, '12-174001-0013-0001', 0, 12500, 2500, 2000, NULL, 'sites-43089'),
(60, '12-174001-0014-0001', 0, 12500, 2500, 2000, NULL, 'sites-43089'),
(61, '12-174001-0015-0002', 0, 27500, 5500, 4400, NULL, 'sites-43089'),
(62, '12-174001-0016-0001', 0, 6250, 1250, 1000, NULL, 'sites-43089'),
(63, '12-174001-0017-0001', 0, 15250, 3050, 2440, NULL, 'sites-43089'),
(64, '12-174001-0018-0001', 0, 8125, 1625, 1300, NULL, 'sites-43089'),
(65, '12-174001-0019-0000', 0, 2125, 425, 340, NULL, 'sites-43089'),
(66, '12-174001-0022-0004', 0, 50000, 10000, 8000, NULL, 'sites-43089'),
(67, '12-174001-0023-0001', 0, 17500, 3500, 2800, NULL, 'sites-43089'),
(68, '12-174001-0024-0000', 0, 500, 100, 80, NULL, 'sites-43089'),
(69, '12-174001-0027-0001', 0, 12500, 2500, 2000, NULL, 'sites-43089'),
(70, '12-174001-0012-0050', 650000, 425000, 125000, 100000, 650000, NULL),
(71, '12-174001-0020-0045', 936000, 382500, 112500, 382500, 585000, 'sites-17697'),
(72, '12-174001-0021-0027', 0, 229500, 67500, 54000, 351000, 'sites-17697'),
(73, '12-174001-0025-0011', 546000, 93500, 27500, 22000, 115500, 'sites-31894'),
(74, '12-174001-0026-0031', 0, 263500, 77500, 62000, 325500, 'sites-31894'),
(75, '12-174001-0029-0020', 260000, 170000, 50000, 40000, 260000, NULL),
(76, '12-174001-0028-0011', 145000, 100000, 25000, 20000, 145000, NULL),
(77, '12-174001-0030-0003', 36000, 30000, 6000, 0, 10500, NULL),
(78, '12-174001-0031-0003', 96000, 30000, 6000, 0, 33000, 'sites-57598'),
(79, '12-174001-0032-0005', 0, 50000, 10000, 0, NULL, 'sites-57598'),
(80, '12-174001-0038-0001', 72000, 30000, 6000, 0, 21000, 'sites-87560'),
(81, '12-174001-0048-0002', 75000, 75000, 0, 0, NULL, 'sites-74670'),
(82, '13-174001-0005-0004', 35600, 16000, 12000, 7600, 34840, NULL),
(83, '13-174001-0016-0018', 213600, 96000, 72000, 45600, 209040, 'sites-41678'),
(84, '13-174001-0008-0006', 0, 0, 0, 0, NULL, 'sites-41678'),
(85, '13-174001-0009-0006', 53400, 24000, 18000, 11400, 52260, NULL),
(86, '13-174001-0012-0005', 44500, 20000, 15000, 9500, 43550, NULL),
(87, '13-174001-0014-0027', 240300, 108000, 81000, 51300, 240300, NULL),
(88, '13-174001-0015-0015', 133500, 60000, 45000, 28500, 133500, NULL),
(89, '13-174001-0017-0010', 89000, 60000, 40000, 30000, 87100, NULL),
(90, '11-174001-0011-0030', 294690, 195000, 75690, 24000, 270690, 'sites-34911'),
(91, '12-174001-0033-0004', 48000, 40000, 8000, 0, 14000, NULL),
(92, '12-174001-0034-0006', 84000, 70000, 14000, 0, 24500, NULL),
(93, '12-174001-0036-0005', 60000, 50000, 10000, 0, 17500, NULL),
(94, '12-174001-0037-0003', 0, 30000, 6000, 0, NULL, 'sites-87560'),
(95, '12-174001-0039-0005', 60000, 50000, 10000, 0, 17500, NULL),
(96, '12-174001-0040-0007', 72000, 60000, 12000, 0, 21000, NULL),
(97, '12-174001-0041-0007', 84000, 70000, 14000, 0, 7000, NULL),
(98, '12-174001-0042-0001', 12000, 10000, 2000, 0, 3500, NULL),
(99, '12-174001-0043-0003', 36000, 30000, 6000, 0, 16260, NULL),
(100, '12-174001-0044-0005', 60000, 50000, 10000, 0, 17500, NULL),
(101, '12-174001-0045-0002', 24000, 20000, 4000, 0, 7000, NULL),
(102, '12-174001-0046-0002', 24000, 20000, 4000, 0, 7000, NULL),
(103, '12-174001-0047-0005', 84000, 70000, 14000, 0, 47250, NULL),
(104, '13-174001-0018-0058', 864200, 580000, 174000, 110200, 505180, NULL),
(105, '13-174001-0019-0029', 258100, 116000, 87000, 55100, 258100, NULL),
(106, '13-174001-0020-0034', 506600, 340000, 102000, 64600, 296140, NULL),
(107, '13-174001-0021-0005', 44500, 20000, 15000, 9500, 44500, NULL),
(108, '13-174001-0026-0038', 338200, 152000, 114000, 72200, 330980, NULL),
(109, '13-174001-0027-0030', 480600, 216000, 162000, 102600, 470340, 'sites-61323'),
(110, '13-174001-0024-0024', 0, 0, 0, 0, NULL, 'sites-61323'),
(111, '13-174001-0035-0031', 275900, 124000, 93000, 58900, 270010, NULL),
(112, '13-174001-0038-0006', 356000, 160000, 120000, 76000, 356000, 'sites-23560'),
(113, '13-174001-0039-0004', 0, 0, 0, 0, NULL, 'sites-23560'),
(114, '13-174001-0040-0005', 0, 0, 0, 0, NULL, 'sites-23560'),
(115, '13-174001-0041-0031', 0, 0, 0, 0, NULL, 'sites-23560'),
(116, '13-174001-0042-0044', 587400, 264000, 198000, 125400, 587400, NULL),
(117, '13-174001-0031-0022', 0, 0, 0, 0, NULL, NULL),
(118, '13-174001-0046-0009', 106800, 48000, 36000, 22800, 106800, 'sites-00123'),
(119, '13-174001-0048-0005', 70000, 40000, 30000, 0, 70000, 'sites-40332'),
(120, '13-174001-0013-0009', 238400, 160000, 48000, 30400, 142400, 'sites-08630'),
(121, '13-174001-0055-0091', 1355900, 910000, 273000, 172900, 809900, NULL),
(122, '13-174001-0056-0033', 491700, 330000, 99000, 62700, 293700, NULL),
(123, '13-174001-0006-0043', 447000, 300000, 90000, 57000, 447000, NULL),
(124, '13-174001-0007-0002', 894000, 600000, 180000, 114000, 534000, 'sites-50050'),
(125, '13-174001-0032-0015', 223500, 150000, 45000, 28500, 223500, NULL),
(126, '13-174001-0003-0005', 283100, 190000, 57000, 36100, 165490, 'sites-80980'),
(127, '13-174001-0010-0005', 106800, 48000, 36000, 22800, NULL, 'sites-00022'),
(128, '13-174001-0023-0008', 149000, 100000, 30000, 19000, 87100, 'sites-17671'),
(129, '13-174001-0036-0005', 169100, 76000, 57000, 36100, NULL, 'sites-99247'),
(130, '13-174001-0030-0040', 894000, 600000, 180000, 114000, 534000, 'sites-90990'),
(131, '13-174001-0033-0003', 259000, 238000, 21000, 0, NULL, 'sites-63689'),
(132, '15-174001-0001-0005', 127400, 87400, 24000, 16000, 108260, 'sites-00038'),
(133, '15-174001-0007-0020', 318500, 218500, 60000, 40000, 286650, NULL),
(134, '15-174001-0010-0010', 175175, 120175, 33000, 22000, 286650, 'sites-91169'),
(135, '15-174001-0012-0004', 95550, 65550, 18000, 12000, 85995, 'sites-52761'),
(136, '15-174001-0013-0008', 859950, 589950, 162000, 108000, 773955, 'sites-92797'),
(137, '15-174001-0024-0004', 63700, 43700, 12000, 8000, NULL, 'sites-92797'),
(138, '15-174001-0017-0007', 116091, 56091, 36000, 24000, 171990, 'sites-81960'),
(139, '15-174001-0020-0004', 111475, 76475, 21000, 14000, 100328, 'sites-75811'),
(140, '15-174001-0022-0021', 398125, 273125, 75000, 50000, 358313, 'sites-06826'),
(141, '15-174001-0025-0040', 637000, 437000, 120000, 80000, 474300, NULL),
(142, '15-174001-0027-0015', 238875, 163875, 45000, 30000, 147103, NULL),
(143, '15-174001-0028-0002', 199063, 136562, 37500, 25000, 179206, 'sites-06735'),
(144, '15-174001-0030-0005', 318500, 218500, 60000, 40000, 286650, 'sites-75161'),
(145, '15-174001-0034-0010', 445900, 305900, 84000, 56000, 401310, 'sites-54145'),
(146, '15-174001-0037-0002', 414050, 284050, 78000, 52000, 372645, 'sites-21549'),
(147, '15-174001-0033-0001', 15500, 10500, 3000, 2000, 13950, NULL),
(148, '15-174001-0034-0002', 31000, 21000, 6000, 4000, 28500, 'sites-08290'),
(149, '15-174001-0035-0002', 31000, 21000, 6000, 4000, 24600, NULL),
(150, '15-174001-0038-0017', 263500, 178500, 51000, 34000, 220575, NULL),
(151, '15-174001-0042-0006', 93000, 63000, 18000, 12000, 83700, NULL),
(152, '15-174001-0056-0007', 111475, 76475, 14000, 12000, 100328, NULL),
(153, '15-174001-0043-0053', 806000, 546000, 156000, 104000, 725400, NULL),
(155, '15-174001-0054-0002', 341000, 231000, 66000, 44000, 306900, NULL),
(156, '15-174001-0039-0010', 465000, 315000, 90000, 60000, 418500, 'sites-38797'),
(157, '15-174001-0048-0006', 403000, 273000, 78000, 52000, 362700, NULL),
(158, '15-174001-0045-0021', 1173000, 1043000, 78000, 52000, NULL, 'sites-47750'),
(159, '16-174001-0001-0027', 707000, 572000, 81000, 54000, 587700, NULL),
(160, '17-174001-0001-0025', 1235884, 907884, 123000, 205000, 1062701, 'sites-28998'),
(161, '17-174001-0003-0049', 1467116, 1075116, 147000, 245000, 1258021, NULL),
(162, '18-174000-0004-0010', 245000, 145000, 50000, 50000, NULL, NULL),
(163, '18-174000-0003-0010', 175000, 75000, 50000, 50000, NULL, NULL),
(164, '18-174000-0009-0030', 930550, 630550, 150000, 150000, 837495, NULL),
(165, '18-174000-0027-0040', 1236450, 836450, 200000, 200000, 1112805, NULL),
(166, '18-174000-0268-0002', 175119, 135369, 200000, 19750, 154007, 'sites-28409'),
(167, '18-174000-0307-0013', 919025, 764775, 77250, 77000, 813218, 'sites-62583'),
(168, '18-174000-0001-0006', 105000, 45000, 30000, 30000, NULL, NULL),
(169, '18-174000-0002-0004', 70000, 30000, 20000, 20000, NULL, NULL),
(170, '11-174001-0016-0041', 0, 361935, 103750, 0, 361935, 'sites-35316'),
(171, '20-174000-0001-0012', 520000, 200000, 60000, 260000, 272880, NULL),
(172, '20-174000-0008-0001', 2433000, 1833000, 300000, 300000, 2373000, 'sites-95629'),
(173, '11-174001-0019-0009', 51417, 21510, 22707, 7200, 84942, NULL),
(174, '12-174001-0035-0013', 144000, 120000, 24000, 0, 42000, NULL),
(175, '12-174001-0049-0001', 37500, 37500, 0, 0, NULL, 'sites-74670'),
(176, '13-174001-0025-0025', 279500, 232000, 0, 47500, 142750, NULL),
(177, '13-174001-0043-0094', 836600, 376000, 282000, 178600, 818740, NULL),
(178, '11-174001-0033-0001', 29469, 19500, 7569, 2400, 29469, NULL),
(179, '11-174001-0036-0002', 27069, 19500, 0, 35069, 35069, NULL),
(180, '15-174001-0006-0001', 103513, 71013, 19500, 13000, NULL, NULL),
(181, '15-174001-0008-0003', 75625, 54625, 15000, 6000, NULL, NULL),
(182, '15-174001-0026-0006', 79625, 54625, 15000, 10000, 49163, NULL),
(183, '15-174001-0036-0003', 170500, 115500, 33000, 22000, 153450, 'sites-68358'),
(184, '18-174000-0309-0013', 782770, 651420, 65800, 65550, 698571, NULL),
(185, '18-174000-0310-0004', 677455, 563805, 56950, 56700, 596575, 'sites-14777'),
(186, '18-174000-0005-0002', 262500, 112500, 75000, 75000, NULL, NULL),
(187, '18-174000-0011-0007', 210000, 90000, 60000, 60000, NULL, NULL),
(188, '18-174000-0014-0001', 8750, 3750, 2500, 2500, NULL, NULL),
(189, '18-174000-0035-0000', 8750, 3750, 2500, 2500, NULL, NULL),
(190, '18-174000-0029-0001', 17500, 7500, 5000, 5000, NULL, NULL),
(191, '18-174000-0018-0001', 30625, 13125, 8750, 8750, NULL, NULL),
(192, '18-174000-0020-0004', 155775, 67425, 44150, 44200, NULL, NULL),
(193, '18-174000-0024-0000', 26000, 11250, 7400, 7350, NULL, NULL),
(194, '18-174000-0028-0001', 21000, 9000, 6000, 6000, NULL, NULL),
(195, '18-174000-0026-0001', 21000, 9000, 6000, 6000, NULL, NULL),
(196, '18-174000-0017-0001', 17500, 7500, 5000, 5000, NULL, NULL),
(197, '18-174000-0030-0000', 7875, 3375, 2250, 2250, NULL, NULL),
(198, '18-174000-0032-0001', 25900, 11100, 7400, 7400, NULL, NULL),
(199, '18-174000-0033-0000', 1750, 750, 500, 500, NULL, NULL),
(200, '18-174000-0034-0003', 46900, 20100, 13400, 13400, NULL, NULL),
(201, '18-174000-0036-0000', 1400, 600, 400, 400, NULL, NULL),
(202, '18-174000-0037-0002', 33075, 14175, 9450, 9450, NULL, NULL),
(203, '18-174000-0038-0001', 22400, 9600, 6400, 6400, NULL, NULL),
(204, '18-174000-0039-0008', 122500, 52500, 35000, 35000, NULL, NULL),
(205, '18-174000-0010-0005', 87500, 37500, 25000, 25000, NULL, NULL),
(206, '18-174000-0022-0028', 612500, 262500, 175000, 175000, NULL, NULL),
(207, '18-174000-0015-0000', 9400, 3600, 2900, 2900, NULL, NULL),
(208, '15-174001-0012-0000', 950000, 825000, 75000, 50000, 945000, 'sites-83751'),
(211, '11-174001-0009-0030', 294690, 195000, 75690, 24000, 270690, 'sites-34911'),
(212, '13-174001-0049-0002', 0, 0, 0, 0, 0, 'sites-40332'),
(213, '13-174001-0050-0005', 0, 0, 0, 0, 0, 'sites-40332'),
(214, '13-174001-0052-0013', 0, 0, 0, 0, 0, 'sites-08630'),
(215, '13-174001-0045-0028', 0, 0, 0, 0, 0, 'sites-50050'),
(216, '13-174001-0044-0030', 0, 0, 0, 0, 0, 'sites-50050'),
(217, '13-174001-0004-0014', 0, 0, 0, 0, 0, 'sites-80980'),
(218, '13-174001-0011-0004', 0, 0, 0, 0, 0, 'sites-00022'),
(219, '13-174001-0001-0001', 0, 0, 0, 0, 0, 'sites-17671'),
(220, '13-174001-0002-0001', 0, 0, 0, 0, 0, 'sites-17671'),
(221, '13-174001-0037-0017', 0, 0, 0, 0, 0, 'sites-99247'),
(222, '13-174001-0034-0004', 0, 0, 0, 0, 0, 'sites-63689'),
(223, '15-174001-0002-0004', 0, 0, 0, 0, 0, 'sites-00038'),
(224, '15-174001-0003-0003', 238875, 163875, 45000, 30000, 219488, 'sites-53362'),
(225, '15-174001-0005-0008', 0, 0, 0, 0, 0, 'sites-53362'),
(226, '15-174001-0004-0004', 0, 0, 0, 0, 0, 'sites-53362'),
(227, '15-174001-0019-0002', 0, 0, 0, 0, 0, 'sites-52761'),
(228, '15-174001-0014-0008', 0, 0, 0, 0, 0, 'sites-92797'),
(229, '15-174001-0015-0015', 0, 0, 0, 0, 0, 'sites-92797'),
(230, '15-174001-0016-0021', 0, 0, 0, 0, 0, 'sites-92797'),
(231, '15-174001-0018-0005', 0, 0, 0, 0, 0, 'sites-81960'),
(232, '15-174001-0021-0003', 0, 0, 0, 0, 0, 'sites-75811'),
(233, '15-174001-0023-0005', 0, 0, 0, 0, 0, 'sites-06826'),
(234, '15-174001-0029-0010', 0, 0, 0, 0, 0, 'sites-06735'),
(235, '15-174001-0031-0005', 0, 0, 0, 0, 0, 'sites-75161'),
(236, '15-174001-0032-0002', 0, 0, 0, 0, 0, 'sites-75161'),
(237, '15-174001-0033-0005', 0, 0, 0, 0, 0, 'sites-75161'),
(238, '15-174001-0036-0002', 0, 0, 0, 0, 0, 'sites-75161'),
(239, '15-174001-0035-0018', 0, 0, 0, 0, 0, 'sites-54145'),
(240, '15-174001-0038-0012', 0, 0, 0, 0, 0, 'sites-21549'),
(241, '15-174001-0039-0006', 0, 0, 0, 0, 0, 'sites-21549'),
(242, '15-174001-0041-0006', 0, 0, 0, 0, 0, 'sites-21549'),
(243, '15-174001-0037-0009', 0, 0, 0, 0, 0, 'sites-68358'),
(244, '15-174001-0044-0006', 93000, 63000, 18000, 12000, 85500, NULL),
(245, '15-174001-0040-0010', 0, 0, 0, 0, 0, 'sites-38797'),
(246, '15-174001-0041-0010', 0, 0, 0, 0, 0, 'sites-38797'),
(247, '15-174001-0046-0024', 0, 0, 0, 0, 0, 'sites-47750'),
(248, '17-174001-0002-0016', 0, 0, 0, 0, 0, 'sites-28998'),
(249, '18-174000-0266-0001', 0, 0, 0, 0, 0, 'sites-28409'),
(250, '18-174000-0267-0001', 0, 0, 0, 0, 0, 'sites-28409'),
(251, '18-174000-0308-0002', 0, 0, 0, 0, 0, 'sites-62583'),
(252, '18-174000-0311-0008', 0, 0, 0, 0, 0, 'sites-14777'),
(253, '20-174000-0009-0006', 0, 0, 0, 0, 0, 'sites-95629'),
(254, '15-174001-0020-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(255, '15-174001-0021-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(256, '15-174001-0026-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(257, '15-174001-0013-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(258, '15-174001-0014-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(259, '15-174001-0015-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(260, '15-174001-0016-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(261, '15-174001-0001-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(262, '15-174001-0002-0002', 0, 0, 0, 0, 0, 'sites-83751'),
(263, '15-174001-0008-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(264, '15-174001-0009-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(265, '15-174001-0010-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(266, '15-174001-0027-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(267, '15-174001-0028-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(268, '15-174001-0029-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(269, '15-174001-0023-0007', 0, 0, 0, 0, 0, 'sites-83751'),
(270, '15-174001-0024-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(271, '15-174001-0003-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(272, '15-174001-0004-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(273, '15-174001-0005-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(274, '15-174001-0022-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(275, '15-174001-0018-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(276, '15-174001-0019-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(277, '15-174001-0031-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(278, '15-174001-0017-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(279, '15-174001-0025-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(280, '15-174001-0006-0000', 0, 0, 0, 0, 0, 'sites-83751'),
(281, '15-174001-0007-0001', 0, 0, 0, 0, 0, 'sites-83751'),
(282, '15-174001-0011-0001Bba', 0, 0, 0, 0, 0, 'sites-83751'),
(283, '15-174001-0011-0001Bbb', 0, 0, 0, 0, 0, 'sites-83751');

-- --------------------------------------------------------

--
-- Table structure for table `remarks`
--

CREATE TABLE `remarks` (
  `remarks_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `code_remark` varchar(10) NOT NULL,
  `remarks` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `remarks`
--

INSERT INTO `remarks` (`remarks_id`, `unique_code`, `code_remark`, `remarks`) VALUES
(3, '22-174000-0001-0012', '6F', '6000 fruit trees for 500 per hectares\r\nSpacing 4m x 5m\r\nSignage Installed'),
(4, '22-174000-0001-0012', 'P8', 'Signage was installed'),
(5, '22-174000-0001-0012', 'DR', 'Signage was installed'),
(6, '22-174000-0001-0012', 'tK', 'Signage was installed'),
(7, '22-174000-0001-0012', 'T8', 'hello'),
(8, '22-174000-0001-0012', 'xD', 'fdfsfdsggf'),
(9, '22-174000-0001-0012', 'QB', '1 meter stakelabel and painted with color white rock\r\nA signage/Billboard was installed\r\n86% of the planted was survived\r\n'),
(10, '11-174001-0001-0034', 'tH', 'N/A'),
(18, '22-174000-0003-0032', 'Uo', 'Fruit trees spacing 4m x 5m (500 per hectare)\nIndigenous trees spacing 4m x 4m (625 per hectares)\n1 meter stake label painted white rock color\nSignage/billboard was installed\n'),
(26, '22-174000-0003-0032', 'kl', 'Replaced dead seedlings with a new one\r\nSignage/Billboard placed near the agroforestry\r\n'),
(28, '22-174000-0004-0020', '86', 'Conduct replanting, foot patrol and among others\r\nReplace the dead seedlings\r\nNo sign of stray animals in the area\r\nSignage/bilboard was installed located at strategic place near the agro-forestry project\r\n'),
(29, '22-174000-0002-0011', 'iZ', '5500 fruit trees planted \r\n500 per hectares with spacing of 4m x 5m\r\n1 meter stake label painted with color rock\r\nSignage/billboard was installed located at strategic place'),
(30, '22-174000-0002-0011', 'Vu', 'Replaced the dead seedlings with a new one\r\nSignage/billboard placed near agroforestry project\r\nIt was observed that 86% of the planted was survive'),
(31, '21-174000-0003-0010', 'Bi', '- A total of 1,795 bamboo planting stock\r\n-88 %  survived in Plantation'),
(32, '21-174000-0003-0010', 'Wa', '- It was observed that maintenance and protection activities particulary replanting were undertaken');

-- --------------------------------------------------------

--
-- Table structure for table `seedplanted_tbl`
--

CREATE TABLE `seedplanted_tbl` (
  `seed_id` int(11) NOT NULL,
  `seed_code` varchar(100) NOT NULL,
  `date_request` date NOT NULL,
  `date_inspected` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `seedplanted_tbl`
--

INSERT INTO `seedplanted_tbl` (`seed_id`, `seed_code`, `date_request`, `date_inspected`) VALUES
(9, '6F', '2022-12-08', '2022-12-08'),
(10, 'tH', '2011-01-01', '2011-01-01'),
(15, 'pK', '2023-10-28', '2023-10-27'),
(17, 'Oj', '2023-10-26', '2023-10-27'),
(26, 'Zk', '2022-11-25', '2022-12-08'),
(27, 'cK', '2022-11-24', '2022-12-07'),
(28, 'Qk', '2022-11-24', '2022-12-07'),
(29, 'iZ', '2022-11-07', '2022-12-08'),
(31, 'QE', '2022-09-22', '2022-10-04'),
(32, '8j', '2021-10-29', '2021-11-06'),
(33, 'Bi', '2021-09-24', '2021-09-29'),
(34, 'RB', '2024-06-19', '2024-06-18');

-- --------------------------------------------------------

--
-- Table structure for table `seedproduction_tbl`
--

CREATE TABLE `seedproduction_tbl` (
  `seed_id` int(11) NOT NULL,
  `seed_code` varchar(100) DEFAULT NULL,
  `date_request` date DEFAULT NULL,
  `date_inspected` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `seedproduction_tbl`
--

INSERT INTO `seedproduction_tbl` (`seed_id`, `seed_code`, `date_request`, `date_inspected`) VALUES
(3, 'Sv', '2022-06-30', '2022-07-26'),
(4, '2g', '2011-01-01', '2011-01-01'),
(5, 'Xy', '2022-06-24', '2022-06-30'),
(31, 'BA', '2022-06-27', '2022-08-05'),
(32, 'ya', '2022-06-24', '2022-06-30'),
(33, '9Q', '2022-06-20', '2022-06-29'),
(34, 'J8', '2021-06-24', '2021-06-29'),
(35, 'J8', '2021-06-24', '2021-06-29'),
(36, 'j3', '2022-06-27', '2022-08-08'),
(37, 'Ro', '2024-04-05', '2024-04-06'),
(38, 'hG', '2024-04-01', '2024-04-01'),
(39, 'Y3', '2024-04-02', '2024-04-01'),
(40, 'WU', '2024-04-02', '2024-04-01'),
(41, 'Yb', '2011-04-02', '2011-04-01'),
(42, 'Yy', '2011-04-02', '2011-04-01'),
(43, '3U', '2011-04-02', '2011-04-01'),
(44, 'Jq', '2011-04-02', '2011-04-01'),
(45, 'TS', '2011-04-02', '2011-04-01'),
(46, 'o1', '2011-04-01', '2011-04-02'),
(47, 'HN', '2011-04-01', '2011-04-02'),
(48, 'dc', '2011-04-01', '2011-04-02'),
(49, 'dk', '2011-04-01', '2011-04-02'),
(50, 'IR', '2011-04-01', '2011-04-02'),
(51, 'S4', '2011-04-01', '2011-04-02'),
(52, 'iy', '2011-04-01', '2011-04-02'),
(53, 'BN', '2011-04-01', '2011-04-02'),
(54, '3C', '2011-04-01', '2011-04-02'),
(55, 'Ii', '2024-04-01', '2024-04-25'),
(56, 'rq', '2011-04-01', '2011-04-02'),
(57, '3U', '2011-04-01', '2011-04-02'),
(58, 'Wh', '2011-04-01', '2011-04-02'),
(59, '28', '2011-04-01', '2011-04-02'),
(60, 'mT', '2011-04-01', '2011-04-02'),
(61, 'bT', '2011-04-01', '2011-04-02'),
(62, '2M', '2011-04-01', '2011-04-02'),
(63, 'V2', '2011-04-01', '2011-04-02'),
(64, 'Zh', '2011-04-01', '2011-04-02'),
(65, 'Bd', '2011-04-01', '2011-04-02'),
(66, 'F7', '2011-04-01', '2011-04-02'),
(67, '0X', '2011-04-01', '2011-04-02'),
(68, 'n2', '2011-04-01', '2011-04-25'),
(69, 'Ii', '2011-04-01', '2011-04-02'),
(70, 'gw', '2011-04-01', '2011-04-02'),
(71, 'C6', '2011-04-01', '2011-04-02'),
(72, 'sn', '2011-04-01', '2011-04-02'),
(73, 'OE', '2011-04-01', '2011-04-02'),
(74, 'AM', '2011-04-01', '2011-04-02'),
(75, 'n7', '2011-04-01', '2011-04-02'),
(76, 'MP', '2011-04-01', '2011-04-02'),
(77, 'tY', '2011-04-01', '2011-04-02'),
(78, 'xk', '2011-04-01', '2011-04-02'),
(79, 'Vy', '2011-04-01', '2011-04-02'),
(80, '7T', '2011-04-01', '2011-04-02'),
(81, 'LE', '2011-04-01', '2011-04-02'),
(82, 'CB', '2024-04-01', '2024-04-26'),
(83, 'wD', '2011-04-01', '2011-04-02'),
(84, '8A', '2011-04-01', '2011-04-02'),
(85, 'Q6', '2024-04-01', '2024-04-29'),
(86, 'Qy', '2024-04-01', '2024-04-02'),
(88, 'qs', '2024-04-01', '2024-04-02'),
(89, '68', '2024-04-01', '2024-04-02'),
(90, 'GF', '2024-04-01', '2024-04-29'),
(91, '28', '2024-04-01', '2024-04-02'),
(92, 'Qe', '2024-04-01', '2024-04-02'),
(93, 'Je', '2024-04-01', '2024-04-29'),
(94, 'E3', '2024-04-01', '2024-04-02'),
(95, 'E3', '2024-04-01', '2024-04-02'),
(96, 'yI', '2024-04-01', '2024-04-02'),
(97, 'rm', '2024-04-01', '2024-04-02'),
(98, 'Bd', '2024-04-01', '2024-04-02'),
(99, 'Bd', '2024-04-01', '2024-04-02'),
(100, '5K', '2024-04-01', '2024-04-29'),
(101, 'Up', '2024-04-01', '2024-04-02'),
(102, '67', '2024-04-01', '2024-04-02'),
(103, 'GW', '2024-04-01', '2024-04-02'),
(104, '6W', '2024-04-01', '2024-04-02'),
(105, 'ig', '2024-04-01', '2024-04-29'),
(106, 'p6', '2024-04-01', '2024-04-02'),
(107, 'o5', '2024-04-01', '2024-04-02'),
(108, 'cJ', '2024-04-01', '2024-04-30'),
(109, 'QV', '2024-04-01', '2024-04-02'),
(110, 'lt', '2024-04-01', '2024-04-02'),
(111, 'PL', '2024-04-01', '2024-04-02'),
(112, 'p5', '2024-04-01', '2024-04-02'),
(113, 'uR', '2024-04-01', '2024-04-02'),
(114, 'BU', '2024-04-01', '2024-04-02'),
(115, 'M0', '2024-04-01', '2024-04-02'),
(116, 'xi', '2024-04-01', '2024-04-02'),
(117, 'Xr', '2024-04-01', '2024-04-02'),
(118, '1Z', '2024-04-01', '2024-04-02'),
(119, 'oJ', '2024-05-01', '2024-05-02'),
(120, 'sp', '2024-05-01', '2024-05-02'),
(121, 'E3', '2024-05-01', '2024-05-02'),
(122, 'pS', '2024-05-01', '2024-05-02'),
(123, '91', '2024-05-01', '2024-05-02'),
(124, 'D1', '2024-05-01', '2024-05-02'),
(125, 'n1', '2024-05-01', '2024-05-02'),
(126, 'sB', '2024-05-01', '2024-05-02'),
(127, 'WD', '2024-05-01', '2024-05-02'),
(128, 'FG', '2024-05-01', '2024-05-02'),
(129, 'AK', '2024-05-01', '2024-05-02'),
(130, 'ys', '2024-05-01', '2024-05-02'),
(131, 'GH', '2024-05-01', '2024-05-02'),
(132, 'J2', '2024-05-01', '2024-05-02'),
(133, 'wD', '2024-05-01', '2024-05-02'),
(134, 'Cr', '2024-05-01', '2024-05-02'),
(135, 'B4', '2024-05-01', '2024-05-02'),
(136, 'mn', '2024-05-01', '2024-05-02'),
(137, '2P', '2024-05-01', '2024-05-02'),
(138, 'SU', '2024-05-01', '2024-05-02'),
(139, 'vL', '2024-05-01', '2024-05-02'),
(140, 'ZL', '2024-05-01', '2024-05-02'),
(141, 'H6', '2024-05-01', '2024-05-02'),
(142, 'oc', '2024-05-02', '2024-05-03'),
(143, 'JX', '2024-05-02', '2024-05-03'),
(144, 'dT', '2024-05-02', '2024-05-03'),
(145, 'Kg', '2024-05-02', '2024-05-03'),
(146, 'y1', '2024-05-02', '2024-05-03'),
(147, 'wA', '2024-05-02', '2024-05-03'),
(148, 'Xw', '2024-05-02', '2024-05-03'),
(149, 'iF', '2024-05-02', '2024-05-03'),
(150, 'Q7', '2024-05-02', '2024-05-03'),
(151, 'SQ', '2024-05-02', '2024-05-03'),
(152, 'Kn', '2024-05-02', '2024-05-03'),
(153, 'DQ', '2024-05-02', '2024-05-03'),
(154, 't3', '2024-05-02', '2024-05-03'),
(155, 'PR', '2024-05-02', '2024-05-03'),
(156, 'af', '2024-05-02', '2024-05-03'),
(157, 'YI', '2024-05-02', '2024-05-03'),
(158, 'yU', '2024-05-02', '2024-05-03'),
(159, 'ds', '2024-05-02', '2024-05-03'),
(160, 'Tg', '2024-05-02', '2024-05-03'),
(161, '9X', '2024-05-02', '2024-05-03'),
(162, 'Nl', '2024-05-02', '2024-05-03'),
(163, '02', '2024-05-02', '2024-05-03'),
(164, 'Db', '2024-05-02', '2024-05-03'),
(165, 'X1', '2024-05-02', '2024-05-03'),
(166, 'Bk', '2024-05-02', '2024-05-03'),
(167, 'IS', '2024-05-02', '2024-05-03'),
(168, '07', '2024-05-02', '2024-05-03'),
(169, 'jE', '2024-05-02', '2024-05-03'),
(170, 'Qw', '2024-05-02', '2024-05-03'),
(171, 'pZ', '2024-05-02', '2024-05-03'),
(172, 'Zw', '2024-05-02', '2024-05-03'),
(173, 'FN', '2024-05-02', '2024-05-03'),
(174, 'GR', '2024-05-02', '2024-05-03'),
(175, 'Ds', '2024-05-02', '2024-05-03'),
(176, 'MZ', '2024-05-02', '2024-05-03'),
(177, 'i1', '2024-05-02', '2024-05-03'),
(178, 'f0', '2024-05-02', '2024-05-03'),
(179, 'jp', '2024-05-02', '2024-05-03'),
(180, 'qi', '2024-05-02', '2024-05-03'),
(181, 's3', '2024-05-02', '2024-05-03'),
(182, 'zP', '2024-05-02', '2024-05-03'),
(183, 'gf', '2024-05-02', '2024-05-03'),
(184, 'tc', '2024-05-02', '2024-05-03'),
(185, '7K', '2024-05-02', '2024-05-03'),
(186, 'mE', '2024-05-05', '2024-05-06'),
(187, '9o', '2024-05-05', '2024-05-06'),
(188, 'nD', '2024-05-05', '2024-05-06'),
(189, 'Up', '2024-05-05', '2024-05-06'),
(190, 'xz', '2024-05-05', '2024-05-06'),
(191, 'lF', '2024-05-05', '2024-05-06'),
(192, '99', '2024-05-05', '2024-05-06'),
(193, 'ze', '2024-05-05', '2024-05-06'),
(194, 'Gr', '2024-05-05', '2024-05-06'),
(195, 'fe', '2024-05-05', '2024-05-06'),
(196, 'T9', '2024-05-05', '2024-05-06'),
(197, 'ak', '2024-05-05', '2024-05-06'),
(198, 'oz', '2024-05-05', '2024-05-06'),
(199, 'uz', '2024-05-05', '2024-05-06'),
(200, 'F0', '2024-05-05', '2024-05-06'),
(201, 'A8', '2024-05-05', '2024-05-06'),
(202, 'oo', '2024-05-05', '2024-05-06'),
(203, 'oe', '2024-05-05', '2024-05-06'),
(204, 'ZY', '2024-05-05', '2024-05-06'),
(205, 'PQ', '2024-05-05', '2024-05-06'),
(206, 'n4', '2024-05-05', '2024-05-06'),
(207, '83', '2024-05-05', '2024-05-06'),
(208, 'hb', '2024-05-06', '2024-05-07'),
(209, 'bL', '2024-05-06', '2024-05-07'),
(210, 'KU', '2024-05-06', '2024-05-07'),
(211, 'yb', '2024-05-06', '2024-05-07'),
(212, 'nK', '2024-05-06', '2024-05-07'),
(213, 'RC', '2024-05-06', '2024-05-07'),
(214, 'V8', '2024-05-06', '2024-05-07'),
(215, 'tr', '2024-05-06', '2024-05-07'),
(216, 'Z7', '2024-05-06', '2024-05-07'),
(217, 'Xx', '2024-05-06', '2024-05-07'),
(218, 'o8', '2024-05-06', '2024-05-07'),
(219, 'nM', '2024-05-06', '2024-05-07'),
(220, 'dQ', '2024-05-06', '2024-05-07'),
(221, 'RU', '2024-05-06', '2024-05-07'),
(222, '7D', '2024-05-06', '2024-05-07'),
(223, 'Vt', '2024-05-06', '2024-05-07'),
(224, 'PB', '2024-05-06', '2024-05-07'),
(225, 'dS', '2024-05-06', '2024-05-07'),
(226, 'to', '2024-05-06', '2024-05-07'),
(227, '7r', '2024-05-06', '2024-05-07'),
(228, 'zj', '2024-05-06', '2024-05-07'),
(229, 'i9', '2024-05-06', '2024-05-07'),
(230, 'bM', '2024-05-06', '2024-05-07'),
(231, 'O5', '2024-05-06', '2024-05-07'),
(232, 'nJ', '2024-05-06', '2024-05-07'),
(233, '5v', '2024-05-06', '2024-05-07'),
(234, 'Cv', '2024-05-06', '2024-05-07'),
(235, 'jA', '2024-05-06', '2024-05-07'),
(236, 'P6', '2024-05-06', '2024-05-07'),
(237, '8z', '2024-05-06', '2024-05-07'),
(238, 'Hx', '2024-05-06', '2024-05-07'),
(239, '3Z', '2024-05-06', '2024-05-07'),
(240, 'ii', '2024-05-06', '2024-05-07'),
(241, 'ia', '2024-05-06', '2024-05-07'),
(242, 'hP', '2024-05-06', '2024-05-07'),
(243, 'y9', '2024-05-06', '2024-05-07'),
(244, 'Zg', '2024-05-14', '2024-05-15'),
(245, 'eZ', '2024-05-28', '2024-05-29'),
(246, 'XC', '2024-05-28', '2024-05-29'),
(247, 'en', '2024-05-28', '2024-05-29'),
(248, 'wd', '2024-05-28', '2024-05-29'),
(249, 'dD', '2024-05-28', '2024-05-29'),
(250, '3y', '2024-05-28', '2024-05-29'),
(251, 'fN', '2024-05-28', '2024-05-29'),
(252, 'gb', '2024-05-28', '2024-05-29'),
(253, 'WO', '2024-05-28', '2024-05-29'),
(254, 'SG', '2024-05-28', '2024-05-29'),
(255, 'aE', '2024-06-01', '2024-06-02'),
(256, 'zC', '2024-06-01', '2024-06-02'),
(257, 'qE', '2024-06-01', '2024-06-02'),
(258, 'l0', '2024-06-01', '2024-06-02'),
(259, 'C2', '2024-06-01', '2024-06-02'),
(260, 'qt', '2024-06-01', '2024-06-02'),
(261, 'ZV', '2024-06-01', '2024-06-02'),
(262, 'uk', '2024-06-01', '2024-06-02'),
(263, 'nK', '2024-06-01', '2024-06-02'),
(264, '0q', '2024-06-01', '2024-06-02'),
(265, 'FS', '2024-06-01', '2024-06-02'),
(266, '7W', '2024-06-01', '2024-06-02'),
(267, 'T1', '2024-06-01', '2024-06-02'),
(268, 'EU', '2024-06-01', '2024-06-02'),
(269, 'c7', '2024-06-01', '2024-06-02'),
(270, '4H', '2024-06-01', '2024-06-02'),
(271, '44', '2024-06-01', '2024-06-02'),
(272, 'hF', '2024-06-01', '2024-06-02'),
(273, 'rz', '2024-06-01', '2024-06-02'),
(274, '0Y', '2024-06-01', '2024-06-02'),
(275, '5o', '2024-06-01', '2024-06-02'),
(276, '3p', '2024-06-01', '2024-06-02'),
(277, '8W', '2024-06-01', '2024-06-02'),
(278, 'GD', '2024-06-01', '2024-06-02'),
(279, 'Yt', '2024-06-01', '2024-06-02'),
(280, '6W', '2024-06-01', '2024-06-02'),
(281, 'a1', '2024-06-01', '2024-06-02'),
(282, 'Lc', '2024-06-01', '2024-06-02'),
(283, 'o9', '2024-06-01', '2024-06-02'),
(284, 'b6', '2024-06-01', '2024-06-02'),
(285, '76', '2024-06-01', '2024-06-02'),
(286, 'Lm', '2024-06-01', '2024-06-02'),
(287, '14', '2024-06-01', '2024-06-02'),
(288, 'eF', '2021-06-24', '2021-07-27'),
(289, 'ZP', '2024-06-19', '2024-06-18');

-- --------------------------------------------------------

--
-- Table structure for table `site_status_tbl`
--

CREATE TABLE `site_status_tbl` (
  `site_status_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `date_updated` date DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `adopting_entity` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `site_status_tbl`
--

INSERT INTO `site_status_tbl` (`site_status_id`, `unique_code`, `date_updated`, `status`, `adopting_entity`) VALUES
(1, '22-174000-0004-0020', '2023-11-23', 'done', 'tenure'),
(2, '22-174000-0001-0012', '2023-11-23', 'Done', 'PO'),
(3, '22-174000-0002-0011', '2023-11-23', 'Nice', 'Po'),
(4, '11-174001-0001-0034', '2023-11-24', 'n/a', 'none'),
(5, '11-174001-0033-0001', '2023-11-24', 'n/a', 'n/a'),
(6, '11-174001-0012-0003', '2023-11-24', 'n/a', 'none'),
(7, '11-174001-0013-0003', '2023-11-24', 'n/a', 'none'),
(8, '11-174001-0014-0004', '2023-11-24', 'n/a', 'none'),
(9, '11-174001-0017-0009', '2023-11-24', 'Tenure', 'CBFM'),
(10, '11-174001-0018-0003', '2023-11-24', 'n/a', 'none'),
(11, '11-174001-0024-0003', '2023-11-24', 'n/a', 'none'),
(12, '11-174001-0025-0003', '2023-11-24', 'n/a', 'none'),
(13, '11-174001-0026-0004', '2023-11-24', 'n/a', 'none'),
(14, '11-174001-0027-0003', '2023-11-24', 'n/a', 'none'),
(15, '11-174001-0028-0003', '2023-11-24', 'n/a', 'none'),
(16, '11-174001-0029-0003', '2023-11-24', 'n/a', 'none'),
(17, '11-174001-0030-0003', '2023-11-24', 'n/a', 'none'),
(18, '11-174001-0031-0003', '2023-11-24', 'n/a', 'none'),
(20, '11-174001-0034-0003', '2023-11-29', 'n/a', 'none'),
(21, '11-174001-0035-0003', '2023-11-29', 'n/a', 'none'),
(23, '11-174001-0037-0003', '2023-11-29', 'n/a', 'none'),
(24, '11-174001-0038-0003', '2023-11-29', 'n/a', 'none'),
(25, '11-174001-0039-0003', '2023-11-29', 'n/a', 'none'),
(26, '11-174001-0040-0002', '2023-11-29', 'n/a', 'none'),
(27, '11-174001-0041-0003', '2023-11-29', 'n/a', 'none'),
(28, '11-174001-0042-0003', '2023-11-29', 'n/a', 'none'),
(29, '11-174001-0006-0003', '2023-11-29', 'n/a', 'none'),
(30, '11-174001-0002-0008', '2023-11-29', 'Tenured', 'CBFM'),
(31, '11-174001-0003-0002', '2023-11-29', 'n/a', 'none'),
(32, '11-174001-0004-0012', '2023-11-29', 'n/a', 'none'),
(33, '11-174001-0005-0007', '2023-11-29', 'n/a', 'none'),
(34, '11-174001-0043-0003', '2023-11-29', 'n/a', 'none'),
(35, '11-174001-0007-0001', '2023-11-29', 'n/a', 'none'),
(36, '11-174001-0008-0002', '2023-11-29', 'n/a', 'none'),
(39, '11-174001-0010-0040', '2023-11-29', 'n/a', 'none'),
(40, '11-174001-0015-0018', '2023-11-29', 'n/a', 'none'),
(41, '11-174001-0020-0010', '2023-11-29', 'n/a', 'none'),
(42, '11-174001-0021-0012', '2023-11-29', 'n/a', 'none'),
(43, '11-174001-0022-0005', '2023-11-29', 'n/a', 'none'),
(44, '11-174001-0023-0006', '2023-11-29', 'n/a', 'none'),
(45, '11-174001-0032-0005', '2023-11-29', 'n/a', 'none'),
(46, '11-174001-0044-0003', '2023-11-29', 'n/a', 'none'),
(47, '12-174001-0001-0014', '2023-11-29', 'n/a', 'none'),
(48, '12-174001-0002-0001', '2023-11-29', 'Tenured', 'CBFM'),
(49, '12-174001-0003-0007', '2023-11-29', 'Tenured', 'CBFM'),
(50, '12-174001-0004-0003', '2023-11-29', 'Tenured', 'CBFM'),
(51, '12-174001-0005-0002', '2023-11-29', 'Tenured', 'CBFM'),
(52, '12-174001-0006-0001', '2023-11-29', 'Tenured', 'CBFM'),
(53, '12-174001-0007-0004', '2023-11-29', 'Tenured', 'CBFM'),
(54, '12-174001-0008-0000', '2023-11-29', 'Tenured', 'CBFM'),
(55, '12-174001-0009-0001', '2023-11-29', 'Tenured', 'CBFM'),
(56, '12-174001-0010-0000', '2023-11-29', 'Tenured', 'CBFM'),
(57, '12-174001-0011-0001', '2023-11-29', 'Tenured', 'CBFM'),
(58, '12-174001-0013-0001', '2023-11-29', 'Tenured', 'CBFM'),
(59, '12-174001-0014-0001', '2023-11-29', 'Tenured', 'CBFM'),
(60, '12-174001-0015-0002', '2023-11-29', 'Tenured', 'CBFM'),
(61, '12-174001-0016-0001', '2023-11-29', 'Tenured', 'CBFM'),
(62, '12-174001-0017-0001', '2023-11-29', 'Tenured', 'CBFM'),
(63, '12-174001-0018-0001', '2023-11-29', 'Tenured', 'CBFM'),
(64, '12-174001-0019-0000', '2023-11-29', 'Tenured', 'CBFM'),
(65, '12-174001-0022-0004', '2023-11-29', 'Tenured', 'CBFM'),
(66, '12-174001-0023-0001', '2023-11-29', 'Tenured', 'CBFM'),
(67, '12-174001-0024-0000', '2023-11-29', 'Tenured', 'CBFM'),
(68, '12-174001-0027-0001', '2023-11-29', 'Tenured', 'CBFM'),
(69, '12-174001-0012-0050', '2023-11-30', 'Tenured', 'CBFM'),
(70, '12-174001-0020-0045', '2023-11-30', 'n/a', 'none'),
(71, '12-174001-0021-0027', '2023-11-30', 'n/a', 'none'),
(72, '12-174001-0025-0011', '2023-11-30', 'n/a', 'none'),
(73, '12-174001-0026-0031', '2023-11-30', 'n/a', 'none'),
(74, '12-174001-0029-0020', '2023-11-30', 'n/a', 'none'),
(75, '12-174001-0028-0011', '2023-11-30', 'n/a', 'none'),
(76, '12-174001-0030-0003', '2023-11-30', 'n/a', 'none'),
(77, '12-174001-0031-0003', '2023-11-30', 'n/a', 'none'),
(78, '12-174001-0048-0002', '2023-11-30', 'n/a', 'none'),
(79, '13-174001-0005-0004', '2023-11-30', 'n/a', 'none'),
(80, '13-174001-0016-0018', '2023-11-30', 'n/a', 'none'),
(81, '13-174001-0008-0006', '2023-11-30', 'n/a', 'none'),
(82, '13-174001-0009-0006', '2023-11-30', 'n/a', 'none'),
(83, '13-174001-0012-0005', '2023-11-30', 'n/a', 'none'),
(84, '13-174001-0014-0027', '2023-11-30', 'n/a', 'none'),
(85, '13-174001-0015-0015', '2023-11-30', 'n/a', 'none'),
(86, '13-174001-0017-0010', '2023-11-30', 'n/a', 'none'),
(87, '11-174001-0011-0030', '2023-12-05', 'n/a', 'none'),
(88, '12-174001-0033-0004', '2023-12-05', 'n/a', 'none'),
(89, '12-174001-0034-0006', '2023-12-05', 'n/a', 'none'),
(90, '12-174001-0036-0005', '2023-12-05', 'n/a', 'none'),
(91, '12-174001-0037-0003', '2023-12-05', 'n/a', 'none'),
(92, '12-174001-0039-0005', '2023-12-05', 'n/a', 'none'),
(93, '12-174001-0040-0007', '2023-12-05', 'n/a', 'none'),
(94, '12-174001-0041-0007', '2023-12-05', 'n/a', 'none'),
(95, '12-174001-0042-0001', '2023-12-05', 'n/a', 'none'),
(96, '12-174001-0043-0003', '2023-12-05', 'n/a', 'none'),
(97, '12-174001-0044-0005', '2023-12-05', 'n/a', 'none'),
(98, '12-174001-0045-0002', '2023-12-05', 'n/a', 'none'),
(99, '12-174001-0046-0002', '2023-12-05', 'n/a', 'none'),
(100, '12-174001-0047-0005', '2023-12-05', 'n/a', 'none'),
(101, '13-174001-0018-0058', '2023-12-06', 'n/a', 'none'),
(102, '13-174001-0019-0029', '2023-12-06', 'Tenured', 'CBFM'),
(103, '13-174001-0020-0034', '2023-12-06', 'n/a', 'none'),
(104, '13-174001-0021-0005', '2023-12-06', 'n/a', 'none'),
(105, '13-174001-0026-0038', '2023-12-06', 'n/a', 'none'),
(106, '13-174001-0027-0030', '2023-12-06', 'n/a', 'none'),
(107, '13-174001-0024-0024', '2023-12-06', 'n/a', 'none'),
(108, '13-174001-0035-0031', '2023-12-06', 'Tenured', 'ISF'),
(109, '13-174001-0038-0006', '2023-12-06', 'Tenured', 'ISF'),
(110, '13-174001-0039-0004', '2023-12-06', 'Tenured', 'ISF'),
(111, '13-174001-0040-0005', '2023-12-06', 'Tenured', 'ISF'),
(112, '13-174001-0041-0031', '2023-12-06', 'Tenured', 'ISF'),
(113, '13-174001-0042-0044', '2023-12-06', 'n/a', 'none'),
(114, '13-174001-0031-0022', '2023-12-06', 'n/a', 'none'),
(115, '13-174001-0046-0009', '2023-12-06', 'n/a', 'none'),
(116, '13-174001-0048-0005', '2023-12-06', 'n/a', 'none'),
(117, '13-174001-0049-0002', '2023-12-06', 'n/a', 'none'),
(118, '13-174001-0050-0005', '2023-12-06', 'n/a', 'none'),
(119, '13-174001-0013-0009', '2023-12-06', 'n/a', 'none'),
(120, '13-174001-0052-0013', '2023-12-06', 'n/a', 'none'),
(121, '13-174001-0055-0091', '2023-12-06', 'Tenured', 'ISF'),
(122, '13-174001-0056-0033', '2023-12-06', 'n/a', 'none'),
(123, '13-174001-0006-0043', '2023-12-06', 'n/a', 'none'),
(124, '13-174001-0007-0002', '2023-12-06', 'n/a', 'none'),
(125, '13-174001-0045-0028', '2023-12-06', 'n/a', 'none'),
(126, '13-174001-0032-0015', '2023-12-06', 'n/a', 'none'),
(127, '13-174001-0003-0005', '2023-12-06', 'n/a', 'none'),
(128, '13-174001-0004-0014', '2023-12-06', 'n/a', 'none'),
(129, '13-174001-0010-0005', '2023-12-06', 'n/a', 'none'),
(130, '13-174001-0011-0004', '2023-12-06', 'n/a', 'none'),
(131, '13-174001-0001-0001', '2023-12-06', 'n/a', 'none'),
(132, '13-174001-0002-0001', '2023-12-06', 'n/a', 'none'),
(133, '13-174001-0023-0008', '2023-12-06', 'n/a', 'none'),
(134, '13-174001-0036-0005', '2023-12-06', 'n/a', 'none'),
(135, '13-174001-0030-0040', '2023-12-07', 'n/a', 'none'),
(136, '13-174001-0051-0003', '2023-12-07', 'n/a', 'none'),
(137, '13-174001-0053-0007', '2023-12-07', 'n/a', 'none'),
(138, '13-174001-0022-0007', '2023-12-07', 'n/a', 'none'),
(139, '13-174001-0022-0007', '2023-12-07', 'n/a', 'none'),
(140, '13-174001-0028-0001', '2023-12-07', 'n/a', 'none'),
(141, '13-174001-0054-0003', '2023-12-07', 'n/a', 'none'),
(142, '13-174001-0033-0003', '2023-12-07', 'n/a', 'none'),
(143, '13-174001-0034-0004', '2023-12-07', 'n/a', 'none'),
(144, '15-174001-0001-0005', '2023-12-07', 'n/a', 'none'),
(145, '15-174001-0002-0004', '2023-12-07', 'n/a', 'none'),
(146, '15-174001-0004-0004', '2024-01-11', 'n/a', 'none'),
(147, '15-174001-0005-0008', '2017-01-15', 'n/a', 'none'),
(148, '15-174001-0007-0020', '2017-01-15', 'n/a', 'none'),
(149, '15-174001-0010-0010', '2017-01-15', 'n/a', 'none'),
(150, '15-174001-0012-0004', '2024-01-12', 'n/a', 'none'),
(151, '15-174001-0019-0002', '2024-01-12', 'n/a', 'none'),
(152, '15-174001-0013-0008', '2024-01-12', 'n/a', 'none'),
(153, '15-174001-0014-0008', '2024-01-12', 'n/a', 'none'),
(154, '15-174001-0015-0015', '2024-01-12', 'n/a', 'none'),
(155, '15-174001-0016-0021', '2024-01-12', 'n/a', 'none'),
(156, '15-174001-0024-0004', '2024-01-12', 'n/a', 'none'),
(157, '15-174001-0017-0007', '2024-01-12', 'n/a', 'none'),
(158, '15-174001-0018-0005', '2024-01-12', 'n/a', 'none'),
(159, '15-174001-0020-0004', '2024-01-12', 'n/a', 'none'),
(160, '15-174001-0021-0003', '2024-01-12', 'n/a', 'none'),
(161, '15-174001-0022-0021', '2024-01-12', 'n/a', 'none'),
(162, '15-174001-0023-0005', '2024-01-12', 'n/a', 'none'),
(163, '15-174001-0025-0040', '2024-01-12', 'n/a', 'none'),
(164, '15-174001-0028-0002', '2024-01-12', 'n/a', 'none'),
(165, '15-174001-0029-0010', '2024-01-12', 'n/a', 'none'),
(166, '15-174001-0030-0005', '2024-01-12', 'n/a', 'none'),
(167, '15-174001-0031-0005', '2024-01-12', 'n/a', 'none'),
(168, '15-174001-0032-0002', '2024-01-12', 'n/a', 'none'),
(169, '15-174001-0033-0005', '2024-01-12', 'n/a', 'none'),
(170, '15-174001-0036-0002', '2024-01-12', 'n/a', 'none'),
(171, '15-174001-0034-0010', '2024-01-12', 'n/a', 'none'),
(172, '15-174001-0035-0018', '2024-01-12', 'n/a', 'none'),
(173, '15-174001-0037-0002', '2024-01-12', 'n/a', 'none'),
(174, '15-174001-0038-0012', '2024-01-12', 'n/a', 'none'),
(176, '15-174001-0033-0001', '2024-01-15', 'n/a', 'none'),
(177, '15-174001-0034-0002', '2024-01-15', 'n/a', 'none'),
(178, '15-174001-0035-0002', '2024-01-15', 'n/a', 'none'),
(179, '15-174001-0038-0017', '2024-01-15', 'n/a', 'none'),
(180, '15-174001-0042-0006', '2024-01-15', 'n/a', 'none'),
(181, '15-174001-0056-0007', '2024-01-15', 'n/a', 'none'),
(182, '15-174001-0037-0009', '2024-01-15', 'n/a', 'none'),
(183, '15-174001-0043-0053', '2024-01-15', 'n/a', 'none'),
(185, '15-174001-0054-0002', '2024-01-15', 'n/a', 'none'),
(186, '15-174001-0051-0012', '2024-01-15', 'n/a', 'none'),
(187, '15-174001-0039-0010', '2024-01-15', 'n/a', 'none'),
(188, '15-174001-0040-0010', '2024-01-15', 'n/a', 'none'),
(189, '15-174001-0041-0010', '2024-01-15', 'n/a', 'none'),
(190, '15-174001-0048-0006', '2024-01-15', 'n/a', 'none'),
(191, '15-174001-0045-0021', '2024-01-16', 'n/a', 'none'),
(192, '15-174001-0046-0024', '2024-01-16', 'n/a', 'none'),
(193, '16-174001-0001-0027', '2024-01-16', 'n/a', 'none'),
(194, '17-174001-0001-0025', '2024-01-16', 'tenured', 'ISF'),
(195, '17-174001-0002-0016', '2024-01-16', 'tenured', 'ISF'),
(196, '17-174001-0003-0049', '2024-01-16', 'tenured', 'ISF'),
(197, '18-174000-0004-0010', '2024-01-16', 'n/a', 'none'),
(198, '18-174000-0009-0030', '2024-01-16', 'n/a', 'none'),
(199, '18-174000-0027-0040', '2024-01-16', 'n/a', 'none'),
(200, '18-174000-0268-0002', '2024-01-16', 'n/a', 'none'),
(201, '18-174000-0267-0001', '2024-01-16', 'n/a', 'none'),
(202, '18-174000-0266-0001', '2024-01-16', 'n/a', 'none'),
(203, '18-174000-0307-0013', '2024-01-23', 'n/a', 'none'),
(204, '18-174000-0001-0006', '2024-01-23', 'n/a', 'none'),
(205, '18-174000-0002-0004', '2024-01-23', 'n/a', 'none'),
(206, '11-174001-0016-0041', '2024-01-23', 'n/a', 'none'),
(207, '20-174000-0008-0001', '2024-01-24', 'n/a', 'none'),
(208, '20-174000-0009-0006', '2024-01-24', 'n/a', 'none'),
(209, '20-174000-0012-0002', '2024-02-05', 'n/a', 'none'),
(210, '20-174000-0013-0004', '2024-02-05', 'n/a', 'none'),
(211, '11-174001-0019-0009', '2024-03-21', 'n/a', 'none'),
(212, '12-174001-0035-0013', '2024-03-22', 'n/a', 'none'),
(213, '12-174001-0049-0001', '2024-03-22', 'n/a', 'none'),
(214, '13-174001-0025-0025', '2024-03-22', 'n/a', 'none'),
(215, '13-174001-0043-0094', '2024-03-22', 'tenured', 'ISF'),
(216, '13-174001-0044-0030', '2024-03-22', 'n/a', 'none'),
(217, '13-174001-0037-0017', '2024-03-22', 'n/a', 'none'),
(218, '11-174001-0036-0002', '2024-04-26', 'n/a', 'none'),
(219, '15-174001-0006-0001', '2024-05-03', 'n/a', 'none'),
(220, '15-174001-0008-0003', '2024-05-03', 'n/a', 'none'),
(221, '15-174001-0009-0002', '2024-05-03', 'n/a', 'none'),
(222, '15-174001-0026-0006', '2024-05-03', 'n/a', 'none'),
(223, '15-174001-0036-0003', '2024-05-03', 'n/a', 'none'),
(224, '18-174000-0309-0013', '2024-05-03', 'n/a', 'none'),
(225, '18-174000-0310-0004', '2024-05-06', 'n/a', 'none'),
(226, '18-174000-0011-0007', '2024-05-06', 'n/a', 'none'),
(227, '18-174000-0014-0001', '2024-05-06', 'n/a', 'none'),
(228, '18-174000-0035-0000', '2024-05-06', 'n/a', 'none'),
(229, '18-174000-0029-0001', '2024-05-06', 'n/a', 'none'),
(230, '18-174000-0018-0001', '2024-05-06', 'n/a', 'none'),
(231, '18-174000-0020-0004', '2024-05-06', 'n/a', 'none'),
(232, '18-174000-0024-0000', '2024-05-06', 'n/a', 'none'),
(233, '18-174000-0028-0001', '2024-05-06', 'n/a', 'none'),
(234, '18-174000-0026-0001', '2024-05-06', 'n/a', 'none'),
(235, '18-174000-0017-0001', '2024-05-06', 'n/a', 'none'),
(236, '18-174000-0030-0000', '2024-05-06', 'n/a', 'none'),
(237, '18-174000-0032-0001', '2024-05-06', 'n/a', 'none'),
(238, '18-174000-0033-0000', '2024-05-06', 'n/a', 'none'),
(239, '18-174000-0034-0003', '2024-05-06', 'n/a', 'none'),
(240, '18-174000-0036-0000', '2024-05-06', 'n/a', 'none'),
(241, '18-174000-0037-0002', '2024-05-06', 'n/a', 'none'),
(242, '18-174000-0038-0001', '2024-05-06', 'n/a', 'none'),
(243, '18-174000-0039-0008', '2024-05-06', 'n/a', 'none'),
(244, '18-174000-0010-0005', '2024-05-06', 'n/a', 'none'),
(245, '18-174000-0022-0028', '2024-05-06', 'n/a', 'none'),
(246, '18-174000-0023-0007', '2024-05-06', 'n/a', 'none'),
(247, '18-174000-0015-0000', '2024-05-07', 'n/a', 'none'),
(248, '20-174000-0010-0007', '2024-05-07', 'n/a', 'none'),
(249, '20-174000-0011-0007', '2024-05-07', 'n/a', 'none'),
(250, '20-174000-0002-0007', '2024-05-07', 'n/a', 'none'),
(251, '20-174000-0003-0007', '2024-05-07', 'n/a', 'none'),
(252, '20-174000-0004-0006', '2024-05-07', 'n/a', 'none'),
(253, '21-174000-0001-0020/ 21-174000-0002-0050', '2024-05-07', 'n/a', 'none'),
(254, '15-174001-0012-0000', '2024-05-15', 'n/a', 'none'),
(256, '11-174001-0009-0030', '2024-06-18', 'n/a', 'none'),
(257, '15-174001-0003-0003', '2024-06-19', 'n/a', 'none'),
(258, '15-174001-0044-0006', '2024-06-19', 'n/a', 'none');

-- --------------------------------------------------------

--
-- Table structure for table `species_tbl`
--

CREATE TABLE `species_tbl` (
  `species_id` int(11) NOT NULL,
  `species_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `species_tbl`
--

INSERT INTO `species_tbl` (`species_id`, `species_name`) VALUES
(1, 'Narra'),
(2, 'Batino'),
(3, 'Makaasim'),
(4, 'Mulawin'),
(5, 'Wisak'),
(6, 'Avocado'),
(7, 'Cacao'),
(8, 'Caimito'),
(9, 'Coffee'),
(10, 'Guyabano'),
(11, 'Langka'),
(12, 'Lanzones'),
(13, 'Mango'),
(14, 'Rambutan'),
(15, 'Santol'),
(16, 'Lucban'),
(17, 'Kalamansi'),
(18, 'Makopa'),
(19, 'Dalanghita'),
(20, 'Acacia'),
(21, 'Pomelo'),
(22, 'Robusta Coffee'),
(23, 'Kamansi'),
(24, 'Star Apple'),
(25, 'Dalandan'),
(26, 'Guyong - guyong'),
(27, 'Lauan'),
(30, 'Bakauan'),
(31, 'Bamboo'),
(32, 'Pipisik'),
(33, 'Kawayang Tinik'),
(34, 'Talisay'),
(35, 'Nipa'),
(36, 'Saging');

-- --------------------------------------------------------

--
-- Table structure for table `status_registry`
--

CREATE TABLE `status_registry` (
  `registry_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `amount_cip` decimal(10,0) DEFAULT NULL,
  `amount_under` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `status_registry`
--

INSERT INTO `status_registry` (`registry_id`, `unique_code`, `amount_cip`, `amount_under`) VALUES
(1, '22-174000-0001-0012', 1000, 1000),
(3, '11-174001-0033-0001', 0, 7569),
(4, '11-174001-0001-0034', 0, 0),
(5, '11-174001-0012-0003', 0, 7569),
(6, '11-174001-0013-0003', 0, 7569),
(7, '11-174001-0014-0004', 0, 10092),
(8, '11-174001-0017-0009', 0, 23607),
(9, '11-174001-0018-0003', 0, 7569),
(10, '11-174001-0024-0003', 0, 7569),
(11, '11-174001-0025-0003', 0, 7569),
(12, '11-174001-0026-0004', 0, 0),
(13, '11-174001-0027-0003', 0, 7569),
(14, '11-174001-0028-0003', 0, 0),
(15, '11-174001-0029-0003', 0, 0),
(16, '11-174001-0030-0003', 0, 7569),
(17, '11-174001-0031-0003', 0, 7569),
(19, '11-174001-0034-0003', 0, 7569),
(20, '11-174001-0035-0003', 0, 0),
(22, '11-174001-0037-0003', 0, 7569),
(23, '11-174001-0038-0003', 0, 0),
(24, '11-174001-0039-0003', 0, 0),
(25, '11-174001-0040-0002', 0, 7569),
(26, '11-174001-0041-0003', 0, 0),
(27, '11-174001-0042-0003', 0, 7569),
(28, '11-174001-0006-0003', 0, 0),
(29, '11-174001-0002-0008', 0, 6400),
(30, '11-174001-0003-0002', 0, 0),
(31, '11-174001-0004-0012', 0, 0),
(32, '11-174001-0005-0007', 0, 0),
(34, '11-174001-0043-0003', 0, 0),
(35, '11-174001-0007-0001', 0, 0),
(36, '11-174001-0008-0002', 0, 0),
(40, '11-174001-0010-0040', 0, 32000),
(41, '11-174001-0015-0018', 0, 0),
(42, '11-174001-0020-0010', 0, 25230),
(43, '11-174001-0021-0012', 0, 76429),
(44, '11-174001-0022-0005', 0, 0),
(45, '11-174001-0023-0006', 0, 0),
(46, '11-174001-0032-0005', 0, 0),
(47, '11-174001-0044-0003', 0, 0),
(48, '12-174001-0001-0014', 0, 28000),
(49, '12-174001-0002-0001', 0, 148500),
(50, '12-174001-0003-0007', 0, 0),
(51, '12-174001-0004-0003', 0, 0),
(52, '12-174001-0005-0002', 0, 0),
(53, '12-174001-0006-0001', 0, 0),
(54, '12-174001-0007-0004', 0, 0),
(55, '12-174001-0008-0000', 0, 0),
(56, '12-174001-0009-0001', 0, 0),
(57, '12-174001-0010-0000', 0, 0),
(58, '12-174001-0011-0001', 0, 0),
(59, '12-174001-0013-0001', 0, 0),
(60, '12-174001-0014-0001', 0, 0),
(61, '12-174001-0015-0002', 0, 0),
(62, '12-174001-0016-0001', 0, 0),
(63, '12-174001-0017-0001', 0, 0),
(64, '12-174001-0018-0001', 0, 0),
(65, '12-174001-0019-0000', 0, 0),
(66, '12-174001-0022-0004', 0, 0),
(67, '12-174001-0023-0001', 0, 0),
(68, '12-174001-0024-0000', 0, 0),
(69, '12-174001-0027-0001', 0, 0),
(70, '12-174001-0012-0050', 0, 225000),
(71, '12-174001-0020-0045', 0, 324000),
(72, '12-174001-0021-0027', 0, 0),
(73, '12-174001-0025-0011', 0, 84000),
(74, '12-174001-0026-0031', 0, 0),
(75, '12-174001-0029-0020', 0, 90000),
(76, '12-174001-0028-0011', 0, 45000),
(77, '12-174001-0030-0003', 0, 0),
(78, '12-174001-0031-0003', 0, 16000),
(79, '12-174001-0032-0005', 0, 0),
(80, '12-174001-0038-0001', 0, 0),
(81, '13-174001-0005-0004', 0, 34840),
(82, '13-174001-0016-0018', 0, 209040),
(83, '13-174001-0008-0006', 0, 0),
(84, '13-174001-0009-0006', 0, 52260),
(85, '13-174001-0012-0005', 0, 20000),
(86, '13-174001-0014-0027', 0, 214650),
(87, '13-174001-0015-0015', 0, 60000),
(88, '13-174001-0017-0010', 0, 87100),
(89, '11-174001-0011-0030', 0, 48000),
(90, '12-174001-0033-0004', 6000, 8000),
(91, '12-174001-0034-0006', 0, 14000),
(92, '12-174001-0036-0005', 0, 10000),
(93, '12-174001-0037-0003', 0, 0),
(94, '12-174001-0039-0005', 7500, 10000),
(95, '12-174001-0040-0007', 9000, 12000),
(96, '12-174001-0041-0007', 0, 0),
(97, '12-174001-0042-0001', 1500, 2000),
(98, '12-174001-0043-0003', 0, 6000),
(99, '12-174001-0044-0005', 0, 10000),
(100, '12-174001-0045-0002', 3000, 4000),
(101, '12-174001-0046-0002', 0, 4000),
(102, '12-174001-0047-0005', 0, 0),
(103, '13-174001-0018-0058', 0, 505180),
(104, '13-174001-0019-0029', 0, 203000),
(105, '13-174001-0020-0034', 0, 296140),
(106, '13-174001-0021-0005', 0, 44500),
(107, '13-174001-0026-0038', 0, 330980),
(108, '13-174001-0027-0030', 0, 470340),
(109, '13-174001-0024-0024', 0, 0),
(110, '13-174001-0035-0031', 0, 270010),
(111, '13-174001-0038-0006', 0, 318000),
(112, '13-174001-0039-0004', 0, 0),
(113, '13-174001-0040-0005', 0, 0),
(114, '13-174001-0041-0031', 0, 0),
(115, '13-174001-0042-0044', 0, 524700),
(116, '13-174001-0031-0022', 0, 0),
(117, '13-174001-0046-0009', 0, 101075),
(118, '13-174001-0048-0005', 0, 70000),
(119, '13-174001-0049-0002', 0, 0),
(120, '13-174001-0013-0009', 0, 112000),
(121, '13-174001-0055-0091', 0, 723450),
(122, '13-174001-0056-0033', 0, 460350),
(123, '13-174001-0006-0043', 0, 447000),
(124, '13-174001-0007-0002', 0, 894000),
(125, '13-174001-0032-0015', 0, 223500),
(126, '13-174001-0003-0005', 0, 165490),
(127, '13-174001-0023-0008', 0, 87100),
(128, '13-174001-0036-0005', 0, 165490),
(129, '13-174001-0030-0040', 0, 780000),
(130, '15-174001-0001-0005', 12000, 65300),
(131, '15-174001-0007-0020', 36000, 0),
(132, '15-174001-0010-0010', 44550, 0),
(133, '15-174001-0012-0004', 27000, 0),
(134, '15-174001-0013-0008', 0, 178200),
(135, '15-174001-0017-0007', 39600, 0),
(136, '15-174001-0020-0004', 31500, 0),
(137, '15-174001-0022-0021', 101250, 0),
(138, '15-174001-0025-0040', 60000, 0),
(139, '15-174001-0027-0015', 49500, 0),
(140, '15-174001-0028-0002', 50625, 0),
(141, '15-174001-0030-0005', 90000, 0),
(142, '15-174001-0034-0010', 92400, 0),
(143, '15-174001-0037-0002', 85800, 0),
(144, '15-174001-0033-0001', 4050, 0),
(145, '15-174001-0034-0002', 3600, 0),
(146, '15-174001-0035-0002', 3600, 0),
(147, '15-174001-0038-0017', 216750, 0),
(148, '15-174001-0042-0006', 10800, 0),
(149, '15-174001-0056-0007', 31500, 0),
(150, '15-174001-0043-0053', 171600, 0),
(152, '15-174001-0054-0002', 89100, 59400),
(153, '15-174001-0039-0010', 99000, 364500),
(154, '15-174001-0048-0006', 117000, 39000),
(155, '16-174001-0001-0027', 358900, 514800),
(156, '17-174001-0001-0025', 1254578, 0),
(157, '17-174001-0003-0049', 1402404, 0),
(158, '18-174000-0009-0030', 1136050, 0),
(159, '18-174000-0027-0040', 1236450, 0),
(160, '18-174000-0268-0002', 186937, 0),
(161, '18-174000-0307-0013', 888125, 0),
(162, '11-174001-0016-0041', 0, 0),
(163, '20-174000-0001-0012', 303200, 0),
(164, '20-174000-0008-0001', 600000, 0),
(165, '11-174001-0019-0009', 0, 22707),
(166, '12-174001-0035-0013', 0, 0),
(167, '12-174001-0049-0001', 0, 0),
(168, '13-174001-0025-0025', 0, 142750),
(169, '13-174001-0043-0094', 0, 818740),
(170, '11-174001-0036-0002', 0, 7569),
(171, '15-174001-0006-0001', 20700, 110256),
(172, '15-174001-0036-0003', 19800, 0),
(173, '18-174000-0309-0013', 776190, 0),
(174, '18-174000-0310-0004', 736042, 0),
(175, '18-174000-0310-0004', 736042, 0),
(176, '21-174000-0001-0020/ 21-174000-0002-0050', 1823000, 0),
(178, '11-174001-0009-0030', 0, 151380),
(179, '15-174001-0003-0003', 49509, 192488),
(180, '15-174001-0044-0006', 10800, 0);

-- --------------------------------------------------------

--
-- Table structure for table `survival_rate_year1`
--

CREATE TABLE `survival_rate_year1` (
  `survival_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `commodity` varchar(100) NOT NULL,
  `area_planted` decimal(10,0) NOT NULL,
  `no_seedling_planted` int(11) NOT NULL,
  `no_seedling_survive` int(11) NOT NULL,
  `survival_rate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `survival_rate_year1`
--

INSERT INTO `survival_rate_year1` (`survival_id`, `unique_code`, `commodity`, `area_planted`, `no_seedling_planted`, `no_seedling_survive`, `survival_rate`) VALUES
(5, '22-174000-0001-0012', 'Fruit Trees', 12, 6000, 5160, 86),
(6, '11-174001-0001-0034', 'Timber', 34, 17000, 17000, 100),
(14, '22-174000-0003-0032', 'Indigenous Trees', 24, 15000, 12900, 86),
(15, '22-174000-0003-0032', 'Fruit Trees', 8, 4000, 3440, 86),
(16, '22-174000-0004-0020', 'Indigenous Trees', 13, 8125, 6988, 86),
(17, '22-174000-0004-0020', 'Fruit Trees', 7, 3500, 3010, 86),
(18, '22-174000-0002-0011', 'Fruit Trees', 11, 5500, 4730, 86),
(20, '21-174000-0001-0020/ 21-174000-0002-0050', 'Indigenous Trees', 70, 21875, 21875, 100),
(21, '21-174000-0001-0020/ 21-174000-0002-0050', 'Fruit Trees', 70, 17500, 17500, 100),
(22, '21-174000-0003-0010', 'Bamboo', 10, 2040, 1775, 87);

-- --------------------------------------------------------

--
-- Table structure for table `survival_rate_year2`
--

CREATE TABLE `survival_rate_year2` (
  `survival_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `quarter_code` varchar(20) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `survival_rate` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `survival_rate_year2`
--

INSERT INTO `survival_rate_year2` (`survival_id`, `unique_code`, `quarter_code`, `filter_code`, `survival_rate`) VALUES
(7, '22-174000-0001-0012', 'EG5W', 'qrt12', 86),
(11, '22-174000-0001-0012', 'xOYl', 'qrt3', 86),
(13, '22-174000-0004-0020', '0fad', 'qrt3', 86),
(14, '22-174000-0005-0024', '0Guy', 'qrt12', 86),
(15, '22-174000-0005-0024', 'lsIT', 'qrt3', 86),
(16, '22-174000-0002-0011', 'THHP', 'qrt3', 86),
(18, '21-174000-0001-0020/ 21-174000-0002-0050', 'eFBy', 'qrt4', 88),
(19, '22-174000-0004-0020', 'CPJI', 'qrt4', 86),
(20, '22-174000-0001-0012', 'Ct7Z', 'qrt4', 86),
(21, '22-174000-0003-0032', 'M4zz', 'qrt3', 86),
(22, '22-174000-0002-0011', 'LcxH', 'qrt4', 86),
(23, '22-174000-0005-0024', '5Lk9', 'qrt4', 86),
(63, '22-174000-0003-0032', 'FE1z', 'qrt4', 85),
(64, '22-174000-0002-0011', 'RfEZ', 'qrt12', 86);

-- --------------------------------------------------------

--
-- Table structure for table `survival_rate_year3`
--

CREATE TABLE `survival_rate_year3` (
  `survival_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `quarter_code` varchar(20) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `survival_rate` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `survival_rate_year3`
--

INSERT INTO `survival_rate_year3` (`survival_id`, `unique_code`, `quarter_code`, `filter_code`, `survival_rate`) VALUES
(1, '11-174001-0001-0034', NULL, NULL, 95.00),
(2, '11-174001-0033-0001', NULL, NULL, 76.00),
(3, '11-174001-0012-0003', NULL, NULL, 93.00),
(4, '11-174001-0013-0003', NULL, NULL, 88.00),
(5, '11-174001-0014-0004', NULL, NULL, 95.00),
(6, '11-174001-0017-0009', NULL, NULL, 80.00),
(7, '11-174001-0024-0003', NULL, NULL, 90.00),
(8, '11-174001-0025-0003', NULL, NULL, 88.00),
(9, '11-174001-0026-0004', NULL, NULL, 85.00),
(10, '11-174001-0027-0003', NULL, NULL, 80.00),
(11, '11-174001-0028-0003', NULL, NULL, 96.00),
(12, '11-174001-0029-0003', NULL, NULL, 75.00),
(13, '11-174001-0030-0003', NULL, NULL, 88.00),
(14, '11-174001-0031-0003', NULL, NULL, 92.00),
(16, '11-174001-0034-0003', NULL, NULL, 76.00),
(17, '11-174001-0035-0003', NULL, NULL, 85.00),
(19, '11-174001-0037-0003', NULL, NULL, 90.00),
(20, '11-174001-0038-0003', NULL, NULL, 75.00),
(21, '11-174001-0039-0003', NULL, NULL, 85.00),
(22, '11-174001-0040-0002', NULL, NULL, 80.00),
(23, '11-174001-0041-0003', NULL, NULL, 93.00),
(24, '11-174001-0042-0003', NULL, NULL, 88.00),
(25, '11-174001-0006-0003', NULL, NULL, 89.00),
(26, '11-174001-0002-0008', NULL, NULL, 90.00),
(27, '11-174001-0003-0002', NULL, NULL, 91.00),
(28, '11-174001-0004-0012', NULL, NULL, 86.00),
(29, '11-174001-0005-0007', NULL, NULL, 86.00),
(31, '11-174001-0043-0003', NULL, NULL, 89.00),
(32, '11-174001-0007-0001', NULL, NULL, 87.00),
(33, '11-174001-0008-0002', NULL, NULL, 88.00),
(36, '11-174001-0010-0040', NULL, NULL, 90.00),
(37, '11-174001-0015-0018', NULL, NULL, 85.00),
(38, '11-174001-0020-0010', NULL, NULL, 90.00),
(39, '11-174001-0021-0012', NULL, NULL, 87.00),
(40, '11-174001-0022-0005', NULL, NULL, 85.00),
(41, '11-174001-0023-0006', NULL, NULL, 80.00),
(42, '11-174001-0032-0005', NULL, NULL, 88.00),
(43, '11-174001-0044-0003', NULL, NULL, 0.00),
(44, '12-174001-0001-0014', NULL, NULL, 92.00),
(45, '12-174001-0002-0001', NULL, NULL, 87.00),
(46, '12-174001-0003-0007', NULL, NULL, 86.00),
(47, '12-174001-0004-0003', NULL, NULL, 86.00),
(48, '12-174001-0005-0002', NULL, NULL, 86.00),
(49, '12-174001-0006-0001', NULL, NULL, 87.00),
(50, '12-174001-0007-0004', NULL, NULL, 84.00),
(51, '12-174001-0008-0000', NULL, NULL, 86.00),
(52, '12-174001-0009-0001', NULL, NULL, 90.00),
(53, '12-174001-0010-0000', NULL, NULL, 100.00),
(54, '12-174001-0011-0001', NULL, NULL, 100.00),
(55, '12-174001-0013-0001', NULL, NULL, 87.00),
(56, '12-174001-0014-0001', NULL, NULL, 98.00),
(57, '12-174001-0015-0002', NULL, NULL, 86.00),
(58, '12-174001-0016-0001', NULL, NULL, 100.00),
(59, '12-174001-0017-0001', NULL, NULL, 90.00),
(60, '12-174001-0018-0001', NULL, NULL, 100.00),
(61, '12-174001-0019-0000', NULL, NULL, 100.00),
(62, '12-174001-0022-0004', NULL, NULL, 86.00),
(63, '12-174001-0023-0001', NULL, NULL, 88.00),
(64, '12-174001-0024-0000', NULL, NULL, 87.00),
(65, '12-174001-0027-0001', NULL, NULL, 85.00),
(66, '12-174001-0012-0050', NULL, NULL, 86.00),
(67, '12-174001-0020-0045', NULL, NULL, 85.00),
(68, '12-174001-0021-0027', NULL, NULL, 86.00),
(69, '12-174001-0025-0011', NULL, NULL, 87.00),
(70, '12-174001-0026-0031', NULL, NULL, 85.00),
(71, '12-174001-0029-0020', NULL, NULL, 86.00),
(72, '12-174001-0028-0011', NULL, NULL, 86.00),
(73, '12-174001-0030-0003', NULL, NULL, 73.00),
(74, '12-174001-0031-0003', NULL, NULL, 74.00),
(75, '12-174001-0032-0005', NULL, NULL, 71.00),
(76, '12-174001-0038-0001', NULL, NULL, 12.00),
(77, '12-174001-0048-0002', NULL, NULL, 87.00),
(78, '13-174001-0005-0004', NULL, NULL, 76.00),
(79, '13-174001-0016-0018', NULL, NULL, 83.00),
(80, '13-174001-0008-0006', NULL, NULL, 76.00),
(81, '13-174001-0009-0006', NULL, NULL, 88.00),
(82, '13-174001-0012-0005', NULL, NULL, 86.00),
(83, '13-174001-0014-0027', NULL, NULL, 85.50),
(84, '13-174001-0015-0015', NULL, NULL, 76.00),
(85, '13-174001-0017-0010', NULL, NULL, 80.00),
(86, '11-174001-0011-0030', NULL, NULL, 94.00),
(87, '12-174001-0033-0004', NULL, NULL, 72.00),
(88, '12-174001-0034-0006', NULL, NULL, 71.00),
(89, '12-174001-0036-0005', NULL, NULL, 48.00),
(90, '12-174001-0037-0003', NULL, NULL, 19.27),
(91, '12-174001-0039-0005', NULL, NULL, 35.00),
(92, '12-174001-0040-0007', NULL, NULL, 14.00),
(93, '12-174001-0042-0001', NULL, NULL, 71.00),
(94, '12-174001-0043-0003', NULL, NULL, 72.00),
(95, '12-174001-0044-0005', NULL, NULL, 72.00),
(96, '12-174001-0045-0002', NULL, NULL, 72.00),
(97, '12-174001-0046-0002', NULL, NULL, 71.00),
(98, '12-174001-0047-0005', NULL, NULL, 87.00),
(99, '13-174001-0018-0058', NULL, NULL, 82.99),
(100, '13-174001-0019-0029', NULL, NULL, 84.04),
(101, '13-174001-0020-0034', NULL, NULL, 90.00),
(102, '13-174001-0021-0005', NULL, NULL, 92.00),
(103, '13-174001-0026-0038', NULL, NULL, 85.05),
(104, '13-174001-0027-0030', NULL, NULL, 85.04),
(105, '13-174001-0024-0024', NULL, NULL, 85.04),
(106, '13-174001-0035-0031', NULL, NULL, 84.00),
(107, '13-174001-0038-0006', NULL, NULL, 83.00),
(108, '13-174001-0039-0004', NULL, NULL, 83.00),
(109, '13-174001-0040-0005', NULL, NULL, 83.00),
(110, '13-174001-0041-0031', NULL, NULL, 83.00),
(111, '13-174001-0042-0044', NULL, NULL, 84.25),
(112, '13-174001-0031-0022', NULL, NULL, 85.00),
(113, '13-174001-0046-0009', NULL, NULL, 81.03),
(114, '13-174001-0048-0005', NULL, NULL, 77.00),
(115, '13-174001-0013-0009', NULL, NULL, 87.00),
(116, '13-174001-0052-0013', NULL, NULL, 81.00),
(117, '13-174001-0055-0091', NULL, NULL, 89.00),
(118, '13-174001-0056-0033', NULL, NULL, 82.00),
(119, '13-174001-0006-0043', NULL, NULL, 80.00),
(120, '13-174001-0007-0002', NULL, NULL, 87.10),
(121, '13-174001-0045-0028', NULL, NULL, 89.50),
(122, '13-174001-0032-0015', NULL, NULL, 83.00),
(123, '13-174001-0003-0005', NULL, NULL, 80.00),
(124, '13-174001-0004-0014', NULL, NULL, 84.00),
(125, '13-174001-0010-0005', NULL, NULL, 78.00),
(126, '13-174001-0011-0004', NULL, NULL, 78.00),
(127, '13-174001-0001-0001', NULL, NULL, 74.00),
(128, '13-174001-0002-0001', NULL, NULL, 74.00),
(129, '13-174001-0023-0008', NULL, NULL, 75.00),
(130, '13-174001-0036-0005', NULL, NULL, 78.00),
(131, '13-174001-0030-0040', NULL, NULL, 80.00),
(132, '13-174001-0051-0003', NULL, NULL, 80.00),
(133, '13-174001-0053-0007', NULL, NULL, 81.00),
(134, '13-174001-0022-0007', NULL, NULL, 82.00),
(135, '13-174001-0028-0001', NULL, NULL, 78.40),
(136, '13-174001-0054-0003', NULL, NULL, 78.00),
(137, '13-174001-0033-0003', NULL, NULL, 77.00),
(138, '13-174001-0034-0004', NULL, NULL, 76.00),
(139, '15-174001-0001-0005', NULL, NULL, 28.00),
(140, '15-174001-0007-0020', NULL, NULL, 21.00),
(141, '15-174001-0010-0010', NULL, NULL, 54.00),
(142, '15-174001-0012-0004', NULL, NULL, 77.00),
(143, '15-174001-0019-0002', NULL, NULL, 77.00),
(144, '15-174001-0013-0008', NULL, NULL, 28.00),
(145, '15-174001-0017-0007', NULL, NULL, 22.00),
(146, '15-174001-0018-0005', NULL, NULL, 22.00),
(147, '15-174001-0020-0004', NULL, NULL, 45.73),
(148, '15-174001-0022-0021', NULL, NULL, 20.09),
(149, '15-174001-0025-0040', NULL, NULL, 31.12),
(150, '15-174001-0027-0015', NULL, NULL, 20.48),
(151, '15-174001-0028-0002', NULL, NULL, 20.40),
(152, '15-174001-0030-0005', NULL, NULL, 44.70),
(153, '15-174001-0034-0010', NULL, NULL, 75.82),
(154, '15-174001-0038-0012', NULL, NULL, 32.57),
(156, '15-174001-0033-0001', NULL, NULL, 27.00),
(157, '15-174001-0034-0002', NULL, NULL, 12.18),
(158, '15-174001-0035-0002', NULL, NULL, 21.00),
(159, '15-174001-0038-0017', NULL, NULL, 0.00),
(160, '15-174001-0042-0006', NULL, NULL, 0.00),
(161, '15-174001-0043-0053', NULL, NULL, 4.30),
(163, '15-174001-0054-0002', NULL, NULL, 36.33),
(164, '15-174001-0039-0010', NULL, NULL, 0.89),
(165, '15-174001-0040-0010', NULL, NULL, 3.61),
(166, '15-174001-0041-0010', NULL, NULL, 20.46),
(167, '15-174001-0048-0006', NULL, NULL, 0.07),
(168, '15-174001-0045-0021', NULL, NULL, 42.00),
(169, '15-174001-0046-0024', NULL, NULL, 3.08),
(170, '16-174001-0001-0027', NULL, NULL, 81.00),
(171, '17-174001-0001-0025', NULL, NULL, 30.02),
(172, '17-174001-0002-0016', NULL, NULL, 30.19),
(173, '17-174001-0003-0049', NULL, NULL, 30.50),
(174, '18-174000-0009-0030', NULL, NULL, 55.00),
(175, '18-174000-0027-0040', NULL, NULL, 21.26),
(176, '18-174000-0268-0002', NULL, NULL, 60.59),
(177, '18-174000-0267-0001', NULL, NULL, 0.34),
(178, '18-174000-0307-0013', NULL, NULL, 77.66),
(179, '11-174001-0016-0041', NULL, NULL, 80.00),
(183, '22-174000-0004-0020', NULL, NULL, 90.00),
(184, '22-174000-0004-0020', 'KeJQ6', 'qrt3', 95.00),
(185, '22-174000-0004-0020', 'P0jw9', 'qrt4', 82.00),
(186, '11-174001-0019-0009', NULL, NULL, 90.00),
(187, '12-174001-0035-0013', NULL, NULL, 75.00),
(188, '12-174001-0041-0007', NULL, NULL, 79.00),
(189, '12-174001-0049-0001', NULL, NULL, 87.00),
(190, '13-174001-0025-0025', NULL, NULL, 75.00),
(191, '13-174001-0043-0094', NULL, NULL, 85.81),
(192, '13-174001-0037-0017', NULL, NULL, 78.00),
(193, '11-174001-0018-0003', NULL, NULL, 88.00),
(194, '11-174001-0036-0002', NULL, NULL, 83.00),
(195, '15-174001-0006-0001', NULL, NULL, 61.00),
(196, '15-174001-0008-0003', NULL, NULL, 61.00),
(197, '15-174001-0026-0006', NULL, NULL, 60.89),
(198, '15-174001-0039-0006', NULL, NULL, 32.57),
(199, '15-174001-0041-0006', NULL, NULL, 32.57),
(200, '15-174001-0036-0003', NULL, NULL, 4.00),
(201, '18-174000-0309-0013', NULL, NULL, 67.15),
(202, '18-174000-0310-0004', NULL, NULL, 63.68),
(203, '15-174001-0012-0000', NULL, NULL, 15.00),
(217, '11-174001-0009-0030', NULL, NULL, 93.00),
(218, '15-174001-0003-0003', NULL, NULL, 32.00),
(219, '15-174001-0056-0007', NULL, NULL, 32.57),
(220, '15-174001-0044-0006', NULL, NULL, 15.06),
(221, '21-174000-0001-0020/ 21-174000-0002-0050', 'TySrN', 'qrt12', 86.00);

-- --------------------------------------------------------

--
-- Table structure for table `year1_disbursement`
--

CREATE TABLE `year1_disbursement` (
  `year1_id` int(11) NOT NULL,
  `unique_code` varchar(100) NOT NULL,
  `1st_payment` int(11) NOT NULL,
  `2nd_payment` int(11) DEFAULT NULL,
  `3rd_payment` int(11) DEFAULT NULL,
  `4th_payment` int(11) DEFAULT NULL,
  `totalcost` decimal(10,0) DEFAULT NULL,
  `retention_fund` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `year2nd_data_tbl`
--

CREATE TABLE `year2nd_data_tbl` (
  `year2_data_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `quarter_code` varchar(10) DEFAULT NULL,
  `type_code` varchar(20) DEFAULT NULL,
  `commodity` varchar(100) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `unit` int(11) DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `accomplished` int(11) DEFAULT NULL,
  `color` varchar(20) DEFAULT NULL,
  `planted` int(11) DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year2nd_data_tbl`
--

INSERT INTO `year2nd_data_tbl` (`year2_data_id`, `unique_code`, `filter_code`, `quarter_code`, `type_code`, `commodity`, `quantity`, `unit`, `total_cost`, `accomplished`, `color`, `planted`, `status`) VALUES
(1, '22-174000-0001-0012', 'qrt12', 'EG5W', 'rwrs', 'Fruit Trees', 1260, 8, 10080, 1260, 'deep pink', NULL, NULL),
(2, '22-174000-0001-0012', 'qrt12', 'EG5W', 'replant', 'Fruit Trees', 540, 10, 5400, NULL, NULL, 540, NULL),
(3, '22-174000-0001-0012', 'qrt12', 'EG5W', 'patrol', 'Fruit Trees', 510, 12, 6120, NULL, NULL, NULL, 'regulary conducted'),
(26, '22-174000-0001-0012', 'qrt3', 'xOYl', 'rwrs', 'Fruit Trees', 2100, 8, 16800, 2100, 'deep pink', NULL, NULL),
(27, '22-174000-0001-0012', 'qrt3', 'xOYl', 'replant', 'Fruit Trees', 900, 10, 9000, NULL, NULL, 900, NULL),
(28, '22-174000-0001-0012', 'qrt3', 'xOYl', 'patrol', 'Fruit Trees', 510, 12, 6120, NULL, NULL, NULL, 'Regularly conducted'),
(49, '22-174000-0004-0020', 'qrt3', '0fad', 'rwrs', 'Indigenous Trees', 4550, 8, 36403, 6510, 'deep pink', NULL, NULL),
(50, '22-174000-0004-0020', 'qrt3', '0fad', 'rwrs', 'Fruit Trees', 1960, 8, 15680, 6510, 'deep pink', NULL, NULL),
(51, '22-174000-0004-0020', 'qrt3', '0fad', 'replant', 'Indigenous Trees', 1950, 10, 19504, NULL, NULL, 2790, NULL),
(52, '22-174000-0004-0020', 'qrt3', '0fad', 'replant', 'Fruit Trees', 840, 10, 8400, NULL, NULL, 2790, NULL),
(53, '22-174000-0004-0020', 'qrt3', '0fad', 'patrol', 'Indigenous Trees', 801, 13, 10408, NULL, NULL, NULL, 'Conducted'),
(54, '22-174000-0004-0020', 'qrt3', '0fad', 'patrol', 'Fruit Trees', 801, 7, 5605, NULL, NULL, NULL, 'Conducted'),
(55, '22-174000-0002-0011', 'qrt12', 'RfEZ', 'rwrs', 'Fruit Trees', 1155, 8, 9240, 1155, 'deep pink', NULL, NULL),
(56, '22-174000-0002-0011', 'qrt12', 'RfEZ', 'replant', 'Fruit Trees', 495, 10, 4950, NULL, NULL, 495, NULL),
(57, '22-174000-0002-0011', 'qrt12', 'RfEZ', 'patrol', 'Fruit Trees', 510, 11, 5610, NULL, NULL, NULL, 'Regulary Conducted'),
(58, '22-174000-0005-0024', 'qrt12', '0Guy', 'rwrs', 'Indigenous Trees', 1706, 8, 13648, 2966, 'deep pink', NULL, NULL),
(59, '22-174000-0005-0024', 'qrt12', '0Guy', 'rwrs', 'Fruit Trees', 1260, 8, 10080, 2966, 'deep pink', NULL, NULL),
(60, '22-174000-0005-0024', 'qrt12', '0Guy', 'replant', 'Indigenous Trees', 731, 10, 7310, NULL, NULL, 1271, NULL),
(61, '22-174000-0005-0024', 'qrt12', '0Guy', 'replant', 'Fruit Trees', 540, 10, 5400, NULL, NULL, 1271, NULL),
(62, '22-174000-0005-0024', 'qrt12', '0Guy', 'patrol', 'Indigenous Trees', 343, 13, 4449, NULL, NULL, NULL, 'Regulary Conducted'),
(63, '22-174000-0005-0024', 'qrt12', '0Guy', 'patrol', 'Fruit Trees', 343, 12, 4106, NULL, NULL, NULL, 'Regulary Conducted'),
(64, '22-174000-0005-0024', 'qrt3', 'lsIT', 'rwrs', 'Indigenous Trees', 2844, 8, 22752, 4944, 'deep pink', NULL, NULL),
(65, '22-174000-0005-0024', 'qrt3', 'lsIT', 'rwrs', 'Fruit Trees', 2100, 8, 16800, 4944, 'deep pink', NULL, NULL),
(66, '22-174000-0005-0024', 'qrt3', 'lsIT', 'replant', 'Indigenous Trees', 1219, 10, 12190, NULL, NULL, 2119, NULL),
(67, '22-174000-0005-0024', 'qrt3', 'lsIT', 'replant', 'Fruit Trees', 900, 10, 9000, NULL, NULL, 2119, NULL),
(68, '22-174000-0005-0024', 'qrt3', 'lsIT', 'patrol', 'Indigenous Trees', 570, 13, 7414, NULL, NULL, NULL, 'continously'),
(69, '22-174000-0005-0024', 'qrt3', 'lsIT', 'patrol', 'Fruit Trees', 570, 12, 6844, NULL, NULL, NULL, 'continously'),
(70, '22-174000-0002-0011', 'qrt3', 'THHP', 'rwrs', 'Fruit Trees', 1925, 8, 15400, 1925, 'deep pink', NULL, NULL),
(71, '22-174000-0002-0011', 'qrt3', 'THHP', 'replant', 'Fruit Trees', 825, 10, 8250, NULL, NULL, 825, NULL),
(72, '22-174000-0002-0011', 'qrt3', 'THHP', 'patrol', 'Fruit Trees', 11, 11, 9350, NULL, NULL, NULL, 'continously'),
(73, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'rwrs', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(74, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'rwrs', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(75, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'replant', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(76, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'replant', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(77, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'patrol', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(78, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'o2cs', 'patrol', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(79, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'rwrs', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(80, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'rwrs', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(81, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'replant', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(82, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'replant', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(83, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'patrol', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(84, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt3', 'QSq9', 'patrol', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(85, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'rwrs', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(86, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'rwrs', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(87, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'replant', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(88, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'replant', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(89, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'patrol', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(90, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt4', 'eFBy', 'patrol', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, NULL),
(103, '22-174000-0004-0020', 'qrt4', 'CPJI', 'rwrs', 'Indigenous Trees', 1138, 8, 9101, 1628, 'Deep Pink', NULL, NULL),
(104, '22-174000-0004-0020', 'qrt4', 'CPJI', 'rwrs', 'Fruit Trees', 490, 8, 3920, 1628, 'Deep Pink', NULL, NULL),
(105, '22-174000-0004-0020', 'qrt4', 'CPJI', 'replant', 'Indigenous Trees', 488, 10, 4876, NULL, NULL, 698, NULL),
(106, '22-174000-0004-0020', 'qrt4', 'CPJI', 'replant', 'Fruit Trees', 210, 10, 2100, NULL, NULL, 698, NULL),
(107, '22-174000-0001-0012', 'qrt4', 'Ct7Z', 'rwrs', 'Fruit Trees', 4200, 8, 33600, 840, 'Deep Pink', NULL, NULL),
(108, '22-174000-0001-0012', 'qrt4', 'Ct7Z', 'replant', 'Fruit Trees', 1800, 10, 18000, NULL, NULL, 360, NULL),
(109, '22-174000-0003-0032', 'qrt3', 'M4zz', 'rwrs', 'Indigenous Trees', 8400, 8, 67200, 10640, 'Deep pink', NULL, NULL),
(110, '22-174000-0003-0032', 'qrt3', 'M4zz', 'rwrs', 'Fruit Trees', 2240, 8, 17920, 10640, 'Deep pink', NULL, NULL),
(111, '22-174000-0003-0032', 'qrt3', 'M4zz', 'replant', 'Indigenous Trees', 3600, 10, 36000, NULL, NULL, 4560, NULL),
(112, '22-174000-0003-0032', 'qrt3', 'M4zz', 'replant', 'Fruit Trees', 960, 10, 9600, NULL, NULL, 4560, NULL),
(113, '22-174000-0002-0011', 'qrt4', 'LcxH', 'rwrs', 'Fruit Trees', 770, 8, 6160, 770, 'Deep Pink', NULL, NULL),
(114, '22-174000-0002-0011', 'qrt4', 'LcxH', 'replant', 'Fruit Trees', 330, 10, 3300, NULL, NULL, 330, NULL),
(115, '22-174000-0002-0011', 'qrt4', 'LcxH', 'patrol', 'Fruit Trees', 340, 11, 3740, NULL, NULL, NULL, 'Conducted'),
(116, '22-174000-0005-0024', 'qrt4', '5Lk9', 'rwrs', 'Indigenous Trees', 5688, 8, 45504, 1978, 'Deep Pink', NULL, NULL),
(117, '22-174000-0005-0024', 'qrt4', '5Lk9', 'rwrs', 'Fruit Trees', 4200, 8, 33600, 1978, 'Deep Pink', NULL, NULL),
(118, '22-174000-0005-0024', 'qrt4', '5Lk9', 'replant', 'Indigenous Trees', 2438, 10, 24380, NULL, NULL, 848, NULL),
(119, '22-174000-0005-0024', 'qrt4', '5Lk9', 'replant', 'Fruit Trees', 1800, 10, 18000, NULL, NULL, 848, NULL),
(120, '22-174000-0005-0024', 'qrt4', '5Lk9', 'patrol', 'Indigenous Trees', 0, 0, 0, NULL, NULL, NULL, 'Conducted'),
(121, '22-174000-0005-0024', 'qrt4', '5Lk9', 'patrol', 'Fruit Trees', 0, 0, 0, NULL, NULL, NULL, 'Conducted'),
(156, '22-174000-0003-0032', 'qrt4', 'FE1z', 'rwrs', 'Indigenous Trees', 2100, 8, 16800, 2660, 'deep pink', NULL, NULL),
(157, '22-174000-0003-0032', 'qrt4', 'FE1z', 'rwrs', 'Fruit Trees', 560, 8, 4480, 2660, 'deep pink', NULL, NULL),
(158, '22-174000-0003-0032', 'qrt4', 'FE1z', 'replant', 'Indigenous Trees', 900, 10, 9000, NULL, NULL, 1140, NULL),
(159, '22-174000-0003-0032', 'qrt4', 'FE1z', 'replant', 'Fruit Trees', 240, 10, 2400, NULL, NULL, 1140, NULL),
(160, '22-174000-0003-0032', 'qrt4', 'FE1z', 'patrol', 'Indigenous Trees', 179, 24, 4290, NULL, NULL, NULL, 'Conducted'),
(161, '22-174000-0003-0032', 'qrt4', 'FE1z', 'patrol', 'Fruit Trees', 179, 8, 1430, NULL, NULL, NULL, 'Conducted'),
(162, '22-174000-0004-0020', 'qrt4', 'CPJI', 'patrol', 'Indigenous Trees', 200, 7, 2602, NULL, NULL, NULL, 'Conducted'),
(163, '22-174000-0004-0020', 'qrt4', 'CPJI', 'patrol', 'Fruit Trees', 200, 13, 1401, NULL, NULL, NULL, 'Conducted'),
(164, '22-174000-0001-0012', 'qrt4', 'Ct7Z', 'patrol', 'Fruit Trees', 12, 1700, 20400, NULL, NULL, NULL, 'Conducted'),
(165, '22-174000-0003-0032', 'qrt3', 'M4zz', 'patrol', 'Indigenous Trees', 715, 24, 17160, NULL, NULL, NULL, 'Continous Maintain'),
(166, '22-174000-0003-0032', 'qrt3', 'M4zz', 'patrol', 'Fruit Trees', 715, 8, 5720, NULL, NULL, NULL, 'Continous Maintain');

-- --------------------------------------------------------

--
-- Table structure for table `year2nd_inspection_date`
--

CREATE TABLE `year2nd_inspection_date` (
  `year2_id` int(11) NOT NULL,
  `quarter_code` varchar(10) NOT NULL,
  `date_request` date NOT NULL,
  `date_inspection` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year2nd_inspection_date`
--

INSERT INTO `year2nd_inspection_date` (`year2_id`, `quarter_code`, `date_request`, `date_inspection`) VALUES
(1, 'EG5W', '2023-06-19', '2023-06-20'),
(5, 'bHJ6', '2023-10-23', '2023-10-24'),
(6, 'RTS1', '2023-10-24', '2023-10-24'),
(7, '5R3o', '2023-11-05', '2023-11-06'),
(9, 'rQ7O', '2023-07-17', '2023-09-14'),
(10, 'xOYl', '2023-07-17', '2023-09-14'),
(15, '0fad', '2023-07-07', '2023-07-18'),
(16, 'RfEZ', '2023-06-08', '2023-06-20'),
(17, '0Guy', '2023-06-13', '2023-06-21'),
(18, 'lsIT', '2023-07-14', '2023-07-20'),
(19, 'THHP', '2023-07-19', '2023-08-02'),
(20, 'v33Q', '2022-06-21', '2022-08-01'),
(21, 'y0jl', '2022-06-21', '2022-08-01'),
(22, 'o2cs', '2022-06-30', '2022-08-01'),
(23, 'QSq9', '2022-11-15', '2022-11-16'),
(24, 'eFBy', '2023-02-02', '2023-02-03'),
(25, 'VnHMs', '2024-02-17', '2024-02-18'),
(26, 'CPJI', '2023-11-28', '2023-12-13'),
(27, 'Ct7Z', '2023-10-17', '2023-12-06'),
(28, 'M4zz', '2023-10-27', '2023-12-06'),
(29, 'LcxH', '2023-10-17', '2023-12-19'),
(30, '5Lk9', '2023-12-04', '2023-12-14'),
(31, 'ZAwy', '2024-05-12', '2024-05-16'),
(32, 'u3Uc', '2024-05-12', '2024-05-16'),
(33, '7KGp', '2024-05-21', '2024-05-20'),
(34, '3K50', '2024-05-19', '2024-05-20'),
(35, 'FE1z', '2023-12-29', '2024-01-11');

-- --------------------------------------------------------

--
-- Table structure for table `year2_remarks`
--

CREATE TABLE `year2_remarks` (
  `remarks_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `quarter_code` varchar(20) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `remark` varchar(10000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year2_remarks`
--

INSERT INTO `year2_remarks` (`remarks_id`, `unique_code`, `quarter_code`, `filter_code`, `remark`) VALUES
(5, '22-174000-0001-0012', 'bHJ6', 'qrt3', '80% survived'),
(6, '22-174000-0001-0012', 'RTS1', 'qrt4', 'hi'),
(7, '22-174000-0005-0024', '0Guy', 'qrt12', '86 % surviving'),
(8, '22-174000-0005-0024', 'lsIT', 'qrt3', '86% surviving'),
(9, '22-174000-0002-0011', 'THHP', 'qrt3', '86% surviving'),
(10, '21-174000-0001-0020/ 21-174000-0002-0050', 'o2cs', 'qrt12', 'No maintenance and Protection has been made such as \r\n-strip bushing\r\n-replanting'),
(11, '21-174000-0001-0020/ 21-174000-0002-0050', 'QSq9', 'qrt3', 'Not able to conduct \r\n-strip brushing\r\n-replanting'),
(12, '21-174000-0001-0020/ 21-174000-0002-0050', 'eFBy', 'qrt4', 'Conducted strip brushing, ring wedding and replanting\r\nTotal of 30,800 surviving assorted seedling of Forest trees and fruit trees were counted\r\nMortality is 4,200 seedling'),
(13, '21-174000-0001-0020/ 21-174000-0002-0050', 'o2cs', 'qrt12', 'They Installed billboard/Signage within the Plantation Site'),
(14, '22-174000-0004-0020', NULL, 'qrt12', 'No inspection / Validation for 1st and 2nd Quarter');

-- --------------------------------------------------------

--
-- Table structure for table `year3rd_data_tbl`
--

CREATE TABLE `year3rd_data_tbl` (
  `year3_data_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `quarter_code` varchar(10) DEFAULT NULL,
  `type_code` varchar(20) DEFAULT NULL,
  `commodity` varchar(100) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `unit` int(11) DEFAULT NULL,
  `total_cost` decimal(10,0) DEFAULT NULL,
  `accomplished` int(11) DEFAULT NULL,
  `color` varchar(20) DEFAULT NULL,
  `planted` int(11) DEFAULT NULL,
  `status` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year3rd_data_tbl`
--

INSERT INTO `year3rd_data_tbl` (`year3_data_id`, `unique_code`, `filter_code`, `quarter_code`, `type_code`, `commodity`, `quantity`, `unit`, `total_cost`, `accomplished`, `color`, `planted`, `status`) VALUES
(12, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'rwrs', 'Indigenous Trees', 12, 12, 144, 12, 'blue', NULL, NULL),
(13, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'rwrs', 'Fruit Trees', 12, 12, 144, 12, 'blue', NULL, NULL),
(14, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'replant', 'Indigenous Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(15, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'replant', 'Fruit Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(16, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'patrol', 'Indigenous Trees', 12, 12, 144, NULL, NULL, NULL, 'on monitoring'),
(17, '22-174000-0004-0020', 'qrt12', 'kXD5B', 'patrol', 'Fruit Trees', 12, 12, 144, NULL, NULL, NULL, 'on monitoring'),
(18, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'rwrs', 'Indigenous Trees', 12, 12, 144, 144, 'blue', NULL, NULL),
(19, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'rwrs', 'Fruit Trees', 12, 12, 144, 144, 'blue', NULL, NULL),
(20, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'replant', 'Indigenous Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(21, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'replant', 'Fruit Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(22, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'patrol', 'Indigenous Trees', 12, 12, 144, NULL, NULL, NULL, 'continous'),
(23, '22-174000-0004-0020', 'qrt3', 'KeJQ6', 'patrol', 'Fruit Trees', 12, 12, 144, NULL, NULL, NULL, 'continous'),
(24, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'rwrs', 'Indigenous Trees', 12, 12, 144, 12, 'Black', NULL, NULL),
(25, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'rwrs', 'Fruit Trees', 12, 12, 144, 12, 'Black', NULL, NULL),
(26, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'replant', 'Indigenous Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(27, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'replant', 'Fruit Trees', 12, 12, 144, NULL, NULL, 144, NULL),
(28, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'patrol', 'Indigenous Trees', 12, 12, 144, NULL, NULL, NULL, 'continous'),
(29, '22-174000-0004-0020', 'qrt4', 'P0jw9', 'patrol', 'Fruit Trees', 12, 12, 144, NULL, NULL, NULL, 'continous'),
(30, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'rwrs', 'Indigenous Trees', 15313, 8, 122504, 100, 'Deep pink', NULL, NULL),
(31, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'rwrs', 'Fruit Trees', 12250, 8, 98000, 100, 'Deep pink', NULL, NULL),
(32, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'replant', 'Indigenous Trees', 6563, 10, 65630, NULL, NULL, 3544, NULL),
(33, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'replant', 'Fruit Trees', 5250, 10, 52500, NULL, NULL, 3544, NULL),
(34, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'patrol', 'Indigenous Trees', 35, 0, 40683, NULL, NULL, NULL, 'Continously Conducted of M&P'),
(35, '21-174000-0001-0020/ 21-174000-0002-0050', 'qrt12', 'TySrN', 'patrol', 'Fruit Trees', 35, 0, 40683, NULL, NULL, NULL, 'Continously Conducted of M&P');

-- --------------------------------------------------------

--
-- Table structure for table `year3rd_inspection_date`
--

CREATE TABLE `year3rd_inspection_date` (
  `year3_id` int(11) NOT NULL,
  `quarter_code` varchar(10) DEFAULT NULL,
  `date_request` date NOT NULL,
  `date_inspection` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year3rd_inspection_date`
--

INSERT INTO `year3rd_inspection_date` (`year3_id`, `quarter_code`, `date_request`, `date_inspection`) VALUES
(4, 'kXD5B', '2024-02-13', '2024-02-14'),
(5, 'KeJQ6', '2024-02-16', '2024-02-18'),
(6, 'P0jw9', '2024-02-15', '2024-02-17'),
(7, 'TySrN', '2023-06-29', '2023-07-18'),
(8, 'PGTB6', '2024-05-20', '2024-05-21'),
(9, 'z62Dz', '2024-05-20', '2024-05-21'),
(10, 'psGOH', '2024-05-18', '2024-05-19'),
(11, 'ynIsp', '2024-05-20', '2024-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `year3_remarks`
--

CREATE TABLE `year3_remarks` (
  `remarks_id` int(11) NOT NULL,
  `unique_code` varchar(100) DEFAULT NULL,
  `quarter_code` varchar(20) DEFAULT NULL,
  `filter_code` varchar(6) DEFAULT NULL,
  `remark` varchar(10000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `year3_remarks`
--

INSERT INTO `year3_remarks` (`remarks_id`, `unique_code`, `quarter_code`, `filter_code`, `remark`) VALUES
(6, 'Testing', 'ynIsp', 'qrt4', 'This year3 4rt'),
(7, 'Testing', 'z62Dz', 'qrt12', 'this is year3 1st and 2nd quarter'),
(8, 'Testing', 'psGOH', 'qrt3', 'this is year3 3rd quarter'),
(9, '21-174000-0001-0020/ 21-174000-0002-0050', 'TySrN', 'qrt12', '-Installed signage within plantation site');

-- --------------------------------------------------------

--
-- Table structure for table `zone_tbl`
--

CREATE TABLE `zone_tbl` (
  `zone_id` int(11) NOT NULL,
  `zone_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `zone_tbl`
--

INSERT INTO `zone_tbl` (`zone_id`, `zone_name`) VALUES
(1, 'Production'),
(2, 'Production & Protection'),
(3, 'Protection');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `activities_tbl`
--
ALTER TABLE `activities_tbl`
  ADD PRIMARY KEY (`activities_id`);

--
-- Indexes for table `amap_doc_tbl`
--
ALTER TABLE `amap_doc_tbl`
  ADD PRIMARY KEY (`amap_doc_id`);

--
-- Indexes for table `commodity_tbl`
--
ALTER TABLE `commodity_tbl`
  ADD PRIMARY KEY (`commodity_id`);

--
-- Indexes for table `commodity_unitcost_tbl`
--
ALTER TABLE `commodity_unitcost_tbl`
  ADD PRIMARY KEY (`commodity_unitcost_id`);

--
-- Indexes for table `component_tbl`
--
ALTER TABLE `component_tbl`
  ADD PRIMARY KEY (`component_id`);

--
-- Indexes for table `contact_tbl`
--
ALTER TABLE `contact_tbl`
  ADD PRIMARY KEY (`Contact_ID`);

--
-- Indexes for table `contract_doc_tbl`
--
ALTER TABLE `contract_doc_tbl`
  ADD PRIMARY KEY (`contract_doc_id`);

--
-- Indexes for table `contract_tbl`
--
ALTER TABLE `contract_tbl`
  ADD PRIMARY KEY (`contract_id`);

--
-- Indexes for table `data_tbl`
--
ALTER TABLE `data_tbl`
  ADD PRIMARY KEY (`data_id`);

--
-- Indexes for table `date_ticinspection_tbl`
--
ALTER TABLE `date_ticinspection_tbl`
  ADD PRIMARY KEY (`date_inspection_id`);

--
-- Indexes for table `date_turnover_tbl`
--
ALTER TABLE `date_turnover_tbl`
  ADD PRIMARY KEY (`turn_over_id`);

--
-- Indexes for table `date_validation_report`
--
ALTER TABLE `date_validation_report`
  ADD PRIMARY KEY (`validation_id`);

--
-- Indexes for table `disbursement_2nd`
--
ALTER TABLE `disbursement_2nd`
  ADD PRIMARY KEY (`disbursement_2nd_id`);

--
-- Indexes for table `disbursement_3rd_mf`
--
ALTER TABLE `disbursement_3rd_mf`
  ADD PRIMARY KEY (`disbursement_3rd_id`);

--
-- Indexes for table `disbursement_76_tbl`
--
ALTER TABLE `disbursement_76_tbl`
  ADD PRIMARY KEY (`disbursement_76_id`);

--
-- Indexes for table `disbursement_tbl`
--
ALTER TABLE `disbursement_tbl`
  ADD PRIMARY KEY (`disbursement_id`);

--
-- Indexes for table `disbursement_yearend_tbl`
--
ALTER TABLE `disbursement_yearend_tbl`
  ADD PRIMARY KEY (`disbursement_yearend_id`);

--
-- Indexes for table `disturbances_tbl`
--
ALTER TABLE `disturbances_tbl`
  ADD PRIMARY KEY (`disturbances_id`);

--
-- Indexes for table `flexible_disbursement_tbl`
--
ALTER TABLE `flexible_disbursement_tbl`
  ADD PRIMARY KEY (`disbursement_id`);

--
-- Indexes for table `funding_tbl`
--
ALTER TABLE `funding_tbl`
  ADD PRIMARY KEY (`funding_id`);

--
-- Indexes for table `inspector_details_tbl`
--
ALTER TABLE `inspector_details_tbl`
  ADD PRIMARY KEY (`inspector_id`);

--
-- Indexes for table `maintenance_pro_tbl`
--
ALTER TABLE `maintenance_pro_tbl`
  ADD PRIMARY KEY (`main_id`);

--
-- Indexes for table `maintenance_tbl`
--
ALTER TABLE `maintenance_tbl`
  ADD PRIMARY KEY (`maintenance_id`);

--
-- Indexes for table `multispecies`
--
ALTER TABLE `multispecies`
  ADD PRIMARY KEY (`multispecies_id`);

--
-- Indexes for table `organizational_tbl`
--
ALTER TABLE `organizational_tbl`
  ADD PRIMARY KEY (`Org_ID`);

--
-- Indexes for table `plantation_estab_tbl`
--
ALTER TABLE `plantation_estab_tbl`
  ADD PRIMARY KEY (`plantation_id`);

--
-- Indexes for table `polygon_tbl`
--
ALTER TABLE `polygon_tbl`
  ADD PRIMARY KEY (`polygon_id`);

--
-- Indexes for table `projectcost_tbl`
--
ALTER TABLE `projectcost_tbl`
  ADD PRIMARY KEY (`cost_id`);

--
-- Indexes for table `remarks`
--
ALTER TABLE `remarks`
  ADD PRIMARY KEY (`remarks_id`);

--
-- Indexes for table `seedplanted_tbl`
--
ALTER TABLE `seedplanted_tbl`
  ADD PRIMARY KEY (`seed_id`);

--
-- Indexes for table `seedproduction_tbl`
--
ALTER TABLE `seedproduction_tbl`
  ADD PRIMARY KEY (`seed_id`);

--
-- Indexes for table `site_status_tbl`
--
ALTER TABLE `site_status_tbl`
  ADD PRIMARY KEY (`site_status_id`);

--
-- Indexes for table `species_tbl`
--
ALTER TABLE `species_tbl`
  ADD PRIMARY KEY (`species_id`);

--
-- Indexes for table `status_registry`
--
ALTER TABLE `status_registry`
  ADD PRIMARY KEY (`registry_id`);

--
-- Indexes for table `survival_rate_year1`
--
ALTER TABLE `survival_rate_year1`
  ADD PRIMARY KEY (`survival_id`);

--
-- Indexes for table `survival_rate_year2`
--
ALTER TABLE `survival_rate_year2`
  ADD PRIMARY KEY (`survival_id`);

--
-- Indexes for table `survival_rate_year3`
--
ALTER TABLE `survival_rate_year3`
  ADD PRIMARY KEY (`survival_id`);

--
-- Indexes for table `year1_disbursement`
--
ALTER TABLE `year1_disbursement`
  ADD PRIMARY KEY (`year1_id`);

--
-- Indexes for table `year2nd_data_tbl`
--
ALTER TABLE `year2nd_data_tbl`
  ADD PRIMARY KEY (`year2_data_id`);

--
-- Indexes for table `year2nd_inspection_date`
--
ALTER TABLE `year2nd_inspection_date`
  ADD PRIMARY KEY (`year2_id`);

--
-- Indexes for table `year2_remarks`
--
ALTER TABLE `year2_remarks`
  ADD PRIMARY KEY (`remarks_id`);

--
-- Indexes for table `year3rd_data_tbl`
--
ALTER TABLE `year3rd_data_tbl`
  ADD PRIMARY KEY (`year3_data_id`);

--
-- Indexes for table `year3rd_inspection_date`
--
ALTER TABLE `year3rd_inspection_date`
  ADD PRIMARY KEY (`year3_id`);

--
-- Indexes for table `year3_remarks`
--
ALTER TABLE `year3_remarks`
  ADD PRIMARY KEY (`remarks_id`);

--
-- Indexes for table `zone_tbl`
--
ALTER TABLE `zone_tbl`
  ADD PRIMARY KEY (`zone_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `activities_tbl`
--
ALTER TABLE `activities_tbl`
  MODIFY `activities_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `amap_doc_tbl`
--
ALTER TABLE `amap_doc_tbl`
  MODIFY `amap_doc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `commodity_tbl`
--
ALTER TABLE `commodity_tbl`
  MODIFY `commodity_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `commodity_unitcost_tbl`
--
ALTER TABLE `commodity_unitcost_tbl`
  MODIFY `commodity_unitcost_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=381;

--
-- AUTO_INCREMENT for table `component_tbl`
--
ALTER TABLE `component_tbl`
  MODIFY `component_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `contact_tbl`
--
ALTER TABLE `contact_tbl`
  MODIFY `Contact_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;

--
-- AUTO_INCREMENT for table `contract_doc_tbl`
--
ALTER TABLE `contract_doc_tbl`
  MODIFY `contract_doc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `contract_tbl`
--
ALTER TABLE `contract_tbl`
  MODIFY `contract_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=363;

--
-- AUTO_INCREMENT for table `data_tbl`
--
ALTER TABLE `data_tbl`
  MODIFY `data_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=361;

--
-- AUTO_INCREMENT for table `date_ticinspection_tbl`
--
ALTER TABLE `date_ticinspection_tbl`
  MODIFY `date_inspection_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `date_turnover_tbl`
--
ALTER TABLE `date_turnover_tbl`
  MODIFY `turn_over_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `date_validation_report`
--
ALTER TABLE `date_validation_report`
  MODIFY `validation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=211;

--
-- AUTO_INCREMENT for table `disbursement_2nd`
--
ALTER TABLE `disbursement_2nd`
  MODIFY `disbursement_2nd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `disbursement_3rd_mf`
--
ALTER TABLE `disbursement_3rd_mf`
  MODIFY `disbursement_3rd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `disbursement_76_tbl`
--
ALTER TABLE `disbursement_76_tbl`
  MODIFY `disbursement_76_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `disbursement_tbl`
--
ALTER TABLE `disbursement_tbl`
  MODIFY `disbursement_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `disbursement_yearend_tbl`
--
ALTER TABLE `disbursement_yearend_tbl`
  MODIFY `disbursement_yearend_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `disturbances_tbl`
--
ALTER TABLE `disturbances_tbl`
  MODIFY `disturbances_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;

--
-- AUTO_INCREMENT for table `flexible_disbursement_tbl`
--
ALTER TABLE `flexible_disbursement_tbl`
  MODIFY `disbursement_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- AUTO_INCREMENT for table `funding_tbl`
--
ALTER TABLE `funding_tbl`
  MODIFY `funding_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `inspector_details_tbl`
--
ALTER TABLE `inspector_details_tbl`
  MODIFY `inspector_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=152;

--
-- AUTO_INCREMENT for table `maintenance_pro_tbl`
--
ALTER TABLE `maintenance_pro_tbl`
  MODIFY `main_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `maintenance_tbl`
--
ALTER TABLE `maintenance_tbl`
  MODIFY `maintenance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `multispecies`
--
ALTER TABLE `multispecies`
  MODIFY `multispecies_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=326;

--
-- AUTO_INCREMENT for table `organizational_tbl`
--
ALTER TABLE `organizational_tbl`
  MODIFY `Org_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;

--
-- AUTO_INCREMENT for table `plantation_estab_tbl`
--
ALTER TABLE `plantation_estab_tbl`
  MODIFY `plantation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `polygon_tbl`
--
ALTER TABLE `polygon_tbl`
  MODIFY `polygon_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `projectcost_tbl`
--
ALTER TABLE `projectcost_tbl`
  MODIFY `cost_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=284;

--
-- AUTO_INCREMENT for table `remarks`
--
ALTER TABLE `remarks`
  MODIFY `remarks_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `seedplanted_tbl`
--
ALTER TABLE `seedplanted_tbl`
  MODIFY `seed_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `seedproduction_tbl`
--
ALTER TABLE `seedproduction_tbl`
  MODIFY `seed_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=290;

--
-- AUTO_INCREMENT for table `site_status_tbl`
--
ALTER TABLE `site_status_tbl`
  MODIFY `site_status_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=259;

--
-- AUTO_INCREMENT for table `species_tbl`
--
ALTER TABLE `species_tbl`
  MODIFY `species_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `status_registry`
--
ALTER TABLE `status_registry`
  MODIFY `registry_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=181;

--
-- AUTO_INCREMENT for table `survival_rate_year1`
--
ALTER TABLE `survival_rate_year1`
  MODIFY `survival_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `survival_rate_year2`
--
ALTER TABLE `survival_rate_year2`
  MODIFY `survival_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `survival_rate_year3`
--
ALTER TABLE `survival_rate_year3`
  MODIFY `survival_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=222;

--
-- AUTO_INCREMENT for table `year1_disbursement`
--
ALTER TABLE `year1_disbursement`
  MODIFY `year1_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `year2nd_data_tbl`
--
ALTER TABLE `year2nd_data_tbl`
  MODIFY `year2_data_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=167;

--
-- AUTO_INCREMENT for table `year2nd_inspection_date`
--
ALTER TABLE `year2nd_inspection_date`
  MODIFY `year2_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `year2_remarks`
--
ALTER TABLE `year2_remarks`
  MODIFY `remarks_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `year3rd_data_tbl`
--
ALTER TABLE `year3rd_data_tbl`
  MODIFY `year3_data_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `year3rd_inspection_date`
--
ALTER TABLE `year3rd_inspection_date`
  MODIFY `year3_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `year3_remarks`
--
ALTER TABLE `year3_remarks`
  MODIFY `remarks_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `zone_tbl`
--
ALTER TABLE `zone_tbl`
  MODIFY `zone_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
