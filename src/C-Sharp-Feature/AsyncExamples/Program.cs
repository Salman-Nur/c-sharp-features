// See https://aka.ms/new-console-template for more information

using AsyncExamples;
/// This code is for understanding = try catch throw 
//try
//{
//    Printer printer = new Printer();
//    await printer.Write(-20);   // if we give negative value + Aysncronous code/defferent thread e run kori. negative er
//                               // jonne oi thread ta dead hoi jabe exception throw korte parbe na
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

Printer printer = new Printer();
await printer.Write();
// await printer.Write();     // await keyward here to syncronous a asyncronous code


Console.WriteLine("hello");



Console.WriteLine("==================  level 1  =====================");
try
{
    Console.WriteLine("Enter a number: ");

    var num = int.Parse(Console.ReadLine());

    Console.WriteLine($"Squre of {num} is {num * num}");
}
catch(Exception ex)
{
    Console.Write("Error occurred." + ex.Message);
}
finally
{
    
}

Console.WriteLine("=============================  level 2  =================================");
Console.Write("Please enter a number to divide 100: ");

try
{
    int num = int.Parse(Console.ReadLine());

    int result = 100 / num;

    Console.WriteLine("100 / {0} = {1}", num, result);
}

catch (DivideByZeroException)
{
    Console.Write("Cannot divide by zero. Please try again.");
}
catch (InvalidOperationException ex)
{
    Console.Write("Invalid operation. Please try again.");
}
catch (FormatException ex)
{
    Console.Write("Not a valid format. Please try again.");
}
catch (Exception ex)
{
    Console.Write("Error occurred! Please try again.");
}
Console.ReadKey();