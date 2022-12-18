namespace FreeExerciseOOP.Exercise2;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    ~Person()
    {
        Name = string.Empty;
    }
    public string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}
