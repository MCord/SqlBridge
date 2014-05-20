namespace UnitTests.Helpers
{
    using SqlBridge;
    using SqlBridge.Schema;
    using Xunit;

    public class IdentifierTests
    {
        [Fact]
        public void ShouldConvertIdentifierToCamelCase()
        {
            Assert.Equal("testCase", Identifier.CamelStyle("TEST_CASE"));
        }

        [Fact]
        public void FactMethodName()
        {
            Assert.Equal("@0,@1,@2", Identifier.SqlArgList(new []{new SpParameter(null), new SpParameter(null), new SpParameter(null)}));
        }
    }
}