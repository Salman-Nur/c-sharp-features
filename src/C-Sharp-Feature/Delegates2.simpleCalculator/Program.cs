using System;

using static Delegates2.simpleCalculator.Calculator;

class Program
{

    static void Main(string[] args)
    {
        double num1, num2;
        string operation;

        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter operation (  +  ,  -  ,  *  ,   /   ): ");
        operation = Console.ReadLine()!;



        double result = 0;
        if (operation == "+")
        {
            result = addDelegate(num1, num2);
        }
        else if (operation == "-")
        {
            result = subtractDelegate(num1, num2);
        }
        else if (operation == "*")
        {
            result = multiplyDelegate(num1, num2);
        }
        else if (operation == "/")
        {
           
            divideDelegate = Divide;
            divideDelegate += Add;
            divideDelegate += Subtract;
            divideDelegate += Multiply;
            divideDelegate -= Multiply;
            divideDelegate += Multiply;
            result = divideDelegate.Invoke(num1, num2);
            //result = divideDelegate(num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid operation");
        }
        Console.WriteLine("Result: " + result);
    }

}

