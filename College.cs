namespace Week4_HomeWork
{
    public class College
    {
        public string _name;
        public int _foundedYear;
        public string _city;

        public College()
        {
            _name = "Unknown";
            _foundedYear = 0;
            _city = "Unknown";
        }

        public College(string name, int foundedYear, string city)
        {
            _name = name;
            _foundedYear = foundedYear;
            _city = city;
        }
    }
}
