CREATE DATABASE BTLC
GO 
CREATE TABLE tSach
(
	MaSach NVARCHAR(10) NOT NULL,
	Tensach NVARCHAR(50) NOT NULL,
	TenTacGia NVARCHAR(50) NOT NULL,
	NamXB SMALLINT NOT NULL,
	NhaXB NVARCHAR(20),
	LanTaiBan TINYINT,
	SoLuong SMALLINT NOT NULL,
	SoTrang SMALLINT,
	MaTheLoai NVARCHAR(10),
	PRIMARY KEY(MaSach)
);

CREATE TABLE tSinhVien
(
	MaSinhVien INT NOT NULL,
	PRIMARY KEY(MaSinhVien),
	TenKhoa NVARCHAR(30) NOT NULL,
	TenLop NVARCHAR(30) NOT NULL,
	--Thoi gian hoc la hien tai dang nam may
	ThoiGianHoc TINYINT, 
	--So nam hoc la so nam hoc de tot nghiep
	SoNamHoc TINYINT,
);
CREATE TABLE tNhanVien
(
	MaNhanVien NVARCHAR(10) NOT NULL,
	PRIMARY KEY(MaNhanVien),
	TenNV NVARCHAR(30) NOT NULL,
	NgaySinh DATE,
	GioiTinh NVARCHAR(5),
	SoDienThoai INT NOT NULL,
	DiaChi NVARCHAR(100),
);
CREATE TABLE tTheMuon
(
	MaThe NVARCHAR(10) NOT NULL,
	HoTen NVARCHAR(20) NOT NULL,
	GioiTinh NVARCHAR(5) NOT NULL,
	NgaySinh DATE,
	MaSinhVien INT NOT NULL,
	NgayLamThe DATE NOT NULL,
	NgayHetHan DATE NOT NULL,
	PRIMARY KEY (MaThe),
	CONSTRAINT FK_The_SV FOREIGN KEY(MaSinhVien) REFERENCES dbo.SinhVien(MaSinhVien)
);
CREATE TABLE tDSMuon
(
	SoPhieuMuon NVARCHAR(10) NOT NULL,
	Masach NVARCHAR(10) NOT NULL,
	SoLuong TINYINT,
	PRIMARY KEY(SoPhieuMuon),
	CONSTRAINT FK_DS_Sach FOREIGN KEY(Masach) REFERENCES dbo.Sach(MaSach)
);
CREATE TABLE tChiTietPhieuMuon
(
	SoPhieuMuon NVARCHAR(10) NOT NULL,
	MaThe NVARCHAR(10) NOT NULL,
	MaNhanVien NVARCHAR(10) NOT NULL,
	NgayMuon DATE NOT NULL,
	NgayPhaiTra DATE NOT NULL,
	TrangThai NVARCHAR(10),
	PRIMARY KEY(SoPhieuMuon),
	CONSTRAINT FK_PM_The FOREIGN KEY(MaThe) REFERENCES dbo.TheMuon(MaThe),
	CONSTRAINT FK_PM_NV FOREIGN KEY(MaNhanVien) REFERENCES dbo.NhanVien(MaNhanVien),
	CONSTRAINT FK FOREIGN KEY(SoPhieuMuon) REFERENCES dbo.DSMuon(SoPhieuMuon)
);
CREATE TABLE tViPham
(
	MaThe NVARCHAR(10),
	MaViPham NVARCHAR(10),
	TenViPham NVARCHAR(20),
	NoiDung NVARCHAR(200),
	CONSTRAINT FK_ViPham_The FOREIGN KEY(MaThe) REFERENCES dbo.TheMuon(MaThe)
);

CREATE TABLE tTraSach
(
	SoPhieuMuon NVARCHAR(10) NOT NULL,
	MaSach NVARCHAR(10) NOT NULL,
	MaNV NVARCHAR(10),
	NgayTra DATE NOT NULL, 
	CONSTRAINT FK_Tra_Nv FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNhanVien),
	CONSTRAINT FK_Muon_Tra FOREIGN KEY(SoPhieuMuon) REFERENCES dbo.ChiTietPhieuMuon(SoPhieuMuon),
	CONSTRAINT FK_Tra_Sach FOREIGN KEY(MaSach) REFERENCES dbo.Sach(MaSach)
);