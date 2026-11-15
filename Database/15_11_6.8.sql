create database BLMS;
GO

USE BLMS;
GO

CREATE TABLE BanBida (
        MaBan INT IDENTITY(1,1) PRIMARY KEY,
        TenBan NVARCHAR(50) NOT NULL,
        LoaiBan NVARCHAR(30) DEFAULT N'Pool (Lỗ)', -- 'Pool (Lỗ)', 'Carom (Phăng)', 'Snooker'
        GiaTheoGio DECIMAL(18,2) NOT NULL CHECK (GiaTheoGio > 0),
        TrangThai NVARCHAR(20) DEFAULT N'Trống'     -- 'Trống', 'Đang chơi'
);

CREATE TABLE MenuDichVu (
        MaDV INT IDENTITY(1,1) PRIMARY KEY,
        TenDV NVARCHAR(100) NOT NULL,
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        TonKho INT NOT NULL CHECK (TonKho >= 0)
);

CREATE TABLE HoaDon (
        MaHD INT IDENTITY(1,1) PRIMARY KEY,
        MaBan INT FOREIGN KEY REFERENCES BanBida(MaBan),
        GioBatDau DATETIME NOT NULL DEFAULT GETDATE(),
        GioKetThuc DATETIME NULL,
        TienGioChoi DECIMAL(18,2) DEFAULT 0,
        TienDichVu DECIMAL(18,2) DEFAULT 0,
        TrangThai BIT DEFAULT 0 -- 0: Chưa thanh toán, 1: Đã thanh toán
);

CREATE TABLE ChiTietHoaDon (
        MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
        MaDV INT FOREIGN KEY REFERENCES MenuDichVu(MaDV),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        PRIMARY KEY (MaHD, MaDV)
);

INSERT INTO BanBida (TenBan, LoaiBan, GiaTheoGio, TrangThai) VALUES
    (N'Bàn Lỗ 01', N'Pool (Lỗ)', 80000, N'Trống'),
    (N'Bàn Lỗ 02', N'Pool (Lỗ)', 80000, N'Trống'),
    (N'Bàn Carom 01', N'Carom (Phăng)', 70000, N'Trống'),
    (N'Bàn Carom 02', N'Carom (Phăng)', 70000, N'Trống'),
    (N'Bàn Snooker VIP', N'Snooker', 120000, N'Trống');

INSERT INTO MenuDichVu (TenDV, DonGia, TonKho) VALUES
    (N'Nước tăng lực Sting', 15000, 150),
    (N'Bò húc RedBull', 20000, 120),
    (N'Mì xào bò', 45000, 40),
    (N'Khăn lạnh', 5000, 300),
    (N'Thuê gậy Carbon', 50000, 999);
go