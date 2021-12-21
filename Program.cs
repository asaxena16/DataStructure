using System;
using static DataSctructure.LinkedList;

namespace DataSctructure
{
    class Program
    {
        static void Main()
        {
            LinkedList list = PopulateLinkedList();

            //BasicOperationonLinkedList();
            //FindOneByNthofLinkedList();
            // MIDDLE_OF_THE_LINKED_LIST(list);
            //REVERSE_LINKED_LIST(list);

            FIND_LENGTH_LL(list);
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

        private static void FindOneByNthofLinkedList()
        {
            #region PopulateLinkedList
            LinkedList list = new LinkedList();
            for (int i = 0; i < 20; i++)
            {
                list.InsertAtEnd(i);
            }
            #endregion

            //FIND 1/2 OF LL

        }

        private static void BasicOperationonLinkedList()
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
