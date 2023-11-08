namespace NPL.M.A001.Exercise1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.0;
            double y = EvaluatePolynomial(x);

            Console.WriteLine($"At x = {x} , y = {y}");
            Console.ReadKey();

        }
        static double EvaluatePolynomial(double x)
        {
            double y = 2 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2 * x - 1;
            return y;
        }
    }
}