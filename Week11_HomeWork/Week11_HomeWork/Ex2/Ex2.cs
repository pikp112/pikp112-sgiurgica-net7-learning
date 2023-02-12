using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex2
{
    //2.Create a generic method that takes in a list of any type and
    //      applies a specific action to each element using a lambda expression.

    public static class Ex2
    {
        public static void Run()
        {
            Console.WriteLine("Ex2: Insert a list of any type with space between elements:");
            try
            {
                var inputArray = Console.ReadLine();
                if (inputArray == null || inputArray.Length < 1)
                {
                    Console.WriteLine("Your list is null or need a length greater than 0.");
                    return;
                }
                var inputList = inputArray.Split(" ").ToList();

                inputList.ForEach(Display);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Display<T>(T obj)
        {
            Console.WriteLine("NEW "+ obj);
        }

        public static void CustomAction<T>(this List<T> list, Action<T> action)
        {
            try
            {
                foreach (var item in list)
                {
                    action(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
