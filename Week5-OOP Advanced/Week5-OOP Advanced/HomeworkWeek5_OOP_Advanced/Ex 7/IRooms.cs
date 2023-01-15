namespace Week5_OOP_Advanced
{
    interface IRooms
    {
        int NumberOfSingleRooms { get; }
        int NumberOfDoubleRooms { get; }
        int NumberOfApartments { get; }
        void SetPriceSingleRoom(int price);
        void SetPriceDoubleRoom(int price);
        void SetPriceApartment(int price);
    }

}
