using System.Security.Principal;

public class Program
{
    /*
     *  Write a program in C# Sharp to convert a string array to a string.
        Test Data :
        Input number of strings to store in the array :3
        Input 3 strings for the array :
        Element[0] : cat
        Element[1] : dog
        Element[2] : rat
        :
        Here is the string below created with elements of the above array :
        cat, dog, rat
     */
    static void Main(string[] args)
    {
        Console.Write("Input number of strings to store in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] stringArray = new string[n];           
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element[{i}] : ");
            stringArray[i] = Console.ReadLine();
        }

        string result = string.Join(", ", stringArray);
        Console.WriteLine("Here is the string below created with elements of the above array : ");
        Console.WriteLine(result);
    }
}