USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 24/11/2020 08:24:31 ******/
CREATE DATABASE [QLSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSinhVien.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSinhVien_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSinhVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLSinhVien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLSinhVien]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 24/11/2020 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 24/11/2020 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](10) NOT NULL,
	[Tenlop] [nvarchar](150) NULL,
	[Nam] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 24/11/2020 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [nvarchar](20) NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[UnitsOnOrder] [smallint] NULL,
	[ReorderLevel] [smallint] NULL,
	[Discontinued] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 24/11/2020 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Masv] [nchar](10) NOT NULL,
	[Hoten] [nvarchar](150) NULL,
	[MaLop] [char](10) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 24/11/2020 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
	[HomePage] [ntext] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Lop] ([MaLop], [Tenlop], [Nam]) VALUES (N'LT01      ', N'L?p trinhg Mobile 1801', 2018)
INSERT [dbo].[Lop] ([MaLop], [Tenlop], [Nam]) VALUES (N'LT02      ', N'L?p trinhg H? th?ng 1701', 2017)
INSERT [dbo].[Lop] ([MaLop], [Tenlop], [Nam]) VALUES (N'MM01      ', N'Qu?n tr? m?ng 1901', 2019)
INSERT [dbo].[SinhVien] ([Masv], [Hoten], [MaLop]) VALUES (N'sv01      ', N'Nguy?n Van An', N'LT01      ')
INSERT [dbo].[SinhVien] ([Masv], [Hoten], [MaLop]) VALUES (N'sv02      ', N'Nguy?n Nhu Vu', N'LT01      ')
INSERT [dbo].[SinhVien] ([Masv], [Hoten], [MaLop]) VALUES (N'sv03      ', N'Ngô H?i Qu?nh', N'MM01      ')
INSERT [dbo].[SinhVien] ([Masv], [Hoten], [MaLop]) VALUES (N'sv04      ', N'Nguy?n Thùy Duong', N'MM01      ')
INSERT [dbo].[SinhVien] ([Masv], [Hoten], [MaLop]) VALUES (N'sv05      ', N'Tr?n Van Nam', N'LT02      ')
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsInStock]  DEFAULT ((0)) FOR [UnitsInStock]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsOnOrder]  DEFAULT ((0)) FOR [UnitsOnOrder]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_ReorderLevel]  DEFAULT ((0)) FOR [ReorderLevel]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Discontinued]  DEFAULT ((0)) FOR [Discontinued]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_Products_UnitPrice] CHECK  (([UnitPrice]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_UnitPrice]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_ReorderLevel] CHECK  (([ReorderLevel]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_ReorderLevel]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsInStock] CHECK  (([UnitsInStock]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_UnitsInStock]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsOnOrder] CHECK  (([UnitsOnOrder]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_UnitsOnOrder]
GO
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
