public class Program
{
    /*
     *  Write a program in C# Sharp to remove items from list by creating an object internally by filtering.
        Test Data :
        Here is the list of items :
        Char: m
        Char: n
        Char: o
        Char: p
        Char: q
         :
        Here is the list after removing the item 'p' from the list :
        Char: m
        Char: n
        Char: o
        Char: q
     */
    public static void Main(string[] args)
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
        char itemToRemove = 'p';

        charLists.RemoveAll(item => item == itemToRemove);
        Console.WriteLine("\nHere is the list after removing the item '" + itemToRemove + "' from the list:");
        foreach (char item in charLists)
        {
            Console.WriteLine("Char: " + item);
        }


    }
}