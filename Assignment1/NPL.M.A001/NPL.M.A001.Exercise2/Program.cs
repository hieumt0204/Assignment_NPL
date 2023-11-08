namespace NPL.M.A001.Exercise2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber;
            Console.Write("Decimal Number = ");
            decimalNumber = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = ConvertToBinary(decimalNumber);
            Console.WriteLine($"The binary  of {decimalNumber} --> {binaryNumber}");
        }
        static string ConvertToBinary(int decimalNumber)
        {
            int quotient = decimalNumber;
            string binaryNumber = "";

            while (quotient > 0)
            {
                int remainder = quotient % 2;
                quotient /= 2;
                binaryNumber = remainder.ToString() + binaryNumber;
            }
            return binaryNumber;
        }
    }

}
