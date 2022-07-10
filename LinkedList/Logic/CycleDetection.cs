namespace LinkedList.Logic
{
    public class CycleDetection
    {
        Node head;
        class Node
        {
            public int data;
            public Node next, child, prev;

            public Node(int d)
            {
                data = d;
                next = child = prev = null;
            }
        }

        //Insert a new node at the front of the list
        public void Push(int new_data)
        {
            /* 1 & 2: Allocate the node and 
             * put it in the data */
            Node new_node = new Node(new_data);

            /* 3: Make next of new node as head */
            new_node.next = head;

            /* 4: Move the head to point to new node */
            head = new_node;
        }

        Boolean DetectLoop()
        {
            Node slow_p = head, fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;

                if (slow_p == fast_p)
                {
                    return true;
                }
            }
            return false;
        }

        /* Driver Code */
        public void Main()
        {
            CycleDetection cc = new CycleDetection();

            cc.Push(20);
            cc.Push(4);
            cc.Push(15);
            cc.Push(10);

            /* Create a Loop for Testing 
             * note that cc.head.data = 10 */
            cc.head.next.next.next.next = cc.head;

            Boolean found = cc.DetectLoop();
            if (found)
            {
                Console.WriteLine("Loop Found");
            }
            else
            {
                Console.WriteLine("No Loop");
            }
        }
    }
}