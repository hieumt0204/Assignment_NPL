using System.ComponentModel;

namespace NPL.M.A002.Exercise2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input two numbers
            int num1 = 12;
            int num2 = 8;

            // Find the GCD
            int gcd = FindGCD(num1, num2);
            int gcd1 = GCD(num1, num2);
            // Display the result
            Console.WriteLine($"Greatest common divisor of {num1} and {num2} is {gcd}");
            Console.WriteLine($"Greatest common divisor of {num1} and {num2} is {gcd1}");
        }
        static int FindGCD( int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            while(num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
        private static int GCD(int a, int b)
        {
            if ( a == 0 )
            {
                return b;
            }
            return GCD(b % a, a);
        }
    }
}