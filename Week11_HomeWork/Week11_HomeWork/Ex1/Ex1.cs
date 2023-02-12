using System.Collections.Generic;

namespace Week11_HomeWork.Ex1
{
    public static class Ex1
    {
        //1. Create a generic method that takes in a list of any type and reverses the order of the elements.
        public static void Run()
        {
            Console.WriteLine("Ex1: Insert a list of any type with space between elements:");
            try
            {
                var inputArray = Console.ReadLine();
                if (inputArray == null || inputArray.Length < 1 )
                {
                    Console.WriteLine("Your list is null or need a length greater than 0.");
                    return;
                }
                var inputList = inputArray.Split(" ").ToList();

                Console.WriteLine(String.Join(',', GetReverseList(inputList)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<T> GetReverseList<T>(List<T> list)
        {
            var reverseList = new List<T>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reverseList.Add(list[i]);
            }
            return reverseList;
        }
    }
}
