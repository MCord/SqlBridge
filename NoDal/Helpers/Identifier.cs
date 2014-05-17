namespace SqlBridge
{
    using System.Text;

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
    }
}