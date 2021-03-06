USE [QUANLYNGANHANG]
GO
ALTER TABLE [dbo].[YeuCauVayVon] DROP CONSTRAINT [FK__YeuCauVayV__cmnd__45F365D3]
GO
ALTER TABLE [dbo].[YeuCauVayVon] DROP CONSTRAINT [FK__YeuCauVay__trang__44FF419A]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK__NhanVien__maChuc__440B1D61]
GO
ALTER TABLE [dbo].[HoSoVayVon] DROP CONSTRAINT [FK__HoSoVayVo__maYeu__4316F928]
GO
ALTER TABLE [dbo].[HopDong] DROP CONSTRAINT [FK__HopDong__maYeuCa__4222D4EF]
GO
ALTER TABLE [dbo].[DieuKhoan] DROP CONSTRAINT [FK__DieuKhoan__maHop__412EB0B6]
GO
ALTER TABLE [dbo].[DieuChinhHopDong] DROP CONSTRAINT [FK__DieuChinh__maHop__403A8C7D]
GO
ALTER TABLE [dbo].[DieuChinhHopDong] DROP CONSTRAINT [FK__DieuChinh__maDie__3F466844]
GO
ALTER TABLE [dbo].[BienLaiThuNo] DROP CONSTRAINT [FK__BienLaiTh__maNgu__3E52440B]
GO
ALTER TABLE [dbo].[BienLaiThuNo] DROP CONSTRAINT [FK__BienLaiTh__maHop__3D5E1FD2]
GO
ALTER TABLE [dbo].[BienLaiPhatTienVay] DROP CONSTRAINT [FK__BienLaiPh__maNgu__3C69FB99]
GO
ALTER TABLE [dbo].[BienLaiPhatTienVay] DROP CONSTRAINT [FK__BienLaiPh__maHop__3B75D760]
GO
ALTER TABLE [dbo].[BaoCaoGiamSat] DROP CONSTRAINT [FK__BaoCaoGiam__cmnd__398D8EEE]
GO
ALTER TABLE [dbo].[BaoCaoGiamSat] DROP CONSTRAINT [FK__BaoCaoGia__maNha__3A81B327]
GO
/****** Object:  Table [dbo].[YeuCauVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[YeuCauVayVon]') AND type in (N'U'))
DROP TABLE [dbo].[YeuCauVayVon]
GO
/****** Object:  Table [dbo].[TrangThaiYeuCauVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrangThaiYeuCauVayVon]') AND type in (N'U'))
DROP TABLE [dbo].[TrangThaiYeuCauVayVon]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoSoVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoSoVayVon]') AND type in (N'U'))
DROP TABLE [dbo].[HoSoVayVon]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HopDong]') AND type in (N'U'))
DROP TABLE [dbo].[HopDong]
GO
/****** Object:  Table [dbo].[DieuKhoan]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DieuKhoan]') AND type in (N'U'))
DROP TABLE [dbo].[DieuKhoan]
GO
/****** Object:  Table [dbo].[DieuChinhHopDong]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DieuChinhHopDong]') AND type in (N'U'))
DROP TABLE [dbo].[DieuChinhHopDong]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu]') AND type in (N'U'))
DROP TABLE [dbo].[ChucVu]
GO
/****** Object:  Table [dbo].[BienLaiThuNo]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BienLaiThuNo]') AND type in (N'U'))
DROP TABLE [dbo].[BienLaiThuNo]
GO
/****** Object:  Table [dbo].[BienLaiPhatTienVay]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BienLaiPhatTienVay]') AND type in (N'U'))
DROP TABLE [dbo].[BienLaiPhatTienVay]
GO
/****** Object:  Table [dbo].[BaoCaoGiamSat]    Script Date: 12/16/2020 11:16:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoCaoGiamSat]') AND type in (N'U'))
DROP TABLE [dbo].[BaoCaoGiamSat]
GO
USE [master]
GO
/****** Object:  Database [QUANLYNGANHANG]    Script Date: 12/16/2020 11:16:16 PM ******/
DROP DATABASE [QUANLYNGANHANG]
GO
/****** Object:  Database [QUANLYNGANHANG]    Script Date: 12/16/2020 11:16:16 PM ******/
CREATE DATABASE [QUANLYNGANHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNGANHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QUANLYNGANHANG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYNGANHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QUANLYNGANHANG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QUANLYNGANHANG] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNGANHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNGANHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNGANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNGANHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYNGANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNGANHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYNGANHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNGANHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNGANHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNGANHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNGANHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYNGANHANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYNGANHANG] SET QUERY_STORE = OFF
GO
USE [QUANLYNGANHANG]
GO
/****** Object:  Table [dbo].[BaoCaoGiamSat]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoGiamSat](
	[maBaoCaoGiamSat] [int] IDENTITY(1,1) NOT NULL,
	[cmnd] [varchar](10) NULL,
	[linkFileBaoCao] [varchar](max) NULL,
	[maNhanVien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maBaoCaoGiamSat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BienLaiPhatTienVay]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BienLaiPhatTienVay](
	[maBienLaiPhatTienVay] [int] IDENTITY(1,1) NOT NULL,
	[maHopDong] [int] NULL,
	[soTien] [int] NULL,
	[noiDung] [nvarchar](max) NULL,
	[ngayPhatTien] [smalldatetime] NULL,
	[maNguoiTao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maBienLaiPhatTienVay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BienLaiThuNo]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BienLaiThuNo](
	[maBienLaiPhatTienVay] [int] IDENTITY(1,1) NOT NULL,
	[maHopDong] [int] NULL,
	[soTien] [int] NULL,
	[noiDung] [nvarchar](max) NULL,
	[ngayNopTien] [smalldatetime] NULL,
	[maNguoiTao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maBienLaiPhatTienVay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [int] IDENTITY(1,1) NOT NULL,
	[tenChucVu] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuChinhHopDong]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuChinhHopDong](
	[maDieuChinhHopDong] [int] IDENTITY(1,1) NOT NULL,
	[maHopDong] [int] NULL,
	[maDieuKhoan] [int] NULL,
	[noiDungChiTiet] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[maDieuChinhHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuKhoan]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuKhoan](
	[maDieuKhoan] [int] IDENTITY(1,1) NOT NULL,
	[maHopDong] [int] NULL,
	[noiDungDieuKhoan] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[maDieuKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[maHopDong] [int] IDENTITY(1,1) NOT NULL,
	[maYeuCauVayVon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoVayVon](
	[maHoSoVayVon] [int] IDENTITY(1,1) NOT NULL,
	[maYeuCauVayVon] [int] NULL,
	[linkFileHoSo] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoSoVayVon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[cmnd] [varchar](10) NOT NULL,
	[name] [nvarchar](255) NULL,
	[diachi] [nvarchar](255) NULL,
	[phone] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[username] [varchar](255) NULL,
	[password] [varchar](255) NULL,
	[maChucVu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiYeuCauVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiYeuCauVayVon](
	[maTrangThai] [int] IDENTITY(1,1) NOT NULL,
	[tenTrangThai] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[maTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauVayVon]    Script Date: 12/16/2020 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauVayVon](
	[maYeuCauVayVon] [int] IDENTITY(1,1) NOT NULL,
	[cmnd] [varchar](10) NULL,
	[mucDichVayVon] [nvarchar](255) NULL,
	[thoiHanVay] [int] NULL,
	[soTienVay] [bigint] NULL,
	[kiHan] [int] NULL,
	[ngayBatDauVay] [smalldatetime] NULL,
	[laiSuat] [float] NULL,
	[trangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maYeuCauVayVon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (1, N'Nhân viên phòng tín d?ng')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (2, N'B? ph?n xét duy?t')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (3, N'B? ph?n qu?n lý h?p d?ng')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (4, N'B? ph?n qu?n lý h?p d?ng')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (5, N'B? ph?n qu?n lí tài chính-k? toán')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HopDong] ON 

INSERT [dbo].[HopDong] ([maHopDong], [maYeuCauVayVon]) VALUES (1, 3)
INSERT [dbo].[HopDong] ([maHopDong], [maYeuCauVayVon]) VALUES (2, 3)
SET IDENTITY_INSERT [dbo].[HopDong] OFF
GO
INSERT [dbo].[KhachHang] ([cmnd], [name], [diachi], [phone]) VALUES (N'025921234', N'KhachHang1', N'1 Ðồng Khởi', N'0907123456')
INSERT [dbo].[KhachHang] ([cmnd], [name], [diachi], [phone]) VALUES (N'025921235', N'KhachHang2', N'2 Ðồng Khởi', N'0907123478')
INSERT [dbo].[KhachHang] ([cmnd], [name], [diachi], [phone]) VALUES (N'098765431', N'Abc', N'abc', N'09876543')
INSERT [dbo].[KhachHang] ([cmnd], [name], [diachi], [phone]) VALUES (N'135', N'Koro', N'23 Le Loi', N'1')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([maNhanVien], [name], [username], [password], [maChucVu]) VALUES (1, N'Nguy?n Van A', N'Anv_1', N'123', 1)
INSERT [dbo].[NhanVien] ([maNhanVien], [name], [username], [password], [maChucVu]) VALUES (2, N'Nguy?n Van B', N'Bnv_2', N'123', 2)
INSERT [dbo].[NhanVien] ([maNhanVien], [name], [username], [password], [maChucVu]) VALUES (3, N'Nguy?n Van C', N'Cnv_3', N'123', 3)
INSERT [dbo].[NhanVien] ([maNhanVien], [name], [username], [password], [maChucVu]) VALUES (4, N'Nguy?n Van D', N'Dnv_4', N'123', 4)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[TrangThaiYeuCauVayVon] ON 

INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (1, N'Chờ duyệt')
INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (2, N'Ðã duyệt')
INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (3, N'Ðã kí hợp đồng')
INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (4, N'Ðã phát tiền vay')
INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (5, N'Từ chối')
INSERT [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai], [tenTrangThai]) VALUES (6, N'Đã thanh lý hợp đồn')
SET IDENTITY_INSERT [dbo].[TrangThaiYeuCauVayVon] OFF
GO
SET IDENTITY_INSERT [dbo].[YeuCauVayVon] ON 

INSERT [dbo].[YeuCauVayVon] ([maYeuCauVayVon], [cmnd], [mucDichVayVon], [thoiHanVay], [soTienVay], [kiHan], [ngayBatDauVay], [laiSuat], [trangThai]) VALUES (3, N'025921234', N'1', 36, 1000000, 12, CAST(N'2020-06-08T00:00:00' AS SmallDateTime), 1.5, 2)
INSERT [dbo].[YeuCauVayVon] ([maYeuCauVayVon], [cmnd], [mucDichVayVon], [thoiHanVay], [soTienVay], [kiHan], [ngayBatDauVay], [laiSuat], [trangThai]) VALUES (4, N'025921235', N'Mua xe', 24, 200000000, 6, CAST(N'2016-12-17T00:00:00' AS SmallDateTime), 0.07, 1)
INSERT [dbo].[YeuCauVayVon] ([maYeuCauVayVon], [cmnd], [mucDichVayVon], [thoiHanVay], [soTienVay], [kiHan], [ngayBatDauVay], [laiSuat], [trangThai]) VALUES (16, N'135', N'Tiêu dùng', 18, 2070000, 1, CAST(N'2020-02-02T00:00:00' AS SmallDateTime), 0.01, 1)
INSERT [dbo].[YeuCauVayVon] ([maYeuCauVayVon], [cmnd], [mucDichVayVon], [thoiHanVay], [soTienVay], [kiHan], [ngayBatDauVay], [laiSuat], [trangThai]) VALUES (21, N'098765431', N'1', 12, 1000000, 2, CAST(N'2020-12-16T00:00:00' AS SmallDateTime), 1.67, 1)
SET IDENTITY_INSERT [dbo].[YeuCauVayVon] OFF
GO
ALTER TABLE [dbo].[BaoCaoGiamSat]  WITH CHECK ADD FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[BaoCaoGiamSat]  WITH CHECK ADD FOREIGN KEY([cmnd])
REFERENCES [dbo].[KhachHang] ([cmnd])
GO
ALTER TABLE [dbo].[BienLaiPhatTienVay]  WITH CHECK ADD FOREIGN KEY([maHopDong])
REFERENCES [dbo].[HopDong] ([maHopDong])
GO
ALTER TABLE [dbo].[BienLaiPhatTienVay]  WITH CHECK ADD FOREIGN KEY([maNguoiTao])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[BienLaiThuNo]  WITH CHECK ADD FOREIGN KEY([maHopDong])
REFERENCES [dbo].[HopDong] ([maHopDong])
GO
ALTER TABLE [dbo].[BienLaiThuNo]  WITH CHECK ADD FOREIGN KEY([maNguoiTao])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[DieuChinhHopDong]  WITH CHECK ADD FOREIGN KEY([maDieuKhoan])
REFERENCES [dbo].[DieuKhoan] ([maDieuKhoan])
GO
ALTER TABLE [dbo].[DieuChinhHopDong]  WITH CHECK ADD FOREIGN KEY([maHopDong])
REFERENCES [dbo].[HopDong] ([maHopDong])
GO
ALTER TABLE [dbo].[DieuKhoan]  WITH CHECK ADD FOREIGN KEY([maHopDong])
REFERENCES [dbo].[HopDong] ([maHopDong])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([maYeuCauVayVon])
REFERENCES [dbo].[YeuCauVayVon] ([maYeuCauVayVon])
GO
ALTER TABLE [dbo].[HoSoVayVon]  WITH CHECK ADD FOREIGN KEY([maYeuCauVayVon])
REFERENCES [dbo].[YeuCauVayVon] ([maYeuCauVayVon])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
GO
ALTER TABLE [dbo].[YeuCauVayVon]  WITH CHECK ADD FOREIGN KEY([trangThai])
REFERENCES [dbo].[TrangThaiYeuCauVayVon] ([maTrangThai])
GO
ALTER TABLE [dbo].[YeuCauVayVon]  WITH CHECK ADD FOREIGN KEY([cmnd])
REFERENCES [dbo].[KhachHang] ([cmnd])
GO
USE [master]
GO
ALTER DATABASE [QUANLYNGANHANG] SET  READ_WRITE 
GO
