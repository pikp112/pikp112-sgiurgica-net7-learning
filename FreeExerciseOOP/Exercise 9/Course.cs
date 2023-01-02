namespace FreeExerciseOOP
{
    public abstract class Course
    {
        protected string Name { get; set; }
        protected int Duration { get; set; }
        protected int Fee { get; set; }
        public Course(string name, int duration, int fee)
        {
            Name = name;
            Duration = duration;
            Fee = fee;
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Duration);
            Console.WriteLine(Fee);
        }

        public abstract int GetTotalFee();

    }
}
