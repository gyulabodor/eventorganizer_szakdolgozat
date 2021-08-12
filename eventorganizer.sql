-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2021. Máj 05. 18:08
-- Kiszolgáló verziója: 10.4.10-MariaDB
-- PHP verzió: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `eventorganizer`
--
CREATE DATABASE IF NOT EXISTS `eventorganizer` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `eventorganizer`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `drinkmenus`
--

DROP TABLE IF EXISTS `drinkmenus`;
CREATE TABLE IF NOT EXISTS `drinkmenus` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(35) COLLATE utf8_hungarian_ci NOT NULL,
  `description` text COLLATE utf8_hungarian_ci NOT NULL,
  `devprice_per_person` int(11) NOT NULL,
  `saleprice_per_person` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `drinkmenus`
--

INSERT INTO `drinkmenus` (`id`, `name`, `description`, `devprice_per_person`, `saleprice_per_person`) VALUES
(1, 'fogyasztás alapú elszámolás', 'A rendezvény végén kerülnek elszámolásra az italok fogyasztás alapján', 0, 0),
(3, ' A - korlátlan italfogyasztás', 'Sörök + Borok + Rövid italok + Üditők', 4890, 6900),
(4, 'B - korlátlan italfogyasztás', 'Sörök + Borok + Üditők', 3850, 4990),
(5, 'C - korlátlan italfogyasztás', 'Üditők', 1370, 2990);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(35) COLLATE utf8_hungarian_ci NOT NULL,
  `payment_per_person` int(11) NOT NULL,
  `need_per_person` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `employees`
--

INSERT INTO `employees` (`id`, `type`, `payment_per_person`, `need_per_person`) VALUES
(1, 'pultos', 15000, 50),
(2, 'felszolgáló', 15000, 10),
(3, 'szakács', 17000, 25);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `events`
--

DROP TABLE IF EXISTS `events`;
CREATE TABLE IF NOT EXISTS `events` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `events`
--

INSERT INTO `events` (`id`, `name`) VALUES
(1, 'Esküvő'),
(2, 'Születésnap'),
(3, 'Céges rendezvény'),
(4, 'Állófogadás');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `locations`
--

DROP TABLE IF EXISTS `locations`;
CREATE TABLE IF NOT EXISTS `locations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `renting_price` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `locations`
--

INSERT INTO `locations` (`id`, `name`, `renting_price`) VALUES
(1, 'Római part vendégház', 39990);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `meals`
--

DROP TABLE IF EXISTS `meals`;
CREATE TABLE IF NOT EXISTS `meals` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `course` varchar(1) COLLATE utf8_hungarian_ci NOT NULL,
  `dev_price` int(11) NOT NULL,
  `sale_price` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `meals`
--

INSERT INTO `meals` (`id`, `name`, `course`, `dev_price`, `sale_price`) VALUES
(1, 'Húsleves', 'e', 465, 780),
(2, 'Hideg meggyleves', 'e', 375, 680),
(3, 'Párolt jázmin rizs', 'k', 60, 420),
(4, 'Hasábburgonya', 'k', 60, 420),
(5, 'Friss saláta', 's', 135, 390),
(6, 'Vecsési Savanyúság', 's', 89, 390),
(7, 'Töltött káposzta', 'f', 325, 990),
(8, 'Sült csirkecomb', 'f', 270, 990),
(9, 'Rántott csirkemell', 'f', 540, 1290),
(10, 'Natúr csirkemell', 'f', 490, 1290),
(11, 'Rántott sajt', 'f', 295, 1290),
(12, 'Fűszeres tarja', 'f', 640, 1290),
(13, 'Cigánypecsenye', 'f', 590, 1290),
(15, 'Sajtasztal', 't', 1490, 2190),
(16, 'Sonkaválogatás', 't', 1320, 1790),
(17, 'Paraszt tál', 't', 1439, 2190),
(18, 'Tengeri tál', 't', 1490, 2490),
(19, 'Vega tál', 't', 1390, 1890),
(20, 'Brokkoli krémleves', 'e', 380, 680),
(21, 'Zöldségleves', 'e', 495, 680),
(22, 'Palócleves', 'e', 585, 890),
(23, 'Mátrai borzaska', 'f', 690, 1290),
(24, 'Holstein szelet', 'f', 570, 1290),
(25, 'Rántott fogasfilé', 'f', 610, 1490),
(26, 'Rigó Jancsi', 'd', 215, 430),
(27, 'Joghurt szelet', 'd', 195, 430),
(28, 'Gyümölcskosár', 'd', 240, 390),
(29, 'Zserbó szelet', 'd', 230, 430),
(30, 'Panna Cotta', 'd', 190, 390);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `portions`
--

DROP TABLE IF EXISTS `portions`;
CREATE TABLE IF NOT EXISTS `portions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `portions` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `portions`
--

INSERT INTO `portions` (`id`, `portions`) VALUES
(1, 35),
(2, 35),
(3, 35),
(4, 35),
(5, 35),
(6, 35);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tenders`
--

DROP TABLE IF EXISTS `tenders`;
CREATE TABLE IF NOT EXISTS `tenders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `event_type` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `client_name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `client_phone` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `client_email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `event_date` date NOT NULL,
  `guests_number` int(11) NOT NULL,
  `mealmenu_devprice_person` int(11) NOT NULL,
  `mealmenu_saleprice_person` int(11) NOT NULL,
  `mealmenu_devprice` int(11) DEFAULT NULL,
  `mealmenu_saleprice` int(11) DEFAULT NULL,
  `drinkmenu_devprice_person` int(11) NOT NULL,
  `drinkmenu_saleprice_person` int(11) NOT NULL,
  `drinkmenu_devprice` int(11) DEFAULT NULL,
  `drinkmenu_saleprice` int(11) DEFAULT NULL,
  `totalmenu_devprice_person` int(11) NOT NULL,
  `totalmenu_saleprice_person` int(11) NOT NULL,
  `totalmenu_devprice` int(11) NOT NULL,
  `totalmenu_saleprice` int(11) NOT NULL,
  `place_rentingprice` int(11) DEFAULT NULL,
  `employees_payment` int(11) DEFAULT NULL,
  `event_totalsaleprice` int(11) NOT NULL,
  `event_totaldevprice` int(11) NOT NULL,
  `profit` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `tenders`
--

INSERT INTO `tenders` (`id`, `event_type`, `client_name`, `client_phone`, `client_email`, `event_date`, `guests_number`, `mealmenu_devprice_person`, `mealmenu_saleprice_person`, `mealmenu_devprice`, `mealmenu_saleprice`, `drinkmenu_devprice_person`, `drinkmenu_saleprice_person`, `drinkmenu_devprice`, `drinkmenu_saleprice`, `totalmenu_devprice_person`, `totalmenu_saleprice_person`, `totalmenu_devprice`, `totalmenu_saleprice`, `place_rentingprice`, `employees_payment`, `event_totalsaleprice`, `event_totaldevprice`, `profit`) VALUES
(1, 'Esküvő', 'Mekk Elek', '06203145659', 'mekkelek@outlook.hu', '2021-02-28', 35, 2360, 4700, 82600, 164500, 3850, 4990, 134750, 174650, 6210, 9690, 217350, 339150, 39990, 109000, 488140, 217350, 270790);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tenders_drinkmenus`
--

DROP TABLE IF EXISTS `tenders_drinkmenus`;
CREATE TABLE IF NOT EXISTS `tenders_drinkmenus` (
  `tender_id` int(11) NOT NULL,
  `drinkmenu_id` int(11) NOT NULL,
  KEY `tender_id` (`tender_id`),
  KEY `drinkservice_id` (`drinkmenu_id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `tenders_drinkmenus`
--

INSERT INTO `tenders_drinkmenus` (`tender_id`, `drinkmenu_id`) VALUES
(1, 4);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tenders_meals_portions`
--

DROP TABLE IF EXISTS `tenders_meals_portions`;
CREATE TABLE IF NOT EXISTS `tenders_meals_portions` (
  `tender_id` int(11) NOT NULL,
  `meal_id` int(11) NOT NULL,
  `portion_id` int(11) NOT NULL,
  KEY `tender_id` (`tender_id`),
  KEY `meal_id` (`meal_id`),
  KEY `portion_id` (`portion_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `tenders_meals_portions`
--

INSERT INTO `tenders_meals_portions` (`tender_id`, `meal_id`, `portion_id`) VALUES
(1, 20, 1),
(1, 8, 2),
(1, 4, 3),
(1, 16, 4),
(1, 5, 5),
(1, 27, 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `email_address` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(256) COLLATE utf8_hungarian_ci NOT NULL,
  UNIQUE KEY `email_address` (`email_address`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`email_address`, `password`) VALUES
('admin@admin.hu', 'f5c894f690afd6bf5e95a6ad171a4760');

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `tenders_drinkmenus`
--
ALTER TABLE `tenders_drinkmenus`
  ADD CONSTRAINT `tenders_drinkmenus_ibfk_1` FOREIGN KEY (`drinkmenu_id`) REFERENCES `drinkmenus` (`id`),
  ADD CONSTRAINT `tenders_drinkmenus_ibfk_2` FOREIGN KEY (`tender_id`) REFERENCES `tenders` (`id`);

--
-- Megkötések a táblához `tenders_meals_portions`
--
ALTER TABLE `tenders_meals_portions`
  ADD CONSTRAINT `tenders_meals_portions_ibfk_1` FOREIGN KEY (`tender_id`) REFERENCES `tenders` (`id`),
  ADD CONSTRAINT `tenders_meals_portions_ibfk_2` FOREIGN KEY (`meal_id`) REFERENCES `meals` (`id`),
  ADD CONSTRAINT `tenders_meals_portions_ibfk_3` FOREIGN KEY (`portion_id`) REFERENCES `portions` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
