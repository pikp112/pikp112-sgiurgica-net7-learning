namespace Week5_OOP_Advanced.ClassworkWeek5_OOP
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public abstract string GetFullName(); //full name
        public abstract double GetMonthlySalary(); //salary divided by 12

    }
}
