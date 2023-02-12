using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex7
{
    //Create an asynchronous method that writes a string to a file.
    //The method should use the StreamWriter classes to perform the file write.

    public class Ex7
    {
        public async Task Run()
        {
            Console.WriteLine("Insert a text that will be the content's file:");
            try
            {
                var inputString = Console.ReadLine();

                if(inputString == null)
                {
                    Console.WriteLine("Your input is null.");
                    return;
                }
                await WriteFile(inputString);
            }
            catch(NullException ex)
            {
                Console.WriteLine("Is something wrong with your input. Please try again.");
            }
            finally
            {
                Console.WriteLine("Byyyyyyyeeeeeeeeeeee!!");
            }
        }

        private async Task WriteFile(string? inputString)
        {
            var path = Directory.GetCurrentDirectory();

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "NewFile.txt")))

                await outputFile.WriteAsync(inputString);
        }
    }
}
