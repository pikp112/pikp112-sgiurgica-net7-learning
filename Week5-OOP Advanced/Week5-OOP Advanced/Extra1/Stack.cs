namespace Week5_OOP_Advanced.Extra1
{
    public class Stack : IStack
    {
        private int[] array = new int[10];
        private int top = 0;
        public int Length { get { return top; } }
        public void Push(int value)
        {
            if (top == 10)
            {
                throw new StackFullException();
            }
            array[top] = value;
            top++;
        }
        public int Pop()
        {
            if (top == 0)
            {
                throw new StackEmptyException();
            }
            top--;
            return array[top];
        }
    }
}
