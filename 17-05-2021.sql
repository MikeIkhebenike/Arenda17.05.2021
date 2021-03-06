USE [master]
GO
/****** Object:  Database [user18]    Script Date: 17.05.2021 16:07:27 ******/
CREATE DATABASE [user18]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'user18', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\user18.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'user18_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\user18_log.ldf' , SIZE = 22144KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [user18] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [user18].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [user18] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [user18] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [user18] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [user18] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [user18] SET ARITHABORT OFF 
GO
ALTER DATABASE [user18] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [user18] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [user18] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [user18] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [user18] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [user18] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [user18] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [user18] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [user18] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [user18] SET  ENABLE_BROKER 
GO
ALTER DATABASE [user18] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [user18] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [user18] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [user18] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [user18] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [user18] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [user18] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [user18] SET RECOVERY FULL 
GO
ALTER DATABASE [user18] SET  MULTI_USER 
GO
ALTER DATABASE [user18] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [user18] SET DB_CHAINING OFF 
GO
ALTER DATABASE [user18] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [user18] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [user18] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'user18', N'ON'
GO
ALTER DATABASE [user18] SET QUERY_STORE = OFF
GO
USE [user18]
GO
/****** Object:  User [perlova]    Script Date: 17.05.2021 16:07:27 ******/
CREATE USER [perlova] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Аренда]    Script Date: 17.05.2021 16:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Аренда](
	[ID_Аренды] [int] IDENTITY(1,1) NOT NULL,
	[ID_Арендатора] [int] NOT NULL,
	[НазваниеТЦ] [nvarchar](50) NOT NULL,
	[ID_Сотрудника] [int] NOT NULL,
	[Номер_Павильона] [nvarchar](50) NOT NULL,
	[Статус] [nvarchar](50) NOT NULL,
	[Начало_аренды] [date] NOT NULL,
	[Окончание_аренды] [date] NOT NULL,
 CONSTRAINT [PK_Аренда] PRIMARY KEY CLUSTERED 
(
	[ID_Аренды] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Арендаторы]    Script Date: 17.05.2021 16:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Арендаторы](
	[ID_Арендатора] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](50) NOT NULL,
	[Номер_телефона] [nvarchar](50) NOT NULL,
	[Адрес] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Арендаторы] PRIMARY KEY CLUSTERED 
(
	[ID_Арендатора] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Павильоны]    Script Date: 17.05.2021 16:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Павильоны](
	[ID_Павильона] [int] NOT NULL,
	[Название_ТЦ] [nvarchar](50) NOT NULL,
	[Номер_павильона] [nvarchar](50) NOT NULL,
	[Этаж] [int] NOT NULL,
	[Статус] [nvarchar](50) NOT NULL,
	[Площадь м.кв.] [float] NOT NULL,
	[Стоимость за кв.м] [money] NOT NULL,
	[Коэфф. Добав.ст.] [float] NOT NULL,
 CONSTRAINT [PK_Павильоны] PRIMARY KEY CLUSTERED 
(
	[ID_Павильона] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудники]    Script Date: 17.05.2021 16:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудники](
	[ID_Сотрудника] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [nvarchar](50) NOT NULL,
	[Логин] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
	[Роль] [nvarchar](50) NOT NULL,
	[Номер] [nvarchar](50) NOT NULL,
	[Пол] [nchar](2) NOT NULL,
	[Фото] [image] NULL,
 CONSTRAINT [PK_Сотрудники] PRIMARY KEY CLUSTERED 
(
	[ID_Сотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ТЦ]    Script Date: 17.05.2021 16:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ТЦ](
	[ID_ТЦ] [int] NOT NULL,
	[Название] [nvarchar](50) NOT NULL,
	[Статус] [nvarchar](50) NOT NULL,
	[Кол-во павильонов] [nvarchar](50) NOT NULL,
	[Город] [nvarchar](50) NOT NULL,
	[Стоимость] [money] NOT NULL,
	[Коэфф добав.ст.] [float] NOT NULL,
	[Этажность] [int] NOT NULL,
	[Изображение] [image] NULL,
 CONSTRAINT [PK_ТЦ] PRIMARY KEY CLUSTERED 
(
	[ID_ТЦ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Аренда]  WITH CHECK ADD  CONSTRAINT [FK_Аренда_Арендаторы] FOREIGN KEY([ID_Арендатора])
REFERENCES [dbo].[Арендаторы] ([ID_Арендатора])
GO
ALTER TABLE [dbo].[Аренда] CHECK CONSTRAINT [FK_Аренда_Арендаторы]
GO
USE [master]
GO
ALTER DATABASE [user18] SET  READ_WRITE 
GO
