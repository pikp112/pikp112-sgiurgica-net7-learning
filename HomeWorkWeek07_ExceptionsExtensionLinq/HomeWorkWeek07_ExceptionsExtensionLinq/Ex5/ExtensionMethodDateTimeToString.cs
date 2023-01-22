namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex5
{
    public static class ExtensionMethodDateTimeToString
    {
        public static void Start()
        {
            Console.WriteLine("This method convert actual time, a DateTime data type, to string: ");
            Console.WriteLine(DateTime.Now.ExtensionMethodDateTime());
        }
        private static string ExtensionMethodDateTime(this DateTime dateAndTime)
        {
            return dateAndTime.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
