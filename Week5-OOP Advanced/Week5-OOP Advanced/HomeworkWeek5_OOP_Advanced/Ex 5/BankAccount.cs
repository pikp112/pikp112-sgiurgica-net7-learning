using System.Security.Principal;
using System.Xml.Linq;

namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex2
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber= value;
            }
        }
        public string AccountHolder
        {
            get
            {
                return _accountHolder;
            }
            set
            {
                if (value.GetType()==typeof(int)||value.GetType()==typeof(double))
                {
                    throw new Exception("Values account holder can't be an int or a double.");
                }
                else _accountHolder = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Balance can't be set lower than 0.");
                }
                //else _balance = value; //redundant
                _balance = value;
            }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            _accountNumber= accountNumber;
            _accountHolder= accountHolder;
            _balance= balance;
            Bank.NumAccounts++;
        }
        public BankAccount(string accountHolder, double balance)
        {
            _accountNumber= Convert.ToString(NumberAccountGenerator.GetNumAccountAutoGenerate());
            _accountHolder= accountHolder;
            _balance= balance;
            Bank.NumAccounts++;
        }

        public void Deposit(double amount)
        {
            if (amount<=0)
            {
                throw new Exception("You can't deposit a negative amount or an amount equal with 0.");
            }
            Balance+=amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance<amount)
            {
                throw new Exception("Your balance value is smaller than this amount.");
            }
            Balance-=amount;
        }

        public string GetInterest()
        {
            return $"{Bank.CalculateInterest(Balance)}";
        }
    }
}
