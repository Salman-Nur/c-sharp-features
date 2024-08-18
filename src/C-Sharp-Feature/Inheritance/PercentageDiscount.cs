using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

public class PercentageDiscount : Discount
{
    public override double Amount { get => base.Amount ; set => base.Amount = value; }
    public PercentageDiscount(double amount, int dlskfj) : base(amount, dlskfj)
    {
        Amount = amount + dlskfj;
    }

    public override double PriceAfterDiscount(double originalPrice)
    {
            return originalPrice - (originalPrice*Amount/100);
    }
}
