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

        public bool HasParameters
        {
            get { return Parameters.Any(); }
        }

        public IEnumerable<ColumnSchema> InferredResultColumns
        {
            get
            {
                var duplicate = new List<string>();
                foreach (var result in Actual .GetReferenced().Where(r => r.ObjectType.Name == "Column").Select(sqlObject => new ColumnSchema(sqlObject)))
                {
                    if (duplicate.Contains(result.Name))
                    {
                        continue;
                    }

                    duplicate.Add(result.Name);
                    yield return result;
                }
            }
        }

        public bool ReturnsVoid
        {
            get { return !InferredResultColumns.Any(); }
        }
    }
}