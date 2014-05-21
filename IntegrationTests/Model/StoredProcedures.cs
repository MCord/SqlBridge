
namespace MyNamespace
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using PetaPoco;

	public class DatabaseModule
	{
		private readonly Database db;
	    public DatabaseModule(Database db)
	    {
	        this.db = db;
	    }

			public IEnumerable<IDataRecord> CustOrderHist(string customerId)
		{
			return db.Read("EXEC [dbo].[CustOrderHist]  @0",customerId) ;
		}
			public IEnumerable<IDataRecord> CustOrdersDetail(int orderId)
		{
			return db.Read("EXEC [dbo].[CustOrdersDetail]  @0",orderId) ;
		}
			public IEnumerable<IDataRecord> CustOrdersOrders(string customerId)
		{
			return db.Read("EXEC [dbo].[CustOrdersOrders]  @0",customerId) ;
		}
			public IEnumerable<IDataRecord> EmployeeSalesByCountry(DateTime beginningDate,DateTime endingDate)
		{
			return db.Read("EXEC [dbo].[Employee Sales by Country]  @0,@1",beginningDate,endingDate) ;
		}
			public IEnumerable<IDataRecord> SalesByYear(DateTime beginningDate,DateTime endingDate)
		{
			return db.Read("EXEC [dbo].[Sales by Year]  @0,@1",beginningDate,endingDate) ;
		}
			public IEnumerable<IDataRecord> SalesByCategory(string categoryName,string ordYear)
		{
			return db.Read("EXEC [dbo].[SalesByCategory]  @0,@1",categoryName,ordYear) ;
		}
			public IEnumerable<IDataRecord> TenMostExpensiveProducts()
		{
			return db.Read("EXEC [dbo].[Ten Most Expensive Products]  ") ;
		}
		}
}