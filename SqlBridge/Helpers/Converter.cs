namespace SqlBridge
{
    using System;

    public class Converter
    {
        public static string ClrTypeFromSqlDefinition(string type, bool allowNull)
        {
            switch (type)
            {
                case "bigint":
                    return allowNull ? "long?" : "long";

                case "binary":
                case "image":
                case "timestamp":
                case "varbinary":
                    return "byte[]";

                case "bit":
                    return allowNull ? "bool?" : "bool";

                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                case "xml":
                    return "string";

                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                case "datetime2":
                    return allowNull ? "DateTime?" : "DateTime";

                case "decimal":
                case "money":
                case "smallmoney":
                    return allowNull ? "decimal?" : "decimal";

                case "float":
                    return allowNull ? "double?" : "double";

                case "int":
                    return allowNull ? "int?" : "int";

                case "real":
                    return allowNull ? "float?" : "float";

                case "uniqueidentifier":
                    return "Guid";

                case "smallint":
                    return allowNull ? "short?" : "short";

                case "tinyint":
                    return "byte";

                case "variant":
                case "udt":
                    return "object";

                case "structured":
                    return "DataTable";

                case "datetimeoffset":
                    return allowNull ? "DateTimeOffset?" : "DateTimeOffset";

                default:
                    throw new NotImplementedException(type);
            }
        }
    }
}