using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#region  1st simple query
List<string> names = new List<string>() { "faisal", "salamn", "abdullah" };

IQueryable<string> query = (from name in names
                            where name.StartsWith("a")
                            select name).AsQueryable();

foreach (var x in query)
{
    Console.WriteLine(x);
}

//List<string> names = new List<string>() { "John", "Mary", "Bob" };

//IEnumerable<string> query = names.AsQueryable();
////IQueryable<string> query = names.AsQueryable();

//var result = from q in query
//             where q.StartsWith("J")
//             select q;


//foreach (string name in result)
//{
//    Console.WriteLine(name);
//}
#endregion




#region    StudentId and mark greater than 80 example
var studentIds = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

IQueryable<Student> GetStudentsFromDb()
{
    return new[]
    {
        new Student() { StudentID = 1, StudentName = "John Nigel", Mark = 73, City ="NYC"} ,
        new Student() { StudentID = 2, StudentName = "Alex Roma",  Mark = 51 , City ="CA"} ,
        new Student() { StudentID = 10, StudentName = "zoha Shamil",  Mark = 88 , City ="CA"},
        new Student() { StudentID = 4, StudentName = "James Palatte" , Mark = 60, City ="NYC"} ,
        new Student() { StudentID = 6, StudentName = "aon Jenova" , Mark = 85 , City ="NYC"},

    }.AsQueryable();
}

var studentList = GetStudentsFromDb();


var highPerformingStudentsQuerySyntax = from student in studentList
                                        where student.Mark >= 80 && (student.StudentID&1) != 1 
                                        orderby student.StudentName 
                                        select student;
foreach (var x in highPerformingStudentsQuerySyntax)
{
    Console.WriteLine(x.StudentName + " " + x.Mark);
}


/// <summary>
/// method syntax
/// </summary>
//var highPerformingStudentsMethodSyntax = studentList.Where(s => s.Mark > 80);  // method syntax 
//var highPerformingStudentsMethodSyntax = studentList.OrderBy((s => s.Mark > 80));  //method syntax
//var highPerformingStudentsMethodSyntax = studentList.OrderByDescending((s => s.Mark > 80));  // method syntax


//var highPerformingStudentsMethodSyntax = studentList.Where((s => s.Mark > 80)).OrderBy(y => y.StudentName);  // method syntax  
//foreach (var s in highPerformingStudentsMethodSyntax)
//{
//    Console.WriteLine(s.StudentName + " : " + s.Mark);
//}




class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Mark { get; set; }
    public string City { get; set; }
}

#endregion







#region
//int[] studentsIds = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//IEnumerable<int> studentsWithEvenIds = from studentId in studentsIds
//                                       where ((studentId&1) != 1)
//                                       select studentId;

//foreach (var student in studentsWithEvenIds)
//{
//    Console.WriteLine(student);
//}
#endregion 




