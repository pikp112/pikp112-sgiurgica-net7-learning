namespace Week5_OOP_Advanced
{
    public class Transaction
    {
        private string _type;
        private DateTime _timespan;
        public DateTime Timestamp { get; set; }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value.ToLower() == "deposit" || value.ToLower() == "withdraw")
                {
                    _type = value;
                }
            }
        }
        public decimal Amount { get; set; }
        public Transaction(string type, decimal amount)
        {
            this.Timestamp= DateTime.Now;
            _type = type;
            Amount = amount;
        }
    }
}
