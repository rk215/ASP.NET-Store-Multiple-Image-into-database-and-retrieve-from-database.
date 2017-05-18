USE [test]
GO

/****** Object:  Table [dbo].[multipleimageupdate]    Script Date: 5/18/2017 11:26:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[multipleimageupdate](
	[i] [int] IDENTITY(1,1) NOT NULL,
	[fimg] [varchar](100) NULL,
	[simg] [varchar](100) NULL,
	[timg] [varchar](100) NULL
) ON [PRIMARY]

GO


