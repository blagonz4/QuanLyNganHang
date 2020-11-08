CREATE DATABASE BAOTRIPHANMEM
USE BAOTRIPHANMEM

CREATE TABLE ChucVu(
    maChucVu int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    tenChucVu varchar(255)
);

CREATE TABLE NhanVien (
    maNhanVien int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name varchar(255),
    username varchar(255),
    password varchar(255),
	maChucVu int,
	FOREIGN KEY (maChucVu) REFERENCES ChucVu(maChucVu)
);

CREATE TABLE KhachHang (
    cmnd varchar(10) NOT NULL PRIMARY KEY,
    name varchar(255),
    diachi varchar(255),
	phone varchar(10),
);

CREATE TABLE TrangThaiYeuCauVayVon(
maTrangThai int NOT NULL IDENTITY(1,1) PRIMARY KEY,
tenTrangThai varchar(255)
);

CREATE TABLE YeuCauVayVon (
    maYeuCauVayVon int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	cmnd varchar(10),
	mucDichVayVon varchar(255),
	thoiHanVay int,
	soTienVay int,
	kiHan int,
	ngayBatDauVay date,
	laiSuat float,
	trangThai int, 
	FOREIGN KEY (cmnd) REFERENCES KhachHang(cmnd),
	FOREIGN KEY (trangThai) REFERENCES TrangThaiYeuCauVayVon(maTrangThai)
);

ALTER TABLE YeuCauVayVon ALTER COLUMN ngayBatDauVay smalldatetime

CREATE TABLE HopDong (
maHopDong int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maYeuCauVayVon int,
FOREIGN KEY (maYeuCauVayVon) REFERENCES YeuCauVayVon(maYeuCauVayVon)
);

CREATE TABLE DieuKhoan(
maDieuKhoan int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maHopDong int,
noiDungDieuKhoan varChar(MAX),
FOREIGN KEY (maHopDong) REFERENCES HopDong(maHopDong)
);

CREATE TABLE DieuChinhHopDong(
maDieuChinhHopDong int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maHopDong int,
maDieuKhoan int,
noiDungChiTiet nvarchar(MAX)
FOREIGN KEY (maHopDong) REFERENCES HopDong(maHopDong),
FOREIGN KEY (maDieuKhoan) REFERENCES DieuKhoan(maDieuKhoan)
);


CREATE TABLE BaoCaoGiamSat(
maBaoCaoGiamSat int NOT NULL IDENTITY(1,1) PRIMARY KEY,
cmnd varchar(10),
linkFileBaoCao varchar(MAX)
FOREIGN KEY (cmnd) REFERENCES KhachHang(cmnd),
maNhanVien int,
FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);

CREATE TABLE HoSoVayVon(
maHoSoVayVon int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maYeuCauVayVon int,
linkFileHoSo varchar(MAX)
FOREIGN KEY (maYeuCauVayVon) REFERENCES YeuCauVayVon(maYeuCauVayVon)
);

CREATE TABLE BienLaiPhatTienVay(
maBienLaiPhatTienVay int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maHopDong int,
soTien int,
noiDung nvarchar(MAX),
ngayPhatTien smalldatetime,
maNguoiTao int
FOREIGN KEY (maHopDong) REFERENCES HopDong(maHopDong),
FOREIGN KEY (maNguoiTao) REFERENCES NhanVien(maNhanVien)
);

CREATE TABLE BienLaiThuNo(
maBienLaiPhatTienVay int NOT NULL IDENTITY(1,1) PRIMARY KEY,
maHopDong int,
soTien int,
noiDung nvarchar(MAX),
ngayNopTien smalldatetime,
maNguoiTao int,
FOREIGN KEY (maHopDong) REFERENCES HopDong(maHopDong),
FOREIGN KEY (maNguoiTao) REFERENCES NhanVien(maNhanVien)
);


--Fake Data:
INSERT INTO ChucVu (tenChucVu)
VALUES ('Nhân viên phòng tín dụng');

INSERT INTO ChucVu (tenChucVu)
VALUES ('Bộ phận xét duyệt');

INSERT INTO ChucVu (tenChucVu)
VALUES ('Bộ phận quản lý hợp đồng');

INSERT INTO ChucVu (tenChucVu)
VALUES ('Bộ phận quản lý hợp đồng');

INSERT INTO ChucVu (tenChucVu)
VALUES ('Bộ phận quản lí tài chính-kế toán');

INSERT INTO NhanVien (name, username, password, maChucVu)
VALUES ('Nguyễn Văn A', 'Anv_1', '123', 1);

INSERT INTO NhanVien (name, username, password, maChucVu)
VALUES ('Nguyễn Văn B', 'Bnv_2', '123', 2);

INSERT INTO NhanVien (name, username, password, maChucVu)
VALUES ('Nguyễn Văn C', 'Cnv_3', '123', 3);

INSERT INTO NhanVien (name, username, password, maChucVu)
VALUES ('Nguyễn Văn D', 'Dnv_4', '123', 4);

INSERT INTO KhachHang(cmnd, name, diachi, phone)
VALUES ('025921234', 'KhachHang1', '1 Đồng Khởi', '0907123456');

INSERT INTO KhachHang(cmnd, name, diachi, phone)
VALUES ('025921235', 'KhachHang2', '2 Đồng Khởi', '0907123478');

INSERT INTO YeuCauVayVon(cmnd, mucDichVayVon, thoiHanVay, soTienVay, kiHan, ngayBatDauVay, laiSuat, trangThai)
VALUES ('025921234', 'Mua nhà', 36, 100000000, 3 , '2015-12-17', 0.05, 1);

INSERT INTO YeuCauVayVon(cmnd, mucDichVayVon, thoiHanVay, soTienVay, kiHan, ngayBatDauVay, laiSuat, trangThai)
VALUES ('025921235', 'Mua xe', 24, 200000000, 6 , '2016-12-17', 0.07, 1);

INSERT INTO TrangThaiYeuCauVayVon(tenTrangThai)
VALUES ('Chờ duyệt');

INSERT INTO TrangThaiYeuCauVayVon(tenTrangThai)
VALUES ('Đã duyệt');

INSERT INTO TrangThaiYeuCauVayVon(tenTrangThai)
VALUES ('Đã kí hợp đồng');

INSERT INTO TrangThaiYeuCauVayVon(tenTrangThai)
VALUES ('Đã phát tiền vay');

INSERT INTO HopDong(maYeuCauVayVon)
VALUES (8);

INSERT INTO HopDong(maYeuCauVayVon)
VALUES (9);

INSERT INTO DieuKhoan(maHopDong, noiDungDieuKhoan)
VALUES (9, 'Điều khoản 1');

INSERT INTO DieuKhoan(maHopDong, noiDungDieuKhoan)
VALUES (9, 'Điều khoản 2');

INSERT INTO DieuKhoan(maHopDong, noiDungDieuKhoan)
VALUES (10, 'Điều khoản 3');

INSERT INTO DieuKhoan(maHopDong, noiDungDieuKhoan)
VALUES (10, 'Điều khoản 4');

INSERT INTO DieuChinhHopDong(maHopDong, maDieuKhoan, noiDungChiTiet)
VALUES (9, 1, 'Chuyển thời hạn vay');

INSERT INTO DieuChinhHopDong(maHopDong, maDieuKhoan, noiDungChiTiet)
VALUES (9, 2, 'Chuyển thời hạn trả lãi');

INSERT INTO BienLaiPhatTienVay(maHopDong, soTien, noiDung, ngayPhatTien, maNguoiTao)
VALUES (9, 1000000, 'Phát tiền vay cho khách hàng', '2020-12-17', 4);

INSERT INTO BienLaiPhatTienVay(maHopDong, soTien, noiDung, ngayPhatTien, maNguoiTao)
VALUES (10, 2000000, 'Phát tiền vay cho khách hàng', '2020-12-18', 4);

INSERT INTO BienLaiThuNo(maHopDong, soTien, noiDung, ngayNopTien, maNguoiTao)
VALUES (9, 100000, 'Thu lãi khách hàng', '2021-12-18', 4);

INSERT INTO BienLaiThuNo(maHopDong, soTien, noiDung, ngayNopTien, maNguoiTao)
VALUES (10, 20000, 'Thu lãi khách hàng', '2021-12-19', 4);










