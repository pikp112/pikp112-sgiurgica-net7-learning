namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex1
{
    public static class CheckPastOrFuture
    {
        public static void Start()
        {
            Console.WriteLine("Insert a date, in format \"yyyy-MM-dd\", to check if it is in the future:");
            try
            {
                string inputDateTime = Console.ReadLine();
                DateTime convertedInputDate = DateTime.Parse(inputDateTime);
                CheckInputDateIsFuture(convertedInputDate);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CheckInputDateIsFuture(DateTime convertedInputDate)
        {
            if (convertedInputDate < DateTime.Now)
            {
                throw new InvalidDateException($"{convertedInputDate} is in the past.");
            }
        }
    }
}
