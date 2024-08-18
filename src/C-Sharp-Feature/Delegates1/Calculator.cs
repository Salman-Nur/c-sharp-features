using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public class Calculator
    {
        private delegate double Del();
        Del d;
        private readonly double[] numbers;
        private readonly string op;
        public Calculator(string op, params double[] numbers)
        {
            this.numbers = numbers;
            this.op = op;
        }

        public void CalulatingResult()
        {
            if (op == "+") { d = Addition; }
            else if (op == "-") { d = Subtraction; }
            else if (op == "*") { d = Multiplication; }
            else if (op == "/") { d = division; }

            double result = d();
            Console.WriteLine($"Result: {result}");
        } 


        private double Addition()
        {
            double result = 0;
            foreach (double item in numbers)
            {
                result += item;
            }
            return result;
        }
        private double Subtraction()
        {
            double result = 0;
            foreach (double item in numbers)
            {
                result -= item;
            }
            result -= numbers[0];
            return result;
        }
        private double Multiplication()
        {
            double result = 1;
            foreach (double item in numbers)
            {
                result *= item;
            }
            return result;
        }
        private double division()
        {
            double result = 1;
            foreach (double item in numbers)
            {
                result /= item;
            }
            return result * numbers[0];
        }
    }
}
