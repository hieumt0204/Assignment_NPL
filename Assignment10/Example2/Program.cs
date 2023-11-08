public class Program
{
    /*
    *   Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
        :
        The numbers within the range of 1 to 11 are :
        1 3 6 9 10
    */
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { -2, 1, 5, -3, 6, -4, 9, 10, -11 };
        var positiveNumbersInRange = from num in numbers
                                     where num > 0 && num >= 1 && num <= 11
                                    
                                     select num;

        Console.WriteLine("The positive numbers within the range of 1 to 11 are:");
        foreach (var number in positiveNumbersInRange)
        {
            Console.Write(number + " ");
        }
    }
}