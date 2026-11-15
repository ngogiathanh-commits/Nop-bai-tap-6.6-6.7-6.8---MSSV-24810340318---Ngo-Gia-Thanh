CREATE DATABASE LMS;
GO

USE LMS
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DocGia')
BEGIN
    CREATE TABLE DocGia (
        MaDocGia INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        Email VARCHAR(100) UNIQUE NOT NULL,
        NgayHetHanThe DATETIME NOT NULL
    );
END

CREATE TABLE DauSach (
        MaSach INT IDENTITY(1,1) PRIMARY KEY,
        TenSach NVARCHAR(200) NOT NULL,
        TheLoai NVARCHAR(50) NOT NULL, 
        SoLuongCon INT NOT NULL CHECK (SoLuongCon >= 0)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PhieuMuon')
BEGIN
    CREATE TABLE PhieuMuon (
        MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
        MaDocGia INT FOREIGN KEY REFERENCES DocGia(MaDocGia) ON DELETE CASCADE,
        NgayMuon DATETIME NOT NULL DEFAULT GETDATE(),
        HanTra DATETIME NOT NULL,
        TrangThai NVARCHAR(50) DEFAULT N'Đang mượn' -- 'Đang mượn', 'Đã trả', 'Quá hạn'
    );
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ChiTietMuon')
BEGIN
    CREATE TABLE ChiTietMuon (
        MaPhieu INT FOREIGN KEY REFERENCES PhieuMuon(MaPhieu) ON DELETE CASCADE,
        MaSach INT FOREIGN KEY REFERENCES DauSach(MaSach),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        PRIMARY KEY (MaPhieu, MaSach)
    );
END

INSERT INTO DocGia (HoTen, Email, NgayHetHanThe) VALUES
    (N'Nguyễn Minh Tuấn', 'tuan.nm@library.vn', '2027-12-31'),
    (N'Trần Thu Hà', 'ha.tt@library.vn', '2027-06-30'),
    (N'Phạm Quốc Bảo', 'bao.pq@library.vn', '2025-10-01');

INSERT INTO DauSach (TenSach, TheLoai, SoLuongCon) VALUES
    (N'Lập trình C# và ADO.NET Toàn Tập', N'Công nghệ thông tin', 15),
    (N'Cơ Sở Dữ Liệu SQL Server Nâng Cao', N'Công nghệ thông tin', 10),
    (N'Kinh Tế Học Vi Mô', N'Kinh tế', 20),
    (N'Nhà Giả Kim', N'Văn học', 12),
    (N'Đắc Nhân Tâm', N'Văn học', 18);

INSERT INTO PhieuMuon (MaDocGia, NgayMuon, HanTra, TrangThai) VALUES
    (1, '2026-10-01', '2026-10-15', N'Quá hạn'),   
    (2, '2026-11-10', '2026-11-25', N'Đang mượn'),
    (1, '2026-09-01', '2026-09-10', N'Đã trả');

INSERT INTO ChiTietMuon (MaPhieu, MaSach, SoLuong) VALUES
    (1, 1, 1),
    (1, 3, 2),
    (2, 2, 1),
    (3, 4, 1);
GO


