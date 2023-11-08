using System;

namespace MyApp 
{
    /*
     *  Write a program in C# Sharp to find a string that starts and ends with a specific character.
        Test Data :
        The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
        Input starting character for the string : A
        Input ending character for the string : M
         :
        The city starting with A and ending with M is : AMSTERDAM
     */
    public class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write("Input starting character for the string :");
            char startChar = Console.ReadLine()[0];
            Console.Write("Input ending character for the string: ");
            char endChar = Console.ReadLine()[0];

            var matchedCity = cities.FirstOrDefault(city =>
                city.ToUpper().StartsWith(startChar.ToString().ToUpper()) && city.ToUpper().EndsWith(endChar.ToString().ToUpper())
            );
            if(matchedCity != null )
            {
                Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is : {matchedCity}");
            }
            else
            {
                Console.WriteLine($"No city matches the criteria.");
            }
        
        }
    }
}