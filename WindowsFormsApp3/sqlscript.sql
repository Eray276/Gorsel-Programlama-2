USE [sinematakip]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 16.06.2023 01:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[Film_Id] [int] IDENTITY(1,1) NOT NULL,
	[Film_Adı] [text] NOT NULL,
	[Seans_Saati] [text] NOT NULL,
	[Salon_Id] [int] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[Film_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Müşteri]    Script Date: 16.06.2023 01:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Müşteri](
	[Müşteri_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad_Soyad] [text] NOT NULL,
	[Bilet_Sayısı] [int] NOT NULL,
	[Bilet_Aralığı] [text] NOT NULL,
	[Film_Id] [int] NOT NULL,
	[Salon_Id] [int] NOT NULL,
 CONSTRAINT [PK_Müşteri] PRIMARY KEY CLUSTERED 
(
	[Müşteri_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon]    Script Date: 16.06.2023 01:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[Salon_Id] [int] NOT NULL,
	[Salon_Adı] [text] NOT NULL,
	[Koltuk_Sayısı] [int] NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[Salon_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_Salon] FOREIGN KEY([Salon_Id])
REFERENCES [dbo].[Salon] ([Salon_Id])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_Salon]
GO
ALTER TABLE [dbo].[Müşteri]  WITH CHECK ADD  CONSTRAINT [FK_Müşteri_Film] FOREIGN KEY([Film_Id])
REFERENCES [dbo].[Film] ([Film_Id])
GO
ALTER TABLE [dbo].[Müşteri] CHECK CONSTRAINT [FK_Müşteri_Film]
GO
ALTER TABLE [dbo].[Müşteri]  WITH CHECK ADD  CONSTRAINT [FK_Müşteri_Salon] FOREIGN KEY([Salon_Id])
REFERENCES [dbo].[Salon] ([Salon_Id])
GO
ALTER TABLE [dbo].[Müşteri] CHECK CONSTRAINT [FK_Müşteri_Salon]
GO
