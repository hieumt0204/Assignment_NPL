namespace NPL.M.A006.Exercise_
{
    public class HourlyEmployee : Employee
    {

        public double Wage { get; set; }
        public double WorkingHour { get; set; }

        public HourlyEmployee() { }

        public HourlyEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double wage, double workingHours)
       : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            Wage = wage;
            WorkingHour = workingHours;
        }
        public override double CalculateEarnings()
        {
            // Hourly employees are paid based on their wage and working hours
            return Wage * WorkingHour;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($" Wage: {Wage}\n Working Hours: {WorkingHour}");
        }


    }
}
