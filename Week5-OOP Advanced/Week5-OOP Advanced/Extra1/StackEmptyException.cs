namespace Week5_OOP_Advanced.Extra1
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException()
        {
            Console.WriteLine("Stack is empty.");
        }
    }
}
