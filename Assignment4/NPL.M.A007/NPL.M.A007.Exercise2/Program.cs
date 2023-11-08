namespace NPL.M.A007.Exercise2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(100m, 20000d, "red", 25);


            Ford ford1 = new Ford(120m, 25000d, "blue", 2022, 1000);
            Ford ford2 = new Ford(150m, 30000d, "black", 2023, 1500);

            Truck truck1 = new Truck(80m, 15000d, "white", 2500);
            Truck truck2 = new Truck(90m, 18000d, "gray", 1800);


            Console.WriteLine($"The sale price of sedan is {sedan.GetSalePrice():C}");
            Console.WriteLine($"The sale price of ford1 is {ford1.GetSalePrice():C}");
            Console.WriteLine($"The sale price of ford2 is {ford2.GetSalePrice():C}");
            Console.WriteLine($"The sale price of truck1 is {truck1.GetSalePrice():C}");
            Console.WriteLine($"The sale price of truck2 is {truck2.GetSalePrice():C}");
        }
    }
}