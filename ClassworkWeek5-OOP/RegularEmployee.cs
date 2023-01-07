namespace Week5_OOP_Advanced
{
    sealed class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName,string lastName,double salary)
        {
            FirstName= firstName;
            LastName= lastName;
            Salary= salary;
        }
        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override double GetMonthlySalary()
        {
            return Salary/12;
        }
    }
}
