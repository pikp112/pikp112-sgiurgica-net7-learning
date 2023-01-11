namespace Week5_OOP_Advanced
{
    internal class Account
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; } // sau return GetBalance();
            set {
                //behind value=20000;
                if (value < 0)
                {
                    throw new Exception("Can't asssign negative values to balance.");
                }
                _balance = value; }
        }

        public int Example { get; set; }
        public void AddBalance(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                throw new Exception("Amount can't be negative.");           
            }
        }

       /* public decimal GetBalance()           // inlocuit prin proprietatea get
        {
            return _balance;
        }*/
    }
}
