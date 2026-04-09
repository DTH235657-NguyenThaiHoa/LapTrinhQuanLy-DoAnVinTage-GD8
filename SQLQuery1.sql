CREATE DATABASE QLVintageShop;
GO

USE QLVintageShop;
GO

CREATE TABLE LoaiSanPham (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(255) NOT NULL
);

CREATE TABLE HangSanXuat (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenHangSanXuat NVARCHAR(255) NOT NULL
);

CREATE TABLE NhanVien (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(255) NOT NULL,
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255),
    TenDangNhap NVARCHAR(100) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL,
    QuyenHan BIT NOT NULL
);

CREATE TABLE KhachHang (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(255) NOT NULL,
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

CREATE TABLE SanPham (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HangSanXuatID INT NOT NULL,
    LoaiSanPhamID INT NOT NULL,
    TenSanPham NVARCHAR(255) NOT NULL,
    Size NVARCHAR(50) NOT NULL,
    DonGia INT NOT NULL,
    SoLuong INT NOT NULL,
    MoTa NVARCHAR(MAX),

    FOREIGN KEY (HangSanXuatID) REFERENCES HangSanXuat(ID),
    FOREIGN KEY (LoaiSanPhamID) REFERENCES LoaiSanPham(ID)
);

CREATE TABLE HoaDon (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienID INT NOT NULL,
    KhachHangID INT NOT NULL,
    NgayLap DATETIME NOT NULL,
    GhiChuHoaDon NVARCHAR(MAX),

    FOREIGN KEY (NhanVienID) REFERENCES NhanVien(ID),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(ID)
);

CREATE TABLE HoaDon_ChiTiet (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HoaDonID INT NOT NULL,
    SanPhamID INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia INT NOT NULL,

    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(ID) ON DELETE CASCADE,
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(ID)
);

-- Loại sản phẩm
INSERT INTO LoaiSanPham (TenLoai) VALUES
(N'Áo Vintage'),
(N'Quần Vintage'),
(N'Áo khoác Retro'),
(N'Phụ kiện cổ điển'),
(N'Giày Vintage'),
(N'Túi xách Retro');

-- Hãng
INSERT INTO HangSanXuat (TenHangSanXuat) VALUES
(N'Levi''s Vintage'),
(N'Wrangler'),
(N'Champion USA'),
(N'Local Secondhand'),
(N'Nike Retro'),
(N'Adidas Classics');

-- Nhân viên
INSERT INTO NhanVien VALUES
(N'Nguyễn Retro', '0901234567', N'Cần Thơ', 'admin', '123456', 1),
(N'Trần Vintage', '0912345678', N'HCM', 'staff1', '123456', 0),
(N'Lê Classic', '0933333333', N'Hà Nội', 'staff2', '123456', 0);

-- Khách hàng (ID 1 → 8)
INSERT INTO KhachHang VALUES
(N'Lý Hoài Cổ', '0971111111', N'Huế'),
(N'Nguyễn Streetwear', '0982222222', N'TP.HCM'),
(N'Tạ Vintage Lover', '0993333333', N'Hà Nội'),
(N'Đoàn Retro Fit', '0904444444', N'Đà Nẵng'),
(N'Phùng Classic Man', '0915555555', N'Cần Thơ'),
(N'Hoàng Old Vibes', '0926666666', N'Nha Trang'),
(N'Đinh Secondhand', '0937777777', N'Hải Dương'),
(N'Lâm Hoài Niệm', '0948888888', N'Quảng Ninh');

-- Sản phẩm
INSERT INTO SanPham VALUES
(1,1,N'Áo thun Vintage','M',300000,20,N'Áo thun cổ điển'),
(2,1,N'Áo sơ mi Vintage','L',350000,15,N'Sơ mi retro'),
(1,2,N'Quần jean Vintage','L',600000,10,N'Jean cổ điển'),
(2,2,N'Quần kaki Retro','M',450000,12,N'Kaki rộng'),
(3,3,N'Denim Jacket','L',800000,8,N'Áo khoác jean'),
(4,3,N'Bomber Retro','XL',900000,6,N'Bomber 80s'),
(4,4,N'Nón len','Free',150000,25,N'Nón vintage'),
(4,4,N'Thắt lưng da','M',200000,18,N'Thắt lưng'),
(5,5,N'Nike Air Retro','42',1200000,5,N'Giày retro'),
(6,5,N'Adidas Superstar','41',1100000,7,N'Giày classic'),
(4,6,N'Túi chéo','Free',350000,14,N'Túi vải'),
(4,6,N'Balo Retro','Free',500000,9,N'Balo');

-- Hóa đơn (fix ID khách hàng hợp lệ)
INSERT INTO HoaDon VALUES
(1,1,GETDATE(),N'Full set'),
(2,2,GETDATE(),N'Áo + quần'),
(3,3,GETDATE(),N'Phụ kiện'),
(1,4,GETDATE(),N'Mua nhiều'),
(2,5,GETDATE(),N'Áo khoác'),
(3,6,GETDATE(),N'Giày'),
(1,7,GETDATE(),N'Combo'),
(2,8,GETDATE(),N'Lần 2'),
(3,1,GETDATE(),N'Đi chơi'),
(1,5,GETDATE(),N'Khách cũ'),
(2,6,GETDATE(),N'Mua quà'),
(3,7,GETDATE(),N'Mix đồ');

-- Chi tiết hóa đơn
INSERT INTO HoaDon_ChiTiet VALUES
(1,1,1,300000),
(1,3,1,600000),
(2,2,1,350000),
(2,4,1,450000),
(3,8,2,200000),
(3,11,1,350000),
(4,1,2,300000),
(4,5,1,800000),
(4,12,1,500000),
(5,6,1,900000),
(6,9,1,1200000),
(6,10,1,1100000),
(7,2,2,350000),
(7,7,1,150000),
(8,3,1,600000),
(8,11,1,350000),
(9,4,1,450000),
(9,12,2,500000),
(10,5,1,800000),
(10,8,1,200000),
(11,6,1,900000),
(11,1,1,300000),
(12,2,1,350000),
(12,9,1,1200000),
(12,7,2,150000);


DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM SanPham;
DELETE FROM KhachHang;
DELETE FROM NhanVien;
DELETE FROM HangSanXuat;
DELETE FROM LoaiSanPham;

DBCC CHECKIDENT ('HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('HoaDon', RESEED, 0);
DBCC CHECKIDENT ('SanPham', RESEED, 0);
DBCC CHECKIDENT ('KhachHang', RESEED, 0);
DBCC CHECKIDENT ('NhanVien', RESEED, 0);
DBCC CHECKIDENT ('HangSanXuat', RESEED, 0);
DBCC CHECKIDENT ('LoaiSanPham', RESEED, 0);

DROP TABLE HoaDon_ChiTiet;
DROP TABLE HoaDon;
DROP TABLE SanPham;
DROP TABLE KhachHang;
DROP TABLE NhanVien;
DROP TABLE HangSanXuat;
DROP TABLE LoaiSanPham;