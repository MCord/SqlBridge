namespace SqlBridge.Schema
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class StoredProcedure : SchemaElement
    {
        public StoredProcedure(TSqlObject actual) : base(actual)
        {
        }

        public IEnumerable<SpParameter> Parameters
        {
            get { return Actual.GetReferenced(Procedure.Parameters).Select(o => new SpParameter(o)); }
        }
    }
}