using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class Fixedwings : Aircraft
    {
        private string planeType;
        private double minNeededRunwaySize;

        public string RunwaySize
        {
            get
            {
                return planeType;
            }
            set
            {
                if(value == "CAG" || value == "LGR" || value == "PRV")
                {
                    planeType = value;
                }
                else
                {
                    throw new InvalidPlaneTypeException("Invalid plane type. Plane type must be one of CAG (Cargo), LGR (Long range) and PRV (Private).");
                }
            }
        }
        public double MinNeededRunwaySize
        {
            get
            {
                return minNeededRunwaySize;
            }
            set
            {
                minNeededRunwaySize = value;
            }
        }
        public Fixedwings(string id, string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, string runwaySize, double MinNeededRunwaySize)
            : base (id,model, cruiseSpeed, emptyWeight, maxTakeoffWeight)
        {
            planeType = this.planeType;
            minNeededRunwaySize = this.minNeededRunwaySize;
        }


        public override void Fly()
        {
            Console.WriteLine("Fixed wing airplane is flying.");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Plane Type: {planeType}");
            Console.WriteLine($"Min Needed Runway Size: {minNeededRunwaySize} m");
        }

    }
}
