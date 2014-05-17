namespace SqlBridge.CodeGen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.Dac.Model;
    using Schema;

    public class Model : IDisposable
    {
        private readonly TSqlModel model;

        public Model(TSqlModel model)
        {
            this.model = model;
        }

        public IEnumerable<TableSchema> Tables { get; set; }
        public IEnumerable<PrimaryKeySchema> PrimaryKeyConstraints
        {
            get
            {
                return model
                    .GetObjects(DacQueryScopes.UserDefined, ModelSchema.PrimaryKeyConstraint)
                    .Select(p => new PrimaryKeySchema(p));
            }
        }

        public void Dispose()
        {
            model.Dispose();
        }
    }
}