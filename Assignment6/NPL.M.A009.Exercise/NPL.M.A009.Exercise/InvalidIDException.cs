using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class InvalidIDException : Exception
    {
        public InvalidIDException(string message) : base(message) { }
    }
    public class InvalidModelSizeException : Exception
    {
        public InvalidModelSizeException(string message) : base(message)
        {
        }
    }
    public class InvalidPlaneTypeException : Exception
    {
        public InvalidPlaneTypeException(string message) : base(message)
        {
        }
    }
    class InvalidRunwaySizeException : Exception
    {
        public InvalidRunwaySizeException(string message) : base(message)
        {
        }
    }
    class InvalidTakeoffWeightException : Exception
    {
        public InvalidTakeoffWeightException(string message) : base(message)
        {
        }
    }
}
