using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex6
{
    //Create an asynchronous method that performs an HTTP GET request to a specified URL,
    //      and returns the contents of the response as a string.
    //The method should use the HttpClient class to perform the request.
    internal class Ex6
    {
        public async Task Run()
        {
            Console.WriteLine("Insert a link to return his content:");
            try
            {
                var inputLink = Console.ReadLine();

                if(inputLink == null)
                {
                    Console.WriteLine("Your input is null.");
                    return;
                }
                await PrintUrlsAsync(inputLink);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Byeeeee!");
            }
        }
        public async Task PrintUrlsAsync(string inputLink)
        {
            Task<string> firstTask = GetDataFromUrlAsync(inputLink);

            Console.WriteLine("Your link's content is:");

            string result = await firstTask;

            Console.WriteLine(result);
        }
        private async Task<string> GetDataFromUrlAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            };
        }

    }
}
