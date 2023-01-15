using System.Collections.Generic;

namespace Week5_OOP_Advanced;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    private List<Transaction> Transactions = new List<Transaction>();

    public BankAccount(int accountNumber, string accountHolder, decimal balance)
    {
        List<Transaction> Transactions = new List<Transaction>();
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }
    public BankAccount(string accountHolder, decimal balance)
    {
        List<Transaction> Transactions = new List<Transaction>();
        AccountHolder= accountHolder;
        Balance = balance;
        AccountNumber=AccountNumberGenerator.GetAccountNumber();
    }
    public void Deposit(decimal amount)
    {
        if (amount< 0)
        {
            throw new Exception("Amount can't be negative.");
        }
        Balance += amount;
        Transactions.Add(new Transaction("Deposit", amount));
        Transactions.Sort((Transaction1, Transaction2) => Transaction1.Timestamp.CompareTo(Transaction2.Timestamp));
    }
    public void Withdraw(decimal amount)
    {
        if (amount<0)
        {
            throw new Exception("Amount can't be negative.");
        }
        if (amount>Balance)
        {
            throw new Exception("This amount doesn'e exist in this bank account.");
        }
        Balance -= amount;
        Transactions.Add(new Transaction("Withdraw", amount));
        Transactions.Sort((Transaction1, Transaction2) => Transaction1.Timestamp.CompareTo(Transaction2.Timestamp));
    }
    public decimal GetBalance()
    {
        return Balance;
    }
    public List<Transaction> GetTransactionHistory()
    {
        return Transactions;
    }
}
