namespace FreeExerciseOOP.Exercise5
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }
    }
}
