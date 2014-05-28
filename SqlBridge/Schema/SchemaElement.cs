namespace SqlBridge.Schema
{
    using System;
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;

    public class SchemaElement
    {
        protected readonly TSqlObject Actual;

        public SchemaElement(TSqlObject actual)
        {
            if (actual == null)
            {
                throw new ArgumentException("Can't be null", "actual");
            }

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