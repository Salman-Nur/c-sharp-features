using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaMethod
{
    internal class Lamd
    {
        public int a { get; set; }
        public int b { get; set; }
        
        public Lamd(int x, int y)
        {
            a = x; b = y;
        }

        public int Sum() => a + b;
        public int Mul() => a * b;
        


    }
}
