--CREATE DATABASE FinalProject

use FinalProject

CREATE TABLE [Lookup]
(
    Id int IDENTITY (1,1) PRIMARY KEY,
	[Name] varchar(50),
	Category varchar(25),
);
CREATE TABLE ManufacturerDetails
(
    Id int IDENTITY (1,1),
	[Name] varchar(50),
	City varchar(30),
	Country varchar(30),
	[Address] varchar(250),
	ContactNumber nvarchar(24),
	Email nvarchar(50),
	PRIMARY KEY (Id)
);

CREATE TABLE ProductDetails
(
   Id int PRIMARY KEY IDENTITY (1,1),
   [Name] varchar(50),
   [Type] int FOREIGN key references [Lookup](Id),
   [Purchase Price] float,
   [Sale Price] float,
   [Description] varchar(250),
   ManufacturerId int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
   [Expiry Date] datetime,
   [Manufacturing Date] datetime,
   check([Expiry Date] > [Manufacturing Date]),
   check([Sale Price] >  [Purchase Price])
);
CREATE TABLE Pharmacy
(
    Id int PRIMARY KEY IDENTITY (1,1),
	[Location] nvarchar(250),
	ContactNumber nvarchar(24)
);
CREATE TABLE EmployeeDetails
(
    RegistrationNumber int IDENTITY (1,1),
	[Name] varchar(50),
	PIN varchar(25),
	CNIC char(13),
	Gender char(1),
	Salary int,
	Designation int,
    [Date Of Birth] datetime,
	City varchar(25),
	Country varchar(25),
	[Address] varchar(250),
	[Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
	[Status] int FOREIGN KEY REFERENCES [Lookup](Id),
	[Hire Date] datetime,
	Email varchar(50),
	ContactNumber varchar(15),
 	PRIMARY KEY(RegistrationNumber),
	check([Hire Date] > [Date Of Birth]),
);
CREATE TABLE CustomerDetails
(
     Id int PRIMARY KEY IDENTITY (1,1),
	 [Name] varchar(50),
	 ContactNumber nvarchar(24),
	 Email varchar(50),
	 [Address] varchar(250),
	 City varchar(25),
	 Country varchar(25),
	 PIN varchar(25)
);
CREATE TABLE CustomerOrder
(
    OrderId int PRIMARY KEY IDENTITY (1,1),
	CustomerId int FOREIGN KEY REFERENCES CustomerDetails(Id),
	[Order Date] datetime,
	[Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
	[Order Type] int FOREIGN KEY REFERENCES [Lookup](Id),
	Discount  int FOREIGN KEY REFERENCES [Lookup](Id) 

	--[Employee Id] int FOREIGN KEY REFERENCES EmployeeDetails(RegistrationNumber)
 
);
CREATE TABLE CustomerOrderDetails
(
    [Order Id] int FOREIGN KEY REFERENCES CustomerOrder(OrderId),
	[Manufacture Id] int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
	[Product Id] int FOREIGN KEY REFERENCES ProductDetails(Id),
	PRIMARY KEY([Order Id],[Manufacture Id],[Product Id]),
	Quantity int,
	Price int,
	--Discount  int FOREIGN KEY REFERENCES [Lookup](Id)
);

CREATE TABLE Stock
(
   [Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id) ,
   [Product Id]  int FOREIGN KEY REFERENCES ProductDetails(Id),
   [Manufacturer ID] int FOREIGN KEY REFERENCES ManufacturerDetails(Id) ,
   PRIMARY KEY([Pharmacy Id],[Product Id],[Manufacturer ID]),
   Quantity int,
);
CREATE TABLE Shippers
(
   Id int PRIMARY Key IDENTITY (1,1),
   [name] varchar(50),
   [Contact Number] varchar(24),
   [Manufacturer Id] int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
   [Address] varchar(250)
);
CREATE TABLE StockOrder
(
   Id int PRIMARY KEY IDENTITY(1,1),
   [Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
   [Order Date] datetime,
   [Shipped Date] datetime,
   [Shipper Id] int FOREIGN KEY REferences Shippers(Id)
);
CREATE TABLE StockOrderDetails
(
	[Order Id] int FOREIGN KEY REFERENCES StockOrder(Id),
	[Manufacture Id] int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
	[Product Id] int FOREIGN KEY REFERENCES ProductDetails(Id),
	PRIMARY KEY([Order Id],[Manufacture Id],[Product Id]),
	--[Shipper Id] int FOREIGN KEY REferences Shippers(Id),
	[Unit Price] int,
	Quantity int
);
CREATE TABLE AttendanceDate
(
   Id int PRIMARY KEY IDENTITY (1,1),
   [Date] datetime
);

CREATE TABLE AttendanceStatus
(
   [Employee ID] int FOREIGN KEY REFERENCES EmployeeDetails(RegistrationNumber),
   [Attendance ID] int FOREIGN KEY REFERENCES AttendanceDate(Id),
   PRIMARY KEY([Employee ID],[Attendance ID]),
   [Attendance Status] int FOREIGN KEY REFERENCES Lookup(Id)  
);

CREATE TABLE ReturnCustomerOrder
(
   OrderID int  FOREIGN  KEY REFERENCES CustomerOrder(OrderId),
   ProductID int FOREIGN  KEY REFERENCES ProductDetails(Id),
   Quantity int,
   ReturnDate datetime
   PRIMARY KEY(OrderID ,ProductID, ReturnDate)
);

CREATE TABLE ReturnStockOrder
(
   StockOrderId int FOREIGN KEY References StockOrder(Id),
   ProductId int FOREIGN  KEY REFERENCES ProductDetails(Id),  
   Quantity int,
   ReturnDate datetime,
   PRIMARY KEY(StockOrderId,ProductId,ReturnDate )
);

CREATE TABLE EmployeeLoan
(
Id int identity(1,1) ,
EmployeeId int FOREIGN KEY References EmployeeDetails(RegistrationNumber),
Purpose varchar(250),
AmountRequested int,
AmountAccepted int ,
ApplyDate datetime,
[Status] int  null,
PRIMARY KEY(Id),
foreign  key ([Status]) references Lookup(Id)
)









CREATE INDEX Index_Manufacturer_Details 
ON ManufacturerDetails([Name])






CREATE INDEX Index_of_Product_Details
ON ProductDetails([Name])







CREATE INDEX Index_of_Pharmacy
ON Pharmacy([Location])







CREATE INDEX Index_of_Loan
ON EmployeeLoan(EmployeeId)







CREATE INDEX Index_of_Employees
ON EmployeeDetails([Name])















CREATE INDEX Index_of_Shippers
ON Shippers([Name])


alter table EmployeeLoan
add constraint employeeLoanAccepted Default 0 for AmountAccepted;