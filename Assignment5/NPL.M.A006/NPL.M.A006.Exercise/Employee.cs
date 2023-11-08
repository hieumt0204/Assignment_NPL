using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace NPL.M.A006.Exercise_
{
    public abstract class Employee
    {
        public string ssn;
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public string phone;
        public string email;

        public Employee() { }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                // Check if the date is in the correct format (dd/MM/yyyy)
                if (value.ToString("dd/MM/yyyy") != "01/01/0001")
                {
                    birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Invalid BirthDate format. Use dd/MM/yyyy.");
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                // Check if the phone number contains at least 7 positive integers
                if (Regex.IsMatch(value, @"\d{7,}"))
                {
                    phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone number must contain at least 7 positive integers.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                // Check if the email is in correct format
                if (Regex.IsMatch(value, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format.");
                }
            }
        }

        public Employee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email)
        {
            SSN = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }

        protected Employee(string ssn, string firstName, string lastName)
        {
            this.ssn = ssn;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public abstract double CalculateEarnings();
        public virtual void Display()
        {
            Console.WriteLine($"SSN {SSN}\n Name: {FirstName} {LastName}\n BirthDate: {BirthDate.ToString("dd/MM/yyyy")}\n Phone: {Phone}\n Email: {Email}");
        }
    }
}
