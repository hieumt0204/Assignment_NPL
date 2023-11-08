using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A007.Exercise2_
{
    public class Truck : Car
    {
        private int weight;

        public Truck(decimal spped, double regularPrice, string color, int weight) : base(spped, regularPrice, color)
        {
            this.weight = weight;
        }

        public override double GetSalePrice()
        {
            if(weight > 2000)
            {
                return base.GetSalePrice()  * 0.9;
            }
            else
            {
                return base.GetSalePrice() * 0.8;
            }
        }
    }
}
