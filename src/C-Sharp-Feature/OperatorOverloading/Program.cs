using OperatorOverloading;

ComplexNumber c1 = new ComplexNumber(1.45, 2.54);
ComplexNumber c2 = new ComplexNumber(3.54, 4.54);
ComplexNumber c3 = c1 + c2;


Console.WriteLine(c3.Real);
Console.WriteLine(c3.Imaginary);






Fraction a = new Fraction(5, 7);

Fraction b = new Fraction(3, 4);

var result = a - b;

Console.WriteLine(result.num + "/" + result.den);






//Fraction fraction1 = new Fraction(5, 7);
//Fraction fraction2 = new Fraction(3, 4);
//var result = fraction1 - fraction2;
//Console.WriteLine(result.num + "/" + result.den);




//Fraction fraction1 = new Fraction(5, 7);
////var result = +fraction1;
//var result = -fraction1;
//Console.WriteLine(result.num + "/" + result.den);





