--Create database [qlsp_8_DTTHangNTHai]
USE [qlsp_8_DTTHangNTHai]
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 9/8/2021 11:30:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NULL,
	[fullname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[mod] [int] NULL,
	[state] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 9/8/2021 11:30:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[manhacc] [int] IDENTITY(1,1) NOT NULL,
	[tennhacc] [nvarchar](50) NULL,
	[emailnhacc] [nvarchar](40) NULL,
	[dienthoai] [nvarchar](30) NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[manhacc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 9/8/2021 11:30:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanpham](
	[masp] [int] IDENTITY(1,1) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[thanhtien] [float] NULL,
	[hangsp] [nvarchar](50) NULL,
	[manhacc] [int] NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'admin', N'1', N'administration', N'adminnistration@gmail.com', 1, N'active              ')
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'block', N'1', N'block', N'block@gmail.com', 1, N'deactive            ')
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'user', N'1', N'user', N'user@gmail.com', 0, N'active              ')
GO
SET IDENTITY_INSERT [dbo].[nhacungcap] ON 

INSERT [dbo].[nhacungcap] ([manhacc], [tennhacc], [emailnhacc], [dienthoai]) VALUES (1, N'cafeTN', N'cafeTN@gmail.com', N'05363424535')
INSERT [dbo].[nhacungcap] ([manhacc], [tennhacc], [emailnhacc], [dienthoai]) VALUES (2, N'Vinagame', N'vinagame@gmail.com', N'08868696632')
INSERT [dbo].[nhacungcap] ([manhacc], [tennhacc], [emailnhacc], [dienthoai]) VALUES (3, N'FPT', N'fpt@gmail.com', N'05345234324')
INSERT [dbo].[nhacungcap] ([manhacc], [tennhacc], [emailnhacc], [dienthoai]) VALUES (4, N'Viettel', N'viettel@gmail.com', N'08524342453')
INSERT [dbo].[nhacungcap] ([manhacc], [tennhacc], [emailnhacc], [dienthoai]) VALUES (5, N'Applee', N'applee@gmail.com', N'08768392333')
SET IDENTITY_INSERT [dbo].[nhacungcap] OFF
GO
SET IDENTITY_INSERT [dbo].[sanpham] ON 

INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (11, N'cafe 1', 5, 200, 1000, N'made in china', 1)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (12, N'cafe 2', 10, 300, 3000, N'made in china', 1)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (13, N'card game 1', 5, 100, 500, N'made in vietnam', 2)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (14, N'card game 2', 6, 100, 600, N'made in vietnam', 2)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (15, N'fpt phone', 2, 1000, 2000, N'apple', 3)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (16, N'fpt TV', 3, 1000, 3000, N'GL', 3)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (17, N'viettel phone', 2, 2000, 4000, N'Samsung', 4)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (18, N'viettel TV', 3, 2000, 6000, N'samsung', 4)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (19, N'Iphone10', 5, 10000, 50000, N'apple', 5)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (20, N'Iphone11', 6, 20000, 1200000, N'apple', 5)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (21, N'Iphone12', 7, 201000, 1407000, N'apple1', 3)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (24, N'Iphone8', 7, 201000, 1407000, N'apple1', 5)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (25, N'Iphone8', 7, 201000, 1407000, N'apple1', 5)
INSERT [dbo].[sanpham] ([masp], [tensp], [soluong], [dongia], [thanhtien], [hangsp], [manhacc]) VALUES (26, N'viettel TV', 3, 2000, 6000, N'Galaxy', 2)
SET IDENTITY_INSERT [dbo].[sanpham] OFF
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_nhacungcap] FOREIGN KEY([manhacc])
REFERENCES [dbo].[nhacungcap] ([manhacc])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_nhacungcap]
GO
