namespace Week5_OOP_Advanced.Extra1
{
    public class StackFullException : Exception
    {
        public StackFullException() : base("Stack Full")
        {
            Console.WriteLine("Stack is full.");
        }
    }
}
