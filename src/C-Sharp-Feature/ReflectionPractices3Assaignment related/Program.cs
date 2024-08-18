//using ReflectionPractices3_Assaignment_related;
//using System.Reflection;
//using System.Text;

//Console.WriteLine();

//Person person2 = new Person();
//person2.Name = "Tarek";
//person2.Age = 30;
//person2.Address = "Dhaka";


//person2.Children = new Child[2];
//person2.Children[0] = new Child()
//{
//    Name = "Rida",
//    Age = 3,
//    Gender = "F"
//};

//person2.Children[1] = new Child()
//{
//    Name = "Ruhi",
//    Age = 4,
//    Gender = "F"
//};


//string json = ConvertToJson(person2);

//string ConvertToJson(object person)  // Person person
//{
//    Type[] types = Assembly.GetExecutingAssembly().GetTypes();

//    foreach (Type type in types)
//    {
//        if (type == person.GetType())
//        {

//            //var constructor = type.GetConstructor(new Type[] { });
//            //var instance = constructor.Invoke(new object[] { });

//            var propertyInfo = type.GetProperties();


//            Console.WriteLine("{");
//            int i = 1;
//            foreach (PropertyInfo property in propertyInfo)
//            {
//                //if (property.GetType().IsClass && property.GetType().IsArray)
//                //{
//                //    ConvertToJson(property.GetType());
//                //}


//                if (i == propertyInfo.Length)
//                {
//                    if (property.PropertyType == typeof(string))
//                    {


//                        Console.WriteLine($"    \"{property.Name}\" : \"{property.GetValue(person)}\""); i++;
//                    }
//                    else
//                    {

//                        Console.WriteLine($"    \"{property.Name}\" : {property.GetValue(person)}"); i++;
//                    }
//                }
//                else
//                {
//                    if (property.PropertyType == typeof(string))
//                    {
//                        Console.WriteLine($"    \"{property.Name}\" : \"{property.GetValue(person)}\","); i++;
//                    }
//                    else
//                    {
//                        Console.WriteLine($"    \"{property.Name}\" : {property.GetValue(person)},"); i++;
//                    }
//                }

//            }
//            Console.WriteLine("}");
//        }
//    }


//    return string.Empty;
//}





//string ConvertToJson(object obj)
//{
//    StringBuilder json = new StringBuilder();
//    Type type = obj.GetType();
//    var propertyInfo = type.GetProperties();
//    json.Append("{");
//    int i = 1;
//    foreach (PropertyInfo property in propertyInfo)
//    {
//        if (property.PropertyType.IsArray)
//        {
//            var array = (Array)property.GetValue(obj);
//            json.Append($"    \"{property.Name}\" : [");
//            int j = 1;
//            foreach (var item in array)
//            {
//                json.Append(ConvertToJson(item));
//                if (j != array.Length)
//                {
//                    json.Append(",");
//                }
//                j++;
//            }
//            json.Append("    ],");
//        }

//        else if (property.PropertyType.IsClass)
//        {
//            json.Append($"    \"{property.Name}\" : {ConvertToJson(property.GetValue(obj))}");
//            if (i != propertyInfo.Length) json.Append(",");
//        }
//        else
//        {
//            if (i == propertyInfo.Length)
//            {
//                if (property.PropertyType == typeof(string))
//                {
//                    json.Append($"    \"{property.Name}\" : \"{property.GetValue(obj)}\"");
//                }
//                else
//                {
//                    json.Append($"    \"{property.Name}\" : {property.GetValue(obj)}");
//                }
//            }
//            else
//            {
//                if (property.PropertyType == typeof(string))
//                {
//                    json.Append($"    \"{property.Name}\" : \"{property.GetValue(obj)}\",");
//                }
//                else
//                {
//                    json.Append($"    \"{property.Name}\" : {property.GetValue(obj, null)},");
//                }
//            }
//        }
//        i++;
//    }
//    json.Append("}");
//    return json.ToString();
//}

using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public Child[] Children { get; set; }
}

class Child
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Tarek";
        person.Age = 30;
        person.Address = "Dhaka";

        person.Children = new Child[2];
        person.Children[0] = new Child()
        {
            Name = "Rida",
            Age = 3,
            Gender = "F"
        };

        person.Children[1] = new Child()
        {
            Name = "Ruhi",
            Age = 4,
            Gender = "F"
        };

        string json = ConvertToJson(person);
        Console.WriteLine(json);
    }

    static string ConvertToJson(object obj)
    {
        StringBuilder json = new StringBuilder();
        Type type = obj.GetType();

        json.Append("{");
        var propertyInfo = type.GetProperties();
        int i = 1;
        //var fieldInfo = type.GetFields();
        foreach (PropertyInfo property in propertyInfo)
        {
            if (property.PropertyType.IsArray)
            {
                var array = property.GetValue(obj) as Array;
                if (array != null)
                {
                    json.Append($"\"{property.Name}\":[");
                    for (int j = 0; j < array.Length; j++)
                    {
                        json.Append(ConvertToJson(array.GetValue(j)));
                        if (j < array.Length - 1)
                            json.Append(",");
                    }
                    json.Append("]");
                }
            }
            else if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
            {
                json.Append($"\"{property.Name}\":{ConvertToJson(property.GetValue(obj))}");
            }
            else
            {
                if (property.PropertyType == typeof(string))
                {
                    json.Append($"\"{property.Name}\":\"{property.GetValue(obj)}\"");
                }
                else
                {
                    json.Append($"\"{property.Name}\":{property.GetValue(obj)}");
                }
            }


            //json = json.TrimEnd(',') + "}";
            if (i < propertyInfo.Length)
                json.Append(",");
            i++;
        }

        json.Append("}");

        return json.ToString();
    }
}