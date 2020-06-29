CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

--Các bảng cần có
-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	status NVARCHAR(100), --Trống || Có người
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,

)
GO
