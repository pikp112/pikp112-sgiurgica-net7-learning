namespace FreeExerciseOOP.Exercise3;

public class Person
{
protected int Age { get; set; }
public void Greet()
    {
        Console.WriteLine("Hello!");
    }
public int SetAge(int age)
    {
        Age= age;
        return Age;
    }
}
