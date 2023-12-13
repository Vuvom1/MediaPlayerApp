-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost
-- Thời gian đã tạo: Th12 13, 2023 lúc 03:30 PM
-- Phiên bản máy phục vụ: 10.4.28-MariaDB
-- Phiên bản PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `MusicPlayer`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `MUSIC`
--

CREATE TABLE `MUSIC` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(50) DEFAULT NULL,
  `FILEPATH` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `MUSIC_PLAYLIST`
--

CREATE TABLE `MUSIC_PLAYLIST` (
  `ID` int(11) NOT NULL,
  `MUSIC_ID` int(11) DEFAULT NULL,
  `PLAYLIST_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `PLAYLIST`
--

CREATE TABLE `PLAYLIST` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `MUSIC`
--
ALTER TABLE `MUSIC`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `MUSIC_PLAYLIST`
--
ALTER TABLE `MUSIC_PLAYLIST`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_MP_MS` (`MUSIC_ID`),
  ADD KEY `FK_MP_PL` (`PLAYLIST_ID`);

--
-- Chỉ mục cho bảng `PLAYLIST`
--
ALTER TABLE `PLAYLIST`
  ADD PRIMARY KEY (`ID`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `MUSIC_PLAYLIST`
--
ALTER TABLE `MUSIC_PLAYLIST`
  ADD CONSTRAINT `FK_MP_MS` FOREIGN KEY (`MUSIC_ID`) REFERENCES `MUSIC` (`ID`),
  ADD CONSTRAINT `FK_MP_PL` FOREIGN KEY (`PLAYLIST_ID`) REFERENCES `PLAYLIST` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
