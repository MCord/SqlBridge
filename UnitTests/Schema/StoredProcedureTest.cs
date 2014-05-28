namespace UnitTests.Schema
{
    using System.Linq;
    using SqlBridge.Schema;
    using Xunit;

    public class StoredProcedureTest
    {
        [Fact]
        public void ShouldExtractSpParameterDefinitionFromDacpacDefinition()
        {
            var sp = new StoredProcedure(TestSchemaLoader.GetDacPacObject("CustOrderHist"));

            Assert.Equal("[dbo].[CustOrderHist]", sp.FullName);
            Assert.Equal("CustOrderHist", sp.Name);

            Assert.NotEmpty(sp.Parameters);
            var firstParam = sp.Parameters.First();
            Assert.Equal("@CustomerID", firstParam.Name);
            Assert.Equal("string", firstParam.Type);

            var columnSchemata = sp.InferredResultColumns.ToList();
            Assert.NotEmpty(columnSchemata);
        }

        [Fact]
        public void FactMethodName()
        {
            var sp = new StoredProcedure(TestSchemaLoader.GetDacPacObject("Employee Sales by Country"));
            var columnSchemata = sp.InferredResultColumns.ToList();
            Assert.True(columnSchemata.All(c => c.Type != null));
        }
    }
}