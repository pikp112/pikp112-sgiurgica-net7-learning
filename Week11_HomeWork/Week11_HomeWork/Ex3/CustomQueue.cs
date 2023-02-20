using System;
using System.Collections;

namespace Week11_HomeWork.Ex3
{
    //Create a generic class that represents a queue, where the items can be of any type. The class should have
    //methods to enqueue, dequeue, and peek at the front item, as well as a method to check if the queue is empty.
    public class CustomQueue<T>
    {
        private Queue<T> elements;
        public CustomQueue() 
        {
            elements = new Queue<T>();
        }
        public CustomQueue(T[] arrayTemp)
        {
            elements =new Queue<T>(arrayTemp);
        }
        public void Enqueue(T item)
        {
            elements.Enqueue(item);
        }

        public T Dequeue()
        {
            return elements.Dequeue();
        }

        public T Peek()
        {
            return elements.Peek();
        }
        public void Print()
        {
            Console.WriteLine("Your queue is: ");

            foreach (T item in elements)
            {
                Console.WriteLine(item);
            }
        }

        public void CheckIfQueueIsEmpty()
        {

            if (elements.Count == 0 || elements.Count == null)
            {
                throw new ValidateQueueException("Your queue is null or doesn't have at least an element.");
            }
        }
    }
}
