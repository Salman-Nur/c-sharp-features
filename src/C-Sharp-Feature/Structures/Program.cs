

using Structures;

Class1  clss = new Class1();
clss.C = 23;
clss.D = 34;

var result1 = clss.anotherPoint1(clss);
Console.WriteLine(result1);


var p1 = new Point();
p1.X = 1; p1.Y = 2;

var p2 = new Point();
p2.X = 3; p2.Y = 4;

//p2 = p1;

p1 = p2;

p1.X = 23434; p1.Y = 34343;


Console.WriteLine(p1.X + "           " + p1.Y);
Console.WriteLine(p2.X);