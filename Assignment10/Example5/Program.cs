public class Program
{
    /*
     * Write a program in C# Sharp to display the characters and frequency of each character in a given string.
        Test Data:
        Input the string: apple
        :
        The frequency of the characters are :
        Character a: 1 times
        Character p: 2 times
        Character l: 1 times
        Character e: 1 times
     */
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the string : ");
        string inputString = Console.ReadLine();

        Dictionary<char, int> characterFrequence = new Dictionary<char, int>();

        foreach(var character in inputString)
        {
            if (characterFrequence.ContainsKey(character))
            {
                characterFrequence[character]++;
            }
            else
            {
                characterFrequence[character] = 1;
            }
        }
        Console.WriteLine("The frequency of the characters are:");
        foreach(var item in  characterFrequence)
        {
            Console.WriteLine($"Character: {item.Key} : {item.Value} times");
        }

        //c2:
        Console.WriteLine("====================");
        Console.WriteLine("Using linq");
        var tansoxuathien = inputString
                            .GroupBy(x => x)
                            .Select(group => new
                            {
                                Character = group.Key,
                                Frequency = group.Count()
                            });
                            
        foreach(var item in tansoxuathien)
        {
           
            Console.WriteLine($"Character {item.Character} : {item.Frequency} times");
        }
           
    }
}