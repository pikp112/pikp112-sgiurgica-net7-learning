namespace FreeExerciseOOP.Exercise5
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
