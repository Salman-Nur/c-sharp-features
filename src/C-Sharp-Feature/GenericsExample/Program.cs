//using GenericsExample;
//using System.Text;

//Console.WriteLine("--------------------------- 1 --------------------------");





//Console.WriteLine("--------------------------- 2 --------------------------");

//Console.WriteLine("--------------------------- 3 --------------------------");
//Console.WriteLine("--------------------------- 4 --------------------------");
//Console.WriteLine("--------------------------- 5 --------------------------");
//Console.WriteLine("--------------------------- 6 --------------------------");
//Console.WriteLine("--------------------------- 7 --------------------------");
//Console.WriteLine("--------------------------- 8 --------------------------");
//Console.WriteLine("--------------------------- 9 --------------------------");
//Console.WriteLine("--------------------------- 10 --------------------------");





//DataStore<string> strStore = new DataStore<string>();
//strStore.Data = "Hello World!";
////strStore.Data = 123; // compile-time error

//DataStore<int> intStore = new DataStore<int>();
//intStore.Data = 100;
////intStore.Data = "Hello World!"; // compile-time error



//GenericsExample.KeyValuePair<int, string> kvp1 = new GenericsExample.KeyValuePair<int, string>();
//kvp1.Key = 12;
//kvp1.Value = "Hundred";

//GenericsExample.KeyValuePair<string, string> kvp2 = new GenericsExample.KeyValuePair<string, string>();
//kvp2.Key = "IT";
//kvp2.Value = "Information Technology";



//DataStore<string> dataStore = new DataStore<string>();
//dataStore.arr[0] = "Jannat";
//dataStore.arr[1] = "Muhammad";
//dataStore.arr[2] = "Salman";

//Console.WriteLine(dataStore.arr[1]);

//DataStore<int> empIds = new DataStore<int>();
//empIds.AddOrUpdate(0, 50);
//empIds.AddOrUpdate(1, 65);
//empIds.AddOrUpdate(2, 89);

//Console.WriteLine(empIds.GetData(1));


//// a non generic class can contain generic methods
//Printer printer = new Printer();
//printer.Print<int>(100000000);
//printer.Print<string>("Allahu_akbar");

//printer.Print(354.343);     // type infer from the specified value
//printer.Print("Subhanallah"); // type infer from the specified value



////https://www.c-sharpcorner.com/UploadFile/84c85b/using-generics-with-C-Sharp/






//// JavaTpoint 
//GenericClass<string> genStr = new GenericClass<string>("This is Generic class");

//GenericClass<int> genInt = new GenericClass<int>(101);

//GenericClass<char> genChar = new GenericClass<char>('x');



////C#_batch9 video class 12
/////Point point = new Point();
////point.X = 10;
////point.Y = 20;


/////Point point1 = new Point();
////point1.X = 234.34;
////point1.Y = 34.43;



///// Here is a problem in the following code : mix up hoiye jasse
////Point point2 = new Point();
////point2.X = "Allahuakbar";
////point2.Y = 45;


/////Here is another problem : when we want to sum two point, need casting
////int z = (int)point.X + (int)point.Y;
//// plus low performence cuz Boxing and unboxing (oxing is the conversion of the value type to an object type,
//// whereas unboxing refers to the conversion of the object type to value type.)


//Point<int, double> point1 = new Point<int, double>();
//point1.X = 24;
//point1.Y = 34.3;


//Point<double, double> point2 = new Point<double, double>();
//point2.X = 343.343;
//point2.Y = 34.43;




//PointFInal<int> point3 = new PointFInal<int>();



//PointWithConstraint<StringBuilder, int> point4 = new PointWithConstraint<StringBuilder, int>();


//Box<Book> bookBox = new Box<Book>();
//bookBox.Add(new Book() { Name = "C# reference", Price = 2343.34 });
//bookBox.Add(new Book() { Name = "PHP reference", Price = 2343.34 });


//Box<Shirt> shirtBox = new Box<Shirt>();
//shirtBox.Add(new Shirt() { Name = "Summer Shirt", Color = "Yellow" });
//shirtBox.Add(new Shirt() { Name = "Night Shirt", Color = "White" });

//SimpleBox simpleBox = new SimpleBox();
//simpleBox.Add(new Shirt() { Name = "sdfj", Color = "A" });
//simpleBox.Add(new Book() { Name = "e34", Price = 234.343 });




//List<Book> book = new List<Book>();

//List<Book> books = bookBox.GetItems<List<Book>>();
//LinkedList<Book> listOfBook = bookBox.GetItems<LinkedList<Book>>();



using GenericsExample;
using System.Collections.Specialized;

double area = RectangleArea.CalculateRectangleArea(5.0, 10.0);
int areaInt = RectangleArea.CalculateRectangleArea(5, 10);
decimal areaDecimal = RectangleArea.CalculateRectangleArea(5.0m, 10.0m);
Console.WriteLine(area);



var s = new Scale<double>();
s.Weight = 20.50;
Console.WriteLine(s.MeasureWeight(5));

OrderedDictionary orderedDictionary = new OrderedDictionary();   


orderedDictionary.Add("3", 333333333);
orderedDictionary.Add(4, 444444444);

int value = (int)orderedDictionary["3"];

Console.WriteLine(value);

