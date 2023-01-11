namespace Week5_OOP_Advanced
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string _gender;
        public string Gender {
            get
            {
                return _gender;
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    _gender = value;
                }
            }
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and I am a {Age} year old {Gender}.");
        }

        public abstract string GetFullName();
        
        
          
    }
}
