namespace NPL.M.A006.Exercise_
{
    public class SalariedEmployee : Employee
    {

        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        public SalariedEmployee() { }


        public SalariedEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double commissionRate, double grossSales, double basicSalary)
        : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            CommissionRate = commissionRate;
            GrossSales = grossSales;
            BasicSalary = basicSalary;
        }
        public override double CalculateEarnings()
        {
            
            return BasicSalary;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($" Commission Rate: {CommissionRate.ToString("0.00")}\n Gross Sales: {GrossSales.ToString("0.00")}\n Basic Salary: {BasicSalary.ToString("0.00")}");
        }

    }
}
