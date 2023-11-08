public class Program
{
    /*
     *  Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order.
         :
        Here is the arranged list :
        ROME
        PARIS
        LONDON
        ZURICH
        NAIROBI
        ABU DHABI
        AMSTERDAM
        NEW DELHI
        CALIFORNIA
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

        var sortedCities = cities.OrderBy(x => x.Length) // sort by string length
                                    .ThenBy(x => x). // sort by names in ascending order
                                        ToList();
        Console.WriteLine("Here is the arranged list:");
        foreach (var city in sortedCities)
        {
            Console.WriteLine(city);
        }
    }
}