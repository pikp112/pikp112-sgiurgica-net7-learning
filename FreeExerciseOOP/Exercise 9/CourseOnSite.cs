namespace FreeExerciseOOP
{
    public class CourseOnSite : Course
    {
        private string CompanyName { get; set; }
        private int NoOfCandidates { get; set; }

        public CourseOnSite(string name, int duration, int fee, string companyName, int noOfCandidates) : base(name, duration, fee)
        {
            CompanyName = companyName;
            NoOfCandidates = noOfCandidates;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine(CompanyName);
            Console.WriteLine(NoOfCandidates);
        }

        public override int GetTotalFee()
        {
            return Fee+Fee*10/100;  //more 10% than normal price
        }
    }
}
