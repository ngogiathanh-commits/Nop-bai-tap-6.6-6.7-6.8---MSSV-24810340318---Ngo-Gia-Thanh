CREATE DATABASE QLNT;
go

use QLNT;
go

CREATE TABLE BenhNhan (
        MaBN INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        SoDienThoai VARCHAR(15) UNIQUE NOT NULL,
        NamSinh INT NOT NULL
);

CREATE TABLE HoSoKham (
        MaHoSo INT IDENTITY(1,1) PRIMARY KEY,
        MaBN INT FOREIGN KEY REFERENCES BenhNhan(MaBN) ON DELETE CASCADE,
        NgayKham DATETIME NOT NULL DEFAULT GETDATE(),
        TrieuChung NVARCHAR(MAX),
        ChanDoan NVARCHAR(250)
);

CREATE TABLE Thuoc (
        MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
        TenThuoc NVARCHAR(150) NOT NULL,
        DonViTinh NVARCHAR(20) NOT NULL, -- 'Viên', 'Vỉ', 'Chai'
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);

CREATE TABLE DonThuoc (
        MaDon INT IDENTITY(1,1) PRIMARY KEY,
        MaHoSo INT FOREIGN KEY REFERENCES HoSoKham(MaHoSo) ON DELETE CASCADE,
        TienKham DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienKham >= 0),
        TongTien DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TongTien >= 0),
        TrangThai NVARCHAR(30) DEFAULT N'Chờ lấy thuốc' -- 'Chờ lấy thuốc', 'Đã thanh toán'
);

CREATE TABLE ChiTietDonThuoc (
        MaDon INT FOREIGN KEY REFERENCES DonThuoc(MaDon) ON DELETE CASCADE,
        MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        LieuDung NVARCHAR(100),
        PRIMARY KEY (MaDon, MaThuoc)
);

INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh) VALUES
    (N'Lê Văn An', '0901234567', 1988),
    (N'Nguyễn Thị Bình', '0918765432', 1995);

INSERT INTO HoSoKham (MaBN, NgayKham, TrieuChung, ChanDoan) VALUES
    (1, GETDATE(), N'Sốt nhẹ, đau họng, ho khan', N'Viêm họng cấp'),
    (2, GETDATE(), N'Đau thượng vị, ợ chua sau ăn', N'Trào ngược dạ dày');

INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) VALUES
    (N'Paracetamol 500mg', N'Vỉ', 15000, 100),
    (N'Amoxicillin 500mg', N'Vỉ', 25000, 80),
    (N'Siro ho Bảo Thanh 125ml', N'Chai', 55000, 40),
    (N'Omeprazole 20mg', N'Viên', 3500, 200),
    (N'Vitamin C 500mg', N'Viên', 2000, 150);
go