namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex7
{
    internal static class SumSquaresEvenNum
    {
        public static void Start()
        {
            List<int> listInt = new List<int>();
            Console.Write("Insert a list of numbers, separeted by spaces: ");
            try
            {
                string inputNum = Console.ReadLine();
                string[] inputArrayNum = inputNum.Split(" ");
                int[] inputIntNum = Array.ConvertAll(inputArrayNum, int.Parse);
                listInt.AddRange(inputIntNum);

                PrintEveryIntFromList(listInt);

                var sumOfSquaresEvenNum = listInt.Where(num => num % 2 == 0)
                    .Select(num => num * num)
                    .Sum();
                Console.WriteLine($"\nSum f the squares of the even numbers in the input list is: {sumOfSquaresEvenNum}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintEveryIntFromList(List<int> listInt)
        {
            foreach (int num in listInt)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
