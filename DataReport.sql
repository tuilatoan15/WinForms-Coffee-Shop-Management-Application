USE [master]
GO
/****** Object:  Database [QuanLyQuanCaPhe]    Script Date: 8/19/2024 10:36:36 PM ******/
CREATE DATABASE [QuanLyQuanCaPhe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCaPhe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KTEAM\MSSQL\DATA\QuanLyQuanCaPhe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCaPhe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KTEAM\MSSQL\DATA\QuanLyQuanCaPhe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCaPhe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyQuanCaPhe', N'ON'
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET QUERY_STORE = OFF
GO
USE [QuanLyQuanCaPhe]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 

	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
				BEGIN 
					IF @COUNTER=1 
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
					ELSE 
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK 
				END 
			SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 
		END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NOT NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'Hang', N'Hang', N'2010', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'K9', N'RongK9', N'1', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff', N'staff', N'1', 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (1, CAST(N'2024-08-01' AS Date), CAST(N'2024-08-01' AS Date), 1, 1, 10, 50000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (2, CAST(N'2024-08-02' AS Date), CAST(N'2024-08-02' AS Date), 2, 1, 15, 75000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (3, CAST(N'2024-08-03' AS Date), CAST(N'2024-08-03' AS Date), 3, 1, 5, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (4, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date), 4, 1, 20, 80000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (5, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date), 5, 1, 10, 40000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (6, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date), 6, 1, 25, 100000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (7, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date), 7, 0, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (8, CAST(N'2024-08-08' AS Date), CAST(N'2024-08-08' AS Date), 8, 1, 10, 55000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (9, CAST(N'2024-08-09' AS Date), CAST(N'2024-08-09' AS Date), 9, 1, 15, 70000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (10, CAST(N'2024-08-10' AS Date), CAST(N'2024-08-10' AS Date), 10, 1, 5, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (11, CAST(N'2024-08-11' AS Date), CAST(N'2024-08-11' AS Date), 11, 1, 20, 85000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (12, CAST(N'2024-08-12' AS Date), CAST(N'2024-08-12' AS Date), 12, 1, 10, 45000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (13, CAST(N'2024-08-13' AS Date), CAST(N'2024-08-13' AS Date), 13, 1, 25, 95000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (14, CAST(N'2024-08-14' AS Date), CAST(N'2024-08-14' AS Date), 14, 1, 15, 75000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (15, CAST(N'2024-08-15' AS Date), CAST(N'2024-08-15' AS Date), 15, 1, 10, 50000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (16, CAST(N'2024-08-16' AS Date), CAST(N'2024-08-16' AS Date), 16, 1, 20, 80000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (17, CAST(N'2024-08-17' AS Date), CAST(N'2024-08-17' AS Date), 17, 1, 5, 35000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (18, CAST(N'2024-08-18' AS Date), CAST(N'2024-08-18' AS Date), 18, 1, 25, 95000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (19, CAST(N'2024-08-19' AS Date), CAST(N'2024-08-19' AS Date), 19, 1, 15, 70000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (20, CAST(N'2024-08-20' AS Date), CAST(N'2024-08-20' AS Date), 20, 1, 10, 55000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (21, CAST(N'2024-08-21' AS Date), CAST(N'2024-08-21' AS Date), 21, 1, 5, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (22, CAST(N'2024-08-22' AS Date), CAST(N'2024-08-22' AS Date), 22, 1, 20, 85000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (23, CAST(N'2024-08-23' AS Date), CAST(N'2024-08-23' AS Date), 23, 1, 10, 45000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (24, CAST(N'2024-08-24' AS Date), CAST(N'2024-08-24' AS Date), 24, 1, 25, 95000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (25, CAST(N'2024-08-25' AS Date), CAST(N'2024-08-25' AS Date), 25, 1, 15, 75000)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (1, 1, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 1, 2, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (3, 1, 3, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (4, 2, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (5, 2, 5, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (6, 2, 6, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (7, 3, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (8, 3, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (9, 4, 9, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (10, 4, 10, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (11, 4, 11, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (12, 5, 12, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (13, 5, 13, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (14, 5, 14, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (15, 6, 15, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (16, 6, 16, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (17, 6, 17, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (18, 7, 18, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (19, 7, 19, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (20, 8, 20, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (21, 8, 21, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (22, 8, 22, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (23, 9, 23, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (24, 9, 24, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (25, 10, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (26, 10, 6, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (27, 10, 7, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (28, 11, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (29, 11, 9, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (30, 11, 3, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (31, 12, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (32, 12, 2, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (33, 12, 3, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (34, 13, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (35, 13, 5, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (36, 13, 6, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (37, 14, 7, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (38, 14, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (39, 14, 9, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (40, 15, 10, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (41, 15, 11, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (42, 15, 12, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (43, 16, 13, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (44, 16, 14, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (45, 16, 15, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (46, 17, 16, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (47, 17, 17, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (48, 17, 18, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (49, 18, 19, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (50, 18, 20, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (51, 18, 21, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (52, 19, 22, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (53, 19, 23, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (54, 19, 24, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (55, 20, 5, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (56, 20, 6, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (57, 20, 7, 2)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Nước khoáng', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Nước trái cây', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Nước ngọt', 1, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Nước lọc', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Nước chanh', 1, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Cà phê đen', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Cà phê sữa đá', 2, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Cà phê latte', 2, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Cà phê cappuccino', 2, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Cà phê mocha', 2, 50000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Bánh mì kẹp thịt', 3, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Phở bò', 3, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Gà chiên', 3, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Súp rau', 3, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Xôi xéo', 3, 28000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Kẹo dẻo', 4, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Kẹo mút', 4, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Kẹo socola', 4, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Kẹo gôm', 4, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Kẹo bạc hà', 4, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Bánh ngọt', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Bánh quy', 5, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Bánh kem', 5, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (24, N'Bánh su', 5, 22000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (25, N'Bánh bao', 5, 15000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Nước')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Cà phê')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Thực phẩm')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Kẹo')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Bánh')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Ban 1', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Ban 2', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Ban 3', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Ban 4', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Ban 5', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Ban 6', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Ban 7', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Ban 8', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Ban 9', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Ban 10', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (11, N'Ban 11', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (12, N'Ban 12', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (13, N'Ban 13', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (14, N'Ban 14', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (15, N'Ban 15', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (16, N'Ban 16', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (17, N'Ban 17', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (18, N'Ban 18', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (19, N'Ban 19', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (20, N'Ban 20', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (21, N'Ban 21', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (22, N'Ban 22', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (23, N'Ban 23', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (24, N'Ban 24', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (25, N'Ban 25', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (26, N'Ban 26', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (27, N'Ban 27', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (28, N'Ban 28', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (29, N'Ban 29', N'Trong')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (30, N'Ban 30', N'Trong')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Kter') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chua dat ten') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chua dat ten') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Ban chua co ten') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trong') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Danh sách các PROC --------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*CREATE PROC USP_MergeTable
    @idTable1 INT, 
    @idTable2 INT
AS 
BEGIN
    DECLARE @idFirstBill INT;
    DECLARE @idSecondBill INT;

    -- Lấy ID của hóa đơn tương ứng với mỗi bàn
    SELECT @idFirstBill = id FROM Bill WHERE idTable = @idTable1 AND status = 0;
    SELECT @idSecondBill = id FROM Bill WHERE idTable = @idTable2 AND status = 0;

    -- Cập nhật BillInfo để gộp hóa đơn của bàn @idTable1 vào hóa đơn của bàn @idTable2
    UPDATE BillInfo 
    SET idBill = @idSecondBill 
    WHERE idBill = @idFirstBill;

    -- Cập nhật trạng thái của bàn 1 thành 'Trong'
    UPDATE TableFood 
    SET status = N'Trong' 
    WHERE id = @idTable1;

    -- Tuỳ chọn: Xóa hóa đơn cũ của @idFirstBill nếu cần thiết
    DELETE FROM Bill WHERE id = @idFirstBill;
END
GO
*/


CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.id AS [ID], t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền],
	DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra],
	discount AS [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page INT
AS
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows

	;WITH BillShow AS (SELECT b.id AS [ID], t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền],
	DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra],
	discount AS [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN
	(SELECT TOP (@exceptRows) id FROM BillShow)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateForReport]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetListBillByDateForReport]
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.id AS [ID], t.name AS [TableName], b.totalPrice AS [TotalPrice],
	DateCheckIn AS [DateCheckIn], DateCheckOut AS [DateCheckOut],
	discount AS [Discount]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
AS
BEGIN
	SELECT COUNT(*)
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetTableList]
AS SELECT * FROM TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT Bill(DateCheckIn, DateCheckOut, idTable, status, discount)
	VALUES (GETDATE(), NULL, @idTable, 0, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBillInfo]
    @idBill INT,
    @idFood INT,
    @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT;
    DECLARE @foodCount INT = 1;

    SELECT @isExitsBillInfo = b.id, @foodCount = b.count 
    FROM BillInfo AS b 
    WHERE idBill = @idBill AND idFood = @idFood;

    IF (@isExitsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
        BEGIN
            UPDATE BillInfo 
            SET count = @foodCount + @count
            WHERE idFood = @idFood AND idBill = @idBill
        END
        ELSE 
        BEGIN
            DELETE FROM BillInfo 
            WHERE idBill = @idBill AND idFood = @idFood
        END
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo (idBill, idFood, count)
        VALUES (@idBill, @idFood, @count);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_SwitchTable]
@idTable1 INT, @idTable2 INT
AS 
BEGIN
	
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1

	SELECT @idSecondBill = id FROM Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM Bill WHERE idTable = @idTable1 AND status = 0

	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable1, 0)
		SELECT @idFirstBill = MAX (id) FROM Bill WHERE idTable = @idTable1 AND status = 0
	END

	SELECT @isFirstTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idFirstBill

		IF (@idSecondBill IS NULL)
	BEGIN
		INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable2, 0)
		SELECT @idSecondBill = MAX (id) FROM Bill WHERE idTable = @idTable2 AND status = 0
	END
	
	SELECT @isSecondTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idSecondBill

	SELECT id INTO IDBillInfoTable FROM BillInfo WHERE idBill = @idSecondBill

	UPDATE BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)

	DROP TABLE IDBillInfoTable

	IF (@isFirstTableEmpty = 0)
		UPDATE TableFood SET status = N'Trong' WHERE id = @idTable2
		
		IF (@isSecondTableEmpty = 0)
		UPDATE TableFood SET status = N'Trong' WHERE id = @idTable1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 8/19/2024 10:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), 
@password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT

	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName AND PassWord = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword IS NULL OR @newPassword = N'')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END
		ELSE
			UPDATE Account SET DisplayName = @displayName, Password = @newPassword WHERE UserName = @userName
	END
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  READ_WRITE 
GO
