namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    public static class HotelManagementMenu
    {
        public static void Start()
        {
            while (true)
            {
                HotelMenu();
                try
                {
                    int? option = Convert.ToInt16(Console.ReadLine());
                    if (option == 1)
                    {
                        SeeHotelList();
                    }
                    if (option == 2)
                    {
                        CheckAddressHotel();
                    }

                    if (option==3)
                    {
                        SeeRoomsNumberandPrices();
                    }

                    if (option==4)
                    {
                        ChangeRoomPrices();
                    }
                    if (option==5)
                    {
                        ChangeProgram();
                    }
                    if (option==6)
                    {
                        EmployeeDepartmentAction();
                    }
                    if (option==7)
                    {
                        CreateNewHotel();
                    }
                    if (option == null || option>7 || option<1)
                    {
                        Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                        if (ExitMethod())
                        {
                            HotelMenu();
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    StaticMessages.MessageTryAgain();
                }
                break;
            }
        }

        private static void HotelMenu()
        {
            Console.WriteLine("  Choose from the following option:");
            Console.WriteLine("   1. See the list of hotels.");
            Console.WriteLine("   2. See the hotel addresses.");
            Console.WriteLine("   3. See the number of rooms and their prices.");
            Console.WriteLine("   4. Change prices for any room you want.");
            Console.WriteLine("   5. Set the check-in and check-out time like(\"12:00\") format.");
            Console.WriteLine("   6. See the employee department.");
            Console.WriteLine("   7. Create a new hotel.");
        }
        private static void SeeHotelList()
        {
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"  {hotel.NameUnit} with {hotel.IdUnit} with address: " + hotel.GetFullAddressUnit());
            }
            Console.WriteLine(" If you want to exit, please write EXIT. if not, write CONTINUE.");
            if (ExitMethod())
            {
                Start();
            }
            else
            {
                Console.WriteLine("  Invalid input value.");
            }
            StaticMessages.ExitMessage();

        }
        private static void EmployeeDepartmentAction()
        {
            Console.WriteLine("  This is the list of hotels:");
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"  {hotel.NameUnit} with ID: {hotel.IdUnit}");
            }
            Console.WriteLine("  Insert hotel by ID to set an action in employee department:");
            try
            {
                int inputHotel = Convert.ToInt32(Console.ReadLine());
                if (ListStaticHotels.IdHotels.Contains(inputHotel))
                {
                    foreach (Hotel hotel in ListStaticHotels.hotelList)
                    {
                        if (hotel.IdUnit== inputHotel)
                        {
                            Console.WriteLine($"  Choose an action: \n 1.See number on employees on {hotel.NameUnit}. " +
                                            $"\n   2.Add some employees." +
                                            $"\n   3.Remove some empoyees.");
                            int? inputActionEmployeeDepartment = Convert.ToByte(Console.ReadLine());
                            if (inputActionEmployeeDepartment==1)
                            {
                                Console.WriteLine($"  Total number of employees in {hotel.NameUnit} is {hotel.NumberOfEmplyees}.");
                            }
                            else if (inputActionEmployeeDepartment==2)
                            {
                                Console.WriteLine("  Insert number of employees you want to add:");
                                int addEmployees = Convert.ToInt32(Console.ReadLine());
                                if (addEmployees>0)
                                {
                                    hotel.AddEmployee(addEmployees);
                                    if (addEmployees==0)
                                    {
                                        Console.WriteLine("  So you don't have new employees.");
                                    }
                                    else if (addEmployees==1)
                                    {
                                        Console.WriteLine("  Congratulations! You have a new employee.");
                                    }
                                    else if (addEmployees>1)
                                    {
                                        Console.WriteLine($"  Congratulations ! You have {addEmployees} new employees.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                                    if (ExitMethod())
                                    {
                                        EmployeeDepartmentAction();
                                    }
                                }
                            }
                            else if (inputActionEmployeeDepartment==3)
                            {
                                Console.WriteLine("  Insert number of employees you want to remove:");
                                int removeEmployees = Convert.ToInt32(Console.ReadLine());
                                if (removeEmployees>0)
                                {
                                    hotel.RemoveEmployee(removeEmployees);
                                    if (removeEmployees==0)
                                    {
                                        Console.WriteLine("  Congratulations! You don't lose any employees.");
                                    }
                                    else if (removeEmployees==1)
                                    {
                                        Console.WriteLine("  We're sorry beacause uou lose one employee.");
                                    }
                                    else if (removeEmployees>1)
                                    {
                                        Console.WriteLine($"  We're sorry because you lose {removeEmployees} employees.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                                    if (ExitMethod())
                                    {
                                        EmployeeDepartmentAction();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(" Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                                if (ExitMethod())
                                {
                                    EmployeeDepartmentAction();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                    if (ExitMethod())
                    {
                        EmployeeDepartmentAction();
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            StaticMessages.ExitMessage();
        } 
        private static void ChangeProgram()
        {
            Console.WriteLine("  This is the list of hotels:");
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"  {hotel.NameUnit} with ID: {hotel.IdUnit}");
            }
            Console.WriteLine("  Insert hotel by ID to set new program:");
            try
            {
                int inputHotel = Convert.ToInt32(Console.ReadLine());
                if (ListStaticHotels.IdHotels.Contains(inputHotel))
                {
                    foreach (Hotel hotel in ListStaticHotels.hotelList)
                    {
                        if (hotel.IdUnit== inputHotel)
                        {
                            Console.WriteLine("  Please set the check-in time in format \"12:00\":");
                            string? inputNewCheckIn = Console.ReadLine();
                            CheckFormatStringDateTime.Start(inputNewCheckIn);
                            Console.WriteLine("  Please set the check-out time in format \"15:00\":");
                            string? inputNewCheckOut = Console.ReadLine();
                            CheckFormatStringDateTime.Start(inputNewCheckOut);
                            try
                            {
                                hotel.SetCheckInTime(inputNewCheckIn);
                                hotel.SetCheckOutTime(inputNewCheckOut);
                                if (inputNewCheckIn==null || inputNewCheckOut==null)
                                {
                                    Console.WriteLine("  Wrong value, try again.");
                                    ChangeProgram();
                                }
                            }
                            catch (InvalidNewCheckIn ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                    if (ExitMethod())
                    {
                        ChangeProgram();
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            StaticMessages.ExitMessage();
        }
        private static void SeeRoomsNumberandPrices()
        {
            Console.WriteLine("  This is the list of hotels:");
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"  {hotel.NameUnit} with ID: {hotel.IdUnit}");
            }
            Console.WriteLine(" Insert hotel by ID to see his rooms number:");
            try
            {
                int inputHotel = Convert.ToInt32(Console.ReadLine());
                if (ListStaticHotels.IdHotels.Contains(inputHotel))
                {
                    foreach (Hotel hotel in ListStaticHotels.hotelList)
                    {
                        if (hotel.IdUnit== inputHotel)
                        {
                            Console.WriteLine("  Number of rooms: "+ hotel.TotalNumberOfAccommodationRooms());
                            Console.WriteLine("  Do you want to see number of people that can be accomodated?");
                            string? inputValueSeeNoPeople = Console.ReadLine();
                            if (inputValueSeeNoPeople.ToLower()=="yes")
                            {
                                Console.WriteLine($"  Number of people that can be accomodate in {hotel.NameUnit} is " + hotel.NumberOfPeopleWhoCanBeAccommodated());
                            }
                            else if (inputValueSeeNoPeople.ToLower()=="no")
                            {
                                StaticMessages.ExitMessageWithNo();
                                break;
                            }
                            else if (inputValueSeeNoPeople==null || inputValueSeeNoPeople.ToLower()!="yes" || inputValueSeeNoPeople.ToLower()!="no")
                            {
                                StaticMessages.ExitMessageByWrongInput();
                                break;
                            }
                            Console.WriteLine("  Do you want to see types of rooms?");
                            string? inputValueSeeTypesOfRooms = Console.ReadLine();
                            if (inputValueSeeTypesOfRooms.ToLower()=="yes")
                            {
                                Console.WriteLine($"  Single rooms: {hotel.NumberOfSingleRooms}, double rooms: {hotel.NumberOfDoubleRooms} and apartments: {hotel.NumberOfApartments}.");
                            }
                            else if (inputValueSeeTypesOfRooms.ToLower()=="no")
                            {
                                StaticMessages.ExitMessageWithNo();
                                break;
                            }
                            else if (inputValueSeeTypesOfRooms==null || inputValueSeeTypesOfRooms.ToLower()!="yes" || inputValueSeeTypesOfRooms.ToLower()!="no")
                            {
                                StaticMessages.ExitMessageByWrongInput();
                                break;
                            }
                            Console.WriteLine(" Do you want to see room prices?");
                            string? inputValueSeeRoomPrices = Console.ReadLine();
                            if (inputValueSeeRoomPrices.ToLower()=="yes")
                            {
                                Console.WriteLine($"  Single room price: {hotel.GetPriceSingleRoom()} euro, " +
                                    $"double room price: {hotel.GetPriceDoubleRoom()} euro and for " +
                                    $"apartment price: {hotel.GetPriceApartment()} euro.");
                                StaticMessages.ExitMessage();
                                break;
                            }
                            else if (inputValueSeeRoomPrices.ToLower()=="no")
                            {
                                StaticMessages.ExitMessageWithNo();
                                break;
                            }
                            else if (inputValueSeeRoomPrices==null || inputValueSeeRoomPrices.ToLower()!="yes" || inputValueSeeRoomPrices.ToLower()!="no")
                            {
                                StaticMessages.ExitMessageByWrongInput();
                                break;
                            }
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine(" Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                    if (ExitMethod())
                    {
                        SeeRoomsNumberandPrices();
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            StaticMessages.ExitMessage();
        }
        private static void ChangeRoomPrices()
        {
            Console.WriteLine("This is the list of hotels:");
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"{hotel.NameUnit} with ID: {hotel.IdUnit}");
            }
            Console.WriteLine("  Insert hotel by ID to change room prices:");

            try
            {
                int inputHotel = Convert.ToInt32(Console.ReadLine());
                if (ListStaticHotels.IdHotels.Contains(inputHotel))
                {
                    foreach (Hotel hotel in ListStaticHotels.hotelList)
                    {
                        if (hotel.IdUnit== inputHotel)
                        {
                            Console.WriteLine("  Select a room:" + "\n 1.Single Room" + "\n 2.Double Room" + "\n 3.Apartment.");
                            int? inputSelectedRoom = Convert.ToByte(Console.ReadLine());
                            if (inputSelectedRoom==1)
                            {
                                Console.WriteLine("  Insert new price for single room: ");
                                int insertNewPriceSingleRoom = Convert.ToInt32(Console.ReadLine());
                                hotel.SetPriceSingleRoom(insertNewPriceSingleRoom);
                            }
                            else if (inputSelectedRoom==2)
                            {
                                Console.WriteLine("  Insert new price for double room: ");
                                int insertNewPriceDoubleRoom = Convert.ToInt32(Console.ReadLine());
                                hotel.SetPriceSingleRoom(insertNewPriceDoubleRoom);
                            }
                            else if (inputSelectedRoom==3)
                            {
                                Console.WriteLine("  Insert new price for apartment: ");
                                int insertNewPriceApartment = Convert.ToInt32(Console.ReadLine());
                                hotel.SetPriceSingleRoom(insertNewPriceApartment);
                            }
                            else
                            {
                                Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                                if (ExitMethod())
                                {
                                    ChangeRoomPrices();
                                }
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                    if (ExitMethod())
                    {
                        ChangeRoomPrices();
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            StaticMessages.ExitMessage();

        }
        private static void CheckAddressHotel()
        {
            Console.WriteLine(" This is the list of hotels:");
            foreach (Hotel hotel in ListStaticHotels.hotelList)
            {
                Console.WriteLine($"  {hotel.NameUnit} with ID: {hotel.IdUnit}");
            }
            Console.WriteLine("  Insert address hotel by ID you want:");
            try
            {
                int inputHotel = Convert.ToInt32(Console.ReadLine());
                if (ListStaticHotels.IdHotels.Contains(inputHotel))
                {
                    foreach (Hotel hotel in ListStaticHotels.hotelList)
                    {
                        if (hotel.IdUnit== inputHotel)
                        {
                            Console.WriteLine(hotel.GetFullAddressUnit());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("  Wrong value, try again. If you want to exit, please write EXIT. if not, write CONTINUE.");
                    if (ExitMethod())
                    {
                        CheckAddressHotel();
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            StaticMessages.ExitMessage();
        }
        private static void CreateNewHotel()
        {
            try
            {
                Console.Write("  Insert the name for your new hotel: ");        //need to review: it s internal!
                string newNameHotel = Console.ReadLine();
                Console.WriteLine("  How many single rooms have your new hotel?");
                int newHotelSingleRooms = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("  How many double rooms have your new hotel?");
                int newHotelDoubleRooms = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("  How many apartments have your new hotel?");
                int newHotelApartments = Convert.ToInt32(Console.ReadLine());
                
                var dictFromEnum = Enum.GetValues(typeof(Cities))               //create new dictionary
                    .Cast<Cities>()
                    .ToDictionary(city => ((int)city)+1, city => city.ToString());
                foreach (KeyValuePair<int, string> cityDict in dictFromEnum)
                {
                    Console.WriteLine($"           {cityDict.Key}.{cityDict.Value}");
                }
                Console.WriteLine("   Insert the city where you want to build a new hotel from previous list by his value:");
                string? newCityHotel = Console.ReadLine();
                if(Enum.TryParse<Cities>(newCityHotel,out Cities City))
                {
                    Console.WriteLine($"{newCityHotel} is the city where you want to build the Hotel {newNameHotel}.");

                }
                else
                {
                    Console.WriteLine("The value is not in the enum");
                }
                /*var dictFromEnum = Enum.GetValues(typeof(Cities))               //create new dictionary
                    .Cast<Cities>()
                    .ToDictionary(city => (int)city, city => city.ToString());
                foreach(KeyValuePair<int,string> cityDict in dictFromEnum)
                {
                    if (cityDict.Value!=newCityHotel)
                    {
                        var countDic = dictFromEnum.Count();
                        dictFromEnum.Add(countDic++, newCityHotel);
                        Enum.Parse<Cities>(cityDict.Value);
                        //Enum.TryParse<Cities>((int)cityDict.Key, out cityDict.Value);
                        //return Cities;
                    }
                    else
                    {
                        newCityHotel=cityDict.Value;
                        Console.WriteLine($"Ok, so the {newCityHotel} exist in our list like {cityDict.Value} value.");
                    }
                }
*/              Console.WriteLine("  Insert the street where your new address hotel:");
                string newStreetAddressHotel = Console.ReadLine();
                if (newStreetAddressHotel.GetType()!=typeof(string))
                {
                    throw new Exception("  Your value is not a string, so is not a valid parameter.");
                }

                Console.WriteLine("  Insert the street number where of your new address hotel:");
                int newStreetNumberAddressHotel = Convert.ToInt32(Console.ReadLine());
                ListStaticHotels.hotelList.Add(new Hotel()
                {
                    NameUnit=newNameHotel,
                    IdUnit=NumberIdUnitGenerator.AutoGenerateIdUnit(),                  //it's internal!
                    //City=newCityHotel,                                                //need convert to enum
                    Street=newStreetAddressHotel,
                    StreetNumber=newStreetNumberAddressHotel,
                    NumberOfEmplyees=0,                                                 //it's internal!
                    NumberOfSingleRooms=newHotelSingleRooms,
                    NumberOfDoubleRooms=newHotelDoubleRooms,
                    NumberOfApartments=newHotelApartments
                });
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(" If you want to exit, please write EXIT. if not, write CONTINUE.");
            if (ExitMethod())
            {
                Start();
            }
            else
            {
                Console.WriteLine("  Invalid input value.");
            }
            StaticMessages.ExitMessage();
        }
        private static bool ExitMethod()
        {
            try
            {
                string exitInput = Console.ReadLine();
                if (exitInput.ToUpper()=="EXIT")
                {
                    Console.WriteLine("  Have a nice day!");
                    return false;
                }
                else if (exitInput.ToUpper()=="CONTINUE")
                {
                    Console.WriteLine("  You don't want to exit so let's try again!");
                    Start();
                }
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
