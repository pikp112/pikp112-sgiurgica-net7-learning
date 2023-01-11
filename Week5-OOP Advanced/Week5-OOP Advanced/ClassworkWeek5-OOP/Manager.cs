namespace Week5_OOP_Advanced.ClassworkWeek5_OOP
{
    sealed class Manager : Employee
    {
        public List<Employee> Employee = new List<Employee>();

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName= firstName;
            LastName= lastName;
            Salary= salary;
        }
        public void AddEmployee(RegularEmployee employee)
        {
            Employee.Add(employee);
        }

        public double GetTotalMonthlySalary()
        {
            double totalMonthlySalary = 0;
            foreach (var employee in Employee)
            {
               totalMonthlySalary+=employee.GetMonthlySalary();
            }
            return totalMonthlySalary+this.GetMonthlySalary();
            

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
