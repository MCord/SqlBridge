namespace UnitTests
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    internal class TestSchemaLoader
    {
        private static readonly TSqlModel Model = new TSqlModel("NorthWind.dacpac");

        public static TSqlObject GetDacPacObject(string id)
        {
            var dacPacObject = Model.GetObjects(DacQueryScopes.UserDefined)
                .First(a => a.Name.Parts.Any() && a.Name.Parts.Last().Equals(id));
            return dacPacObject;
        }
    }
}