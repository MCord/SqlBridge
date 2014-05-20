namespace SqlBridge.Schema
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class SpParameter : SchemaElement
    {
        public SpParameter(TSqlObject actual) : base(actual)
        {
        }

        public bool Nullable
        {
            get { return false; }
        }

        public string SqlType
        {
            get
            {
                return Actual.GetReferenced(Parameter.DataType)
                    .First().Name.Parts.Last();
            }
        }

        public string Type
        {
            get
            {
                return Converter.ClrTypeFromSqlDefinition(SqlType, Nullable);
            }
        }
    }
}