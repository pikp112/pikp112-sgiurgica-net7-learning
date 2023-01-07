namespace Week5_OOP_Advanced
{
    public class Teacher : Person
    {
        public List<Course> courses { get; set; }
    public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and i'm a teacher");
        }
        public override string GetFullName()
        {
            return $"{ FirstName}{ LastName}";
        }
    }
}
