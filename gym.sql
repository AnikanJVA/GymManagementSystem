-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 08, 2025 at 01:15 PM
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
-- Database: `gym`
--

-- --------------------------------------------------------

--
-- Table structure for table `deductions`
--

CREATE TABLE `deductions` (
  `deductionID` bigint(20) NOT NULL,
  `payrollID` bigint(20) DEFAULT NULL,
  `deductionName` varchar(100) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `discounts`
--

CREATE TABLE `discounts` (
  `discountID` bigint(20) NOT NULL,
  `discountName` varchar(100) DEFAULT NULL,
  `discountRate` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `equipmentcategories`
--

CREATE TABLE `equipmentcategories` (
  `categoryID` bigint(20) NOT NULL,
  `categoryName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipmentcategories`
--

INSERT INTO `equipmentcategories` (`categoryID`, `categoryName`) VALUES
(1, 'Cardio'),
(2, 'Strength'),
(3, 'Free Weights');

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE `equipments` (
  `equipmentID` bigint(20) NOT NULL,
  `equipmentName` varchar(150) DEFAULT NULL,
  `brand` varchar(100) DEFAULT NULL,
  `model` varchar(100) DEFAULT NULL,
  `categoryID` bigint(20) DEFAULT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `equipmentCondition` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipments`
--

INSERT INTO `equipments` (`equipmentID`, `equipmentName`, `brand`, `model`, `categoryID`, `cost`, `quantity`, `equipmentCondition`) VALUES
(1, 'Treadmill X10', 'LifeFit', 'X10 Pro', 1, 1500.50, 5, 'Excellent'),
(2, 'Power Rack XL', 'IronForce', 'PR-XL', 2, 850.00, 3, 'Good'),
(3, 'Hex Dumbbell Set', 'HeavyLift', 'HD-300', 3, 250.75, 10, 'Fair'),
(4, 'asdf', 'cell', '2982938', 3, 299.00, 24, 'Good'),
(5, 'Dumbell 15 pounds', 'Duracell', 'DB-100', 3, 300.00, 4, 'Good');

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

CREATE TABLE `expenses` (
  `expenseID` bigint(20) NOT NULL,
  `expenseType` varchar(100) DEFAULT NULL,
  `expenseCategory` varchar(50) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `description` text DEFAULT NULL,
  `staffID` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `maintenancerecords`
--

CREATE TABLE `maintenancerecords` (
  `recordID` bigint(20) NOT NULL,
  `equipmentID` bigint(20) DEFAULT NULL,
  `maintenanceDate` datetime DEFAULT NULL,
  `description` text DEFAULT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `performedBy` varchar(100) DEFAULT NULL,
  `nextDueDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `memberattendance`
--

CREATE TABLE `memberattendance` (
  `attendanceID` bigint(20) NOT NULL,
  `memberID` bigint(20) DEFAULT NULL,
  `timeIn` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `memberID` bigint(20) NOT NULL,
  `lastName` varchar(50) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `middleName` varchar(50) DEFAULT NULL,
  `DoB` date DEFAULT NULL,
  `Sex` varchar(10) DEFAULT NULL,
  `contactNumber` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `membershipDate` datetime DEFAULT NULL,
  `membershipType` varchar(50) DEFAULT NULL,
  `renewalDate` datetime DEFAULT NULL,
  `membershipStatus` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `payrollID` bigint(20) NOT NULL,
  `staffID` bigint(20) NOT NULL,
  `payPeriodStart` date DEFAULT NULL,
  `payPeriodEnd` date DEFAULT NULL,
  `totalHours` decimal(10,2) DEFAULT NULL,
  `grossPay` decimal(10,2) DEFAULT NULL,
  `totalDeductions` decimal(10,2) DEFAULT NULL,
  `netPay` decimal(10,2) DEFAULT NULL,
  `dateGenerated` date DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `positions`
--

CREATE TABLE `positions` (
  `positionID` bigint(20) NOT NULL,
  `positionName` varchar(100) DEFAULT NULL,
  `baseSalary` decimal(10,2) DEFAULT NULL,
  `hourlyRate` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `saleID` bigint(20) NOT NULL,
  `saleTypeID` bigint(20) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `discountID` bigint(20) DEFAULT NULL,
  `memberID` bigint(20) DEFAULT NULL,
  `transactionDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `saletypes`
--

CREATE TABLE `saletypes` (
  `saleTypeID` bigint(20) NOT NULL,
  `saleTypeName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sessions`
--

CREATE TABLE `sessions` (
  `sesssionID` bigint(20) NOT NULL,
  `staffID` bigint(20) DEFAULT NULL,
  `memberID` bigint(20) DEFAULT NULL,
  `sessionDate` datetime NOT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staffattendance`
--

CREATE TABLE `staffattendance` (
  `attendanceID` bigint(20) NOT NULL,
  `staffID` bigint(20) DEFAULT NULL,
  `timeIn` datetime DEFAULT NULL,
  `timeOut` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `staffID` bigint(20) NOT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  `lastName` varchar(50) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `middleName` varchar(50) DEFAULT NULL,
  `DoB` date DEFAULT NULL,
  `Sex` varchar(10) DEFAULT NULL,
  `contactNumber` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `schedule` varchar(20) DEFAULT NULL,
  `positionID` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` bigint(20) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `accType` varchar(50) DEFAULT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `username`, `password`, `accType`, `status`) VALUES
(1, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'ADMIN', 'ACTIVE'),
(2, 're', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'RECEPTIONIST', 'ACTIVE'),
(3, 'co', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'COACH', 'ACTIVE');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `deductions`
--
ALTER TABLE `deductions`
  ADD PRIMARY KEY (`deductionID`),
  ADD KEY `payrollID` (`payrollID`);

--
-- Indexes for table `discounts`
--
ALTER TABLE `discounts`
  ADD PRIMARY KEY (`discountID`);

--
-- Indexes for table `equipmentcategories`
--
ALTER TABLE `equipmentcategories`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `equipments`
--
ALTER TABLE `equipments`
  ADD PRIMARY KEY (`equipmentID`),
  ADD KEY `categoryID` (`categoryID`);

--
-- Indexes for table `expenses`
--
ALTER TABLE `expenses`
  ADD PRIMARY KEY (`expenseID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `maintenancerecords`
--
ALTER TABLE `maintenancerecords`
  ADD PRIMARY KEY (`recordID`),
  ADD KEY `equipmentID` (`equipmentID`);

--
-- Indexes for table `memberattendance`
--
ALTER TABLE `memberattendance`
  ADD PRIMARY KEY (`attendanceID`),
  ADD KEY `memberID` (`memberID`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`memberID`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`payrollID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `positions`
--
ALTER TABLE `positions`
  ADD PRIMARY KEY (`positionID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`saleID`),
  ADD KEY `discountID` (`discountID`),
  ADD KEY `memberID` (`memberID`),
  ADD KEY `saleTypeID` (`saleTypeID`) USING BTREE;

--
-- Indexes for table `saletypes`
--
ALTER TABLE `saletypes`
  ADD PRIMARY KEY (`saleTypeID`);

--
-- Indexes for table `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`sesssionID`),
  ADD KEY `memberID` (`memberID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `staffattendance`
--
ALTER TABLE `staffattendance`
  ADD PRIMARY KEY (`attendanceID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`staffID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `positionID` (`positionID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `deductions`
--
ALTER TABLE `deductions`
  MODIFY `deductionID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `discounts`
--
ALTER TABLE `discounts`
  MODIFY `discountID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `equipmentcategories`
--
ALTER TABLE `equipmentcategories`
  MODIFY `categoryID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `equipments`
--
ALTER TABLE `equipments`
  MODIFY `equipmentID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `expenses`
--
ALTER TABLE `expenses`
  MODIFY `expenseID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `maintenancerecords`
--
ALTER TABLE `maintenancerecords`
  MODIFY `recordID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `memberattendance`
--
ALTER TABLE `memberattendance`
  MODIFY `attendanceID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `memberID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `payrollID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `positions`
--
ALTER TABLE `positions`
  MODIFY `positionID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `saleID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `saletypes`
--
ALTER TABLE `saletypes`
  MODIFY `saleTypeID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sessions`
--
ALTER TABLE `sessions`
  MODIFY `sesssionID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staffattendance`
--
ALTER TABLE `staffattendance`
  MODIFY `attendanceID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `staffID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deductions`
--
ALTER TABLE `deductions`
  ADD CONSTRAINT `deductions_ibfk_1` FOREIGN KEY (`payrollID`) REFERENCES `payroll` (`payrollID`);

--
-- Constraints for table `equipments`
--
ALTER TABLE `equipments`
  ADD CONSTRAINT `equipments_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `equipmentcategories` (`categoryID`);

--
-- Constraints for table `expenses`
--
ALTER TABLE `expenses`
  ADD CONSTRAINT `expenses_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staffs` (`staffID`);

--
-- Constraints for table `maintenancerecords`
--
ALTER TABLE `maintenancerecords`
  ADD CONSTRAINT `maintenancerecords_ibfk_1` FOREIGN KEY (`equipmentID`) REFERENCES `equipments` (`equipmentID`);

--
-- Constraints for table `memberattendance`
--
ALTER TABLE `memberattendance`
  ADD CONSTRAINT `memberattendance_ibfk_1` FOREIGN KEY (`memberID`) REFERENCES `members` (`memberID`);

--
-- Constraints for table `payroll`
--
ALTER TABLE `payroll`
  ADD CONSTRAINT `payroll_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staffs` (`staffID`);

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`discountID`) REFERENCES `discounts` (`discountID`),
  ADD CONSTRAINT `sales_ibfk_2` FOREIGN KEY (`memberID`) REFERENCES `members` (`memberID`),
  ADD CONSTRAINT `sales_ibfk_3` FOREIGN KEY (`saleTypeID`) REFERENCES `saletypes` (`saleTypeID`);

--
-- Constraints for table `sessions`
--
ALTER TABLE `sessions`
  ADD CONSTRAINT `sessions_ibfk_1` FOREIGN KEY (`memberID`) REFERENCES `members` (`memberID`),
  ADD CONSTRAINT `sessions_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staffs` (`staffID`);

--
-- Constraints for table `staffattendance`
--
ALTER TABLE `staffattendance`
  ADD CONSTRAINT `staffattendance_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staffs` (`staffID`);

--
-- Constraints for table `staffs`
--
ALTER TABLE `staffs`
  ADD CONSTRAINT `staffs_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `staffs_ibfk_2` FOREIGN KEY (`positionID`) REFERENCES `positions` (`positionID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
