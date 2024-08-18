List<List<int>> nestedLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 5 },
                new List<int> { 4, 5 },
                new List<int> { 6, 7, 8, 9 }

            };

int count = nestedLists.Count(l => l.Count() > 2);
int countn = nestedLists.Count(l => l.Contains(5));
Console.WriteLine(count + "       " + countn);