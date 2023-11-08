public class Program
{
    /*
     *  Write a program in C# Sharp to display the name of the days of the week.
        :
        Sunday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
     */
    public static void Main(string[] args)
    {
        string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        var dayNames = daysOfWeek.Select(x => x.ToString());

        Console.WriteLine("The days of the week are:");
        foreach (var day in dayNames)
        {
            Console.WriteLine(day);
        }

        //c2:
        Console.WriteLine("-------------------------");
        Console.WriteLine("Using Dictionanry");
        Dictionary<int, string > dayOfWeekDistionary = new Dictionary<int, string>()
        {
            { 0, "Sunday" },
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" }
        };
        var dayofName = from day in dayOfWeekDistionary
                        select day.Value;
        Console.WriteLine("The day of week are: ");
        foreach(var item in dayofName)
        {
            Console.WriteLine(item);
        }
    }
}