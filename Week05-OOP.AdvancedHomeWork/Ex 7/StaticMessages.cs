namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    public static class StaticMessages
    {
        public static void ExitMessage()
        {
            Console.WriteLine("  Thank you! If you want to implement another action or to see another details, please start again the program.");
        }

        public static void ExitMessageWithNo()
        {
            Console.WriteLine("  Ok, we understand your choose. For other implementation, please start again the program.");
        }

        public static void ExitMessageByWrongInput()
        {
            Console.WriteLine("  Your input value is wrong. Please start again the program.");
        }

        public static void MessageTryAgain()
        {
            Console.WriteLine("  Please start again the program if you want to do something.");
        }
    }
}
