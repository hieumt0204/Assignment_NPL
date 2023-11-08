using FinalAssignment.Data;
using FinalAssignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class PhoneBookManagement
    {
        private IPhoneBookRepository _context = new PhoneBookRepository();
        public void GetAllListPhoneBook()
        {
            Console.WriteLine("Information List Phone Book!");
            Console.WriteLine("=============================");
            foreach (var phoneBook in _context.GetAll() )
            {
                Console.WriteLine($"Id : {phoneBook.Id}, Name: {phoneBook.Name}, PhoneNumber: {phoneBook.PhoneNumber}, Address : {phoneBook.Address}, Email : {phoneBook.Email}, Group: {phoneBook.Group}");
            }
        }

        public void AddNewPhoneBook()
        {
            Console.WriteLine("Add new phone book:");

            Console.Write("Input string name : ");
            string name = Console.ReadLine();

            Console.Write("Input phone number : ");
            string phoneNumber = Console.ReadLine();
            if (!Regex.IsMatch(phoneNumber, @"^0\d{2} \d{3} \d{4}$"))
            {
                Console.WriteLine("Invalid phone number format. Please try again.");
                return;
            }

            Console.Write("Input Email :");
            string email = Console.ReadLine();

            Console.Write("Input Address :");
            string address = Console.ReadLine();

            Console.Write("Input group :");
            string group = Console.ReadLine();
            if (!new List<string> { "Family", "Colleague", "Friend", "Other" }.Contains(group))
            {
                Console.WriteLine("Invalid group. Please try again.");
                return;
            }

            PhoneBook phoneBook = new PhoneBook() { Name = name, PhoneNumber = phoneNumber, Address = address, Email = email, Group = group };
            _context.Add(phoneBook);
            Console.WriteLine("Add new phone book sucessfully!");
        }

        public void DeletePhoneBook()
        {
            Console.WriteLine("Enter name phone book you need delete : ");
            string name = Console.ReadLine();

            _context.Delete(name);
            Console.WriteLine("Delete successfully phone book");

        }

        public void UpdatePhoneBook()
        {
            Console.WriteLine("Update phone book by id");
            int id;
            do
            {
                Console.Write("Enter your id you want to update :");
            }while(!int.TryParse(Console.ReadLine(), out id));
            Console.Write("Input string name : ");
            string name = Console.ReadLine();

            Console.Write("Input phone number : ");
            string phoneNumber = Console.ReadLine();
            if (!Regex.IsMatch(phoneNumber, @"^0\d{2} \d{3} \d{4}$"))
            {
                Console.WriteLine("Invalid phone number format. Please try again.");
                return;
            }

            Console.Write("Input Email :");
            string email = Console.ReadLine();

            Console.Write("Input Address :");
            string address = Console.ReadLine();

            Console.Write("Input group :");
            string group = Console.ReadLine();
            if (!new List<string> { "Family", "Colleague", "Friend", "Other" }.Contains(group))
            {
                Console.WriteLine("Invalid group. Please try again.");
                return;
            }

            PhoneBook phoneBook = new PhoneBook() { Name = name, PhoneNumber = phoneNumber, Address = address, Email = email, Group = group };
            _context.Update(phoneBook, id);
            Console.WriteLine("Update phone book sucessfully !");
        }
        public void SortByName()
        {
            Console.WriteLine("List phone book sort by name: ");
         
            foreach (var phoneBook in _context.Sort())
            {
                Console.WriteLine($"Id : {phoneBook.Id}, Name: {phoneBook.Name}, PhoneNumber: {phoneBook.PhoneNumber}, Address : {phoneBook.Address}, Email : {phoneBook.Email}, Group: {phoneBook.Group}");
            }
        }
        public void FindByName()
        {
            Console.WriteLine("Find Phone Book By Name");
            Console.Write("Enter your string name you want to fi" +
                "nd : ");
            string name = Console.ReadLine();
            foreach (var phoneBook in _context.Find(name))
            {
                Console.WriteLine($"Id : {phoneBook.Id}, Name: {phoneBook.Name}, PhoneNumber: {phoneBook.PhoneNumber}, Address : {phoneBook.Address}, Email : {phoneBook.Email}, Group: {phoneBook.Group}");
            }

        }
    }
}
