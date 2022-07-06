namespace LinkedList.Logic
{
    public class MAndNReversal
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void AddNode(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void ReverseBetween(int m, int n)
        {
            //first move the current pointer to the node
            //from where we have to reverse the linked list
            Node curr = head, prev = null;

            //prev points to the node before the mth node
            int i;
            for (i = 1; i < m; i++)
            {
                prev = curr;
                curr = curr.next;
            }

            //this pointer store the pointer to the head of the reversed linkedlist
            Node rtail = curr;

            //this pointer stores the pointer to the tail of the reversed linkedlist
            Node rhead = null;

            //now reverse the linkedlist from m to n nodes
            while (i <= n)
            {
                Node next = curr.next;
                curr.next = rhead;
                rhead = curr;
                curr = next;
                i++;
            }

            //if prev is not null, it means that some of the nodes exists before m (or if m != 1)
            if (prev != null)
            {
                prev.next = rhead;
            }
            else
            {
                head = rhead;
            }

            //at this point curr will point to the next of the nth node
            //where we will connect the tail of te reverse linked list
            rtail.next = curr;
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}

