

using Inner_Join;
using System.Reflection;

List<Table1> table1 = new List<Table1>()
    {
        new Table1() {Id1 = 1, Roll = 111, Name ="Muhammad ", Age = 40},
        new Table1() {Id1 = 2,Roll = 222, Name = "Abu Bakar", Age = 34},
        new Table1() {Id1 = 3,Roll = 333, Name = "Ali      ", Age = 20},
        new Table1() {Id1 = 4,Roll = 444, Name = "Umar     ", Age = 25}
    };

List<Table2> table2 = new List<Table2>()
    {
        new Table2() {Id2 = 1, Regist = 345454, Country = "Bangladesh"},
        new Table2() {Id2 = 1, Regist = 345454, Country = "Arabia"},
        new Table2() {Id2 = 1, Regist = 345454, Country = "Whole world"},
        new Table2() {Id2 = 2,Regist = 454545, Country = "Pakistan"},
        //new Table2() {Id2 = 3,Regist = 576766, Country = "Arabia"},
        new Table2() {Id2 = 6,Regist = 676767, Country = "Palastine"}
    };


//var q = from c in table1
//        join p in table2
//        on c equals p.Category
//        select (Category: c, p.ProductName);

//foreach (var v in q)
//{
//    Console.WriteLine(v.ProductName + ": " + v.Category);
//}


#region   Inner Join
//var q = from a in table1
//        join b in table2
//        on a.Id1 equals b.Id2
//        select (a, b);

//Console.WriteLine($"Name     \tRoll\tAge\tRegist\t   Country");
//Console.WriteLine($"----     \t----\t---\t------\t   -------");
//foreach (var item in q)
//{
//    Console.WriteLine($"{item.a.Name}\t{item.a.Roll}\t{item.a.Age}\t{item.b.Regist}\t   {item.b.Country}");
//}
#endregion








#region   Group Join
//var q = from a in table1
//        join b in table2
//        on a.Id1 equals b.Id2
//        into g
//        select (a, g); 

//foreach (var item in q)
//{
//    Console.WriteLine($"{item.a.Name} : ");//\t{item.a.Roll}\t{item.a.Age}\t");
//    foreach (var v in item.g)
//    {
//        Console.WriteLine($"{v.Regist}\t   {v.Country}");

//    }
//    Console.WriteLine();
//    Console.WriteLine();
//}
#endregion





#region Left Outer Join
//var query = from n1 in table1
//            join n2 in table2
//            on n1.Id1 equals n2.Id2 into g
//            from r in g.DefaultIfEmpty()
//            select (n1, reg: r?.Regist ?? null, coun: r?.Country ?? null);

//foreach (var table in query)
//{
//    Console.WriteLine(table.n1.Name + "    :   " + (table.reg == null ? "NULL" : table.reg) + "         :         " + (table.coun == null ? "NULL" : table.coun));
//}









//var q = from a in table1
//        join b in table2
//        on a.Id1 equals b.Id2 into g
//        from j in g.DefaultIfEmpty()
//            //select (a, j);
//        select (a, Regist: j?.Regist ?? null, Country: j == null ? "NULL" : j.Country);
////select (a, Regist : j?.Regist ?? null, Country : j==null? "NULL":j.Country );

//Console.WriteLine($"Name     \tRoll\tAge\tRegist\t   Country");
//Console.WriteLine($"----     \t----\t---\t------\t   -------");
//foreach (var item in q)
//{
//    Console.Write($"{item.a.Name}\t{item.a.Roll}\t{item.a.Age}");
//    if (item.Regist == null)
//    {
//        Console.Write("\tnull");
//    }
//    else
//    {
//        Console.Write($"\t{item.Regist}");
//    }
//    Console.WriteLine($"\t   {item.Country}");
//}
#endregion















