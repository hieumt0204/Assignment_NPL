using Example24;

public class Program
{
    /*
     *  Write a program in C# Sharp to generate an Inner Join between two data sets.
     :Item ID Item Name Purchase Quantity
    -------------------------------------------------------
    1 Biscuit 458
    2 Chocolate 650
    3 Butter 800
    3 Butter 900
    3 Butter 900
    4 Brade 700
    4 Brade 650

     */
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>
        {
            new Item { ItemID = 1, ItemName = "Biscuit", PurchaseQuantity = 458 },
            new Item { ItemID = 2, ItemName = "Chocolate", PurchaseQuantity = 650 },
            new Item { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 800 },
            new Item { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            new Item { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            new Item { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 700 },
            new Item { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 650 }
        };

        List<Stock> stock = new List<Stock>
        {
            new Stock { ItemID = 1, StockQuantity = 1000 },
            new Stock { ItemID = 2, StockQuantity = 800 },
            new Stock { ItemID = 3, StockQuantity = 1500 },
            new Stock { ItemID = 4, StockQuantity = 1300 }
        };

        var innerJoin = from item in items
                        join s in stock on item.ItemID equals s.ItemID
                        select new
                        {
                            ItemID = item.ItemID,
                            ItemName = item.ItemName,
                            PurchaseQuantity = item.PurchaseQuantity,
                            StockQuatity = s.StockQuantity
                        };
        Console.WriteLine("Item ID\tItem Name\tPurchase Quantity\tStock Quantity");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var result in innerJoin)
        {
            Console.WriteLine($"{result.ItemID}            {result.ItemName}             \t{result.PurchaseQuantity}       \t{result.StockQuatity}");
        }


    }
}