USE [master]
GO
/****** Object:  Database [WinFormFinalProject]    Script Date: 5/17/2020 11:33:03 PM ******/
CREATE DATABASE [WinFormFinalProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinFormFinalProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinFormFinalProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinFormFinalProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinFormFinalProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WinFormFinalProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinFormFinalProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WinFormFinalProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WinFormFinalProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WinFormFinalProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WinFormFinalProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WinFormFinalProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET RECOVERY FULL 
GO
ALTER DATABASE [WinFormFinalProject] SET  MULTI_USER 
GO
ALTER DATABASE [WinFormFinalProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WinFormFinalProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WinFormFinalProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WinFormFinalProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WinFormFinalProject] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WinFormFinalProject', N'ON'
GO
ALTER DATABASE [WinFormFinalProject] SET QUERY_STORE = OFF
GO
USE [WinFormFinalProject]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllOrders]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ConsumerID] [int] NULL,
	[CarmadeID] [int] NULL,
	[Carmake] [nvarchar](50) NULL,
	[PickedDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_AllOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Made] [int] NULL,
	[Make] [nvarchar](50) NULL,
	[Engine] [decimal](18, 1) NULL,
	[Year] [int] NULL,
	[FuelCons] [int] NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Cars_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consumers]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consumers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[IdentityNumber] [int] NULL,
	[DrivingLicence] [int] NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Consumers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[IdentityNumber] [int] NULL,
	[Position] [nvarchar](50) NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mades]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Made] [nvarchar](50) NULL,
 CONSTRAINT [PK_MadeMakes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/17/2020 11:33:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ConsumerID] [int] NULL,
	[CarMadeID] [int] NULL,
	[CarId] [int] NULL,
	[CarMake] [nvarchar](50) NULL,
	[PickedDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AllOrders]  WITH CHECK ADD  CONSTRAINT [FK_AllOrders_Consumers] FOREIGN KEY([ConsumerID])
REFERENCES [dbo].[Consumers] ([Id])
GO
ALTER TABLE [dbo].[AllOrders] CHECK CONSTRAINT [FK_AllOrders_Consumers]
GO
ALTER TABLE [dbo].[AllOrders]  WITH CHECK ADD  CONSTRAINT [FK_AllOrders_Mades] FOREIGN KEY([CarmadeID])
REFERENCES [dbo].[Mades] ([Id])
GO
ALTER TABLE [dbo].[AllOrders] CHECK CONSTRAINT [FK_AllOrders_Mades]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Mades1] FOREIGN KEY([Made])
REFERENCES [dbo].[Mades] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Mades1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Cars]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Consumers] FOREIGN KEY([ConsumerID])
REFERENCES [dbo].[Consumers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Consumers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Mades] FOREIGN KEY([CarMadeID])
REFERENCES [dbo].[Mades] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Mades]
GO
USE [master]
GO
ALTER DATABASE [WinFormFinalProject] SET  READ_WRITE 
GO
