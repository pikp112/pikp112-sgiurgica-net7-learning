namespace Week5_OOP_Advanced.Extra1
{
    interface IStack
    {
        int Length { get; }
        void Push(int value);
        int Pop();
    }
}
