// See https://aka.ms/new-console-template for more information
using ReflectionPractice1;
using System.Reflection;

var className = Console.ReadLine();


Assembly assembly = Assembly.GetExecutingAssembly();

Type[] allTypes =  assembly.GetTypes();
//var allTypes = Assembly.GetExecutingAssembly().GetTypes();

foreach (Type type in allTypes)
{
    if (type.Name == className)
    {
        var constructor = type.GetConstructor(new Type[] { });
        //var constructor = type.GetConstructor(Type.EmptyTypes);
        object instance = constructor.Invoke(new object[] { });

        while (true)
        {
            string methodName = Console.ReadLine()!;
            if (methodName == "exit")
            {
                break;
            }
            else
            {
                var methodInfo = type.GetMethod(methodName,new Type[] {});
                if(methodInfo != null )
                {
                    methodInfo.Invoke(instance, new object[] { });
                }


            }
            
        }
        //var propertyInfo = type.GetProperty("Speed");
        //int speed = (int)propertyInfo.GetValue(instance);
        //Console.WriteLine(speed);

    }
}
