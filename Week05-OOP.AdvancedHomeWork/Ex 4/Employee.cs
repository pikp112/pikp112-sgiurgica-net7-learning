namespace Week5_OOP_Advanced
{
    public abstract class Employee
    {
        private string _email;
        private int _phone;
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Email
        {
            get
            {
                //First we need to split the Name in 2 parts:
                string _firstName = Name.Substring(0, Name.IndexOf(" ")); //define firstName
                string _lastName = Name.Substring(Name.IndexOf(" ") + 1); //define lastName

                _email=$"{_firstName.ToLower()}.{_lastName[0]}";         //auto-create email by the output
                return _email;
            }
            set
            {
                if (value.Contains("@")&&value.Contains("."))
                {
                    _email = value;
                }
            }
        }

        public int Phone
        {
            get { return _phone; }
            set     //check if set number contains 10 digits
            {
                if (value==null)
                {
                    Console.WriteLine("Without phone number.");
                }
                else
                {
                    int count = 0;
                    while (value>0)
                    {
                        value/=10;
                        count++;
                    }
                    if (count==10)
                    {
                        _phone = value;
                    }
                    else
                    {
                        throw new Exception("Phone number doesn t contain 10 digits.");
                    }
                }
            }
        }

        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return $"{Name} have {Age} years old and the salary is {Salary}.";

        }
    }
}
