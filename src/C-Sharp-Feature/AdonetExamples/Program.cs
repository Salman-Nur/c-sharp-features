using AdonetExamples;
string connectionString = "Server=MUHAMMAD\\SQLEXPRESS;Database=CSharpB9x;User Id=csharpb9x;Password=123456;TrustServerCertificate=True;";

/// Hardcore kore Insert, Update, Delete ------------------------------------------------------------
DataUtility dataUtility = new DataUtility(connectionString);
dataUtility.ExecuteCommand("Update Students Set [Name] = 'Hasib' where [Name] = 'Majeda'", null);
dataUtility.ExecuteCommand("Delete From Students where [Name] = 'Hasib'", null);
string query = "Delete From Students where [Name] Like '%faisa%'";
dataUtility.ExecuteCommand("Insert Into Students ([Name], DateOfBirth) values ('x' , '2001-01-12')", null);

/// Take Input from user and insert it but we prevent sql injection ----------------------------------------------
string name = Console.ReadLine();
string dateOfBirth = Console.ReadLine();
string query1 = $"Insert Into Students ([Name], DateOfBirth) values (@name, @dateOfBirth)";  //scalar variable use to avoid sql injection attack
List<(string key, object value)> parameters = new List<(string key, object value)>();
parameters.Add(("name", name));
parameters.Add(("dateOfBirth", dateOfBirth));

dataUtility.ExecuteCommand(query, parameters);



///For Read Data + Printing 
DataUtility dataUtility1 = new DataUtility(connectionString);
string query2 = "select * from students";
//string query2 = "select [Name] from students";
var result = dataUtility1.ReadData(query2, null);
if (result != null && result.Count > 0)
{
    foreach (var col in result[0].Keys)
    {
        Console.Write(col);
        Console.Write('\t');
    }
    Console.WriteLine();

    foreach (var row in result)
    {
        foreach (var col in row.Values)
        {
            Console.Write(col);
            Console.Write('\t');
        }
        Console.WriteLine();
    }
}




