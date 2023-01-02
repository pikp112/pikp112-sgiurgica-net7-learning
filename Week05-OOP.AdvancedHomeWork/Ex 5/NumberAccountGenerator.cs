namespace Week5_OOP_Advanced
{
    public static class NumberAccountGenerator
    {
        private static int numberAccountGenerator = 0;
        public static int GetNumAccountAutoGenerate()
        {
            return numberAccountGenerator++;
        }
    }
}
