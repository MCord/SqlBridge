namespace SqlBridge.Schema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeGen;
    using Microsoft.SqlServer.Dac.Model;

    public class Model : IDisposable
    {
        private readonly TSqlModel model;

        public Model(TSqlModel model)
        {
            this.model = model;
        }

        public IEnumerable<TableSchema> Tables
        {
            get
            {
                return ExtractObject(ModelSchema.Table, t => new TableSchema(t, this));
            }
        }

        private IEnumerable<T> ExtractObject<T>(ModelTypeClass typ, Func<TSqlObject, T> convertor)
        {
            return model.GetObjects(DacQueryScopes.UserDefined, typ)
                .Select(convertor);
        }

        public IEnumerable<PrimaryKeySchema> PrimaryKeyConstraints
        {
            get { return ExtractObject(ModelSchema.PrimaryKeyConstraint, p => new PrimaryKeySchema(p)); }
        }

        public IEnumerable<StoredProcedure> StoredProcedures
        {
            get
            {
                return ExtractObject(ModelSchema.Procedure, p => new StoredProcedure(p));
            }
        }

        public void Dispose()
        {
            model.Dispose();
        }
    }
}