USE [master]
GO
/****** Object:  Database [employeeDB]    Script Date: 13-Jan-15 9:11:56 PM ******/
CREATE DATABASE [employeeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'employeeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\employeeDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'employeeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\employeeDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [employeeDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [employeeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [employeeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [employeeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [employeeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [employeeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [employeeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [employeeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [employeeDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [employeeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [employeeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [employeeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [employeeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [employeeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [employeeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [employeeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [employeeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [employeeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [employeeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [employeeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [employeeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [employeeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [employeeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [employeeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [employeeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [employeeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [employeeDB] SET  MULTI_USER 
GO
ALTER DATABASE [employeeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [employeeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [employeeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [employeeDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [employeeDB]
GO
/****** Object:  Table [dbo].[tbl_Designation]    Script Date: 13-Jan-15 9:11:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Designation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Title] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Designation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Employee]    Script Date: 13-Jan-15 9:11:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Designation_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Designation] ON 

INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (1, N'123', N'cse')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (2, N'453', N'MAnager')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (3, N'4539', N'MAnager')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (4, N'999', N'CEO')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (5, N'000', N'HR')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (6, N'333', N'CEO')
INSERT [dbo].[tbl_Designation] ([Id], [Code], [Title]) VALUES (7, N'987', N'')
SET IDENTITY_INSERT [dbo].[tbl_Designation] OFF
SET IDENTITY_INSERT [dbo].[tbl_Employee] ON 

INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (1, N'orthy', N'gmail', N'.com', 2)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (2, N'orthy', N'31@gmail.comm', N'khulna', 1)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (3, N'asde', N'sss', N'cdvfgvbn', 4)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (4, N'mklo', N'ouik', N'kkkk', 1)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (5, N'shipte', N'yahoo', N'dhaka', 2)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (6, N'panku', N'', N'khulna', 1)
INSERT [dbo].[tbl_Employee] ([Id], [Name], [Email], [Address], [Designation_Id]) VALUES (7, N'zzz', N'', N'dfgh', 1)
SET IDENTITY_INSERT [dbo].[tbl_Employee] OFF
ALTER TABLE [dbo].[tbl_Employee]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Employee_tbl_Employee] FOREIGN KEY([Designation_Id])
REFERENCES [dbo].[tbl_Designation] ([Id])
GO
ALTER TABLE [dbo].[tbl_Employee] CHECK CONSTRAINT [FK_tbl_Employee_tbl_Employee]
GO
USE [master]
GO
ALTER DATABASE [employeeDB] SET  READ_WRITE 
GO
