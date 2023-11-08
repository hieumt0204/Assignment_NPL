using NPL.M.A006.Exercise_;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    //static List<Employee> employees = new List<Employee>();

    public static void Main(string[] args)
    {
        Console.WriteLine("=========== Assignment 06 - Employee Management ===========");
        Functions functions = new Functions();
        while (true)
        {
            Console.WriteLine("1. Import Employee");
            Console.WriteLine("2. Display Employee Information");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Exit");
            Console.Write("Please select the admin area you require: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    break;
                case 2:
                    functions.DisplayEmployeeInformation();
                    break;
                case 3:
                    SearchEmployee();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    //static void ImportEmployee()
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("1. Salaried Employee");
    //        Console.WriteLine("2. Hourly Employee");
    //        Console.WriteLine("3. Main menu");
    //        Console.Write("Enter Menu Option: ");
    //        int employeeTypeChoice = int.Parse(Console.ReadLine());
    //        switch (employeeTypeChoice)
    //        {
    //            case 1:
    //                ImportEmployeeSalaried();
    //                break;
    //            case 2:
    //                ImportEmployeeHorly();
    //                break;
    //            case 3:
    //                return; // Return to the main menu
    //            default:
    //                Console.WriteLine("Invalid option. Please try again.");
    //                break;
    //        }


    //    }




    //    //Console.WriteLine("Employee imported successfully.");
    //}


    //static void ImportEmployeeHorly()
    //{
    //    Console.Write("Enter SSN: ");
    //    string ssn = Console.ReadLine();

    //    Console.Write("Enter First Name: ");
    //    string firstName = Console.ReadLine();

    //    Console.Write("Enter Last Name: ");
    //    string lastName = Console.ReadLine();

    //    Console.Write("Enter BirthDate (dd/MM/yyyy): ");
    //    DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

    //    Console.Write("Enter Phone: ");
    //    string phone = Console.ReadLine();

    //    Console.Write("Enter Email: ");
    //    string email = Console.ReadLine();

    //    Console.Write("Enter Wage: ");
    //    double wage = double.Parse(Console.ReadLine());

    //    Console.Write("Enter Working Hours: ");
    //    double workingHours = double.Parse(Console.ReadLine());

    //    HourlyEmployee hourlyEmployee = new HourlyEmployee(ssn, firstName, lastName, birthDate, phone, email, wage, workingHours);
    //    employees.Add(hourlyEmployee);
    //}
    //static void ImportEmployeeSalaried()
    //{
    //    Console.Write("Enter SSN: ");
    //    string ssn = Console.ReadLine();

    //    Console.Write("Enter First Name: ");
    //    string firstName = Console.ReadLine();

    //    Console.Write("Enter Last Name: ");
    //    string lastName = Console.ReadLine();

    //    Console.Write("Enter BirthDate (dd/MM/yyyy): ");
    //    DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

    //    Console.Write("Enter Phone: ");
    //    string phone = Console.ReadLine();

    //    Console.Write("Enter Email: ");
    //    string email = Console.ReadLine();
    //    Console.Write("Enter Commission Rate: ");
    //    double commissionRate = double.Parse(Console.ReadLine());

    //    Console.Write("Enter Gross Sales: ");
    //    double grossSales = double.Parse(Console.ReadLine());

    //    Console.Write("Enter Basic Salary: ");
    //    double basicSalary = double.Parse(Console.ReadLine());

    //    SalariedEmployee salariedEmployee = new SalariedEmployee(ssn, firstName, lastName, birthDate, phone, email, commissionRate, grossSales, basicSalary);
    //    employees.Add(salariedEmployee);
    //}
    //static void DisplayEmployeeInformation()
    //{
    //    foreach (Employee employee in employees)
    //    {
    //        if (employee is SalariedEmployee)
    //        {
    //            SalariedEmployee salariedEmployee = employee as SalariedEmployee;
    //            salariedEmployee.Display();
    //        }
    //        else if (employee is HourlyEmployee)
    //        {
    //            HourlyEmployee hourlyEmployee = employee as HourlyEmployee;
    //            hourlyEmployee.Display();
    //        }
    //    }
    //}

    //static void SearchEmployee()
    //{

    //    while (true)
    //    {
    //        Console.WriteLine("Search Employee:");
    //        Console.WriteLine("1. By Employee Type");
    //        Console.WriteLine("2. By Employee Name");
    //        Console.WriteLine("3. Return to Main Menu");
    //        Console.Write("Please select an option: ");

    //        int searchOption = int.Parse(Console.ReadLine());

    //        switch (searchOption)
    //        {
    //            case 1:
    //                SearchByEmployeeType();
    //                break;
    //            case 2:
    //                SearchByEmployeeName();
    //                break;
    //            case 3:
    //                return;
    //            default:
    //                Console.WriteLine("Invalid option. Please try again.");
    //                break;
    //        }
    //    }
    //}
    //static void SearchByEmployeeType()
    //{
    //    Console.Write("Enter employee type to search (Salaried or Hourly): ");
    //    string employeeType = Console.ReadLine();

    //    var searchResults = employees.Where(e => e.GetType().Name == $"{employeeType}Employee").ToList();

    //    if (searchResults.Count > 0)
    //    {
    //        Console.WriteLine("Search results:");
    //        foreach (var result in searchResults)
    //        {
    //            result.Display();
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("No matching employees found.");
    //    }
    //}
    //static void SearchByEmployeeName()
    //{
    //    Console.Write("Enter employee's  name: ");
    //    string employeeFullName = Console.ReadLine();

    //    var searchResults = employees.Where(e => (e.LastName) == (employeeFullName)).ToList();

    //    if (searchResults.Count > 0)
    //    {
    //        Console.WriteLine("Search results:");
    //        foreach (var result in searchResults)
    //        {
    //            result.Display();
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("No matching employees found.");
    //    }
    //}
}
