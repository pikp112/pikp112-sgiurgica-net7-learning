using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class FreeExercices
    {
        public void Go()
        {

            //1. Given a string, write a method that checks
            //if there are exactly the same letters on the left side and right side of the string.
            //Assume string length is even and letters don't repeat on each side.
            //Expected input and output
            //LettersBalance("fgvgvf") → true
            //LettersBalance("lampsmpser") → false

            /*string letter = "alooal";
            for (int i = 0; i < letter.Length / 2; i++)
            {
                bool isBalance = false;

                for (int j = letter.Length - 1; j >= letter.Length / 2; j--)
                {
                    if (letter[i] == letter[j])
                    {
                        isBalance = true;
                    }
                }
                if (isBalance == false)
                {
                    isBalance=false;
                }
            }

            //2. Given a string in which two words are separated by a char, write a method that replaces these two words.
            // Expected input and output
            // ReplaceWords("abc_xyz", '_') → xyz_abc
            // ReplaceWords("trolling.master", '.') → master.trolling
            char ch = '_';
            string word = "firstWord" + ch + "secondWord";
            string firstWord="";
            string secondWord="";

            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] != ch)
                {
                    secondWord += word[i];

                }
                else {
                    for (int j = i + 1;j < word.Length; j++)
                    {
                        firstWord += word[j];
                    }
                    break;
                    }
            }
            Console.WriteLine(firstWord+ch+secondWord);


            //3.Given two integers, write a method that returns first number raised to the power of second one.
            // Expected input and output
            // ToThePowerOf(-2, 3) → -8

            Console.WriteLine("input first number: ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input second number: ");
            double num2=Convert.ToDouble(Console.ReadLine());

            double numPow = Math.Pow(num1, num2);
            Console.WriteLine("result is: "+ numPow);*/


            //4.Write a method that draws triangle shape like below.
            // Expected input and output
            // DrawTriangle() →
            //             *
            //            **
            //           ***
            //          ****
            //         *****
            //        ******
            //       *******
            //      ********
            //     *********
            //    **********

            char stellar= '*';
            for(int i=0;i<10;i++)
            {
                for (int j = 10; j >i; j--)
                {
                   
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write(stellar);
                }
                Console.WriteLine();

            }





            Console.ReadKey();
        }

    }
}
