namespace LinkedList.Logic
{
    public class FlattenMultiLevelLinkedList
    {
        static Node head;
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

        Node CreateList(int[] arr, int n)
        {
            Node node = null;
            Node p = null;

            int i;
            for (i = 0; i < n; ++i)
            {
                if (node == null)
                {
                    node = p = new Node(arr[i]);
                }
                else
                {
                    p.next = new Node(arr[i]);
                    p = p.next;
                }
                p.next = p.child = p.prev = null;
            }
            return node;
        }

        void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next; 
            }
            Console.WriteLine(" ");
        }

        Node CreateList()
        {
            int[] arr1 = new int[] { 10, 5, 12, 7, 11 };
            int[] arr2 = new int[] { 4, 20, 13 };
            int[] arr3 = new int[] { 17, 6 };
            int[] arr4 = new int[] { 9, 8};
            int[] arr5 = new int[] { 19, 15 };
            int[] arr6 = new int[] { 2 };
            int[] arr7 = new int[] { 16 };
            int[] arr8 = new int[] { 3 };

            Node head1 = CreateList(arr1, arr1.Length);
            Node head2 = CreateList(arr2, arr2.Length);
            Node head3 = CreateList(arr3, arr3.Length);
            Node head4 = CreateList(arr4, arr4.Length);
            Node head5 = CreateList(arr5, arr5.Length);
            Node head6 = CreateList(arr6, arr6.Length);
            Node head7 = CreateList(arr7, arr7.Length);
            Node head8 = CreateList(arr8, arr8.Length);

            head1.child = head2;
            head1.next.next.next.child = head3;
            head3.child = head4;
            head4.child = head5;
            head2.next.child = head6;
            head2.next.next.child = head7;
            head7.child = head8;

            return head1;
        }

        void printList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine("");
        }

        public void Main()
        {
            FlattenMultiLevelLinkedList list = new FlattenMultiLevelLinkedList();
            head = list.CreateList();
            list.Flatten(head);
            //list.FlattenList(head);
            list.PrintList(head);
        }

        Node Flatten(Node head)
        {
            var current = head;
            var stack = new Stack<Node>();

            // Loop through nodes
            while (current != null)
            {

                // Check to see if node has child
                if (current.child != null)
                {
                    // If current node has a next node, save to stack
                    // so we can reconnect it to the tail
                    // of the child node later
                    if (current.next != null)
                    {
                        stack.Push(current.next);
                    }

                    // Set the next node as the child,
                    // we will now iterate down this path
                    current.next = current.child;

                    // Set the previous node as the current
                    current.next.prev = current;

                    // Set child to null
                    current.child = null;

                }
                else if (current.next == null)
                {
                    // Reconnect node at the top of the
                    // stack to the tail child node
                    if (stack.Count > 0)
                    {
                        // Set the next node as the reconnected node,
                        // we will now iterate down this path
                        current.next = stack.Pop();
                        current.next.prev = current;
                    }
                }
                current = current.next;
            }

            return head;
        }
    }
}


        