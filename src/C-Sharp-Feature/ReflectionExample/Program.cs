// See https://aka.ms/new-console-template for more information

using System.Reflection;
string className = Console.ReadLine();

Type[] t = Assembly.GetExecutingAssembly().GetTypes();
//Type t = Assembly.GetExecutingAssembly().GetType(className);  // Q1 ::::  In which situation we need GetType()



foreach (Type t2 in t)
{
    if (t2.Name == className)
    {
        ConstructorInfo constructor = t2.GetConstructor(new Type[] { });
        object instance = constructor.Invoke(new object[] { });

        while (true)
        {
            string methodName = Console.ReadLine();


            if (methodName == "exit")
            {
                break;
            }
            MethodInfo methodInfo = t2.GetMethod(methodName, new Type[] { });
            if(methodInfo != null )     // ????? to avoid exception but how can we understand here we can get an error
            {
                methodInfo.Invoke(instance, new object[] { });   
            }

        }

        // If we use Person class, we don't need the following 3 lines of code.
        PropertyInfo property = t2.GetProperty("Speed");  
        int speed = (int)property.GetValue(instance);
        Console.WriteLine(speed);
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
//        t.GetProperty("Speed");
//        PropertyInfo property = t.GetProperty("Speed");

//        int speed = (int)property.GetValue(instance);
//        Console.WriteLine(speed);


//    }



    




