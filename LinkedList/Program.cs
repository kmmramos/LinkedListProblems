
using LinkedList.Common;

namespace LinkedList
{
    class Program
    {
        public static int SelectAction()
        {
            int choice = -1;
            string input = string.Empty;
            do
            {
                Console.WriteLine("Actions");
                Console.WriteLine("Select from the options below:");
                Console.WriteLine("[1] Reverse Linked List");
                Console.WriteLine("[2] M and N Reversal");
                Console.WriteLine("[3] Flatten Multi-Level Linked List");
                Console.WriteLine("[4] Cycle Detection in Linked List");
                Console.WriteLine("Enter action:");
                input = Console.ReadLine();
                choice = Validator.IsInteger(ref input, choice);
                Console.Clear();
            } while (string.IsNullOrEmpty(input));
            return choice;
        }

        static void Main(String[] args)
        {
            try
            {
                int choice = SelectAction();
                switch (choice)
                {
                    case 1:
                        Display.Problem1();
                        break;
                    case 2:
                        Display.Problem2();
                        break;
                    case 3:
                        Display.Problem3();
                        break;
                    case 4:
                        Display.Problem4();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}