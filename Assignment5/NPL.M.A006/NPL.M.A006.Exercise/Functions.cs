using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A006.Exercise_
{
    public class Functions
    {
        static List<Employee> employees = new List<Employee>();

        public static void ImportEmployee()
        {
            while (true)
            {
                Console.WriteLine("1. Salaried Employee");
                Console.WriteLine("2. Hourly Employee");
                Console.WriteLine("3. Main menu");
                Console.Write("Enter Menu Option: ");
                int employeeTypeChoice = int.Parse(Console.ReadLine());
                switch (employeeTypeChoice)
                {
                    case 1:
                        ImportEmployeeSalaried();
                        break;
                    case 2:
                        ImportEmployeeHorly();
                        break;
                    case 3:
                        return; 

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }


            }




            //Console.WriteLine("Employee imported successfully.");
        }


        public static void ImportEmployeeHorly()
        {
            Console.Write("Enter SSN: ");
            string ssn = Console.ReadLine();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter BirthDate (dd/MM/yyyy): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Wage: ");
            double wage = double.Parse(Console.ReadLine());

            Console.Write("Enter Working Hours: ");
            double workingHours = double.Parse(Console.ReadLine());

            HourlyEmployee hourlyEmployee = new HourlyEmployee(ssn, firstName, lastName, birthDate, phone, email, wage, workingHours);
            employees.Add(hourlyEmployee);
        }
        public static void ImportEmployeeSalaried()
        {
            Console.Write("Enter SSN: ");
            string ssn = Console.ReadLine();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter BirthDate (dd/MM/yyyy): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Commission Rate: ");
            double commissionRate = double.Parse(Console.ReadLine());

            Console.Write("Enter Gross Sales: ");
            double grossSales = double.Parse(Console.ReadLine());

            Console.Write("Enter Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            SalariedEmployee salariedEmployee = new SalariedEmployee(ssn, firstName, lastName, birthDate, phone, email, commissionRate, grossSales, basicSalary);
            employees.Add(salariedEmployee);
        }
        public static void DisplayEmployeeInformation()
        {
            foreach (Employee employee in employees)
            {
                if (employee is SalariedEmployee)
                {
                    SalariedEmployee salariedEmployee = employee as SalariedEmployee;
                    salariedEmployee.Display();
                }
                else if (employee is HourlyEmployee)
                {
                    HourlyEmployee hourlyEmployee = employee as HourlyEmployee;
                    hourlyEmployee.Display();
                }
            }
        }

        public static void SearchEmployee()
        {

            while (true)
            {
                Console.WriteLine("Search Employee:");
                Console.WriteLine("1. By Employee Type");
                Console.WriteLine("2. By Employee Name");
                Console.WriteLine("3. Return to Main Menu");
                Console.Write("Please select an option: ");

                int searchOption = int.Parse(Console.ReadLine());

                switch (searchOption)
                {
                    case 1:
                        SearchByEmployeeType();
                        break;
                    case 2:
                        SearchByEmployeeName();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        public static void SearchByEmployeeType()
        {
            Console.Write("Enter employee type to search (Salaried or Hourly): ");
            string employeeType = Console.ReadLine();

            var searchResults = employees.Where(e => e.GetType().Name == $"{employeeType}Employee").ToList();

            if (searchResults.Count > 0)
            {
                Console.WriteLine("Search results:");
                foreach (var result in searchResults)
                {
                    result.Display();
                }
            }
            else
            {
                Console.WriteLine("No matching employees found.");
            }
        }
        public static void SearchByEmployeeName()
        {
            Console.Write("Enter employee's  name: ");
            string employeeFullName = Console.ReadLine();

            var searchResults = employees.Where(e => (e.LastName) == (employeeFullName)).ToList();

            if (searchResults.Count > 0)
            {
                Console.WriteLine("Search results:");
                foreach (var result in searchResults)
                {
                    result.Display();
                }
            }
            else
            {
                Console.WriteLine("No matching employees found.");
            }
        }

    }
}
