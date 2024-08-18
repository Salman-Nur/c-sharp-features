using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Delegates
{
    
    public class DelegateExample
    {

        //public delegate int Calculate(int x, int y);
        //public delegate int Calculate(int x, int y); // declare a delegate type


        //public static Func<int, int, int> func = (x, y) => x + y;
        //public static Action<string> action = (message) => Console.WriteLine(message);
        public delegate void Del(string str);
        public delegate void Del1(int str);
        public void PrintingName(string name)
        {
            Console.WriteLine(name);
        }
        public void PrintingAge(int age)
        {
            Console.WriteLine(age);
        }
        



         
 





    }
    
}
