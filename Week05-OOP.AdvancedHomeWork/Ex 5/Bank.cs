namespace Week5_OOP_Advanced
{
    public static class Bank
    {
        private static double InterestRate { get; set; } = 0.01;
        public static int NumAccounts { get; set; } = 0;
        public static double CalculateInterest(double _balance)
        {
            double _interest;
            return _interest=_balance*InterestRate;
        }
        public static int GetNumAccounts()
        {
            return NumAccounts;
        }
    }
}
