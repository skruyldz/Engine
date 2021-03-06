USE [SompoEngine]
GO
/****** Object:  Schema [SampleEngine]    Script Date: 20-Dec-20 7:18:02 PM ******/
CREATE SCHEMA [SampleEngine]
GO
/****** Object:  Table [SampleEngine].[ServiceRequestResponse]    Script Date: 20-Dec-20 7:18:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SampleEngine].[ServiceRequestResponse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProposalNo] [nvarchar](20) NULL,
	[EndorsNo] [int] NULL,
	[RenewalNo] [int] NULL,
	[ProductNo] [nvarchar](20) NULL,
	[RequestJson] [nvarchar](max) NULL,
	[ResponseJson] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ServiceRequestResponse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [SampleEngine].[ServiceRequestResponse] ON 

INSERT [SampleEngine].[ServiceRequestResponse] ([Id], [ProposalNo], [EndorsNo], [RenewalNo], [ProductNo], [RequestJson], [ResponseJson], [Status], [CreateDate], [UpdateDate]) VALUES (45, N'200200022183057', 0, 0, N'112', N'{"Authentication":{"Source":"SOMPO","Key":"77lTCSn41w"},"Object":{"ProposalNo":200200022183057,"EndorsNo":0,"RenewalNo":0,"ProductNo":"112"}}', N'{"Results":[{"Code":"916","Description":"Açıklama 916","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"946","Description":"Açıklama 946","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"506","Description":"Açıklama 506","Status":{"Value":"1","Name":"Olumlu"}},{"Code":"776","Description":"Açıklama 776","Status":{"Value":"2","Name":"Bilgi"}},{"Code":"849","Description":"Açıklama 849","Status":{"Value":"2","Name":"Bilgi"}},{"Code":"1065","Description":"Açıklama 1065","Status":{"Value":"2","Name":"Bilgi"}},{"Code":"536","Description":"Açıklama 536","Status":{"Value":"1","Name":"Olumlu"}},{"Code":"537","Description":"Açıklama 537","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"540","Description":"Açıklama 540","Status":{"Value":"1","Name":"Olumlu"}}]}', 1, CAST(N'2020-12-20T18:19:38.840' AS DateTime), CAST(N'2020-12-20T18:19:38.840' AS DateTime))
INSERT [SampleEngine].[ServiceRequestResponse] ([Id], [ProposalNo], [EndorsNo], [RenewalNo], [ProductNo], [RequestJson], [ResponseJson], [Status], [CreateDate], [UpdateDate]) VALUES (46, N'0', 0, 0, N'0', N'{"Authentication":{"Source":"SOMPO","Key":"77lTCSn41w"},"Object":{"ProposalNo":0,"EndorsNo":0,"RenewalNo":0,"ProductNo":"0"}}', N'{"Results":[{"Code":"916","Description":"Açıklama 916","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"946","Description":"Açıklama 946","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"935","Description":"Açıklama 935","Status":{"Value":"3","Name":"Olumsuz"}},{"Code":"977","Description":"Açıklama 977","Status":{"Value":"1","Name":"Olumlu"}},{"Code":"1191","Description":"Açıklama 1191","Status":{"Value":"1","Name":"Olumlu"}}]}', 1, CAST(N'2020-12-20T19:14:04.790' AS DateTime), CAST(N'2020-12-20T19:14:04.790' AS DateTime))
SET IDENTITY_INSERT [SampleEngine].[ServiceRequestResponse] OFF
