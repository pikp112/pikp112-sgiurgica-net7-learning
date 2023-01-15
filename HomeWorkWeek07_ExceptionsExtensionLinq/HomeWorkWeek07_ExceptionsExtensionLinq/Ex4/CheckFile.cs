using System.IO;
namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex4
{
    public static class CheckFile
    {
        public static void Start()
        {
            // reads a text file and displays the contents on the console.
            Console.WriteLine("Enter the name of a file:");
            string fileName = Console.ReadLine();
            string path = Path.Combine(@"C:\Users\sorin\source\repos\Week07Exceptions-Extension\HomeWorkWeek07_ExceptionsExtensionLinq\HomeWorkWeek07_ExceptionsExtensionLinq\Ex4\", fileName);
            try
            {
                CheckFiles(fileName);
                CheckEmptyPath(fileName);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CheckFiles(string fileName)
        {
            if (!File.Exists(fileName))
            {
                // If the file does not exist, the program should create a new file
                // and ask the user to enter some text to write to the file
                Console.WriteLine("File does not exist.\nEnter some text to write to the new file:");
                using (StreamWriter newFile = new StreamWriter(@"Desktop"))
                {
                    string inputString = Console.ReadLine();
                }
            }
        }

        private static void CheckEmptyPath(string fileName)
        {
            FileInfo infoPath = new FileInfo(fileName);
            if (infoPath.Length == 0)
            {
                Console.WriteLine($"The file {infoPath.Name} is empty. Insert some text to write into the file:");
                string inputString = Console.ReadLine();
                File.WriteAllText(infoPath.FullName, inputString);
            }
            else
            {
                Console.WriteLine("File contents:");
                string[] lines = File.ReadAllLines(infoPath.FullName);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
