using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class FixedWingAirplane : Airphane
    {
        public string MinNeeded  { get; set; }
        public int  RunwaySize{ get; set; }

        public FixedWingAirplane() { }
        public FixedWingAirplane(string id, string model, int cruiseSpeed, int emptyWeight, int maxTakeoffWeight, string minNeeded, int runWaySize)
            : base (id,model, cruiseSpeed, emptyWeight, maxTakeoffWeight)
        {
            MinNeeded = minNeeded;
            RunwaySize = runWaySize;
        }
        public override void Fly()
        {
            Console.WriteLine("Flying a fixed wing airplane.");
        }
    }
}
