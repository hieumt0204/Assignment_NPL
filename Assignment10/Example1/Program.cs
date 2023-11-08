public class Program
{
    public static void Main(string[] args)
    {
     /*
     *  Write a program in C# Sharp to show how the three parts of a query operation execute.
        The numbers which produce the remainder 0 after divided by 2 are :
        0 2 4 6 8
     */
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = from num in numbers
                     where num % 2 == 0
                     select num;
        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");
        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
        Console.ReadKey();
    }
}