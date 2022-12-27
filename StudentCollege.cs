namespace Week4_HomeWork
{
    public class StudentCollege
    {
        public string _name;
        public DateTime _startDate;
        public DateTime _endDate;
        public College _college;
        public DateTime _birthDate;

        public StudentCollege(string name, DateTime startDate, DateTime endTime, College college, DateTime birthDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endTime;
            _college = college;
            _birthDate = birthDate;
        }

        public bool IsStillStudent()
        {
            if (_endDate < DateTime.Now)
            {
                return false;
            }
            else return true;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - _birthDate.Year;
        }

        public void Print()
        {
            Console.WriteLine($"Hi!My name is {_name} and my student period on {_college._name} is {_startDate.Year} - {_endDate.Year} years. " +
    $"My date of birth was in {_birthDate}. I am {GetAge()} years old.");
        }

        public void AddStudent()
        {
            Console.Write("Insert student's name: ");
            _name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insert start date student: ");
            _startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insert end date student: ");
            _endDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Insert college's student name: ");            //input college fields step by step
            _college._name= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insert college's founded year: ");
            _college._foundedYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert college's city: ");

            _college._city = Convert.ToString(Console.ReadLine());
            College inputCollege = new College();
            inputCollege._name = _college._name;
            inputCollege._foundedYear = _college._foundedYear;
            inputCollege._city = _college._city;                            //last step

            Console.Write("Insert birth date student: ");
            _birthDate = Convert.ToDateTime(Console.ReadLine());
        }


        public void RemoveStudent()
        {
            Console.WriteLine("Insert student name to remove: ");
            string removeNameStudent = Convert.ToString(Console.ReadLine());
            if (removeNameStudent != null)
            {
                _name = default(string);
                _endDate = default(DateTime);
                _startDate = default(DateTime);
                _endDate = default(DateTime);
                _birthDate = default(DateTime);
            }
            else Console.WriteLine("Name student is null.");
        }

    }
}
