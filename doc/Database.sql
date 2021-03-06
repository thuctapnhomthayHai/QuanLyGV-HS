USE [QLGV-HS]
create database QLGV_HS
GO
/****** Object:  Table [dbo].[GiangDay]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiangDay](
	[MaGV] [varchar](10) NOT NULL,
	[MaLop] [nvarchar](50) NULL,
	[Thu] [int] NULL,
	[Tiet] [int] NULL,
 CONSTRAINT [PK_GiangDay] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [varchar](20) NULL,
	[Luong] [int] NULL,
	[MaMon] [varchar](10) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [nvarchar](10) NOT NULL,
	[TenHS] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DanToc] [nvarchar](50) NULL,
	[MaLop] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaGV] [varchar](10) NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[Quyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[Quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/12/2018 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [varchar](20) NOT NULL,
	[PassWord] [varchar](20) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv01', N'lop01', 2, 3)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv02', N'lop01', 2, 1)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv03', N'lop02', 2, 1)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv04', N'lop02', 2, 4)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv05', N'lop03', 2, 1)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv06', N'lop01', 2, 2)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv07', N'lop02', 2, 3)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv08', N'lop04', 2, 4)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv09', N'lop05', 2, 5)
INSERT [dbo].[GiangDay] ([MaGV], [MaLop], [Thu], [Tiet]) VALUES (N'gv10', N'lop05', 2, 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv01', N'Nguyễn Văn Tính', N'Nam', CAST(N'1970-05-23' AS Date), N'01657222333', 50000000, N'mon01')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv02', N'Nguyễn Thị Tuyết', N'Nữ', CAST(N'1980-04-03' AS Date), N'01653987789', 55000000, N'mon02')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv03', N'Nguyễn Lan Hương', N'Nữ', CAST(N'1975-03-02' AS Date), N'09833289382', 45000000, N'mon03')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv04', N'Trần Văn Cường', N'Nam', CAST(N'1976-12-07' AS Date), N'09633232323', 70000000, N'mon04')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv05', N'Ngô Văn Lân', N'Nam', CAST(N'1985-11-30' AS Date), N'09793847387', 60000000, N'mon05')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv06', N'Hà Thị Minh Trang', N'Nữ', CAST(N'1986-10-23' AS Date), N'09823928392', 55000000, N'mon06')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv07', N'Đỗ Tùng Lâm', N'Nam', CAST(N'1977-10-23' AS Date), N'09639382938', 53000000, N'mon07')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv08', N'Nguyễn Mạnh Đức', N'Nam', CAST(N'1986-08-24' AS Date), N'09772858903', 45000000, N'mon08')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv09', N'Nguyễn Đức Mạnh', N'Nam', CAST(N'1985-02-02' AS Date), N'09122382938', 63000000, N'mon09')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [SDT], [Luong], [MaMon]) VALUES (N'gv10', N'Trần Văn Tú', N'Nam', CAST(N'1983-11-26' AS Date), N'09839283928', 80000000, N'mon10')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs01', N'Nguyễn Thành Long', N'Nam', CAST(N'1998-04-22' AS Date), N'Kinh', N'lop01')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs02', N'Trần Thị Huyền', N'Nữ', CAST(N'1997-03-23' AS Date), N'Kinh', N'lop01')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs03', N'Lương Lan Anh', N'Nữ', CAST(N'1998-08-09' AS Date), N'Kinh', N'lop01')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs04', N'Ngô Hoài Nam', N'Nam', CAST(N'1998-02-10' AS Date), N'Kinh', N'lop02')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs05', N'Trần Minh Đức', N'Nam', CAST(N'1998-06-01' AS Date), N'Thái', N'lop02')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs06', N'Chương Cẩm Vân', N'Nữ', CAST(N'1998-04-12' AS Date), N'Mường', N'lop02')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs07', N'Lại Mạnh Đức', N'Nam', CAST(N'1998-04-15' AS Date), N'Dao', N'lop03')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs08', N'Hoàng Trung Văn', N'Nam', CAST(N'1998-04-18' AS Date), N'Mông', N'lop03')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs09', N'Nguyễn Thế Tài', N'Nam', CAST(N'1998-02-17' AS Date), N'Kinh', N'lop03')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs10', N'Phạm Văn Tài', N'Nam', CAST(N'1998-05-18' AS Date), N'Kinh', N'lop04')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs11', N'Trần Thị Huyền Trang', N'Nữ', CAST(N'1998-11-12' AS Date), N'Kinh', N'lop04')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs12', N'Lê Hồ Bá Quang', N'Nam', CAST(N'1998-10-10' AS Date), N'Mường', N'lop04')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs13', N'Nguyễn Văn Dũng', N'Nam', CAST(N'1998-12-12' AS Date), N'Mường', N'lop05')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs14', N'Nguyễn Thị Huệ', N'Nữ', CAST(N'1998-10-09' AS Date), N'Kinh', N'lop05')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DanToc], [MaLop]) VALUES (N'hs15', N'Lương Văn Dân', N'Nam', CAST(N'1998-01-30' AS Date), N'Kinh', N'lop05')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop], [MaGV]) VALUES (N'lop01', N'10A1', N'gv01')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop], [MaGV]) VALUES (N'lop02', N'10A2', N'gv02')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop], [MaGV]) VALUES (N'lop03', N'11A1', N'gv03')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop], [MaGV]) VALUES (N'lop04', N'11A2', N'gv04')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop], [MaGV]) VALUES (N'lop05', N'12A1', N'gv05')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon01', N'Toán')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon02', N'Văn')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon03', N'Tiếng Anh')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon04', N'Vật lí')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon05', N'Hóa Học')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon06', N'Lịch Sử')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon07', N'Địa lý')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon08', N'Giáo dục công dân')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon09', N'Sinh học')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon]) VALUES (N'mon10', N'Tin học')
INSERT [dbo].[Quyen] ([Quyen], [TenQuyen]) VALUES (1, N'Giáo Viên')
INSERT [dbo].[Quyen] ([Quyen], [TenQuyen]) VALUES (2, N'Học Sinh')
INSERT [dbo].[User] ([UserName], [PassWord], [Quyen]) VALUES (N'GV01', N'123456', 1)
INSERT [dbo].[User] ([UserName], [PassWord], [Quyen]) VALUES (N'GV02', N'123456', 1)
INSERT [dbo].[User] ([UserName], [PassWord], [Quyen]) VALUES (N'HS01', N'123456', 2)
INSERT [dbo].[User] ([UserName], [PassWord], [Quyen]) VALUES (N'HS02', N'123456', 2)
ALTER TABLE [dbo].[GiangDay]  WITH CHECK ADD  CONSTRAINT [FK_GiangDay_LopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[GiangDay] CHECK CONSTRAINT [FK_GiangDay_LopHoc]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_LopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_LopHoc]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_GiaoVien]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Quyen1] FOREIGN KEY([Quyen])
REFERENCES [dbo].[Quyen] ([Quyen])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Quyen1]
GO
