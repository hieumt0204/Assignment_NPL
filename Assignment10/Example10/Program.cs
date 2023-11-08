public class Program
{
    /*
     *  Write a program in C# Sharp to accept list members through the keyboard and display them more than a specific value.
        Test Data :
        Input the number of members on the List : 5
        Member 0 : 10
        Member 1 : 48
        Member 2 : 52
        Member 3 : 94
        Member 4 : 63
        Input the value above you want to display the members of the List : 59
         :
        The numbers greater than 59 are :
        94
        63
     */
    static void Main(string[] args)
    {
        Console.Write("Input the number of members on the List:");
        int n = int.Parse(Console.ReadLine());


        List<int> memebersList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Member {i} : ");
            int member = Convert.ToInt32(Console.ReadLine());
            memebersList.Add(member);
        }

        Console.Write("Input the value above which you want to display the members of the List: ");
        int threshold = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The number greater than " + threshold + " are:");

        var result = memebersList.Where(x => x > threshold).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }


        //Console.WriteLine("===================================");
        //Console.WriteLine("Using linq");

        //Console.Write("Input the number of members on the List: ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //var membersList = Enumerable.Range(0, n).Select(x =>
        //{
        //    Console.WriteLine($"Member {x} : ");
        //    return Convert.ToInt32(Console.ReadLine()) ;
        //}).ToList();

        //Console.Write("Input the value above which you want to display the members of the List: ");
        //int threshold = Convert.ToInt32(Console.ReadLine());

        //var numberGreateThanThreshold = membersList.Where(number => number > threshold).ToList();
        //Console.WriteLine("The numbers greater than " + threshold + " are:");
        //foreach (int member in numberGreateThanThreshold)
        //{
        //    Console.WriteLine(member);
        //}


    }
}