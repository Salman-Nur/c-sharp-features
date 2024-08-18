// See https://aka.ms/new-console-template for more information

// general switch 
// limitation 1. we cannot compare object value + hard to type
using NewSwitch;

int x = 5;
switch (x)
{
    case 0:
        Console.WriteLine("Start");
        break;

    case 1:
        Console.WriteLine("In progresss");
        break;
    default:
        Console.WriteLine("End");
        break;
}
// new switch 
string y = x switch
{
    0 => "Start",
    1 => "In Progress",
    _ => "End"
};
Console.WriteLine(y);

Person p = new Person() { Name = "Jalaluddin", Age = 40 };

string y2 = p switch
{

    { Name: "Jalaluddin", Age: 20 } => "Start", 
    // { Name: "Jalaluddin", Age: 20 } => GetText(), // here, we can use many statement by using method 
    { Name: "Tarek", } => "In Progress",
    { Name: _ } => "End"
};

string GetText()
{
    string x = "Hello" + "5";
    return x;
}


int operation = 2;
string result = operation switch
{
    1 => "Case 1",
    2 => "Case 2",
    3 => "Case 3",
    4 => "Case 4",
};

Console.WriteLine(result);






Console.WriteLine("==============================================    Level 0    ==============================================");
//while (true)
//{
//    string str1 = Console.ReadLine();
//    int answer1 = str1 switch
//    {
//        "+" => 5 + 5,
//        "-" => 5 - 5,
//        "*" => 5 * 5,
//        "/" => 5 / 5,
//        "exit" => 2,
//        _ => -1
//    };
//    if (answer1 == 2) break;
//    else if (answer1 == -1) Console.WriteLine("Wrong Operator! Please Enter :   ( +   or  -   or   *  or   / )");
//    else Console.WriteLine(answer1);
  
//}







Console.WriteLine("==============================================    Level 1    ==============================================");

Console.WriteLine("C# 8.0 New Feature Swtich Expressions");

//example1    
(int a, int  b,string option) sss = (3, 4, "+");

var example1 = sss.option switch
{
    "+" => sss.a + sss.b,
    "-" => sss.a - sss.b,
    _ => sss.a * sss.b
};
Console.WriteLine("Example 1 : " + example1);

//example2    
var cal = new Calculation(10, 20, "/");
var example2 = cal.Operation switch
{
    "+" => cal.FirstNumber + cal.SecondNumber,
    "-" => cal.FirstNumber - cal.SecondNumber,
    _ => cal.FirstNumber * cal.SecondNumber,
};
Console.WriteLine("Example 2 : " + example2);
Console.WriteLine("Property Assignment : " + cal.LogLevel);

//example3    
var value = 25;

int example3 = value switch
{
    _ when value > 10 => 0,
    _ when value <= 10 => 1
};
Console.WriteLine("Example 3 : " + example3);

//example4    
var dic = new Dictionary<string, string>();
var (key, defaultValue) = ("Jeetendra", "C# Corner");

var example4 = dic.TryGetValue(key, out string val) switch
{
    false => defaultValue,
    _ => val
};
Console.WriteLine("Example 4 : " + example4);


