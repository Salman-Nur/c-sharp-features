//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Program
//{

//    public static void Main()
//    {

//        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
//        // a way of declaration int the following:
//        var (a, b, option) = (10, 5, "+");


//        Console.WriteLine("------------- 1 ----------------");
//        (double, int) tuple1 = (34.34, 15);
//        Console.WriteLine(tuple1.Item1); Console.WriteLine(tuple1.Item2);


//        Console.WriteLine("------------- 2 ----------------");
//        (double Umar, int Ali) tuple2 = (77.55, 13);
//        Console.WriteLine(tuple2.Item1); Console.Write(tuple2.Item2);
//        Console.WriteLine(tuple2.Umar); Console.WriteLine(tuple2.Ali);


//        Console.WriteLine("------------- 3 ----------------");
//        (double, int) tuple3 = (34.3, 57);
//        Console.WriteLine(tuple3.GetHashCode());
//        tuple3.ToString();




//        Console.WriteLine("------------- 4 ----------------");
//        // (int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int) tuple4 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);
//        var tuple4 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);
//        Console.WriteLine(tuple4.Item17);
//        Console.WriteLine(tuple4);



//        Console.WriteLine("------------- 5 ----------------");

//        var tuple5 = (Sum: 4.5, Count: 3);  // if you use like this then must use var or "(double Sum, int Count) tuple5 = (Sum: 4.5, Count: 3);"
//        Console.WriteLine($"Sum of {tuple5.Count} elements is {tuple5.Sum}.");


//        (double Sum, int Count) d = (4.5, 3);   // To Simplify, in rightside, explicitly specify the names of tuple fields doesn't need 
//        Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");




//        Console.WriteLine("------------- 6 ----------------");
//        //It is known as tuple projection initializer
//        /*  
//            Task is : 
//            1. take two double and int variale and initialize them in same line;
//            2. declare a tuple then print them
//         */

//        var x = 45.4;   //double x = 45.4;
//        var y = 3;      //int y = 3;

//        var tuple6 = (x, y);     // (double x, int y) tuple6 = (x, y);
//        Console.WriteLine($"{tuple6.x}   { tuple6.y}");






//        Console.WriteLine("------------- 7 ----------------");
//        var tuple7 = (a, b: 20, 30);
//        Console.WriteLine($"The 1st element is {tuple7.Item1} (same as {tuple7.a}).");
//        Console.WriteLine($"The 2nd element is {tuple7.Item2} (same as {tuple7.b}).");
//        Console.WriteLine($"The 3rd element is {tuple7.Item3}");



//        Console.WriteLine("------------- 8 ----------------");

//        (double x, int y) tuple8 = (45.89, 100);
//        (int, int) tupleX = (0, 0);
//        tuple8 = tupleX;
//        Console.WriteLine($"{tuple8.Item1}    {tuple8.Item2}");  // Tuple element values are assigned following the order of tuple elements
//        Console.WriteLine(nameof(tuple8)); //The names of tuple fields are ignored and not assigned
//        Console.WriteLine(nameof(tupleX));  // The names of tuple fields are ignored and not assigned



//        Console.WriteLine("------------- 9 ----------------");
//        var t1 = ("post office1", 3.6);
//        (string destination1, double distance1) = t1;  //Explicitly declare the type of each variable inside parentheses
//        Console.WriteLine($"Distance to {t1.Item1} is {distance1} km.");  // two method is valid for value printing


//        var t2 = ("Post office2", 3.6);
//        var (destination2, distance2) = t2; // var keyword outside the parentheses to declare implicitly typed variables and let the compiler infer their types:




//        var destination = string.Empty;
//        var distance = 0.0;
//        var t = ("Post office", 4.3);
//        (destination, distance) = t;

//        Console.WriteLine($"{destination} and {distance}");




//        Console.WriteLine("------------- 10 ----------------");
//        (int a, byte b) left = (5, 10);
//        (long a, int b) right = (5, 10);
//        Console.WriteLine(left == right);





//        Console.WriteLine("------------- 11 ----------------");
//        Console.WriteLine((Display(1), Display(2)) == (Display(3), Display(4)));

//        int Display(int s)
//        {
//            Console.WriteLine(s);
//            return s;
//        }






//        Console.WriteLine("------------- 12 ----------------");
//        //User user = null;
//        //Membership membership = new Membership();


//        ////(AccountCreationStatus status, User user) result = membership.CreateUser("Jalaluddin", "1234");
//        ////Console.WriteLine(result.status);
//        ////Console.WriteLine(result.user.Username);


//        //var result = membership.CreateUser("Jalaluddin", "1234");
//        //Console.WriteLine(result.Item1);
//        //Console.WriteLine(result.Item2.Username);



//        (double x, int y) something1 = (5.5, 3);
//        (double x, int y) something2;
//        something2.x = 3.3;
//        something2.y = 65;

//        something2 = (3.43, 5);






//    }

//}






///___________________  The conclusion  ______________________

var tup1 = ("Muhammad", 1);    // (string , int) tup1= ("Muhammad", 1);   //you can use it too
Console.WriteLine(tup1.Item1 + "     " + tup1.Item2);



(string Name, int Score) tup2 = ("Abu Bakar", 2);
Console.WriteLine(tup2.Name + "     " + tup2.Score); //CW(tup2.Item1 + "     "  + tup2.Item2);  //you can use it too



