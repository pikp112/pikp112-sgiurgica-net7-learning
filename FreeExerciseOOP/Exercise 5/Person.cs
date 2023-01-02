namespace FreeExerciseOOP.Exercise5
{
    public class Person
    {
    public string Name { get; set; }

    public Person(string name)
        {
            Name = name;
        }
    public string ToString()
        {
            return $"Hello! My name is {Name}";
        }
    }
}
