CREATE DATABASE QuanLyPhongGame
GO
CREATE TABLE TaiKhoan
(
	TenTk VARCHAR(100) NOT NULL PRIMARY KEY,
	MatKhau VARCHAR(100)NOT NULL,
	ChuTK NVARCHAR(100),
	GioiTinh NVARCHAR(15),
	NgaySinh DATETIME,
	SoDienThoai VARCHAR(15),
	SoDuTaiKhoan INT
)
GO
CREATE TABLE KhoHang
(
	MaHang VARCHAR(50) NOT NULL PRIMARY KEY,
	TenHang NVARCHAR(100)NOT NULL,
	SoLuong INT,
	GiaNhap INT,
	GiaBan  INT,
)
GO
CREATE TABLE HoaDon
(
	MaHD VARCHAR(50) NOT NULL PRIMARY KEY,
	TenTK VARCHAR(100) FOREIGN KEY REFERENCES dbo.TaiKhoan(TenTk),
	Loai BIT,
	GiaTri INT,
	Ngay DATE,
	Gio TIME,
	ChiTiet NVARCHAR(500)
)
GO
