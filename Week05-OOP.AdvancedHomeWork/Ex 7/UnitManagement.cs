namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    public static class UnitManagement
    {
        public static void Run()
        {
            while (true)
            {
                UnitMenu();
                try
                {
                    int? option = Convert.ToInt16(Console.ReadLine());
                    if (option == 1)
                    {
                        HotelManagementMenu.Start();
                    }
                    if (option == 2)
                    {
                        //MotelManagementMenu.Start();
                        Console.WriteLine("           ----- IN CONSTRUCTION ---- " +
                            "\n      If you want to exit, please write EXIT. if not, write CONTINUE.");
                        if (ExitMethod())
                        {
                            UnitMenu();
                        }
                    }
                    if (option == null || option !=1 || option!=2)
                    {
                        Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                        if (ExitMethod())
                        {
                            UnitMenu();
                        }
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    StaticMessages.MessageTryAgain();
                }
                break;
            }
        }
        private static void UnitMenu()
        {
            Console.WriteLine("Choose from the following menu:");
            Console.WriteLine("1. HOTEL management.");
            Console.WriteLine("2. MOTEL management"); //Need more time for this
        }
        private static bool ExitMethod()
        {
            try
            {
                string exitInput = Console.ReadLine();
                if (exitInput.ToUpper()=="EXIT")
                {
                    Console.WriteLine("  Have a nice day!");
                    return false;
                }
                else if (exitInput.ToUpper()=="CONTINUE")
                {
                    Console.WriteLine("  You don't want to exit so let's try again!");
                    Run();
                }
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

    }
}
