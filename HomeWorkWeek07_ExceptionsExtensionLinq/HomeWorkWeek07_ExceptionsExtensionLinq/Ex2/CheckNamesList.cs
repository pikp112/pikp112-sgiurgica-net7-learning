namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex2
{
    internal static class CheckNamesList
    {
        public static void Start()
        {
            List<string> listOfNames = new List<string>();
            Console.WriteLine("Insert a list of names by space:");
            string input = Console.ReadLine();
            string[] inputParse = input.Split(" ");
            listOfNames.AddRange(inputParse);
            try
            {
                CheckAllNames(listOfNames);
            }
            catch (BlankNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CheckAllNames(List<string> listOfNames)
        {
            foreach (var name in listOfNames)
            {
                if (!IsValidName(name))
                {
                    throw new BlankNameException($"{name} value is blank.");
                }
                Console.WriteLine($"{name} value is valid.");

            }
        }

        private static bool IsValidName(string name)
        {
            //a name is valid (NOT BLANK) if contain min 3 char and max 25 and type is string
            if (name.GetType() != typeof(string))
            {
                return false;
            }
            if (name.Length <= 3 || name.Length >= 25)
            {
                return false;
            }
            return true;
        }
    }
}
