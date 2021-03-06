USE [idefloors]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 08/21/2015 17:33:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Banner](
	[BannerID] [int] IDENTITY(1,1) NOT NULL,
	[ImgUrl] [nvarchar](100) NULL,
	[ThumbUrl] [nvarchar](100) NULL,
	[Link] [nvarchar](300) NULL,
	[Title] [nvarchar](100) NULL,
	[UserCreated] [varchar](100) NULL,
	[UserModified] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[BannerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Banner] ON
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (1, N'01.jpg', N'thumb-01.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=4', NULL, NULL, NULL, CAST(0x0000A4FB011CFF8F AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (2, N'02.jpg', N'thumb-02.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=6', NULL, NULL, NULL, CAST(0x0000A4FB011D0196 AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (3, N'03.jpg', N'thumb-03.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=4', NULL, NULL, NULL, CAST(0x0000A4FB011D028A AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (4, N'04.jpg', N'thumb-04.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=4', NULL, NULL, NULL, CAST(0x0000A4FB011D0381 AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (5, N'05.jpg', N'thumb-05.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=12', NULL, NULL, NULL, CAST(0x0000A4FB011D044C AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (6, N'06.jpg', N'thumb-06.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=30', NULL, NULL, NULL, CAST(0x0000A4FB011D051D AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (7, N'07.jpg', N'thumb-07.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=17', NULL, NULL, NULL, CAST(0x0000A4FB011D05EA AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (8, N'08.jpg', N'thumb-08.jpg', NULL, NULL, NULL, NULL, CAST(0x0000A4FB011D0749 AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (9, N'09.jpg', N'thumb-09.jpg', NULL, NULL, NULL, NULL, CAST(0x0000A4FB011D0823 AS DateTime), NULL)
INSERT [dbo].[Banner] ([BannerID], [ImgUrl], [ThumbUrl], [Link], [Title], [UserCreated], [UserModified], [CreatedDate], [ModifiedDate]) VALUES (10, N'10.jpg', N'thumb-10.jpg', N'http://localhost:23742/Page/ProductByCategory.aspx?Id=16', NULL, NULL, NULL, CAST(0x0000A4FB011D0E73 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Banner] OFF
/****** Object:  Default [DF_Banner_CreatedDate]    Script Date: 08/21/2015 17:33:10 ******/
ALTER TABLE [dbo].[Banner] ADD  CONSTRAINT [DF_Banner_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
