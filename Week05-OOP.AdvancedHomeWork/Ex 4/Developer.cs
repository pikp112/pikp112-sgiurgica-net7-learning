namespace Week5_OOP_Advanced
{
    public class Developer : Employee
    {
        public double Bonus { get; set; }
        public List<string> Skills { get; set; }
        public bool IsJunior { get; set; }
        public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
        {
            Name = name;
            Age = age;
            Salary = salary;
            List<string> Skills = new List<string>();
            Skills = skills;
            IsJunior = isJunior;
        }
        public override double CalculateBonus()
        {
            return Bonus=Salary*0.2;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Skills: {Skills}, Email:{Email}, Phone: {Phone}";
        }
    }
}
