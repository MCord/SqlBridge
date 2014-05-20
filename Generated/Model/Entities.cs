
namespace MyNamespace
{
	using System;
	using PetaPoco;

	
	[TableName("[dbo].[Categories]")]
		[PrimaryKey("CategoryId")]
		public class Categories
	{
		[Column("[CategoryID]")] public int CategoryId {get;set;}
		[Column("[CategoryName]")] public string CategoryName {get;set;}
		[Column("[Description]")] public string Description {get;set;}
		[Column("[Picture]")] public byte[] Picture {get;set;}
	}
	
	
	[TableName("[dbo].[CustomerCustomerDemo]")]
		[PrimaryKey("CustomerId")]
		public class CustomerCustomerDemo
	{
		[Column("[CustomerID]")] public string CustomerId {get;set;}
		[Column("[CustomerTypeID]")] public string CustomerTypeId {get;set;}
	}
	
	
	[TableName("[dbo].[CustomerDemographics]")]
		[PrimaryKey("CustomerTypeId")]
		public class CustomerDemographics
	{
		[Column("[CustomerTypeID]")] public string CustomerTypeId {get;set;}
		[Column("[CustomerDesc]")] public string CustomerDesc {get;set;}
	}
	
	
	[TableName("[dbo].[Customers]")]
		[PrimaryKey("CustomerId")]
		public class Customers
	{
		[Column("[CustomerID]")] public string CustomerId {get;set;}
		[Column("[CompanyName]")] public string CompanyName {get;set;}
		[Column("[ContactName]")] public string ContactName {get;set;}
		[Column("[ContactTitle]")] public string ContactTitle {get;set;}
		[Column("[Address]")] public string Address {get;set;}
		[Column("[City]")] public string City {get;set;}
		[Column("[Region]")] public string Region {get;set;}
		[Column("[PostalCode]")] public string PostalCode {get;set;}
		[Column("[Country]")] public string Country {get;set;}
		[Column("[Phone]")] public string Phone {get;set;}
		[Column("[Fax]")] public string Fax {get;set;}
	}
	
	
	[TableName("[dbo].[Employees]")]
		[PrimaryKey("EmployeeId")]
		public class Employees
	{
		[Column("[EmployeeID]")] public int EmployeeId {get;set;}
		[Column("[LastName]")] public string LastName {get;set;}
		[Column("[FirstName]")] public string FirstName {get;set;}
		[Column("[Title]")] public string Title {get;set;}
		[Column("[TitleOfCourtesy]")] public string TitleOfCourtesy {get;set;}
		[Column("[BirthDate]")] public DateTime? BirthDate {get;set;}
		[Column("[HireDate]")] public DateTime? HireDate {get;set;}
		[Column("[Address]")] public string Address {get;set;}
		[Column("[City]")] public string City {get;set;}
		[Column("[Region]")] public string Region {get;set;}
		[Column("[PostalCode]")] public string PostalCode {get;set;}
		[Column("[Country]")] public string Country {get;set;}
		[Column("[HomePhone]")] public string HomePhone {get;set;}
		[Column("[Extension]")] public string Extension {get;set;}
		[Column("[Photo]")] public byte[] Photo {get;set;}
		[Column("[Notes]")] public string Notes {get;set;}
		[Column("[ReportsTo]")] public int? ReportsTo {get;set;}
		[Column("[PhotoPath]")] public string PhotoPath {get;set;}
	}
	
	
	[TableName("[dbo].[EmployeeTerritories]")]
		[PrimaryKey("EmployeeId")]
		public class EmployeeTerritories
	{
		[Column("[EmployeeID]")] public int EmployeeId {get;set;}
		[Column("[TerritoryID]")] public string TerritoryId {get;set;}
	}
	
	
	[TableName("[dbo].[Order Details]")]
		[PrimaryKey("OrderId")]
		public class OrderDetails
	{
		[Column("[OrderID]")] public int OrderId {get;set;}
		[Column("[ProductID]")] public int ProductId {get;set;}
		[Column("[UnitPrice]")] public decimal UnitPrice {get;set;}
		[Column("[Quantity]")] public short Quantity {get;set;}
		[Column("[Discount]")] public float Discount {get;set;}
	}
	
	
	[TableName("[dbo].[Orders]")]
		[PrimaryKey("OrderId")]
		public class Orders
	{
		[Column("[OrderID]")] public int OrderId {get;set;}
		[Column("[CustomerID]")] public string CustomerId {get;set;}
		[Column("[EmployeeID]")] public int? EmployeeId {get;set;}
		[Column("[OrderDate]")] public DateTime? OrderDate {get;set;}
		[Column("[RequiredDate]")] public DateTime? RequiredDate {get;set;}
		[Column("[ShippedDate]")] public DateTime? ShippedDate {get;set;}
		[Column("[ShipVia]")] public int? ShipVia {get;set;}
		[Column("[Freight]")] public decimal? Freight {get;set;}
		[Column("[ShipName]")] public string ShipName {get;set;}
		[Column("[ShipAddress]")] public string ShipAddress {get;set;}
		[Column("[ShipCity]")] public string ShipCity {get;set;}
		[Column("[ShipRegion]")] public string ShipRegion {get;set;}
		[Column("[ShipPostalCode]")] public string ShipPostalCode {get;set;}
		[Column("[ShipCountry]")] public string ShipCountry {get;set;}
	}
	
	
	[TableName("[dbo].[Products]")]
		[PrimaryKey("ProductId")]
		public class Products
	{
		[Column("[ProductID]")] public int ProductId {get;set;}
		[Column("[ProductName]")] public string ProductName {get;set;}
		[Column("[SupplierID]")] public int? SupplierId {get;set;}
		[Column("[CategoryID]")] public int? CategoryId {get;set;}
		[Column("[QuantityPerUnit]")] public string QuantityPerUnit {get;set;}
		[Column("[UnitPrice]")] public decimal? UnitPrice {get;set;}
		[Column("[UnitsInStock]")] public short? UnitsInStock {get;set;}
		[Column("[UnitsOnOrder]")] public short? UnitsOnOrder {get;set;}
		[Column("[ReorderLevel]")] public short? ReorderLevel {get;set;}
		[Column("[Discontinued]")] public bool Discontinued {get;set;}
	}
	
	
	[TableName("[dbo].[Region]")]
		[PrimaryKey("RegionId")]
		public class Region
	{
		[Column("[RegionID]")] public int RegionId {get;set;}
		[Column("[RegionDescription]")] public string RegionDescription {get;set;}
	}
	
	
	[TableName("[dbo].[Shippers]")]
		[PrimaryKey("ShipperId")]
		public class Shippers
	{
		[Column("[ShipperID]")] public int ShipperId {get;set;}
		[Column("[CompanyName]")] public string CompanyName {get;set;}
		[Column("[Phone]")] public string Phone {get;set;}
	}
	
	
	[TableName("[dbo].[Suppliers]")]
		[PrimaryKey("SupplierId")]
		public class Suppliers
	{
		[Column("[SupplierID]")] public int SupplierId {get;set;}
		[Column("[CompanyName]")] public string CompanyName {get;set;}
		[Column("[ContactName]")] public string ContactName {get;set;}
		[Column("[ContactTitle]")] public string ContactTitle {get;set;}
		[Column("[Address]")] public string Address {get;set;}
		[Column("[City]")] public string City {get;set;}
		[Column("[Region]")] public string Region {get;set;}
		[Column("[PostalCode]")] public string PostalCode {get;set;}
		[Column("[Country]")] public string Country {get;set;}
		[Column("[Phone]")] public string Phone {get;set;}
		[Column("[Fax]")] public string Fax {get;set;}
		[Column("[HomePage]")] public string HomePage {get;set;}
	}
	
	
	[TableName("[dbo].[Territories]")]
		[PrimaryKey("TerritoryId")]
		public class Territories
	{
		[Column("[TerritoryID]")] public string TerritoryId {get;set;}
		[Column("[TerritoryDescription]")] public string TerritoryDescription {get;set;}
		[Column("[RegionID]")] public int RegionId {get;set;}
	}
	
	}