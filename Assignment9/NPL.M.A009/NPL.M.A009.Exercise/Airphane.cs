using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A009.Exercise_
{
    public abstract class Airphane
    {
        public string ID { get;  }
        public string Model { get;  }
        public int CruiseSpeed { get; }
        public int EmptyWeight {  get; }
        public int MaxTakeoffWeight {  get; }

        public Airphane() { }
        public Airphane(string id, string model, int cruiseSpeed, int emptyWeight, int maxTakeoffWeight)
        {
            if(!(IsValidId(id)))
            {
                throw new ArgumentException("Invalid ID format");
            }
            ID = id;
            if(model.Length > 40)
            {
                throw new ArgumentException("Model exceeds the maximum length of 40 characters");
            }
            Model = model;
            CruiseSpeed = cruiseSpeed;
            EmptyWeight = emptyWeight;
            MaxTakeoffWeight = maxTakeoffWeight;
        }
        public bool IsValidId(string id)
        {
            if(id.Length != 7)
            {
                return false;
            }
            if((id.StartsWith("FW") || id.StartsWith("RW") || id.StartsWith("AP"))){
                return true;
            }
            return false;
        }
        public abstract void Fly();
    }
}
