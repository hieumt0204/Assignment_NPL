using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    public class FactorialCalculator
    {
        public int CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Input must be a non-negative integer.");
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
