USE [FinalProject]
GO
/****** Object:  Table [dbo].[AttendanceDate]    Script Date: 4/10/2022 10:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceDate](
	[Id] [int] NOT NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendanceStatus]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 4/10/2022 10:49:32 PM ******/
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
	[Employee Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrderDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
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
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order Id] ASC,
	[Manufacture Id] ASC,
	[Product Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[RegistrationNumber] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[PIN] [varchar](25) NULL,
	[CNIC] [char](13) NULL,
	[Gender] [int] NULL,
	[Salary] [int] NULL,
	[Designation] [varchar](50) NULL,
	[Date Of Birth] [datetime] NULL,
	[City] [varchar](25) NULL,
	[Country] [varchar](25) NULL,
	[Address] [varchar](250) NULL,
	[Pharmacy Id] [int] NULL,
	[Status] [int] NULL,
	[Hire Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RegistrationNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeLoan]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeLoan](
	[Id] [int] NOT NULL,
	[EmployeeId] [int] NULL,
	[PharmacyId] [int] NULL,
	[Purpose] [varchar](250) NULL,
	[Amount] [int] NULL,
	[ApplyDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[ManufacturerDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[Pharmacy]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Type] [int] NULL,
	[Purchase Price] [int] NULL,
	[Sale Price] [int] NULL,
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
/****** Object:  Table [dbo].[ReturnCustomerOrder]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[ReturnStockOrder]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[Shippers]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Stock]    Script Date: 4/10/2022 10:49:32 PM ******/
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
/****** Object:  Table [dbo].[StockOrder]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pharmacy Id] [int] NULL,
	[Order Date] [datetime] NULL,
	[Shipped Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOrderDetails]    Script Date: 4/10/2022 10:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOrderDetails](
	[Order Id] [int] NOT NULL,
	[Manufacture Id] [int] NOT NULL,
	[Product Id] [int] NOT NULL,
	[Shipper Id] [int] NULL,
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
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Employee Id])
REFERENCES [dbo].[EmployeeDetails] ([RegistrationNumber])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Order Type])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([Pharmacy Id])
REFERENCES [dbo].[Pharmacy] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrderDetails]  WITH CHECK ADD FOREIGN KEY([Discount])
REFERENCES [dbo].[Lookup] ([Id])
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
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
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
ALTER TABLE [dbo].[EmployeeLoan]  WITH CHECK ADD FOREIGN KEY([PharmacyId])
REFERENCES [dbo].[Pharmacy] ([Id])
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
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Manufacture Id])
REFERENCES [dbo].[ManufacturerDetails] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Order Id])
REFERENCES [dbo].[StockOrder] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Product Id])
REFERENCES [dbo].[ProductDetails] ([Id])
GO
ALTER TABLE [dbo].[StockOrderDetails]  WITH CHECK ADD FOREIGN KEY([Shipper Id])
REFERENCES [dbo].[Shippers] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD CHECK  (([Gender]='U' OR [Gender]='F' OR [Gender]='M'))
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD CHECK  (([Hire Date]>[Date Of Birth]))
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD CHECK  (([Expiry Date]>[Manufacturing Date]))
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD CHECK  (([Sale Price]>[Purchase Price]))
GO
ALTER TABLE [dbo].[StockOrder]  WITH CHECK ADD CHECK  (([Shipped Date]>[Order Date]))
GO
