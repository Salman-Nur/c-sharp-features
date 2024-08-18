///print: city name and population (in descending order with respect to population)
List<Country> countries = new List<Country>
{
    new Country
    {
        Name = "United States",
        Cities = new List<City>
        {
            new City { Name = "New York", Population = 100 },
            new City { Name = "Los Angeles", Population = 200 },
            new City { Name = "Chicago", Population = 1000 },
            new City { Name = "Houston", Population = 5000 },
            new City { Name = "Phoenix", Population = 300 }
        }
    },
    new Country
    {
        Name = "India",
        Cities = new List<City>
        {
            new City { Name = "Mumbai", Population = 12344408 },
            new City { Name = "Delhi", Population = 500 },
            new City { Name = "Bangalore", Population = 8436675 },
            new City { Name = "Hyderabad", Population = 6767507 },
            new City { Name = "Ahmedabad", Population = 5570585 }
        }
    }
};



#region The Query is here .........
List<City> smallCitiesQuery = (from country in countries
                               from city in country.Cities
                               where city.Population < 1000
                               orderby city.Population descending
                               select city).ToList();

#endregion 










foreach (var city in smallCitiesQuery)
{
    Console.Write(city.Name + ": " + city.Population + " " + '\n');
}

class City
{
    public string Name { get; set; }
    public int Population { get; set; }
}

class Country
{
    public string Name { get; set; }
    public List<City> Cities { get; set; }
}

