namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex9
{
    internal static class OrderStudentByGrade
    {
        public static void Start()
        {
            var students = new List<Student>
            {
                 new Student { Name = "Alice", Grade = "A" },
                 new Student { Name = "Bob", Grade = "B" },
                 new Student { Name = "Charlie", Grade = "A" },
                 new Student { Name = "Dave", Grade = "C" }
            };

            var NameStOrderbyGrade = students.Where(student => student.Grade == "A")
                .OrderByDescending(student => student.Name)
                .Select(student => new ListStudentByGrade { Name = student.Name })
                .ToList();

            Console.Write(@"Names in descending order for the students with Grade ""A"" are: ");
            foreach (var studentInfoByGrade in NameStOrderbyGrade)
            {
                Console.Write($"{studentInfoByGrade.Name} ");
            }
        }
    }
}
