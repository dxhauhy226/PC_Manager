create database PCManager
go
use PCManager
go
create table tblManufacturer
(
	Manufacturer_ID nvarchar(10) primary key,
	Manufacturer_Name nvarchar(50)
)
go
create table tblStaff
(
	Staff_ID nvarchar(10) primary key,
	Staff_Name nvarchar(100),
	Staff_Gender nvarchar(10),
	Staff_Addr nvarchar(100),
	Staff_Phone nvarchar(10)
)
go
create table tblCustomer
(
	Customer_ID nvarchar(10) primary key,
	Customer_Name nvarchar(100),
	Customer_Gender nvarchar(10),
	Customer_Addr nvarchar(100),
	Customer_Phone nvarchar(10)
)
go
create table tblComputer
(
	Computer_ID nvarchar(30) primary key,
	Computer_Name nvarchar(100),
	Manufacturer_ID nvarchar(10),
	Computer_Count int,
	Computer_Price_In int,
	Computer_Price_Out int,
	Computer_Picture nvarchar(200),
	Computer_Detail nvarchar(200),
	FOREIGN KEY (Manufacturer_ID) REFERENCES tblManufacturer(Manufacturer_ID)
)
go
create table tblBill
(
	Bill_ID nvarchar(30) primary key,
	Bill_Date datetime,
	Staff_ID nvarchar(10),
	Customer_ID nvarchar(10),
	Bill_Total int,
	FOREIGN KEY (Staff_ID) REFERENCES tblStaff(Staff_ID),
	FOREIGN KEY (Customer_ID) REFERENCES tblCustomer(Customer_ID)
)
go
create table tblBillDetail
(
	Bill_ID nvarchar(30),
	Computer_ID nvarchar(30),
	BillDetail_Count int,
	BillDetail_Price int,
	BillDetail_Sale int,
	BillDetail_Money int,
	FOREIGN KEY (Bill_ID) REFERENCES tblBill(Bill_ID),
	FOREIGN KEY (Computer_ID) REFERENCES tblComputer(Computer_ID),
	primary key clustered (Bill_ID asc, Computer_ID asc)
)
go