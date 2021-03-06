USE [master]
GO
/****** Object:  Database [Video_Rental_Master_Database]    Script Date: 27/06/2021 11:42:39 PM ******/
CREATE DATABASE [Video_Rental_Master_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Video_Rental_Master_Database_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Master_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Video_Rental_Master_Database_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Master_Database.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Video_Rental_Master_Database] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Video_Rental_Master_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET  MULTI_USER 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Video_Rental_Master_Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Video_Rental_Master_Database] SET QUERY_STORE = OFF
GO
USE [Video_Rental_Master_Database]
GO
/****** Object:  Table [dbo].[BookingTable]    Script Date: 27/06/2021 11:42:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingTable](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[MovieId] [int] NULL,
	[BookMovie] [nchar](50) NULL,
	[ReturnMovie] [nchar](50) NULL,
 CONSTRAINT [PK_BookingTable] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTable]    Script Date: 27/06/2021 11:42:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nchar](100) NULL,
	[Mobile] [nchar](100) NULL,
	[City] [nchar](100) NULL,
	[Country] [nchar](100) NULL,
 CONSTRAINT [PK_CustomerTable] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieTable]    Script Date: 27/06/2021 11:42:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieTable](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nchar](100) NULL,
	[Year] [nchar](100) NULL,
	[Plot] [nchar](100) NULL,
	[Copies] [nchar](100) NULL,
	[Genre] [nchar](100) NULL,
	[Price] [nchar](100) NULL,
 CONSTRAINT [PK_MovieTable] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookingTable] ON 

INSERT [dbo].[BookingTable] ([BookingId], [CustomerId], [MovieId], [BookMovie], [ReturnMovie]) VALUES (1, 22, 1, N'26 June 2021                                      ', N'26 June 2021                                      ')
INSERT [dbo].[BookingTable] ([BookingId], [CustomerId], [MovieId], [BookMovie], [ReturnMovie]) VALUES (2, 2, 2, N'Sunday, 27 June 2021                              ', N'Sunday, 27 June 2021                              ')
SET IDENTITY_INSERT [dbo].[BookingTable] OFF
SET IDENTITY_INSERT [dbo].[CustomerTable] ON 

INSERT [dbo].[CustomerTable] ([CustomerId], [CustomerName], [Mobile], [City], [Country]) VALUES (2, N'df                                                                                                  ', N'46                                                                                                  ', N'gfg                                                                                                 ', N'sgdfg                                                                                               ')
SET IDENTITY_INSERT [dbo].[CustomerTable] OFF
SET IDENTITY_INSERT [dbo].[MovieTable] ON 

INSERT [dbo].[MovieTable] ([MovieId], [MovieName], [Year], [Plot], [Copies], [Genre], [Price]) VALUES (2, N'sdgdfg                                                                                              ', N'2                                                                                                   ', N'2323                                                                                                ', N'23                                                                                                  ', N'3232                                                                                                ', N'2                                                                                                   ')
SET IDENTITY_INSERT [dbo].[MovieTable] OFF
USE [master]
GO
ALTER DATABASE [Video_Rental_Master_Database] SET  READ_WRITE 
GO
