
namespace MyNamespace
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using PetaPoco;

	public class DatabaseModule
	{
		private readonly Database db;
	    public DatabaseModule(Database db=null)
	    {
	        this.db = db ?? new Database("ConnectionString");
	    }

	
		public IEnumerable<T> CustOrderHist<T>(string customerId)
		{
			return db.Fetch<T>(";EXEC [dbo].[CustOrderHist]  @0",customerId) ;
		}
	
		public IEnumerable<T> CustOrdersDetail<T>(int orderId)
		{
			return db.Fetch<T>(";EXEC [dbo].[CustOrdersDetail]  @0",orderId) ;
		}
	
		public IEnumerable<T> CustOrdersOrders<T>(string customerId)
		{
			return db.Fetch<T>(";EXEC [dbo].[CustOrdersOrders]  @0",customerId) ;
		}
	
		public IEnumerable<T> EmployeeSalesByCountry<T>(DateTime beginningDate,DateTime endingDate)
		{
			return db.Fetch<T>(";EXEC [dbo].[Employee Sales by Country]  @0,@1",beginningDate,endingDate) ;
		}
	
		public IEnumerable<T> SalesByYear<T>(DateTime beginningDate,DateTime endingDate)
		{
			return db.Fetch<T>(";EXEC [dbo].[Sales by Year]  @0,@1",beginningDate,endingDate) ;
		}
	
		public IEnumerable<T> SalesByCategory<T>(string categoryName,string ordYear)
		{
			return db.Fetch<T>(";EXEC [dbo].[SalesByCategory]  @0,@1",categoryName,ordYear) ;
		}
	
		public IEnumerable<T> TenMostExpensiveProducts<T>()
		{
			return db.Fetch<T>(";EXEC [dbo].[Ten Most Expensive Products]  ") ;
		}
		}
}