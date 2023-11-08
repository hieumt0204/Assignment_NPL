public class Program
{
    /*
     *  Write a program in C# Sharp to remove items from list using remove function by passing the object.
        Test Data :
        Here is the list of items :
        Char: m
        Char: n
        Char: o
        Char: p
        Char: q
        :
        Here is the list after removing the item 'o' from the list :
        Char: m
        Char: n
        Char: p
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

        char itemRemove = 'o';

        if (charLists.Contains(itemRemove))
        {
            charLists.Remove(itemRemove);
            Console.WriteLine("\nHere is the list after removing the item "+ itemRemove + " from the list:");
            foreach (var item in charLists)
            {
                Console.WriteLine("Char:" + item);
            }
        }
        else
        {
            Console.WriteLine("\nThe item " + itemRemove + "was not found ");
        }
    }
}