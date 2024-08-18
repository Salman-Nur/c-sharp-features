
using PartialClass;

var prod = new Product(345);

prod.Name = "Car";

Console.WriteLine(prod.Name + " Price is :" + prod.method(prod.Price));