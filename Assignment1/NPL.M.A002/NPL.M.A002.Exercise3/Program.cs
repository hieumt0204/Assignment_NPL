namespace NPL.M.A002.Exercise3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 18, 24,32, 64 };

            // Find the GCD of the array
            int gcd = FindGcd(numbers);

            // Display the result
            Console.WriteLine($"Greatest common divisor of [{string.Join(", ", numbers)}] is {gcd}");
        }
        public static int FindGcd(int[] arr)
        {
            int result = arr[0];
            for(int i = 0; i < arr.Length; i++) 
            {
                result  = Gcd(result, arr[i]);
                if(result == 1)
                {
                    return 1;
                }
            }
            return result;
        }

        private static int  Gcd(int a, int b)
        {
            if( a == 0)
            {
                return b;
            }
            return Gcd(b % a, a);
        }
    }
}