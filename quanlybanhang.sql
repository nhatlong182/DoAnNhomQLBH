USE [master]
GO
/****** Object:  Database [quanlybanhang]    Script Date: 10/2/2021 3:58:43 PM ******/
CREATE DATABASE [quanlybanhang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlybanhang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\quanlybanhang.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlybanhang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\quanlybanhang_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlybanhang] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlybanhang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlybanhang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlybanhang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlybanhang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlybanhang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlybanhang] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlybanhang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [quanlybanhang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlybanhang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlybanhang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlybanhang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlybanhang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlybanhang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlybanhang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlybanhang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlybanhang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [quanlybanhang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlybanhang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlybanhang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlybanhang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlybanhang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlybanhang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlybanhang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlybanhang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlybanhang] SET  MULTI_USER 
GO
ALTER DATABASE [quanlybanhang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlybanhang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlybanhang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlybanhang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [quanlybanhang] SET DELAYED_DURABILITY = DISABLED 
GO
USE [quanlybanhang]
GO
/****** Object:  User [XUANTHAO\pc]    Script Date: 10/2/2021 3:58:43 PM ******/
CREATE USER [XUANTHAO\pc] FOR LOGIN [XUANTHAO\pc] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CTDH]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDH](
	[MaDH] [int] NOT NULL,
	[MaSP] [nvarchar](20) NOT NULL,
	[Soluong] [int] NULL,
	[Size] [nchar](10) NULL,
	[ThanhTien] [int] NULL,
	[Giamgia] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
	[NgayLapHD] [datetime] NULL,
	[NgayGiaoHang] [datetime] NULL,
	[DiaChiGiaoHang] [nchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DienThoai] [nvarchar](7) NULL,
	[Fax] [nvarchar](12) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [int] NOT NULL,
	[TenLoaiSP] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Admin] [bit] NULL,
	[GioiTinh] [nchar](10) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](20) NOT NULL,
	[TenSP] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[MaLoaiSP] [int] NULL,
	[HinhSP] [nvarchar](max) NULL,
	[DangGiamGia] [bit] NULL,
	[MaGiamGia] [int] NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT06', 1, NULL, 255000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT08', 3, N'          ', 675000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT09', 1, N'M         ', 299000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT14', 5, N'M         ', 1250000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT15', 1, NULL, 400000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT17', 2, N'L         ', 200000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'SM05', 1, NULL, 300000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'TS03', 2, NULL, 500000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (23, N'AT01', 2, N'M         ', 910000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (23, N'AT02', 1, N'L         ', 399000, 0)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (23, N'AT10', 2, N'S         ', 300000, 0)
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (22, 5, 1, CAST(N'2021-09-05 13:43:24.000' AS DateTime), CAST(N'2021-10-06 00:00:00.000' AS DateTime), N'b                                                 ', N'Không')
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (23, 2, 1, CAST(N'2021-09-05 17:28:52.000' AS DateTime), CAST(N'2021-10-01 19:29:39.607' AS DateTime), N'b                                                 ', N'Không')
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (33, 1, 20, CAST(N'2021-09-22 08:22:50.000' AS DateTime), CAST(N'2021-10-01 19:22:03.157' AS DateTime), N'b                                                 ', N'Không')
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (39, 17, 1, CAST(N'2021-09-05 13:43:24.000' AS DateTime), CAST(N'2021-10-02 08:17:33.373' AS DateTime), N'g                                                 ', N'Không')
SET IDENTITY_INSERT [dbo].[DonHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (1, N'Nguyễn Xuân Thao', N'123 Tân Phú', CAST(N'1999-12-02' AS Date), N'Nam', N'12322', N'123', N'a', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (2, N'Bong Hong', N'24 Ky Cong', CAST(N'2000-12-11' AS Date), N'Nữ', N'8855421', N'084088800256', N'a@gmail.com', N'c')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (5, N'Koko Companyy', N'90 An Duong Vuong', CAST(N'2000-12-08' AS Date), N'Nam', N'8250102', N'084083230156', N'bg@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (6, N'Queen Cozinhaa', N'891 An Duong Vuong', CAST(N'2000-12-07' AS Date), N'Nam', N'8855461', N'084428430156', N'bendin@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (8, N'Suoi Tra', N'2817 Minh Phun', CAST(N'2000-02-12' AS Date), N'Nữ', N'8356210', N'084088356210', N'stun@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (9, N'Song Trang', N'187 Lao Tu', CAST(N'2000-03-12' AS Date), N'Nam', N'9450210', N'084088430142', N'ana@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (10, N'Vinh Vien', N'45 Su Van hanh', CAST(N'2000-04-12' AS Date), N'Nam', N'8855469', N'084088654790', N'anas@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (11, N'Trần Vinh Viễn', N'87 Trần Hưng Đạo', CAST(N'2000-05-12' AS Date), N'Nam', N'8855464', N'084088430112', N'ani@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (13, N' Minh Hưng', N'456 Công Hòa', CAST(N'2000-12-12' AS Date), N'Nam', N'8855264', N'084088430131', N'ana@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (14, N'Nghia Đình', N'12 Lý chính Thắng', CAST(N'2000-09-12' AS Date), N'Nam', N'9874564', N'084088430113', N'ana11@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (15, N'Minh Anh', N'15/1 Hữu Giang', CAST(N'2000-08-12' AS Date), N'Nam', N'6548797', N'084088430141', N'ana12@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (16, N'Trần Tùng', N'12/15 Hậu Nghia', CAST(N'2001-12-12' AS Date), N'Nam', N'6547898', N'084088430114', N'ana13@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (17, N'Vinh Lợi', N'1812 Trần Quang Khải', CAST(N'2002-12-12' AS Date), N'Nam', N'8854464', N'084088430151', N'ahi2@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (18, N'Bình Duong', N'145 Nguyễn Hiền', CAST(N'2004-12-12' AS Date), N'Nam', N'6548797', N'084088430115', N'aha1@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (19, N'Thần Tài', N'14 Lê Lợi', CAST(N'2000-12-01' AS Date), N'Nam', N'6523154', N'084088430132', N'xuxi@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (21, N'Thành Lợi', N'Q1 TP.HCM', CAST(N'2003-12-12' AS Date), N'Nam', N'0913123', N'0913123456', N'hung@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (22, N'Trần Hùng', N'Công ty TNHH Thành Lợi', CAST(N'2006-12-12' AS Date), N'Nam', N'0913123', N'0913123456', N'hung@gmail.com', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (24, N'Cty Minh Hưng', N'87 Trần Hưng Đạo', CAST(N'2000-12-12' AS Date), N'Nam', N'123', N'123', N'thao@ou.edu.vn', N'123')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (27, N'Trần Vinh Viễn', N'123 Tân Tấn', CAST(N'2000-12-11' AS Date), N'Nam', N'123', N'123', N'thao@ou.edu.vn', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (29, N'a', N'b', CAST(N'1999-12-02' AS Date), N'Nam', N'1232', N'123', N'a', N'a')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (30, N'Nguyễn Xuân', N'120 Ha Ton Quyen', CAST(N'2000-12-12' AS Date), N'Nam', N'8171717', N'084088171717', N'1851010123thao@ou.edu.vn', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (31, N'Trần Nhật Long', N'120 Ha Ton Quyen', CAST(N'2000-12-12' AS Date), N'Nam', N'8171717', N'084088171717', N'1851010123thao@ou.edu.vn', N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (43, N'Koko Company', N'90 An Duong Vuong', CAST(N'2000-12-08' AS Date), N'Nam', N'8250102', N'084083230156', N'bg@gmail.com', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (46, N'a', N'a', CAST(N'2000-12-03' AS Date), N'Nam', N'123', N'123', N'thao@ou.edu.vn', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (47, N'Bong Hong', N'24 Ky Cong', CAST(N'2000-12-11' AS Date), N'Nữ', N'8855421', N'084088800256', N'a@gmail.com', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (50, N'Nguyễn Xuân Thao', N'123 Tân Phú', CAST(N'1999-12-02' AS Date), N'Nam', N'12322', N'123', N'a', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (51, N'Nguyễn Xuân Thao', N'123 Tân Phú', CAST(N'1999-12-02' AS Date), N'Nam', N'12322', N'123', N'a', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [Fax], [Email], [Password]) VALUES (52, N'Bong Hong', N'24 Ky Cong', CAST(N'2000-12-11' AS Date), N'Nữ', N'8855421', N'084088800256', N'a@gmail.com.vn', NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (1, N'Áo thun')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (2, N'Áo Hoodie')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (3, N'Áo Sơ Mi')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (4, N'Túi sách')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (5, N'Quần')
SET IDENTITY_INSERT [dbo].[Nhanvien] ON 

INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (1, N'Trần Nhật Nong', N'35 Đào Tứ', N'1223456', N'1851010123thao@gmail.com.vn', N'12345a', 1, N'Nữ        ', CAST(N'1999-02-01' AS Date))
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (20, N'Trần Nhật Nong', N'35 Đào Tứ', N'1223456', N'b@gmail.com', N'b12345', 0, N'Nữ        ', CAST(N'1999-02-01' AS Date))
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (47, N'Nguyễn Xuân', N'Thao', N'1233532', N'a12312@gmail.com.vn', N'12345t', 1, N'Nam       ', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (58, N'Vương Gia', N'Phúc', N'1233532', N'a12312@gmail.com.vn', N'12122a', 1, N'Nam       ', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (59, N'Ma Hoàng', N'Nguyên', N'1635315', N'1851010123thao@gmail.com', N'12124v', 0, N'Nam       ', CAST(N'2021-10-02' AS Date))
SET IDENTITY_INSERT [dbo].[Nhanvien] OFF
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT01', N'Oldskull Dungz White', 455000, 1, N'images/AoThunTrang.jpg', 1, 0, 60, N'')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT02', N'Oldskull Gori Rocket', 399000, 1, N'images/AoThunXam.jpg', 1, 0, 308, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT03', N'Gori Season 3/ Xám', 225000, 1, N'images/AoThunXamNhat.jpg', 0, 0, 27, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT04', N'Oldskull Destroy', 199000, 1, N'images/AoThunDen.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT05', N'Oldskull Helmet/ Nâu', 250000, 1, N'images/AoThunNau.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT06', N'Gori Basic Tee / Kem', 255000, 1, N'images/AoThunNauNhat.jpg', 1, 0, 3029, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT07', N'Gori Season 03/ Xám', 179000, 1, N'images/AoThunXam2.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT08', N'Basic Tee/ Green', 225000, 1, N'images/AoThunXanhLa.jpg', 1, 0, 29, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT09', N'Oldskull Apparel', 299000, 1, N'images/AoThunCam.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT10', N'Áo Thun Navy', 150000, 1, N'images/aoutanimalnavy.jpg', 0, 0, 24, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT11', N'Áo Tandy Xám', 200000, 1, N'images/aoutandyxam.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT12', N'Áo Animal White', 300000, 1, N'images/aoutanimaltrang.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT14', N'Áo Marvel', 250000, 1, N'images/aoutmarvel.jpg', 0, 0, 25, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT15', N'Áo Peanut Be', 400000, 1, N'images/aoutpeanutbe.jpg', 0, 0, 29, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT16', N'Áo Monster', 230000, 1, N'images/aoutmonsterbe.jpg', 0, 0, 3030, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT17', N'Áo Brand', 200000, 1, N'images/aoutthebrandsden.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'AT20', N'Áo Zara Tím', 300000, 1, N'images/aozaratim.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD01', N'Hoodie With Mistake', 599000, 2, N'images/AoHoodieCam.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD02', N'Hoodie Life Gori', 555000, 2, N'images/AoHoodieXam.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD03', N'Hoodie Ss04/ Đen', 499000, 2, N'images/AoHoodieDen.jpg', 0, 0, 3030, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD04', N'Hoodie Washed Be', 250000, 2, N'images/0912hoodiewashedbe.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD05', N'Hoodie Washed Black', 200000, 2, N'images/0912hoodiewashedblack.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'HD06', N'Hoodie Washed', 300000, 2, N'images/0912logohoodiewashed.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q01', N'Quần Jean Black', 400000, 5, N'Images/curvejeanblackowst.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q02', N'Quần Jean Navy', 500000, 5, N'Images/jeanregularfitnavy.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q03', N'Quần Jean Blue', 300000, 5, N'Images/jeanslimfitblue.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q04', N'Quần Jogger', 200000, 5, N'Images/quanjoggerowstblack.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q05', N'Quần Short Navy', 150000, 5, N'Images/quandryshortnavy.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q06', N'Quần Short Gray', 170000, 5, N'Images/shortowstgray.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q07', N'Quần Jogger Gray', 200000, 5, N'Images/quanjoggerowstdarkgray.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q08', N'Quần Jean Lider', 250000, 5, N'Images/tomjeanlider.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q09', N'Quần Short Black', 150000, 5, N'Images/shortowstblack.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q10', N'Quần Jean Light Blue', 300000, 5, N'Images/unclejeanlider.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q11', N'Quần Jean Regular', 200000, 5, N'Images/quandeepsealider.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q12', N'Quần Dark Gray', 250000, 5, N'Images/quanjoggerowstdarkgray.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q13', N'Quần Short White', 150000, 5, N'Images/quanshortlidertrang.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q14', N'Quần Tây Orange', 300000, 5, N'Images/quantaybeuniqlo.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'Q15', N'Quần Tây Brown', 350000, 5, N'Images/quanlacvietowst.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM01', N'Flannel / Đỏ Mới', 400000, 3, N'images/AoSoMiCaRoDo.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM02', N'Flannel / Vàng Mới', 355000, 3, N'images/AoSoMiCaRoVang.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM03', N'Áo Sơ Mi Vàng', 200000, 3, N'images/aosomicarongantayvang.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM04', N'Áo Sơ Mi Trắng', 150000, 3, N'images/aosomicarongantaytrang.jpg', 0, 0, 303030, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM05', N'Áo Sơ Mi Xanh', 300000, 3, N'images/aopoloxanh.jpg', 0, 0, 29, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SM06', N'Áo Sơ Mi Xám', 200000, 3, N'images/aopolosocgray.jpg', 0, 0, 3030, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SP2940', N'Oldskull', 250000, 1, N'images/a8fe59603db2c3ec9aa3.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SP3056', N'Áo Animal Xanh', 250000, 1, NULL, 0, 0, 26, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'SP5562', N'a', 399000, 1, N'images/hinhnen.gif', 0, 0, 308, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'TS01', N'Gori Bag', 155000, 4, N'images/TuiKhongHoaTiet.jpg', 0, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'TS02', N'Túi Tote/ Rocket', 199000, 4, N'images/TuiHoaTietTrang.jpg', 1, 0, 30, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'TS03', N'Túi Tote/ Gori Brown', 250000, 4, N'images/TuiHoaTietCam.jpg', 0, 0, 28, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong], [GhiChu]) VALUES (N'TS04', N'Túi Tote/ Gori Black', 199000, 4, N'images/TuiHoaTietDen.jpg', 0, 0, 30, NULL)
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_DonHang]
GO
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_SanPham]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_Nhanvien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSanPhamDonHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_KiemTraSanPhamDonHang] @MaDH int,@MaSP nvarchar
as
begin
	set nocount on
	declare @sl int
	select @sl = count(*) from CTDH
	where MaDH=@MaDH and MaSP= @MaSP
	select @sl as alias
end
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[spLogin] 
@Email nvarchar(50),
@Password nvarchar(50)
As
Begin
 SET NOCOUNT ON
 Declare @status int
 IF EXISTS(Select * from Nhanvien Where Email=@Email AND [Password]=@Password)
 
 Set @status = 1
 
 Else 
 
 Set @status = 0
 
 Select @status as alias
End
GO
/****** Object:  Trigger [dbo].[trg_DatHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create trigger [dbo].[trg_DatHang] on [dbo].[CTDH] after insert
as
begin
	update [dbo].[SanPham]
	set [dbo].[SanPham].SoLuong = [dbo].[SanPham].SoLuong - (
		select Soluong
		from inserted 
		where MaSP = [dbo].[SanPham].MaSP
	)
	from [dbo].[SanPham]
	join inserted on [dbo].[SanPham].MaSP = inserted.MaSP
end

GO
/****** Object:  Trigger [dbo].[trg_HuyDatHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_HuyDatHang] on [dbo].[CTDH] for delete
as
begin
	update [dbo].[SanPham]
	set [dbo].[SanPham].SoLuong = [dbo].[SanPham].SoLuong + (
		select Soluong
		from deleted 
		where MaSP = [dbo].[SanPham].MaSP
	)
	from [dbo].[SanPham]
	join deleted on [dbo].[SanPham].MaSP = deleted.MaSP
end

GO
/****** Object:  Trigger [dbo].[trg_SuaDonHang]    Script Date: 10/2/2021 3:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_SuaDonHang] on [dbo].[CTDH] after update as
begin
   update [dbo].[SanPham] 
   set [dbo].[SanPham].SoLuong = [dbo].[SanPham].SoLuong -
	   (select Soluong from inserted where MaSP = [dbo].[SanPham].MaSP) +
	   (select Soluong from deleted where MaSP = [dbo].[SanPham].MaSP)
   from [dbo].[SanPham]
   join deleted on [dbo].[SanPham].MaSP = deleted.MaSP
end

GO
USE [master]
GO
ALTER DATABASE [quanlybanhang] SET  READ_WRITE 
GO
