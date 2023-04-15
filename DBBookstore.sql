USE [DBBookstore]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/15/2023 4:21:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[isAdmin] [tinyint] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookInfo]    Script Date: 4/15/2023 4:21:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookInfo](
	[BookName] [nvarchar](50) NOT NULL,
	[WriterName] [nvarchar](50) NOT NULL,
	[NationBook] [nvarchar](50) NOT NULL,
	[PriceBook] [decimal](18, 0) NOT NULL,
	[QuantityBook] [int] NOT NULL,
	[CategoryBook] [nvarchar](50) NOT NULL,
	[Image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
