namespace NPL.M.A005.Exercise3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {   "Tony Stark",
                                "Steve Rogers",
                                "Bruce Banner",
                                "Thor",
                                "Natasha Romanoff",
                                "Clint Barton",
                                "James Rhodes",
                                "Scott Lang",
                                "Doctor Strange",
                                "Carol Danvers",
                                "Peter Parker"
                             };
            Console.WriteLine("Input:");
            foreach (var item in names)
            {
                Console.WriteLine($"{item}");
            }
            

            Console.WriteLine("Output:");
            SortName(names);

            foreach (var item in names)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Output1:");
            string[] sortNames = SortName1(names.ToArray());

            foreach (var item in names)
            {
                Console.WriteLine($"{item}");
            }
       

            Console.ReadKey();

        }
        public static void SortName(string[] names)
        {
            Array.Sort(names, (x, y) =>
            {
                string lastNameX = x.Split(' ').Last();
                string lastNameY = y.Split(' ').Last();
                return lastNameX.CompareTo(lastNameY);
            });
        }

        //C2
        static string[] SortName1(string[] names)
        {
            return names.OrderBy(x =>
            {
                string[] parts = x.Split(' ');
                return parts[parts.Length - 1];
            }).ToArray();
        }
    }
}