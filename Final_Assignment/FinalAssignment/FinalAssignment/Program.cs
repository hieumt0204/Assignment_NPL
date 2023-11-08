using System;

namespace FinalAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBookManagement phoneBookManagement = new PhoneBookManagement();

            do
            {
                Console.WriteLine("MANAGEMENT PHONE BOOK");
                Console.WriteLine("1. LIST PHONE BOOK");
                Console.WriteLine("2. ADD NEW PHONE BOOK");
                Console.WriteLine("3. UPDATE PHONE BOOK");
                Console.WriteLine("4. DELETE PHONE BOOK");
                Console.WriteLine("5. SORT PHONE BOOK");
                Console.WriteLine("6. FIND PHONE BOOK");
                Console.WriteLine("7. EXIT");

                int choice;

                do
                {
                    Console.Write("Enter your choice : ");
                }while(!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                        phoneBookManagement.GetAllListPhoneBook();
                        break;
                    case 2:
                        phoneBookManagement.AddNewPhoneBook();
                        break;
                    case 3:
                        phoneBookManagement.UpdatePhoneBook();
                        break;
                    case 4:
                        phoneBookManagement.DeletePhoneBook();
                        break;
                    case 5:
                        phoneBookManagement.SortByName();
                        break;
                    case 6:
                        phoneBookManagement.FindByName();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
