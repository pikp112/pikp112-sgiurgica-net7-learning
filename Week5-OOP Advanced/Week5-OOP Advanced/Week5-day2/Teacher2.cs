namespace Week5_OOP_Advanced.Week5_day2
{
    internal class Teacher2 : Person
    {
        public List<Course> Courses { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {GetFullName()} and i'm a teacher");
        }
        protected override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
