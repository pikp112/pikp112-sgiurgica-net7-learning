namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex6
{
    public static class IntToBinary
    {
        public static void Start()
        {
            Console.WriteLine("Insert an integer: ");
            try
            {
                int inputValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The binary value is: {inputValue.ToBinary()}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Your input value format is wrong.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static string ToBinary(this int value)
        {
            return Convert.ToString(value, 2);
        }
    }
}
