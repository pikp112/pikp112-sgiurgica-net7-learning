namespace Week5_OOP_Advanced.Week5_day1
{
    internal class Author
    {
        private string name;
        private string email;
        public Author() { }

        public string Name                  //asta e CUSTOM
        {
            get
            {
                return this.name;                 //poti accesa alex.Name;
                                                  //return name.ToLower();
            }
            set
            { //this.name="nothing"      //MEREU va fi NOTHING
                name = value;
            }               //poti seta alex.Name=VALOARE;
        }
        public Author(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            if (name.Length < 10)
            {
                Console.WriteLine("Error");
            }
            this.name = name;
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@")&&value.Contains("."))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Error on email");
                }
            }
        }
        public string Country
        {
            get; set;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Print()
        {
            Console.WriteLine($"{this.name} have an email: {this.email} and is from "); // aici e din field

            //SAU

            Console.WriteLine($"{Name} have an email: {this.email} and is from "); //aici este activa ToLower din Propertatea lui Name
        }
    }
}
