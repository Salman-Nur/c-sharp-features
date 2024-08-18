using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Car
    {
        public string Model { get; set; }   
        public string Color { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Speed = 100;
        }

        public void IncreaseSpeed()
        {
            Speed += 10;
        }
        public void Stop()
        {
            Speed = 0;
        }
    }
}

//foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
//{
//    if (t.Name == className)
//    {
//        ConstructorInfo constructor = t.GetConstructor(new Type[] { });
//        object instance = constructor.Invoke(new object[] {});
//        while (true)
//        {
//            string methodName = Console.ReadLine();
//            if (methodName == "exit")
//            {
//                break;
//            }
//            else
//            {
//                MethodInfo method = t.GetMethod(methodName, new Type[] { });
//                if (method != null)
//                {
//                    method.Invoke(instance, new object[] { });
//                }
//            }
//        }

//        PropertyInfo property = t.GetProperty("Speed");

//        int speed = (int)property.GetValue(instance);
//        Console.WriteLine(speed);


