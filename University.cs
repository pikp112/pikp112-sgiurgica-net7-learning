namespace Week4_HomeWork
{
    public class University
    {
        public string _name;
        public List<Student> students = new List<Student>();
        public List<Faculty> faculties = new List<Faculty>();

        public University(string Name)
        {
            _name = Name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public int GetFacultyCount()
        {
            return faculties.Count;
        }
    }
}
