using LamdaMethod;
using System.Net.Http.Headers;
using System.Transactions;

Lamd lamd = new Lamd(4545,99);
int x = lamd.Sum();



Console.WriteLine(x);
Console.WriteLine(lamd.Mul());



Console.WriteLine("=============== Level 1 =============");
int sum(int a, int b) => a + b;

int result = sum(5, 4);
Console.WriteLine(result);

void Printer(string s) => Console.WriteLine(s);
Printer("Subhan_allah");


Func<int, int, int> method = (a, b) => a + b;   // anonymous method

int r = method(2, 2);
Console.WriteLine(r);


