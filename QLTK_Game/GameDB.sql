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

-- 2. Bảng Liên Quân 
CREATE TABLE LienQuanAccounts (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Password NVARCHAR(MAX), 
    LoginType NVARCHAR(50), 
    RankLienQuan NVARCHAR(50),
    SoTuong INT,
    Skins INT
);

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
