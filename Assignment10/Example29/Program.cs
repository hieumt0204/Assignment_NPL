public class Program
{
    static void Main(string[] args)
    {
        /*
         * Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.
             :
            Biscuit
            Brade
            Butter
            Honey
         */
        List<string> items = new List<string>
        {
            "Butter", "Honey", "Biscuit", "Brade", "Butter"
        };

        var distinctSortItem = items.Distinct().OrderBy(x => x).ToList();

        foreach (var item in distinctSortItem)
        {
            Console.WriteLine(item);
        }
    }
}