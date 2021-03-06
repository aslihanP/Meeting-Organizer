USE [MeetingsDB]
GO
/****** Object:  Table [dbo].[tblMeetings]    Script Date: 15.04.2018 17:49:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMeetings](
	[MeetingID] [int] IDENTITY(1,1) NOT NULL,
	[MeetingTopic] [nvarchar](50) NOT NULL,
	[MeetingDate] [datetime] NOT NULL,
	[StartTime] [nchar](10) NOT NULL,
	[EndTime] [nchar](10) NOT NULL,
	[Katılımcılar] [ntext] NOT NULL,
 CONSTRAINT [PK_tblMeetings] PRIMARY KEY CLUSTERED 
(
	[MeetingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblMeetings] ON 

INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (1, N'Ürün Tanıtımı', CAST(N'2018-04-16 00:00:00.000' AS DateTime), N'11:00 AM  ', N'12:00 PM  ', N'Aslıhan Peker, Miray Kaya')
INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (3, N'Devam Görüşmesi', CAST(N'2018-04-20 00:00:00.000' AS DateTime), N'9:00 AM   ', N'10:00 AM  ', N'Selim Güngör, Bahadır Canyılmaz')
INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (6, N'İnsan Kaynakları Toplantısı', CAST(N'2018-08-09 00:00:00.000' AS DateTime), N'1:30 PM   ', N'2:30 PM   ', N'Hakan Yalçın, Ayşe Yılmaz')
INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (7, N'Pazarlama Stratejileri', CAST(N'2018-04-11 00:00:00.000' AS DateTime), N'9:00 AM   ', N'10:30 AM  ', N'Merve Dağlı, Kerim Bülbül')
INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (11, N'Aylık Performans Toplantısı', CAST(N'2018-05-26 00:00:00.000' AS DateTime), N'4:00 PM   ', N'5:00 PM   ', N'Halil Akay, Sibel Mercan')
INSERT [dbo].[tblMeetings] ([MeetingID], [MeetingTopic], [MeetingDate], [StartTime], [EndTime], [Katılımcılar]) VALUES (15, N'aswd', CAST(N'2018-04-15 00:00:00.000' AS DateTime), N'9:00 AM   ', N'11:00 AM  ', N'asdfg')
SET IDENTITY_INSERT [dbo].[tblMeetings] OFF
