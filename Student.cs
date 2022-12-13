namespace Week4_HomeWork
{
    public class Student
    {
        public string _firstName;
        public string _lastName;
        public int _studentID;
        public double _GPA;

        public Student(string firstName, string lastName, int studentID, double GPA)
        {
            _firstName = firstName;
            _lastName = lastName;
            _studentID = studentID;
            _GPA = GPA;
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public bool HasHonors()
        {
            if (_GPA >= 3.5)
            {
                return true;
            }
            else return false;
        }


    }
}
