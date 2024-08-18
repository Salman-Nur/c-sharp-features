using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    public abstract class Discount 
    {
        public Discount(double amount) 
        {
            Amount = amount;
        }
        public Discount(double amount, int x) 
        {
            Amount = amount;
        }
        public virtual double Amount { get; set; }

        public int Am { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract double PriceAfterDiscount(double originalPrice);

        public int x()
        {
            throw new NotImplementedException();
        }
    } 
}
