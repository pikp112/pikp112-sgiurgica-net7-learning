﻿using System.IO;

namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    sealed class Motel : AccommodationUnitDetails, IRooms, IProgram
    {
        //Fields
        private int _noSingleRooms;
        private int _priceSingleRoom;
        private int _noDoubleRooms;
        private int _priceDoubleRoom;
        private int _noApartments;
        private int _priceApartment;
        private int? _noOfEmployees;
        //Properties
        //Employees
        public int? NumberOfEmplyees
        {
            get { return _noOfEmployees; }
            protected set
            {
                if (value<=0)
                {
                    throw new Exception("This unit can't have 0 or negative employees.");
                }
                else _noOfEmployees=value;
            }
        }
        //Unit rooms details
        public int NumberOfSingleRooms          //for 1 person
        {
            get
            { return _noSingleRooms; }
            set
            {
                _priceSingleRoom = 80;
                if (value<0)
                {
                    throw new Exception("Number of rooms can't be negative.");
                }
                else _noSingleRooms= value;
            }
        }
        public int NumberOfDoubleRooms          //for 2 people
        {
            get
            { return _noDoubleRooms; }
            set
            {
                _priceDoubleRoom=150;
                if (value<0)
                {
                    throw new Exception("Number of rooms can't be negative.");
                }
                else _noDoubleRooms= value;
            }
        }
        public int NumberOfApartments           //for 4 people
        {
            get
            { return _noApartments; }
            set
            {
                _priceApartment=220;
                if (value<0)
                {
                    throw new Exception("Number of rooms can't be negative.");
                }
                else _noApartments= value;
            }
        }
        //Unit program
        public string CheckInTime { get; private set; }
        public string CheckOutTime { get; private set; }
        //Constructors
        //default constructor
        public Motel()
        {
            NameUnit="Unknown";
            //auto generate ID by static class methods
            IdUnit=NumberIdUnitGenerator.AutoGenerateIdUnit();
            NumberOfEmplyees=null;
        }
        //basic constructor
        public Motel(string name, int id, Cities city, string street, int streetNumber, int numberOfEmployees)
        {
            NameUnit=name;
            IdUnit=id;
            City=city;
            Street=street;
            StreetNumber=streetNumber;
            NumberOfEmplyees=numberOfEmployees;
        }
        //Methods
        //Program
        public void SetCheckInTime(string setCheckIn)
        {
            CheckInTime = setCheckIn;
        }
        public void SetCheckOutTime(string setCheckOut)
        {
            CheckOutTime = setCheckOut;
        }
        //Price rooms
        public int GetPriceSingleRoom()
        {
            return _priceSingleRoom;
        }
        public int GetPriceDoubleRoom()
        {
            return _priceDoubleRoom;
        }
        public int GetPriceApartment()
        {
            return _priceApartment;
        }

        public void SetPriceSingleRoom(int price)
        {
            if (price <= 0)
            {
                throw new Exception("Price can't be negative.");
            }
            else _priceSingleRoom=price;
        }
        public void SetPriceDoubleRoom(int price)
        {
            if (price <= 0)
            {
                throw new Exception("Price can't be negative.");
            }
            else _priceDoubleRoom=price;
        }
        public void SetPriceApartment(int price)
        {
            if (price <= 0)
            {
                throw new Exception("Price can't be negative.");
            }
            else _priceApartment=price;
        }
        //Unit capacity
        public override int NumberOfPeopleWhoCanBeAccommodated()    //dynamic polymorphism - method override
        {
            int _capacityOfAccommodation = NumberOfSingleRooms + NumberOfDoubleRooms*2 + NumberOfApartments*4;
            return _capacityOfAccommodation;
        }
        public override int TotalNumberOfAccommodationRooms()   //dynamic polymorphism - method override
        {
            int _totalNumberOfAccommodationRooms = NumberOfSingleRooms + NumberOfDoubleRooms + NumberOfApartments;
            return _totalNumberOfAccommodationRooms;
        }
        //Full address
/*        public override string GetFullAddressUnit()         //dynamic polymorphism - method override
        {                                                     //is not defineted like abstract method in the abstract class
            return $"{City}, {Street}, nr.{StreetNumber}";
        }
*/
        public static void GetFullAddressUnit(Motel motel)     //static polymorphism - method overload
        {
            Console.WriteLine($"Motel {motel.NameUnit} address is: {motel.GetFullAddressUnit()}.");
        }
        //Add/Remove employee
        public override void AddEmployee(int addNumber)          //dynamic polymorphism - method override
        {
            NumberOfEmplyees+=addNumber;
        }
        public override void RemoveEmployee(int removeNumber)        //dynamic polymorphism - method override
        {
            NumberOfEmplyees-=removeNumber;
        }
        //Unit details
        public override void PrintInfo()        //dynamic polymorphism - method override on virtual method
        {
            if (this.NumberOfApartments==0)
            {
                Console.WriteLine($" Motel {NameUnit} with an ID: {IdUnit} from the address: {GetFullAddressUnit()}." +
                    $"\n The capacity for accommodation is: {TotalNumberOfAccommodationRooms()} rooms for {NumberOfPeopleWhoCanBeAccommodated()} people." +
                    $"\n The number of employees is {NumberOfEmplyees}."+
                    $"\n Price for single room is {_priceSingleRoom} euro and for a double room is {_priceDoubleRoom} euro." +
                    $"\n For this unit, the program is: check-in after {CheckInTime} AM and check-out before {CheckOutTime} PM.");
            }
            else
            {
                Console.WriteLine($" Motel {NameUnit} with an ID: {IdUnit} from the address: {GetFullAddressUnit()}." +
                    $"\n The capacity for accommodation is: {TotalNumberOfAccommodationRooms()} rooms for {NumberOfPeopleWhoCanBeAccommodated()} people." +
                    $"\n The number of employees is {NumberOfEmplyees}."+
                    $"\n Price for single room is {_priceSingleRoom} euro, for a double room is {_priceDoubleRoom} euro and for an apartment is {_priceApartment} euro." +
                    $"\n For this unit, the program is: check-in after {CheckInTime} AM and check-out before {CheckOutTime} PM.");
            }
        }
    }
}
