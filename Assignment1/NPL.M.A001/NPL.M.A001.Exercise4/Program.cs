namespace NPL.M.A001.Exercise4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number ;
            Console.Write("Number = ");
            number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = CheckPrimeNumber(number);
            if(isPrime)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a prime number");
            }
        }
        static bool CheckPrimeNumber(int number) 
        { 
            if(number <= 1)
            {
                return false;
            }
            else if(number == 2)
            {
                return true;
            }
            else if(number % 2 == 0)
            {
                return false;
            }
            else
            {
                for(int i = 3; i * i < number; i += 2)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                   
                }
            }
            return true;
        }
    }
}