using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class Helicopters : Aircraft
    {
        private double range;

        public double Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }

        public Helicopters(string id, string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, double range)
            : base (id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight)           
        {
            range = this.range;
        }
        public override void Fly()
        {
            Console.WriteLine("Helicopter is flying.");
        }
        public override void Display()
        {
            Console.WriteLine($"Range: {range} km");
        }
    }
}
