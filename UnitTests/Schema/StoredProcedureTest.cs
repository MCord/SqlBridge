namespace UnitTests.Schema
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;
    using SqlBridge.Schema;
    using Xunit;

    public class StoredProcedureTest
    {
        [Fact]
        public void ShouldExtractSpParameterDefinitionFromDacpacDefinition()
        {
            var sp = new StoredProcedure(TestSchemaLoader.GetDacPacObject("dbo.CustOrderHist", ModelSchema.Procedure));

            Assert.Equal("[dbo].[CustOrderHist]", sp.FullName);
            Assert.Equal("CustOrderHist", sp.Name);

            Assert.NotEmpty(sp.Parameters);
            var firstParam = sp.Parameters.First();
            Assert.Equal("@CustomerID", firstParam.Name);
            Assert.Equal("string", firstParam.Type);
        }
    }
}