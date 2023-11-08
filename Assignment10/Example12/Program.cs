using System.Text.RegularExpressions;

public class Program
{
    /*
     *  Write a program in C# Sharp to find uppercase words in a string.
    Test Data :
    Input the string : this IS a STRING
     :
    The UPPER CASE words are :
    IS
    STRING
     */
    public static void Main(string[] args)
    {
        Console.Write("Input the string : ");
        string inputString = Console.ReadLine();

        string patten = @"\b[A-Z]+\b";
        MatchCollection matchese = Regex.Matches(inputString, patten);

        Console.WriteLine("The UPPER CASE words are:");

        foreach (var math in matchese)
        {
            Console.WriteLine(math);
        }

        //c2
        Console.WriteLine("========================");
        Console.WriteLine("Using linq");


        string[] words = inputString.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        var uppercaseWords = words.Where(word => word.All(char.IsUpper));

        foreach (var word in uppercaseWords)
        {
            Console.WriteLine(word);
        }

    }
}