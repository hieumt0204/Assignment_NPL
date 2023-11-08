using System.Runtime.CompilerServices;

public class Program
{
    /*
     * Write a program in C# Sharp to find the strings for a specific minimum length.
        Test Data :
        Input number of strings to store in the array :4
        Input 4 strings for the array:
        Element[0] : this
        Element[1] : is
        Element[2] : a
        Element[3] : string
        Input the minimum length of the item you want to find : 5
        :
        The items of minimum 5 characters are :
        Item: string
     */
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        Console.Write("Input number of strings to store the array : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Input {number} for the array: ");
        for(int i = 0; i < number; i++) {
            Console.Write($"Element:[{i}]:");
            string inputString = Console.ReadLine();
            list.Add(inputString);
        }


        Console.Write("Input the minimum length of the item you want to find :");
        int minLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe items of minimum " + minLength + " characters are:");

        foreach (var item in list)
        {
            if(item.Length > minLength)
            {
                Console.WriteLine("Item :" + item);
            }
        }

        Console.WriteLine("==========================");
        Console.WriteLine("using linq");
        var result = list.Where(item => item.Length > minLength).ToList();
        foreach (var item in result)
        {
            Console.WriteLine("Item :" + item);
        }

    }
}