
using System;

List<Country> countries = new List<Country>
{
    new Country("United States", 1500),
    new Country("Russia", 2000),
    new Country("China", 999),
    new Country("Canada", 570),
    new Country("Brazil", 7000)
};


#region The query is here ________________
var bigCountry = from country in countries
                 where country.Area > 1000
                 select country;
#endregion


foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}
public class Country
{
    public string Name { get; set; }
    public int Area { get; set; }

    public Country(string name, int area)
    {
        Name = name;
        Area = area;
    }
}
