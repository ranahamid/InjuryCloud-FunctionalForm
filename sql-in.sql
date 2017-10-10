USE [master]
GO
/****** Object:  Database [tempDB_]    Script Date: 8/25/2017 9:16:23 PM ******/
CREATE DATABASE [tempDB_]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tempDB_', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\tempDB_.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tempDB__log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\tempDB__log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [tempDB_] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tempDB_].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tempDB_] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tempDB_] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tempDB_] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tempDB_] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tempDB_] SET ARITHABORT OFF 
GO
ALTER DATABASE [tempDB_] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tempDB_] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tempDB_] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tempDB_] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tempDB_] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tempDB_] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tempDB_] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tempDB_] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tempDB_] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tempDB_] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tempDB_] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tempDB_] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tempDB_] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tempDB_] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tempDB_] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tempDB_] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tempDB_] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tempDB_] SET RECOVERY FULL 
GO
ALTER DATABASE [tempDB_] SET  MULTI_USER 
GO
ALTER DATABASE [tempDB_] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tempDB_] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tempDB_] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tempDB_] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [tempDB_] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'tempDB_', N'ON'
GO
USE [tempDB_]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 8/25/2017 9:16:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[AnswerDesc] [nvarchar](255) NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicalHistory]    Script Date: 8/25/2017 9:16:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](250) NULL,
	[QuestionType] [nvarchar](20) NULL,
	[QuestionRegion] [nvarchar](255) NULL,
 CONSTRAINT [PK_MedicalHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TestAnswer]    Script Date: 8/25/2017 9:16:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestAnswer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TestId] [nchar](10) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[AnswerId] [int] NULL,
	[AnswerDesc] [nvarchar](2000) NULL,
 CONSTRAINT [PK_TestAnswer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (1, 1, N'Sharp')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (2, 1, N'Dull')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (3, 1, N'Aching')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (4, 1, N'Shooting')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (5, 2, N'Constant')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (6, 2, N'Intermittent')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (7, 2, N'Occasional')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (8, 3, N'Lifting')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (9, 3, N'Leaning')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (10, 3, N'Dressing')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (11, 3, N'Climbing')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (12, 3, N'Sitting')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (13, 3, N'Walking')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (14, 3, N'Standing')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (15, 3, N'Reaching')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (16, 3, N'Driving')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (17, 3, N'Bending')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (18, 3, N'Stooping')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (19, 3, N'Laying Down')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (21, 8, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (22, 8, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (23, 9, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (24, 9, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (25, 10, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (26, 10, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (27, 11, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (28, 11, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (29, 12, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (30, 12, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (31, 13, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (32, 13, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (33, 5, N'1')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (34, 5, N'2')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (35, 5, N'3')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (36, 5, N'4')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (37, 5, N'5')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (38, 5, N'6')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (39, 5, N'7')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (40, 5, N'8')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (41, 5, N'9')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (42, 5, N'10')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (43, 6, N'1')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (44, 6, N'2')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (46, 6, N'3')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (47, 6, N'4')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (48, 6, N'5')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (49, 6, N'6')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (50, 6, N'7')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (51, 6, N'8')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (52, 6, N'9')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (53, 6, N'10')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (54, 7, N'1')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (55, 7, N'2')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (56, 7, N'3')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (57, 7, N'4')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (58, 7, N'5')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (59, 7, N'6')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (60, 7, N'7')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (61, 7, N'8')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (62, 7, N'9')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (63, 7, N'10')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (64, 18, N'Male')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (65, 18, N'Female')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (66, 19, N'Right')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (67, 19, N'Left')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (68, 29, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (69, 29, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (70, 30, N'Within the last year')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (71, 30, N'1 to 2 years ago')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (72, 30, N'More than 2 years ago')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (73, 31, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (74, 31, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (75, 31, N'N/A')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (76, 32, N'Yes, test was negative')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (77, 32, N'Yes, test was positive')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (78, 32, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (79, 32, N'N/A')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (80, 33, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (81, 33, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (82, 34, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (83, 34, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (84, 35, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (85, 35, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (86, 36, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (87, 36, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (88, 37, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (89, 37, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (90, 38, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (91, 38, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (92, 39, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (93, 39, N'Yes, controlled by medication or diet')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (94, 39, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (95, 40, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (96, 40, N'Yes, controlled by medication or diet')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (97, 40, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (98, 41, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (99, 41, N'Yes, controlled by medication or diet')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (100, 41, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (104, 42, N'Yes')
GO
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (105, 42, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (106, 43, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (107, 43, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (108, 44, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (109, 44, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (110, 45, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (111, 45, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (112, 46, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (113, 46, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (114, 47, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (115, 47, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (116, 48, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (117, 48, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (118, 49, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (119, 49, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (120, 50, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (121, 50, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (122, 51, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (123, 51, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (124, 52, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (125, 52, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (126, 53, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (127, 53, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (128, 54, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (129, 54, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (130, 55, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (131, 55, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (132, 56, N'Yes')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (133, 56, N'No')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (134, 57, N'None')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (135, 57, N'Limiting, prevents full activity')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (136, 57, N'Severe, no activity possible')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (137, 58, N'A. I have no pain at the moment.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (138, 58, N'B. The pain is mild at the moment.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (139, 58, N'C. The pain comes and goes and is moderate.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (140, 58, N'D. The pain is moderate and does not vary much.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (141, 58, N'E. The pain is severe, but comes and goes.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (142, 59, N'A. I can look after myself without causing extra pain.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (143, 59, N'B. I can look after myself normally, but it causes extra pain.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (144, 59, N'C. It is painful to look after myself and I am slow and careful.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (145, 59, N'D.  I need some help, but manage most of my personal care.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (148, 59, N'E. I need help every day in most aspects of self-care.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (149, 59, N'F. I do not get undressed, I wash with difficulty and stay in bed.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (150, 60, N'A. I can lift heavy weights without extra pain.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (151, 60, N'B. I can lift heavy weights but it causes extra pain.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (152, 60, N'C. Pain prevents me from lifting heavy weights off the floor, but I can manage if they are conveniently positioned (e.g. on a table)')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (153, 60, N'D. Pain prevents me from lifting heavy weights, but I can manage light to medium weights if they are conveniently positioned.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (154, 60, N'E. I can lift only very light weights.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (155, 60, N'F. I cannot lift or carry anything at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (156, 61, N'A. I can read as much as I want to with no pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (157, 61, N'B. I can read as much as I want to with slight pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (158, 61, N'C. I can read as much as I want to with moderate pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (159, 61, N'D. I cannot read as much as I want to because of moderate pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (160, 61, N'E. I cannot read as much as I want to because of severe pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (161, 61, N'F. I cannot read at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (162, 62, N'A. I have no headaches at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (163, 62, N'B. I have slight headaches that come infrequently.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (164, 62, N'C. I have moderate headaches that come infrequently.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (165, 62, N'D. I have moderate headaches that come frequently.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (166, 62, N'E. I have severe headaches that come frequently.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (167, 62, N'F. I have headaches almost all the time.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (168, 63, N'A. I can concentrate fully when I want to with no difficulty.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (169, 63, N'B. I can concentrate fully when I want to with slight difficulty.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (170, 63, N'C. I have a fair degree of difficulty in concentrating when I want to.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (171, 63, N'D. I have a lot of difficulty in concentrating when I want to.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (172, 63, N'E. I have a great deal of difficulty in concentrating when I want to.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (173, 63, N'F. I cannot concentrate at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (174, 64, N'A. I can do as much work as I want to.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (175, 64, N'B. I can do my usual work but no more.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (176, 64, N'C. I can do most of my usual work, but no more.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (177, 64, N'D. I cannot do my usual work.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (178, 64, N'E. I can hardly do any work at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (179, 64, N'F. I cannot do any work at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (180, 65, N'A. I can drive my car without any neck pain.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (181, 65, N'B. I can drive my car as long as I want with slight pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (182, 65, N'C. I can drive my car as long as I want with moderate pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (183, 65, N'D. I cannot drive my car as long as I want because of moderate pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (184, 65, N'E. I can hardly drive at all because of severe pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (185, 65, N'F. I cannot drive my car at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (186, 66, N'A. I have no trouble sleeping.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (187, 66, N'B. My sleep is slightly disturbed (less than 1 hour sleepless).')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (188, 66, N'C. My sleep is mildly disturbed (1-2 hours sleepless).')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (189, 66, N'D. My sleep is moderately disturbed (2-3 hours sleepless).')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (190, 66, N'E. My sleep is greatly disturbed (3-5 hours sleepless).')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (191, 66, N'F. My sleep is completely disturbed (5-7 hours sleepless).')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (193, 68, N'1')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (194, 68, N'2')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (195, 68, N'3')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (196, 68, N'4')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (197, 68, N'5')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (199, 68, N'6')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (200, 68, N'7')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (201, 68, N'8')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (202, 68, N'9')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (203, 68, N'10')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (204, 58, N'F. The pain is severe and does not vary much.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (205, 67, N'A. I am able to engage in all my recreational activities, with no neck pain at all.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (206, 67, N'B. I am able to engage in all of my recreational activities, with some pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (207, 67, N'C. I am able to engage in most, but not all of my usual recreational activities because of pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (208, 67, N'D. I am able to engage in only a few of my usual recreational activities because of pain in my neck.')
GO
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (209, 67, N'E. I can hardly do any recreational activities because of pain in my neck.')
INSERT [dbo].[Answer] ([Id], [QuestionId], [AnswerDesc]) VALUES (215, 67, N'F. I cannot do any recreational activities at all.')
SET IDENTITY_INSERT [dbo].[Answer] OFF
SET IDENTITY_INSERT [dbo].[MedicalHistory] ON 

INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (1, N'Which of the following best describes your pain?', N'Radio', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (2, N'Which of the following best describes the frequency of your pain? (check one)', N'Radio', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (3, N'What makes your pain feel worse? (check all that apply)', N'CheckBox', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (4, N'What makes your pain feel better?', N'Text', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (5, N'What number on the pain scale best describes your pain right now?', N'Scale', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (6, N'What number on the pain scale describes your worst pain over the past 30 days?', N'Scale', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (7, N'What number on the pain scale describes your least pain over the past 30 days?', N'Scale', N'PAIN DESCRIPTION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (8, N'Do you have a history of cancer?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (9, N'Do you have a pacemaker?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (10, N'Do you have hypertension?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (11, N'Do you have bowel/bladder problems?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (12, N'Are you diabetic?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (13, N'Are you pregnant?', N'Radio', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (14, N'Please list any other relevant past medical or orthopedic history:', N'Text', N'GENERAL MEDICAL HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (15, N'Patient Name:', N'Text', N'Authorization for Release of Information')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (16, N'DOB', N'Date', N'Authorization for Release of Information')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (17, N'First Name', N'Text', N'BIOGRAPHIC INFORMATION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (18, N'Sex', N'Radio', N'BIOGRAPHIC INFORMATION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (19, N'DominantHand', N'Radio', N'BIOGRAPHIC INFORMATION')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (20, N'First Name', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (21, N'Last Name', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (22, N'PIN (Enter Four Digits):', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (23, N'Date of Birth', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (24, N'feet', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (25, N' inches', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (26, N'Email', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (27, N'Weight', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (28, N'Todays Date', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (29, N'Do you smoke?', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (30, N'When was your last physical exam?', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (31, N'Have you reached menopause?', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (32, N'Have you had a PSA test within the last year?', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (33, N'Thyroid Dysfunction', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (34, N'Rheumatoid Arthritis, Lupus, or Psoriatic', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (35, N'Osteoarthritis', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (36, N'Osteoporosis', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (37, N'Cancer', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (38, N'Stroke', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (39, N'High Cholesterol', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (40, N'High Blood Pressure', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (41, N'Diabetes', NULL, N'PERSONAL HEALTH HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (42, N'Over the counter (OTC) Non-Steroidal, Anti-Inflammatory medications? (such as Tylenol, Ibuprofen, Motrin, Aspirin)', NULL, N'MEDICATIONS')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (43, N'Prescription Non-Steroidal, Anti-inflammatory medication? (such as Naproxen, Mobic, Tylenol #3)', NULL, N'MEDICATIONS')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (44, N'Narcotic Pain Medications? (such as Oxycontin, Hydrocodone, Morphine)', NULL, N'MEDICATIONS')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (45, N'Head', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (46, N'Cardiovascular/Pulmonary', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (47, N'Abdominal', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (48, N'Genito/Urinary', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (49, N'Spine', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (50, N'Diabetes', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (51, N'Thyroid Dysfunction', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (52, N'Rheumatoid Arthritis, Lupus, or Psoriatic', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (53, N'Osteoarthritis', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (54, N'Osteoporosis', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (55, N'Cancer', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (56, N'Stroke', NULL, N'FAMILY HISTORY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (57, N'What effect has your past surgery had on your ability to perform daily activities?', NULL, N'SURGERY')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (58, N'Section 1 - Pain Intensity', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (59, N'Section 2 - Personal Care', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (60, N'Section 3 - Lifting', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (61, N'Section 4 - Reading', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (62, N'Section 5 - Headache', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (63, N'Section 6 - Concentration', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (64, N'Section 7 - Work', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (65, N'Section 8 - Driving', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (66, N'Section 9 - Sleeping', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (67, N'Section 10 - Recreation', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (68, N'Section 11 - Numeric Rating Scale (NRS)', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (69, N'OswestryName', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (70, N'OswestryDate', NULL, N'Oswestry Neck Pain Questionnaire')
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (71, N'OSW-SCORE', NULL, NULL)
INSERT [dbo].[MedicalHistory] ([Id], [Question], [QuestionType], [QuestionRegion]) VALUES (72, N'P-SCORE', NULL, NULL)
SET IDENTITY_INSERT [dbo].[MedicalHistory] OFF
SET IDENTITY_INSERT [dbo].[TestAnswer] ON 

INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (29, N'1         ', 1, 1, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (30, N'1         ', 2, 5, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (31, N'1         ', 3, 8, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (32, N'1         ', 4, 0, N'http://localhost:15272/FunctionalForm/Test/1')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (33, N'1         ', 8, 21, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (34, N'1         ', 9, 23, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (35, N'1         ', 10, 25, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (36, N'1         ', 11, 28, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (37, N'1         ', 12, 30, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (38, N'1         ', 13, 32, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (39, N'1         ', 14, 0, N'http://localhost:15272/FunctionalForm/Test/1')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (40, N'1         ', 18, 65, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (41, N'1         ', 19, 67, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (42, N'1         ', 20, 0, N'https://www.pickaboo.com/checkout/cart/')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (43, N'1         ', 21, 0, N'https://www.shohoz.com/booking/bus/search?fromcity=Rangpur&tocity=Dhaka&doj=06-Sep-2017&dor=')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (44, N'1         ', 22, 0, N'3698')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (45, N'1         ', 23, 0, N'8/21/2017 8:09:59 PM')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (46, N'1         ', 24, 0, N'6')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (47, N'1         ', 25, 0, N'2')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (48, N'1         ', 26, 0, N'ranahamid007@gmail.com')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (49, N'1         ', 27, 0, N'55')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (50, N'1         ', 28, 0, N'8/21/2017 8:09:59 PM')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (51, N'10        ', 1, 2, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (52, N'10        ', 2, 6, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (53, N'10        ', 3, 9, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (54, N'10        ', 4, NULL, N'Get this from db')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (55, N'10        ', 8, 22, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (56, N'10        ', 9, 24, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (57, N'10        ', 10, 26, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (58, N'10        ', 11, 27, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (59, N'10        ', 12, 29, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (60, N'10        ', 13, 31, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (61, N'10        ', 14, NULL, N'Get this from db')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (62, N'10        ', 18, 65, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (63, N'10        ', 19, 67, NULL)
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (64, N'10        ', 20, NULL, N'student')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (65, N'10        ', 21, NULL, N'2016')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (66, N'10        ', 22, NULL, N'5465')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (67, N'10        ', 23, NULL, N'8/21/2017 8:13:11 PM')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (68, N'10        ', 24, NULL, N'5')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (69, N'10        ', 25, NULL, N'5')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (70, N'10        ', 26, NULL, N'ranahamid007@gmail.com')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (71, N'10        ', 27, NULL, N'50')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (72, N'10        ', 28, NULL, N'8/21/2017 8:13:11 PM')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1044, N'1         ', 5, 33, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1045, N'1         ', 6, 44, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1046, N'1         ', 7, 56, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1047, N'1         ', 29, 68, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1048, N'1         ', 30, 71, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1049, N'1         ', 31, 75, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1050, N'1         ', 32, 76, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1051, N'1         ', 33, 81, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1052, N'1         ', 34, 82, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1053, N'1         ', 35, 85, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1054, N'1         ', 36, 86, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1055, N'1         ', 37, 89, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1056, N'1         ', 38, 90, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1057, N'1         ', 39, 93, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1058, N'1         ', 40, 97, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1059, N'1         ', 41, 98, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1060, N'1         ', 42, 104, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1061, N'1         ', 43, 107, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1062, N'1         ', 44, 108, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1063, N'1         ', 45, 110, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1064, N'1         ', 46, 113, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1065, N'1         ', 47, 114, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1066, N'1         ', 48, 117, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1067, N'1         ', 49, 118, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1068, N'1         ', 57, 134, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1069, N'1         ', 50, 121, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1070, N'1         ', 51, 122, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1071, N'1         ', 52, 125, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1072, N'1         ', 53, 126, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1073, N'1         ', 54, 129, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1074, N'1         ', 55, 130, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1075, N'1         ', 56, 133, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1076, N'1         ', 58, 137, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1077, N'1         ', 59, 143, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1078, N'1         ', 60, 152, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1079, N'1         ', 61, 159, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1080, N'1         ', 62, 166, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1081, N'1         ', 63, 173, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1082, N'1         ', 64, 174, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1083, N'1         ', 65, 181, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1084, N'1         ', 66, 188, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1085, N'1         ', 67, 208, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1086, N'1         ', 68, 193, N'')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1087, N'1         ', 69, 0, N'https://www.google.com/search?q=intitle:index.of%3F+mp4+Superman')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1088, N'1         ', 70, 0, N'8/22/2017 9:09:51 PM')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1089, N'1         ', 71, 0, N'https://cinehub24.com/')
INSERT [dbo].[TestAnswer] ([Id], [TestId], [QuestionId], [AnswerId], [AnswerDesc]) VALUES (1090, N'1         ', 72, 0, N'https://www.youtube.com/user/setindia')
SET IDENTITY_INSERT [dbo].[TestAnswer] OFF
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_MedicalHistory] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[MedicalHistory] ([Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_MedicalHistory]
GO
USE [master]
GO
ALTER DATABASE [tempDB_] SET  READ_WRITE 
GO
