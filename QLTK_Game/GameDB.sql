CREATE DATABASE GameDB
GO
USE GameDB;
GO
--------
-- 1. Bảng User
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(MAX), 
    DisplayName NVARCHAR(100)
);
-- Tạo tài khoản Admin
INSERT INTO Users (Username, Password, DisplayName) 
VALUES ('admin', 'admin', 'ADMIN');
go
-- 2. Bảng Liên Quân 
-- Thường là: Garena, Facebook, Apple ID
CREATE TABLE LienQuanAccounts (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Password NVARCHAR(MAX), 
    LoginType NVARCHAR(50), 
    RankLienQuan NVARCHAR(50),
    SoTuong INT,
    Skins INT
);
--Thêm dữ liệu cho bảng Liên Quân
INSERT INTO LienQuanAccounts (Username, Password, LoginType, RankLienQuan, SoTuong, Skins)
VALUES 
(N'lienquan1@gmail.com', N'123456', N'Garena', N'Chiến Tướng', 115, 320),
(N'lienquan2@gmail.com', N'123456', N'Facebook', N'Cao Thủ', 105, 150);
go
-- 3. Bảng Free Fire 
CREATE TABLE FreeFireAccounts (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Password NVARCHAR(MAX),
    LoginType NVARCHAR(50), 
    ID_InGame NVARCHAR(20),
    SkinSungHiem NVARCHAR(MAX),
    LevelAccount INT
);

--Thêm dữ liệu cho bảng Free Fire 
INSERT INTO FreeFireAccounts (Username, Password, LoginType, ID_InGame, SkinSungHiem, LevelAccount)
VALUES 
(N'ff001@gmail.com', N'ffpass1', N'Google', N'99887766', N'500', 70),
(N'ffnewbie@gmail.com', N'ffpass2', N'Garena', N'11223344', N'50', 15);
go
-- 4. Bảng FC Mobile 
CREATE TABLE FCMobileAccounts (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Password NVARCHAR(MAX),
    LoginType NVARCHAR(50), 
    DoiHinh_OVR INT,
    GiaTriDoiHinh BIGINT,
    Region NVARCHAR(50)
);
--Thêm dữ liệu cho bảng FC Mobile 
INSERT INTO FCMobileAccounts (Username, Password, LoginType, DoiHinh_OVR, GiaTriDoiHinh, Region)
VALUES 
(N'fc01@gmail.com', N'fcpass1', N'Facebook', 140, 25000000000, N'VN'),
(N'fc02@gmail.com', N'fcpass2', N'EA Account', 138, 18000000000, N'Global');
GO





