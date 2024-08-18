using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;


string className = Console.ReadLine();

Assembly assembly = Assembly.GetExecutingAssembly();
Type[] allTypes = assembly.GetTypes();
foreach (Type type in allTypes)
{
    if (type.Name == className)
    {



        ConstructorInfo contructor = type.GetConstructor(new Type[] { });
        object instance = contructor.Invoke(new object[] { });

        var property = type.GetProperty("dateTime");


        foreach (var p in type.GetProperties())
        {
            DateTime date = (DateTime)property.GetValue(instance);
            Console.WriteLine($"{p.Name} : {date.ToString("yyyy-MM-ddTHH:mm:ss")}\")");
            //dateTime.ToString("yyyy-MM-ddTHH:mm:ss")
        }

    }
}

//Console.WriteLine(Dates.dateTime.Year);
public class Dates
{
    public DateTime dateTime { get; set; } = new DateTime(2023, 1, 15, 11, 0, 0);

    
    //Console.WriteLine(dateTime.Month);
}