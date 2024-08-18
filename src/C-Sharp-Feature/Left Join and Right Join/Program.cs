using System.Reflection.Emit;

namespace Left_Join_and_Right_Join
{
    public class A
    {
        public int User { get; set; }
        public int Age { get; set; }
        public  double Data { get; set; }

    }
    public class B
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public  double Growth { get; set; }

    }

    public static class Program
    {
        public static List<A> Table1 = new List<A>()
        { 
            new A() {User = 1, Age = 2, Data = 43.5   },
            new A() {User = 2, Age = 3, Data = 44.5   },
            new A() {User = 3, Age = 4, Data = 45.6   }
        };
        public static List<B> Table2 = new List<B>()
        {
            new B() { ID = 1, Age = 2, Growth = 46.5},
            new B() { ID = 1, Age = 5, Growth = 49.5},
            new B() { ID = 1, Age = 6, Growth = 48.5},
        };
        static void Main(string[] args)
        {
            #region Left Join
            var result1 = from x in Table1
                          join y in Table2
                          on x.User equals y.ID
                          into g
                          from z in g.DefaultIfEmpty()
                          select (tableOne: x, tableTwo: z?.Growth ?? null);
            Console.WriteLine("Left Join: ============");
            foreach (var i in result1)
            {
                Console.WriteLine($"{i.tableOne.User}  {i.tableOne.Age}    {i.tableOne.Data}   {i.tableTwo}");
            }
            #endregion





            #region Right Join
            var result2 = from y in Table2
                          join x in Table1 
                          on y.ID equals x.User
                          into g
                          from z in g.DefaultIfEmpty()
                          select (tableTwo:y, tableOne : (age :z?.Age?? null, data: z?.Data?? null));
            Console.WriteLine("\nRight Join: ============");
            foreach (var i in result2)
            {
                Console.WriteLine($"{i.tableTwo.ID}  {i.tableTwo.Age}  {i.tableTwo.Growth}       {i.tableOne.age}  {i.tableOne.data} ");
            }
            #endregion 
        }
    }
}