using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A007.Exercise2_
{
    public class Ford : Car
    {
        private int year;
        private int manufacturerDiscount;

        public Ford(decimal spped, double regularPrice, string color, int year, int manufacturerDiscount) : base(spped, regularPrice, color)
        {
            this.year = year;
            this.manufacturerDiscount = manufacturerDiscount;
        }
        public override double GetSalePrice()
        {
            return base.GetSalePrice() - manufacturerDiscount;
        }

    }
}
