using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class Airport
    {
        public string ID { get; }
        public string Name { get; }
        public int RunwaySize { get; }
        public int MaxFixedWingParkingPlace { get; }
        public List<string> FixedWingAirplaneIDs { }
        public int MaxRotatedWingParkingPlace { get; }
        public List<string> HelicopterIDs { }

        public Airport(string id, string name, int runwaySize, int maxFixedWingParkingPlace, List<string> fixedWingAirplaneIDs, int maxRotatedWingParkingPlace, List<string> helicopterIDs)
        {
            // Enforce ID rule
            if (!IsValidID(id))
                throw new ArgumentException("Invalid ID format");

            ID = id;
            Name = name;
            RunwaySize = runwaySize;
            MaxFixedWingParkingPlace = maxFixedWingParkingPlace;
            FixedWingAirplaneIDs = fixedWingAirplaneIDs;
            MaxRotatedWingParkingPlace = maxRotatedWingParkingPlace;
            HelicopterIDs = helicopterIDs;
        }

        // Helper method to check the ID format
        private bool IsValidID(string id)
        {
            if (id.Length != 7)
                return false;

            if (id.StartsWith("AP") && id.Substring(2).All(char.IsDigit))
                return true;

            return false;
        }
    }
}
