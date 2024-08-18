using System.Diagnostics.Metrics;

List<Country> countries = new List<Country>()
{
    new Country { Name = "China", Population = 14_000_000 },
    new Country { Name = "India", Population = 13_000_000 },
    new Country { Name = "United States", Population = 330_000_000 },
    new Country { Name = "Indonesia", Population = 270_000_000 },
    new Country { Name = "Pakistan", Population = 220_000_000 },
    new Country { Name = "Bangladesh", Population = 160_000_000 },
    new Country { Name = "Japan", Population = 126_000_000 },
    new Country { Name = "Philippines", Population = 110_000_000 },
    new Country { Name = "Vietnam", Population = 97_000_000 },
    new Country { Name = "Turkey", Population = 84_000_000 },
    new Country { Name = "Iran", Population = 83_000_000 },
    new Country { Name = "Thailand", Population = 68_000_000 },
    new Country { Name = "Myanmar", Population = 54_000_000 },
};
// percentileQuery is an IEnumerable<IGrouping<int, Country>>
var percentileQuery = from n in countries
                      let percent = n.Population / 10_000_000
                      group n by percent into g
                      where g.Key >= 20
                      orderby g.Key ascending
                      select g;



// grouping is an IGrouping<int, Country>
foreach (var grouping in percentileQuery)
{
    Console.WriteLine(grouping.Key);
    foreach (var country in grouping)
    {
        Console.WriteLine(country.Name + ":" + country.Population);
    }
}
class Country
{
    public string Name { get; set; }
    public int Population { get; set; }
}




//List<Country> countries = new List<Country>
//{
//    new Country { Name = "United States", Capital = "Washington D.C.", Population = 331002651 },
//    new Country { Name = "India", Capital = "New Delhi", Population = 1380004385 },
//    new Country { Name = "Indonesia", Capital = "Jakarta", Population = 273523615 },
//    new Country { Name = "Brazil", Capital = "Brasília", Population = 211049527 },
//    new Country { Name = "Pakistan", Capital = "Islamabad", Population = 220892340 }
//};

//#region   MyQuery
//var queryCountryGroups = from c in countries
//                         group c by c.Name[0] into g
//                         orderby g.Key
//                         select g;
//#endregion

//foreach (var group in queryCountryGroups)
//{
//    Console.Write(group.Key + ": ");
//    foreach (var country in group)
//    {
//        Console.WriteLine("\t" + country.Population);
//    }
//}







////string[] names = { "beans", "carrots", "cabbage", "broccoli", "barley" };
////IEnumerable<IGrouping<char, string>> queryFoodGroups = from n in names
////                                                       group n by n[0];
////foreach (var group in queryFoodGroups)
////{
////    Console.Write(group.Key + " :");
////    foreach (var item in group)
////        Console.WriteLine("\t" + item);
////}



//class Country
//{
//    public string Name { get; set; }
//    public string Capital { get; set; }
//    public int Population { get; set; }
//}



