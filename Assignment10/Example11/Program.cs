public class Program
{
    /*
     * Write a program in C# Sharp to display the top n-th records.
        Test Data :
        The members of the list are :
        5
        7
        13
        24
        6
        9
        8
        7
        How many records you want to display ? : 3
         :
        The top 3 records from the list are :
        24
        13
        9
     */
    private static void Main(string[] args)
    {
        List<int> membersList = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };

        Console.Write("How many records you want to display ?: ");
        int n = Convert.ToInt32(Console.ReadLine());

        var result = membersList.OrderByDescending(x => x).Take(n).ToList();
        foreach(var number in result)
        {
            Console.WriteLine(number);
        }


    }
}