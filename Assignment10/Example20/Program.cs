public class Program
{
    /*
     * Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove.
    Test Data :
    Here is the list of items :
    Char: m
    Char: n
    Char: o
    Char: p
    Char: q
    :
    Here is the list after removing the three items starting from the item index 1 from the list :
    Char: m
    Char: q
     */
    static void Main(string[] args)
    {
        List<char> charLists = new List<char>
        {
            'm', 'n', 'o', 'p', 'q'
        };
        Console.WriteLine("Here is the list of items : ");
        foreach (var item in charLists)
        {
            Console.WriteLine($"Char :{item}");
        }

        int startIndex = 1;
        int countIndexRemove = 3;

        if (startIndex >= 0 && startIndex < charLists.Count && countIndexRemove > 0 && startIndex + countIndexRemove < charLists.Count())
        {
            charLists.RemoveRange(startIndex, countIndexRemove);

            Console.WriteLine("\nHere is the list after removing the " + countIndexRemove + " items starting from the item index " + startIndex + " from the list:");
            foreach (char item in charLists)
            {
                Console.WriteLine("Char: " + item);
            }
        }
        else
        {
            Console.WriteLine("\nThe specified range is invalid or out of range.");
        }
       
    }

}