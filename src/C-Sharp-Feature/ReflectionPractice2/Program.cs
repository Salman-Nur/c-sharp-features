


using System.Reflection;

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

var assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

var property = type.GetProperty(propertyName);
var constructor = type.GetConstructor(new Type[] { });

object instance = constructor.Invoke(new object[] { });
property.SetValue(instance, propertyValue);


//Console.WriteLine((instance as Person).Name);

foreach (var p in type.GetProperties())
{
    Console.WriteLine($"{p.Name}  : {p.GetValue(instance)}");
}


/*
 
*/

/*
/// when no parameterised constructor  + Printing Properties <------------------------------------------

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

var assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

var property = type.GetProperty(propertyName);
var constructor = type.GetConstructor(new Type[] { });

object instance = constructor.Invoke(new object[] { });
property.SetValue(instance, propertyValue);


//Console.WriteLine((instance as Person).Name);

foreach (var p in type.GetProperties())
{
    Console.WriteLine($"{p.Name}  : {p.GetValue(instance)}");
}
 
*/

/*
///Printing Private Properties <------------------------------------------

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

var assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

var property = type.GetProperty(propertyName);
var constructor = type.GetConstructor(new Type[] { });

object instance = constructor.Invoke(new object[] { });
property.SetValue(instance, propertyValue);


//Console.WriteLine((instance as Person).Name);

foreach (var p in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public ))    //<<===============================
{
    Console.WriteLine($"{p.Name}  : {p.GetValue(instance)}");
}
 

*/

/*
/// constructor Parameterized hoile  +  property onno ta set kortesi <------------------------------------------


string className = Console.ReadLine();
string propertyName = Console.ReadLine();
int propertyValue = Convert.ToInt32(Console.ReadLine());     //<<===============================

var assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);   

var property = type.GetProperty(propertyName);    //<<=============================== 
var constructor = type.GetConstructor(new Type[] { typeof(string), typeof(int), typeof(string) });    //<<===============================

object instance = constructor.Invoke(new object[] { "Salman", 70, "01717745454" });      //<<===============================
property.SetValue(instance, propertyValue);


//Console.WriteLine((instance as Person).Name);

foreach (var p in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
{
    Console.WriteLine($"{p.Name}  : {p.GetValue(instance)}");  
}
*/





/*
ReflectionPractice2.Person
Name
Faisal
*/



