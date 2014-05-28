namespace IntegrationTests
{
    using System.Linq;
    using MyNamespace;
    using PetaPoco;
    using Xunit;

    public class StoredProcedureTests
    {
        [Fact]
        public void FactMethodName()
        {
            var dbModule = new DatabaseModule(new Database("Northwind"));
            var topName = dbModule.TenMostExpensiveProducts().Select(r => r.GetString(0)).First();
            Assert.Equal("Côte de Blaye", topName);
        }
    }
}