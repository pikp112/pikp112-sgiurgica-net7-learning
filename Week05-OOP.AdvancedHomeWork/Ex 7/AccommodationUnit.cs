namespace Week5_OOP_Advanced
{
    public abstract class AccommodationUnitDetails
    {
        //Fields
        private string _street;
        private int _streetNumber;
        //Unit details properties
        public string NameUnit { get; protected set; }
        public int IdUnit { get; protected set; }
        public int NumberOfEmplyees { get; protected set; }
        //Unit address properties
        public Cities City { get; set; }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                if (value.GetType()!=typeof(string))
                {
                    throw new Exception("Input value of street is not a string.");
                }
                else _street = value;
            }
        }
        public int StreetNumber
        {
            get
            {
                return _streetNumber;
            }
            set
            {
                if (value.GetType()!=typeof(int))
                {
                    throw new Exception("Input value of street number is not a string.");
                }
                else _streetNumber = value;
            }
        }
        //Methods
        public abstract string GetFullAddressUnit();
        public abstract int TotalNumberOfAccommodationRooms();
        public abstract int NumberOfPeopleWhoCanBeAccommodated();
        public abstract void AddEmployee(int addNumber);
        public abstract void RemoveEmployee(int removeNumber);
        public virtual void PrintInfo()
        {
            Console.WriteLine($" Unit {NameUnit} with an ID: {IdUnit} from the address: {GetFullAddressUnit()}." +
        $"\n The capacity for accommodation is: {TotalNumberOfAccommodationRooms()} rooms for {NumberOfPeopleWhoCanBeAccommodated()} people.");
        }
    }
}
