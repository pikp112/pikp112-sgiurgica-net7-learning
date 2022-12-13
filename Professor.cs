namespace Week4_HomeWork
{
    public class Professor
    {
        public string _name;
        //public string _faculity;
        public College _faculity;
        public string _specialization;
        public List<string> _studentsWhoGiveTheirDegree = new List<string>();
        public StudentCollege _student;

        public Professor(string name, College faculity, string specialization)
        {
            _name = name;
            _faculity = faculity;
            _specialization = specialization;
        }

        public Professor(string name, College faculity, string specialization, string studentsWhoGiveTheirDegree)
        {
            _name=name;
            if (_faculity._name!=name && _faculity._name!=_student._name)
            {
                throw new Exception("the name of the college is not the same for the professor and the student");
            } else _faculity = faculity;
            _specialization = specialization;
            _studentsWhoGiveTheirDegree.Add(studentsWhoGiveTheirDegree);
        }

        public void AddStudent()
        {
            Console.Write("Insert student's name: ");
            _student._name = Console.ReadLine();
            Console.WriteLine();

            _studentsWhoGiveTheirDegree.Add(_student._name);
        }

    }
}
