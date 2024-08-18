using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1 : PercentageDiscount
    {
        public Class1(double amount, int x) : base(amount, x) { }



        public override double PriceAfterDiscount(double originalPrice)
        {


            return originalPrice - Amount;

        }
    }
}
