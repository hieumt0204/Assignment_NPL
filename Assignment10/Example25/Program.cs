using Example25;

public class Program
{
    /*
     * 
     */
    public static void Main(string[] args)
    {
        List<Item> items = new List<Item>()
        {
            new Item { ItemID = 1, ItemName = "Biscuit" },
            new Item { ItemID = 2, ItemName = "Chocolate" },
            new Item { ItemID = 3, ItemName = "Butter" },
            new Item { ItemID = 4, ItemName = "Brade" },
            new Item { ItemID = 5, ItemName = "Honey" }


        };
        List<Purchase> purchases = new List<Purchase>()
        {
            new Purchase { ItemID = 1, PurchaseQuantity = 458 },
            new Purchase { ItemID = 2, PurchaseQuantity = 650 },
            new Purchase { ItemID = 3, PurchaseQuantity = 800 },
            new Purchase { ItemID = 3, PurchaseQuantity = 900 },
            new Purchase { ItemID = 3, PurchaseQuantity = 900 },
            new Purchase { ItemID = 4, PurchaseQuantity = 700 },
            new Purchase { ItemID = 4, PurchaseQuantity = 650 },
        };


        var leftJoinGroup = from item in items
                            join purchase in purchases
                            on item.ItemID equals purchase.ItemID into joinedItems
                            from purchase in joinedItems.DefaultIfEmpty()
                            select new
                            {
                                ItemID = item.ItemID,
                                ItemName = item.ItemName,
                                PurchaseQuality = purchase?.PurchaseQuantity ?? 0
                            }; 

        Console.WriteLine("Item ID\tItem Name\tPurchase Quantity");
        Console.WriteLine("---------------------------------------");
        foreach (var item in leftJoinGroup)
        {
            Console.WriteLine($"{item.ItemID}\t{item.ItemName}\t\t\t{item.PurchaseQuality}\t\t");
        }



    }
}