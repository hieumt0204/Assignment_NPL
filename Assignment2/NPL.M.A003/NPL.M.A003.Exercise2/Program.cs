using System.Globalization;

namespace NPL.M.A003.Exercise2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter log records (each line should start with a timestamp and end with 'by <Name>'):");

            List<string> logRecords = new List<string>();
            string inputLine;

            while (!string.IsNullOrWhiteSpace(inputLine = Console.ReadLine()))
            {
                logRecords.Add(inputLine);
            }

            if (logRecords.Count > 0)
            {
                List<string> sortedRecords = SortLogRecords(logRecords);
                PrintSortedRecords(sortedRecords);
            }
            else
            {
                Console.WriteLine("No log records were provided.");
            }
        }
        static List<string> SortLogRecords(List<string> logRecords)
        {

            List<string> sortedRecords = logRecords.OrderBy(ParseTimestamp).ToList();
            return sortedRecords;
        }

        static DateTime ParseTimestamp(string record)
        {
            string[] sortedRecord;

            

          
            return DateTime.MinValue;
        }
        static DateTime ParseDate(string record)
        {
            string[] parts = record.Split(new[] { "by" }, StringSplitOptions.None);
            if (parts.Length == 2)
            {
                string timestampPart = parts[0].Trim();
                DateTime date;

                if (DateTime.TryParseExact(timestampPart, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) ||
                    DateTime.TryParseExact(timestampPart, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) ||
                    DateTime.TryParseExact(timestampPart, "dd/MMM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    return date.Date; // Extract only the date portion
                }
            }

            // If the date cannot be parsed, return DateTime.MinValue
            return DateTime.MinValue;
        }

        static void PrintSortedRecords(List<string> sortedRecords)
        {
            Console.WriteLine("Sorted log records:");
            foreach (string record in sortedRecords)
            {
                Console.WriteLine(record);
            }
        }
    }
}


