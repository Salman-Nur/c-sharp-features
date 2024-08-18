
using System.Text;

string[] fruits = { "Apple", "Banana", "Goava", "Pinnaple" };


//var r1 = fruits[^1];
//var r2 = fruits[^2];
//var r3 = fruits[^3];
//var r4 = fruits[^4];

//Console.WriteLine(r1);
//Console.WriteLine(r2);
//Console.WriteLine(r3);
//Console.WriteLine(r4);


// Printing with loop 
for (int i = 1; i <= fruits.Length; i++)
{
    Console.WriteLine(fruits[^i]);
}

