namespace Week5_OOP_Advanced
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }
        private Department Department { get; set; }
        public Manager(string name, int age, double salary, Department department)
        {
            Name= name;
            Age= age;
            Salary= salary;
            Department= department;
        }
        public override double CalculateBonus()
        {
            return Bonus=Salary*0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Department}, Email: {Email}, Phone: {Phone}.";
        }
    }
}
