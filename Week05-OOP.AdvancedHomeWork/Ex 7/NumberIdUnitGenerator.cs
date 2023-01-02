namespace Week5_OOP_Advanced
{
    public static class NumberIdUnitGenerator
    {
        private static int _idUnitGenerator = 1;
        public static int AutoGenerateIdUnit()
        {
            return _idUnitGenerator++;
        }
    }
}
