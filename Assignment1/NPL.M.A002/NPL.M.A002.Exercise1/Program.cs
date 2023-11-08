namespace NPL.M.A002.Exercise1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 25, -10, 6, 4 };

            int maximum = FindMaxinnum(numbers);
            int minimum = FindMinimum(numbers);

            Console.WriteLine($"Maximum is: {maximum}");
            Console.WriteLine($"Minimum is: {minimum}");

            Console.WriteLine($"Maximum is : {numbers.Max()}");
            Console.WriteLine($"Minximum is : {numbers.Min()}");

        }
        static int FindMaxinnum(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                Console.WriteLine("The array cannot be empty");
            }
            int maximum = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }
            return maximum;
        }
        static int FindMinimum(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("The array cannot be empty");
            }
            int minximum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minximum)
                {
                    minximum = numbers[i];
                }
            }
            return minximum;
        }
    }
}