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


CREATE PROC USP_Login
@userName varchar(100),
@passWord varchar(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenTk =@userName AND MatKhau = @passWord
END

CREATE PROC USP_UpdateMK
@tenTk varchar(100),
@matkhau varchar(100),
@matkhaumoi varchar(100)
AS
BEGIN
	DECLARE @dungMk INT = 0
	SELECT @dungMk = COUNT(*) FROM dbo.TaiKhoan WHERE MatKhau = @matkhau AND TenTk =@tenTk
	IF(@dungMk=1)
	BEGIN
		UPDATE dbo.TaiKhoan SET MatKhau=@matkhaumoi  WHERE TenTk=@tenTK 
		end
END
GO
