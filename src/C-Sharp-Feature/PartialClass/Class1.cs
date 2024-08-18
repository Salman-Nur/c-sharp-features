using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Product
    {
        
        public Product(int price) { 
        
            Price= price;
        }

        public int method(int p)
        {
            return p + 5;
        }
    } 
}
