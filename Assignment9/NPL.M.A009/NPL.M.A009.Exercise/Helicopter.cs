using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class Helicopter : Airphane
    {
        public int Range { get; set; }
        public Helicopter() { }
        public Helicopter(string id, string model, int cruiseSpeed, int emptyWeight, int maxTakeoffWeight, string minNeeded, int runWaySize, int range) 
            : base (id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight)
        {
            if(maxTakeoffWeight > 1.5 * emptyWeight)
            {
                throw new ArgumentException("Max takeoff weight of the helicopter exceeds 1.5 times its empty weight");
            }
            Range = range;

        }
        public override void Fly()
        {
            Console.WriteLine("Flying a helicopter.");
        }
    }
}
