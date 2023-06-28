CREATE DATABASE FinalProject
CREATE TABLE Lookup
(
    Id int IDENTITY (1,1) PRIMARY KEY,
	Name varchar(50),
	Category varchar(25),
);
CREATE TABLE ManufacturerDetails
(
    Id int IDENTITY (1,1),
	Name varchar(50),
	City varchar(30),
	Country varchar(30),
	Address varchar(250),
	ContactNumber nvarchar(24),
	Email nvarchar(50),
	PRIMARY KEY (Id)
);

CREATE TABLE ProductDetails
(
   Id int PRIMARY KEY IDENTITY (1,1),
   Name varchar(50),
   Type varchar(50),
   [Purchase Price] int,
   [Sale Price] int,
   Description varchar(250),
   ManufacturerId int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
   [Expiry Date] datetime,
   [Manufacturing Date] datetime
);
CREATE TABLE Pharmacy
(
    Id int PRIMARY KEY IDENTITY (1,1),
	Location nvarchar(250),
	ContactNumber nvarchar(24)
);
CREATE TABLE EmployeeDetails
(
    Id int IDENTITY (1,1),
	Name varchar(50),
	PIN varchar(25),
	CNIC char(13),
	Salary int,
	Designation varchar(50),
    [Date Of Birth] datetime,
	City varchar(25),
	Country varchar(25),
	Address varchar(250),
	[Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
	Status int FOREIGN KEY REFERENCES Lookup(Id),
	[Hire Date] datetime,
 	PRIMARY KEY(Id)
);
CREATE TABLE CustomerDetails
(
     Id int PRIMARY KEY IDENTITY (1,1),
	 Name varchar(50),
	 ContactNumber nvarchar(24),
	 Email varchar(50),
	 Address varchar(250),
	 City varchar(25),
	 Country varchar(25)
);
CREATE TABLE CustomerOrder
(
    OrderId int PRIMARY KEY IDENTITY (1,1),
	CustomerId int FOREIGN KEY REFERENCES CustomerDetails(Id),
	[Order Date] datetime,
	[Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
	[Order Type] varchar(50),
	[Employee Id] int FOREIGN KEY REFERENCES EmployeeDetails(Id)
);
CREATE TABLE CustomerOrderDetails
(
    [Order Id] int FOREIGN KEY REFERENCES CustomerOrder(OrderId),
	[Product Id] int FOREIGN KEY REFERENCES ProductDetails(Id),
	PRIMARY KEY([Order Id],[Product Id]),
	Quantity int ,
	Price int,
	Discount float
);

CREATE TABLE Stock
(
   [Pharmacy Id] int FOREIGN KEY REFERENCES Pharmacy(Id),
   [Product Id]  int FOREIGN KEY REFERENCES ProductDetails(Id),
   [Manufacturer ID] int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
   PRIMARY KEY([Pharmacy Id],[Product Id],[Manufacturer ID]),
   Quantity int,
);
CREATE TABLE Shippers
(
   Id int PRIMARY Key,
   [Company Name] varchar(50),
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
   
);
CREATE TABLE StockOrderDetails
(
	[Order Id] int FOREIGN KEY REFERENCES StockOrder(Id),
	[Manufacture Id] int FOREIGN KEY REFERENCES ManufacturerDetails(Id),
	[Product Id] int FOREIGN KEY REFERENCES ProductDetails(Id),
	PRIMARY KEY([Order Id],[Manufacture Id],[Product Id]),
	[Shipper Id] int FOREIGN KEY REferences Shippers(Id),
	[Unit Price] int,
	Quantity int
);
CREATE TABLE AttendanceDate
(
   Id int PRIMARY KEY,
   Date datetime
);

CREATE TABLE AttendanceStatus
(
    
   [Employee ID] int FOREIGN KEY REFERENCES EmployeeDetails(Id),
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
   PRIMARY KEY(OrderID ,ProductID)
);

CREATE TABLE ReturnStockOrder
(
   StockOrderId int FOREIGN KEY References StockOrder(Id),
   ProductId int FOREIGN  KEY REFERENCES ProductDetails(Id),  
   Quantity int,
   ReturnDate datetime,
   PRIMARY KEY(StockOrderId,ProductId)
);

CREATE TABLE EmployeeLoan
(
Id int,
EmployeeId int   FOREIGN KEY References EmployeeDetails(Id),
PharmacyId int FOREIGN KEY References Pharmacy(Id),
Purpose varchar(250),
Amount int,
ApplyDate datetime,
PRIMARY KEY(Id)
)
