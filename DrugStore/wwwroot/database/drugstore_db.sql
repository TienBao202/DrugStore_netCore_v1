USE [Demo_QLHT]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](256) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Phone_Number] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[IsAdmin] [bit] NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Employee] [int] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Agencies]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Agency_Code] [nvarchar](50) NOT NULL,
	[Agency_Name] [nvarchar](256) NOT NULL,
	[Phone_Number] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Delegate_Name] [nvarchar](max) NULL,
	[Display_Order] [int] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Agencies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countrys]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countrys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Country_Name] [nvarchar](256) NOT NULL,
	[Display_Order] [int] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Countrys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Code] [nvarchar](50) NOT NULL,
	[First_Name] [nvarchar](max) NULL,
	[Last_Name] [nvarchar](max) NULL,
	[Birth_Day] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[Phone_Number] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Tax_Code] [nvarchar](max) NULL,
	[Customer_Type] [bit] NOT NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_Code] [nvarchar](50) NOT NULL,
	[First_Name] [nvarchar](max) NULL,
	[Last_Name] [nvarchar](max) NULL,
	[Birth_Day] [nvarchar](max) NULL,
	[Gender] [bit] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Phone_Number] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Identity_Number] [nvarchar](max) NULL,
	[Identity_Date] [nvarchar](max) NULL,
	[Identity_Address] [nvarchar](max) NULL,
	[Salary_Min] [decimal](18, 2) NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Position] [int] NOT NULL,
	[ID_Agency] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Errors]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Errors](
	[Error_ID] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[StackTrace] [nvarchar](max) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Errors] PRIMARY KEY CLUSTERED 
(
	[Error_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice_Details]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice_Details](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Invoice] [int] NOT NULL,
	[ID_Medicine] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Invoice_Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Invoice_Code] [nvarchar](50) NOT NULL,
	[Total_Price] [decimal](18, 2) NOT NULL,
	[Discount] [real] NULL,
	[Customer_Pays] [decimal](18, 2) NOT NULL,
	[Return_Customer] [decimal](18, 2) NOT NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Customer] [int] NOT NULL,
	[ID_Agency] [int] NOT NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine_Batches]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine_Batches](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Medicine_Batch_Code] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Start_Date] [datetime2](7) NOT NULL,
	[End_Date] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Medicine] [int] NOT NULL,
	[ID_Country] [int] NOT NULL,
 CONSTRAINT [PK_Medicine_Batches] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine_Categories]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine_Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Code] [nvarchar](50) NOT NULL,
	[Category_Name] [nvarchar](256) NOT NULL,
	[Category_Alias] [nvarchar](max) NULL,
	[Category_Parent_ID] [int] NULL,
	[Display_Order] [int] NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
 CONSTRAINT [PK_Medicine_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine_Units]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine_Units](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Medicine_Unit_Name] [nvarchar](max) NOT NULL,
	[Display_Order] [int] NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
 CONSTRAINT [PK_Medicine_Units] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicines]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicines](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Medicine_Code] [nvarchar](50) NOT NULL,
	[Medicine_Name] [nvarchar](256) NOT NULL,
	[Medicine_Alias] [nvarchar](max) NULL,
	[Medicine_Image] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Original_Price] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Element] [nvarchar](max) NULL,
	[Effect] [nvarchar](max) NULL,
	[Indications] [nvarchar](max) NULL,
	[Contraindications] [nvarchar](max) NULL,
	[Caution] [nvarchar](max) NULL,
	[Dosage_And_Administration] [nvarchar](max) NULL,
	[Warranty] [int] NULL,
	[Packing] [nvarchar](max) NULL,
	[Inventory_Min] [int] NULL,
	[Inventory_Max] [int] NULL,
	[ID_Medicine_Category] [int] NOT NULL,
	[ID_Medicine_Unit] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
 CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Positions]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Position_Code] [nvarchar](50) NOT NULL,
	[Position_Name] [nvarchar](max) NOT NULL,
	[Position_Alias] [nvarchar](max) NULL,
	[Display_Order] [int] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchase_Order_Details]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Order_Details](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Purchase_Order] [int] NOT NULL,
	[ID_Medicine_Batch] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Purchase_Order_Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchase_Orders]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Purchase_Order_Code] [nvarchar](50) NOT NULL,
	[Total_Price] [decimal](18, 2) NOT NULL,
	[Discount] [real] NULL,
	[Amount_Payment] [decimal](18, 2) NOT NULL,
	[Amount_Owed] [decimal](18, 2) NOT NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Supplier] [int] NOT NULL,
	[ID_Agency] [int] NOT NULL,
 CONSTRAINT [PK_Purchase_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier_Groups]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier_Groups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Supplier_Group_Code] [nvarchar](50) NOT NULL,
	[Supplier_Group_Name] [nvarchar](max) NULL,
	[Display_Order] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Supplier_Groups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/4/2019 4:51:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Supplier_Code] [nvarchar](50) NOT NULL,
	[Supplier_Name] [nvarchar](max) NOT NULL,
	[Phone_Number] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Tax_Code] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Date_Created] [datetime2](7) NOT NULL,
	[Date_Modified] [datetime2](7) NOT NULL,
	[User_Created] [nvarchar](max) NULL,
	[User_Modified] [nvarchar](max) NULL,
	[ID_Supplier_Group] [int] NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (1, N'Kieu Thi Linh', N'kieulinh123', N'kieulinh123', N'112331723', N'kieulinh123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 15)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (2, N'Vu Xuan Dai', N'daidau07', N'daidau07', N'33232832', N'daidau07@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 14)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (3, N'Vu Thi Bich', N'vubich123', N'vubich123', N'1434563', N'vubich123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 16)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (4, N'Vuong trung kien', N'trungkien123', N'trungkien123', N'12723456', N'trungkien123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 17)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (5, N'Ta Minh Vuong', N'minhvuong123', N'minhvuong123', N'12738763', N'minhvuong123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 18)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (6, N'Kieu Van Truong', N'vantruong123', N'vantruong123', N'75586575', N'vantruong123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 19)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (7, N'Huynh Tien Tien', N'tientien123', N'tientien123', N'1276334553', N'tientien123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 20)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (8, N'Nguyen Chien Thang', N'chienthang123', N'chienthang123', N'12342343', N'chienthang123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 21)
INSERT [dbo].[Accounts] ([ID], [FullName], [UserName], [Password], [Phone_Number], [Email], [Address], [IsAdmin], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Employee]) VALUES (9, N'Nguyen Huyen Trang', N'huyentrang123', N'huyentrang123', N'91864397', N'huyentrang123@gmail.com', N'Ha Noi', NULL, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 22)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
SET IDENTITY_INSERT [dbo].[Agencies] ON 

INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (1, N'CN001', N'Chi nhánh trung tâm', N'032116655', N'CN1@gmail.com', N'Nguyễn Tiến Bảo', 1, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (2, N'CN002', N'Chi nhánh Hà N?i', N'16386273', N'lala@gmail.com', N'Ki?u Van A', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (3, N'CN003', N'Chi nhánh Hà Nam', N'12387123', N'lal1a@gmail.com', N'Ki?u Van o', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (4, N'CN003', N'Chi nhánh H?i Phòng', N'12123123', N'lal1a@gmail.com', N'Ki?u Van g', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (5, N'CN003', N'Chi nhánh Hung Yên', N'1245623', N'lal16a@gmail.com', N'Ki?u Van r', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (6, N'CN003', N'Chi nhánh Nam Ð?nh', N'12387345', N'lal14a@gmail.com', N'Ki?u Van v', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (7, N'CN003', N'Chi nhánh Ti?n Giang', N'12387234', N'la5l1a@gmail.com', N'Ki?u Van q', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (8, N'CN003', N'Chi nhánh Vung Tàu', N'12387643', N'lal31a@gmail.com', N'Ki?u Van c', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (9, N'CN003', N'Chi nhánh Gia Lai', N'12387346', N'lal12a@gmail.com', N'Ki?u Van y', 2, 1)
INSERT [dbo].[Agencies] ([ID], [Agency_Code], [Agency_Name], [Phone_Number], [Email], [Delegate_Name], [Display_Order], [Status]) VALUES (10, N'CN003', N'Chi nhánh Biên Hòa', N'12387108', N'lal11a@gmail.com', N'Ki?u Van u', 2, 1)
SET IDENTITY_INSERT [dbo].[Agencies] OFF
SET IDENTITY_INSERT [dbo].[Countrys] ON 

INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (1, N'Trung Quốc', 1, 1)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (2, N'Đức', 2, 1)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (3, N'Hà Lan', 3, 2)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (4, N'Mỹ', 3, 1)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (5, N'Bỉ', 1, 1)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (6, N'Anh', 1, 1)
INSERT [dbo].[Countrys] ([ID], [Country_Name], [Display_Order], [Status]) VALUES (7, N'Nhật Bản', 1, 1)
SET IDENTITY_INSERT [dbo].[Countrys] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (6, N'KH0001', N'Đỗ Văn ', N'Khánh', N'02/11/1997', 1, N'032116655', NULL, N'VanKhanh@gmail.com', N'000011111110', 1, 1, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (7, N'KH0002', N'Kiều Văn', N'Chuẩn', N'11/05/1997', 1, N'012356565', NULL, N'KieuVanChuan@gmail.com', NULL, 1, 1, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (8, N'KH0003', N'Đỗ Thị Thu ', N'Trang', N'05/02/1998', 0, N'0326666777', NULL, N'QTMT@gmail.com', NULL, 1, 1, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (9, N'KH0004', N'Nguyễn Thị Khánh ', N'Huyền', N'12/02/1998', 0, NULL, NULL, NULL, NULL, 1, 1, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (10, N'KH0005', N'Đỗ Danh', N'Nam', N'10/10/1997', 1, NULL, NULL, NULL, NULL, 1, 0, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (12, N'KH0006', N'Nhà thuốc ', N'01', NULL, NULL, N'032666999', NULL, NULL, NULL, 0, 1, CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-02 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (14, N'KH0009', N'Đào Tùng', N'Anh', N'12/10/1997', 1, N'032665511', N'Hà Nội', N'TungAnh@gmail.com', N'000011111110', 1, 1, CAST(N'2019-10-27 13:49:28.9390000' AS DateTime2), CAST(N'2019-10-27 13:49:28.9390000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (15, N'KH0010', N'Nguyễn Văn', N'Đại', N'11/11/1997', 1, N'03299885544', N'Hà Nội', N'VanDai@gmail.com', N'000001111111', 0, 1, CAST(N'2019-10-27 13:52:04.3650000' AS DateTime2), CAST(N'2019-10-27 13:52:04.3650000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Customer_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Phone_Number], [Address], [Email], [Tax_Code], [Customer_Type], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (16, N'KH0011', N'Quầy thuốc', N'Minh Tâm', NULL, 1, N'0326666777', N'Cầu giấy', N'QTMT11111@gmail.com', N'000011111110', 0, 1, CAST(N'2019-10-27 14:13:38.2680000' AS DateTime2), CAST(N'2019-10-27 14:13:38.2680000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (4, N'NV0001', N'Đỗ Duy', N'Anh', N'20/04/1997', 1, N'Hà Nội', N'032996655', N'DuyAnh@gmail.com', N'001097001133', N'27/04/2015', N'Hà Nội', CAST(5000000.00 AS Decimal(18, 2)), 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 1, 1)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (14, N'NV0001', N'Nguyễn Văn', N'Đại', N'12/10/1997', 1, N'Hà Nội', N'0326666777', NULL, N'0010025666', N'12/10/2015', N'Hà Nội', NULL, 1, CAST(N'2019-10-29 09:49:42.8384412' AS DateTime2), CAST(N'2019-10-29 09:49:42.8384435' AS DateTime2), NULL, NULL, 1, 1)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (15, N'NV0003', N'Nguyễn Thu', N'Hà', N'1997-10-21T17:00:00.000Z', 0, NULL, N'0326666777', N'QTMT@gmail.com', N'0010025666', N'2015-02-11T17:00:00.000Z', NULL, NULL, 1, CAST(N'2019-10-29 10:09:05.1069166' AS DateTime2), CAST(N'2019-10-29 10:09:05.1071549' AS DateTime2), NULL, NULL, 1, 1)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (16, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 1, 1)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (17, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 2, 4)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (18, N'NV004', N'Ki?u Van', N'Anh', N'07/21/1995', 1, N'Hà N?i', N'027826263', N'aqasda@gmail.com', N'012318162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 3, 2)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (19, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 4, 1)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (20, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 3, 2)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (21, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 2, 3)
INSERT [dbo].[Employees] ([ID], [Employee_Code], [First_Name], [Last_Name], [Birth_Day], [Gender], [Address], [Phone_Number], [Email], [Identity_Number], [Identity_Date], [Identity_Address], [Salary_Min], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Position], [ID_Agency]) VALUES (22, N'NV004', N'Vu Van', N'Tình', N'07/20/1997', 1, N'Hà N?i', N'02782663', N'asda@gmail.com', N'012378162382', N'10/10/2015', N'Hà N?i', NULL, 1, CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-22 00:00:00.0000000' AS DateTime2), NULL, NULL, 1, 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Medicine_Batches] ON 

INSERT [dbo].[Medicine_Batches] ([ID], [Medicine_Batch_Code], [Quantity], [Start_Date], [End_Date], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Medicine], [ID_Country]) VALUES (14, N'KH0006', 6, CAST(N'2019-01-11 17:00:00.0000000' AS DateTime2), CAST(N'2019-02-11 17:00:00.0000000' AS DateTime2), 1, CAST(N'2019-10-30 14:24:45.3439115' AS DateTime2), CAST(N'2019-10-30 14:27:05.7761219' AS DateTime2), NULL, NULL, 19, 1)
SET IDENTITY_INSERT [dbo].[Medicine_Batches] OFF
SET IDENTITY_INSERT [dbo].[Medicine_Categories] ON 

INSERT [dbo].[Medicine_Categories] ([ID], [Category_Code], [Category_Name], [Category_Alias], [Category_Parent_ID], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (3, N'MH001', N'Thực phẩm chức năng', N'TPCN', NULL, 1, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-30 13:14:10.7274848' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Categories] ([ID], [Category_Code], [Category_Name], [Category_Alias], [Category_Parent_ID], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (5, N'2', N'dụng cụ y tế', NULL, NULL, NULL, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Categories] ([ID], [Category_Code], [Category_Name], [Category_Alias], [Category_Parent_ID], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (6, N'3', N'Thuốc chống viêm', NULL, NULL, NULL, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Categories] ([ID], [Category_Code], [Category_Name], [Category_Alias], [Category_Parent_ID], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (7, N'4', N'Thuốc dị ứng', NULL, NULL, NULL, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Categories] ([ID], [Category_Code], [Category_Name], [Category_Alias], [Category_Parent_ID], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (8, N'5', N'Thuốc giảm đau', NULL, NULL, NULL, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Medicine_Categories] OFF
SET IDENTITY_INSERT [dbo].[Medicine_Units] ON 

INSERT [dbo].[Medicine_Units] ([ID], [Medicine_Unit_Name], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (1, N'Hộp', 1, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Units] ([ID], [Medicine_Unit_Name], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (2, N'Vỉ', 2, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicine_Units] ([ID], [Medicine_Unit_Name], [Display_Order], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (3, N'Viên', 3, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Medicine_Units] OFF
SET IDENTITY_INSERT [dbo].[Medicines] ON 

INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (9, N'	
SP000001', N'Dầu Gấc Vinaga', NULL, NULL, CAST(850.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), 100, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 1, 1, CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-20 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (14, N'SP000002', N'	Zentomum', NULL, NULL, CAST(100.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 5, 3, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (18, N'SP000003', N'GingkoSoftM6', NULL, NULL, CAST(40.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (19, N'SP000004', N'Acnacare', NULL, NULL, CAST(60.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 50, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 5, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (22, N'SP000005', N'NattoGinkgo', NULL, NULL, CAST(100.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 3, 1, CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (23, N'SP000006', N'Đè Lưỡi Gỗi Hanomed', NULL, NULL, CAST(4.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 6, 2, 1, CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (24, N'SP000006', N'Cao Dan Salonsip', NULL, NULL, CAST(130.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (25, N'SP000008', N'Ecosipcool', NULL, NULL, CAST(80.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 6, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (26, N'SP000009', N'Nhi?t K? Aurora', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (27, N'SP0000010', N'Medrol', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (28, N'SP0000011', N'Mobic', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (29, N'SP0000012', N'Detromethorpharn', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (30, N'SP0000013', N'Dimicox', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Medicines] ([ID], [Medicine_Code], [Medicine_Name], [Medicine_Alias], [Medicine_Image], [Price], [Original_Price], [Quantity], [Element], [Effect], [Indications], [Contraindications], [Caution], [Dosage_And_Administration], [Warranty], [Packing], [Inventory_Min], [Inventory_Max], [ID_Medicine_Category], [ID_Medicine_Unit], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified]) VALUES (31, N'SP0000014', N'Bromuric', NULL, NULL, CAST(260.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 2, 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Medicines] OFF
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (1, N'CV001', N'Quản lý kinh doanh', N'QuanLyKinhDoanh', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (2, N'CV003', N'Nhân Viên', N'NhanVien', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (3, N'CV004', N'Nhân Viên', N'NhanVien', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (4, N'CV005', N'Giám d?c chi nhánh', N'GiamDocChiNhanh', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (5, N'CV006', N'Nhân Viên Bán Hàng', N'NhanVienBanHang', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (6, N'CV007', N'Nhân Viên Kho', N'NhanVienKho', 1, 1)
INSERT [dbo].[Positions] ([ID], [Position_Code], [Position_Name], [Position_Alias], [Display_Order], [Status]) VALUES (7, N'CV008', N'Qu?n Lý Kho', N'QuanLyKho', 1, 1)
SET IDENTITY_INSERT [dbo].[Positions] OFF
SET IDENTITY_INSERT [dbo].[Supplier_Groups] ON 

INSERT [dbo].[Supplier_Groups] ([ID], [Supplier_Group_Code], [Supplier_Group_Name], [Display_Order], [Description], [Status]) VALUES (1, N'SG001', N'Thường xuyên', 1, N'Thương xuyên', 1)
SET IDENTITY_INSERT [dbo].[Supplier_Groups] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (1, N'SL001', N'C?a hàng Ð?i Vi?t', N'172381293', N'Hà N?i', N'asddfas@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (2, N'SL002', N'C?a hàng An Bình', N'34581293', N'Nam Ð?nh', N'asdas@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (3, N'SL003', N'C?a hàng Bình Phúc', N'562381293', N'Hà Nam', N'asdhas@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (4, N'SL004', N'Công ty Pharmedic', N'342381293', N'H?i Phòng', N'asdgas@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (5, N'SL005', N'Công ty V?n Phúc', N'12381293', N'Vung Tàu', N'asdafas@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Suppliers] ([ID], [Supplier_Code], [Supplier_Name], [Phone_Number], [Address], [Email], [Tax_Code], [Status], [Date_Created], [Date_Modified], [User_Created], [User_Modified], [ID_Supplier_Group]) VALUES (6, N'SL006', N'Công ty TNHH Citigo', N'107381293', N'Gia Lai', N'asdasa@gmail.com', N'123213', 1, CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), CAST(N'2019-10-10 00:00:00.0000000' AS DateTime2), NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Employees_ID_Employee] FOREIGN KEY([ID_Employee])
REFERENCES [dbo].[Employees] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Employees_ID_Employee]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Agencies_ID_Agency] FOREIGN KEY([ID_Agency])
REFERENCES [dbo].[Agencies] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Agencies_ID_Agency]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Positions_ID_Position] FOREIGN KEY([ID_Position])
REFERENCES [dbo].[Positions] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Positions_ID_Position]
GO
ALTER TABLE [dbo].[Invoice_Details]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Details_Invoices_ID_Invoice] FOREIGN KEY([ID_Invoice])
REFERENCES [dbo].[Invoices] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice_Details] CHECK CONSTRAINT [FK_Invoice_Details_Invoices_ID_Invoice]
GO
ALTER TABLE [dbo].[Invoice_Details]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Details_Medicines_ID_Medicine] FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice_Details] CHECK CONSTRAINT [FK_Invoice_Details_Medicines_ID_Medicine]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Agencies_ID_Agency] FOREIGN KEY([ID_Agency])
REFERENCES [dbo].[Agencies] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Agencies_ID_Agency]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Customers_ID_Customer] FOREIGN KEY([ID_Customer])
REFERENCES [dbo].[Customers] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Customers_ID_Customer]
GO
ALTER TABLE [dbo].[Medicine_Batches]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Batches_Countrys_ID_Country] FOREIGN KEY([ID_Country])
REFERENCES [dbo].[Countrys] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicine_Batches] CHECK CONSTRAINT [FK_Medicine_Batches_Countrys_ID_Country]
GO
ALTER TABLE [dbo].[Medicine_Batches]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Batches_Medicines_ID_Medicine] FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[Medicines] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicine_Batches] CHECK CONSTRAINT [FK_Medicine_Batches_Medicines_ID_Medicine]
GO
ALTER TABLE [dbo].[Medicines]  WITH CHECK ADD  CONSTRAINT [FK_Medicines_Medicine_Categories_ID_Medicine_Category] FOREIGN KEY([ID_Medicine_Category])
REFERENCES [dbo].[Medicine_Categories] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicines] CHECK CONSTRAINT [FK_Medicines_Medicine_Categories_ID_Medicine_Category]
GO
ALTER TABLE [dbo].[Medicines]  WITH CHECK ADD  CONSTRAINT [FK_Medicines_Medicine_Units_ID_Medicine_Unit] FOREIGN KEY([ID_Medicine_Unit])
REFERENCES [dbo].[Medicine_Units] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicines] CHECK CONSTRAINT [FK_Medicines_Medicine_Units_ID_Medicine_Unit]
GO
ALTER TABLE [dbo].[Purchase_Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Order_Details_Medicine_Batches_ID_Medicine_Batch] FOREIGN KEY([ID_Medicine_Batch])
REFERENCES [dbo].[Medicine_Batches] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Order_Details] CHECK CONSTRAINT [FK_Purchase_Order_Details_Medicine_Batches_ID_Medicine_Batch]
GO
ALTER TABLE [dbo].[Purchase_Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Order_Details_Purchase_Orders_ID_Purchase_Order] FOREIGN KEY([ID_Purchase_Order])
REFERENCES [dbo].[Purchase_Orders] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Order_Details] CHECK CONSTRAINT [FK_Purchase_Order_Details_Purchase_Orders_ID_Purchase_Order]
GO
ALTER TABLE [dbo].[Purchase_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Orders_Agencies_ID_Agency] FOREIGN KEY([ID_Agency])
REFERENCES [dbo].[Agencies] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Orders] CHECK CONSTRAINT [FK_Purchase_Orders_Agencies_ID_Agency]
GO
ALTER TABLE [dbo].[Purchase_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Orders_Suppliers_ID_Supplier] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[Suppliers] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Orders] CHECK CONSTRAINT [FK_Purchase_Orders_Suppliers_ID_Supplier]
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Suppliers_Supplier_Groups_ID_Supplier_Group] FOREIGN KEY([ID_Supplier_Group])
REFERENCES [dbo].[Supplier_Groups] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Suppliers] CHECK CONSTRAINT [FK_Suppliers_Supplier_Groups_ID_Supplier_Group]
GO
