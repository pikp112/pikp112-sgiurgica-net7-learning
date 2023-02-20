using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex3
{
    //Create a generic class that represents a queue, where the items can be of any type. The class should have
    //methods to enqueue, dequeue, and peek at the front item, as well as a method to check if the queue is empty.
    public class Ex3
    {
        public static void Run()
        {
            Console.WriteLine("Ex3: Insert elements for your queue by space:");
            try
            {
                var inputArray = Console.ReadLine();
                var tempArray = inputArray.Split(" ");

                var inputQueue = new CustomQueue<string>(tempArray);

                inputQueue.CheckIfQueueIsEmpty();

                DisplayMenu();
                var selectOption = Convert.ToInt16(Console.ReadLine());

                SelectOption(selectOption,inputQueue);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Byee.");
            }
        }

        private static void SelectOption(int selectOption, CustomQueue<string> inputQueue)
        {
            switch (selectOption)
            {
                case 1:
                    {
                        Console.WriteLine("Insert element you want to add:");
                        var enqueueElement = Console.ReadLine();
                        inputQueue.Enqueue(enqueueElement);
                        inputQueue.Print();
                        break;
                    }

                case 2:
                    {
                        var oldElement = inputQueue.Peek();
                        Console.WriteLine($"You will remove {oldElement}.");
                        inputQueue.Dequeue();
                        break;
                    }

                case 3:
                    {
                        var oldElement = inputQueue.Peek();
                        Console.WriteLine($"The oldest element is {oldElement}.");
                        break;
                    }

                default:
                    return;
            }

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Select option: \n1.Enqueue element \n2.Dequeue element \n3.Peek element");
        }

    }
}
