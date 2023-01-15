using System.Reflection;
using System.Xml.Linq;

namespace Week5_OOP_Advanced.Week5_day2
{
    public abstract class Person                    
    {
        protected string _gender;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public CityNames CyteName { get; set; }
        internal string Gender
        {
            get
            {
                return _gender.ToUpper();
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    _gender = value;
                }
                else throw new Exception("Gender is not valid.");
            }
        }
        public virtual void Introduce()
        {
            string messageToDisplay = $"Hi, my name is {GetFullName()} and I am a {Age} year old {Gender}.";
            Console.WriteLine(messageToDisplay);
        }


        protected abstract string GetFullName();            // OBLIGI clasa copil sa o implementeze
        
        
    }
}
