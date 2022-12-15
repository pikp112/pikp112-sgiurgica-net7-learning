namespace Week4_HomeWork
{
    public class Faculty
    {
        public string _firstName;
        public string _lastName;
        public int _employeeId;
        public List<string> _subjectsTaught;

        public Faculty(string firstName, string lastName, int employeeId, List<string> subjectsTaught)
        {
            _firstName = firstName;
            _lastName = lastName;
            _employeeId = employeeId;
            _subjectsTaught = subjectsTaught;
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
            //return $"{_firstName} + " " + {_lastName}";
        }

        public void GetSubjectsTaught()
        {
            foreach(string elem in _subjectsTaught)
            {
                Console.WriteLine(elem);
            }
        }


    }
}
