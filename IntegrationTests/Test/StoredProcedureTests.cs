namespace IntegrationTests.Test
{
    using System.Linq;
    using Annotations;
    using MyNamespace;
    using Xunit;

    public class StoredProcedureTests
    {
        private readonly DatabaseModule dbm = new DatabaseModule();

        [UsedImplicitly]
        public class ExpensiveProduct
        {
            public string TenMostExpensiveProducts { get; [UsedImplicitly] set; }
            public decimal UnitPrice { get; [UsedImplicitly] set; }
        }

        [UsedImplicitly]
        public class ProductSum
        {
            public string ProductName { get; [UsedImplicitly] set; }
            public decimal Total { get; [UsedImplicitly] set; }
        }

        [Fact]
        public void ShouldCallStoredProcedure()
        {
            var mostExpensiveProduct = dbm.TenMostExpensiveProducts<ExpensiveProduct>().First();
            Assert.Equal(263.5M, mostExpensiveProduct.UnitPrice);
            Assert.Equal("Côte de Blaye", mostExpensiveProduct.TenMostExpensiveProducts);
        }

        [Fact]
        public void ShouldCallStoredProcedureWithParameter()
        {
            var maxSum = dbm.CustOrderHist<ProductSum>("ALFKI").Max(ps=> ps.Total);
            Assert.Equal(40, maxSum);
        }
    }
}