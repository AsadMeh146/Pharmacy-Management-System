USE [FinalProject]
GO
/****** Object:  Table [dbo].[AttendanceDate]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceDate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendanceStatus]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceStatus](
	[Employee ID] [int] NOT NULL,
	[Attendance ID] [int] NOT NULL,
	[Attendance Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee ID] ASC,
	[Attendance ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[ContactNumber] [nvarchar](24) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](250) NULL,
	[City] [varchar](25) NULL,
	[Country] [varchar](25) NULL,
	[PIN] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrder](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[Order Date] [datetime] NULL,
	[Pharmacy Id] [int] NULL,
	[Order Type] [int] NULL,
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrderDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrderDetails](
	[Order Id] [int] NOT NULL,
	[Manufacture Id] [int] NOT NULL,
	[Product Id] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order Id] ASC,
	[Manufacture Id] ASC,
	[Product Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[RegistrationNumber] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[PIN] [varchar](25) NULL,
	[CNIC] [char](13) NULL,
	[Gender] [char](1) NULL,
	[Salary] [int] NULL,
	[Designation] [int] NULL,
	[Date Of Birth] [datetime] NULL,
	[City] [varchar](25) NULL,
	[Country] [varchar](25) NULL,
	[Address] [varchar](250) NULL,
	[Pharmacy Id] [int] NULL,
	[Status] [int] NULL,
	[Hire Date] [datetime] NULL,
	[Email] [varchar](50) NULL,
	[ContactNumber] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[RegistrationNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeLoan]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeLoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[Purpose] [varchar](250) NULL,
	[AmountRequested] [int] NULL,
	[AmountAccepted] [int] NULL,
	[ApplyDate] [datetime] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Category] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManufacturerDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManufacturerDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[City] [varchar](30) NULL,
	[Country] [varchar](30) NULL,
	[Address] [varchar](250) NULL,
	[ContactNumber] [nvarchar](24) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacy]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](250) NULL,
	[ContactNumber] [nvarchar](24) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Type] [int] NULL,
	[Purchase Price] [float] NULL,
	[Sale Price] [float] NULL,
	[Description] [varchar](250) NULL,
	[ManufacturerId] [int] NULL,
	[Expiry Date] [datetime] NULL,
	[Manufacturing Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnCustomerOrder]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnCustomerOrder](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[ReturnDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC,
	[ReturnDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnStockOrder]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnStockOrder](
	[StockOrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NULL,
	[ReturnDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StockOrderId] ASC,
	[ProductId] ASC,
	[ReturnDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[Contact Number] [varchar](24) NULL,
	[Manufacturer Id] [int] NULL,
	[Address] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Pharmacy Id] [int] NOT NULL,
	[Product Id] [int] NOT NULL,
	[Manufacturer ID] [int] NOT NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Pharmacy Id] ASC,
	[Product Id] ASC,
	[Manufacturer ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOrder]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pharmacy Id] [int] NULL,
	[Order Date] [datetime] NULL,
	[Shipped Date] [datetime] NULL,
	[Shipper Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOrderDetails]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOrderDetails](
	[Order Id] [int] NOT NULL,
	[Manufacture Id] [int] NOT NULL,
	[Product Id] [int] NOT NULL,
	[Unit Price] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order Id] ASC,
	[Manufacture Id] ASC,
	[Product Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AttendanceDate] ON 

INSERT [dbo].[AttendanceDate] ([Id], [Date]) VALUES (1, CAST(N'2022-04-06T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[AttendanceDate] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerDetails] ON 

INSERT [dbo].[CustomerDetails] ([Id], [Name], [ContactNumber], [Email], [Address], [City], [Country], [PIN]) VALUES (2, N'asdf', N'sf', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CustomerDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerOrder] ON 

INSERT [dbo].[CustomerOrder] ([OrderId], [CustomerId], [Order Date], [Pharmacy Id], [Order Type], [Discount]) VALUES (1, 2, CAST(N'2022-04-30T11:21:56.000' AS DateTime), 2, 16, 15)
INSERT [dbo].[CustomerOrder] ([OrderId], [CustomerId], [Order Date], [Pharmacy Id], [Order Type], [Discount]) VALUES (2, 2, CAST(N'2010-10-10T00:00:00.000' AS DateTime), 2, 16, 15)
INSERT [dbo].[CustomerOrder] ([OrderId], [CustomerId], [Order Date], [Pharmacy Id], [Order Type], [Discount]) VALUES (3, 2, CAST(N'2010-10-10T00:00:00.000' AS DateTime), 2, 16, 15)
INSERT [dbo].[CustomerOrder] ([OrderId], [CustomerId], [Order Date], [Pharmacy Id], [Order Type], [Discount]) VALUES (4, 2, CAST(N'2010-10-10T00:00:00.000' AS DateTime), 2, 16, 15)
SET IDENTITY_INSERT [dbo].[CustomerOrder] OFF
GO
INSERT [dbo].[CustomerOrderDetails] ([Order Id], [Manufacture Id], [Product Id], [Quantity], [Price]) VALUES (1, 1, 4, 10, 65)
INSERT [dbo].[CustomerOrderDetails] ([Order Id], [Manufacture Id], [Product Id], [Quantity], [Price]) VALUES (1, 1, 5, 5, 65)
GO
SET IDENTITY_INSERT [dbo].[EmployeeDetails] ON 

INSERT [dbo].[EmployeeDetails] ([RegistrationNumber], [Name], [PIN], [CNIC], [Gender], [Salary], [Designation], [Date Of Birth], [City], [Country], [Address], [Pharmacy Id], [Status], [Hire Date], [Email], [ContactNumber]) VALUES (1, N'Admin1', N'1231', N'3630227267087', N'M', 10000, 1, CAST(N'2010-10-10T00:00:00.000' AS DateTime), N'multan', N'Pakistan', N'housedd', 2, 5, CAST(N'2011-11-11T00:00:00.000' AS DateTime), N'2020cs27@asdfg', N'03019123200')
INSERT [dbo].[EmployeeDetails] ([RegistrationNumber], [Name], [PIN], [CNIC], [Gender], [Salary], [Designation], [Date Of Birth], [City], [Country], [Address], [Pharmacy Id], [Status], [Hire Date], [Email], [ContactNumber]) VALUES (2, N'ali', N'a5@f5555555555', N'3630227267085', N'M', 6646, 2, CAST(N'2022-04-01T00:00:00.000' AS DateTime), N'vggg', N'asdf', N'hn', 2, 4, CAST(N'2022-04-21T00:00:00.000' AS DateTime), N'kashir74@gmail.com', N'03012677768')
SET IDENTITY_INSERT [dbo].[EmployeeDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeLoan] ON 

INSERT [dbo].[EmployeeLoan] ([Id], [EmployeeId], [Purpose], [AmountRequested], [AmountAccepted], [ApplyDate], [Status]) VALUES (1, 1, N'asdfg', 6546, 0, CAST(N'2022-04-30T11:17:58.000' AS DateTime), 14)
INSERT [dbo].[EmployeeLoan] ([Id], [EmployeeId], [Purpose], [AmountRequested], [AmountAccepted], [ApplyDate], [Status]) VALUES (2, 1, N'asdfg', 6546, 6546, CAST(N'2022-04-30T11:17:58.000' AS DateTime), 12)
INSERT [dbo].[EmployeeLoan] ([Id], [EmployeeId], [Purpose], [AmountRequested], [AmountAccepted], [ApplyDate], [Status]) VALUES (3, 1, N'asdfg', 6546, 0, CAST(N'2022-04-30T11:17:58.000' AS DateTime), 14)
INSERT [dbo].[EmployeeLoan] ([Id], [EmployeeId], [Purpose], [AmountRequested], [AmountAccepted], [ApplyDate], [Status]) VALUES (4, 1, N'asdfg', 6546, 0, CAST(N'2022-04-30T11:17:58.000' AS DateTime), 14)
SET IDENTITY_INSERT [dbo].[EmployeeLoan] OFF
GO
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (1, N'Admin', N'EMPLOYEE_DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (2, N'Cashier', N'EMPLOYEE_DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (3, N'DelieveryBoy', N'EMPLOYEE_DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (4, N'Active', N'EMPLOYEE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (5, N'InActive', N'EMPLOYEE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (6, N'Present', N'ATTENDANCE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (7, N'Absent', N'ATTENDANCE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (8, N'Late', N'ATTENDANCE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (9, N'Leave', N'ATTENDANCE_STATUS')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (10, N'Anti-Biotic', N'Medicine Type')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (11, N'Non-Anti-Biotic', N'Medicine Type')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (12, N'Approved', N'LoanStatus')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (13, N'Disapproved', N'LoanStatus')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (14, N'Waiting', N'LoanStatus')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (15, N'Online', N'ORDER TYPE')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (16, N'OnPharmacy', N'ORDER TYPE')
INSERT [dbo].[Lookup] ([Id], [Name], [Category]) VALUES (17, N'15', N'Discount')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
GO
SET IDENTITY_INSERT [dbo].[ManufacturerDetails] ON 

INSERT [dbo].[ManufacturerDetails] ([Id], [Name], [City], [Country], [Address], [ContactNumber], [Email]) VALUES (1, N'asfg', N'zsdfg', N'zsdfg', N'zxcf', N'6', N'sdf')
INSERT [dbo].[ManufacturerDetails] ([Id], [Name], [City], [Country], [Address], [ContactNumber], [Email]) VALUES (2, N'asfg', N'zsdfg', N'zsdfg', N'zxcf', N'6', N'sdf')
INSERT [dbo].[ManufacturerDetails] ([Id], [Name], [City], [Country], [Address], [ContactNumber], [Email]) VALUES (3, N'asfg', N'zsdfg', N'zsdfg', N'zxcf', N'6', N'sdf')
SET IDENTITY_INSERT [dbo].[ManufacturerDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Pharmacy] ON 

INSERT [dbo].[Pharmacy] ([Id], [Location], [ContactNumber]) VALUES (1, N'ghari shahoo', N'03019123200')
INSERT [dbo].[Pharmacy] ([Id], [Location], [ContactNumber]) VALUES (2, N'ghari shahoo', N'03019123200')
INSERT [dbo].[Pharmacy] ([Id], [Location], [ContactNumber]) VALUES (3, N'ghari shahoo', N'03019123200')
INSERT [dbo].[Pharmacy] ([Id], [Location], [ContactNumber]) VALUES (4, N'ghari shahoo', N'03019123200')
SET IDENTITY_INSERT [dbo].[Pharmacy] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDetails] ON 

INSERT [dbo].[ProductDetails] ([Id], [Name], [Type], [Purchase Price], [Sale Price], [Description], [ManufacturerId], [Expiry Date], [Manufacturing Date]) VALUES (3, N'asd', 10, 45, 1215, N'24lbg', 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime), CAST(N'2022-04-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ProductDetails] ([Id], [Name], [Type], [Purchase Price], [Sale Price], [Description], [ManufacturerId], [Expiry Date], [Manufacturing Date]) VALUES (4, N'medicine4', 11, 15, 65, N'asdfg', 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime), CAST(N'2022-03-28T00:00:00.000' AS DateTime))
INSERT [dbo].[ProductDetails] ([Id], [Name], [Type], [Purchase Price], [Sale Price], [Description], [ManufacturerId], [Expiry Date], [Manufacturing Date]) VALUES (5, N'asrfy', 11, 15, 65, N'asdfg', 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime), CAST(N'2022-03-28T00:00:00.000' AS DateTime))
INSERT [dbo].[ProductDetails] ([Id], [Name], [Type], [Purchase Price], [Sale Price], [Description], [ManufacturerId], [Expiry Date], [Manufacturing Date]) VALUES (6, N'asrfy', 11, 15, 65, N'asdfg', 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime), CAST(N'2022-03-28T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductDetails] OFF
GO
INSERT [dbo].[ReturnCustomerOrder] ([OrderID], [ProductID], [Quantity], [ReturnDate]) VALUES (1, 4, 6, CAST(N'2022-04-30T11:24:01.000' AS DateTime))
INSERT [dbo].[ReturnCustomerOrder] ([OrderID], [ProductID], [Quantity], [ReturnDate]) VALUES (1, 5, 2, CAST(N'2022-04-30T11:23:10.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Shippers] ON 

INSERT [dbo].[Shippers] ([Id], [name], [Contact Number], [Manufacturer Id], [Address]) VALUES (1, N'sdfg', N'663', 1, N'asd')
INSERT [dbo].[Shippers] ([Id], [name], [Contact Number], [Manufacturer Id], [Address]) VALUES (2, N'sdfg', N'663', 1, N'asd')
INSERT [dbo].[Shippers] ([Id], [name], [Contact Number], [Manufacturer Id], [Address]) VALUES (4, N'sdfg', N'663', 1, N'asd')
SET IDENTITY_INSERT [dbo].[Shippers] OFF
GO
INSERT [dbo].[Stock] ([Pharmacy Id], [Product Id], [Manufacturer ID], [Quantity]) VALUES (2, 3, 1, 100)
INSERT [dbo].[Stock] ([Pharmacy Id], [Product Id], [Manufacturer ID], [Quantity]) VALUES (2, 4, 1, 96)
INSERT [dbo].[Stock] ([Pharmacy Id], [Product Id], [Manufacturer ID], [Quantity]) VALUES (2, 5, 1, 97)
INSERT [dbo].[Stock] ([Pharmacy Id], [Product Id], [Manufacturer ID], [Quantity]) VALUES (2, 6, 1, 100)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_of_Employees]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_of_Employees] ON [dbo].[EmployeeDetails]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Index_of_Loan]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_of_Loan] ON [dbo].[EmployeeLoan]
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_Manufacturer_Details]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_Manufacturer_Details] ON [dbo].[ManufacturerDetails]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_of_Pharmacy]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_of_Pharmacy] ON [dbo].[Pharmacy]
(
	[Location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_of_Product_Details]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_of_Product_Details] ON [dbo].[ProductDetails]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_of_Shippers]    Script Date: 4/30/2022 5:35:46 PM ******/
CREATE NONCLUSTERED INDEX [Index_of_Shippers] ON [dbo].[Shippers]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeLoan] ADD  CONSTRAINT [employeeLoanAccepted]  DEFAULT ((0)) FOR [AmountAccepted]
GO
ALTER TABLE [dbo].[AttendanceStatus]  WITH CHECK ADD FOREIGN KEY([Attendance ID])
REFERENCES [dbo].[AttendanceDate] ([Id])
GO
ALTER TABLE [dbo].[AttendanceStatus]  WITH CHECK ADD FOREIGN KEY([Attendance Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[AttendanceStatus]  WITH CHECK ADD FOREIGN KEY([Employee ID])
REFERENCES [dbo].[EmployeeDetails] ([RegistrationNumber])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerDetails] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Discount])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Order Type])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Pharmacy Id])
REFERENCES [dbo].[Pharmacy] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrderDetails]  WITH CHECK ADD FOREIGN KEY([Manufacture Id])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrderDetails]  WITH CHECK ADD FOREIGN KEY([Order Id])
REFERENCES [dbo].[CustomerOrder] ([OrderId])
GO
ALTER TABLE [dbo].[CustomerOrderDetails]  WITH CHECK ADD FOREIGN KEY([Product Id])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD FOREIGN KEY([Pharmacy Id])
REFERENCES [dbo].[Pharmacy] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[EmployeeLoan]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[EmployeeDetails] ([RegistrationNumber])
GO
ALTER TABLE [dbo].[EmployeeLoan]  WITH CHECK ADD FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD FOREIGN KEY([Type])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ReturnCustomerOrder]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[CustomerOrder] ([OrderId])
GO
ALTER TABLE [dbo].[ReturnCustomerOrder]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[ReturnStockOrder]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[ReturnStockOrder]  WITH CHECK ADD FOREIGN KEY([StockOrderId])
REFERENCES [dbo].[StockOrder] ([Id])
GO
ALTER TABLE [dbo].[Shippers]  WITH CHECK ADD FOREIGN KEY([Manufacturer Id])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([Manufacturer ID])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([Pharmacy Id])
REFERENCES [dbo].[Pharmacy] ([Id])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([Product Id])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[StockOrder]  WITH CHECK ADD FOREIGN KEY([Pharmacy Id])
REFERENCES [dbo].[Pharmacy] ([Id])
GO
ALTER TABLE [dbo].[StockOrder]  WITH CHECK ADD FOREIGN KEY([Shipper Id])
REFERENCES [dbo].[Shippers] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Manufacture Id])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Order Id])
REFERENCES [dbo].[StockOrder] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Product Id])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD CHECK  (([Hire Date]>[Date Of Birth]))
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD CHECK  (([Expiry Date]>[Manufacturing Date]))
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD CHECK  (([Sale Price]>[Purchase Price]))
GO
/****** Object:  StoredProcedure [dbo].[deleteShipper]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deleteShipper] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from Shippers where [Id] = @Id
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[employee_Wise_Attendance]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[employee_Wise_Attendance]
	-- Add the parameters for the stored procedure here
	@pharmacyId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select R3.RegistrationNumber ,EmployeeDetails.Name , R3.Total_Days ,R3.Present_Days , R3.Present_Percentage 
from 
	(select  EmployeeDetails.RegistrationNumber, MAX(R2.Total_Days) AS Total_Days , COUNT(AttendanceStatus.[Employee ID]) as Present_Days , (CAST(CAST(COUNT( AttendanceStatus.[Employee ID] ) AS float) / CAST(MAX(R2.Total_Days) AS float) AS float)*100) AS Present_Percentage        
	from 
		(select   count(DISTINCT [Date]) AS Total_Days , Min(R1.Id) as Present_Status 
			from (select Id from Lookup  where Category = 'ATTENDANCE_STATUS' and Name = 'Present') as R1 
			CROSS JOIN AttendanceDate  JOIN AttendanceStatus  ON AttendanceDate.Id = AttendanceStatus.[Attendance ID]) as R2 
		CROSS JOIN AttendanceDate JOIN AttendanceStatus  ON AttendanceDate.Id = AttendanceStatus.[Attendance ID] 
		JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = AttendanceStatus.[Employee ID] 
		WHERE AttendanceStatus.[Attendance Status] = R2.Present_Status 
		GROUP BY EmployeeDetails.RegistrationNumber) as R3 
		join EmployeeDetails on R3.RegistrationNumber = EmployeeDetails.RegistrationNumber 
		where EmployeeDetails.[Pharmacy Id] = @pharmacyId
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[insertingCompany]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertingCompany] 
	-- Add the parameters for the stored procedure here
	@companyName varchar(50),
	@companyCity varchar(30),
	@companyCountry varchar(30),
	@companyAddress varchar(250),
	@companyContactNumber nvarchar(24),
	@companyEmail nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into ManufacturerDetails values (@companyName, @companyCity  , @companyCountry , @companyAddress , @companyContactNumber , @companyEmail )
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[out_of_Stock_and_Expired_Products]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[out_of_Stock_and_Expired_Products]
	-- Add the parameters for the stored procedure here
	@pharmacyId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select R2.Product_Name , R2.Product_Type , ManufacturerDetails.Name AS Company_NAme , R2.[Expiry Date] , R2.Quantity as Stock   
from	
	(select R1.Name as Product_Name , Lookup.Name as Product_Type , R1.ManufacturerId   as Company_Name, R1.[Expiry Date] ,R1.Quantity   
	from 
		(select ProductDetails.Name , ProductDetails.Type , ProductDetails.ManufacturerId , [Expiry Date] , Quantity 
		from ProductDetails join Stock on ProductDetails.Id = Stock.[Product Id] 
		where  (Quantity <=0 or  GETDATE() >=  [Expiry Date]) and Stock.[Pharmacy Id] = @pharmacyId ) as R1 
	join Lookup on Id = R1.Type) as R2 
join ManufacturerDetails on R2.Company_Name = ManufacturerDetails.Id

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[sales_Report_of_Day]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sales_Report_of_Day]
	-- Add the parameters for the stored procedure here
	@pharmacyId int,
	@date Datetime

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select R.OrderId , CustomerDetails.Name , CustomerDetails.ContactNumber , R.Total_Amount , R.Discount , R.After_Discount 
	from ((select CustomerOrder.OrderId , CustomerOrder.CustomerId ,Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price) AS Total_Amount , CAST(discountValue.Name as float)/100 *  (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price)) as Discount , (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price) - CAST(discountValue.Name as float)/100 *  (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price))) AS After_Discount 
		from (select Name  from Lookup where Category = 'Discount') as discountValue , CustomerOrder 
		join CustomerOrderDetails on CustomerOrder.OrderId = CustomerOrderDetails.[Order Id] 
		where Convert(date, @date)  = CONVERT(date , [Order Date]) and CustomerOrder.[Pharmacy Id] = @pharmacyId
		group by CustomerOrder.OrderId, CustomerOrder.CustomerId, discountValue.Name)) as R  
		join CustomerDetails on CustomerDetails.Id = R.CustomerId
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[sales_Report_of_Month]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sales_Report_of_Month] 
	-- Add the parameters for the stored procedure here
	@pharmacyId int,
	@date Datetime
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select R.OrderId , CustomerDetails.Name , CustomerDetails.ContactNumber , R.Total_Amount , R.Discount , R.After_Discount 
from 
	((select CustomerOrder.OrderId , CustomerOrder.CustomerId ,Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price) AS Total_Amount , CAST(discountValue.Name as float)/100 *  (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price)) as Discount , (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price) - CAST(discountValue.Name as float)/100 *  (Sum(CustomerOrderDetails.Quantity * CustomerOrderDetails.Price))) AS After_Discount 
	from 
		(select Name  from Lookup where Category = 'Discount') as discountValue , CustomerOrder 
		join CustomerOrderDetails on CustomerOrder.OrderId = CustomerOrderDetails.[Order Id] 
		where  year(@date) = year(CustomerOrder.[Order Date]) and month(@date) = month(CustomerOrder.[Order Date])  and CustomerOrder.[Pharmacy Id] =@pharmacyId
		group by CustomerOrder.OrderId, CustomerOrder.CustomerId, discountValue.Name)) as R  
		join CustomerDetails on CustomerDetails.Id = R.CustomerId
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[stock_Order_Report]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[stock_Order_Report] 
	-- Add the parameters for the stored procedure here
	@pharmacyId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select R.Id , R.[Order Date] , R.Name , R.ContactNumber , Shippers.name , R.Total_Amount 
from 
	(select StockOrder.Id, StockOrder.[Order Date] , ManufacturerDetails.Name , ManufacturerDetails.ContactNumber   , StockOrder.[Shipper Id] ,Sum(StockOrderDetails.Quantity * StockOrderDetails.[Unit Price]) AS Total_Amount 
	from StockOrder join StockOrderDetails on StockOrder.Id = StockOrderDetails.[Order Id] 
	join ManufacturerDetails  on ManufacturerDetails.Id = StockOrderDetails.[Manufacture Id] 
	where StockOrder.[Pharmacy Id] =   @pharmacyId
	group by StockOrder.Id, StockOrder.[Order Date] , ManufacturerDetails.Name , ManufacturerDetails.ContactNumber   , StockOrder.[Shipper Id] ) AS R 
	join Shippers on Shippers.Id = R.[Shipper Id] 
	order by R.Id desc
    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
/****** Object:  StoredProcedure [dbo].[updateProduct]    Script Date: 4/30/2022 5:35:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateProduct] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Type int,	
	@purchasePrice float,
	@salePrice float,
	@description varchar(250),
	@manufacturerId int,
	@expiryDate datetime,
	@manufacturingDate datetime
	

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update ProductDetails set [Name] = @Name , [Type] = @Type , [Purchase Price] = @purchasePrice   , [Sale Price] = @salePrice  , [Description] = @description  , [ManufacturerId] = @manufacturerId , [Expiry Date] = @expiryDate  , [Manufacturing Date] = @manufacturingDate  where [Id] =  @Id

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
