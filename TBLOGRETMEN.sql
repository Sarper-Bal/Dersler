USE [Dkayıt]
GO

/****** Object:  Table [dbo].[TBLOGRETMEN]    Script Date: 22.7.2019 15:04:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TBLOGRETMEN](
	[OGRTID] [int] IDENTITY(1,1) NOT NULL,
	[OGRTADSOYAD] [varchar](50) NULL,
	[OGRTBRANS] [int] NULL,
 CONSTRAINT [PK_TBLOGRETMEN] PRIMARY KEY CLUSTERED 
(
	[OGRTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TBLOGRETMEN]  WITH CHECK ADD  CONSTRAINT [FK_TBLOGRETMEN_TBLDERSLER] FOREIGN KEY([OGRTBRANS])
REFERENCES [dbo].[TBLDERSLER] ([DERSID])
GO

ALTER TABLE [dbo].[TBLOGRETMEN] CHECK CONSTRAINT [FK_TBLOGRETMEN_TBLDERSLER]
GO

