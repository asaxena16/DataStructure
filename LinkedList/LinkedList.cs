using System;

namespace DataSctructure
{
    public class LinkedList
    {
        public class Node
        {
            internal object data;
            internal Node nextElement;


            public Node()
            {
                nextElement = null;
            }
        };
        private Node head;
        internal int Length;

        public LinkedList()
        {
            head = null;
            Length = 0;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool DetectLoop()
        {
            Node traversingNode = head;
            Node referenceNode = new Node();

            while (traversingNode != null)
            {

            }
            return false;
        }

        internal Node GetLength()
        {
            Node currentnode = head;
            while (currentnode != null)
            {
                Length++;
                currentnode = currentnode.nextElement;
            }
            return currentnode;
        }

        internal Node RemoveDuplicates()
        {
            Node mainNode = head;
            LinkedList returninglist = new LinkedList();

            while (mainNode != null)
            {
                if (!returninglist.Find((int)mainNode.data))
                {
                    returninglist.InsertAtEnd((int)mainNode.data);
                }
                mainNode = mainNode.nextElement;
            }
            return returninglist.head;
        }

        internal Node FindMiddle()
        {
            Node currentNode = head;
            Node fastNode = head;

            while (currentNode != null)
            {
                currentNode = currentNode.nextElement;
                fastNode = fastNode.nextElement.nextElement;
                if (fastNode == null || fastNode.nextElement == null)
                {
                    break;
                }
            }
            return currentNode;
        }

        internal Node FindNth_node(int traverseTo)
        {
            Node currentNode = head;
            if (traverseTo == 1)
            {
                return currentNode;
            }
            while (traverseTo > 1)
            {
                currentNode = currentNode.nextElement;
                traverseTo--;
            }
            return currentNode;
        }
        internal void Print(Node reversdlist)
        {
            while (reversdlist != null)
            {
                Console.Write("Value - " + reversdlist.data + "\n");
                reversdlist = reversdlist.nextElement;
            }
        }

        internal Node Reverse()
        {
            Node currentNode = head;
            Node StackedNode = null;

            while (currentNode != null)
            {
                Node tempNode = currentNode.nextElement;
                currentNode.nextElement = StackedNode;
                StackedNode = currentNode;
                currentNode = tempNode;

            }
            head = StackedNode;
            return head;
        }

        public void InsertAtHead(int value)
        {
            Node newnode = new Node
            {
                data = value,
                nextElement = head
            };
            head = newnode;
            Console.WriteLine(value + " Inserted!");
        }
        public void InsertAtEnd(int value)
        {
            if (IsEmpty())
            {
                InsertAtHead(value);
            }
            else
            {
                Node newnode = new Node { data = value };
                Node traversingNode = head;
                while (traversingNode.nextElement != null)
                {
                    traversingNode = traversingNode.nextElement;
                }
                traversingNode.nextElement = newnode;
                Console.Write(value + " Inserted!    \n");
            }
        }

        public bool DeleteAtHead()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return false;
            }

            head = head.nextElement;
            return true;
        }
        internal bool Delete(int value)
        {
            bool deleted = false;
            if (IsEmpty())
            {
                return deleted;
            }
            Node currentNode = head;
            if ((int)currentNode.data == value)
            {
                DeleteAtHead();
                return true;
            }
            Node previousNode = currentNode;
            currentNode = currentNode.nextElement;
            while (currentNode != null)
            {
                if (value == (int)currentNode.data)
                {
                    previousNode.nextElement = currentNode.nextElement;
                    deleted = true;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.nextElement;
            }
            if (deleted)
            {
                Console.WriteLine("Deleted !!!!");
                return true;
            }
            else
            {
                Console.WriteLine("Doesnt exist");
                return false;
            }
        }

        internal bool Find(int value)
        {
            if (IsEmpty())
            {
                return false;
            }
            Node temp = head;
            while (temp != null)
            {
                if ((int)temp.data == value)
                {
                    return true;
                }
                temp = temp.nextElement;
            }
            return false;
        }
    }
}
