namespace NPL.M.A007.Exercise2_
{
    public class Sedan : Car
    {
        private int length;

        public Sedan(decimal spped, double regularPrice, string color, int length) : base(spped, regularPrice, color)
        {
            this.length = length;
        }

        public override double GetSalePrice()
        {
            if(length > 20)
            {
                return base.GetSalePrice() * 0.95;
            }
            else
            {
                return base.GetSalePrice() * 0.9;
            }
        }
    }
}
