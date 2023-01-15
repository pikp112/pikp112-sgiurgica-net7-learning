namespace Week5_OOP_Advanced
{
    public class Author
    {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }

    public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Country);
        }
    }
}
