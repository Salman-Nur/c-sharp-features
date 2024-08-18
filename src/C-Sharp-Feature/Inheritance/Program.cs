using Inheritance;

PercentageDiscount percentageDiscount = new PercentageDiscount(10, 10);
//percentageDiscount.Amount = 10; 
double priceAfterDiscount = percentageDiscount.PriceAfterDiscount(2000);

Console.WriteLine(priceAfterDiscount);
