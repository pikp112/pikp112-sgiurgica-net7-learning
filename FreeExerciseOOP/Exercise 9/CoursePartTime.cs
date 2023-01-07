namespace FreeExerciseOOP
{
    public class CoursePartTime : Course
    {
        private string TimingPartTimeCourse { get; set; }
        public CoursePartTime(string name, int duration, int fee, string timingPartTimeCourse) : base(name, duration, fee)
        {
            TimingPartTimeCourse= timingPartTimeCourse;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine(TimingPartTimeCourse);
        }
        public override int GetTotalFee()
        {
            return Fee-Fee*10/100;   //discount 10%
        }
    }
}
