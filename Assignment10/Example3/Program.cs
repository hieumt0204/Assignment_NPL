public class Program
{
    /*
     * Write a program in C# Sharp to find the number of an array and the square of each number.
         :
        { Number = 9, SqrNo = 81 }
        { Number = 8, SqrNo = 64 }
        { Number = 6, SqrNo = 36 }
        { Number = 5, SqrNo = 25 }
     */
    public static void Main(string[] args)
    {
        int[] numbers = new int[] { 9, 8, 6, 5 };

        var result = from num in numbers
                     select new {Number = num, SqrNo = Math.Pow(num,2)};
        foreach(var item in result)
        {
            Console.WriteLine("{0}", item);
        }
       
    }
}