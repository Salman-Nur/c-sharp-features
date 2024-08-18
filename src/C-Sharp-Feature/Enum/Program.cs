//using Enum;
//AccountStatus GetStatus()
//{
//    return AccountStatus.Blocked;
//}

//AccountStatus accountstatus = GetStatus();


//if ( accountstatus == AccountStatus.Active)
//{
//    Console.WriteLine(accountstatus);
//}
//else if (accountstatus == AccountStatus.Canceled)
//{
//    Console.WriteLine((int)accountstatus);
//}
//else
//{
//    Console.WriteLine("Not match any case.");
//}



//___________________________________________________________________________________________________
public enum Gender
{
    Male,
    Female
}
public enum Position
{
    Administrator,
    Manager,
    Executive
}
public class Employee
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public Position Position { get; set; }
}
public class EmployeeManager
{
    private readonly List<Employee> _employees;

    public EmployeeManager()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var empManager = new EmployeeManager();
        var emp = new Employee { Name = "X", Gender = Gender.Male, Position = Position.Manager };
        empManager.AddEmployee(emp);

        //===============================================================================================================

        empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
        empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
    }
}

