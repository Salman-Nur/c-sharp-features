
var math = new ParameterModifiers.Math();

Console.WriteLine(math.Sum(34,34));
Console.WriteLine(math.Sum(34, 34, 45));
Console.WriteLine(math.Sum(new int[] { 34,34,43,343,434}));


int x = 5;


math.ChangeValue(out x);
Console.WriteLine(x);