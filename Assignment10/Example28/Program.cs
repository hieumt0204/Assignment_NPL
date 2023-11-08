using System.Data.SqlTypes;

public class Program
{
    /*
     *   Write a program in C# Sharp to split a collection of strings into some groups.
         :
        Here is the group of cities :

        ROME; LONDON; NAIROBI
        -- here is a group of cities --

        CALIFORNIA; ZURICH; NEW DELHI
        -- here is a group of cities --

        AMSTERDAM; ABU DHABI; PARIS
        -- here is a group of cities --

        NEW YORK
        -- here is a group of cities --
     */
    static void Main(string[] args)
    {
        string[] cities = {
            "ROME",
            "PARIS",
            "LONDON",
            "ZURICH",
            "NAIROBI",
            "ABU DHABI",
            "AMSTERDAM",
            "NEW DELHI",
            "CALIFORNIA"
        };

        int maxStringPerGroup = 3;
        int currentIndex = 0;
        while (currentIndex < cities.Length)
        {
            List<string> currentGroup = new List<string>();
            for (int i = 0; i < maxStringPerGroup && currentIndex < cities.Length; i++)
            {
                currentGroup.Add(cities[currentIndex]);
                currentIndex++;
            }
            DisplayGroup(currentGroup);
        }


        Console.WriteLine("================================");
        Console.WriteLine("Using linq");

        var groups = cities.Select((city, index) => new
        {
            City = city,
            Index = index,
        })
                            .GroupBy(item => item.Index / maxStringPerGroup)
                            .Select(group => group.Select(item => item.City));

        foreach (var item in groups)
        {
            DisplayGroup(item);
        }


        Console.WriteLine("================================");
        Console.WriteLine("Using Dictionanry  ");

        Dictionary<int, List<string>> cityGroups = new Dictionary<int, List<string>>();
        int groupIndex = 0;

        foreach (string city in cities)
        {
            if (!cityGroups.ContainsKey(groupIndex))
            {
                cityGroups[groupIndex] = new List<string>();
            }

            cityGroups[groupIndex].Add(city);

            if (cityGroups[groupIndex].Count == maxStringPerGroup)
            {
                groupIndex++;
            }
        }

        foreach (var group in cityGroups.Values)
        {
            DisplayGroup(group);
        }
    }


    static void DisplayGroup(IEnumerable<string> group)
    {
        Console.WriteLine("Console.WriteLine(\"-- here is a group of cities --\");");
        Console.WriteLine();
        foreach (string city in group)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine("-- here is a group of cities --");
        Console.WriteLine();
    }
}