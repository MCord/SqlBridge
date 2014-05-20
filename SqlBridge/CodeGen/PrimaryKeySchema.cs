namespace SqlBridge.CodeGen
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;
    using Schema;

    public class PrimaryKeySchema:SchemaElement
    {
        public string FullColumnName
        {
            get
            {
                var columnRelation = Actual.GetReferencedRelationshipInstances().First(r=> r.Relationship.Name == "Columns");

                return columnRelation.ObjectName.ToString();
            }
        }
        public PrimaryKeySchema(TSqlObject actual) : base(actual)
        {
        }
    }
}