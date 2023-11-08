using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public abstract class Aircraft
    {
        private string id;
        private string model;
        private double cruiseSpeed;
        private double emptyWeight;
        private double maxTakeoffWeight;


       
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                //check if the ID is a string of 7 characters,started by "FW" for fixed wing airplane,
                //"RW" for helicopter
                //and "AP" for airport, followed by 5 digits.
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
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if(value.Length <= 40)
                {
                    model = value;
                }
                else
                {
                    throw new InvalidModelSizeException("Invalid model size. Model size must be maximum 40 characters.");
                }
            }
        }
        public double CruiseSpeed
        {
            get
            {
                return cruiseSpeed;
            }
            set
            {
                cruiseSpeed = value;
            }
        }
        public double EmptyWeight
        {
            get
            {
                return emptyWeight;
            }
            set
            {
                emptyWeight = value;
            }
        }
        public double MaxTakeoffWeight
        {
            get
            {
                return maxTakeoffWeight;
            }
            set
            {
                maxTakeoffWeight = value;
            }
        }

        public Aircraft() { }
        public Aircraft(string id, string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight)
        {
            id = this.id;
            model = this.model;
            cruiseSpeed = this.cruiseSpeed;
            emptyWeight = this.emptyWeight;
            maxTakeoffWeight = this.maxTakeoffWeight;
        }
        public abstract void Fly();

        public virtual void Display()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Cruise Speed: {cruiseSpeed} km/h");
            Console.WriteLine($"Empty Weight: {emptyWeight} kg");
            Console.WriteLine($"Max Takeoff Weight: {maxTakeoffWeight} kg");
        }

    }
}
