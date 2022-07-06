namespace LinkedList.Common
{
    public static class Validator
    {
        public static int IsInteger(ref string input, int choice)
        {
            bool isInt = int.TryParse(input, out choice);
            if ((!isInt))
            {
                input = string.Empty;
                Console.WriteLine("Input is invalid.");
                Thread.Sleep(500);
            }
            return choice;
        }
    }
}
