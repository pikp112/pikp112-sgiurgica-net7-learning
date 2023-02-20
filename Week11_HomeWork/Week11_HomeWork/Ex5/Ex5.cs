using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex5
{
    //Create a generic interface that defines a method for comparing two items of the same type.
    //Implement this interface in a class that compares two items based on
    //their length (for strings) or size (for collections).
    public class Ex5<T> : CompareInterface<T>
    {
        public void Run()
        {
            Console.WriteLine("Insert first item:");
            var firstItem = Console.ReadLine();
            Console.WriteLine("Insert second item:");
            var secondItem = Console.ReadLine();
            Console.WriteLine("By comparing the result, longest item is: ");
            Console.WriteLine(Compare(firstItem, secondItem));
        }
        public T Compare<T>(T firstValue, T secondValue)
        {
            if(secondValue.ToString().Length < firstValue.ToString().Length)
            {
                return firstValue;
            }
/*            if (secondValue.ToString().Length == firstValue.ToString().Length)
            {
                //return //"Both values have same length.";
            }
*/            else return secondValue;
        }
    }
}
