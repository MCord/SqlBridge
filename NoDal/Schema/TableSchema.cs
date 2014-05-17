namespace SqlBridge.Schema
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class TableSchema : SchemaElement
    {
        private readonly Model model;

        public TableSchema(TSqlObject @object, Model model)
            : base(@object)
        {
            this.model = model;
        }

        public string Schema
        {
            get { return Actual.Name.Parts.Reverse().Skip(1).First(); }
        }

        public IEnumerable<ColumnSchema> Columns
        {
            get { return Actual.GetReferenced(Table.Columns).Select(o => new ColumnSchema(o)); }
        }

        public string PrimaryKey
        {
            get
            {
                var primaryKeys = model.PrimaryKeyConstraints.Select(c => c.FullColumnName);
                var columnName = Columns.Select(c => c.FullName);

                return primaryKeys
                    .Intersect(columnName)
                    .First()
                    .Split('.')
                    .LastOrDefault();
            }
        }

        public bool HasPrimaryKey
        {
            get { return PrimaryKey != null; }
        }
    }
}