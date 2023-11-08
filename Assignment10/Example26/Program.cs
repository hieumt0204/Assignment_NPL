using Example26;

public class Program
{
    /*
     *  Write a program in C# Sharp to generate a Right Outer Join between two data sets.
         :Here is the list after joining :

        Item ID Item Name Purchase Quantity
        -------------------------------------------------------
        3 Butter 800
        5 Honey 650
        3 Butter 900
        4 Brade 700
        3 Butter 900
        4 Brade 650
        1 Biscuit 458
     */
    public static void Main(string[] args)
    {
        List<Item> listItems = new List<Item>
        {
            new Item { ItemId = 1, ItemName = "Biscuit" },
            new Item { ItemId = 2, ItemName = "Chocolate" },
            new Item { ItemId = 3, ItemName = "Butter" },
            new Item { ItemId = 4, ItemName = "Brade" },
            new Item { ItemId = 5, ItemName = "Honey" }
        };
        List<Purchase> listPurchases = new List<Purchase>
        {
            new Purchase { ItemId = 3, PurchaseQuantity = 800 },
            new Purchase { ItemId = 5, PurchaseQuantity = 650 },
            new Purchase { ItemId = 3, PurchaseQuantity = 900 },
            new Purchase { ItemId = 4, PurchaseQuantity = 700 },
            new Purchase { ItemId = 3, PurchaseQuantity = 900 },
            new Purchase { ItemId = 4, PurchaseQuantity = 650 },
            new Purchase { ItemId = 1, PurchaseQuantity = 458 },
        };
        var rightJoinQuery = from purchase in listPurchases
                             join item in listItems
                             on purchase.ItemId equals item.ItemId into joinedPurchases
                             from item in joinedPurchases.DefaultIfEmpty()
                             select new
                             {
                                 ItemId = item?.ItemId ?? purchase.ItemId,
                                 ItemName = item?.ItemName ?? "Unknow",
                                 ItemPurchaseQuantity = purchase.PurchaseQuantity
                             };
        Console.WriteLine("Item ID\tItem Name\tPurchase Quantity");
        Console.WriteLine("---------------------------------------");
        foreach (var result in rightJoinQuery)
        {
            Console.WriteLine($"{result.ItemId}\t{result.ItemName}\t{result.ItemPurchaseQuantity}");
        }



    }
}