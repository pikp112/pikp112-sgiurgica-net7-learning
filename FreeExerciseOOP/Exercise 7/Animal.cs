namespace FreeExerciseOOP.Exercise7
{
    public abstract class Animal
    {
     protected string Name { get; set; }
     public string SetName(string name)
        {
            Name = name;
            return Name;
        }
     public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
}
