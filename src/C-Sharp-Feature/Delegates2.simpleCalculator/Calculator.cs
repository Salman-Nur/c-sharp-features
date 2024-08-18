using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2.simpleCalculator
{
    delegate double CalculateDelegate(double num1, double num2);

    internal  class Calculator
    {
        public static CalculateDelegate addDelegate = new CalculateDelegate(Add);
        public static Func<double, double, double> subtractDelegate = Subtract;
        public static Func<double, double, double> multiplyDelegate = Multiply;
        
        public static CalculateDelegate? divideDelegate = null;


        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}




