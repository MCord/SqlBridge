namespace UnitTests
{
    using Microsoft.SqlServer.Dac.Model;

    internal class TestSchemaLoader
    {
        private static readonly TSqlModel Model = new TSqlModel("NorthWind.dacpac");

        public static TSqlObject GetDacPacObject(string id, ModelTypeClass typ)
        {
            var obj = Model.GetObject(typ, new ObjectIdentifier(id.Split('.')),DacQueryScopes.All);
            return obj;
        }
    }
}