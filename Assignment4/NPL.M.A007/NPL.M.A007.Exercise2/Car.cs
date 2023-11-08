namespace NPL.M.A007.Exercise2_
{
    public class Car
    {
        //Three instance variable 
        protected decimal speed;
        protected double regularPrice;
        protected string color;

        public Car(decimal spped, double regularPrice, string color)
        {
            this.speed = spped;
            this.regularPrice = regularPrice;
            this.color = color;
        }
        public virtual double GetSalePrice()
        {
            return regularPrice;
        }




    }
}
