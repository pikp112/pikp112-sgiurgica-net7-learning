namespace Week4_HomeWork
{
    public class Faculty
    {
        public string _firstName;
        public string _lastName;
        public int _employeeId;
        public List<string> _subjectsTaught=new List<string>();

        public Faculty(string firstName, string lastName, int employeeId, string subjectsTaught)
        {
            _firstName = firstName;
            _lastName = lastName;
            _employeeId = employeeId;
            if (subjectsTaught!=null)
            {
                _subjectsTaught.Add(subjectsTaught);
            }
            else throw new Exception("List \"subjectsTaught\" is not ok.");
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public List<string> GetSubjectsTaught()
        {
            return _subjectsTaught;
        }


    }
}
