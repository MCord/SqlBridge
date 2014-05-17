namespace UnitTests
{
    using System.Linq;
    using SqlBridge.Schema;
    using Xunit;

    public class SchemaReaderTest
    {
        [Fact]
        public void ShouldFlagIfTableHasAPrimaryKey()
        {
            var reader = new SchemaReader();
            var model = reader.GetModel();

            Assert.True(model.Tables.First(t=> t.Name.Equals("Categories")).HasPrimaryKey);
            
        }
    }
}