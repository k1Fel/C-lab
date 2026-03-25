using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starodubov_PD21
{
    public class TextOperator
    {
        public delegate string TextOperation(string text);

        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string CountChars(string text)
        {
            return $"Кількість символів:{text.Length}";
        }
        public static string WordCount(string text)
        {
            return $"Кількість слів:{text.Split(' ').Length}";
        }
    }
}
