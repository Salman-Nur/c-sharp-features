
using System;
using System.Diagnostics.Metrics;

List<Country> countries = new List<Country>
{
    new Country("United States", 1500, 63343453),
    new Country("Russia", 2000, 34353433),
    new Country("China", 999,44234324),
    new Country("Canada", 570,3434234),
    new Country("Brazil", 7000,24324234)
};

// Here var is required because the query
// produces an anonymous type.
var studentQuery1 = from student in students
                    group student by student.Last[0];



foreach (var country in studentQuery1)
{
    Console.WriteLine(country);
}
public class Country
{
    public string Name { get; set; }
    public int Area { get; set; }
    public int Population { get; set; }
    public Country(string name, int area, int population)
    {
        Name = name;
        Area = area;
        Population = population;
    }
}
