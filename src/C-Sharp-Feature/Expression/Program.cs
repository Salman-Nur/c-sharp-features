

using System.Linq.Expressions;

Func<int, int, int> someMethod = (a, b) => a + b;

Expression<Func<int, int, int>> expression = (a, b) => a + b;
Func<int, int, int> method = expression.Compile();

int result = method(2, 3);
Console.WriteLine(result);

