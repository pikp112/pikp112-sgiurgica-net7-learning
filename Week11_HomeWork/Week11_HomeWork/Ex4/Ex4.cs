using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_HomeWork.Ex4
{   //Write a C# program that uses the async and await keywords to fetch multiple URLs concurrently,
    //and then prints out the content of the first URL to complete.
    public class AsyncPrintUrlEx4
    {
        public async Task Run()
        {
            string? firstUrl, secondUrl, thirdUrl;
            InputLinks(out firstUrl, out secondUrl, out thirdUrl);

            Console.WriteLine("Now we will print the content of your fastest URL matched:");

            await PrintUrlsAsync(firstUrl, secondUrl, thirdUrl);
        }
        private static void InputLinks(out string? firstUrl, out string? secondUrl, out string? thirdUrl)
        {
            Console.WriteLine("Insert first URL:");
            firstUrl =Console.ReadLine();
            CheckUrl(firstUrl);
            Console.WriteLine("Insert second URL:");
            secondUrl =Console.ReadLine();
            CheckUrl(secondUrl);
            Console.WriteLine("Insert third URL:");
            thirdUrl =Console.ReadLine();
            CheckUrl(thirdUrl);
        }

        private static void CheckUrl(string? firstUrl)
        {
            if (firstUrl == null)
            {
                throw new CheckException(" Your URL have a wrong format.");
            }
            if (firstUrl.Length < 7 || !firstUrl.Contains("."))
            {
                throw new ValidationException(" Your URL don't have logic validation.");
            }
        }

        public async Task PrintUrlsAsync(string firstUrl, string secondUrl, string thirdUrl)
        {
            Task<string> firstTask = GetDataFromUrlAsync(firstUrl);
            Task<string> secondTask = GetDataFromUrlAsync(secondUrl); 
            Task<string> thirdTask = GetDataFromUrlAsync(thirdUrl);

            Console.WriteLine(await Task.WhenAny(firstTask, secondTask, thirdTask));
        }
        private async Task<string> GetDataFromUrlAsync(string url)
        {
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            };
        }
    }
}
