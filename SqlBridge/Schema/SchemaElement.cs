namespace SqlBridge.Schema
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class SchemaElement
    {
        protected readonly TSqlObject Actual;

        public SchemaElement(TSqlObject actual)
        {
            Actual = actual;
        }

        public string Name
        {
            get { return Actual.Name.Parts.LastOrDefault(); }
        }

        public string FullName
        {
            get { return Actual.Name.ToString(); }
        }
    }
}