namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex8
{
    internal static class NewListSquareNum
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

                CheckZeroInt(listInt);

                var SquaresNum = listInt.Select(num => num * num).ToList();

                Console.Write($"\nNew list that contains the squares of the numbers in the original list: ");
                PrintInfo(SquaresNum);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
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

        private static void CheckZeroInt(List<int> listInt)
        {
            foreach (var num in listInt)
            {
                if (num == 0)
                {
                    throw new DivideByZeroException("Input value can't be zero.");
                }
            }
        }

        private static void PrintInfo(List<int> squaresNum)
        {
            foreach (var num in squaresNum)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
