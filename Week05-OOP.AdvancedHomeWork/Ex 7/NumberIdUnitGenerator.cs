namespace Week5_OOP_Advanced
{
    public static class NumberIdUnitGenerator
    {
        private static int _idUnitGenerator = 543462;
        public static int AutoGenerateIdUnit()
        {
            return _idUnitGenerator+42;             //random number unit
        }
    }
}
