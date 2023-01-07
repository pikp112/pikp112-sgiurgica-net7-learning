namespace Week5_OOP_Advanced
{
    public static class AccountNumberGenerator
    {
        private static int accountNumber = 0;
        public static int GetAccountNumber() { return accountNumber++; }
    }
}
