using Xunit;

namespace UnitTests
{
    using SqlBridge.CodeGen;

    public class EntityGeneratorTests
    {
        [Fact]
        public void Test()
        {
            var sut = new EntityGenerator(null);
            sut.Generate();
        }
    }
}