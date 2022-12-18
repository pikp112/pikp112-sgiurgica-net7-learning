namespace FreeExerciseOOP
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int FeePaid { get; set; }

        private double _serviceTax = 12.3;

        public double ServiceTax { get
            {
                return _serviceTax;
            }
            set { _serviceTax = value; }
        }

        public Student(int rollNo, string name, string course)
        {
            RollNo = rollNo;
            Name = name;
            Course = course;
        }
        public void Payment(int payment)
        {
            FeePaid += payment;
        }
        public void Print()
        {
            Console.WriteLine(RollNo);
            Console.WriteLine(Name);
            Console.WriteLine(Course);
            Console.WriteLine(FeePaid);
        }
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaid;
            }
        }
        public int TotalFee
        {
            get
            {
                double _totalFee = (Course == "c#") ? 2000 : 3000;
                //with service tax
                _totalFee = _totalFee + _totalFee * _serviceTax / 100;
                return (int)_totalFee;
            }
        }
    }
}
