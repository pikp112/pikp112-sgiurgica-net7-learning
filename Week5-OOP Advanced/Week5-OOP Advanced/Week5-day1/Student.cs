namespace Week5_OOP_Advanced
{
    public class Student
    {
        public string[] courses;

        public List<string> courses2;
        public Student()
        {
        }

        public Student(string[] courses)
        {
            this.courses = courses;
        }

        public Student(List<string> courses2)
        {
            this.courses2 = courses2;
        }

        public void PrintCourses()
        {
            foreach(var course in courses)
            Console.WriteLine(course);
        }

        public void PrintCourses2()
        {
            foreach (var course in courses2)
                Console.WriteLine(course);
        }
    }
}
