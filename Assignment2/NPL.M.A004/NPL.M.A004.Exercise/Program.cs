namespace NPL.M.A004.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            do
            {
                Console.WriteLine("Enter a date in one of the following formats:");
                Console.WriteLine("1. MM/dd/yyyy");
                Console.WriteLine("2. MM/dd/yyyy hh:mm:ss");
                Console.WriteLine("3. M/d/yyyy h:mm:ss");
                Console.WriteLine("4. M/d/yyyy hh:mm tt");
                Console.WriteLine("5. M/d/yyyy hh tt");
                Console.WriteLine("6. M/d/yyyy h:mm");
                Console.Write("Enter date: ");
                string[] formatDate = {"MM/dd/yyyy", 
                                        "MM / dd / yyyy hh:mm: ss", 
                                        "M/d/yyyy h:mm:ss", 
                                        "M/d/yyyy hh:mm tt",    
                                        "M/d/yyyy hh tt",
                                         "M/d/yyyy h:mm"   };
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out DateTime date) && DateTime.TryParseExact(input, formatDate, null, System.Globalization.DateTimeStyles.None, out DateTime inputDate))
                {
                    Console.WriteLine($"Parsed DateTime: {date}");
                    Console.WriteLine($"Last day of the month: {GetLastDayOfMonth(date)}");
                    Console.WriteLine($"Number of working days: {CountWorkingDays(date)}");
                    break;

                }
              
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }
            } while (true);
            Console.ReadKey();
            
        }

        static DateTime GetLastDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        static int CountWorkingDays(DateTime date)
        {
            int workingDays = 0;
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDate = new DateTime(date.Year, date.Month, day);
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}
