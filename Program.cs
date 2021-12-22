using System;
using static DataSctructure.LinkedList;

namespace DataSctructure
{
    class Program
    {
        static void Main()
        {
            LinkedList list = PopulateLinkedList();

            BASICOPERATIONONLINKEDLIST();
            int n = 2;
            //TODO - DISCUSS WITH HIMANSHU
            FINDONEBYNTHOFLINKEDLIST(n, list);

            MIDDLE_OF_THE_LINKED_LIST(list);

            REVERSE_LINKED_LIST(list);
            
            FIND_LENGTH_LL(list);

            //TODO
            //DETECT_LOOP(list);
        }

        private static void DETECT_LOOP(LinkedList list)
        {
            bool loopPresent = list.DetectLoop();
            Console.WriteLine("Loop Present ? " + loopPresent);
        }

        private static void FIND_LENGTH_LL(LinkedList list)
        {
            list.GetLength();
            Console.WriteLine("Length of Linked List is " + list.Length);
        }

        private static LinkedList PopulateLinkedList()
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 10; i++)
            {
                list.InsertAtEnd(i);
            }
            Console.WriteLine("\n");
            return list;
        }

        private static void REVERSE_LINKED_LIST(LinkedList list)
        {
            Node reversdlist = list.Reverse();
            list.Print(reversdlist);
        }

        private static void MIDDLE_OF_THE_LINKED_LIST(LinkedList list)
        {

            Node node = list.FindMiddle();
            Console.WriteLine("Middle of Linked List is - " + node.data);
        }

        private static void FINDONEBYNTHOFLINKEDLIST(int n, LinkedList list)
        {
            list.GetLength();
            var traverseTo = list.Length / n;
            if (traverseTo > 0)
            {
                Node nthnode = list.FindNth_node(traverseTo);
                Console.WriteLine(" Nth node is  - " + nthnode.data);
            }
            else
            {
                Console.WriteLine(" Nth Node doesnt exist !");
            }

        }

        private static void BASICOPERATIONONLINKEDLIST()
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    list.InsertAtHead(i);
                }

                list.InsertAtEnd(i);
            }

            Console.WriteLine("Value is Present - " + list.Find(5));
            list.DeleteAtHead();
            list.Delete(5);
        }
    }
}
