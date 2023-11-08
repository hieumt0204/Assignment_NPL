using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public class Airports
    {
        private string id;
        private string name;
        private double runwaySize;
        private int maxFixedWingParkingPlace;
        private List<string> listOfFixedWingID;
        private int maxRotatedWingParkingPlace;
        private List<string> listOfHelicopterID;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(FW|RW|AP)\d{5}$"))
                {
                    id = value;
                }
                else
                {
                    throw new InvalidIDException("Invalid ID. ID must be a string of 7 characters, started by “FW” for fixed wing airplane, “RW” for helicopter and “AP” for airport, followed by 5 digits.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double RunwaySize
        {
            get { return runwaySize; }
            set { runwaySize = value; }
        }

        public int MaxFixedWingParkingPlace
        {
            get { return maxFixedWingParkingPlace; }
            set { maxFixedWingParkingPlace = value; }
        }

        public List<string> ListOfFixedWingID
        {
            get { return listOfFixedWingID; }
            set { listOfFixedWingID = value; }
        }

        public int MaxRotatedWingParkingPlace
        {
            get { return maxRotatedWingParkingPlace; }
            set { maxRotatedWingParkingPlace = value; }
        }

        public List<string> ListOfHelicopterID
        {
            get { return listOfHelicopterID; }
            set { listOfHelicopterID = value; }
        }


        public Airports(string id, string name, double runwaySize, int maxFixedWingParkingPlace, int maxRotatedWingParkingPlace)
        {
            id = this.id;
            name = this.name;
            runwaySize = this.runwaySize;
            maxFixedWingParkingPlace = this.maxFixedWingParkingPlace;
            listOfFixedWingID = new List<string>();
            maxRotatedWingParkingPlace = this.maxRotatedWingParkingPlace;
            listOfFixedWingID = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Runway Size: {RunwaySize} m");
            Console.WriteLine($"Max Fixed Wing Parking Place: {MaxFixedWingParkingPlace}");
            Console.WriteLine($"List Of Fixed Wing ID: {(ListOfFixedWingID.Count > 0 ? string.Join(", ", ListOfFixedWingID) : "None")}");
            Console.WriteLine($"Max Rotated Wing Parking Place: {MaxRotatedWingParkingPlace}");
            Console.WriteLine($"List Of Helicopter ID: {(ListOfHelicopterID.Count > 0 ? string.Join(", ", ListOfHelicopterID) : "None")}");
        }

    }
}
