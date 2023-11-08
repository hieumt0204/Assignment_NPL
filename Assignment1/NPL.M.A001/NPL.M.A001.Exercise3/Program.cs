namespace NPL.M.A001.Exercise3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n = ");
            } while(!int.TryParse(Console.ReadLine(), out n));
           
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

        }
        static int Fibonacci(int n)
        {
            if(n < 0)
            {
                return -1;
            }

            else if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        //C2
        /// <summary>
        /// chi so cua Fibonacci tinh tu 0
        /// vd f0 = 0; f1 = 1; f2= 1, f3 = 2
        /// return so Fibonacci thu n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fibonacci1(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;

            if(n < 0)
            {
                return -1;
            }
            else if(n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for( i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}