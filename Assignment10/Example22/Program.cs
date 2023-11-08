public class Program
{
    /*
     * Write a program in C# Sharp to generate a cartesian product of two sets.
    :
    The cartesian product are :
    { letterList = X, numberList = 1 }
    { letterList = X, numberList = 2 }
    { letterList = X, numberList = 3 }
    { letterList = X, numberList = 4 }
    . . .
     */
    static void Main(string[] args)
    {
        char[] letterList = { 'X', 'Y', 'Z' };
        int[] numberList = { 1, 2, 3, 4 };

        var result = from letter in letterList
                     from number in numberList
                     select new { letterList = letter, numberList = number };

        Console.WriteLine("The cartesian product are:");
        foreach (var item in result)
        {
            Console.WriteLine($" letterList = {item.letterList} , numberList = {item.numberList} ");
        }
        Console.WriteLine("The cartesian product are :");
        
    }
}