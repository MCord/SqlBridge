namespace SqlBridge.Schema
{
    using System.IO;
    using Microsoft.SqlServer.Dac.Model;
    using NLog;

    public class SchemaReader
    {
        private readonly string dacPackFile;
        private static Logger log = LogManager.GetCurrentClassLogger();

        public SchemaReader(string dacPackFile)
        {
            log.Info("Reading schema from {0}", dacPackFile);

            if (!File.Exists(dacPackFile))
            {
                log.Error("DacPac file is missing. {0}", dacPackFile);
                throw new FileNotFoundException("DacPac file is missing,", dacPackFile);
            }
            this.dacPackFile = dacPackFile;
        }

        public Model GetModel()
        {
            return new Model(new TSqlModel(dacPackFile));
        }
    }
}