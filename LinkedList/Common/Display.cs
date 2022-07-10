
using LinkedList.Logic;

namespace LinkedList.Common
{
    public static class Display
    {
        public static void Problem1()
        {
            Console.Write("Please enter the number of elements inside the linked list: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the elements: ");
            LL lL = new LL();
            int d;
            for (int i = 1; i <= length; i++)
            {
                Console.Write("Enter node " + i.ToString() + ": ");
                d = Convert.ToInt32(Console.ReadLine());
                lL.AddNode(new LL.Node(d));
            }

            //list before reversal
            Console.Write("Given Linked List: ");
            lL.PrintList();

            //list after reversal
            lL.ReverseList();
            Console.Write("Reversed Linked List: ");            
            lL.PrintList();
        }

        public static void Problem2()
        {
            Console.Write("Please enter the number of elements inside the linked list: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the elements: ");
            MAndNReversal lL = new MAndNReversal();
            int d;
            for (int i = 1; i <= length; i++)
            {
                Console.Write("Enter node " + i.ToString() + ": ");
                d = Convert.ToInt32(Console.ReadLine());
                lL.AddNode(new MAndNReversal.Node(d));
            }

            Console.Write("Please enter the start of the reversal: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the end of the reversal: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //list before reversal
            Console.Write("Given Linked List: ");
            lL.PrintList();

            //list after reversal
            lL.ReverseBetween(m, n);
            Console.Write("Reversed Linked List: ");
            lL.PrintList();
        }

        public static void Problem3()
        {
            FlattenMultiLevelLinkedList flattenMultiLevelLinkedList = new FlattenMultiLevelLinkedList();
            flattenMultiLevelLinkedList.Main();
        }

        public static void Problem4()
        {
            CycleDetection cycleDetection = new CycleDetection();
            cycleDetection.Main();
        }

    }
}
