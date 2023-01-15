namespace Week5_OOP_Advanced
{
    interface IProgram
    {
        string CheckInTime { get; }
        string CheckOutTime { get; }
        public void SetCheckInTime(string setCheckIn);
        public void SetCheckOutTime(string setCheckOut);
    }
}
