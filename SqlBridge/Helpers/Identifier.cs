namespace SqlBridge
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Schema;

    public class Identifier
    {
        public static string PascalStyle(string name)
        {
            var sb = new StringBuilder();

            var capital = true;
            var prev = 'x';

            for (var i = 0; i < name.Length; i++)
            {
                var ch = name[i];

                if (char.IsUpper(ch) && char.IsLower(prev))
                {
                    capital = true;
                }

                prev = ch;

                if(!char.IsLetterOrDigit(ch))
                {
                    capital = true;
                    continue;
                }

                sb.Append(capital ? char.ToUpper(ch) : char.ToLower(ch));
                capital = false;
            }

            return sb.ToString();
        }

        public static string CamelStyle(string name)
        {
            var pascalStyle = PascalStyle(name);
            return char.ToLower(pascalStyle[0]) + pascalStyle.Substring(1);
        }

        public static string SqlArgList(IEnumerable<SpParameter> list )
        {
            return string.Join(",", list.Select((l, index) => "@" + index));
        }
    }
}