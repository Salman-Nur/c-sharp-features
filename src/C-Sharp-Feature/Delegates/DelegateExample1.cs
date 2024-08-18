using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegateExample1
    {
        public void Write(string text, string str)
        {
            Console.WriteLine(text + str);
        }

        public int SumWhoReturn(int a, int b)
        {
            return a + b; 
        }
        public void SumWhoDoesNotReturn(int a, int b)
        {
            Console.WriteLine(a+b); 
        }
    }
}
