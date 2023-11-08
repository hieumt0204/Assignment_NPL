using System.Text.RegularExpressions;

namespace NPL.M.A005.Exercise2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                if (IsEmail(email))
                {
                    Console.WriteLine("The email is valid.");
                    break;
                }
                else
                {
                    Console.WriteLine("The email is invalid.Please try again!");
                }
                
            }while (true);
           
        }
        static bool IsEmail(string email)
        {
            // Define the regex pattern for the local part of the email
            string localPartPattern = @"^[a-zA-Z0-9!#$%&'*+-/=?^_{|}~]+(\.[a-zA-Z0-9!#$%&'*+-/=?^_{|}~]+)*$";

            // Define the regex pattern for the domain part of the email
            string domainPartPattern = @"^[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*$";

            //Split email into local part and domain part
            string[] parts = email.Split('@');
            
            //Check if the email has exactly one '@' character

            if(parts.Length != 2)
            {
                return false;
            }

            // Chech if local part and domain part match their respective patterns 
            if (!Regex.IsMatch(parts[0],localPartPattern) || !Regex.IsMatch(parts[1], domainPartPattern))
            {
                return false;
            }

            //check if the top-level domain is not all-numeric 
            string[] domainParts = parts[1].Split('.');
            if (int.TryParse(domainParts[domainParts.Length - 1], out _))
            {
                return false;
            }

            return true;
        }
    }
}