namespace SqlBridge.Schema
{
    using System.Configuration;
    using System.Linq;
    using CodeGen;
    using Microsoft.SqlServer.Dac.Model;

    public class SchemaReader
    {
        private readonly string dacPackFile;

        public SchemaReader() : this(DefaultSchemaFile())
        {
        }

        public SchemaReader(string dacPackFile)
        {
            this.dacPackFile = dacPackFile;
        }

        public Model GetModel()
        {
            var model = new TSqlModel(dacPackFile ?? DefaultSchemaFile());
            
                var result = new Model(model);
                result.Tables =
                    model.GetObjects(DacQueryScopes.UserDefined, ModelSchema.Table)
                        .Select(t => new TableSchema(t, result));

            return result;
        }

        private static string DefaultSchemaFile()
        {
            return ConfigurationSettings.AppSettings["DatabaseModel"];
        }
    }
}