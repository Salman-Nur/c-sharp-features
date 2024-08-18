
///print those numbers which are greater than 3
List<int> integerList = new()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
#region
IEnumerable<int> numbers1 = from n in integerList
                           where n > 3
                           select n;

foreach (var number in numbers1)
{
    Console.Write(number + " ");
    Console.WriteLine();
}
#endregion




///print: names whose length is greater than 8
var listOfNames = new List<string>()
{
    "John Doe",
    "Jane Doe",
    "Jenna Doe",
    "Joe Doe"
};
#region
IEnumerable<string> names = from n in listOfNames
                            where n.Length >= 8
                            select n;
foreach (var name in names)
{
    Console.WriteLine(name);
}
#endregion




/// print: greater than or equal 80 + even numbers + descending order
int[] scores = { 90, 71, 82, 93, 75, 80, 81 };
#region
// Query Expression.

IEnumerable<int> scoreQuery = from n in scores
                              where n>=80
                              where (n&1) != 1
                              orderby n descending
                              select n;

// Execute the query to produce the results
#endregion
foreach (int testScore in scoreQuery)
{
    Console.WriteLine(testScore);
}





// string collection
IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

#region MyRegion
// LINQ Query Syntax
var result = from s in stringList
             where s.Contains("Tutorials")
             select s;
#endregion
foreach (var ss in result)
{
    Console.WriteLine(ss);
}




















