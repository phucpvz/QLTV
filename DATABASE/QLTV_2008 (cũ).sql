USE [QLTV_UPDATE]
GO
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[MaSach] [int] NOT NULL,
	[MaNCC] [varchar](10) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
 CONSTRAINT [PK_ChiTietSachNhap] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[MaPhieuMuon] [varchar](10) NOT NULL,
	[MaSach] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuTra]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuTra](
	[MaPhieuTra] [varchar](10) NOT NULL,
	[MaSach] [int] NOT NULL,
	[MaPhieuMuon] [varchar](10) NOT NULL,
	[SoTienPhat] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChiTietPhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietThanhLy]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietThanhLy](
	[MaSach] [int] NOT NULL,
	[MaNhaThanhLy] [varchar](10) NOT NULL,
	[NgayThanhLy] [datetime] NOT NULL,
 CONSTRAINT [PK_ChiTietThanhLy] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Danhgiathuvien]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Danhgiathuvien](
	[MaDG] [varchar](10) NOT NULL,
	[Diem] [int] NOT NULL,
	[NoiDung] [nvarchar](200) NOT NULL,
	[NgayDanhGia] [datetime] NOT NULL,
 CONSTRAINT [PK_Danhgiathuvien] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC,
	[NgayDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MSSV] [varchar](20) NOT NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoiTac]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoiTac](
	[MaDoiTac] [varchar](10) NOT NULL,
	[TenDoiTac] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[MoTa] [nvarchar](100) NULL,
	[LaNhaXuatBan] [bit] NOT NULL,
	[LaNhaCungCap] [bit] NOT NULL,
	[LaNhaThanhLy] [bit] NOT NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaDoiTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KeSach]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KeSach](
	[MaKe] [varchar](10) NOT NULL,
	[TenKe] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[MaKhu] [varchar](10) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_KeSach] PRIMARY KEY CLUSTERED 
(
	[MaKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [varchar](10) NOT NULL,
	[TenKho] [nvarchar](50) NOT NULL,
	[ViTri] [nvarchar](100) NULL,
	[MoTa] [nvarchar](100) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khu]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khu](
	[MaKhu] [varchar](10) NOT NULL,
	[TenKhu] [nvarchar](50) NOT NULL,
	[ViTri] [nvarchar](100) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_Khu] PRIMARY KEY CLUSTERED 
(
	[MaKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiNV](
	[MaLoaiNV] [varchar](10) NOT NULL,
	[TenLoaiNV] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[CCCD] [varchar](13) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[MaLoaiNV] [varchar](10) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPhieuMuon] [varchar](10) NOT NULL,
	[MaTheDocGia] [varchar](10) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[NgayHenTra] [datetime] NOT NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_PhieuMuon_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuTra]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuTra](
	[MaPhieuTra] [varchar](10) NOT NULL,
	[MaTheDG] [varchar](10) NULL,
	[NgayTra] [datetime] NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_PhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[MaISBN] [varchar](25) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SachTrenKe]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SachTrenKe](
	[MaSach] [int] NOT NULL,
	[MaKe] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SachTrenKe] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SachTrongKho]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SachTrongKho](
	[MaSach] [int] NOT NULL,
	[MaKho] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SachTrongKho] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[NgayMat] [date] NULL,
	[QueQuan] [nvarchar](100) NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoanDG]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanDG](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[MaDG] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoanNV]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanNV](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TaiKhoanNV] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheDocGia]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheDocGia](
	[MaTheDG] [varchar](10) NOT NULL,
	[MaDG] [varchar](10) NOT NULL,
	[NgayLapThe] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
	[SoLuongMuonToiDa] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_TheDocGia] PRIMARY KEY CLUSTERED 
(
	[MaTheDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](30) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TuaSach](
	[MaISBN] [varchar](25) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[MaTheLoai] [varchar](10) NOT NULL,
	[MaNXB] [varchar](10) NOT NULL,
	[NgayXuatBan] [datetime] NULL,
	[SoTrang] [int] NULL,
	[ChieuDai] [int] NULL,
	[ChieuRong] [int] NULL,
	[ChatLieuGiay] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](200) NULL,
	[MoTa] [nvarchar](1000) NULL,
	[GiaTien] [int] NOT NULL,
	[MaTacGia] [varchar](10) NULL,
 CONSTRAINT [PK_TuaSach] PRIMARY KEY CLUSTERED 
(
	[MaISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietNhap] ([MaSach], [MaNCC], [NgayNhap]) VALUES (1, N'DT001', CAST(N'2022-01-05 00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietNhap] ([MaSach], [MaNCC], [NgayNhap]) VALUES (3, N'DT001', CAST(N'2022-01-05 00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietNhap] ([MaSach], [MaNCC], [NgayNhap]) VALUES (4, N'DT001', CAST(N'2022-01-06 00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([MaPhieuMuon], [MaSach], [TrangThai]) VALUES (N'PM001', 2, 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaPhieuMuon], [MaSach], [TrangThai]) VALUES (N'PM01', 1, 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaPhieuMuon], [MaSach], [TrangThai]) VALUES (N'PM02', 1, 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaPhieuMuon], [MaSach], [TrangThai]) VALUES (N'PM02', 3, 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaPhieuMuon], [MaSach], [TrangThai]) VALUES (N'PM03', 4, 1)
INSERT [dbo].[ChiTietThanhLy] ([MaSach], [MaNhaThanhLy], [NgayThanhLy]) VALUES (1, N'DT003', CAST(N'2022-01-06 02:51:19.247' AS DateTime))
INSERT [dbo].[Danhgiathuvien] ([MaDG], [Diem], [NoiDung], [NgayDanhGia]) VALUES (N'DG01', 3, N'', CAST(N'2022-01-07 11:27:28.217' AS DateTime))
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG002', N'Nguyễn Thị Trà', N'My', N'N19DCCN092', N'0921020293', N'tramy2k1@yahoo.com')
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG01', N'Phạm Đức Phú', N'Phúc', N'N18DCCN154', N'0923123456', N'phuc@email.com')
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG02', N'Nguyễn Văn', N'Nhất', N'N18DCCN165', N'0987678767', N'nhat@gmail.com')
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG03', N'Huỳnh Phước ', N'Sang', N'N18DCCN171', N'0933545121', N'sang@gmail.com')
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG04', N'Nguyễn Thị Huyền ', N'Dịu', N'N18DCCN027', N'0989900009', N'diu@email.com')
INSERT [dbo].[DocGia] ([MaDG], [Ho], [Ten], [MSSV], [SDT], [Email]) VALUES (N'DG05', N'Trương Minh', N'Tân', N'N18DCCN183', N'0987675436', N'tan@email.com')
INSERT [dbo].[DoiTac] ([MaDoiTac], [TenDoiTac], [DiaChi], [SDT], [Email], [MoTa], [LaNhaXuatBan], [LaNhaCungCap], [LaNhaThanhLy]) VALUES (N'DT001', N'Nhà xuất bản Kim Đồng', N'TP. HCM', N'0620110234', N'kimdong@gmail.com', N'Nhà xuất bản truyện tranh và sách cho thiếu nhi', 1, 1, 0)
INSERT [dbo].[DoiTac] ([MaDoiTac], [TenDoiTac], [DiaChi], [SDT], [Email], [MoTa], [LaNhaXuatBan], [LaNhaCungCap], [LaNhaThanhLy]) VALUES (N'DT002', N'Nhà xuất bản giáo dục Việt Nam', N'Hà Nội', N'0123456789', N'', N'', 1, 0, 1)
INSERT [dbo].[DoiTac] ([MaDoiTac], [TenDoiTac], [DiaChi], [SDT], [Email], [MoTa], [LaNhaXuatBan], [LaNhaCungCap], [LaNhaThanhLy]) VALUES (N'DT003', N'Công Ty ABC', N'Đà Nẵng', N'0934839922', N'', N'', 0, 1, 1)
INSERT [dbo].[KeSach] ([MaKe], [TenKe], [MoTa], [MaKhu], [TrangThai]) VALUES (N'A1', N'Kệ A1', NULL, N'A', 1)
INSERT [dbo].[KeSach] ([MaKe], [TenKe], [MoTa], [MaKhu], [TrangThai]) VALUES (N'A2', N'Kệ A2', NULL, N'A', 1)
INSERT [dbo].[KeSach] ([MaKe], [TenKe], [MoTa], [MaKhu], [TrangThai]) VALUES (N'A3', N'Kệ A3', N'', N'A', 1)
INSERT [dbo].[Kho] ([MaKho], [TenKho], [ViTri], [MoTa], [TrangThai]) VALUES (N'KH001', N'Kho 1', N'', N'Kho chứa sách giáo khoa', 1)
INSERT [dbo].[Kho] ([MaKho], [TenKho], [ViTri], [MoTa], [TrangThai]) VALUES (N'KH002', N'Kho 2', N'', N'Kho chứa truyện tranh', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [ViTri], [TrangThai]) VALUES (N'A', N'Sách giáo khoa', N'Tầng 1', 1)
INSERT [dbo].[Khu] ([MaKhu], [TenKhu], [ViTri], [TrangThai]) VALUES (N'B', N'Truyện tranh', N'Tầng 2', 1)
INSERT [dbo].[LoaiNV] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'QLDG', N'Quản lý độc giả')
INSERT [dbo].[LoaiNV] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'TK', N'Thủ kho')
INSERT [dbo].[LoaiNV] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'TT', N'Thủ thư')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [CCCD], [NgaySinh], [QueQuan], [SDT], [Email], [MaLoaiNV], [TrangThai]) VALUES (N'online', N'online', N'online', N'000000000', CAST(N'2016-01-01' AS Date), NULL, NULL, NULL, N'TT', 1)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [CCCD], [NgaySinh], [QueQuan], [SDT], [Email], [MaLoaiNV], [TrangThai]) VALUES (N'QLDG01', N'Trần', N'Nam', N'0631230990243', CAST(N'2001-07-26' AS Date), N'TP.HCM', N'0620192834', NULL, N'QLDG', 1)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [CCCD], [NgaySinh], [QueQuan], [SDT], [Email], [MaLoaiNV], [TrangThai]) VALUES (N'TK01', N'Đặng Văn', N'Tuấn', N'0611023152111', CAST(N'1999-02-13' AS Date), N'Long An', N'0934123456', NULL, N'TK', 1)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [CCCD], [NgaySinh], [QueQuan], [SDT], [Email], [MaLoaiNV], [TrangThai]) VALUES (N'TT01', N'Nguyễn Thị Thanh', N'Hương', N'062000111222', CAST(N'2000-12-01' AS Date), N'Kiên Giang', N'0902092011', N'huongxinh@gmail.com', N'TT', 1)
INSERT [dbo].[PhieuMuon] ([MaPhieuMuon], [MaTheDocGia], [NgayMuon], [NgayHenTra], [MaNV]) VALUES (N'PM001', N'TH001', CAST(N'2022-01-07 00:00:00.000' AS DateTime), CAST(N'2022-01-31 00:00:00.000' AS DateTime), N'TT01')
INSERT [dbo].[PhieuMuon] ([MaPhieuMuon], [MaTheDocGia], [NgayMuon], [NgayHenTra], [MaNV]) VALUES (N'PM01', N'T001', CAST(N'2021-02-02 00:00:00.000' AS DateTime), CAST(N'2021-03-02 00:00:00.000' AS DateTime), N'online')
INSERT [dbo].[PhieuMuon] ([MaPhieuMuon], [MaTheDocGia], [NgayMuon], [NgayHenTra], [MaNV]) VALUES (N'PM02', N'T001', CAST(N'2021-04-04 00:00:00.000' AS DateTime), CAST(N'2021-05-04 00:00:00.000' AS DateTime), N'online')
INSERT [dbo].[PhieuMuon] ([MaPhieuMuon], [MaTheDocGia], [NgayMuon], [NgayHenTra], [MaNV]) VALUES (N'PM03', N'T004', CAST(N'2021-12-31 00:00:00.000' AS DateTime), CAST(N'2022-02-01 00:00:00.000' AS DateTime), N'online')
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MaSach], [MaISBN], [TrangThai]) VALUES (1, N'S01', 1)
INSERT [dbo].[Sach] ([MaSach], [MaISBN], [TrangThai]) VALUES (2, N'1234356789', 0)
INSERT [dbo].[Sach] ([MaSach], [MaISBN], [TrangThai]) VALUES (3, N'S02', 1)
INSERT [dbo].[Sach] ([MaSach], [MaISBN], [TrangThai]) VALUES (4, N'S03', 1)
SET IDENTITY_INSERT [dbo].[Sach] OFF
INSERT [dbo].[SachTrenKe] ([MaSach], [MaKe]) VALUES (2, N'A3')
INSERT [dbo].[SachTrenKe] ([MaSach], [MaKe]) VALUES (3, N'A3')
INSERT [dbo].[SachTrenKe] ([MaSach], [MaKe]) VALUES (4, N'A1')
INSERT [dbo].[TacGia] ([MaTacGia], [Ho], [Ten], [NgaySinh], [NgayMat], [QueQuan], [MoTa]) VALUES (N'TG001', N'Phạm Văn', N'Ất', NULL, NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [Ho], [Ten], [NgaySinh], [NgayMat], [QueQuan], [MoTa]) VALUES (N'TG002', N'Karl ', N'Marx', NULL, NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [Ho], [Ten], [NgaySinh], [NgayMat], [QueQuan], [MoTa]) VALUES (N'TG003', N'Huỳnh Văn', N'Mẫn', NULL, NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [Ho], [Ten], [NgaySinh], [NgayMat], [QueQuan], [MoTa]) VALUES (N'TG004', N'Fujiko', N'Pro', CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), N'Tokyo - Nhật Bản', N'')
INSERT [dbo].[TaiKhoanDG] ([TenDangNhap], [MatKhau], [MaDG]) VALUES (N'phuc', N'12345', N'DG01')
INSERT [dbo].[TaiKhoanNV] ([TenDangNhap], [MatKhau], [MaNV]) VALUES (N'qldg', N'qldg', N'QLDG01')
INSERT [dbo].[TaiKhoanNV] ([TenDangNhap], [MatKhau], [MaNV]) VALUES (N'tk', N'tk', N'TK01')
INSERT [dbo].[TaiKhoanNV] ([TenDangNhap], [MatKhau], [MaNV]) VALUES (N'tt', N'tt', N'TT01')
INSERT [dbo].[TheDocGia] ([MaTheDG], [MaDG], [NgayLapThe], [NgayHetHan], [SoLuongMuonToiDa], [TrangThai]) VALUES (N'T001', N'DG01', CAST(N'2020-02-02 00:00:00.000' AS DateTime), CAST(N'2023-05-14 00:00:00.000' AS DateTime), 10, 0)
INSERT [dbo].[TheDocGia] ([MaTheDG], [MaDG], [NgayLapThe], [NgayHetHan], [SoLuongMuonToiDa], [TrangThai]) VALUES (N'T002', N'DG02', CAST(N'2019-12-15 00:00:00.000' AS DateTime), CAST(N'2023-03-03 00:00:00.000' AS DateTime), 10, 0)
INSERT [dbo].[TheDocGia] ([MaTheDG], [MaDG], [NgayLapThe], [NgayHetHan], [SoLuongMuonToiDa], [TrangThai]) VALUES (N'T003', N'DG03', CAST(N'2021-03-02 00:00:00.000' AS DateTime), CAST(N'2024-05-05 00:00:00.000' AS DateTime), 10, 1)
INSERT [dbo].[TheDocGia] ([MaTheDG], [MaDG], [NgayLapThe], [NgayHetHan], [SoLuongMuonToiDa], [TrangThai]) VALUES (N'T004', N'DG01', CAST(N'2021-06-07 00:00:00.000' AS DateTime), CAST(N'2022-07-06 00:00:00.000' AS DateTime), 10, 1)
INSERT [dbo].[TheDocGia] ([MaTheDG], [MaDG], [NgayLapThe], [NgayHetHan], [SoLuongMuonToiDa], [TrangThai]) VALUES (N'TH001', N'DG002', CAST(N'2022-01-06 00:00:00.000' AS DateTime), CAST(N'2022-01-07 00:00:00.000' AS DateTime), 3, 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'SGK', N'Sách giáo khoa', N'Sách dạy học từ lớp 1 đến lớp 12')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'SKH', N'Sách khoa học', N'Sách nói về các hiện tượng khoa học kỳ thú')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL01', N'Giáo trình trình thuật', N'Giáo trình giảng dạy kỹ thuật')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL02', N'Văn học', N'Giáo trình văn học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL03', N'Kinh tế', N'Sách kinh tế')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TT', N'Truyện tranh', N'Truyện tranh dành cho thiếu nhi')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'1234356789', N'Doraemon - Cuộc chiến ở xứ sở robot (Truyện dài tập 23)', N'TT', N'DT001', CAST(N'2022-01-06 00:00:00.000' AS DateTime), 0, 0, 0, N'', N'doremon_cuoc_chien_o_xu_so_robot.png', N'', 0, N'TG004')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'3384392343', N'Doraemon - Truyện ngắn tập 33', N'TT', N'DT001', CAST(N'2022-01-05 00:00:00.000' AS DateTime), 0, 0, 0, N'', N'doremon_tap_33.png', N'', 0, N'TG004')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'92102103104', N'Giải tích 12', N'SGK', N'DT002', CAST(N'2022-01-01 00:00:00.000' AS DateTime), 200, 200, 100, N'', N'giai_tich_12.png', N'', 25000, N'TG001')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'9750261123', N'10 vạn câu hỏi vì sao - Các hiện tượng tự nhiên kỳ thú (Tái bản)', N'SKH', N'DT001', CAST(N'2000-01-15 00:00:00.000' AS DateTime), 200, 200, 100, N'Giấy trắng', N'10_van_cau_hoi_vi_sao_cac_hien_tuong_tu_nhien_ky_thu.png', N'', 30000, N'TG003')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'S01', N'Kỹ thuật lập trình', N'TL01', N'DT001', CAST(N'2014-02-02 00:00:00.000' AS DateTime), 55, 90, 35, N'Giấy nhám', NULL, N'Ðây là sách hay dành cho người nhập môn', 100000, N'TG001')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'S02', N'Kinh tế luận', N'TL03', N'DT001', CAST(N'2012-02-14 00:00:00.000' AS DateTime), 70, 50, 40, N'Giấy trơn', NULL, N'Ðây là sách dành cho kinh tế luận', 120000, N'TG002')
INSERT [dbo].[TuaSach] ([MaISBN], [TenSach], [MaTheLoai], [MaNXB], [NgayXuatBan], [SoTrang], [ChieuDai], [ChieuRong], [ChatLieuGiay], [HinhAnh], [MoTa], [GiaTien], [MaTacGia]) VALUES (N'S03', N'Lập trình hướng đối tượng', N'TL01', N'DT002', CAST(N'2017-03-05 00:00:00.000' AS DateTime), 46, 45, 30, N'Giấy nhám', NULL, N'Nhập môn hướng đối tượng cùng chuyên gia', 300000, N'TG003')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_MSSV]    Script Date: 1/7/2022 11:34:29 AM ******/
ALTER TABLE [dbo].[DocGia] ADD  CONSTRAINT [UQ_MSSV] UNIQUE NONCLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_MaNguoiDung]    Script Date: 1/7/2022 11:34:29 AM ******/
ALTER TABLE [dbo].[TaiKhoanDG] ADD  CONSTRAINT [UQ_MaNguoiDung] UNIQUE NONCLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_TaiKhoanNV]    Script Date: 1/7/2022 11:34:29 AM ******/
ALTER TABLE [dbo].[TaiKhoanNV] ADD  CONSTRAINT [UQ_TaiKhoanNV] UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_DoiTac] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[DoiTac] ([MaDoiTac])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_DoiTac]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSachNhap_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietSachNhap_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTra_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[ChiTietPhieuTra] CHECK CONSTRAINT [FK_ChiTietPhieuTra_PhieuMuon]
GO
ALTER TABLE [dbo].[ChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTra_PhieuTra] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PhieuTra] ([MaPhieuTra])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuTra] CHECK CONSTRAINT [FK_ChiTietPhieuTra_PhieuTra]
GO
ALTER TABLE [dbo].[ChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTra_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuTra] CHECK CONSTRAINT [FK_ChiTietPhieuTra_Sach]
GO
ALTER TABLE [dbo].[ChiTietThanhLy]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThanhLy_DoiTac] FOREIGN KEY([MaNhaThanhLy])
REFERENCES [dbo].[DoiTac] ([MaDoiTac])
GO
ALTER TABLE [dbo].[ChiTietThanhLy] CHECK CONSTRAINT [FK_ChiTietThanhLy_DoiTac]
GO
ALTER TABLE [dbo].[ChiTietThanhLy]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThanhLy_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietThanhLy] CHECK CONSTRAINT [FK_ChiTietThanhLy_Sach]
GO
ALTER TABLE [dbo].[Danhgiathuvien]  WITH CHECK ADD  CONSTRAINT [FK_Danhgiathuvien_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[Danhgiathuvien] CHECK CONSTRAINT [FK_Danhgiathuvien_DocGia]
GO
ALTER TABLE [dbo].[KeSach]  WITH CHECK ADD  CONSTRAINT [FK_KeSach_Khu] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[Khu] ([MaKhu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KeSach] CHECK CONSTRAINT [FK_KeSach_Khu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_VaiTro] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNV] ([MaLoaiNV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_VaiTro]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_NhanVien]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_TheDocGia] FOREIGN KEY([MaTheDocGia])
REFERENCES [dbo].[TheDocGia] ([MaTheDG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_TheDocGia]
GO
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_NhanVien]
GO
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_TheDocGia] FOREIGN KEY([MaTheDG])
REFERENCES [dbo].[TheDocGia] ([MaTheDG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_TheDocGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TuaSach] FOREIGN KEY([MaISBN])
REFERENCES [dbo].[TuaSach] ([MaISBN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TuaSach]
GO
ALTER TABLE [dbo].[SachTrenKe]  WITH CHECK ADD  CONSTRAINT [FK_SachTrenKe_KeSach] FOREIGN KEY([MaKe])
REFERENCES [dbo].[KeSach] ([MaKe])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SachTrenKe] CHECK CONSTRAINT [FK_SachTrenKe_KeSach]
GO
ALTER TABLE [dbo].[SachTrenKe]  WITH CHECK ADD  CONSTRAINT [FK_SachTrenKe_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SachTrenKe] CHECK CONSTRAINT [FK_SachTrenKe_Sach]
GO
ALTER TABLE [dbo].[SachTrongKho]  WITH CHECK ADD  CONSTRAINT [FK_SachTrongKho_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SachTrongKho] CHECK CONSTRAINT [FK_SachTrongKho_Kho]
GO
ALTER TABLE [dbo].[SachTrongKho]  WITH CHECK ADD  CONSTRAINT [FK_SachTrongKho_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SachTrongKho] CHECK CONSTRAINT [FK_SachTrongKho_Sach]
GO
ALTER TABLE [dbo].[TaiKhoanDG]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoanDG] CHECK CONSTRAINT [FK_TaiKhoan_DocGia]
GO
ALTER TABLE [dbo].[TaiKhoanNV]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNV_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoanNV] CHECK CONSTRAINT [FK_TaiKhoanNV_NhanVien]
GO
ALTER TABLE [dbo].[TheDocGia]  WITH CHECK ADD  CONSTRAINT [FK_TheDocGia_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TheDocGia] CHECK CONSTRAINT [FK_TheDocGia_DocGia]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_DoiTac] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[DoiTac] ([MaDoiTac])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_DoiTac]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_TacGia]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_TheLoai]
GO
/****** Object:  StoredProcedure [dbo].[INSERT_REVIEW]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[INSERT_REVIEW]
@Madocgia varchar(10),
@diem int, 
@noidung nvarchar(200)
as
BEGIN
Insert into Danhgiathuvien values(@Madocgia,@diem,@noidung,GETDATE())
END

GO
/****** Object:  StoredProcedure [dbo].[LOAD_LIST_BOOK_BORROW]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LOAD_LIST_BOOK_BORROW]
@madocgia varchar(10)
as
BEGIN
	SELECT C.MaSach,TS.MaISBN, TS.TenSach,TS.SoTrang,P.NgayMuon FROM (SELECT * FROM TheDocGia WHERE TheDocGia.MaDG = @madocgia) T 
	left join PhieuMuon P on T.MaTheDG = P.MaTheDocGia
	left join ChiTietPhieuMuon C on C.MaPhieuMuon = P.MaPhieuMuon
	left join Sach S on C.MaSach = S.MaSach
	left join TuaSach TS on S.MaISBN = TS.MaISBN
END

GO
/****** Object:  StoredProcedure [dbo].[LOAD_READER_INFO]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LOAD_READER_INFO]
@Madocgia nvarchar(10)
as
BEGIN
	select D.MaDG,D.MSSV,D.Ho + ' '+D.Ten as 'Ho ten', D.SDT, D.Email,T.MatKhau from (Select * from DocGia where DocGia.MaDG = @Madocgia) D
	left join TaiKhoanDG T
	on D.MaDG = T.MaDG
END

GO
/****** Object:  StoredProcedure [dbo].[REPORT_READER_CARD]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORT_READER_CARD]
@start int,
@end int
as
BEGIN
select T.MaTheDG,D.MaDG, D.Ho + ' ' + D.Ten,D.MSSV,D.Email,D.SDT, T.TrangThai 
from 
(Select * from TheDocGia where YEAR(TheDocGia.NgayLapThe) >= @start and YEAR(TheDocGia.NgayLapThe)<=@end) T 
left join   DocGia D on T.MaDG = D.MaDG 
END

GO
/****** Object:  StoredProcedure [dbo].[REPORT_REGISTER_READER_CARD]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORT_REGISTER_READER_CARD]
@start int,
@end int
as
BEGIN
select T.MaTheDG,D.MaDG, D.Ho + ' ' + D.Ten,D.MSSV,T.NgayLapThe,T.TrangThai
from 
(Select * from TheDocGia where YEAR(TheDocGia.NgayLapThe) >= @start and YEAR(TheDocGia.NgayLapThe)<=@end) T 
left join   DocGia D on T.MaDG = D.MaDG 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LIST_BOOK]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GET_LIST_BOOK]
AS
BEGIN
SELECT T.MaISBN, T.TenSach,T.MoTa,T.NgayXuatBan,T.SoTrang,Ta.Ho+' ' + Ta.Ten as 'Tac gia',D.TenDoiTac FROM TuaSach T
left join TacGia Ta on T.MaTacGia =  Ta.MaTacGia
left join DoiTac D on D.MaDoiTac = T.MaNXB
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_READER_INFO]    Script Date: 1/7/2022 11:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_READER_INFO]
@Madocgia varchar(10),
@sdt varchar(10),
@email varchar(50),
@matkhau varchar(50)
as
BEGIN
update DocGia set SDT = @sdt,Email = @email where MaDG = @Madocgia
update TaiKhoanDG set MatKhau = @matkhau where MaDG = @Madocgia
END

GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
