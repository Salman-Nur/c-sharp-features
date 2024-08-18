
IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };


#region LINQ Query Syntax to find out teenager students (12 < teenager < 20)
var teenAgerStudent = from s in studentList
                      where s.Age > 12 && s.Age < 20
                      select s;
#endregion

foreach (var ss in teenAgerStudent)
{
    Console.WriteLine(ss.Age);
}




class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}