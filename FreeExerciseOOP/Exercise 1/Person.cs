namespace FreeExerciseOOP.Exercise1
{
    public class Person
    {
        public string Name
        {
            get; set;
        }

        public string ToString()
        {
            return $"Hello! My name is " + Name;
        }
    }
}
