namespace Week5_OOP_Advanced.ClassworkWeek5_OOP
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        private long Balance { get; set; }
        private List<string> Transactions=new List<string>();

        public BankAccount(int accountNumber, string accountHolder, long balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public long Deposit(long amount)
        {
            Transactions.Add($"Deposited ${amount}.");
            return Balance += amount;
        }
        public long Withdraw(long amount)
        {
            Transactions.Add($"Withdraw ${amount}.");
            return Balance -= amount;
        }

        public long GetBalance()
        {
            return Balance;
        }
        public List<string> GetTransactionHistory()
        {
            return Transactions;
        }

    }
}