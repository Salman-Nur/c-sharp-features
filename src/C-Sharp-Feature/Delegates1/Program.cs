using Delegates1;

List<double> list = new List<double>();
Console.Write("Valid operators (  +    -   *   /   ) \nEnter a Operator: ");
string op = Console.ReadLine();


double input;
Console.WriteLine("Enter some numbers : ");
while (true)
{
    string inputStr = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(inputStr)) break;
    input = Convert.ToDouble(inputStr);
    list.Add(input);
}

Calculator calculator = new Calculator(op, list.ToArray());

calculator.CalulatingResult();

