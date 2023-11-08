public class Program
{
    /*
     * Write a program in C# Sharp to generate a cartesian product of three sets.
     :
    The cartesian product are :
    { letter = X, number = 1, colour = Green }
    { letter = X, number = 1, colour = Orange }
    { letter = X, number = 2, colour = Green }
    { letter = X, number = 2, colour = Orange }
    { letter = X, number = 3, colour = Green }
    { letter = X, number = 3, colour = Orange }
    { letter = Y, number = 1, colour = Green }
    { letter = Y, number = 1, colour = Orange }
    . . .
     */
    static void Main(string[] args)
    {
        List<char> letterList = new List<char> { 'X', 'Y' };
        List<int> numberList = new List<int> { 1, 2, 3 };
        List<string> colorList = new List<string> { "Green", "Orange" };

        var result = from letter in letterList
                     from number in numberList
                     from color in colorList
                     select new {Letter = letter, Number = number, Color = color};

        foreach (var item in result.Distinct())
        {
            Console.WriteLine(item);
        }

    }
}