using System;
namespace DataSctructure
{
    class Program
    {
        static void Main()
        {
            //BasicOperationonLinkedList();

            //FindOneByNthofLinkedList();
            MIDDLE_OF_THE_LINKED_LIST();
        }

        private static void MIDDLE_OF_THE_LINKED_LIST()
        {
            #region PopulateLinkedList
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            for (int i = 0; i < 18; i++)
            {
                list.InsertAtEnd(i);
            }
            #endregion

            LinkedList.LinkedList.Node node = list.FindMiddle();
            Console.WriteLine("Middle of Linked List is - " + node.data);
        }

        private static void FindOneByNthofLinkedList()
        {
            #region PopulateLinkedList
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            for (int i = 0; i < 20; i++)
            {
                list.InsertAtEnd(i);
            }
            #endregion

            //FIND 1/2 OF LL

        }

        private static void BasicOperationonLinkedList()
        {
            LinkedList.LinkedList list = new LinkedList.LinkedList();
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
