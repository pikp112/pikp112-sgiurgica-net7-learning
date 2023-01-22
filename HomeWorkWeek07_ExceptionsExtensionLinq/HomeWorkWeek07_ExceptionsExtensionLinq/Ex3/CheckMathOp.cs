namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex3
{
    public static class CheckMathOp
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
                CheckStringList(listInt);
                CheckOverFlow(listInt);
                CheckEmptyList(listInt);
                Console.WriteLine($"Sum: {CalculateSum(listInt)}");
                Console.WriteLine($"Average: {CalculateAverage(listInt)}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CheckEmptyList(List<int> listInt)
        {
            if (listInt == null)
            {
                throw new DivideByZeroException("Attempted to divide by zero.");
            }
        }

        private static void CheckOverFlow(List<int> listInt)
        {
            foreach (int num in listInt)
            {
                if (num > int.MaxValue)
                {
                    throw new OverflowException("Arithmetic operation resulted in an overflow.");
                }
            }
        }

        private static void CheckStringList(List<int> listInt)
        {
            foreach (int num in listInt)
            {
                if (num.GetType() != typeof(int))
                {
                    throw new FormatException("Input string was not in a correct format.");
                }
            }
        }

        private static int CalculateSum(List<int> listInt)
        {
            int sum = 0;
            foreach (int num in listInt)
            {
                sum += num;
            }
            return sum;
        }
        private static int CalculateAverage(List<int> listInt)
        {
            int counter = 0;
            foreach (int num in listInt)
            {
                counter++;
            }
            return CalculateSum(listInt) / counter;
        }
    }
}
