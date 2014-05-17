namespace SqlBridge.Schema
{
    using Microsoft.SqlServer.Dac.Model;

    public class ConstraintSchema :SchemaElement
    {
        public ConstraintSchema(TSqlObject actual) : base(actual)
        {
        }
    }
}