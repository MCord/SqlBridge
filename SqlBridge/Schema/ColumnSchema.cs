namespace SqlBridge.Schema
{
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class ColumnSchema : SchemaElement
    {
        public ColumnSchema(TSqlObject actual) : base(actual)
        {
        }
       
        public bool Nullable
        {
            get
            {
                return Actual.GetProperty<bool>(Column.Nullable);
            }
        }

        public string SqlType
        {
            get
            {
                return Actual.GetReferenced(Column.DataType)
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