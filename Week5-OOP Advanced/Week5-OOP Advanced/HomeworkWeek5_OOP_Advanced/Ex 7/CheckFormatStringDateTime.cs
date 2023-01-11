namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    public static class CheckFormatStringDateTime
    {
        public static void Start(string time)
        {
            //format is in hours : e.g. "12:00"
            DateTime dDate;
            if(DateTime.TryParse(time, out dDate))
            {
                String.Format("{0:hh:mm}", dDate);
            }
            else
            {
                Console.WriteLine("Invalid: input string time is not in required format.");
            }
        }
    }
}
