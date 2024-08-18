using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static int AsciiSum(this string text)
        {
            int sum = 0;
            foreach (char c in text)
            {
                sum += (int)c;
            }
            return sum;  

        }
    }
}
