
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](50) NULL,
	[IsDeleted] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kategori] ON
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (1, N'Roman', 1)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (2, N'Hikaye', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (3, N'Polisiye', 1)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (4, N'Masal', 1)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (5, N'Şiir', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (6, N'Felsefe', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (7, N'Sosyoloji', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (8, N'Siyaset', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (9, N'Eğitim', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (10, N'Ansiklopedi', 1)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (11, N'Edebiyat', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (12, N'Sanat', 0)
INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi], [IsDeleted]) VALUES (13, N'Mizah', 0)
SET IDENTITY_INSERT [dbo].[Kategori] OFF
/****** Object:  Table [dbo].[Bolum]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolum](
	[BolumID] [int] IDENTITY(1,1) NOT NULL,
	[BolumAdi] [nvarchar](50) NULL,
	[Isdeleted] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BolumID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bolum] ON
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (1, N'Matematik Mühendisliği', 1)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (2, N'Fizik Mühendisliği', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (3, N'Yazılım Mühendisliği', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (4, N'Mekatronik Mühendisliği', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (5, N'Hukuk', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (6, N'Tarih', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (7, N'Sosyoloji', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (8, N'Felsefe', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (9, N'Psikoloji', 1)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (10, N'İngilizce', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (11, N'Makine Mühendisliği', 0)
INSERT [dbo].[Bolum] ([BolumID], [BolumAdi], [Isdeleted]) VALUES (12, N'Bilgisayar Mühendisliği', 0)
SET IDENTITY_INSERT [dbo].[Bolum] OFF
/****** Object:  Table [dbo].[Yazar]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[YazarID] [int] IDENTITY(1,1) NOT NULL,
	[Adi_Soyadi] [nvarchar](50) NULL,
	[IsDeleted] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[YazarID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Yazar] ON
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (1, N'Orhan VELİ', 1)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (2, N'Ayşe KULİN', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (3, N'Ömer Seyfettin', 1)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (4, N'Dostoyevski', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (5, N'Canan TAN', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (6, N'Ahmet ÜMİT', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (7, N'İpek ONGUN', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (8, N'Sabahattin ALİ', 0)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (9, N'Elif ŞAFAK', 1)
INSERT [dbo].[Yazar] ([YazarID], [Adi_Soyadi], [IsDeleted]) VALUES (10, N'Süleyman ÖZIŞIK', 0)
SET IDENTITY_INSERT [dbo].[Yazar] OFF
/****** Object:  View [dbo].[VwYazar]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwYazar] AS
Select*From Yazar
Where Isdeleted=0
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[KitapID] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [nvarchar](50) NULL,
	[KategoriID] [int] NULL,
	[YazarID] [int] NULL,
	[IsDeleted] [int] NULL,
	[ISBN] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[KitapID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kitap] ON
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (1, N'Olasılıksız', 1, 1, 1, -2807)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (2, N'Sefiller', 2, 2, 0, -1638)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (3, N'Gözlük', 3, 3, 1, -8348)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (4, N'Refleks', 4, 4, 0, -8473)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (5, N'Mülteci', 5, 5, 0, -8874)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (6, N'Çalıkuşu', 6, 6, 1, -5350)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (7, N'Fatih Harbiye', 7, 7, 0, -6103)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (8, N'Aşk Tesadüfleri Sever', 1, 8, 0, -8061)
INSERT [dbo].[Kitap] ([KitapID], [KitapAdi], [KategoriID], [YazarID], [IsDeleted], [ISBN]) VALUES (9, N'Sherlock Holmes', 6, 5, 0, -5012)
SET IDENTITY_INSERT [dbo].[Kitap] OFF
/****** Object:  View [dbo].[VwKategori]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwKategori] AS
Select*From Kategori
Where Isdeleted=0
GO
/****** Object:  View [dbo].[VwBolum]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwBolum] AS
Select*From Bolum
Where Isdeleted=0
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAdi] [nvarchar](50) NULL,
	[OgrenciSoyadi] [nvarchar](50) NULL,
	[OgrenciNo] [int] NULL,
	[BolumID] [int] NULL,
	[TCKimlikNo] [varchar](50) NULL,
	[TelefonNo] [varchar](50) NULL,
	[IsDeleted] [int] NULL,
 CONSTRAINT [PK__Ogrenci__E497E6D45DB5E0CB] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (1, N'aaaaaq', N'sssss', 423424242, 12, N'42342343333', N'53453444444', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (2, N'Ümit', N'AKINCI', 536485, 3, N'32547869532', N'5369827687', 1)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (3, N'Üzeyir', N'OKTAY', 135467, 5, N'21456325698', N'5325689632', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (4, N'Deniz', N'KADI', 564879, 9, N'32054760532', N'5556254879', 1)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (5, N'Berk', N'MERSİN', 625493, 5, N'62458796320', N'5456259866', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (6, N'Sinan', N'KAN', 986548, 2, N'23014587960', N'5314568928', 1)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (7, N'Semih', N'AKINCI', 853698, 8, N'46589350214', N'5398425131', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (8, N'Furkan', N'Türksoy', 364852, 4, N'98630254785', N'5356196995', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (9, N'Selim', N'ŞENOCAK', 250846, 7, N'23056975304', N'5379425447', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (10, N'Önder', N'ER', 198853532, 4, N'50035553590', N'5369827687', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (11, N'Tuğba', N'ÖZAY', 434234, 8, N'66666666666', N'55555555555', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (12, N'vvvvvvv', N'bbbbb', 66666666, 10, N'22222222222', N'44444444444', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (13, N'aaaaa', N'sssss', 423424245, 1, N'42342345555', N'53453455555', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (14, N'fffffaa', N'aaab', 2324242, 12, N'55555555554', N'99999999998', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (15, N'cccccc', N'dddd', 15734, 8, N'64', N'34', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (16, N'rrrrrrrrr', N'tttttttt', 52222, 5, N'88888888888', N'77777777777', 0)
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdi], [OgrenciSoyadi], [OgrenciNo], [BolumID], [TCKimlikNo], [TelefonNo], [IsDeleted]) VALUES (17, N'xxxxxxxxxxxx', N'yyyyyyyyyyyy', 222222222, 11, N'66666666666', N'22222222222', 0)
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
/****** Object:  Table [dbo].[Odunc]    Script Date: 08/15/2016 17:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odunc](
	[OduncID] [int] IDENTITY(1,1) NOT NULL,
	[KitapID] [int] NULL,
	[OgrenciID] [int] NULL,
	[VerilmeTarihi] [datetime] NULL,
	[IadeTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[OduncID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Odunc] ON
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (1, 3, 2, CAST(0x0000A58100000000 AS DateTime), CAST(0x0000A58200000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (2, 6, 15, CAST(0x0000A58D00000000 AS DateTime), CAST(0x0000A59D00000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (3, 2, 10, CAST(0x0000A65F0118FD10 AS DateTime), CAST(0x0000A6830118FC08 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (4, 4, 8, CAST(0x0000A6600089F5F8 AS DateTime), CAST(0x0000A6610089F5F8 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (5, 9, 2, CAST(0x0000A661008CA258 AS DateTime), CAST(0x0000A66F00000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (6, 1, 6, CAST(0x0000A66100000000 AS DateTime), CAST(0x0000A66900000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (7, 6, 4, CAST(0x0000A66000000000 AS DateTime), CAST(0x0000A66000000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (8, 4, 5, CAST(0x0000A66200000000 AS DateTime), CAST(0x0000A66F00000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (9, 1, 1, CAST(0x0000A58100000000 AS DateTime), CAST(0x0000A5A000000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (10, 1, 1, CAST(0x0000A58900000000 AS DateTime), CAST(0x0000A5AD00000000 AS DateTime))
INSERT [dbo].[Odunc] ([OduncID], [KitapID], [OgrenciID], [VerilmeTarihi], [IadeTarihi]) VALUES (11, 1, 5, CAST(0x0000A65A00000000 AS DateTime), CAST(0x0000A66F00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Odunc] OFF
/****** Object:  View [dbo].[Vwkitaptanimlama]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vwkitaptanimlama]
AS
SELECT     dbo.Kitap.KitapID, dbo.Kategori.KategoriID, dbo.Yazar.YazarID, dbo.Yazar.Adi_Soyadi, dbo.Kitap.KitapAdi, dbo.Kategori.KategoriAdi, dbo.Kitap.ISBN, 
                      dbo.Kitap.IsDeleted
FROM         dbo.Kategori INNER JOIN
                      dbo.Kitap ON dbo.Kategori.KategoriID = dbo.Kitap.KategoriID INNER JOIN
                      dbo.Yazar ON dbo.Kitap.YazarID = dbo.Yazar.YazarID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Kategori"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 99
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Kitap"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 114
               Right = 378
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Yazar"
            Begin Extent = 
               Top = 6
               Left = 416
               Bottom = 99
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vwkitaptanimlama'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vwkitaptanimlama'
GO
/****** Object:  View [dbo].[VwKitap]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwKitap] AS
Select*From Kitap
Where Isdeleted=0
GO
/****** Object:  View [dbo].[Vwogrencibolumu]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vwogrencibolumu]
AS
SELECT     dbo.Ogrenci.OgrenciID, dbo.Bolum.BolumID, dbo.Ogrenci.OgrenciAdi, dbo.Ogrenci.OgrenciSoyadi, dbo.Bolum.BolumAdi, dbo.Ogrenci.OgrenciNo, 
                      dbo.Ogrenci.TCKimlikNo, dbo.Ogrenci.TelefonNo, dbo.Ogrenci.IsDeleted
FROM         dbo.Bolum INNER JOIN
                      dbo.Ogrenci ON dbo.Bolum.BolumID = dbo.Ogrenci.BolumID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Bolum"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 182
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ogrenci"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 179
               Right = 378
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vwogrencibolumu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vwogrencibolumu'
GO
/****** Object:  View [dbo].[VwOgrenci]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwOgrenci] AS
Select*From Ogrenci
Where Isdeleted=0
GO
/****** Object:  View [dbo].[VwOdunctanimlama]    Script Date: 08/15/2016 17:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwOdunctanimlama]
AS
SELECT     dbo.Odunc.OduncID, dbo.Kitap.KitapID, dbo.Ogrenci.OgrenciID, dbo.Ogrenci.OgrenciAdi, dbo.Ogrenci.OgrenciSoyadi, dbo.Kitap.KitapAdi, 
                      dbo.Odunc.VerilmeTarihi, dbo.Odunc.IadeTarihi
FROM         dbo.Kitap INNER JOIN
                      dbo.Odunc ON dbo.Kitap.KitapID = dbo.Odunc.KitapID INNER JOIN
                      dbo.Ogrenci ON dbo.Odunc.OgrenciID = dbo.Ogrenci.OgrenciID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Kitap"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Odunc"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 114
               Right = 378
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Ogrenci"
            Begin Extent = 
               Top = 6
               Left = 416
               Bottom = 114
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwOdunctanimlama'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwOdunctanimlama'
GO
/****** Object:  ForeignKey [fk_yazar]    Script Date: 08/15/2016 17:21:39 ******/
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [fk_yazar] FOREIGN KEY([YazarID])
REFERENCES [dbo].[Yazar] ([YazarID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [fk_yazar]
GO
/****** Object:  ForeignKey [fk_kitap]    Script Date: 08/15/2016 17:21:39 ******/
ALTER TABLE [dbo].[Odunc]  WITH CHECK ADD  CONSTRAINT [fk_kitap] FOREIGN KEY([KitapID])
REFERENCES [dbo].[Kitap] ([KitapID])
GO
ALTER TABLE [dbo].[Odunc] CHECK CONSTRAINT [fk_kitap]
GO
/****** Object:  ForeignKey [fk_ogrenci]    Script Date: 08/15/2016 17:21:39 ******/
ALTER TABLE [dbo].[Odunc]  WITH CHECK ADD  CONSTRAINT [fk_ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[Odunc] CHECK CONSTRAINT [fk_ogrenci]
GO
/****** Object:  ForeignKey [fk_bolum]    Script Date: 08/15/2016 17:21:39 ******/
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [fk_bolum] FOREIGN KEY([BolumID])
REFERENCES [dbo].[Bolum] ([BolumID])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [fk_bolum]
GO
