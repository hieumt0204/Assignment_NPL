public class Program
{
    /* Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
        Test Data :
        The numbers in the array are :
        5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
         :
        Number Number*Frequency Frequency
        ------------------------------------------------
        5 15 3
        1 1 1
        9 9 1
        2 4 2
        . . . . . . . .
     */
    public static void Main(string[] args)
    {

        int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        var groupByNumber = numbers.GroupBy(x => x)
                                   .Select(number => new
                                   {
                                       Number = number.Key,
                                       Frequency = number.Count(),
                                       Product = number.Key * number.Count()
                                   });

        Console.WriteLine("Number || Number*Frequency ||  Frequency");
        foreach(var item in groupByNumber)
        {
            Console.WriteLine($"{item.Number} {item.Product} {item.Frequency}");
        }

        //C2:
        Console.WriteLine("===================================");
        Console.WriteLine("Using Dictionary ");
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        foreach (var number in numbers)
        {
            if (frequency.ContainsKey(number))
            {
                frequency[number]++;
            }
            else
            {
                frequency[number] = 1;
            }
        }
        Console.WriteLine("Number || Number*Frequency ||  Frequency");
        foreach(var item in frequency)
        {
            Console.WriteLine($"{item.Key} {item.Key * item.Value} {item.Value}");
        }

    }
}