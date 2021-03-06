USE [QLTT]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[MaSV] [nvarchar](50) NOT NULL,
	[Diem] [nvarchar](50) NULL,
	[TenLHTT] [nvarchar](50) NULL,
	[LanThucTap] [nvarchar](50) NOT NULL,
	[ThoiGianTT] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[LanThucTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoMon]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoMon](
	[MaBM] [nvarchar](50) NOT NULL,
	[TenBM] [nvarchar](50) NULL,
 CONSTRAINT [PK_BoMon] PRIMARY KEY CLUSTERED 
(
	[MaBM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [nvarchar](50) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[GioiTinhGV] [nvarchar](50) NULL,
	[NgaySinhGV] [date] NULL,
	[SDTGV] [nvarchar](50) NULL,
	[EmailGV] [nvarchar](50) NULL,
	[DiaChiGV] [nvarchar](50) NULL,
	[MaBM] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoa] [nvarchar](50) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [nvarchar](50) NULL,
	[MaKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTT]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTT](
	[MaNhom] [nvarchar](50) NOT NULL,
	[LichTT] [date] NULL,
	[MaGV] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomTT] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/1/2022 8:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](50) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[MaLop] [nvarchar](50) NULL,
	[MaNhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (N'1', N'CNTT')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (N'2', N'CNTT')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (N'3', N'CNTT')
GO
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NgaySinhGV], [SDTGV], [EmailGV], [DiaChiGV], [MaBM]) VALUES (N'1', N'GVA', N'Nam', CAST(N'1990-12-12' AS Date), N'12312312', N'adasdasd', N'huế', N'1')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NgaySinhGV], [SDTGV], [EmailGV], [DiaChiGV], [MaBM]) VALUES (N'2', N'GVB', N'Nữ', CAST(N'2021-12-02' AS Date), N'23213123', N'zcxzc', N'huế', N'2')
GO
INSERT [dbo].[KhoaHoc] ([MaKhoa], [TenKhoa]) VALUES (N'1', N'Công nghệ phầm mềm')
INSERT [dbo].[KhoaHoc] ([MaKhoa], [TenKhoa]) VALUES (N'2', N'Mạng viễn thông')
INSERT [dbo].[KhoaHoc] ([MaKhoa], [TenKhoa]) VALUES (N'3', N'Khoa học máy tính')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoa]) VALUES (N'1', N'Lop1', N'20', N'1')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoa]) VALUES (N'2', N'Lop2', N'20', N'3')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoa]) VALUES (N'3', N'Lop3', N'20', N'2')
GO
INSERT [dbo].[NhomTT] ([MaNhom], [LichTT], [MaGV]) VALUES (N'1', CAST(N'2022-10-01' AS Date), N'1')
INSERT [dbo].[NhomTT] ([MaNhom], [LichTT], [MaGV]) VALUES (N'2', CAST(N'2022-10-01' AS Date), N'2')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [NoiSinh], [DiaChi], [SDT], [GioiTinh], [Email], [MaLop], [MaNhom]) VALUES (N'1001', N'Nguyễn Kim Ngàn ', CAST(N'2000-12-04' AS Date), N'Huế', N'Huế', N'0123456789', N'Nam', N'ngan124@gmail.com', N'1', N'1')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [NoiSinh], [DiaChi], [SDT], [GioiTinh], [Email], [MaLop], [MaNhom]) VALUES (N'1002', N'Trần Văn Hải Dương', CAST(N'2000-03-08' AS Date), N'Huế', N'Huế', N'0123213313', N'Nam', N'Duong@gmail.com', N'2', N'1')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [NoiSinh], [DiaChi], [SDT], [GioiTinh], [Email], [MaLop], [MaNhom]) VALUES (N'1003', N'Lê Nguyên Trí', CAST(N'2000-02-08' AS Date), N'Huế', N'Huế', N'0132312312', N'Nam', N'Tri@gmail.com', N'3', N'1')
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_SinhVien]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_BoMon] FOREIGN KEY([MaBM])
REFERENCES [dbo].[BoMon] ([MaBM])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_BoMon]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoaHoc] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[KhoaHoc] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoaHoc]
GO
ALTER TABLE [dbo].[NhomTT]  WITH CHECK ADD  CONSTRAINT [FK_NhomTT_GiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[NhomTT] CHECK CONSTRAINT [FK_NhomTT_GiangVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_NhomTT] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomTT] ([MaNhom])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_NhomTT]
GO
