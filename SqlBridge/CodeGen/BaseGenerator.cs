namespace SqlBridge.CodeGen
{
    public class BaseGenerator
    {
        protected string ValidId(string value)
        {
            return value.Replace(' ', '_');
        }
    }
}