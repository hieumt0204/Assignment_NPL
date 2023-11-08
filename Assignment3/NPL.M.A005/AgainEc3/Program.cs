namespace AgainEc3
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
            Console.WriteLine("Output: ");
            foreach(string name in names)
            {
                Console.WriteLine($"{name}");
            }
            SortName( names );
            Console.WriteLine("Output: ");
            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }


        }
        public static void SortName(string[] names)
        {
            Array.Sort(names, (name1, name2) =>
            {
                string lastNameA = name1.Split(' ').Last();
                string lastNameB = name2.Split(' ').Last();
                return lastNameA.CompareTo(lastNameB);

            });
        }
    }
}