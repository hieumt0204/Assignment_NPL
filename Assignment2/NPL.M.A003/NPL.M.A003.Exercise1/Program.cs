using System.Runtime.Intrinsics.Arm;

namespace NPL.M.A003.Exercise1_
{
    internal class Program
    {
        static DateTime GetNextWorkingDay(DateTime currentDate)
        {
            do
            {
                currentDate = currentDate.AddDays(1);
            } while (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday);
            return currentDate;
        }

        static string GetOrdinalSuffix(int number)
        {
            if (number % 10 == 1 && number % 100 != 11)
                return "st";
            if (number % 10 == 2 && number % 100 != 12)
                return "nd";
            if (number % 10 == 3 && number % 100 != 13)
                return "rd";
            return "th";
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a date in the format 'dd/mm/yyyy':");
                string inputDateStr = Console.ReadLine();
                if (DateTime.TryParseExact(inputDateStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime inputDate))
                {

                    DateTime currentDate = inputDate;

                    for (int i = 1; i <= 5; i++)
                    {
                        currentDate = GetNextWorkingDay(currentDate);

                        if (i == 1)
                        {
                            currentDate = currentDate.AddDays(6); // First reminder after 7 working days
                        }
                        else if (i == 2)
                        {
                            currentDate = currentDate.AddDays(1); // Second reminder after 2 working days
                        }
                        else
                        {
                            currentDate = currentDate.AddDays(0); // Subsequent reminders every 1 working days
                        }

                        string ordinalSuffix = GetOrdinalSuffix(i);
                        Console.WriteLine($"{i}{ordinalSuffix} reminder: {currentDate:dd/MM/yyyy}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date in the format 'dd/mm/yyyy'.");
                }

            } while (true);

        }
    }
}
