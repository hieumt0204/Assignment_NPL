public class Program
{
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

        int indexToRemove = 3;


        if(indexToRemove >= 0 &&  indexToRemove < charLists.Count)
        {
            charLists.RemoveAt(indexToRemove);
            Console.WriteLine("\nHere is the list after removing item index " + indexToRemove + " from the list:");
            for (int i = 0; i < charLists.Count; i++)
            {
                Console.WriteLine("Char: " + charLists[i]);
            }
        }
        else
        {
            Console.WriteLine("\nThe specified index is out of range.");
        }
    }
}