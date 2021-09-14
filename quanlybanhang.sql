USE [master]
GO
/****** Object:  Database [quanlybanhang]    Script Date: 9/14/2021 8:59:24 PM ******/
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
/****** Object:  User [XUANTHAO\pc]    Script Date: 9/14/2021 8:59:24 PM ******/
CREATE USER [XUANTHAO\pc] FOR LOGIN [XUANTHAO\pc] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CTDH]    Script Date: 9/14/2021 8:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDH](
	[MaDH] [int] NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[DonHang]    Script Date: 9/14/2021 8:59:25 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/14/2021 8:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DienThoai] [nvarchar](7) NULL,
	[Fax] [nvarchar](12) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 9/14/2021 8:59:25 PM ******/
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
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 9/14/2021 8:59:25 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 9/14/2021 8:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[MaLoaiSP] [int] NULL,
	[HinhSP] [nvarchar](max) NULL,
	[DangGiamGia] [bit] NULL,
	[MaGiamGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (22, N'AT01', 4, N'M         ', 1820000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (23, N'AT01', 2, N'M         ', 910000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (23, N'AT02', 1, N'L         ', 399000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (24, N'AT01', 1, N'L         ', 455000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (25, N'AT01', 1, N'XL        ', 455000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (32, N'Q05', 1, N'XL        ', 150000, NULL)
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [Soluong], [Size], [ThanhTien], [Giamgia]) VALUES (32, N'Q06', 1, N'L         ', 170000, NULL)
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (22, 29, 1, CAST(N'2021-09-05 13:43:24.533' AS DateTime), NULL, N'b                                                 ', NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (23, 29, 1, CAST(N'2021-09-05 17:28:52.350' AS DateTime), NULL, N'b                                                 ', NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (24, 29, 1, CAST(N'2021-09-05 17:32:41.217' AS DateTime), NULL, N'b                                                 ', NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (25, 29, 1, CAST(N'2021-09-05 17:34:19.830' AS DateTime), NULL, N'b                                                 ', NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang], [DiaChiGiaoHang], [GhiChu]) VALUES (32, 29, 1, CAST(N'2021-09-08 21:38:46.027' AS DateTime), NULL, N'b                                                 ', NULL)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (1, N'Nguyễn Xuân Thao', N'120 Ha Ton Quyen', N'Nam', N'8171717', N'084088171717', N'1851010123thao@ou.edu.vn', N'1', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (2, N'Bong Hong', N'24 Ky Con', N'Nữ', N'', N'084088800256', N'c', N'c', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (3, N'Em Anh', N'6 Ky Hoa', N'Nữ', N'', N'084088852258', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (4, N'Ho Han', N'8 Pham van Khoe', N'Nữ', N'8430156', N'084088430156', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (5, N'Koko Company', N'90 An Duong Vuong', N'Nam', N'8250102', N'', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (6, N'Queen Cozinha', N'891 An Duong Vuong', N'Nam', N'', N'', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (7, N'Quoc Cuong', N'10 Tan Da', N'Nam', N'8950203', N'', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (8, N'Suoi Tra', N'2817 Minh Phung', N'Nữ', N'8356210', N'084088356210', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (9, N'Song Trang', N'187 Lao Tu', N'Nam', N'9450210', N'', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (10, N'Vinh Vien', N'45 Su Van hanh', N'Nam', N'', N'084088654790', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (11, N'Trần Vinh Viễn', N'87 Trần Hưng Đạo', N'Nam', N'8855464', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (12, N'Lý Văn Trung', N'123 Tân Tấn', N'Nam', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (13, N' Minh Hưng', N'456 Công Hòa', N'Nam', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (14, N'Nghia Đình', N'12 Lý chính Thắng', N'Nam', N'9874564', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (15, N'Minh Anh', N'15/1 Hữu Giang', N'Nam', N'6548797', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (16, N'Trần Tùng', N'12/15 Hậu Nghia', N'Nam', N'6547898', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (17, N'Vinh Lợi', N'1812 Trần Quang Khải', N'Nam', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (18, N'Bình Duong', N'145 Nguyễn Hiền', N'Nam', N'6548797', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (19, N'Thần Tài', N'14 Lê Lợi', N'Nam', N'6523154', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (20, N'Trần Văn Trị', N'45 Nguyễn Thị Minh Khai', N'Nam', N'4561234', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (21, N'Thành Lợi', N'Q1 TP.HCM', N'Nam', N'0913123', N'0913123456', N'hung@gmail.com', NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (22, N'Trần Hùng', N'Công ty TNHH Thành Lợi', N'Nam', N'0913123', N'0913123456', N'hung@gmail.com', NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (23, N'aaa', N'aaa', N'Nam', N'0913123', N'0913123456', N'hung@gmail.com', NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (24, N'Cty Minh Hưng', N'87 Trần Hưng Đạo', N'Nam', N'123', N'123', N'thao@ou.edu.vn', N'123', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (25, N'a', N'a', N'Nam', N'123', N'123', N'thao@ou.edu.vn', N'21', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (27, N'Trần Vinh Viễn', N'123 Tân Tấn', N'Nam', N'123', N'123', N'thao@ou.edu.vn', N'1', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [GioiTinh], [DienThoai], [Fax], [Email], [Password], [NgaySinh]) VALUES (29, N'a', N'b', N'Nam', N'123', N'123', N'a', N'a', NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (1, N'Áo thun')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (2, N'Áo Hoodie')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (3, N'Áo Sơ Mi')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (4, N'Túi sách')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (5, N'Quần')
SET IDENTITY_INSERT [dbo].[Nhanvien] ON 

INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (1, N'Nguyễn Xuân ', N'45 Trần Phú', N'8663447', N'1851010123thao@gmail.com.vn', N'1         ', 1, NULL, NULL)
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (20, N'Trần Nhật', N'35 Đào Tứ', N'1223456', N'b', N'b', 1, NULL, NULL)
INSERT [dbo].[Nhanvien] ([MaNV], [HoTenNV], [Diachi], [Dienthoai], [Email], [Password], [Admin], [GioiTinh], [NgaySinh]) VALUES (21, N'a', N'a', N'1', N'123', N'1', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Nhanvien] OFF
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT01', N'Oldskull Dungz White', 455000, 1, N'images/AoThunTrang.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT02', N'Oldskull Gori Rocket', 399000, 1, N'images/AoThunXam.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT03', N'Gori Season 3/ Xám', 225000, 1, N'images/AoThunXamNhat.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT04', N'Oldskull Destroy', 199000, 1, N'images/AoThunDen.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT05', N'Oldskull Helmet/ Nâu', 250000, 1, N'images/AoThunNau.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT06', N'Gori Basic Tee / Kem', 255000, 1, N'images/AoThunNauNhat.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT07', N'Gori Season 03/ Xám', 179000, 1, N'images/AoThunXam2.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT08', N'Basic Tee/ Green', 225000, 1, N'images/AoThunXanhLa.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT09', N'Oldskull Apparel', 299000, 1, N'images/AoThunCam.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT10', N'Áo Thun Navy', 150000, 1, N'images/aoutanimalnavy.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT11', N'Áo Tandy Xám', 200000, 1, N'images/aoutandyxam.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT12', N'Áo Animal White', 300000, 1, N'images/aoutanimaltrang.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT13', N'Áo Animal Xanh', 250000, 1, N'images/aoutanimalxanh.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT14', N'Áo Marvel', 250000, 1, N'images/aoutmarvel.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT15', N'Áo Peanut Be', 400000, 1, N'images/aoutpeanutbe.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT16', N'Áo Monster', 230000, 1, N'images/aoutmonsterbe.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT17', N'Áo Brand', 200000, 1, N'images/aoutthebrandsden.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'AT20', N'Áo Zara Tím', 300000, 1, N'images/aozaratim.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD01', N'Hoodie With Mistake', 599000, 2, N'images/AoHoodieCam.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD02', N'Hoodie Life Gori', 555000, 2, N'images/AoHoodieXam.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD03', N'Hoodie Ss04/ Đen', 499000, 2, N'images/AoHoodieDen.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD04', N'Hoodie Washed Be', 250000, 2, N'images/0912hoodiewashedbe.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD05', N'Hoodie Washed Black', 200000, 2, N'images/0912hoodiewashedblack.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'HD06', N'Hoodie Washed', 300000, 2, N'images/0912logohoodiewashed.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q01', N'Quần Jean Black', 400000, 5, N'Images/curvejeanblackowst.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q02', N'Quần Jean Navy', 500000, 5, N'Images/jeanregularfitnavy.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q03', N'Quần Jean Blue', 300000, 5, N'Images/jeanslimfitblue.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q04', N'Quần Jogger', 200000, 5, N'Images/quanjoggerowstblack.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q05', N'Quần Short Navy', 150000, 5, N'Images/quandryshortnavy.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q06', N'Quần Short Gray', 170000, 5, N'Images/shortowstgray.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q07', N'Quần Jogger Gray', 200000, 5, N'Images/quanjoggerowstdarkgray.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q08', N'Quần Jean Lider', 250000, 5, N'Images/tomjeanlider.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q09', N'Quần Short Black', 150000, 5, N'Images/shortowstblack.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q10', N'Quần Jean Light Blue', 300000, 5, N'Images/unclejeanlider.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q11', N'Quần Jean Regular', 200000, 5, N'Images/quandeepsealider.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q12', N'Quần Dark Gray', 250000, 5, N'Images/quanjoggerowstdarkgray.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q13', N'Quần Short White', 150000, 5, N'Images/quanshortlidertrang.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q14', N'Quần Tây Orange', 300000, 5, N'Images/quantaybeuniqlo.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'Q15', N'Quần Tây Brown', 350000, 5, N'Images/quanlacvietowst.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM01', N'Flannel / Đỏ Mới', 400000, 3, N'images/AoSoMiCaRoDo.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM02', N'Flannel / Vàng Mới', 355000, 3, N'images/AoSoMiCaRoVang.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM03', N'Áo Sơ Mi Vàng', 200000, 3, N'images/aosomicarongantayvang.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM04', N'Áo Sơ Mi Trắng', 150000, 3, N'images/aosomicarongantaytrang.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM05', N'Áo Sơ Mi Xanh', 300000, 3, N'images/aopoloxanh.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM06', N'Áo Sơ Mi Xám', 200000, 3, N'images/aopolosocgray.jpg', NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'SM07', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'TS01', N'Gori Bag', 155000, 4, N'images/TuiKhongHoaTiet.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'TS02', N'Túi Tote/ Rocket', 199000, 4, N'images/TuiHoaTietTrang.jpg', 1, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'TS03', N'Túi Tote/ Gori Brown', 250000, 4, N'images/TuiHoaTietCam.jpg', 0, NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [HinhSP], [DangGiamGia], [MaGiamGia], [SoLuong]) VALUES (N'TS04', N'Túi Tote/ Gori Black', 199000, 4, N'images/TuiHoaTietDen.jpg', 0, NULL, NULL)
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
USE [master]
GO
ALTER DATABASE [quanlybanhang] SET  READ_WRITE 
GO
