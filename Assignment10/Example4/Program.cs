using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public class Program
{
    /*
     *  Write a program in C# Sharp to display the number and frequency of a given number from an array.
         :
        The number and the Frequency are :
        Number 5 appears 3 times
        Number 9 appears 2 times
        Number 1 appears 1 times
     */
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 9, 5, 1, 5, 9 };
        Dictionary<int, int> frequence = new Dictionary<int, int>();
        foreach (var number in numbers)
        {
            if (frequence.ContainsKey(number))
            {
                frequence[number]++;
            }
            else
            {
                frequence[number] = 1;
            }
        }
        Console.WriteLine("The number and the Frequency are:");
        foreach (var item in frequence)
        {
            Console.WriteLine("Number " + item.Key + " appears " + item.Value + " times");
        }
    //c2:
        Console.WriteLine("=====================");
        Console.WriteLine("Using linq ");
        var groupByNumbers = numbers
                            .GroupBy(x => x)
                            .Select(number => new
                            {
                                Number = number.Key,
                                Frequence = number.Count()
                            });
        foreach (var item in groupByNumbers)
        {
            
            Console.WriteLine("Number " + item.Number + " appears " + item.Frequence + " times");
        }
    }
}